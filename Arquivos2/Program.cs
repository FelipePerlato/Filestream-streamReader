using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {

        string caminho = @"C:\Users\Felipe\Desktop\PROJETOS\file1.txt";

        FileStream fs = null;

        StreamReader sr = null;

        try
        {

            sr = File.OpenText(caminho);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            

            
        }
        catch(IOException e)
        {
            Console.WriteLine("ocorreu um erro");
            Console.WriteLine(e.Message);

        }

       
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}