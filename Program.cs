namespace Module_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
        }

        class Human
        {

            public Human()
            {
                name = "Неизвестно";
                age = 20;
            }
            // Конструктор 2
            public Human(string n)
            {
                name = n;
                age = 20;
            }
            // Конструктор 3
            public Human(string n, int a)
            {
                name = n;
                age = a;
            }

            // Поля класса
            public string name;
            public int age;

            // Метод класса
            public void Greetings()
            {
                Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
            }
        }

        struct Animal
        {

            // Поля структуры
            public string type;
            public string name;
            public int age;

            // Метод структуры
            public void Info()
            {
                Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
            }
        }

        class Pen
        {
            public Pen()
            {
                color = "Черный";
                cost = 100;
            }
            public Pen(string penColor, int penCost)
            {
                color=penColor;
                cost = penCost;
            }

            public string color;
            public int cost;
        }

        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle()
            {
                a = 6;
                b = 4;
            }

            public Rectangle(int side)
            {
                a = side;
                b = side;
            }

            public Rectangle(int first, int second)
            {
                a = first;
                b = second;
            }

            public int Square()
            {
                return a * b;
            }
        }


    }
}