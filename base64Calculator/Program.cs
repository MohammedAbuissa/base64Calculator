using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace base64Calculator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("dilimiter");
            string Dilimiter = Console.ReadLine();
            LinkedList<string> Elements = new LinkedList<string>();
            string dummy;
            do
            {
                Console.WriteLine("enter text elements and empty line at the end");
                 dummy = Console.ReadLine();
                Elements.AddLast(dummy);
            } while (dummy != "");
            Elements.RemoveLast();
            StringBuilder sb = new StringBuilder();
            sb.Append(Elements.First());
            Elements.RemoveFirst();
            foreach (var item in Elements)
            {
                sb.Append(Dilimiter);
                sb.Append(item);
            }
            Clipboard.SetText(Convert.ToBase64String(Encoding.ASCII.GetBytes(sb.ToString())));
            Console.WriteLine("Copied to clip board");
            Console.WriteLine("press enter to exit");
            Console.Read();

        }
    }
}
