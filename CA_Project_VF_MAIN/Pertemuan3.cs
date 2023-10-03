using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_310823
{
    class Pertemuan3 : Setelan
    {
        private int PilihLuas()
        {
            int hsl = 0;

            //JUDUL

            string titleP3A1 = ("LATIHAN PROGRAM C# CONSOLE");
            TulisTengah(134, 0, 8, titleP3A1);
            string titleP3A2 = ("HITUNG LUAS BANGUN DATAR (MENU PILIH)");
            TulisTengah(134, 0, 9, titleP3A2);

            //PERTANYAAN1

            Console.ForegroundColor = ConsoleColor.Cyan;
            
            string daftar1 =("1. HITUNG LUAS LINGKARAN");
            string daftar2 =("2. HITUNG LUAS PERSEGI");
            string daftar3 =("3. HITUNG LUAS PERSEGI PANJANG");
            string daftar4 =("4. HITUNG LUAS SEGITIGA");
            string daftar5 =("5. HITUNG LUAS JAJAR GENJANG");

            //PERTANYAAN2
            Console.SetCursorPosition(25, 11);
            Console.Write(daftar1);
            Console.SetCursorPosition(25, 12);
            Console.Write(daftar2);
            Console.SetCursorPosition(25, 13);
            Console.Write(daftar3);
            Console.SetCursorPosition(25, 14);
            Console.Write(daftar4);
            Console.SetCursorPosition(25, 15);
            Console.Write(daftar5);

            //PERTANYAAN3

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(25, 17);
            string Ask = "PILIH PERTANYAAN 1-5 : ";
            Console.Write(Ask);

            //BACK&FORTH

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(25 + Ask.Length, 17);
            Console.Write(" ");
            Console.SetCursorPosition(25 + Ask.Length, 17);
            hsl = int.Parse(Console.ReadLine());

            return hsl;
        }
        public void P3A()
        {
            int pil = 0;

        atas:
            pil = PilihLuas();

            if (pil < 1 || pil > 5)
            {
                Console.SetCursorPosition(25, 19);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("INVALID INPUT");
                Console.ReadLine();
                goto atas;
            }
            {
                switch (pil)
                {
                    case 1: //RUMUS LINGKARAN
                        {
                            double phi = 3.14;
                            double r, LL;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(25, 19);
                            Console.Write("PHI = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(31, 19);
                            Console.Write(phi);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(45, 19);
                            Console.Write("R = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(49, 19);
                            r = double.Parse(Console.ReadLine());
                            LL = phi * (r * r);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(60, 19);
                            Console.Write("L = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(64, 19);
                            Console.Write(LL);
                            break;
                        }
                    case 2: //RUMUS PERSEGI
                        {
                            double SISI;
                            double LP;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(25, 19);
                            Console.Write("SISI = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(32, 19);
                            SISI = double.Parse(Console.ReadLine());
                            LP = SISI * SISI;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(60, 19);
                            Console.Write("L = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(64, 19);
                            Console.Write(LP);
                            break;
                        }
                    case 3: //RUMUS PERSEGI PANJANG
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(25, 19);
                            Console.Write("PJG=");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            decimal Length = Convert.ToDecimal(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(40, 19);
                            Console.Write("LBR=");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            decimal Width = Convert.ToDecimal(Console.ReadLine());
                            decimal Perimeter = (Length * Width);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(60, 19);
                            Console.Write("L=");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(64, 19);
                            Console.Write(Perimeter);
                            break;
                        }
                    case 4: //PERTANYAAN, JAWABAN & VARIABEL (SEGITIGA)
                        {
                            double A, T, H;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(25, 19);
                            Console.Write("ALAS = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(32, 19);
                            A = double.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(40, 19);
                            Console.Write("TINGGI = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(49, 19);
                            T = double.Parse(Console.ReadLine());

                            H = 0.5 * A * T;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(60, 19);
                            Console.Write("L = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(64, 19);
                            Console.Write(H);
                            break;
                        }
                    case 5: //PERTANYAAN, JAWABAN & VARIABEL (JAJAR GENJANG)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(25, 19);
                            Console.Write("A = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            decimal L = Convert.ToDecimal(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(40, 19);
                            Console.Write("T = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            decimal W = Convert.ToDecimal(Console.ReadLine());
                            decimal P = (L * W);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(60, 19);
                            Console.Write("L = ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(64, 19);
                            Console.Write(P);
                            break;
                        }
                }

                //PERTANYAAN3

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(25, 21);
                string Ask2 = "HITUNG RUMUS LAGI? : ";
                Console.Write(Ask2);

                //BACK&FORTH2

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(25 + Ask2.Length, 21);
                Console.Write(" ");
                Console.SetCursorPosition(25 + Ask2.Length, 21);
                string hsl1 = Console.ReadLine();
                if (hsl1 == "Y" || hsl1 == "y")
                {
                    goto atas;
                }
                else if (hsl1 == "N" || hsl1 == "n")
                {
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
        }
        public void P3B()
        {
            //JUDUL
            Console.SetCursorPosition(40, 8);
            Console.Write("LATIHAN PROGRAM C# CONSOLE");
            Console.SetCursorPosition(34, 9);
            Console.Write("MENAMPILKAN ZODIAK BEDASARKAN TANGGAL LAHIR");

            //KALENDER
            atas4:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(25, 10);
            string label1 = "TANGGAL LAHIR (DD/MM/YYYY) : ";
            Console.Write(label1);
            //TANGGAL
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("  ");
            //PEMISAH
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" - ");
            //BULAN
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("  ");
            //PEMISAH
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" - ");
            //TAHUN
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("    ");

            int tgl, bln, thn;

        atas1:
            int.TryParse(TextBoxOri((25 + label1.Length), 10, 2, ConsoleColor.White, ConsoleColor.DarkBlue),out tgl);
            //CHECK KEBENARAN TGL
            if (tgl >= 1 && tgl <= 31)
            {
                //TGL BENAR
                ClearArea(25, 12, 50, 12);

                atas2:
                int.TryParse(TextBoxOri((30 + label1.Length), 10, 2, ConsoleColor.White, ConsoleColor.DarkBlue),out bln);
                
                //CHECK KEBENARAN BLN
                if (bln >= 1 && bln <= 12)
                {
                    ClearArea(25, 12, 50, 12);
                    atas3:
                    int.TryParse(TextBoxOri((35 + label1.Length), 10, 3, ConsoleColor.White, ConsoleColor.DarkBlue),out thn);
                    //CHECK KEBENARAN THN
                    if (thn < 1993)
                    {
                        //THN SALAH
                        Console.SetCursorPosition(25, 12);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("INPUT TAHUN SALAH");
                        goto atas3;
                    }
                }
                else
                {
                    //BLN SALAH
                    Console.SetCursorPosition(25, 12);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("INPUT BULAN SALAH");
                    goto atas2;
                }
            }
            else
            {
                //TGL SALAH
                Console.SetCursorPosition(25, 12);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("INPUT TANGGAL SALAH");
                goto atas1;
            }
            //ZODIAK
            switch (bln)
            {
                case 1: //JANUARY
                    if (tgl >= 1 && tgl <= 19)
                    {
                        //CAPICORN
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Januari " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Capicorn");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 20 && tgl <= 31)
                    {
                        //AQUARIUS
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Januari " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Aquarius");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 2:  //FEBRUARY
                    if (tgl >= 1 && tgl <= 18)
                    {
                        //AQUARIUS
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Februari " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Aquarius");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 19 && tgl <= 29)
                    {
                        //PISCES
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Februari " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Pisces");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 3:  //MARCH
                    if (tgl >= 1 && tgl <= 20)
                    {
                        //PISCES
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Maret " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Pisces");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 21 && tgl <= 31)
                    {
                        //ARIES
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Maret " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Aries");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 4:  //APRIL
                    if (tgl >= 1 && tgl <= 19)
                    {
                        //ARIES
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " April " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Aries");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 21 && tgl <= 30)
                    {
                        //TAURUS
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " April " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Taurus");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 5:  //MAY
                    if (tgl >= 1 && tgl <= 20)
                    {
                        //TAURUS
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Mei " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Taurus");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 21 && tgl <= 31)
                    {
                        //GEMINI
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Mei " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Gemini");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 6:  //JUNE
                    if (tgl >= 1 && tgl <= 20)
                    {
                        //GEMINI
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Juni " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Gemini");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 21 && tgl <= 30)
                    {
                        //CANCER
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Juni " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Cancer");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 7:  //JULY
                    if (tgl >= 1 && tgl <= 22)
                    {
                        //CANCER
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Juli " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Cancer");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 21 && tgl <= 31)
                    {
                        //LEO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Juli " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Leo");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 8:  //AUGUST
                    if (tgl >= 1 && tgl <= 22)
                    {
                        //LEO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Agustus " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Leo");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 23 && tgl <= 31)
                    {
                        //VIRGO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Agustus " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Virgo");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 9: //SEPTEMBER
                    if (tgl >= 1 && tgl <= 22)
                    {
                        //VIRGO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " September " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Virgo");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 23 && tgl <= 30)
                    {
                        //LIBRA
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " September " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Libra");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 10: //OCTOBER
                    if (tgl >= 1 && tgl <= 22)
                    {
                        //LIBRA
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Oktober " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Libra");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 23 && tgl <= 31)
                    {
                        //SCORPIO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Oktober " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Scorpio");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 11: //NOVEMBER
                    if (tgl >= 1 && tgl <= 21)
                    {
                        //SCORPIO
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " November " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Scorpio");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 22 && tgl <= 30)
                    {
                        //SAGITARIUS
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " November " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Sagitarius");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
                case 12: //DECEMBER
                    if (tgl >= 1 && tgl <= 21)
                    {
                        //SAGITARIUS
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Desember " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Sagitarius");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    else if (tgl >= 22 && tgl <= 31)
                    {
                        //CAPICORN
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 12);
                        Console.Write("Tanggal lahir : " + tgl + " Desember " + thn);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 13);
                        Console.Write("Nama Zodiak : Capicorn");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(25, 14);
                        Console.Write("Ramalan : Null");
                    }
                    break;
            }
            {
                Console.ReadLine();
                ClearArea(25, 12, 56, 14);
                goto atas4;
            }
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
            string[] menu = new string[4] { "INFO", "SOAL 3A", "SOAL 3B", "MENU UTAMA" };
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
                        if (idx < 3) { idx = idx + 1; } else { idx = 0; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearArea(21, 8, 118, 21);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 3)
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
                        if (idx > 0) { idx = idx - 1; } else { idx = 3; }
                        //warna sorot = warna dituju
                        Console.ForegroundColor = ConsoleColor.Red;
                        TulisTengah(0, 20, (6 + (idx * 2)), menu[idx]);
                        //keterangan
                        ClearArea(21, 8, 118, 21);
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (idx < 3)
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
                    P3A();
                    goto atas1;
                    break;
                case 2:
                    ClearArea(21, 8, 118, 21);
                    P3B();
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
