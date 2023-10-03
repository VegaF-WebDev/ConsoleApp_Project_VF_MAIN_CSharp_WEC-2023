using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_MAIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Setelan st = new Setelan();
            //PASSBOX USERNAME1
            st.Border(0, 11, 119, 17, ConsoleColor.White);
            Console.ForegroundColor = ConsoleColor.White;
            string text1 = "USERNAME     : ";
            string text2 = "PASSWORD     : ";

            //PASSBOX USERNAME2
            Console.SetCursorPosition(2, 13);
            Console.Write(text1);
            Console.SetCursorPosition(2, 15);
            Console.Write(text2);
            
            //PASSBOX USERNAME3
            atas:
            st.TulisTengah(0, 119, 11, "VALIDASI USER");
            st.TextBoxPasif(text1.Length + 2, 15, 100, ConsoleColor.White, ConsoleColor.Blue);

            string username = st.TextBox(text1.Length + 2, 13, 100, ConsoleColor.White, ConsoleColor.Red, "biasa");
            string password = st.TextBox(text2.Length + 2, 15, 100, ConsoleColor.White, ConsoleColor.Red, "password");

            if (username == "vegaf2003" && password == "vf2003")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                st.FrontPage();
                st.Dashboard();
                st.MenuUtama();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                string text3 = "COBA LAGI";
                st.TulisTengah(0, 119, 18, text3);
                goto atas;
            }
            Console.ReadLine();
        }
    }
}
