using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhuDat> listKhuDat = new List<KhuDat>();
            Console.WriteLine("Nhap So Luong Bat Dong San Cua Cong Ty Dia Oc D:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. De nhap va xuat thong tin Khu Dat");
                Console.WriteLine("2. De nhap va xuat thong tin Nha Pho");
                Console.WriteLine("3. De nhap va xuat thong tin Chung Cu");
                Console.WriteLine("Moi Ban Chon: ");
                int chon = Int32.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        KhuDat kd = new KhuDat();
                        kd.Input();
                        listKhuDat.Add(kd);
                        Console.WriteLine("\n======Thong Tin Khu Dat======\n");
                        kd.Output();
                        break;
                    case 2:
                        NhaPho np = new NhaPho();
                        np.Input();
                        listKhuDat.Add(np);
                        Console.WriteLine("\n======Thong Tin Nha Mat Pho======\n");
                        np.Output();
                        break;
                    case 3:
                        ChungCu cc = new ChungCu();
                        cc.Input();
                        listKhuDat.Add(cc);
                        Console.WriteLine("\n======Thong Tin Chung Cu======\n");
                        cc.Output();
                        break;

                }
            }

          

        }
        public static List<KhuDat> GetListBDS(List<KhuDat> listInput)
        {
            List<KhuDat> listResult = listInput
        }
    }
}
