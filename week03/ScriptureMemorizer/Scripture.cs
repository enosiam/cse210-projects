using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            string[] wordArray = text.Split(' ');
            foreach (string word in wordArray)
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            int wordsHidden = 0;

            // First try to hide words that aren't already hidden
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            
            while (wordsHidden < numberToHide && visibleWords.Count > 0)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
                wordsHidden++;
            }

            // If we still need to hide more words (all were already hidden), just return
        }

        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + "\n\n";
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText.Trim();
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}