using System;

namespace baithuchanh1
{

    class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void nhap()
        {
            Console.Write("Nhap Hoanh do : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap Tung do : ");
            y = double.Parse(Console.ReadLine());
        }
        public void hienThi()
        {
            Console.WriteLine("Toa do la : ({0},{1})", x, y);
        }
        public double Khoangcach(Diem d1, Diem d2)
        {
            double kc = Math.Sqrt((d1.x - d2.x) * (d1.x - d2.x) + (d1.y - d2.y) * (d1.y - d2.y));
            return kc;
        }
        static void Main1(string[] args)
        {
            Diem t = new Diem();
            t.nhap();
            t.hienThi();
            Console.ReadKey();
        }
    }
}