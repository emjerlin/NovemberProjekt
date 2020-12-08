using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000,1000,"Antiquary");
            int posX = 80;
            int posY = 200;
            while (!Raylib.WindowShouldClose()){


                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.GRAY);

                Raylib.DrawText("Welcome to your first day of many at the antiquary", 60, 80, 30, Color.BLACK);

                Rectangle roadHorizontal = new Rectangle(60,600,400, 60);
                Rectangle roadVertical = new Rectangle(60,200,60, 400);
                Rectangle player = new Rectangle(posX,posY,20,20);
            
                Raylib.DrawRectangle(200,200,300,120,Color.RED);


                Raylib.DrawRectangleRec(roadVertical,Color.DARKGRAY);

                Raylib.DrawRectangleRec(roadHorizontal,Color.DARKGRAY);

                Raylib.DrawRectangleRec(player,Color.PURPLE);

                bool isCollidingH = Raylib.CheckCollisionRecs(roadHorizontal, player);
                bool isCollidingV = Raylib.CheckCollisionRecs(roadVertical, player);
                

                if (isCollidingV == true)
                {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                   posX--;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    posX++;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    posY++;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    posY--;
                }
                }
                else{

                }
                

                Book b1 = new Book();

                b1.PrintInfo();
                

                Raylib.EndDrawing();
            

            //Console.WriteLine("Welcome to your first day of many at the antiquary");
            //Planen är att man ska kunna gå från rum till rum i en affär, och kunna plocka upp böcker som man kan köpa.
            //Sedan andra delen av spelet kommer man tillbaka till sin egen affär och ska sälja den till customers
            //Man får en rapport hur mycket man tjänar i slutet av dagen. Om man har kvar ett cursed item
            //får man problem under nästa dag. Om man säljer en cursed item till en customer som inte letar efter det
            //kommer man få en lawsuit, som man måste kunna betala av
            //Console.WriteLine();


            
            
            //Console.ReadLine();
            }
        }
    }
}
