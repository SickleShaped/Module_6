namespace Module_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if(Load.HasValue && Load.Value>0)
                {
                    Console.WriteLine("Количество пассажиров = "+Load.Value);
                }
                else
                {
                    Console.WriteLine("Автобус пуст");
                }
            }
        }


    }
}