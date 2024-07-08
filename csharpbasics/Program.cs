using csharpbasics;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        FileStreamExample fse = new FileStreamExample();

        // to create  and enter bytes in file
        // fse.CreateFile();


        // to read byte data from file
        // fse.GetDataFromFile();

        // to add string in file

        //  fse.CreateStreamWriter();

        // fse.GetDataFromStreamWriter(); // to read data from file in string format

        // fse.GetAllDataFromStreamWriter();

        //  fse.InsertAllDataUsingTextReader();


        fse.GetAllDataUsingTextReader();

    }
}