using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Raylib.InitWindow(1000,1000,"Antiquary");
            int posX = 330;
            int posY = 610;
            string room = "hs";

            while (!Raylib.WindowShouldClose()){

            Rectangle background1 = new Rectangle (0,0, 320,660);
            Rectangle background2 = new Rectangle (0,660,1000,340);
            Rectangle background3 = new Rectangle (380,0, 620,600);
            Rectangle background4 = new Rectangle(320,0,60,200);
            Rectangle background5 = new Rectangle(800,600,200,60);
            Rectangle roadHorizontal = new Rectangle(320,600,480, 60);
            Rectangle roadVertical = new Rectangle(320,200,60,400);
            Rectangle aDoor = new Rectangle (670,560,60,50);
            Rectangle sDoor = new Rectangle (325,270,60,50);
            Rectangle player = new Rectangle(posX,posY,20,20);

                if (room == "hs") {
                    DrawHomescreen(player, background1, background2, background3,background4, background5, roadHorizontal, roadVertical, aDoor, sDoor);
                }
                if (room == "a"){
                    DrawAntique(player);
                }
                if (room == "s"){
                    DrawSecond(player);
                }
                

                //player controls
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

                //player stays on road
                bool isCollidingBG1 = Raylib.CheckCollisionRecs(background1, player);
                bool isCollidingBG2 = Raylib.CheckCollisionRecs(background2, player);
                bool isCollidingBG3 = Raylib.CheckCollisionRecs(background3, player);
                bool isCollidingBG4 = Raylib.CheckCollisionRecs(background4, player);
                bool isCollidingBG5 = Raylib.CheckCollisionRecs(background5, player);

                if (isCollidingBG1 == true){
                    posX++;
                }
                if (isCollidingBG2 == true){
                    posY--;
                }
                if (isCollidingBG3 == true){
                    posX--;
                    posY++;
                }
                if (isCollidingBG4 == true){
                    posY++;
                }
                if (isCollidingBG5 == true){
                    posX--;
                }

                //player enters antiquary
                bool aDoorCollide = Raylib.CheckCollisionRecs(aDoor, player);
                if (aDoorCollide == true){
                    room = "a";
                }
                //player enters second hand store
                bool sDoorCollide = Raylib.CheckCollisionRecs(sDoor, player);
                if (sDoorCollide == true){
                    room = "s";
                }
                
                //display stats for books - transfer to second hand store
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)){
                     Book b1 = new Book();
                     
                     b1.PrintInfo();
                }
            

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
        static void DrawHomescreen(Rectangle player, Rectangle background1, Rectangle background2,Rectangle background3,
        Rectangle background4,Rectangle background5, Rectangle roadVertical, Rectangle roadHorizontal, Rectangle aDoor, Rectangle sDoor){
            
             Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.WHITE);
                
            Raylib.DrawRectangleRec(background1,Color.GRAY);
            Raylib.DrawRectangleRec(background2,Color.GRAY);
            Raylib.DrawRectangleRec(background3,Color.GRAY);
            Raylib.DrawRectangleRec(background4,Color.GRAY);
            Raylib.DrawRectangleRec(background5,Color.GRAY);

            Raylib.DrawRectangleRec(roadVertical,Color.DARKGRAY);
            Raylib.DrawRectangleRec(roadHorizontal,Color.DARKGRAY);

            Raylib.DrawText("Welcome to a new day at the antiquary", 60, 80, 40, Color.BLACK);
            
            Raylib.DrawRectangle(200,200,300,120,Color.RED);
            Raylib.DrawRectangleRec(sDoor,Color.BLACK);
            Raylib.DrawText("Second Hand Store", 215, 230, 25, Color.BLACK);

            Raylib.DrawRectangle(500,410,400,200,Color.PURPLE);
            Raylib.DrawRectangleRec(aDoor,Color.BLACK);
            Raylib.DrawText("ANTIQUARY", 590, 450, 35, Color.BLACK);
              Raylib.DrawRectangleRec(player,Color.PURPLE);

             Raylib.EndDrawing();

        
        }
        static void DrawAntique(Rectangle player){
             Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
             Raylib.DrawText("Antiquary", 60, 80, 40, Color.BLACK);
              Raylib.DrawRectangleRec(player,Color.PURPLE);
              Raylib.EndDrawing();

        }
        static void DrawSecond(Rectangle player){
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
             Raylib.DrawText("Second hand", 60, 80, 40, Color.BLACK);
              Raylib.DrawRectangleRec(player,Color.PURPLE);
              Raylib.EndDrawing();
        }
    }
}
