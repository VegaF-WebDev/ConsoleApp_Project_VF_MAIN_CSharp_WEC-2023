using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_070923
{
    class Pertemuan1 : Setelan
    {
        public void P1A()
        {
            //JUDUL

            string titleP1A = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP1A);

            //DAFTAR1
            string daftar1 = ("NIM            :");
            string daftar2 = ("NAMA           :");
            string daftar3 = ("TTL            :");
            string daftar4 = ("ALAMAT         :");
            string daftar5 = ("JK             :");
            string daftar6 = ("KELAS          :");
            string daftar7 = ("KETERANGAN     :");

            //DAFTAR2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 12);
            Console.Write(daftar1);
            Console.SetCursorPosition(25, 13);
            Console.Write(daftar2);
            Console.SetCursorPosition(25, 14);
            Console.Write(daftar3);
            Console.SetCursorPosition(25, 15);
            Console.Write(daftar4);
            Console.SetCursorPosition(25, 16);
            Console.Write(daftar5);
            Console.SetCursorPosition(25, 17);
            Console.Write(daftar6);
            Console.SetCursorPosition(25, 18);
            Console.Write(daftar7);

            //ISI
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(daftar1.Length + 25, 12);
            Console.Write("2023120084");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(daftar2.Length + 25, 13);
            Console.Write("VEGA FEBRILIANANDA");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(daftar3.Length + 25, 14);
            Console.Write("KEPANJEN, 20 FEBRUARI 2003");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(daftar4.Length + 25, 15);
            Console.Write("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(daftar5.Length + 25, 16);
            Console.Write("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(daftar6.Length + 25, 17);
            Console.Write("");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(daftar7.Length + 25, 18);
            Console.Write("");

            Console.ReadLine();
        }
        public void P1B()
        {
            //JUDUL

            string titleP1B = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP1B);

            //DAFTAR1
            string daftar1 = ("NIM            :");
            string daftar2 = ("NAMA           :");
            string daftar3 = ("TTL            :");
            string daftar4 = ("ALAMAT         :");
            string daftar5 = ("JK             :");
            string daftar6 = ("KELAS          :");
            string daftar7 = ("KETERANGAN     :");

            //DAFTAR2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 12);
            Console.Write(daftar1);
            Console.SetCursorPosition(25, 13);
            Console.Write(daftar2);
            Console.SetCursorPosition(25, 14);
            Console.Write(daftar3);
            Console.SetCursorPosition(25, 15);
            Console.Write(daftar4);
            Console.SetCursorPosition(25, 16);
            Console.Write(daftar5);
            Console.SetCursorPosition(25, 17);
            Console.Write(daftar6);
            Console.SetCursorPosition(25, 18);
            Console.Write(daftar7);

            //ISI
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(daftar1.Length + 25, 12);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(daftar2.Length + 25, 13);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(daftar3.Length + 25, 14);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(daftar4.Length + 25, 15);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(daftar5.Length + 25, 16);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(daftar6.Length + 25, 17);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(daftar7.Length + 25, 18);
            Console.ReadLine();

            //KONFIRMASI1
            Console.ForegroundColor = ConsoleColor.Yellow;
            string confirm = "APAKAH SUDAH SELESAI :";
            Console.SetCursorPosition(25, 20);
            Console.Write(confirm);

            //KONFIRMASI2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(confirm.Length + 25, 20);
            Console.ReadLine();

            //AKHIR
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(25, 21);
            Console.Write("TERIMA KASIH, SUDAH SELESAI");

            Console.ReadLine();
        }
        public void info()
        {
            //JUDUL
            ClearCenter();
            string kata = "INFORMASI SOAL :";
            string value = "1. Kerjakan SOAL 1A dan SOAL 1B pada pertemuan PERTAMA.";
            string value2 = "2. Hasil akan dinilai pada pertemuan KEDUA.";
            string value3 = "3. Point mengerjakan soal ini adalah 5.";
            string value4 = "4. Mintalah soal tambahan ke dosen jika merasa kurang.";
            string value5 = "5. Usahakan utk mengerjakan sendiri sblm bertanya.";
            string value6 = "Keywords :";
            string value7 = "- Console.Write,Console.ForegroundColor,Console.Clear";
            string value8 = "- Console.WriteLine,Console.Read,Console.ReadLine";
            string value9 = "- Console.BackgroundColor,Console.SetCursorPosition";
            TulisTengahWarna(kata, 22, 117, 8, ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(22, 11);
            Console.Write(value);
            Console.SetCursorPosition(22, 12);
            Console.Write(value2);
            Console.SetCursorPosition(22, 13);
            Console.Write(value3);
            Console.SetCursorPosition(22, 14);
            Console.Write(value4);
            Console.SetCursorPosition(22, 15);
            Console.Write(value5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(22, 16);
            Console.Write(value6);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(22, 17);
            Console.Write(value7);
            Console.SetCursorPosition(22, 18);
            Console.Write(value8);
            Console.SetCursorPosition(22, 19);
            Console.Write(value9);
            Console.ReadLine();
        }
        public void menu()
        {
            ClearArea(1, 7, 18, 22);
            //REG MENU
            string[] menu = new string[4] { "INFO", "SOAL 1A", "SOAL 1B", "MENU UTAMA" };
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
                            TulisTengah(22, 117, 13, "Kembali ke menu utama?");
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
                            TulisTengah(22, 117, 13, "Kembali ke menu utama?");
                        }
                        break;
                }
            }
            while (tom.Key != ConsoleKey.Enter);

            switch (idx)
            {
                case 0:
                    ClearArea(22, 8, 118, 21);
                    info();
                    goto atas1;
                    break;
                case 1:
                    ClearArea(22, 8, 118, 21);
                    P1A();
                    goto atas1;
                    break;
                case 2:
                    ClearArea(22, 8, 118, 21);
                    P1B();
                    goto atas1;
                    break;
                case 3:
                    ClearArea(1, 7, 18, 22);
                    ClearArea(22, 8, 118, 21);
                    break;
            }
        }
    }
}
