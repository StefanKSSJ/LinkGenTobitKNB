using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Linkgenerator_Tobit_KNB
{
    class Program
    {
        static void Main(string[] args)
        {

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            

            // Append text to an existing file named "WriteLines.txt".

            int DavidURL=0;

            while(DavidURL<12000)
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(mydocpath, "WriteLines.txt"), true))
                {
                    if(DavidURL<10&&DavidURL>=0)
                    {
                        outputFile.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=0000" + DavidURL);
                        Console.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=0000" + DavidURL);
                        DavidURL++;
                        
                    }
                    if (DavidURL < 100 && DavidURL >= 10)
                    {
                        outputFile.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=000" + DavidURL);
                        Console.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=000" + DavidURL);
                        DavidURL++;
                    }
                    if (DavidURL < 1000 && DavidURL >= 100)
                    {
                        outputFile.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=00" + DavidURL);
                        Console.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=00" + DavidURL);
                        DavidURL++;
                    }
                    if (DavidURL < 10000 && DavidURL >= 1000)
                    {
                        outputFile.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=0" + DavidURL);
                        Console.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=0" + DavidURL);
                        DavidURL++;
                    }
                    if (DavidURL >= 10000)
                    {
                        outputFile.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=" + DavidURL);
                        Console.WriteLine("http://club.tobit.com/showkbArticle.asp?ArticleID=" + DavidURL);
                        DavidURL++;
                    }
                    else
                    { }
                        

                }
            }
            Console.WriteLine("Ende");

        }
    }
}
