using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Linq;

namespace kurs
{
    class Normalizator
    {
        string separator = "";
        static List<string> punctuator = new List<string>();//роздільники, записані у файлі граматики
        static List<string> programKeywords = new List<string>();//усі ключові слова, які є в програмі
        static List<string> numbers = new List<string>();
        static Dictionary<string, string> keywordsDictionary = new Dictionary<string, string>();

        public Normalizator(string grammar_file_path)//розташування файлу з граматикою (роздільники + ключові слова)
        {
            ReadGrammar(grammar_file_path);//зчитуємо граматику
        }

        public string GetNormalizedCode(string code)
        {
            FindProgramKeywords(code);//шукаємо всі ключові слова, які є в програмі
            FillDictionary();//заповнюємо словник ключове слово - токен
            return NormalizeCode(code);//повертаємо нормалізований код
        }

        private string NormalizeCode(string code)//виконує нормалізацію коду
        {
            code = RemoveComments(code);//видалення коментарів
            code = RemoveText(code);//видалення не програмного тексту

            //кожне ключове слово замінюється на відповідний йому токен
            programKeywords.Sort(CompareStringLength);
            foreach (string s in programKeywords)
            {
                if (s.Length > 1)
                {
                    code = code.Replace(s, separator + keywordsDictionary[s]);
                }
                else
                {
                    if (keywordsDictionary.ContainsValue(s))
                    {
                        code = code.Replace(separator + s, separator + separator);
                        code = code.Replace(s, separator + keywordsDictionary[s]);
                        code = code.Replace(separator + separator, separator + s);
                    }
                    else
                    {
                        code = code.Replace(s, separator + keywordsDictionary[s]);
                    }
                }
            }

            //числа замінюються на токен, який відповідає типу int
            numbers.Sort(CompareStringLength);
            foreach (string s in numbers)
                code = code.Replace(s, "#number#");
            code = code.Replace("#number#.#number#", "#number#");
            code = code.Replace("#number#,#number#", "#number#");
            code = code.Replace("#number#", separator + keywordsDictionary["int"]);
            code = code.Replace(separator, "");

            //видалення відступів
            code = code.Replace(" ", "");
            code = code.Replace("\n", "");
            code = code.Replace("\r", "");

            return code;
        }

        private int CompareStringLength(string a, string b)//порівнює довжину двох рядків
        {
            if (a.Length == b.Length)
                return 0;
            if (a.Length > b.Length)
                return -1;
            return 1;
        }

        private void FillDictionary()//заповнює словник токенів
        {
            bool allKeyworsAdded = true;
            do
            {
                for (int i = 1; i < programKeywords.Count; ++i)
                {
                    if (!keywordsDictionary.ContainsKey(programKeywords[i]))
                    {
                        if (keywordsDictionary.ContainsKey(programKeywords[i - 1]))
                        {
                            keywordsDictionary.Add(programKeywords[i], keywordsDictionary[programKeywords[i - 1]]);
                        }
                        else
                        {
                            if (keywordsDictionary.ContainsKey(programKeywords[i + 1]))
                            {
                                keywordsDictionary.Add(programKeywords[i], keywordsDictionary[programKeywords[i + 1]]);
                            }
                            else
                            {
                                allKeyworsAdded = false;
                            }
                        }
                    }
                }
            }
            while (!allKeyworsAdded);
        }

        private void ReadGrammar(string path)//зчитує граматику з файлу
        {
            StreamReader sr = new StreamReader(path);

            separator = sr.ReadLine();//роздільник у файлі з граматикою

            //зчитує роздільники в мові програмування
            string line = sr.ReadLine();
            while (!line.Equals(separator))
            {
                punctuator.Add(line);
                line = sr.ReadLine();
            }

            //зчитує всі стандартні ключові слова
            line = sr.ReadLine();
            while (!line.Equals(separator))
            {
                string[] spl = line.Split(separator);
                string[] buf = spl[0].Split(' ');
                if (spl.Length > 1) 
                {
                    foreach(string s in buf)
                    {
                        if(!keywordsDictionary.ContainsKey(s))
                            keywordsDictionary.Add(s, spl[1]);
                    }
                }
                line = sr.ReadLine();
            }

            sr.Close();
        }

        private void FindProgramKeywords(string code)//пошук усіх використаних у програмі ключових слів
        {
            code = RemoveComments(code);//видалення коментарів
            code = RemoveText(code);//видалення не програмного тексту
            code = code.Replace("\n", " ");//видалення абзаців
            code = code.Replace("\r", " ");
            foreach (string s in punctuator)//видалення роздільників мови програмування
                code = code.Replace(s, " ");

            string[] splitCode = code.Split(' ');//тут знаходяться всі використані ключові слова
            foreach (string s in splitCode)//знаходить всі унікальні ключові слова
            {
                if (s.Length > 0 && !programKeywords.Contains(s))
                {
                    if (!IsNumber(s))
                    {
                        programKeywords.Add(s);
                    }
                    else 
                    { 
                        if(!numbers.Contains(s))
                            numbers.Add(s); 
                    }
                }
            }
        }

        private bool IsNumber(string n)//перевірка, чи є рядок числом
        {
            if (!Char.IsNumber(n[0]))
                return false;
            for (int i = 1; i < n.Length; ++i)
                if (!Char.IsNumber(n[i]))
                    return false;
            return true;
        }

        private string RemoveComments(string code)//видаляє коментарі
        {
            //видалення коментарів виду //текст
            while (code.Contains("//"))
            {
                int i = code.IndexOf("//");
                string buf1 = code.Substring(0, i);
                string buf2 = code.Remove(0, i + 2);
                i = buf2.IndexOf("\n");
                if (i != -1) buf2 = buf2.Remove(0, i);
                code = buf1 + buf2;
            }

            //видалення коментарів виду /*текст*/
            while (code.Contains("/*"))
            {
                int i = code.IndexOf("/*");
                string buf1 = code.Substring(0, i);
                string buf2 = code.Remove(0, i + 2);
                i = buf2.IndexOf("*/");
                if (i != -1) buf2 = buf2.Remove(0, i + 2);
                code = buf1 + "\n" + buf2;
            }

            return code;
        }

        private string RemoveText(string code)//видаляє не програмний текст
        {
            //видалення тексту виду "текст"
            code = code.Replace("\\\"", " ");
            while (code.Contains("\""))
            {
                int i = code.IndexOf("\"");
                string buf1 = code.Substring(0, i);
                string buf2 = code.Remove(0, i + 1);
                i = buf2.IndexOf("\"");
                if (i != -1) buf2 = buf2.Remove(0, i + 1);
                code = buf1 + buf2;
            }

            //видалення символів виду 'с'
            code = code.Replace("\\\'", " ");
            while (code.Contains("\'"))
            {
                int i = code.IndexOf("\'");
                string buf1 = code.Substring(0, i);
                string buf2 = code.Remove(0, i + 1);
                i = buf2.IndexOf("\'");
                if (i != -1) buf2 = buf2.Remove(0, i + 1);
                code = buf1 + buf2;
            }

            return code;
        }
    }
}
