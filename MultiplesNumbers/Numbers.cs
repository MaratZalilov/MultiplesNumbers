﻿namespace MultiplesNumbers;

public class Numbers
{
    public void Func(int number)
    {
        int summ = 0;
        for (int i = 1; i < number; i++)
        {
            if (i % 3 == 0)
            {
                summ += i;
                Console.WriteLine();
                Console.WriteLine($"{i} кратно трём");
            }
            else if (i % 5 == 0)
            {
                summ += i;
                Console.WriteLine();
                Console.WriteLine($"{i} кратно пяти");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма всех кратных чисел {summ}");
    }
}
