using System;
using System.Collections.Generic;
using RendObj;

namespace Printers
{
    public interface IPrinter
    {
        void Print(List<FileObj> files);
    }




    public class EasyPrinter : IPrinter
    {
        void IPrinter.Print(List<FileObj> files)
        {
            int i = 0;
            foreach (var fi in files)
            {
                Console.WriteLine(i + " " + fi.ToString().Split('~')[0]);
                i++;
            }
        }
    }

    public class Printer : IPrinter
    {
        void IPrinter.Print(List<FileObj> files)
        {
            string[] data;
            foreach (var file in files)
            {
                data = file.ToString().Split('~');
                Console.Write(file.GetForm(), data[0], data[1], data[2], data[3]);
            }
        }
    }
}
