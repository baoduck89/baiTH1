using System;
namespace baithuchanh1
{
    class SoPhuc
    {
        private double thuc, ao;
        public SoPhuc()
        {
            thuc = 0;
            ao = 0;
        }
        public SoPhuc(double thuc, double ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }
        public SoPhuc(SoPhuc t2)
        {
            this.thuc = t2.thuc;
            this.ao = t2.ao;
        }
        public void Hien()
        {
            string kq = thuc + (ao > 0 ? "+" : "") + ao + "* i";
            Console.WriteLine(kq);
        }
        public static SoPhuc operator +(SoPhuc t1, SoPhuc t2)
        {
            SoPhuc tmp = new SoPhuc();
            tmp.thuc = t1.thuc + t2.thuc;
            tmp.ao = t1.ao + t2.ao;
            return tmp;
        }
        public SoPhuc Tong(SoPhuc t2)
        {
            SoPhuc tmp = new SoPhuc();
            tmp.thuc = this.thuc + t2.thuc;
            tmp.ao = this.ao + t2.ao;
            return tmp;
        }
        public SoPhuc Hieu(SoPhuc t2)
        {
            SoPhuc tmp = new SoPhuc();
            tmp.thuc = this.thuc - t2.thuc;
            tmp.ao = this.ao - t2.ao;
            return tmp;
        }

        static void Main4(string[] args)
        {
        }
    }
}
