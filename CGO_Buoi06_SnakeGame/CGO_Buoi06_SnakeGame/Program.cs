using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CGO_Buoi06_SnakeGame
{
    class Program
    {
        // Parameter
        public Random rand = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        int score, hiscore, headX, headY, fruitX, fruitY, nTail;
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        bool gameOver, reset, isprinted, horizontal, vertical, eatenFruit;
        string dir, pre_dir;

        int gamespeed = 100;
        enum FruitType
        {
            RedApple,
            BlueApple,
            YellowApple
        }
        FruitType currentFruit;

        //Hien thi man hinh bat dau
        void ShowBanner()
        {
            Console.SetWindowSize(width, height + panel); //height còn thêm thông báo panel
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;   //ẩn cỏn trỏ nháy
            Console.WriteLine("===SNAKE GAME===");
            Console.WriteLine("Huong dan choi game: ");
            Console.WriteLine("- Nhan phim bat ky de choi");
            Console.WriteLine("- Nhan phim P de tam dung choi");
            Console.WriteLine("- Nhan phim R de choi lai van moi");
            Console.WriteLine("- Nhan phim Q de ngung choi");
            //Doi nguoi choi bam phim
            keypress = Console.ReadKey();    //input key???
            if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
        }
        //Cai dat thong so ban dau game
        void Setup()
        {
            dir = "RIGHT"; pre_dir = ""; //mac dinh di chuyen sang phai
            score = 0; nTail = 0;
            gameOver = reset = isprinted = false;
            currentFruit = (FruitType)rand.Next(0, Enum.GetValues(typeof(FruitType)).Length);

            headX = 30; //vi tri dau tien con ran (dam bao ko vuot qua width)
            headY = 10; //vi tri dau tien con ran (dam bao ko vuot qua height)
            randomQua();//sinh ngau nhien phan qua 
        }
        //Sinh ngau nhien diem an qua
        void randomQua()
        {
            FruitType previousFruit = currentFruit;
            currentFruit = (FruitType)rand.Next(0, Enum.GetValues(typeof(FruitType)).Length);
          
            // Assign fruit coordinates based on the type
            switch (currentFruit)
            {
                case FruitType.RedApple:
                    fruitX = rand.Next(1, width - 1);
                    fruitY = rand.Next(1, height - 1);
                    if (eatenFruit)
                    {
                        score += GetFruitValue(previousFruit);
                        nTail += GetFruitValue(previousFruit);
                    }
                    break;
                case FruitType.BlueApple:
                    fruitX = rand.Next(1, width - 1);
                    fruitY = rand.Next(1, height - 1);
                    if (eatenFruit)
                    {
                        score += GetFruitValue(previousFruit);
                        nTail += GetFruitValue(previousFruit);
                    }
                    break;
                case FruitType.YellowApple:
                    fruitX = rand.Next(1, width - 1);
                    fruitY = rand.Next(1, height - 1);
                    if (eatenFruit)
                    {
                        score += GetFruitValue(previousFruit);
                        nTail  += GetFruitValue(previousFruit);
                    }
                    break;
            } 
        }
        int GetFruitValue(FruitType fruitType)
        {
            switch (fruitType)
            {
                case FruitType.RedApple:
                    return 2;
                case FruitType.BlueApple:
                    return 3;
                case FruitType.YellowApple:
                    return 4;
                default:
                    return 0;
            }
        }
        private void TypeFruit()
        {
            switch (currentFruit)
            {
                case FruitType.RedApple:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("?");

                    break;
                case FruitType.BlueApple:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("*");

                    break;
                case FruitType.YellowApple:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("#");
                    break;
            }
            
        }

        //Cap nhat man hinh khi thao tac
        void Update()
        {
            while (!gameOver)
            {
                //con choi tiep, chua co chet!!!
                CheckInput(); //cho bam phim
                Logic();      //kiem tra phim bam
                Render();     //hien thi man hinh
                if (reset) break;
                //Tang toc do con ran
               
                Thread.Sleep(GetgameSpeed()); //chay process trong vong 1000ml 
            }
            if (gameOver) {
              
                Lose();
                    }
        }
        int GetgameSpeed()
        {
            if (score >= 20 && score < 50)
            {
                gamespeed = 50;
            }
            else if (score >= 50)
            {
                gamespeed = 10;
            }
            return gamespeed;
        }
        //Dieu khien phim
        void CheckInput()
        {
            while (Console.KeyAvailable)
            {
                //CHo bam phim bat ky 
                keypress = Console.ReadKey();
                //luu lai thao tac phim truoc do
                pre_dir = dir;
                switch (keypress.Key)
                {
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;

                    case ConsoleKey.P: dir = "STOP"; break;   //play -> P (pause) -> stop
                    case ConsoleKey.Q: Environment.Exit(0); break;
                }
            }
        }
        //Kiem tra phim nhan dieu huong
        void Logic()
        {
            int preX = TailX[0], preY = TailY[0]; // (x,y)
            int tempX, tempY;
            //0 1 2 3 4 => Con rắn ăn thêm quà            //x 0 1 2 3 4 => Chen them vo mang
            if (dir != "STOP")
            {
                TailX[0] = headX; TailY[0] = headY;

                for (int i = 1; i < nTail; i++)
                {
                    tempX = TailX[i]; tempY = TailY[i];
                    TailX[i] = preX; TailY[i] = preY;
                    preX = tempX; preY = tempY;
                }
            }
            switch (dir)
            {
                case "LEFT": headX--; break;
                case "RIGHT": headX++; break;
                case "UP": headY--; break;
                case "DOWN": headY++; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear(); //xoa cac hien thi tren man hinh
                            Console.WriteLine("===SNAKE GAME===");
                            Console.WriteLine("Dang tam dung choi game!");
                            Console.WriteLine("- Nhan phim P de tiep tuc choi");
                            Console.WriteLine("- Nhan phim R de choi lai van moi");
                            Console.WriteLine("- Nhan phim Q de ngung choi");

                            keypress = Console.ReadKey();
                            if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                            if (keypress.Key == ConsoleKey.R)
                            {
                                reset = true; break;
                            }
                            if (keypress.Key == ConsoleKey.P) //tiep tuc choi du lieu dang luu TailX, TailY, ....
                                break;
                        }
                    }
                    dir = pre_dir; break;
            }
            //kiem tra va cham vat can 
            if (headX <= 0 || headX >= width - 1 || headY <= 0 || headY >= height - 1)
                gameOver = true;
            else gameOver = false;
            //kiem tra diem an qua
            if (headX == fruitX && headY == fruitY) //trung toa do
            {
                eatenFruit = true;    //tang kich thuoc con rang    
                randomQua();//khoi tao diem qua moi
            }
            //kiem tra di chuyen lien tuc
            //kiem tra di chuyen ngang LEFT , RIGHT
            if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) || ((dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                horizontal = true; //di chuyen lien tuc theo chieu ngang
            else horizontal = false;
            //kiem tra di chuyen doc UP, DOWN
            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) || ((dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                vertical = true; //di chuyen lien tuc theo chieu doc
            else vertical = false;

            //kiem tra con ran va cham than con ran
            for (int i = 1; i < nTail; i++)
            {
                if (headX == TailX[i] && headY == TailY[i])
                {
                    //quay dau 180
                    if (horizontal || vertical) gameOver = false;
                    else gameOver = true;
                }
                if (fruitX == TailX[i] && fruitY == TailY[i]) //qua sinh trung than con ran -> sinh lai ngau nhien qua
                    randomQua();
            }

           
        }
      
        //Hien thi thay doi man hinh
        void Render()
        {
          
            Console.SetCursorPosition(0, 0);
           
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {  //vien khung ben tren va duoi
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("_");
                    }
                    else if (j == 0 || j == width - 1)
                    {  //vien khung ben trai va phai
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("|");
                    }
                    else if (fruitX == j && fruitY == i) // qua
                    {
                        TypeFruit();
                    }
                    else if (headX == j && headY == i)
                    {  // dau cua con ran
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("O");
                    }
                    else
                    {   //than con ran
                        isprinted = false;
                        for (int k = 0; k < nTail; k++)
                        {
                            if (TailX[k] == j && TailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("o");
                     
                                isprinted = true;
                            }
                        }
                        if (!isprinted) Console.Write(" "); //o trong khung hinh
                    }
                }
                Console.WriteLine(); //xuong dong cuoi hang
            }
            //Hien thi panel thong tin
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Diem cua ban: " + score);
            Console.WriteLine("High Score: " + hiscore);
        }
        //Xy ly game thua
        void Lose()
        {
            if (score > hiscore)
            {
                eatenFruit = false;
                hiscore = score;
            }
            score = 0;
            // Lưu highScore vào dạng text
            Console.WriteLine("===SNAKE GAME===");
            Console.WriteLine("Ban da thua!");
            Console.WriteLine("- Nhan phim R de choi lai van moi");
            Console.WriteLine("- Nhan phim Q de ngung choi");

            while (true)
            {
                keypress = Console.ReadKey();
                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                if (keypress.Key == ConsoleKey.R)
                {
                    reset = true; break;
                }
            }
        }
        static void Main(string[] args)
        {
            Program snakegame = new Program();
            snakegame.ShowBanner();
            while (true)
            {
                snakegame.Setup();
                snakegame.Update();
                Console.Clear();
            }
        }
    }
}