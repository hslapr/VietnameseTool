using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Manh.Applications.VietnameseTool
{
    public class AppDbContext : IDisposable
    {
        private SQLiteConnection connection;

        private int lastWordId;
        private int lastExampleId;




        public AppDbContext(string connectionString)
        {
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "PRAGMA foreign_keys = ON"; // Sqlite3默认不支持foreign key，需要用这条命令开启
            command.ExecuteNonQuery();
            // 獲取原始的狀態
            command.CommandText =
                @"SELECT COUNT(id) FROM words";
            lastWordId = Convert.ToInt32(command.ExecuteScalar());
            command.CommandText =
                @"SELECT COUNT(id) FROM examples";
            lastExampleId = Convert.ToInt32(command.ExecuteScalar());
        }

        public void CreateWordsTable()
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"CREATE TABLE IF NOT EXISTS words(" +
                "id INTEGER PRIMARY KEY," +
                "word TEXT NOT NULL UNIQUE," +
                "note TEXT NOT NUll" +
                ")";
            command.ExecuteNonQuery();
        }

        public void CreateExamplesTable()
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"CREATE TABLE IF NOT EXISTS examples(" +
                "id INTEGER PRIMARY KEY," +
                "text TEXT NOT NUll UNIQUE," +
                "note TEXT" +
                ")";
            command.ExecuteNonQuery();
        }

        public void CreateWordWithExamplesTable()
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"CREATE TABLE IF NOT EXISTS word_with_examples(" +
                "id INTEGER PRIMARY KEY," +
                "word_id INTEGER NOT NULL," +
                "example_id INTEGER NOT NULL," +
                "UNIQUE (word_id, example_id)," +
                "FOREIGN KEY (word_id) REFERENCES words(id) ON DELETE CASCADE," +
                "FOREIGN KEY (example_id) REFERENCES examples(id) ON DELETE CASCADE" +
                ")";
            command.ExecuteNonQuery();
        }
        public void InsertWordNote(string word, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO words (word, note) VALUES ($word, $note)";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$note", note);
            command.ExecuteNonQuery();
        }

        public void DeleteWord(string word)
        {
            Delete("words", "word", word);
        }

        public void Delete(string table, string column, string value)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                $"DELETE FROM {table} WHERE {column} = $value";
            command.Parameters.AddWithValue("$value", value);
            command.ExecuteNonQuery();
        }

        public void Update(string table, string keyColumn, string keyValue, string column, string value)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                $"UPDATE {table} SET {column} = $value WHERE {keyColumn} = $keyValue";
            command.Parameters.AddWithValue("$value", value);
            command.Parameters.AddWithValue("$keyValue", keyValue);
            command.ExecuteNonQuery();
        }

        public void UpdateExample(int id, string text, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                $"UPDATE examples SET text = $text, note = $note WHERE id = $id";
            command.Parameters.AddWithValue("$text", text);
            command.Parameters.AddWithValue("$note", note);
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public int UpdateExampleForWord(string word, int id, string text, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(id) FROM word_with_examples " +
                "WHERE word_id <> (SELECT id FROM words WHERE word = $word) AND " +
                "example_id = $example_id";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$example_id", id);
            if (Convert.ToInt32(command.ExecuteScalar()) == 0)
            {
                UpdateExample(id, text, note);
                return id;
            }
            else
            {
                command.CommandText = "DELETE FROM word_with_examples " +
                    "WHERE word_id = (SELECT id FROM words WHERE word = $word) AND " +
                    "example_id = $example_id";
                command.Parameters.AddWithValue("$word", word);
                command.Parameters.AddWithValue("$example_id", id);
                command.ExecuteNonQuery();
                return InsertExample(word, text, note);
            }
        }


        public void DeleteExample(int id)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                $"DELETE FROM examples WHERE id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public void DeleteExampleForWord(int exampleId, string word)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                "DELETE FROM word_with_examples " +
                "WHERE word_id = (SELECT id FROM words WHERE word = $word) " +
                "AND example_id = $example_id";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$example_id", exampleId);
            command.ExecuteNonQuery();
            command.CommandText = "SELECT COUNT(id) FROM word_with_examples " +
                "WHERE example_id = $example_id";
            command.Parameters.AddWithValue("$example_id", exampleId);
            if (Convert.ToInt32(command.ExecuteScalar()) == 0)
            {
                DeleteExample(exampleId);
            }
        }

        public int InsertExample(string word, string text, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO examples (text, note) VALUES ($text, $note)";
            command.Parameters.AddWithValue("$text", text);
            command.Parameters.AddWithValue("$note", note);
            command.ExecuteNonQuery();
            command.CommandText = "SELECT last_insert_rowid();";
            var id = Convert.ToInt32(command.ExecuteScalar());
            command.CommandText = "INSERT OR IGNORE INTO word_with_examples (word_id, example_id) VALUES (" +
                "(SELECT id FROM words WHERE word = $word), $example_id)";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$example_id", id);
            command.ExecuteNonQuery();
            return id;
        }

        public void InsertWordExampleRelation(string word, string text)
        {
            var command = connection.CreateCommand();
            command.CommandText = "INSERT OR IGNORE INTO word_with_examples (word_id, example_id) VALUES (" +
                "(SELECT id FROM words WHERE word = $word), (SELECT id FROM examples WHERE text = $text)) ";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$text", text);
            command.ExecuteNonQuery();
        }



        public void UpdateNote(string word, string note)
        {
            Update("words", "word", word, "note", note);
        }

        public void InsertOrUpdateWord(string word, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                "INSERT OR REPLACE INTO words (id, word, note) VALUES ((SELECT id FROM words WHERE word = $word), $word, $note)";
            command.Parameters.AddWithValue("$word", word);
            command.Parameters.AddWithValue("$note", note);
            command.ExecuteNonQuery();
        }

        public void InsertOrUpdateExample(string text, string note)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                "INSERT OR REPLACE INTO examples (id, text, note) VALUES ((SELECT id FROM examples WHERE text = $text), $text, $note)";
            command.Parameters.AddWithValue("$text", text);
            command.Parameters.AddWithValue("$note", note);
            command.ExecuteNonQuery();
        }

        public async Task<IEnumerable<string>> SelectWordsByPrefix(string prefix)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT word FROM words WHERE word LIKE $pattern ORDER BY length(word)";
            command.Parameters.AddWithValue("$pattern", $"{prefix}%");
            IList<string> list = new List<string>();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    var word = reader.GetString(0);
                    list.Add(word);
                }
            }
            return list;
        }

        public string SelectWordNote(string word)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT note FROM words WHERE word = $word";
            command.Parameters.AddWithValue("$word", word);
            var result = command.ExecuteScalar();
            return result?.ToString();
        }

        public string SelectExampleNote(string text)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT note FROM examples WHERE text = $text";
            command.Parameters.AddWithValue("$text", text);
            var result = command.ExecuteScalar();
            return result?.ToString();
        }

        public bool HasExample(string text)
        {
            return SelectExampleId(text) > -1;
        }

        public int SelectExampleId(string text)
        {
            var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT id FROM examples WHERE text = $text";
            command.Parameters.AddWithValue("$text", text);
            var result = command.ExecuteScalar();
            return result == null ? -1 : Convert.ToInt32(result);
        }

        public IEnumerable<string> SelectAllExamplesOfWord(string word)
        {
            var result = new List<string>();
            var command = connection.CreateCommand();
            command.CommandText =
                @"SELECT text FROM examples " +
                 "WHERE id IN (SELECT example_id FROM word_with_examples " +
                 "WHERE word_id = (SELECT id FROM words " +
                 "WHERE word = $word))";
            command.Parameters.AddWithValue("$word", word);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(reader.GetString(0));
                }
            }
            return result;
        }

        public void Dispose()
        {
            var words = new Dictionary<string, IList<string[]>>();
            var command = connection.CreateCommand();
            command.CommandText = "DROP VIEW IF EXISTS word_exid";
            command.ExecuteNonQuery();
            command.CommandText = "create view word_exid as select words.word, words.note, word_with_examples.example_id " +
                "from words left join word_with_examples " +
                "on words.id = word_with_examples.word_id " +
                $"where words.id > {lastWordId}";
            command.ExecuteNonQuery();
            command.CommandText = "select word_exid.word, word_exid.note, examples.text, examples.note " +
                "from word_exid left join examples " +
                "on word_exid.example_id = examples.id ";
            //command.Parameters.AddWithValue("$last_id", lastExampleId);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var word = reader.GetString(0);
                    var wordNote = reader.GetValue(1).ToString();
                    var example = reader.GetValue(2).ToString();
                    var exampleNote = reader.GetValue(3).ToString();
                    var arr = new string[] { wordNote, example, exampleNote };
                    if (!words.ContainsKey(word))
                    {
                        words.Add(word, new List<string[]>());
                    }
                    words[word].Add(arr);
                }
            }

            using (var writer = new StreamWriter(File.Open("new_data.txt",FileMode.Create), Encoding.UTF8))
            {
                foreach (var pair in words)
                {
                    writer.WriteLine($"**{pair.Key}** {pair.Value[0][0]}");
                    foreach (var arr in pair.Value)
                    {
                        if (arr[1].Length>0) writer.WriteLine(arr[1]);
                        if (arr[2].Length > 0) writer.WriteLine(arr[2]);
                    }
                }
            }
            connection.Close();
            connection.Dispose();
        }
    }
}
