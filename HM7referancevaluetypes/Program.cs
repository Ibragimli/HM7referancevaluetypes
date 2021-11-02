﻿using System;

namespace HM7referancevaluetypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Verilmis string variable-in deyerini icerisinde her soz arasinda bir bosluq gelecek vezyete salan metod.
            //Misalcun bu metoda deyeri " salam,      Dunya" olan string variable gondersek hemin metod bu variable-in
            //deyerini deyisidib "salam, Dunya" vezyetine salmalidir.Yəni göndırilən string-de sözlər arasında birdən
            //çox boşluq ola bilər, onu hər söz arasında bir boşluq olan vezyete salan metod yazırsınız.Metod geriyə dəyər qaytarmır!

            //Console.WriteLine("1)String deyerini girin:");
            //string text = Console.ReadLine();
            //spaceOne(text);



            //2. Gonderilmis string deyerinin asagidaki sertleri odeyib odemediyini qaytaran metod
            //-icinde en az 1 reqem olmalidir
            //-icinde en az 1 boyuk herf olmalidir
            //- icinde en az 1 kicik herf olmalidir

            //Console.WriteLine("2)String bir deyer daxil edin:");
            //Console.WriteLine($"Cavab-{checkDUL(Console.ReadLine())}");

            //3. Parameter olaraq integer array variable-i (reference) ve bir integer value qebul eden ve
            //hemin integer value-nu integer array-e yeni element kimi elave eden metod.
            //Console.WriteLine("3)Value daxil edin:");
            //int[] intArry = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //string numberstr = Console.ReadLine();
            //int number = Convert.ToInt32(numberstr);

            //int [] arry = returnNewArry(ref intArry,number);
            //foreach (var num in arry)
            //{
            //    Console.WriteLine(num);
            //}

            //4.Gonderilmis string deyerinideki sözlərdən ibaret array qaytaran metod 
            string word;

            string[] newstrArr = new string[0];
            string[] newStrArr = new string[0];
            do
            {
                Console.WriteLine("Stringi daxil edin: (Cixmaq ucun q-ya basin)");
                word = Console.ReadLine();
                newStrArr = getStringArry(ref newstrArr, word);
                
            } while (word != "q" );


            foreach (var words in  newStrArr)
            {
                Console.WriteLine($" Array-{word}");
            }
        }

        static void spaceOne(string space)
        {
            space = space.Trim();
            for (int i = 0; i < space.Length; i++)
            {
                while (space[i] == ' ' && space[i + 1] == ' ')
                {
                    space = space.Remove(i, 1);
                }

            }
            Console.WriteLine(space);
        }

        static bool checkDUL(string text1)
        {
            text1 = text1.Trim();
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            for (int i = 0; i < text1.Length; i++)
            {
                char chr = text1[i];
                if (char.IsUpper(chr))
                {
                    check1 = true;
                }
                if (char.IsLower(chr))
                {
                    check2 = true;
                }
                if (char.IsDigit(chr))
                {
                    check3 = true;
                }
                if (check1 == true && check2 == true && check3 == true)
                {
                    return true;
                }

            }
            return false;

        }

        static int[] returnNewArry(ref int[] intArry, int number)
        {
            int[] newIntArry = intArry;
            Array.Resize(ref newIntArry, intArry.Length + 1);
            newIntArry[newIntArry.Length - 1] = number;
            
            return newIntArry;
        }

        static string [] getStringArry(ref string[] intArry, string word)
        {
            string [] newStrArry = intArry;
            Array.Resize(ref newStrArry, intArry.Length + 1);
            newStrArry[newStrArry.Length - 1] = word;

            return newStrArry;
        }

        
    }
}
