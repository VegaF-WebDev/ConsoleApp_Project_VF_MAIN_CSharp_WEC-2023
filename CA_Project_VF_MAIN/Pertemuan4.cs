using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_070923
{
    class Pertemuan4: Setelan
    {
        public void P4A()
        {
            //JUDUL
            string titleP2A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP2A1);
            string titleP2A2 = ("MEMBUAT LOADING SCREEN");
            TulisTengah(134, 0, 9, titleP2A2);
            
            //BORDER LOADING
            Border(42, 16, 93, 18, ConsoleColor.Cyan);

            //LOADING BAR
            for (int i=1; i<=50; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.SetCursorPosition((42 + i), 17);
                Console.Write(" ");

                //PRESENTASE LOADING
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(62, 14);
                Console.Write("LOADING..." + (i * 2) + "%");

                //KONSEP DELAY
                for (int k=1; k<=25000000; k++)
                {

                }
            }  
        }
        public void P4B()
        {
            //JUDUL
            string titleP2A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP2A1);
            string titleP2A2 = ("MEMBUAT FORM LOGIN VALIDASI USER");
            TulisTengah(134, 0, 9, titleP2A2);

            //PASSBOX USERNAME1
            Border(22, 11, 117, 16, ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
            string text1 = "USERNAME     : ";
            string text2 = "PASSWORD     : ";

            //PASSBOX USERNAME2
            Console.SetCursorPosition(25, 13);
            Console.Write(text1);
            Console.SetCursorPosition(25, 14);
            Console.Write(text2);

            //PASSBOX USERNAME3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = true;
            string str = PassBox(text1.Length + 25, 13, 12, ConsoleColor.Red, ConsoleColor.White, false);
            string str2 = PassBox(text2.Length + 25, 14, 14 , ConsoleColor.Red, ConsoleColor.White, true);
            Console.CursorVisible = false;
            
            //PASSBOX KONFIRMASI
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(25, 18);
            Console.Write("DATA LOGIN YANG DIKETIKAN : ");
            Console.SetCursorPosition(25, 19);
            Console.Write("USERNAME : " + str);
            Console.SetCursorPosition(25, 20);
            Console.Write("PASSWORD : " + str2);

            Console.ReadLine();
        }
        public void P4B_ALT()
        {
            //JUDUL
            string titleP2A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP2A1);
            string titleP2A2 = ("MEMBUAT FORM LOGIN VALIDASI USER");
            TulisTengah(134, 0, 9, titleP2A2);

            //PASSBOX USERNAME1
            Border(22, 13, 117, 19, ConsoleColor.White);
            Console.ForegroundColor = ConsoleColor.White;
            string text1 = "USERNAME     : ";
            string text2 = "PASSWORD     : ";

            //PASSBOX USERNAME2
            Console.SetCursorPosition(25, 15);
            Console.Write(text1);
            Console.SetCursorPosition(25, 17);
            Console.Write(text2);

            //PASSBOX USERNAME3
            atas5:
            TulisTengah(134, 0, 11, "Validasi User");
            TextBoxPasif(text1.Length + 25, 17, 20, ConsoleColor.White, ConsoleColor.Blue);

            string username = TextBox(text1.Length + 25, 15, 20, ConsoleColor.White, ConsoleColor.Red, "biasa");
            string password = TextBox(text2.Length + 25, 17, 20, ConsoleColor.White, ConsoleColor.Red, "password");

            if (username == "vegaf2003" && password == "vf2003")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                FrontPage();
                Dashboard();
                MenuUtama();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                goto atas5;
            }
            Console.ReadLine();
        }
        public void info()
        {
            //JUDUL
            string title_info = "HANYA INFO";
            TulisTengah(21, 100, 11, title_info);

            Console.ReadLine();
        }
        public void menu()
        {
            ClearArea(1, 7, 18, 22);
            //REG MENU
            string[] menu = new string[5] { "INFO", "SOAL 4A", "SOAL 4B", "ALT 4B", "MENU UTAMA" };
            int idx = 0;

        atas1:
            //menampilkan isi array
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i <= 4; i++)
            {
                TulisTengah(0, 20, (6 + (i * 2)), menu[i]);
            }
            //buat sorot utk menu pertama
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
            //keterangan awal
            ClearArea(21, 8, 118, 21);
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(22, 98, 13, menu[idx]);
            //gerakan sorot saat keyboard panah atas/bawah ditekan
            //keluar dari perulangan saat Enter ditekan
            ConsoleKeyInfo tom;
            do
            {
                tom = Console.ReadKey();
                switch (tom.Key)
                {
                    case ConsoleKey.DownArrow:  //panah bawah
                        //warna ditinggalkan
                        Console.ForegroundColor = ConsoleColor.Green;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //ubah index
                        if (idx < 4) { idx = idx + 1; } else { idx = 0; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearArea(21, 8, 118, 21);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 4)
                        {
                            TulisTengah(22, 98, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 98, 13, "Kembali ke menu utama?");
                        }
                        break;

                    case ConsoleKey.UpArrow: //panah atas
                        //warna ditinggalkan
                        Console.ForegroundColor = ConsoleColor.Green;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //ubah index
                        if (idx > 0) { idx = idx - 1; } else { idx = 4; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearArea(21, 8, 118, 21);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 4)
                        {
                            TulisTengah(22, 98, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 98, 13, "Kembali ke menu utama?");
                        }
                        break;
                }
            }
            while (tom.Key != ConsoleKey.Enter);

            switch (idx)
            {
                case 0:
                    info();
                    break;
                case 1:
                    ClearArea(22, 8, 118, 21);
                    P4A();
                    goto atas1;
                    break;
                case 2:
                    ClearArea(21, 8, 118, 21);
                    P4B();
                    goto atas1;
                    break;
                case 3:
                    ClearArea(21, 8, 118, 21);
                    P4B_ALT();
                    goto atas1;
                    break;
                case 4:
                    ClearArea(1, 7, 18, 22);
                    ClearArea(21, 8, 118, 21);
                    break;
            }
        }

    }
}
