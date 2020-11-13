using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurs
{
    class Plagiator
    {
        int MIN_LCS_LENGTH = 17; //мінімальна довжина однакової ділянки коду, яка свідчить про плагіат
        public double LongestCommonSubstringTest(string test, string other)//модифікований метод найдовшого спільного рядка
            //test - рядок, який перевіряємо на плагіат
            //other - рядок, із яким перевіряємо
        {
            int originalLength = test.Length;//початкова довжина рядка
            int lcsLength;//довжина найдовшого спільного рядка (НСР)
            do//повторюємо дії, поки НСР не буде закоротким
            {
                int n = test.Length;
                int m = other.Length;
                int[,] matr = new int[n, m];
                lcsLength = 0;
                int maxI = 0;
                for (int i = 0; i < n; i++)//заповнює матрицю пошуку НСР
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (test[i] == other[j])
                        {
                            matr[i, j] = (i == 0 || j == 0) ? 1 : matr[i - 1, j - 1] + 1;
                            if (matr[i, j] > lcsLength)
                            {
                                lcsLength = matr[i, j];
                                maxI = i;
                            }
                        }
                    }
                }

                if (lcsLength > 0)//якщо НСР знайдено
                {
                    string lcs = test.Substring(maxI + 1 - lcsLength, lcsLength);//знаходимо цей НСР
                    test = test.Replace(lcs, "");//видаляємо з рядка, який перевіряємо, всі входження НСР
                    other = other.Remove(other.IndexOf(lcs), lcsLength);//із рядка, з яким перевіряємо, видаляємо лише перше входження НСР
                }
            }
            while (lcsLength >= MIN_LCS_LENGTH);//повторюємо дії, поки НСР не буде закоротким

            //коефіцієнт плагіату знаходиться як відношення довжини унікальної частини тексту до всієї довжини рядка
            return 1.0 - (double)test.Length / originalLength;
        }

        public double WShinglingTest(string test, string other)//метод шинглів
        {
            //шукаємо шингли рядка test та відразу рахуємо їхній хеш
            int testCountShingles = test.Length - MIN_LCS_LENGTH + 1;
            List<int> testShingles = new List<int>();
            for (int i = 0; i < testCountShingles; ++i)
            {
                testShingles.Add(test.Substring(i, MIN_LCS_LENGTH).GetHashCode());
            }
            
            //шукаємо шингли рядка other та відразу рахуємо їхній хеш
            int otherCountShingles = other.Length - MIN_LCS_LENGTH + 1;
            List<int> otherShingles = new List<int>();
            for (int i = 0; i < otherCountShingles; ++i)
            {
                otherShingles.Add(other.Substring(i, MIN_LCS_LENGTH).GetHashCode());
            }

            //коефіцієнт плагіату знаходиться як відношення кількості однакових хешів до кількості всіх хешів рядка test
            return (double)testShingles.Intersect(otherShingles).Count() / testShingles.Distinct().Count();
        }
    
        public double AveragePlagTest(string test, string other)//середнє арифметичне обох методів
        {
            return (LongestCommonSubstringTest(test, other) + WShinglingTest(test, other)) / 2;
        }
    }
}
