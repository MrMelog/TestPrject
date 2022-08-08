using System;
using System.Collections.Generic;
using System.IO;
using RendObj;



namespace Render_Prj
{

    class ProgStart
    {
        static void Main(string[] args)
        {
            IPrinter EzPrint = new EasyPrinter();
            IPrinter Print = new Printer();
            List<RenderObj> PickFi = new List<RenderObj>(); 

            Console.WriteLine(@"Enter the Path(like: C:\Users\tomfitz )");
            DirectoryInfo direct;
            FileInfo[] dirF;
            while (true) 
            {
                try
                {
                    string path = @Console.ReadLine();
                    direct = new DirectoryInfo(path);
                    dirF = direct.GetFiles();
                    break;
                }
                catch
                {
                    Console.WriteLine("Pls try again.");
                }
            }
            if (dirF.Length > 0)
            {
                List<RenderObj> Files = new List<RenderObj>();
                foreach (var fi in dirF)
                {
                    Files.Add(new RenderObj(fi));
                }
                EzPrint.Print(Files);
                Console.WriteLine("Enter the number of files. If u want close choise files enter 'end' ");
                string try_i = "";
                int num = -1;
                while (true)
                {
                    try_i = Console.ReadLine();
                    if (try_i.ToLower() == "end")
                        break;
                    while (!((int.TryParse(try_i, out num)) && num >= 0 && num <= dirF.Length - 1))
                    {
                        Console.WriteLine("Pls try again.");
                        try_i = Console.ReadLine();
                        
                    }
                    PickFi.Add(Files[num]);   
                }
                Print.Print(PickFi);
            }

            Console.ReadLine();
        }
    }
}
