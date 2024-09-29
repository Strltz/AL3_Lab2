using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class ClassRoom
    {
        Pupil[] all_pupils;

        public ClassRoom(params Pupil[] class_list)
        {
            all_pupils = class_list;
        }
        public void print_all_pupils_on_class()
        {
            int i = 1;
            foreach (Pupil p in all_pupils)
            {
                string suf = "th";
                switch (i)
                {
                    case 1: suf = "st";
                        break;
                    case 2: suf = "nd";
                        break;
                    case 3: suf = "rd";
                        break;
                    case 4: suf = "th";
                        break;
                }
                Console.WriteLine($"{i}{suf} pupil:");
                p.Read();
                p.Write();
                p.Study();
                p.Relax();
            }
        }
    }
}
