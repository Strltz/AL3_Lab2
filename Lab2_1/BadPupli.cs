using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class BadPupil : Pupil
    {
        public BadPupil() : base() { }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Read: bad");
        }
        public override void Write()
        {
            base.Write();
            Console.WriteLine("Write: bad");
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("Study: very bad");
        }
        public override void Relax()
        {
            base.Relax();
            Console.WriteLine("Relax: very much relax. Razdolbay");
        }
    }
}
