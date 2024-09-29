using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class DocumentWorker
    {
        public DocumentWorker() { }

        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии" +
                "Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
}
