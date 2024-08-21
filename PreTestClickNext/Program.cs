using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTestClickNext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool chkLoop = true;

            while (chkLoop)
            {
                try
                {
                    Console.WriteLine("[=========== Select Process Menu ===========]");
                    Console.WriteLine("Process [1]");
                    Console.WriteLine("Process [2]");
                    Console.WriteLine("Process [3]");
                    Console.WriteLine("Process [4]");
                    Console.WriteLine("Process [5]");
                    Console.WriteLine("Process [6]");
                    Console.WriteLine("Process [7]");
                    Console.WriteLine("Process [8]");
                    Console.WriteLine("Process [9]");
                    Console.WriteLine("Process [10]");
                    Console.WriteLine("Process [11]");
                    Console.WriteLine("Exit Program [0]");
                    Console.Write("Please Select Process: ");
                    int processNum = decConvert(Console.ReadLine());

                    if (processNum == 1)
                    {
                        int[] arr = { 1, 2, 3, 4, 5 };
                        int sum1 = 4;
                        test_1(arr, sum1);
                    }
                    else if (processNum == 2)
                    {
                        test_2();
                    }
                    else if (processNum == 3)
                    {
                        int []day1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 16, 17, 20, 23, 24 };
                        int []day2 = { 1, 4, 6, 9, 10, 14, 16, 17 };

                        test_3(day1);
                        test_3(day2);
                    }
                    else if (processNum == 4)
                    {
                        test_4();
                    }
                    else if (processNum == 5)
                    {
                        test_5();
                    }
                    else if (processNum == 6)
                    {
                        test_6();
                    }
                    else if (processNum == 7)
                    {
                        test_7();
                    }
                    else if (processNum == 8)
                    {
                        test_8();
                    }
                    else if (processNum == 9)
                    {
                        test_9();
                    }
                    else if (processNum == 10)
                    {
                        test_10();
                    }
                    else if (processNum == 11)
                    {
                        test_11();
                    }
                    else if (processNum == 0)
                    {
                        chkLoop = false;
                        Console.WriteLine("Good Bye!!");
                    }
                    else
                    {
                        Console.WriteLine("Please Select Menu");
                    }
                }
                catch (Exception e) { 
                
                
                }
            }

        }

        static void test_1(int[] arr, int targetSum)
        {
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            bool[] used = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (used[i]) { 
                    continue;
                } 

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (used[j]) continue;

                    if (arr[i] + arr[j] == targetSum)
                    {
                        pairs.Add(new Tuple<int, int>(arr[i], arr[j]));

                        used[i] = true;
                        used[j] = true;
                        break;
                    }
                }
            }

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Item1}, {pair.Item2}");
            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No pairs found.");
            }
        }

        static void test_2()
        {
            Console.Write("s1 = ");
            string s1 = Console.ReadLine();
            Console.Write("s2 = ");
            string s2 = Console.ReadLine();

            string str1="",str2="";
            bool chkStr = false;

            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    str1 += LowerCaseConvert(s1[i] + "");
                    str2 += LowerCaseConvert(s2[i] + "");
                }

                chkStr = stringInsertionSort(str1) == stringInsertionSort(str2);
                Console.WriteLine(chkStr);
            }
            else
            {
                Console.WriteLine(chkStr);
            }
        }

        static void test_3(int[]days)
        {
            if (days.Length == 0)
            {
                Console.WriteLine("No data.");
                return;
            }

            string result = "";

            int start = days[0];
            int end = days[0];


            for (int i = 1; i < days.Length; i++)
            {
                
                if (days[i] == end + 1)
                {
                    end = days[i];
                }
                else
                {
                    if (start == end)
                    {
                        result += start+"";
                    }
                    else
                    {
                        result += start + "-" + end;
                    }

                    result += ", ";

                    start = end = days[i];
                }
            }

            if (start == end)
            {
                result += start+"";
            }
            else
            {
                result += start + "-" + end;
            }

            Console.WriteLine(result);

        }

        static void test_4()
        {

            int num;
            Console.Write("Input: ");
            num = decConvert(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= ((2 * i)-1); j++)
                {
                    Console.Write("*");
                }
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        static void test_5()
        {

            int num;
            Console.Write("Input 1 - 4 : ");
            num = decConvert(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    if (number == 10)
                    {
                        Console.Write(" {0} ", 0);
                    }
                    else {
                        Console.Write(" {0} ", number);
                    }
                    
                    number++;
                }

                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        static void test_6() {
            Console.Write("Input 10 Number: ");
            string numbers = Console.ReadLine();
            char[] chNumber = arrayConvert(numbers);
            int size = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (chNumber[i] == ',')
                {
                    size++;
                }

            }

            string numCurrent = "";
            string[] numbers2 = new string[size];
            int numIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (chNumber[i] == ',')
                {
                    numbers2[numIndex] = numCurrent;
                    numCurrent = "";
                    numIndex++;
                }
                else if (chNumber[i] == ' ')
                {
                    continue;
                }
                else if ((i + 1) == numbers.Length)
                {
                    numCurrent += chNumber[i];
                    numbers2[numIndex] = numCurrent;
                    numCurrent = "";
                    numIndex++;
                }
                else
                {
                    numCurrent += chNumber[i];
                }
            }



            for (int i = 1; i < numbers2.Length; i++)
            {
                // แปลงตัวเลขจาก string เป็น int
                int current = decConvert(numbers2[i]);

                int j = i - 1;
                // วนลูปเลื่อนค่าที่มีขนาดมากกว่า current ไปยังตำแหน่งถัดไป
                while (j >= 0 && decConvert(numbers2[j]) < current)
                {
                    numbers2[j + 1] = numbers2[j]; // เลื่อนค่าที่มีขนาดมากกว่าไปข้างหน้า
                    j--;
                }

                // แทรก current ในตำแหน่งที่ถูกต้อง
                numbers2[j + 1] = current + "";
            }

            // แสดงผลลัพธ์การเรียงลำดับ
            foreach (var num in numbers2)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }

        static void test_7() {
            Console.Write("Input Time Second: ");
            int sec = decConvert(Console.ReadLine());
            int minute = sec / 60;
            int hour = minute / 60;

            string resSec=(sec%60)+"",resMinute= (minute % 60) + "",resHour= (hour % 24) + "";


            if (sec < 10)
            {
                resSec = "0" + (sec % 60);
            }

            if (minute < 10)
            {
                resMinute = "0" + (minute % 60);
            }

            if (hour < 10)
            {
                resHour = "0" + (hour % 60);
            }

            Console.WriteLine("{0}:{1}:{2}",resHour,resMinute,resSec);
            Console.WriteLine();
        }

        static void test_8()
        {

            int num, money500, money100, money50, money10,money5,money1;
            Console.Write("Input: ");
            num = decConvert(Console.ReadLine());
            int resMoney = 1000 - num;
            Console.WriteLine("จำนวนเงินทอน {0} บาท",resMoney);
            money500 = resMoney / 500;
            money100 = (resMoney % 500) / 100;
            money50 = ((resMoney % 500) % 100) / 50;
            money10 = (((resMoney % 500) % 100) % 50) / 10;
            money5 = ((((resMoney % 500) % 100) % 50) % 10) / 5;
            money1 = (((((resMoney % 500)%100) % 50) % 10) % 5) / 1;

            Console.WriteLine("500 {0} ใบ", money500);
            Console.WriteLine("100 {0} ใบ", money100);
            Console.WriteLine("50 {0} ใบ", money50);
            Console.WriteLine("10 {0} เหรียญ", money10);
            Console.WriteLine("5 {0} เหรียญ", money5);
            Console.WriteLine("1 {0} เหรียญ", money1);

        }

        static void test_9()
        {
            Console.Write("Input Text: ");
            string str = Console.ReadLine();
            char[] ch = arrayConvert(str);
            int size = 1;
            for (int i = 0; i < str.Length; i++)
            {

                if (ch[i] == ' ')
                {
                    size++;
                }

            }
            
            string strCurrent = "";
            string[] str2 = new string[size];
            int strIndex = 0;

            string[] strReverse = new string[size];
            

            for (int i = 0; i < str.Length; i++)
            {
                if (ch[i] == ' ')
                {

                    str2[strIndex] = strCurrent;
                    //Console.WriteLine(str2[strIndex]);
                    strCurrent = "";
                    strIndex++;
                }else if ((i + 1) == str.Length)
                {
                    strCurrent += ch[i];
                    //Console.WriteLine("Last Index");
                    str2[strIndex] = strCurrent;
                    //Console.WriteLine(str2[strIndex]);
                    strCurrent = "";
                    strIndex++;
                }
                else
                {
                    strCurrent += ch[i];
                }
            }



            for (int i = 0; i < str2.Length; i++)
            {
                char[] reverse = str2[i].ToCharArray();

                // เริ่มจากดัชนีสุดท้ายของอาร์เรย์
                for (int j = reverse.Length - 1; j >= 0; j--)
                {
                    Console.Write("{0}", reverse[j]);
                }

                Console.Write(" "); // ไปที่บรรทัดถัดไปหลังจากพิมพ์คำที่ย้อนกลับ
            }
            Console.WriteLine();


        }

        static void test_10() {

            int num;
            Console.Write("Input: ");
            num = decConvert(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j > i ; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < ((2 * i) - 1); j++)
                {
                    Console.Write("*");
                }

                for (int j = num; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        
        static void test_11()
        {

            Console.Write("Input 10 Number: ");
            string numbers = Console.ReadLine();
            char[] chNumber = arrayConvert(numbers);
            int size = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (chNumber[i] == ',')
                {
                    size++;
                }

            }

            string numCurrent = "";
            string[] numbers2 = new string[size];
            int numIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (chNumber[i] == ',')
                {
                    numbers2[numIndex] = numCurrent;
                    numCurrent = "";
                    numIndex++;
                }
                else if (chNumber[i] == ' ')
                {
                    continue;
                }
                else if ((i + 1) == numbers.Length)
                {
                    numCurrent += chNumber[i];
                    numbers2[numIndex] = numCurrent;
                    numCurrent = "";
                    numIndex++;
                }
                else
                {
                    numCurrent += chNumber[i];
                }
            }



            for (int i = 1; i < numbers2.Length; i++)
            {
                int current = decConvert(numbers2[i]);
                
                int j = i - 1;
                while ( j >= 0 && decConvert(numbers2[j]) > current)
                {
                    numbers2[j + 1] = numbers2[j];
                    j--;
                }
                numbers2[j + 1] = current+"";
            }
            foreach (var num in numbers2)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

        }

        static string LowerCaseConvert(string str)
        {

            if (str == "a" || str == "A")
            {
                return "a";
            }
            else if (str == "b" || str == "B")
            {
                return "b";
            }
            else if (str == "c" || str == "C")
            {
                return "c";
            }
            else if (str == "d" || str == "D")
            {
                return "d";
            }
            else if (str == "e" || str == "E")
            {
                return "e";
            }
            else if (str == "f" || str == "F")
            {
                return "f";
            }
            else if (str == "g" || str == "G")
            {
                return "g";
            }
            else if (str == "h" || str == "H")
            {
                return "h";
            }
            else if (str == "i" || str == "I")
            {
                return "i";
            }
            else if (str == "j" || str == "J")
            {
                return "j";
            }
            else if (str == "k" || str == "K")
            {
                return "k";
            }
            else if (str == "j" || str == "L")
            {
                return "j";
            }
            else if (str == "m" || str == "M")
            {
                return "m";
            }
            else if (str == "n" || str == "N")
            {
                return "n";
            }
            else if (str == "o" || str == "O")
            {
                return "o";
            }
            else if (str == "p" || str == "P")
            {
                return "p";
            }
            else if (str == "q" || str == "Q")
            {
                return "q";
            }
            else if (str == "r" || str == "R")
            {
                return "r";
            }
            else if (str == "s" || str == "S")
            {
                return "s";
            }
            else if (str == "t" || str == "T")
            {
                return "t";
            }
            else if (str == "u" || str == "U")
            {
                return "u";
            }
            else if (str == "v" || str == "V")
            {
                return "v";
            }
            else if (str == "w" || str == "W")
            {
                return "w";
            }
            else if (str == "x" || str == "X")
            {
                return "x";
            }
            else if (str == "y" || str == "Y")
            {
                return "y";
            }
            else if (str == "z" || str == "Z")
            {
                return "z";
            }
            else
            {
                return "No String";
            }

        }

        static string stringInsertionSort(string str)
        {
            char[] arr = arrayConvert(str);
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                char key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            return new string(arr);
        }

        static int decConvert(string input) {

            bool isNegative = input[0] == '-';
            int startIndex = isNegative ? 1 : 0;


            int number = 0;
            for (int i = startIndex; i < input.Length; i++)
            {

                if (input[i] >= '0' && input[i] <= '9')
                {
                    number = number * 10 + (input[i] - '0');
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return 0 ;
                }
            }


            if (isNegative)
            {
                number = -number;
            }

            return number;
        }

        static char[] arrayConvert(string str)
        {
            char[] characters = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                characters[i] = str[i];
            }

            return characters;
        }
    }
}
