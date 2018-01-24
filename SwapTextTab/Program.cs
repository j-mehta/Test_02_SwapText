using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTextTab
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapText();
        }

        public static void SwapText()
        {
            string text = File.ReadAllText(@"C:\Users\j-mehta\Desktop\tabSwap\4.txt", Encoding.UTF8);

            string splitChar = string.Empty;

            if (text.Contains("\r\n"))
            {
                splitChar = "\r\n";
            }
            else if (text.Contains("\r"))
            {
                splitChar = "\r";
            }
            else if (text.Contains("\n"))
            {
                splitChar = "\n";
            }


            string[] SplitByLine = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            string ResultData = string.Empty;

            for (int intC = 0; intC < SplitByLine.Length; intC++)
            {
                string[] SplitByTab = SplitByLine[intC].Split('\t');
                if (SplitByTab.Length == 2)
                    ResultData = ResultData + SplitByTab[1] + '\t' + SplitByTab[0] + splitChar;

                //Console.Clear();
                Console.WriteLine(intC);
            }

            File.WriteAllText(@"C:\Users\j-mehta\Desktop\tabSwap\4_Res.txt", ResultData, Encoding.UTF8);

        }

    }
}
