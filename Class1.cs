using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ref
{
    public class ClassRef
    { /* SkipSpaces пропускает все пробельные символы в text, 
        начиная с позиции pos.
        В конце pos оказывается установлен в первый непробельный символ.*/
        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }
        /*ReadNumber пропускает все цифры в text, начиная с позиции pos,
         * а затем возвращает все пропущенные символы. 
         * В конце pos оказывается установлен в первый символ не цифру.*/
        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }
        /*WriteAllNumbersFromText функция, 
         * которая читает все числа из строк
         * и выводит их, разделяя единственным пробелом.*/
        public static void WriteAllNumbersFromText(string text)
        {
            int pos = 0;
            while (true)
            {
                SkipSpaces(text, ref pos);
                // skip spaces

                var num = ReadNumber(text, ref pos); // read next number
                if (num == "") break;
                Console.Write(num + " ");
            }
            Console.WriteLine();

        }
    }
}
