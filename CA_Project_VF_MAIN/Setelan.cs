using CA_Project_VF_260823;
using CA_Project_VF_310823;
using CA_Project_VF_MAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_070923
{
    class Setelan
    {
        public string TextBoxOri(int left, int top, int pjg, ConsoleColor wrnText, ConsoleColor wrnBack)
        {
            string n = "";

            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = wrnText;
            Console.BackgroundColor = wrnBack;

            //LAYOUT TEXTBOX
            for (int i = left; i <= (left + pjg); i++)
            {
                Console.Write(" ");
            }
            //KEMBALIKAN KURSOR KE DEPAN
            Console.SetCursorPosition(left, top);
            n = Console.ReadLine();
            return n;
        }
        public string TextBox(int left, int top, int pjg, ConsoleColor wrnText, ConsoleColor wrnBack, string tipe)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = wrnText;
            Console.BackgroundColor = wrnBack;
            //buat layout textbox nya
            for (int i = left; i <= (left + pjg); i++)
            {
                Console.Write(" ");
            }
            //kembalikan cursor ke depan
            Console.SetCursorPosition(left, top);
            Boolean full = false;
            ConsoleKeyInfo kar;
            string kata = "", katapass = "";
            do
            {
                kar = Console.ReadKey();
                if (kar.Key != null)
                {
                    if (kar.Key != ConsoleKey.Enter)
                    {
                        if (kar.Key == ConsoleKey.Backspace)
                        {
                            if (kata.Length > 0) //textbox msh ada isinya
                            {
                                if (kata.Length >= pjg) //apa pjgkata >= pjgtexbox
                                {
                                    if (kata.Length == pjg)
                                    {
                                        kata = kata.Substring(0, kata.Length - 1); //dipotong 1 digit dibelakang
                                        katapass = katapass.Substring(0, katapass.Length - 1); //dipotong 1 digit dibelakang
                                        //di lokasi potongan dicetak spasi kosong
                                        Console.SetCursorPosition(left + kata.Length, top);
                                        Console.Write(" ");
                                    }
                                    else //if(kata.Length > pjg)
                                    {
                                        kata = kata.Substring(0, pjg); //dipotong 1 digit dibelakang
                                        katapass = katapass.Substring(0, pjg); //dipotong 1 digit dibelakang
                                        //di lokasi potongan dicetak spasi kosong
                                        Console.SetCursorPosition(left + pjg, top);
                                        Console.Write(" ");                                        
                                    }
                                }
                                else
                                {
                                    kata = kata.Substring(0, kata.Length - 1); //dipotong 1 digit dibelakang
                                    katapass = katapass.Substring(0, katapass.Length - 1); //dipotong 1 digit dibelakang
                                    //di lokasi potongan dicetak spasi kosong
                                    Console.SetCursorPosition(left + kata.Length, top);
                                    Console.Write(" ");
                                }                                                              
                                //posisikan cursor di lokasi yang kosong
                                Console.SetCursorPosition(left + kata.Length, top);
                            }
                            else
                            {
                                Console.SetCursorPosition(left, top);
                            }
                        }
                        else
                        {
                            kata = kata + kar.KeyChar;
                            katapass = katapass + "*";
                        }
                    }

                    if (kata.Length >= pjg)
                    {                                              
                        if (tipe == "password")
                        {
                            if (kata.Length == pjg)
                            {
                                Console.SetCursorPosition(left + pjg - 1, top);
                                Console.Write("*");
                            }
                            else
                            {
                                Console.SetCursorPosition(left + pjg, top);
                                Console.Write("*");
                            }
                        }

                        Console.SetCursorPosition(left + pjg, top);
                        full = true;
                    }
                    else
                    {
                        if (tipe == "password")
                        {
                            Console.SetCursorPosition(left, top);
                            Console.Write(katapass);

                        }
                        Console.SetCursorPosition(left + kata.Length, top);                        
                    }
                }               
            }
            while(kar.Key != ConsoleKey.Enter);

            if(full == true)
            {
                kata = kata.Substring(0, pjg) + kata.Substring(kata.Length-1, 1);
            }

            return kata;
        }
        public void TextBoxPasif(int left, int top, int pjg, ConsoleColor wrnText, ConsoleColor wrnBack)
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = wrnText;
            Console.BackgroundColor = wrnBack;
            //buat layout textbox nya
            for (int i = left; i <= (left + pjg); i++)
            {
                Console.Write(" ");
            }
        }
        protected string PassBox(int left, int top, int pjg, ConsoleColor wrnText, ConsoleColor wrnBack, bool typepass)
        {
            string text = "";
            string text2 = "";
            string text3 = "";
            for (int i = 1; i <= pjg; i++)
            {
                text3 += " ";
            }
            Console.SetCursorPosition(left, top);
            Console.BackgroundColor = wrnBack;
            Console.ForegroundColor = wrnText;
            Console.Write(text3);
            Console.CursorVisible = true;
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                if (text.Length < pjg)
                {
                    Console.SetCursorPosition(left + text.Length, top);
                }
                else
                {
                    Console.SetCursorPosition(left + (pjg - 1), top);
                }
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.Backspace)
                {
                    if (text.Length >= 1 && text.Length < pjg)
                    {
                        text = text.Substring(0, text.Length - 1).Trim();
                        text2 = text2.Substring(0, text2.Length - 1).Trim();
                        Console.Write(" ");
                    }
                    else if (text.Length >= pjg)
                    {
                        text = text.Substring(0, text.Length - 1).Trim();
                        text2 = text2.Substring(0, text2.Length - 1).Trim();
                        Console.SetCursorPosition(left + pjg - 1, top);
                        Console.Write(" ");
                    }
                }
                else if (consoleKeyInfo.Key != ConsoleKey.Enter)
                {
                    text += consoleKeyInfo.KeyChar;
                    if (typepass)
                    {
                        text2 += "*";
                    }
                    else
                    {
                        text2 = text;
                    }
                    if (text.Length >= pjg)
                    {
                        text = text.Substring(0, pjg).Trim();
                        text2 = text2.Substring(0, pjg).Trim();
                    }
                    Console.SetCursorPosition(left, top);
                    Console.Write(text2);
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);
            return text;
        }
        public void ClearArea(int left1, int top1, int left2, int top2)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;

            for (int k = left1; k <= left2; k++)
            {
                for (int q = top1; q <= top2; q++)
                {
                    Console.SetCursorPosition(k, q);
                    Console.Write(" ");
                }
            }
        }
        public void Border(int left1, int top1, int left2, int top2, ConsoleColor wrnBorder)
        {
            Console.ForegroundColor = wrnBorder;

            //GARIS H
            for(int i=left1; i<= left2; i++)
            {
                Console.SetCursorPosition(i, top1);
                Console.Write("─");
                Console.SetCursorPosition(i, top2);
                Console.Write("─");
            }
            //GARIS V
            for (int j = (top1 + 1); j < top2; j++)
            {
                Console.SetCursorPosition(left1, j);
                Console.Write("│");
                Console.SetCursorPosition(left2, j);
                Console.Write("│");
            }
            //TUTUP POJOK KIRI ATAS
            Console.SetCursorPosition(left1, top1);
            Console.Write("┌");
            //TUTUP POJOK KIRI BAWAH
            Console.SetCursorPosition(left1, top2);
            Console.Write("└");
            //TUTUP POJOK KANAN ATAS
            Console.SetCursorPosition(left2, top1);
            Console.Write("┐");
            //TUTUP POJOK KANAN BAWAH
            Console.SetCursorPosition(left2, top2);
            Console.Write("┘");
        }
        public void FrontPage()
        {
            Console.CursorVisible = false;
            //BORDER ATAS
            Border(0, 0, 119, 5, ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string label1 = "LATIHAN MEMBUAT DASHBOARD C# CONSOLE";
            string label2 = "WEARNES EDUCATION CENTER";
            TulisTengah(0, 119, 2, label1);
            TulisTengah(0, 119, 3, label2);
            //BORDER TENGAH
            Border(0, 6, 119, 23, ConsoleColor.Yellow);
            //BORDER BAWAH
            Border(0, 24, 119, 29, ConsoleColor.Magenta);
            Console.ForegroundColor = ConsoleColor.Blue;
            string label3 = "VEGA FEBRILIANANDA";
            string label4 = "IK2 2023-2024";
            TulisTengah(0, 119, 26, label3);
            TulisTengah(0, 119, 27, label4);

            //WORDART
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(44, 8);
            Console.WriteLine("██████████              █████████");
            Console.SetCursorPosition(44, 9);
            Console.WriteLine(" █████         ███         █████");
            Console.SetCursorPosition(44, 10);
            Console.WriteLine("  █████       █████       █████");
            Console.SetCursorPosition(44, 11);
            Console.WriteLine("   █████     ███████     █████");
            Console.SetCursorPosition(44, 12);
            Console.WriteLine("    █████   █████████   █████");
            Console.SetCursorPosition(44, 13);
            Console.WriteLine("     █████   ███████   █████");
            Console.SetCursorPosition(44, 14);
            Console.WriteLine("      █████   █████   ████");
            Console.SetCursorPosition(44, 15);
            Console.WriteLine("       ██████████████████");
            Console.SetCursorPosition(44, 16);
            Console.WriteLine("        █████      █████");

            //BORDER LOADING
            Border(34, 19, 86, 21, ConsoleColor.Cyan);

            //LOADING BAR
            for (int l = 1; l <= 50; l++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.SetCursorPosition((35 + l), 20);
                Console.Write(" ");

                //PRESENTASE LOADING
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Black;
                //Console.SetCursorPosition(35, 20);
                //Console.Write(loading.Length + (l * 2) + "%");
                TulisTengah(0, 119, 18, "LOADING " + (l * 2) + "%");

                //KONSEP DELAY
                for (int j = 1; j <= 25000000; j++);
            }
            ClearArea(0, 0, 119, 29);
        }
        public void Dashboard()
        {
            //BORDER ATAS
            Border(0, 0, 119, 5, ConsoleColor.Green);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string label1 = "LATIHAN MEMBUAT DASHBOARD C# CONSOLE";
            string label2 = "WEARNES EDUCATION CENTER";
            TulisTengah(0, 119, 2, label1);
            TulisTengah(0, 119, 3, label2);

            //BORDER KIRI
            Border(0, 6, 19, 23, ConsoleColor.Cyan);
            
            //BORDER TENGAH
            Border(20, 6, 119, 23, ConsoleColor.Yellow);

            //BORDER BAWAH
            Border(0, 24, 119, 29, ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Blue;
            string label3 = "VEGA FEBRILIANANDA";
            string label4 = "IK2 2023-2024";
            TulisTengah(0, 119, 26, label3);
            TulisTengah(0, 119, 27, label4);
        }
        public void TulisTengah(int x1,int x2,int y1, string kata)
        {
            int pjgkta = kata.Length;
            int lebararea = (x2 - x1);
            int xCenter = (lebararea - pjgkta) / 2;
            Console.SetCursorPosition((x1 + xCenter), y1);
            Console.Write(kata);
        }
        public void TulisTengahWarna(string kata, int x1, int x2, int y1, ConsoleColor warna)
        {
            Console.ForegroundColor = warna;
            int length = kata.Length;
            int x3 = (x2 - x1 - length) / 2 + x1;
            Console.SetCursorPosition(x3, y1);
            Console.Write(kata);
        }
        public void ClearCenter()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            string text = " ";
            for (int i = 1; i <= 95; i++)
            {
                text += " ";
            }
            for (int j = 1; j <= 16; j++)
            {
                Console.SetCursorPosition(22, 6 + j);
                Console.Write(text);
            }
        }
        public void MenuUtama()
        {
            //ARRAY 1 DIMENSI
            string[] menu = new string[8] {"MENU UTAMA", "PART 1", "PART 2", "PART 3", "PART 4", "PART 5", 
                "WIP 6", "KELUAR" };
            int idx = 0;
        
            //MENAMPILKAN ISI ARRAY
        atasmenu:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i <= 7; i++)
            {
                TulisTengah(0, 20, (6 + (i * 2)), menu[i]);
            }
            
            //MEMBUAT SOROT UTK MENU UTAMA
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);

            //KETERANGAN AWAL
            ClearCenter();
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(22, 117, 13, menu[idx]);
            
            //GERAKAN SOROT SAAT KEYBOARD PANAH ATAS/BAWAH DITEKAN
            //KELUAR DARI PERULANGAN SAAT ENTER DITEKAN
            ConsoleKeyInfo tom;
            do
            {
                Console.CursorVisible = false;
                tom = Console.ReadKey();
                switch (tom.Key)
                {
                    case ConsoleKey.DownArrow:  //PANAH BAWAH

                        //WARNA DITINGGAL
                        Console.ForegroundColor = ConsoleColor.Green;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);

                        //ubah index
                        if (idx < 7)
                        {
                            idx = idx + 1;
                        }
                        else
                        {
                            idx = 0;
                        }

                        //WARNA SOROT = WARNA DILAJU
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);

                        //keterangan
                        ClearCenter();
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 7)
                        {
                            TulisTengah(22, 117, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 117, 13, "MAU KELUAR?");
                        }
                        break;

                    case ConsoleKey.UpArrow: //PANAH ATAS

                        //WARNA DITINGGAL
                        Console.ForegroundColor = ConsoleColor.Green;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);

                        //UBAH INDEX
                        if (idx > 0)
                        {
                            idx = idx - 1;
                        }
                        else
                        {
                            idx = 7;
                        }

                        //WARNA SOROT = WARNA DILAJU
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);

                        //keterangan
                        ClearArea(21, 8, 118, 21);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 7)
                        {
                            TulisTengah(22, 117, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 117, 13, "MAU KELUAR?");
                        }
                        break;
                }
            }
            while (tom.Key != ConsoleKey.Enter);

            //KELUAR DARI MENU            
            switch (idx)
            {
                case 0:

                    break;
                case 1:
                    Pertemuan1 p1 = new Pertemuan1();
                    Dashboard();
                    p1.menu();
                    goto atasmenu;
                    break;
                case 2:
                    Pertemuan2 p2 = new Pertemuan2();
                    Dashboard();
                    p2.menu();
                    goto atasmenu;
                    break;
                case 3:
                    Pertemuan3 p3 = new Pertemuan3();
                    Dashboard();
                    p3.menu();
                    goto atasmenu;
                    break;
                case 4:
                    Pertemuan4 p4 = new Pertemuan4();
                    Dashboard();
                    p4.menu();
                    goto atasmenu;
                    break;
                case 5:
                    Pertemuan5 p5 = new Pertemuan5();
                    Dashboard();
                    p5.menu();
                    goto atasmenu;
                    break;
                case 6:

                    break;
                case 7:
                    //keluar
                    break;
            }
        }
    }
}
