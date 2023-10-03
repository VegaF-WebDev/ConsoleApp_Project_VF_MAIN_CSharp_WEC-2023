using CA_Project_VF_070923;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Project_VF_MAIN
{
    // Token: 0x02000009 RID: 9
    internal class Pertemuan6 : Setelan
    {
        // Token: 0x0600002A RID: 42 RVA: 0x00006A78 File Offset: 0x00004C78
        public Pertemuan6()
        {
            if (!File.Exists("d:\\databuku.txt"))
            {
                File.WriteAllLines("d:\\databuku.txt", this.arrBuku);
                this.createFile = true;
            }
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00006B14 File Offset: 0x00004D14
        public void buka()
        {
            base.TulisTengahWarna("SOAL PERT6", 1, 15, 4, ConsoleColor.Yellow);
            string[] array = new string[]
            {
                "INFORMASI",
                "ADD",
                "EDIT",
                "DEL",
                "SHOW",
                "MENU UTAMA"
            };
            int num = 0;
            foreach (string text in array)
            {
                base.TulisTengahWarna(text, 1, 15, 6 + num * 2 + 2, ConsoleColor.Green);
                num++;
            }
            base.TulisTengahWarna(array[0], 1, 15, 8, ConsoleColor.Red);
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
                    base.ClearCenter();
                    if (num2 == 0)
                    {
                        base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Yellow);
                    }
                    else
                    {
                        base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Green);
                    }
                    if (num2 == 0)
                    {
                        num2 = 5;
                    }
                    else
                    {
                        num2--;
                    }
                    base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Red);
                    if (num2 == 3)
                    {
                        base.TulisTengahWarna("Kembali ke menu utama ?", 17, 78, 11, ConsoleColor.Red);
                    }
                    else
                    {
                        base.TulisTengahWarna("Operasi File " + array[num2], 17, 78, 11, ConsoleColor.Red);
                    }
                }
                else if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                {
                    base.ClearCenter();
                    if (num2 == 0)
                    {
                        base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Yellow);
                    }
                    else
                    {
                        base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Green);
                    }
                    if (num2 == 5)
                    {
                        num2 = 0;
                    }
                    else
                    {
                        num2++;
                    }
                    base.TulisTengahWarna(array[num2], 1, 15, 6 + num2 * 2 + 2, ConsoleColor.Red);
                    if (num2 == 5)
                    {
                        base.TulisTengahWarna("Kembali ke menu utama ?", 17, 78, 11, ConsoleColor.Red);
                    }
                    else
                    {
                        base.TulisTengahWarna("Operasi File " + array[num2], 17, 78, 11, ConsoleColor.Red);
                    }
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    switch (num2)
                    {
                        case 0:
                            this.perintah();
                            break;
                        case 1:
                            base.ClearCenter();
                            this.Add();
                            break;
                        case 2:
                            base.ClearCenter();
                            this.Edit();
                            break;
                        case 3:
                            base.ClearCenter();
                            this.Hapus();
                            break;
                        case 4:
                            {
                                base.ClearCenter();
                                this.arrBuku = File.ReadAllLines("d:\\databuku.txt");
                                this.jmlData = this.arrBuku.Length;
                                this.sisa = this.jmlData % 5;
                                this.group = 1;
                                this.jmlGroup = this.jmlData / 5 + this.sisa;
                                if (this.jmlData > 5)
                                {
                                    this.awal = 0;
                                    this.akhir = 4;
                                    this.Tampil();
                                }
                                else
                                {
                                    this.awal = 0;
                                    this.akhir = this.jmlData - 1;
                                    this.Tampil();
                                }
                                string[] array3 = new string[]
                                {
                            " PREV ",
                            " NEXT "
                                };
                                int num3 = 0;
                                foreach (string text in array3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                    Console.SetCursorPosition(40 + num3 * 8, 17);
                                    Console.Write(text);
                                    num3++;
                                }
                                this.menuSorot(array3, 40, 17, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.Gray, "TAMPIL");
                                break;
                            }
                    }
                }
                else
                {
                    base.ClearCenter();
                    base.TulisTengahWarna("Anda Menekan Tombol yang salah!!", 17, 78, 19, ConsoleColor.Red);
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter || num2 != 5);
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00006F80 File Offset: 0x00005180
        private void perintah()
        {
            string kata = "INFORMASI SOAL :";
            string value = "1. Kerjakan ADD,EDIT,SHOW,dan DEL pd pert KE-6 sd KE-10.";
            string value2 = "2. Hasil akan dinilai pada pertemuan KELIMABELAS.";
            string value3 = "3. Point mengerjakan soal ini adalah 40.";
            string value4 = "4. Pert KE-12 sd KE-15 untuk merangkum hasil perkerjaan";
            string value5 = "   sehingga membentuk tampilan seperti soal latihan Anda.";
            string value6 = "Keywords :";
            string value7 = "- All Keyword dari pert 1 sd pert 5.";
            string value8 = "- System.IO";
            string value9 = "- Gunakan tombol [ESC] untuk keluar dari menu";
            base.TulisTengahWarna(kata, 16, 79, 5, ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(17, 9);
            Console.Write(value);
            Console.SetCursorPosition(17, 10);
            Console.Write(value2);
            Console.SetCursorPosition(17, 11);
            Console.Write(value3);
            Console.SetCursorPosition(17, 12);
            Console.Write(value4);
            Console.SetCursorPosition(17, 13);
            Console.Write(value5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(17, 15);
            Console.Write(value6);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(17, 16);
            Console.Write(value7);
            Console.SetCursorPosition(17, 17);
            Console.Write(value8);
            Console.SetCursorPosition(17, 18);
            Console.Write(value9);
        }

        // Token: 0x0600002D RID: 45 RVA: 0x00007098 File Offset: 0x00005298
        private void cekKode(int width, int left, int top)
        {
            this.kode = base.TextBox(width, left, top, ConsoleColor.Red, ConsoleColor.Yellow, false);
            if (string.IsNullOrWhiteSpace(this.kode))
            {
                this.cekKode(width, left, top);
            }
        }

        // Token: 0x0600002E RID: 46 RVA: 0x000070D8 File Offset: 0x000052D8
        private void cekJudul(int width, int left, int top)
        {
            this.judul = base.TextBox(width, left, top, ConsoleColor.Red, ConsoleColor.Yellow, false);
            if (string.IsNullOrWhiteSpace(this.judul))
            {
                this.cekJudul(width, left, top);
            }
        }

        // Token: 0x0600002F RID: 47 RVA: 0x00007118 File Offset: 0x00005318
        private void cekJumlah(int width, int left, int top)
        {
            string text = base.TextBox(width, left, top, ConsoleColor.Red, ConsoleColor.Yellow, false);
            if (string.IsNullOrWhiteSpace(text))
            {
                this.cekJumlah(width, left, top);
            }
            else
            {
                int.TryParse(text, out this.jml);
                if (this.jml <= 0)
                {
                    this.cekJumlah(width, left, top);
                }
            }
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00007178 File Offset: 0x00005378
        private void Add()
        {
            string kata = "SOAL 6A :";
            base.TulisTengahWarna(kata, 16, 79, 5, ConsoleColor.Cyan);
            base.TulisTengahWarna("Operasi File - Add", 16, 79, 6, ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Kode Buku    = ";
            string value = "Judul Buku   = ";
            string value2 = "Jumlah       = ";
            Console.SetCursorPosition(18, 10);
            Console.WriteLine(text);
            Console.SetCursorPosition(18, 12);
            Console.WriteLine(value);
            Console.SetCursorPosition(18, 14);
            Console.WriteLine(value2);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(18 + text.Length, 10);
            Console.Write("          ");
            Console.SetCursorPosition(18 + text.Length, 12);
            Console.Write("                                   ");
            Console.SetCursorPosition(18 + text.Length, 14);
            Console.Write("    ");
            string[] array = new string[]
            {
                " SAVE ",
                " CANCEL "
            };
            int num = 0;
            foreach (string value3 in array)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(18 + text.Length + num * 8, 16);
                Console.Write(value3);
                num++;
            }
            this.cekKode(10, 18 + text.Length, 10);
            this.cekJudul(35, 18 + text.Length, 12);
            this.cekJumlah(4, 18 + text.Length, 14);
            this.menuSorot(array, 18 + text.Length, 16, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.Gray, "ADD");
        }

        // Token: 0x06000031 RID: 49 RVA: 0x0000732C File Offset: 0x0000552C
        private void Edit()
        {
            string kata = "SOAL 6B :";
            base.TulisTengahWarna(kata, 16, 79, 5, ConsoleColor.Cyan);
            base.TulisTengahWarna("Operasi File - Edit", 16, 79, 6, ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Cari Kode Buku = ";
            Console.SetCursorPosition(18, 8);
            Console.WriteLine(text);
            this.cekKode(10, 18 + text.Length, 8);
            this.arrBuku = File.ReadAllLines("d:\\databuku.txt");
            string text2 = this.kode;
            this.jmlData = this.arrBuku.Length;
            for (int i = 0; i < this.jmlData; i++)
            {
                this.bacaData = this.arrBuku[i].Split(new char[]
                {
                    ';'
                });
                if (text2.ToUpper().Trim() == this.bacaData[0].ToUpper().Trim())
                {
                    this.kode1 = this.bacaData[0];
                    this.judul1 = this.bacaData[1];
                    this.jml1 = int.Parse(this.bacaData[2]);
                    this.ketemu = i;
                    break;
                }
            }
            if (this.ketemu >= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string value = "Kode Buku      = ";
                string value2 = "Judul Buku     = ";
                string value3 = "Jumlah         = ";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(18, 10);
                Console.WriteLine(value);
                Console.SetCursorPosition(18, 11);
                Console.WriteLine(value2);
                Console.SetCursorPosition(18, 12);
                Console.WriteLine(value3);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(18 + text.Length, 10);
                Console.Write("          ");
                Console.SetCursorPosition(18 + text.Length, 11);
                Console.Write("                                   ");
                Console.SetCursorPosition(18 + text.Length, 12);
                Console.Write("    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(18 + text.Length, 10);
                Console.Write(this.kode1);
                Console.SetCursorPosition(18 + text.Length, 11);
                Console.Write(this.judul1);
                Console.SetCursorPosition(18 + text.Length, 12);
                Console.Write(this.jml1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(18, 14);
                Console.WriteLine(value);
                Console.SetCursorPosition(18, 15);
                Console.WriteLine(value2);
                Console.SetCursorPosition(18, 16);
                Console.WriteLine(value3);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(18 + text.Length, 14);
                Console.Write("          ");
                Console.SetCursorPosition(18 + text.Length, 15);
                Console.Write("                                   ");
                Console.SetCursorPosition(18 + text.Length, 16);
                Console.Write("    ");
                string[] array = new string[]
                {
                    " SAVE ",
                    " CANCEL "
                };
                int num = 0;
                foreach (string value4 in array)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(18 + num * 8, 18);
                    Console.Write(value4);
                    num++;
                }
                this.cekKode(10, 18 + text.Length, 14);
                this.cekJudul(35, 18 + text.Length, 15);
                this.cekJumlah(4, 18 + text.Length, 16);
                this.menuSorot(array, 18, 18, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.Gray, "EDIT");
            }
            else
            {
                this.ketemu = -1;
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                base.TulisTengahWarna("Data Yang Anda Cari Tidak Ditemukan.", 17, 78, 19, ConsoleColor.Red);
                Console.ReadLine();
                base.ClearCenter();
                this.Edit();
            }
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00007740 File Offset: 0x00005940
        private void Tampil()
        {
            string kata = "SOAL 6D :";
            base.TulisTengahWarna(kata, 16, 79, 5, ConsoleColor.Cyan);
            base.TulisTengahWarna("Operasi File - Tampil", 16, 79, 6, ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(18, 8);
            Console.Write("----------------------------------------------------------");
            Console.SetCursorPosition(18, 9);
            Console.Write("│ NO │   KODE   │               JUDUL               │ JML│");
            Console.SetCursorPosition(18, 10);
            Console.Write("----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (this.jmlData > 0)
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.SetCursorPosition(18, 11 + i);
                    string text = string.Format("{0,4}", "");
                    this.kode1 = string.Format("{0,-10}", "");
                    this.judul1 = string.Format("{0,-35}", "");
                    string text2 = string.Format("{0,4}", "");
                    Console.Write(string.Format("│{0}│{1}│{2}│{3}│", new object[]
                    {
                        text,
                        this.kode1,
                        this.judul1,
                        text2
                    }));
                }
                for (int i = this.awal; i <= this.akhir; i++)
                {
                    this.bacaData = this.arrBuku[i].Split(new char[]
                    {
                        ';'
                    });
                    if (this.bacaData.Length <= 1)
                    {
                        this.jmlData = 0;
                        break;
                    }
                    Console.SetCursorPosition(18, 11 + i - (this.group - 1) * 5);
                    string text = string.Format("{0,4}", i + 1);
                    this.kode1 = string.Format("{0,-10}", this.bacaData[0]);
                    this.judul1 = string.Format("{0,-35}", this.bacaData[1]);
                    string text2 = string.Format("{0,4}", this.bacaData[2]);
                    Console.Write(string.Format("│{0}│{1}│{2}│{3}│", new object[]
                    {
                        text,
                        this.kode1,
                        this.judul1,
                        text2
                    }));
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(18, 16);
                Console.Write("----------------------------------------------------------");
            }
            Console.SetCursorPosition(18, 17);
            Console.Write("Data = " + this.jmlData);
        }

        // Token: 0x06000033 RID: 51 RVA: 0x000079E4 File Offset: 0x00005BE4
        private void Hapus()
        {
            string kata = "SOAL 6C :";
            base.TulisTengahWarna(kata, 16, 79, 5, ConsoleColor.Cyan);
            base.TulisTengahWarna("Operasi File - Delete", 16, 79, 6, ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.White;
            string text = "Cari Kode Buku = ";
            Console.SetCursorPosition(18, 8);
            Console.WriteLine(text);
            this.cekKode(10, 18 + text.Length, 8);
            this.arrBuku = File.ReadAllLines("d:\\databuku.txt");
            string text2 = this.kode;
            this.jmlData = this.arrBuku.Length;
            for (int i = 0; i < this.jmlData; i++)
            {
                this.bacaData = this.arrBuku[i].Split(new char[]
                {
                    ';'
                });
                if (text2.ToUpper().Trim() == this.bacaData[0].ToUpper().Trim())
                {
                    this.kode1 = this.bacaData[0];
                    this.judul1 = this.bacaData[1];
                    this.jml1 = int.Parse(this.bacaData[2]);
                    this.ketemu = i;
                    break;
                }
            }
            if (this.ketemu >= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string value = "Kode Buku      = ";
                string value2 = "Judul Buku     = ";
                string value3 = "Jumlah         = ";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(18, 10);
                Console.WriteLine(value);
                Console.SetCursorPosition(18, 11);
                Console.WriteLine(value2);
                Console.SetCursorPosition(18, 12);
                Console.WriteLine(value3);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(18 + text.Length, 10);
                Console.Write("          ");
                Console.SetCursorPosition(18 + text.Length, 11);
                Console.Write("                                   ");
                Console.SetCursorPosition(18 + text.Length, 12);
                Console.Write("    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(18 + text.Length, 10);
                Console.Write(this.kode1);
                Console.SetCursorPosition(18 + text.Length, 11);
                Console.Write(this.judul1);
                Console.SetCursorPosition(18 + text.Length, 12);
                Console.Write(this.jml1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(18, 14);
                Console.Write("Apakah Data Buku ini ingin dihapus?");
                string[] array = new string[]
                {
                    " DELETE ",
                    " CANCEL "
                };
                int num = 0;
                foreach (string value4 in array)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(40 + num * 8, 16);
                    Console.Write(value4);
                    num++;
                }
                this.menuSorot(array, 40, 16, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.DarkMagenta, ConsoleColor.Gray, "DEL");
            }
            else
            {
                this.ketemu = -1;
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                base.TulisTengahWarna("Data Yang Anda Cari Tidak Ditemukan.", 17, 78, 19, ConsoleColor.Red);
                Console.ReadLine();
                base.ClearCenter();
                this.Hapus();
            }
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00007D40 File Offset: 0x00005F40
        private void menuSorot(string[] menu, int left, int top, ConsoleColor background, ConsoleColor forecolor, ConsoleColor background1, ConsoleColor forecolor1, string proses)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(left, top);
            Console.BackgroundColor = background;
            Console.ForegroundColor = forecolor;
            Console.Write(menu[0]);
            int num = 0;
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                Console.SetCursorPosition(0, 19);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.ForegroundColor = forecolor1;
                    Console.BackgroundColor = background1;
                    Console.SetCursorPosition(left + num * 8, top);
                    Console.Write(menu[num]);
                    if (num == 0)
                    {
                        num = menu.Length - 1;
                    }
                    else
                    {
                        num--;
                    }
                    Console.ForegroundColor = forecolor;
                    Console.BackgroundColor = background;
                    Console.SetCursorPosition(left + num * 8, top);
                    Console.Write(menu[num]);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.ForegroundColor = forecolor1;
                    Console.BackgroundColor = background1;
                    Console.SetCursorPosition(left + num * 8, top);
                    Console.Write(menu[num]);
                    if (num == menu.Length - 1)
                    {
                        num = 0;
                    }
                    else
                    {
                        num++;
                    }
                    Console.ForegroundColor = forecolor;
                    Console.BackgroundColor = background;
                    Console.SetCursorPosition(left + num * 8, top);
                    Console.Write(menu[num]);
                }
                else if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    switch (num)
                    {
                        case 0:
                            if (proses != null)
                            {
                                if (!(proses == "ADD"))
                                {
                                    if (!(proses == "EDIT"))
                                    {
                                        if (!(proses == "DEL"))
                                        {
                                            if (proses == "TAMPIL")
                                            {
                                                if (this.group > 1)
                                                {
                                                    this.group--;
                                                    this.akhir = this.awal - 1;
                                                    this.awal = this.akhir - 4;
                                                    this.Tampil();
                                                }
                                            }
                                        }
                                        else if (this.ketemu >= 0)
                                        {
                                            string[] array = new string[1];
                                            Array.Resize<string>(ref array, this.jmlData - 1);
                                            int num2 = 0;
                                            for (int i = 0; i < this.jmlData; i++)
                                            {
                                                if (i != this.ketemu)
                                                {
                                                    array[num2] = this.arrBuku[i];
                                                    num2++;
                                                }
                                            }
                                            File.WriteAllLines("d:\\databuku.txt", array);
                                            base.TulisTengahWarna("DATA BUKU BERHASIL DIHAPUS", 17, 78, 19, ConsoleColor.Red);
                                        }
                                        else
                                        {
                                            base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                        }
                                    }
                                    else
                                    {
                                        this.arrBuku = File.ReadAllLines("d:\\databuku.txt");
                                        this.data = "";
                                        this.data = string.Format("{0};{1};{2}", this.kode, this.judul, this.jml);
                                        this.arrBuku[this.ketemu] = this.data;
                                        if (!string.IsNullOrWhiteSpace(this.kode) && !string.IsNullOrWhiteSpace(this.judul) && this.jml != 0)
                                        {
                                            File.WriteAllLines("d:\\databuku.txt", this.arrBuku);
                                            base.TulisTengahWarna("DATA BUKU BERHASIL DIEDIT", 17, 78, 19, ConsoleColor.Red);
                                        }
                                        else
                                        {
                                            base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!this.createFile)
                                    {
                                        this.arrBuku = File.ReadAllLines("d:\\databuku.txt");
                                        int num3 = this.arrBuku.Length + 1;
                                        Array.Resize<string>(ref this.arrBuku, num3);
                                        this.data = "";
                                        this.data = string.Format("{0};{1};{2}", this.kode, this.judul, this.jml);
                                        this.arrBuku[num3 - 1] = this.data;
                                    }
                                    else
                                    {
                                        this.data = "";
                                        this.data = string.Format("{0};{1};{2}", this.kode, this.judul, this.jml);
                                        this.arrBuku[0] = this.data;
                                        this.createFile = false;
                                    }
                                    if (!string.IsNullOrWhiteSpace(this.kode) && !string.IsNullOrWhiteSpace(this.judul) && this.jml != 0)
                                    {
                                        File.WriteAllLines("d:\\databuku.txt", this.arrBuku);
                                        base.TulisTengahWarna("DATA BUKU BERHASIL DISIMPAN", 17, 78, 19, ConsoleColor.Red);
                                        this.kode = string.Empty;
                                        this.judul = string.Empty;
                                        this.jml = 0;
                                    }
                                    else
                                    {
                                        base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                    }
                                }
                            }
                            break;
                        case 1:
                            if (proses != null)
                            {
                                if (!(proses == "ADD"))
                                {
                                    if (!(proses == "EDIT"))
                                    {
                                        if (!(proses == "DEL"))
                                        {
                                            if (proses == "TAMPIL")
                                            {
                                                if (this.group < this.jmlGroup)
                                                {
                                                    this.group++;
                                                    this.awal = this.akhir + 1;
                                                    if (this.akhir + 5 < this.jmlData)
                                                    {
                                                        this.akhir += 5;
                                                    }
                                                    else
                                                    {
                                                        this.akhir = this.akhir + (this.jmlData - this.akhir) - 1;
                                                    }
                                                    this.Tampil();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                        }
                                    }
                                    else
                                    {
                                        base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                    }
                                }
                                else
                                {
                                    base.TulisTengahWarna("Tekan ESC untuk keluar dari menu", 17, 78, 19, ConsoleColor.Red);
                                }
                            }
                            break;
                    }
                }
                else
                {
                    base.TulisTengahWarna("Anda Menekan Tombol yang salah!!", 17, 78, 19, ConsoleColor.Red);
                }
            }
            while (consoleKeyInfo.Key != ConsoleKey.Escape);
            base.ClearCenter();
            this.kode = "";
            this.judul = "";
            this.data = "";
            this.kode1 = "";
            this.judul1 = "";
            this.jml = 0;
            this.jml1 = 0;
            this.awal = 0;
            this.akhir = 0;
            this.jmlData = 0;
            this.group = 0;
            this.sisa = 0;
            this.jmlGroup = 0;
            this.createFile = false;
            this.ketemu = -1;
        }

        // Token: 0x04000004 RID: 4
        private string[] arrBuku = new string[1];

        // Token: 0x04000005 RID: 5
        private string[] bacaData = new string[3];

        // Token: 0x04000006 RID: 6
        private string kode = "-";

        // Token: 0x04000007 RID: 7
        private string judul = "-";

        // Token: 0x04000008 RID: 8
        private string data = "";

        // Token: 0x04000009 RID: 9
        private string kode1 = "-";

        // Token: 0x0400000A RID: 10
        private string judul1 = "-";

        // Token: 0x0400000B RID: 11
        private int jml;

        // Token: 0x0400000C RID: 12
        private int jml1;

        // Token: 0x0400000D RID: 13
        private int awal;

        // Token: 0x0400000E RID: 14
        private int akhir;

        // Token: 0x0400000F RID: 15
        private int jmlData;

        // Token: 0x04000010 RID: 16
        private int group;

        // Token: 0x04000011 RID: 17
        private int sisa;

        // Token: 0x04000012 RID: 18
        private int jmlGroup;

        // Token: 0x04000013 RID: 19
        private bool createFile = false;

        // Token: 0x04000014 RID: 20
        private int ketemu = -1;
    }
}
