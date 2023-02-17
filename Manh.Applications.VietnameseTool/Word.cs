using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Manh.Applications.VietnameseTool
{
    public class Word
    {
        private readonly string word;

        private string note;

        private readonly AppDbContext dbContext;

        public Word(AppDbContext dbContext, string word) : this(dbContext, word, null)
        {
        }



        public Word(AppDbContext dbContext, string word, string note)
        {
            this.dbContext = dbContext;
            this.word = word;
            var noteInDb = dbContext.SelectWordNote(word);
            if (note == null || noteInDb == note)
            {
                this.note = noteInDb;
            }
            else
            {
                Note = note;

            }
        }

        public IEnumerable<string> GetAllExamplesText()
        {
            return dbContext.SelectAllExamplesOfWord(word);
        }


        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
                if (value == null || value.Length == 0)
                {
                    dbContext.DeleteWord(this.ToString());
                }
                else
                {
                    dbContext.InsertOrUpdateWord(this.ToString(), value);
                }

            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            var other = (Word)obj;
            return this.ToString() == other.ToString();
        }

        public override int GetHashCode()
        {
            return ("[Word]" + word).GetHashCode();
        }

        public override string ToString()
        {
            return word;
        }

        public static implicit operator string(Word word) => word.ToString();

        public static bool operator ==(Word w1, Word w2)
        {
            if (w1 is null)
            {
                return w2 is null;
            }
            return w1.Equals(w2);
        }
        public static bool operator !=(Word w1, Word w2)
        {
            return !(w1 == w2);
        }


    }
}
