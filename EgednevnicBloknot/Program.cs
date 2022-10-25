namespace EgednevnicBloknot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zapiska nowzametki = new Zapiska();
            Zapiska nowzametki2 = new Zapiska();
            Zapiska zametki = new Zapiska();
            Zapiska oldzametki = new Zapiska();
            Zapiska oldoldzametki = new Zapiska();

            nowzametki.Name = "Сходить на пары";
            nowzametki.Opisanie = "Описание: Чему-то научиться";
            nowzametki.Now2 = new DateTime(2022, 10, 15);

            nowzametki2.Name = "Написать программу";
            nowzametki2.Opisanie = "Описание: дописать начатую программу";
            nowzametki2.Now2 = new DateTime(2022, 10, 15);

            zametki.Name = "Сходить на тренировку";
            zametki.Opisanie = "выполнить комплекс упражнений";
            zametki.Now2 = new DateTime(2022, 10, 16);

            oldzametki.Name = "Купить корм кошкам";
            oldzametki.Opisanie = "Сходить в пятерочку и купить корм";
            oldzametki.Now2 = new DateTime(2022, 10, 14);

            oldoldzametki.Name = "Отдохнуть";
            oldoldzametki.Opisanie = "Сходить на турники";
            oldoldzametki.Now2 = new DateTime(2022, 10, 13);

            List<Zapiska> zapiski = new List<Zapiska>();
            zapiski.Add(nowzametki);
            zapiski.Add(nowzametki2);
            zapiski.Add(zametki);
            zapiski.Add(oldzametki);
            zapiski.Add(oldoldzametki);
            foreach (Zapiska pos in zapiski)
            {
                Console.WriteLine(pos.Name);
                Console.WriteLine(pos.Opisanie);
                Console.WriteLine(pos.Now2);
            }

            DateTime now = new DateTime(2022, 10, 15);
            DateTime contnow = new DateTime(2022, 10, 15);
            ConsoleKeyInfo clavisha = Console.ReadKey();
            int position = 1;
            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    now = now.AddDays(-1);

                }
                else if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    now = now.AddDays(1);
                }
                else if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                    position--;
                     if (position < 1)
                     {
                       position = 1;
                     }
                    }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                      position++;
                       if (position > 1)
                        {
                          position = 2;
                        }
                    }
                Console.Clear();
                Console.WriteLine("Выбрана дата" + " " + now);
                int q = 1;
                if (now == contnow)
                {
                    Console.WriteLine("    1. Пойти на пары ");
                    Console.WriteLine("    2. Написать программу");
                    q = 1;
                }
                else if (now == contnow.AddDays(-1))
                {
                    Console.WriteLine("    1. Купить корм кошкам ");
                    q = 2;
                }
                else if (now == contnow.AddDays(-2))
                {
                    Console.WriteLine("    1. Отдохнуть ");
                    q = 3;
                }
                else if (now == contnow.AddDays(1))
                {
                    Console.WriteLine("    1. Сходить на тренировку ");
                    q = 4;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
                clavisha = Console.ReadKey();
                Console.Clear();

                if (position == 1)
                {
                    if (q == 1)
                    {
                        Console.WriteLine(nowzametki.Name);
                        Console.WriteLine(nowzametki.Opisanie);
                        Console.WriteLine(nowzametki.Now2);
                    }
                    else if (q == 2)
                    {
                        Console.WriteLine(oldzametki.Name);
                        Console.WriteLine(oldzametki.Opisanie);
                        Console.WriteLine(oldzametki.Now2);
                    }
                    else if (q == 3)
                    {
                        Console.WriteLine(oldoldzametki.Name);
                        Console.WriteLine(oldoldzametki.Opisanie);
                        Console.WriteLine(oldoldzametki.Now2);
                    }
                    else if (q == 4)
                    {
                        Console.WriteLine(zametki.Name);
                        Console.WriteLine(zametki.Opisanie);
                        Console.WriteLine(zametki.Now2);
                    }
                }
                if (position == 2)
                {
                    if (q == 1)
                    {
                        Console.WriteLine(nowzametki2.Name);
                        Console.WriteLine(nowzametki2.Opisanie);
                        Console.WriteLine(nowzametki2.Now2);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}