using System;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your first day of many at the antiquary");
            //Planen är att man ska kunna gå från rum till rum i en affär, och kunna plocka upp böcker som man kan köpa.
            //Sedan andra delen av spelet kommer man tillbaka till sin egen affär och ska sälja den till customers
            //Man får en rapport hur mycket man tjänar i slutet av dagen. Om man har kvar ett cursed item
            //får man problem under nästa dag. Om man säljer en cursed item till en customer som inte letar efter det
            //kommer man få en lawsuit, som man måste kunna betala av
            Console.WriteLine();


            Book b1 = new Book();
            b1.PrintInfo();
            
            Console.ReadLine();
        }
    }
}
