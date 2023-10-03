using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_MAIN
{
    class Pertemuan5: Setelan
    {
        public void P5A()
        {
            //JUDUL
            string titleP5A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(135, 0, 8, titleP5A1);
            string titleP5A2 = ("MEMBUAT SOROT VERTIKAL");
            TulisTengah(135, 0, 9, titleP5A2);

            //ARRAY VERTIKAL
            string[] array = new string[]
            {
                "MENU 1",
                "MENU 2",
                "MENU 3",
                "MENU 4",
                "KELUAR"
            };
            int num = 0;
            foreach (string kata2 in array)
            {
                TulisTengahWarna(kata2, 22, 117, 11 + num * 2, ConsoleColor.White);
                num++;
            }
            TulisTengahWarna(array[0], 22, 117, 11, ConsoleColor.Red);
            Console.SetCursorPosition(22, 22);
            Console.Write("PRESS ENTER...");
            int num2 = 0;
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 19);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
                {
                    TulisTengahWarna(array[num2], 22, 117, 11 + num2 * 2, ConsoleColor.White);
                    if (num2 == 0)
                    {
                        num2 = 4;
                    }
                    else
                    {
                        num2--;
                    }
                    TulisTengahWarna(array[num2], 22, 117, 11 + num2 * 2, ConsoleColor.Red);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                {
                    TulisTengahWarna(array[num2], 22, 117, 11 + num2 * 2, ConsoleColor.White);
                    if (num2 == 4)
                    {
                        num2 = 0;
                    }
                    else
                    {
                        num2++;
                    }
                    TulisTengahWarna(array[num2], 22, 117, 11 + num2 * 2, ConsoleColor.Red);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    switch (num2)
                    {
                        case 0:
                            TulisTengahWarna("                                           ", 22, 117, 21, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 1", 22, 117, 21, ConsoleColor.Red);
                            break;
                        case 1:
                            TulisTengahWarna("                                           ", 22, 117, 21, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 2", 22, 117, 21, ConsoleColor.Red);
                            break;
                        case 2:
                            TulisTengahWarna("                                           ", 22, 117, 21, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 3", 22, 117, 21, ConsoleColor.Red);
                            break;
                        case 3:
                            TulisTengahWarna("                                           ", 22, 117, 21, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 4", 22, 117, 21, ConsoleColor.Red);
                            break;
                    }
                }
                else
                {
                    TulisTengahWarna("TOMBOL YANG DITEKAN SALAH", 22, 117, 21, ConsoleColor.Red);
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter || num2 != 4);
            ClearCenter();
            TulisTengahWarna("SOAL 5A", 22, 117, 14, ConsoleColor.Red);
            Console.ReadLine();
            ClearArea(1, 7, 18, 22);
        }
        public void P5B()
        {
            //JUDUL
            string titleP5A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(135, 0, 8, titleP5A1);
            string titleP5A2 = ("MEMBUAT SOROT VERTIKAL");
            TulisTengah(135, 0, 9, titleP5A2);

            string[] array = new string[]
            {
                "MENU 1",
                "MENU 2",
                "MENU 3",
                "MENU 4",
                "KELUAR"
            };
            int num = 0;
            foreach (string value in array)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(49 + num * 8, 14);
                Console.Write(value);
                num++;
            }
            Console.SetCursorPosition(49, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(array[0]);
            Console.SetCursorPosition(22, 21);
            Console.Write("PRESS ENTER...");
            int num2 = 0;
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 19);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(49 + num2 * 8, 14);
                    Console.Write(array[num2]);
                    if (num2 == 0)
                    {
                        num2 = 4;
                    }
                    else
                    {
                        num2--;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(49 + num2 * 8, 14);
                    Console.Write(array[num2]);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(49 + num2 * 8, 14);
                    Console.Write(array[num2]);
                    if (num2 == 4)
                    {
                        num2 = 0;
                    }
                    else
                    {
                        num2++;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(49 + num2 * 8, 14);
                    Console.Write(array[num2]);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    switch (num2)
                    {
                        case 0:
                            TulisTengahWarna("                                           ", 22, 117, 19, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 1", 22, 117, 19, ConsoleColor.Red);
                            break;
                        case 1:
                            TulisTengahWarna("                                           ", 22, 117, 19, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 2", 22, 117, 19, ConsoleColor.Red);
                            break;
                        case 2:
                            TulisTengahWarna("                                           ", 22, 117, 19, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 3", 22, 117, 19, ConsoleColor.Red);
                            break;
                        case 3:
                            TulisTengahWarna("                                           ", 22, 117, 19, ConsoleColor.Red);
                            TulisTengahWarna("DIPILIH MENU 4", 22, 117, 19, ConsoleColor.Red);
                            break;
                    }
                }
                else
                {
                    TulisTengahWarna("TOMBOL YANG DITEKAN SALAH", 22, 117, 19, ConsoleColor.Red);
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter || num2 != 4);
            ClearCenter();
            TulisTengahWarna("SOAL 5B", 22, 117, 14, ConsoleColor.Red);
            Console.ReadLine();
        }
        public void info()
        {
            //JUDUL
            ClearCenter();
            string title_info = "HANYA INFO";
            TulisTengah(22, 117, 13, title_info);

            Console.ReadLine();
        }
        public void menu()
        {
            ClearArea(1, 7, 18, 22);
            //REG MENU
            string[] menu = new string[4] { "INFO", "SOAL 5A", "SOAL 5B", "MENU UTAMA" };
            int idx = 0;

        atas1:
            //menampilkan isi array
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i <= 3; i++)
            {
                TulisTengah(0, 20, (6 + (i * 2)), menu[i]);
            }
            
            //buat sorot utk menu pertama
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
            
            //keterangan awal
            ClearCenter();
            Console.ForegroundColor = ConsoleColor.Red;
            TulisTengah(22, 117, 13, menu[idx]);
            
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
                        if (idx < 3) { idx = idx + 1; } else { idx = 0; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearCenter();
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 3)
                        {
                            TulisTengah(22, 117, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 117, 13, "MAU KE MENU UTAMA?");
                        }
                        break;

                    case ConsoleKey.UpArrow: //panah atas
                        //warna ditinggalkan
                        Console.ForegroundColor = ConsoleColor.Green;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //ubah index
                        if (idx > 0) { idx = idx - 1; } else { idx = 3; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearCenter();
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 3)
                        {
                            TulisTengah(22, 117, 13, menu[idx]);
                        }
                        else
                        {
                            TulisTengah(22, 117, 13, "MAU KE MENU UTAMA?");
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
                    {
                        ClearCenter();
                        P5A();
                        break;
                    }
                    goto atas1;
                case 2:
                    ClearCenter();
                    P5B();
                    goto atas1;
                    break;
                case 3:
                    ClearArea(1, 7, 18, 22);
                    ClearCenter();
                    break;
            }
        }

    }
}