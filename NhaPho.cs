using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class NhaPho :KhuDat
    {
        private string namXD;
        private int soTang;


        public NhaPho()
        {

        }
        public NhaPho(string diaDiem, float giaBan, string dienTich,string namXD, int soTang)
            :base(diaDiem,giaBan,dienTich)
            
        {
            this.namXD = namXD;
            this.soTang = soTang;
        }

        public string NamXD
        {
            get
            {
                return namXD;
            }

            set
            {
                namXD = value;
            }
        }

        public int SoTang
        {
            get
            {
                return soTang;
            }

            set
            {
                soTang = value;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Vao Nam Xay Dung:");
            NamXD = Console.ReadLine();
            Console.WriteLine("Nhap Vao So Tang:");
            SoTang = Int32.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine(" - Nam Xay Dung: {0}\n - So Tang: {1}",NamXD,SoTang);
        }
    }
}
