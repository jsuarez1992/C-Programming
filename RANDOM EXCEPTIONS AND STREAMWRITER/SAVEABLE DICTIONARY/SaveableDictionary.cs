using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise005
{

    public class SaveableDictionary
    {
        public Dictionary<string, string> dict;
        public string file { get; set; }
        public List<string> addWords;

        public SaveableDictionary()
        {
            this.dict = new Dictionary<string, string>();
            this.addWords = new List<string>();
        }
        public SaveableDictionary(string file) : this()
        {
            this.file = file;
        }
        public void Add(string words, string translation)
        {
            if (!this.dict.ContainsKey(words))
            {
                this.dict.Add(words, translation);
                this.dict.Add(translation, words);
            }
        }
        public string Translate(string word)
        {
            if (this.dict.ContainsKey(word))
            {
                return this.dict[word];
            }
            return null;
        }
        public void Delete(string word)
        {
            this.dict.Remove(this.dict[word]);
            this.dict.Remove(word);
        }
        public bool Load()
        {
            try
            {
                string[] files = File.ReadAllLines(this.file);

                foreach (string line in files)
                {
                    string[] splitit = line.Split(":");
                    Add(splitit[0], splitit[1]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Save()
        {
            try
            {
                StreamWriter writer = new StreamWriter(this.file);
                foreach (KeyValuePair<string,string> kvp in this.dict)
                {
                    if (!addWords.Contains(kvp.Key) || !addWords.Contains(kvp.Value) )
                    {
                        this.addWords.Add(kvp.Key);
                        this.addWords.Add(kvp.Value);
                        writer.WriteLine(kvp.Key + ":" + kvp.Value);
                    }

                }
                writer.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
