using System;
using System.IO;
using System.Text;

namespace _3._2
{
    class Test
    {
        public static void Main()
        {
            string pathin = @"D:\кк\txt\input.txt";

            StreamReader f = new StreamReader(pathin);
            string v = f.ReadLine();

            string path = @"D:\кк\txt\output.txt";

            
            if (!File.Exists(path))
            {
                
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }

            string text = "";
            string[] arrStr = new string[2];
            string[] split = v.Split(new Char[] { '!' });                                  //БУЛО
            int i = 0;
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {

                    arrStr[i] = s;
                    i++;
                    text = s;                                                              //СТАЛО
                    break;
                }
            }
            string str = "";
            try
            {
                using (StreamReader sr = new StreamReader(pathin))
                {
                    sr.ReadLine();
                    str = sr.ReadToEnd(); 
                }
                using (StreamWriter sw = new StreamWriter(@"D:\кк\txt\tt"))
                {
                    sw.WriteLine(str); 
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
            }
            Console.WriteLine(str);
            Console.ReadKey();
            File.AppendAllText(path, text);
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}

