using System;
using System.Collections.Generic;

namespace Interfaces_Abstraction
{
    public interface IPrintable
    {
        void Print();
        void PrintToPdf();
    }
    public interface ISavable
    {
        void SaveToFile(string fileName);
    }
    public interface IDocument : ISavable, IPrintable
    {
        void CreateNewDocument();
    }
    public class PDFile : IDocument
    {
        public void CreateNewDocument()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void PrintToPdf()
        {
            throw new NotImplementedException();
        }

        public void SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
    public class ExcelFile : IPrintable, ISavable
    {
        public void Print()
        {
            
        }

        public void PrintToPdf()
        {
            
        }

        public void SaveToFile(string fileName)
        {
            
        }
    }
    public class Document : IPrintable,ISavable
    {
        public void PrintToPdf()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine();
        }

        public void SaveToFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrintable printable = new Document();
            printable = new ExcelFile();
            Print(new Document());
            Print(new ExcelFile());
            WriteAllElementsToConsole(new string[4]);
        }
        static void WriteAllElementsToConsole(IEnumerable<string> a)
        {
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        static void Print(IPrintable p)
        {
            p.Print();
        }
    }
}
