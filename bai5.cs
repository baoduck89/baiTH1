using System;
using System.Runtime.InteropServices.ComTypes;
namespace B5_TH1_OOP
{
    class MaTran
    {
        private int sh, sc;
        private int[,] a;
        public MaTran()
        {
            sh = sc = 2;
            a = new int[sh, sc];
        }
        public MaTran(int sh, int sc)
        {
            this.sh = sh;
            this.sc = sc;
            a = new int[sh, sc];
        }
        public MaTran(MaTran t2)
        {
            this.sh = t2.sh;
            this.sc = t2.sc;
            this.a = new int[sh, sc];
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    this.a[i, j] = t2.a[i, j];
        }
        public void Print()
        {
            Console.WriteLine("Cac phan tu cua ma tran la");
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public void Nhap()
        {
            Console.Write("Nhap so hang: "); sh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); sc = int.Parse(Console.ReadLine());
            a = new int[sh, sc];
            Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public MaTranTong(MaTran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                MaTran t = new MaTran(this.sh, this.sc);
                for (int i = 0; i < sh; i++)
                    for (int j = 0; j < sc; j++)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
        public MaTranHieu(MaTran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                MaTran t = new MaTran(this.sh, this.sc);
                for (int i = 0; i < sh; i++)
                    for (int j = 0; j < sc; j++)
                        t.a[i, j] = this.a[i, j] - t2.a[i, j];
                return t;
            }
            else return null;
        }
        public bool TuongThich()
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
                return true;
            else return false;
        }
        static void Main5(string[] args)
        {
        }
    }
}