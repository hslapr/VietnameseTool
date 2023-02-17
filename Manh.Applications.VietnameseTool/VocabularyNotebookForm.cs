using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manh.Applications.VietnameseTool
{
    public partial class VocabularyNotebookForm : Form
    {

        private AppDbContext dbContext;
        
        public AppDbContext DbContext
        {
            get
            {
                return dbContext;
            }
            set
            {
                dbContext = value;
                vocabularyNotebookControl.DbContext = dbContext;
            }
        }
        public VocabularyNotebookForm()
        {
            InitializeComponent();
        }

        public void SetWord(string word)
        {
            vocabularyNotebookControl.SetWord(word);
        }
    }
}
