using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    internal class FileStreamExample
    {
        public void CreateFile()
        {
            String path = "E:\\demo.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);


            for (int i = 0; i <= 10; i++)
            {
                fs.WriteByte((byte)i);
            }
            fs.Close();

            Console.WriteLine("file created");
        }

        public void GetDataFromFile()
        {


            FileStream fss = new FileStream("E:\\demo.txt", FileMode.Append);
            int i = 0;
            while ((i = fss.ReadByte()) != -1)
            {
                Console.WriteLine((char)i);
            }
            fss.Close();
        }

        public void CreateStreamWriter()
        {

            Console.WriteLine("enter your name : ");

            String name = Console.ReadLine();

            FileStream fs = new FileStream("E:\\demoo.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("name : " + name);
            sw.Close();
            fs.Close();

            Console.WriteLine("file created");

        }

        public void GetDataFromStreamWriter()
        {
            FileStream fs = new FileStream("E:\\demoo.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            String data = sr.ReadToEnd();
            Console.WriteLine(data);

            sr.Close();
            fs.Close();
        }

        public void GetAllDataFromStreamWriter()
        {
            FileStream fs = new FileStream("E:\\demoo.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            String data = "";
            data = sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
            fs.Close();
        }

        // text reader method using TextReader

        public void InsertAllDataUsingTextReader()
        {
            using (TextWriter tr = File.CreateText("E:\\one.txt"))
            {
                tr.WriteLine("hello world");
                tr.WriteLine("how are you ");
                tr.WriteLine("this file is created by c#");

            }
            Console.WriteLine("data inserted successfully");

        }

        public void GetAllDataUsingTextReader()
        {
            using (TextReader tr = File.OpenText("E:\\one.txt"))
            {
               Console.WriteLine(tr.ReadToEnd());

            }
            Console.WriteLine("all data from file successfully");

        }


    }
}
