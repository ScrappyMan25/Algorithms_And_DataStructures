using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<string> stringTree = new BSTree<string>();
            //readFile("textFile.txt");
            readFile("textFile.txt", stringTree);
            System.Console.WriteLine($"Tree: {stringTree.PreOrder()}");
            System.Console.WriteLine($"Number of Words : {stringTree.Count()}");
            System.Console.WriteLine($"Height of Tree : {stringTree.Height()}");
            System.Console.ReadKey();
        }

        static void readFile(string fileName)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName);


            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                    if (word != "")
                        Console.WriteLine(word.ToLower());
            }
        }
        static void readFile(string fileName, BSTree<string> tree)
        {
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines(fileName);


            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] words = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string word in words)
                    if (word != "")
                        tree.InsertItem(word.ToLower());
            }
        }

    }
}
