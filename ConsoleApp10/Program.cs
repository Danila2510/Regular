using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Первое задание :

            string zadanie_1 = "ahb acb aeb aeeb adcb axeb";
            string oblast_1 = @"^a\wb$";
            MatchCollection sovp_1 = Regex.Matches(zadanie_1, oblast_1);
            findMyText(zadanie_1, sovp_1);
            Console.WriteLine();
            #endregion

            #region Второе задание :

            string zadanie_2 = "aba aca aea abba adca abea";
            string oblast_2 = @"a..a";
            MatchCollection sovp_2 = Regex.Matches(zadanie_2, oblast_2);
            findMyText(zadanie_2, sovp_2);
            Console.WriteLine();
            #endregion

            #region Третье задание :

            string zadanie_3 = "aba aca aea abba adca abea";
            string oblast_3 = @"a.(?!c).a";
            MatchCollection sovp_3 = Regex.Matches(zadanie_3, oblast_3);
            findMyText(zadanie_3, sovp_3);
            Console.WriteLine();
            #endregion

            #region Четвертое задание :

            string zadanie_4 = "aa aba abba abbba abca abea";
            string oblast_4 = @"ab+a";
            MatchCollection sovp_4 = Regex.Matches(zadanie_4, oblast_4);
            findMyText(zadanie_4, sovp_4);
            Console.WriteLine();
            #endregion

            #region Пятое задание :

            string zadanie_5 = "aa aba abba abbba abca abea";
            string oblast_5 = @"ab*?a";
            MatchCollection sovp_5 = Regex.Matches(zadanie_5, oblast_5);
            findMyText(zadanie_5, sovp_5);
            Console.WriteLine();
            #endregion

            #region Шестое задание : 

            string zadanie_6 = "aa aba abba abbba abca abea";
            string oblast_6 = @"ab?a";
            MatchCollection sovp_6 = Regex.Matches(zadanie_6, oblast_6);
            findMyText(zadanie_6, sovp_6);
            Console.WriteLine();
            #endregion

            #region Седьмое задание :

            string zadanie_7 = "aa aba abba abbba abca abea";
            string oblast_7 = @"ab?a";
            MatchCollection sovp_7 = Regex.Matches(zadanie_7, oblast_7);
            findMyText(zadanie_7, sovp_7);
            Console.WriteLine();
            #endregion

            #region Восьмое задание : 

            string zadanie_8 = "ab abab abab ab ababababab abea";
            string oblast_8 = @"\bab\b";
            MatchCollection sovp_8 = Regex.Matches(zadanie_8, oblast_8);
            findMyText(zadanie_8, sovp_8);
            Console.WriteLine();
            #endregion
        }
        static void findMyText(string text, MatchCollection myMatch)
        {
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }

        }
    }
}