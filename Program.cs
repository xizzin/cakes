using System.IO;
using System;


namespace cakes
{
    internal class Menu
    {   
        public static int ArrrowUpDown(int k, int b1)
        {
            ConsoleKeyInfo key;
            int b = k;
            key = Console.ReadKey();

            do
            {
                Console.SetCursorPosition(0, b);
                Console.WriteLine(" ");

                if (key.Key == ConsoleKey.UpArrow && b != k)
                {
                    b--;
                }
                else if (key.Key == ConsoleKey.DownArrow && b != b1)
                {
                    b++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }
                Console.SetCursorPosition(0, b);
                Console.WriteLine(">");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Enter);

            return b;
        }
    }

    internal class CakeAtribut
    {
        public string AtrubutName;
        public double price;

    }
    internal class Cake
    {
        static CakeAtribut Circle = new CakeAtribut()
        {      
            AtrubutName = "круглый торт",
            price = 1500
        };
        static CakeAtribut Square = new CakeAtribut()
        {
            AtrubutName = "квадратный торт",
            price = 1500
        };
        static CakeAtribut Octagon = new CakeAtribut()
        {
            AtrubutName = "октагонный торт",
            price = 1500
        };
        static CakeAtribut Triangle = new CakeAtribut()
        {
            AtrubutName = "треугольный торт",
            price = 1500
        };
        static CakeAtribut Sphere  = new CakeAtribut()
        {
            AtrubutName = "шарообразный торт",
            price = 3000
        };
        static CakeAtribut Author = new CakeAtribut()
        {
            AtrubutName = "авторский торт",
            price = 2500
        };

        static CakeAtribut Small = new CakeAtribut()
        {
            AtrubutName = "Маленький размер - 500 гр",
            price = 1000
        };
        static CakeAtribut Medium = new CakeAtribut()
        {
            AtrubutName = "Средний размер - 1 кг",
            price = 2000
        };
        static CakeAtribut Big = new CakeAtribut()
        {
            AtrubutName = "Крупный размер - 5 кг",
            price = 10000
        };
        static CakeAtribut SuperBig = new CakeAtribut()
        {
            AtrubutName = "максимальный торт - 20 кг",
            price = 45000
        };

        static CakeAtribut MilkTaste = new CakeAtribut()
        {
            AtrubutName = "Молочный вкус",
            price = 100
        };
        static CakeAtribut ChocTaste = new CakeAtribut()
        {
            AtrubutName = "Шоколадный вкус",
            price = 200
        };
        static CakeAtribut VanTaste = new CakeAtribut()
        {
            AtrubutName = "Ванильный вкус",
            price = 50
        };
        static CakeAtribut MangoTaste = new CakeAtribut()
        {
            AtrubutName = "Манговый вкус",
            price = 200
        };
        static CakeAtribut RaspbTaste = new CakeAtribut()
        {
            AtrubutName = "Малиновый вкус",
            price = 100
        };
        static CakeAtribut BananaTaste = new CakeAtribut()
        {
            AtrubutName = "Банановый вкус",
            price = 150
        };

        static CakeAtribut OneTier = new CakeAtribut()
        {
            AtrubutName = "один ярус",
            price = 0
        };
        static CakeAtribut TwoTier = new CakeAtribut()
        {
            AtrubutName = "один ярус",
            price = 1.5
        };
        static CakeAtribut ThreeTier = new CakeAtribut()
        {
            AtrubutName = "три яруса",
            price = 2.5
        };
        static CakeAtribut FourTier = new CakeAtribut()
        {
            AtrubutName = "четыре яруса",
            price = 3.6
        };

        static CakeAtribut Nocream = new CakeAtribut()
        {
            AtrubutName = "Без крема/глазури",
            price = 0
        };
        static CakeAtribut Berriescream = new CakeAtribut()
        {
            AtrubutName = "Ягодный крем",
            price = 300
        };
        static CakeAtribut Zavcream = new CakeAtribut()
        {
            AtrubutName = "Ягодный крем",
            price = 200
        };
        static CakeAtribut Milkcream = new CakeAtribut()
        {
            AtrubutName = "Сливочный крем",
            price = 300
        };
        static CakeAtribut Choccream = new CakeAtribut()
        {
            AtrubutName = "Шоколадный крем",
            price = 300
        };

        static CakeAtribut NoDecor = new CakeAtribut()
        {
            AtrubutName = "Без посыпки",
            price = 0
        };
        static CakeAtribut BerriesDecor = new CakeAtribut()
        {
            AtrubutName = "Ягоды",
            price = 150
        };
        static CakeAtribut ChocDecor = new CakeAtribut()
        {
            AtrubutName = "Шоколадная крошка",
            price = 100
        };
        static CakeAtribut MiniDecor = new CakeAtribut()
        {
            AtrubutName = "Мини-конфетки",
            price = 150
        };
        static CakeAtribut RainbowDecor = new CakeAtribut()
        {
            AtrubutName = "Радужные шарики",
            price = 100
        };
        static CakeAtribut BeadsDecor = new CakeAtribut()
        {
            AtrubutName = "Мелкие бусинки",
            price = 100
        };
        static List<CakeAtribut> Decor2 = new List<CakeAtribut>()
        { NoDecor, BerriesDecor, ChocDecor, MiniDecor, RainbowDecor, BeadsDecor};
        static List<CakeAtribut> Decor1 = new List<CakeAtribut>()
        { Nocream, Berriescream, Zavcream, Milkcream, Choccream};
        static List<CakeAtribut> Tiers = new List<CakeAtribut>()
        { OneTier, TwoTier, ThreeTier, FourTier};
        static List<CakeAtribut> Taste = new List<CakeAtribut>()
        { MilkTaste, ChocTaste,VanTaste, MangoTaste, RaspbTaste, BananaTaste};
        static List<CakeAtribut> Size = new List<CakeAtribut>()
        { Small, Medium, Big, SuperBig };
        static List<CakeAtribut> Form = new List<CakeAtribut>()
        { Circle, Square, Octagon, Triangle, Sphere, Author};
        public static List<List<CakeAtribut>> full = new List<List<CakeAtribut>>()
        { Form, Size, Taste, Tiers, Decor1, Decor2};
    }

    internal class Order
    {
        static List<string> order = new List<string>();

        public void Show(int a)
        {
            Console.Clear();

        }
        private void Thenames(int a)
        {

        }
        private void Total()
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Соберите торт(ы) и сделайте заказ! Вы должны выбрать что-то в каждом подпункте меню для того, чтобы полностью сосбрать торт. \nEsc возвращает Вас в главное меню и закрывает программу. \nEnter поволяет Вам подтвердить свой выбор в подпункте. Вы можете его изменить в любой момент до завершения торта. \nДля завершения сборки торта нажмите Enter в главном меню.");
            Console.WriteLine(" 1. Форма торта");
            Console.WriteLine(" 2. Размер/вес торта");
            Console.WriteLine(" 3. Количество ярусов торта");
            Console.WriteLine(" 4. Покрытие торта");
            Console.WriteLine(" 5. Декор торта");
            Console.WriteLine("Ваш заказ:");
            Console.WriteLine("Сумма заказа: ");
            int pos = Menu.ArrrowUpDown(5, 9);

        }
    }
}