using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ChungCu : KhuDat
    {
        private int tang;

        public ChungCu()
        {

        }

        public ChungCu(string diaDiem, float giaBan, string dienTich, int tang)
            :base(diaDiem,giaBan,dienTich)
        {
            this.Tang = tang;
        }

        public int Tang
        {
            get
            {
                return tang;
            }

            set
            {
                tang = value;
            }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Vao Tang:");
            Tang = Int32.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("- Tang: {0}",Tang);
        }
    }
}
