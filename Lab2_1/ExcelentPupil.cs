using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil() : base() { }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Excelent");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Excelent");
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Excelent");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Excelent");
        }
    }
}
