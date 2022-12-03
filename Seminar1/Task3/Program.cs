Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            while (count < number)
            {
                if (count % 2 == 0)
                {
                Console.Write("Четное число = ");
                Console.WriteLine(count);
                count++;
                }
                else
                {
                count++;
                }
            }