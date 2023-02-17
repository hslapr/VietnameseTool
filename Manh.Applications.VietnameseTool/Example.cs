using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manh.Applications.VietnameseTool
{
    // 用来表示单词的例句或短语，对应数据库的examples表
    public sealed class Example
    {
        private int id;
        private string text;
        private string note;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (text != value)
                {
                    text = value;
                    int otherId = dbContext.SelectExampleId(text);
                    if (otherId == -1 || otherId == id)
                    {
                        Colliding = false;
                        Save();
                    }
                    else
                    {
                        Colliding = true;
                    }
                }

            }
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
                if (!Colliding)
                    Save();
            }
        }
        public Word Word { get; set; }

        // 用来检查当前Example是否语数据库中已经存在的example相冲突
        public bool Colliding { get; set; }

        private readonly AppDbContext dbContext;
        public Example(AppDbContext context, Word word, string text, string note)
        {
            dbContext = context;
            Word = word;
            this.text = text;
            Note = note;
            id = context.SelectExampleId(text);

        }

        public Example(AppDbContext context, Word word, string text)
        {
            dbContext = context;
            Word = word;
            this.text = text;
            id = context.SelectExampleId(text);
            if (id > -1)
            {
                note = context.SelectExampleNote(text);
            }
            else
            {
                note = null;
            }
        }

        public void Load()
        {
            dbContext.DeleteExampleForWord(id, Word.ToString());
            note = dbContext.SelectExampleNote(text);
            id = dbContext.SelectExampleId(text);
            Colliding = false;
            dbContext.InsertWordExampleRelation(Word.ToString(), text);
        }

        public Example(AppDbContext context, Word word)
        {
            dbContext = context;
            Word = word;
            id = -1;
        }


        private void Save()
        {
            if (id == -1 && text != null && text.Length > 0)
            {
                id = dbContext.InsertExample(Word, text, note);
            }
            else
            {
                if (id != -1 && (text == null || text.Length == 0))
                {
                    dbContext.DeleteExampleForWord(id, Word.ToString());
                    id = -1;
                }
                else if (id != -1)
                {
                    id = dbContext.UpdateExampleForWord(Word.ToString(), id, text, note);
                }
            }
        }

    }
}
