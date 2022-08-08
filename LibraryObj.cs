using System;
using System.IO;
using System.Collections.Generic;

namespace RendObj
{
    public class RenderObj
    {
        private string _fullname = String.Empty;
        private Int64 _lenght;
        private string _extension = String.Empty;
        private string _name = String.Empty;

        public RenderObj(FileInfo fileInf)
        {
            _fullname = fileInf.FullName;
            _lenght = fileInf.Length;
            _extension = fileInf.Extension;
            _name = fileInf.Name;
        }

        public string[] GetData()
        {
            string[] data = {_name, _fullname, _extension, _lenght.ToString()};
            return data;
        }

    }



    public interface IPrinter
    {
        void Print(List<RenderObj> files);
    }

    public class EasyPrinter : IPrinter
    {
        void IPrinter.Print(List<RenderObj> files)
        {
            int i = 0;
            foreach (var fi in files)
            {
                Console.WriteLine(i + " " + fi.GetData()[0]);
                i++;
            }
            
        }
    }

    public class Printer : IPrinter
    {
        void IPrinter.Print(List<RenderObj> files)
        {
            string[] data;
            foreach (var file in files)
            {
                data = file.GetData();
                Console.Write(
                    "\nName: {0} \n" +
                "Path: {1} \n" +
                "Format: {2} \n" +
                "Size: {3} byte \n", data[0], data[1], data[2], data[3]);
            
            }


             
        }


    }

}
