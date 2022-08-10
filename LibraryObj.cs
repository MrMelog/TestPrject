using System;
using System.IO;

namespace RendObj
{
    public abstract class FileObj
    {
        private string _fullname = String.Empty;
        private Int64 _lenght;
        private string _extension = String.Empty;
        private string _name = String.Empty;
        protected string _form;

        public FileObj(FileInfo fileInf)
        {
            _fullname = fileInf.FullName;
            _lenght = fileInf.Length;
            _extension = fileInf.Extension;
            _name = fileInf.Name;
        }

        public override string ToString()
        {
            string data =_name + "~" + _fullname + "~" + _extension + "~" + _lenght.ToString();
            return data;
        }

        public string GetForm()
        {
            return _form;
        }
    }


    public class RenderObj : FileObj
    {
        
        public RenderObj(FileInfo fileInf) : base(fileInf)
        {
            _form = "\nName: {0} \nPath: {1} \n" +
                "Format: {2} - image \nSize: {3} byte \n";
        }
    }
    public class OtherObj : FileObj
    {
        public OtherObj(FileInfo fileInf) : base(fileInf)
        {
            _form = "\n{0} - {2} - {3} byte \nPath: {1}\n";
        }
    }

}
