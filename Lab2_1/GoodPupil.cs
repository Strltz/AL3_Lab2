using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class GoodPupil : Pupil
    {
        public GoodPupil() : base() { }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Read: good");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Write: good");
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Study: good");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Relax: good");
        }
    }
}
