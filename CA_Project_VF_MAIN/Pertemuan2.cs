using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_260823
{
    class Pertemuan2: Setelan
    {
        public void P2A()
        {
            //STRING
            string NIM, NAMA, TTL, ALAMAT, JK, KELAS, KETERANGAN;

            //JUDUL

            string titleP2A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP2A1);
            string titleP2A2 = ("ISIKAN FORMULIR");
            TulisTengah(134, 0, 9, titleP2A2);

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
            NIM = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(daftar2.Length + 25, 13);
            NAMA = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(daftar3.Length + 25, 14);
            TTL = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(daftar4.Length + 25, 15);
            ALAMAT = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(daftar5.Length + 25, 16);
            JK = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(daftar6.Length + 25, 17);
            KELAS = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(daftar7.Length + 25, 18);
            KETERANGAN = Console.ReadLine();

            //AKHIR
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            string daftar8 = "ENTER UNTUK MELIHAT HASIL";
            TulisTengah(134, 0, 20, daftar8);

            Console.ReadLine();

            //TAMPILKAN HASIL
            Console.ReadLine();

            ClearCenter();
            //JUDUL

            string titleP2A3 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP2A3);
            string titleP2A4 = "HASIL FORMULIR";
            TulisTengah(134, 0, 9, titleP2A4);

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

            //HASIL
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(daftar1.Length + 25, 12);
            Console.Write(NIM);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(daftar2.Length + 25, 13);
            Console.Write(NAMA);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(daftar3.Length + 25, 14);
            Console.Write(TTL);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(daftar4.Length + 25, 15);
            Console.Write(ALAMAT);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(daftar5.Length + 25, 16);
            Console.Write(JK);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(daftar6.Length + 25, 17);
            Console.Write(KELAS);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(daftar7.Length + 25, 18);
            Console.Write(KETERANGAN);

            //AKHIR
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            string daftar9 = "TERIMA KASIH";
            TulisTengah(134, 0, 20, daftar9);

            Console.ReadLine();
        }
        public void P2B()
        {
            //JUDUL

            string titleP2A1 = "LATIHAN PROGRAM C# CONSOLE";
            TulisTengah(134, 0, 8, titleP2A1);
            string titleP2A2 = "HITUNG LUAS BANGUN DATAR";
            TulisTengah(134, 0, 9, titleP2A2);

            //PERTANYAAN1
            Console.ForegroundColor = ConsoleColor.Yellow;
            string daftar1 = "HITUNG LUAS LINGKARAN";
            string daftar2 = "HITUNG LUAS PERSEGI";
            string daftar3 = "HITUNG LUAS PERSEGI PANJANG";
            string daftar4 = "HITUNG LUAS SEGITIGA";
            string daftar5 = "HITUNG LUAS JAJAR GENJANG";

            //DAFTAR2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(25, 11);
            Console.Write(daftar1);
            Console.SetCursorPosition(25, 13);
            Console.Write(daftar2);
            Console.SetCursorPosition(25, 15);
            Console.Write(daftar3);
            Console.SetCursorPosition(25, 17);
            Console.Write(daftar4);
            Console.SetCursorPosition(25, 19);
            Console.Write(daftar5);

            //PERTANYAAN, JAWABAN & VARIABEL (LINGKARAN)
            
            double phi = 3.14;
            double r, LL;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(25, 12);
            Console.Write("PHI = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(31, 12);
            Console.Write(phi);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(45, 12);
            Console.Write("R = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(49, 12);
            double.TryParse(Console.ReadLine(),out r);

            LL = phi * (r * r);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 12);
            Console.Write("L = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(64, 12);
            Console.Write(LL);

            //PERTANYAAN, JAWABAN & VARIABEL (PERSEGI)
            
            double SISI;
            double LP;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(25, 14);
            Console.Write("SISI = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(32, 14);
            double.TryParse(Console.ReadLine(),out SISI);

            LP = SISI * SISI;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 14);
            Console.Write("L = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(64, 14);
            Console.Write(LP);

            //PERTANYAAN, JAWABAN & VARIABEL (PERSEGI PANJANG)
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(25, 16);
            Console.Write("PJG = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal Length = Convert.ToDecimal(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 16);
            Console.Write("LBR = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal Width = Convert.ToDecimal(Console.ReadLine());
            
            decimal Perimeter = (Length * Width);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 16);
            Console.Write("L = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(64, 16);
            Console.Write(Perimeter);

            //PERTANYAAN, JAWABAN & VARIABEL (SEGITIGA)
            
            double A, T, H;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(25, 18);
            Console.Write("ALAS = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(32, 18);
            double.TryParse(Console.ReadLine(),out A);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 18);
            Console.Write("TINGGI = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(49, 18);
            double.TryParse(Console.ReadLine(), out T);
            
            H = 0.5 * A * T;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 18);
            Console.Write("L = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(64, 18);
            Console.Write(H);

            //PERTANYAAN, JAWABAN & VARIABEL (JAJAR GENJANG)

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(25, 20);
            Console.Write("A = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal L = Convert.ToDecimal(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 20);
            Console.Write("T = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            decimal W = Convert.ToDecimal(Console.ReadLine());

            decimal P = (L * W);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(60, 20);
            Console.Write("L = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(64, 20);
            Console.Write(Perimeter);

            Console.ReadLine();
        }
        public void info()
        {
            //JUDUL
            ClearCenter();
            string kata = "INFORMASI SOAL :";
            string value = "1. Kerjakan SOAL 2A dan SOAL 2B pada pertemuan KEDUA.";
            string value2 = "2. Hasil akan dinilai pada pertemuan KETIGA.";
            string value3 = "3. Point mengerjakan soal ini adalah 10.";
            string value4 = "4. Mintalah soal tambahan ke dosen jika merasa kurang.";
            string value5 = "5. Usahakan utk mengerjakan sendiri sblm bertanya.";
            string value6 = "Keywords :";
            string value7 = "- Variabel,Constanta,Write,ForegroundColor,Clear";
            string value8 = "- WriteLine,Read,ReadLine";
            string value9 = "- BackgroundColor,SetCursorPosition";
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
            string[] menu = new string[4] { "INFO", "SOAL 2A", "SOAL 2B", "MENU UTAMA" };
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
                    P2A();
                    goto atas1;
                    break;
                case 2:
                    ClearArea(21, 8, 118, 21);
                    P2B();
                    goto atas1;
                    break;
                case 3:
                    ClearArea(1, 7, 18, 22);
                    ClearArea(21, 8, 118, 21);
                    break;
            }
        }

    }
}
    