using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Text_Analyzer_GUI
{
    internal class TextAnalyzer
    {
        private String text;
        public List<String> words = new List<String>();
        public List<String> uniqueWords = new List<String>();
        public String Text
        {
            get { return text; }
            set { text = value; }
        }


        public TextAnalyzer(string text)
        {
            Text = text;
        }

        public int NumOfSentences()
        {
            int sentenceCount = 0;

            string[] delimiterChars = { ".", "?", "!" };

            string[] words = text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

            System.Console.WriteLine($"{words.Length} substrings in text:");

            sentenceCount = (int)words.Length;

            return sentenceCount;
        }

        public int NumOfWords()
        {
            int wordCount = 0, index = 0;

            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            return wordCount;

        }

        public int NumOfUniqueWords()
        {

            string concat = string.Join(" ", uniqueWords.ToArray());
            //

            int wordCount = 0, index = 0;

            while (index < concat.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < concat.Length)
            {
                // check if current char is part of a word
                while (index < concat.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < concat.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            return wordCount;
        }

        public void BuildUniqueList()
        {

            foreach (var item in words)
            {
                if (uniqueWords.Contains(item) == false) 
                {
                    uniqueWords.Add(item);
                }
                
            }    

        }

        public void BuildList()
        {

            string[] splittedStringArray = text.Split(' ');

            foreach (string stringInArray in splittedStringArray)
            {
                words.Add(stringInArray);
            }
        }


        public void RemovePunctuation()
        {
            text = Regex.Replace(text.ToLower(), @"[^\w\s]", "");
        }


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
