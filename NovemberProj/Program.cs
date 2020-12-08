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

                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Welcome to your first day of many at the antiquary", 60, 80, 30, Color.BLACK);

                Rectangle background1 = new Rectangle (0,0, 320,660);
                Rectangle background2 = new Rectangle (0,660,540,340);
                Rectangle background3 = new Rectangle (380,0, 620,600);
                Rectangle roadHorizontal = new Rectangle(320,600,480, 60);
                Rectangle roadVertical = new Rectangle(320,200,60,400);
                Rectangle player = new Rectangle(posX,posY,20,20);

                Raylib.DrawRectangleRec(background1,Color.BLUE);
                Raylib.DrawRectangleRec(background2,Color.PINK);
                Raylib.DrawRectangleRec(background3,Color.GREEN);

                Raylib.DrawRectangleRec(roadVertical,Color.DARKGRAY);
                Raylib.DrawRectangleRec(roadHorizontal,Color.DARKGRAY);
            
                Raylib.DrawRectangle(200,200,300,120,Color.RED);
                Raylib.DrawRectangle(325,270,60,50,Color.BLACK);
                Raylib.DrawText("Second Hand Store", 215, 230, 25, Color.BLACK);

                Raylib.DrawRectangle(500,400,400,200,Color.PURPLE);
                Raylib.DrawRectangle(670,550,60,50,Color.BLACK);
                Raylib.DrawText("ANTIQUARY", 590, 450, 35, Color.BLACK);

               
                
               

                Raylib.DrawRectangleRec(player,Color.PURPLE);

                bool isCollidingBG = Raylib.CheckCollisionRecs(background1, player);
                bool isCollidingV = Raylib.CheckCollisionRecs(roadVertical, player);
                

                
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
                
                if (isCollidingBG == true){
                    posX++;
                }
                
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
                     Book b1 = new Book();
                     
                     b1.PrintInfo();
                }
               
                

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
