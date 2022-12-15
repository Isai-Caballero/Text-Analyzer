using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Analyzer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxTest.Clear();
            lblNumOfSent.Text = "";
            lstBxUnique.Items.Clear();

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            lstBxUnique.Items.Clear();
            try
            {
                if (txtBoxTest.Text == "") {
                    throw new Exception();
                }
                var text = txtBoxTest.Text;
                var textAnalysis = new TextAnalyzer(text);

                //separate var for num of sentences
                var numSentences = textAnalysis.NumOfSentences();

                textAnalysis.RemovePunctuation();
                textAnalysis.BuildList();
                textAnalysis.BuildUniqueList();


                lblNumOfSent.Text = $"Number of sentences: {numSentences}\n" +
                    $"Total number of words: {textAnalysis.NumOfWords()}\n" +
                    $"Total number of unique words: {textAnalysis.NumOfUniqueWords()}";

                // counts instances of unique words in 'words' list
                int iterator = 0;
                foreach (var item in textAnalysis.uniqueWords)
                {

                    int count = textAnalysis.words.Where(x => x.Equals(item)).Count();
                    lstBxUnique.Items.Add($"{textAnalysis.uniqueWords[iterator]} occurs {count} times.");

                    iterator++;
                }
            } catch
            {
                MessageBox.Show("Input text!");
                txtBoxTest.Clear();
                lblNumOfSent.Text = "";
                lstBxUnique.Items.Clear();
            }
            
        }
    }
}
