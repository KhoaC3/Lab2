using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class KhuDat
    {
        private string diaDiem;
        private float giaBan;
        private string dienTich;

      

        public string DiaDiem
        {
            get
            {
                return diaDiem;
            }

            set
            {
                diaDiem = value;
            }
        }

        public float GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
            }
        }

        public string DienTich
        {
            get
            {
                return dienTich;
            }

            set
            {
                dienTich = value;
            }
        }
        public KhuDat()
        {
                
        }
        public KhuDat(string diaDiem, float giaBan, string dienTich)
        {
            this.diaDiem = diaDiem;
            this.giaBan = giaBan;
            this.dienTich = dienTich;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap Vao Dia Diem:");
            DiaDiem = Console.ReadLine();
            Console.WriteLine("Nhap Vao Gia Ban:");
            GiaBan = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Vao Dien Tich");
            DienTich = Console.ReadLine();

        }
        public virtual void Output()
        {
            
            Console.WriteLine(" - Dia Diem:{0}\n - Gia Ban:{1}\n - Dien Tich:{2} ",DiaDiem,GiaBan,DienTich);
        }
    }
}
