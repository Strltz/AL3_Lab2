using Lab2_3;

class Program
{
    static string key_pro = "6165356741258637";
    static string key_exp = "sEr61erc45tbr45t";
    static void Main(string[] args)
    {
        string user_enter_key = "";
        Console.WriteLine("Enter the key");
        user_enter_key = Console.ReadLine();
        
        DocumentWorker worker1 = new DocumentWorker();

        if (user_enter_key == key_pro)
        {
            worker1 = new ProDocumentWorker();
        }
        else if (user_enter_key == key_exp)
        {
            worker1 = new ExpertDocumentWorker();
        }
        worker1.OpenDocument();
        worker1.EditDocument();
        worker1.SaveDocument();
    }
}
