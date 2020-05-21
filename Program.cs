using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperateBigNumbers
{

    class BigNumOperater
    {

        private bool negetive; // for devition it used

        private int num1Length;
        private int num2Length;

        private int maxLength;
        private int minLength;
        private int[] num1;
        private int[] num2;

       /* private int[] sum;*/      
       /* private int[] minus;*/
        /*private int[] multiply;*/
        //private int[] devision;



        // constructor 
        public BigNumOperater(string Snum1, string Snum2,int count,string[] Operators)
        {
            negetive = false;
            num1Length =Snum1.Length;
            num2Length = Snum2.Length;


            // set max lengh and min lengh of the two inputs
            if (Snum1.Length > Snum2.Length)
            {
                maxLength = num1Length;
                minLength = num2Length;
            }
            else
            {
                maxLength = num2Length;
                minLength = num1Length;
            }
            num1 = new int[maxLength];   // changed maxLength to num1Length
            num2 = new int[maxLength];   // changed maxLength to num2Length
            /*sum = new int[maxLength+1];*/
            /*minus = new int[maxLength];*/
           // devision= new int[maxLength];
           /* multiply = new int[num1Length+num2Length];*/


            // store the input numbers in an arrays that any index of these arrays represent if the place of the digits from right to left 
            // num1:>>
            for (int i=0; i < num1Length; i++)
            {
                int index = num1Length - 1 - i;
                num1[i]=(int)Snum1[index]-48;
            }
            //num2:>>
            for (int i = 0; i < num2Length; i++)
            {
                int index = num2Length - 1 - i;
                num2[i] = (int)Snum2[index]-48;
            }

            Console.ForegroundColor = ConsoleColor.Green;

/*
            Console.WriteLine("A+B"+Sum(Snum1,Snum2));
            Console.WriteLine("A-B = "+Subtraction(Snum1,Snum2));
            Console.WriteLine("");
            //Console.WriteLine(Subtraction(Snum1,Snum2));

            Console.WriteLine("A/B = " + Devision(Snum1, Snum2));
            Console.WriteLine("A*B = "+Multiply(Snum1, Snum2));

            Console.WriteLine("A%B = " + Reminder(Snum1, Snum2));


            Console.WriteLine("LCM = " + LCM(Snum1, Snum2));
            Console.WriteLine("GCD = " + GCD(Snum1, Snum2));

      
            Console.WriteLine("A abs= " + ABS(Snum1));
            Console.WriteLine("B abs= " + ABS(Snum2));*/


            Print(Operators, count, Snum1, Snum2);

        }

        public void Print(string[] s,int count,string Snum1,string Snum2)
        {
            
            if(count!=0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            }
            else
            {
                Console.WriteLine("\nYou entered 0 , then there is nothig i should do XD. have a good time sir ! bye");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+");


            }
            for (int i=0;i<count;i++)
            {
               
                
                Console.ForegroundColor = ConsoleColor.Green;
                if (s[i]=="+")
                    Console.WriteLine("A+B = " + Sum(Snum1, Snum2));
                else if(s[i]=="-")
                    Console.WriteLine("A-B = " + Subtraction(Snum1, Snum2));
                else if(s[i]=="*")
                    Console.WriteLine("A*B = " + Multiply(Snum1, Snum2));
                else if(s[i]=="/")
                    Console.WriteLine("A/B = " + Devision(Snum1, Snum2));
                else if (s[i]=="%")
                    Console.WriteLine("A%B = " + Reminder(Snum1, Snum2));
                else if (s[i] == "abs")
                {
                    Console.WriteLine("A abs= " + ABS(Snum1));
                    Console.WriteLine("B abs= " + ABS(Snum2));
                }
                else if(s[i]=="gcd")
                    Console.WriteLine("GCD = " + GCD(Snum1, Snum2));
                else if (s[i] == "lcm")
                    Console.WriteLine("LCM = " + LCM(Snum1, Snum2));


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*^*");

            }
        }



        /// <summary>
        /// /moghayese 2 addad    if n1>n2  return 1  if 1==2  return =  if 1<2  return -1
        /// </summary>
        public int Compare()
        {
            if (num1Length > num2Length)
                return 1;
            else if (num1Length < num2Length)
                return -1;
            else
            {
                for(int i=maxLength-1;i>=0;i--)
                {
                    if (num1[i] > num2[i])
                        return 1;
                    else if (num1[i] < num2[i])
                        return -1;

                }
                return 0;

            }
        }


        public int CompareNumbers(string number1, string number2)
        {
            if (number1.Length > number2.Length)
                return 1;
            else if (number1.Length < number2.Length)
                return -1;
            else// equal lengthes
            {
                for (int i = 0; i < number2.Length; i++)
                {
                    if ((number1[i]-'0') > (number2[i]-'0'))
                        return 1;
                    else if ((number1[i] - '0') < (number2[i] - '0'))
                        return -1;

                }
                return 0;

            }
        }
        


        // operater functions !!!    ( +  -  *  %  lcm   gcd  abs )

        // +     ( This function Writes Sum of the Two numbers
        public string Sum(string number1, string number2)
        {
            string RawNum1="";
            string RawNum2="";



            int Raw1Length; //positive length
            int Raw2Length;
            bool n1Negetive = false;
            bool n2Negetive = false;
            int HighestLenght=0;

            /// chek which number is negetive  and intialize the positive form of numbers
            if (number1[0] == '-')
            {
                for (int i = 1; i < number1.Length; i++)
                {
                    RawNum1+=number1[i];
                }
                n1Negetive = true;
            }
            else
            {
                RawNum1 = number1;
            }

            if (number2[0] == '-')
            {
                for (int i = 1; i < number2.Length; i++)
                {
                    RawNum2+=number2[i];
                }
                n2Negetive = true;
            }
            else
            {
                RawNum2 = number2;
            }

            Raw1Length = RawNum1.Length;
            Raw2Length = RawNum2.Length;
            HighestLenght = RawNum1.Length;


            if(Raw2Length>Raw1Length)
            {
                HighestLenght= RawNum2.Length;
            }

            
            int[] sum = new int[HighestLenght + 1];





            int[] An1 = new int[HighestLenght];
            int[] An2 = new int[HighestLenght];

            for (int i = 0; i < Raw1Length; i++)
            {
                int index = Raw1Length - 1 - i;
                 An1[i] = (int)RawNum1[index] - 48;
            }
            for (int i = 0; i < Raw2Length; i++)
            {
                int index = Raw2Length - 1 - i;
                An2[i] = (int)RawNum2[index] - 48;
            }


            // 3 Types:  ++   +-/-+   --


            if((n1Negetive==false&&n2Negetive==false)|| (n1Negetive == true && n2Negetive == true)) // both +or-
            {
                // holds the  Tens digit of sum of two digit
                int hold = 0;
                int MxLen = HighestLenght;
               

                string strSum = "";
                if(n1Negetive==true)
                {
                    strSum += "-";
                }

             /*   if (An2.Length > An2.Length)
                {
                    MxLen = An2.Length;
                    MnLen = An1.Length;
                }*/

                // calculate sum of two integrs and put all the digits in an array

                for (int i = 0; i < MxLen; i++)
                {
                    int SUM = An1[i] + An2[i] + hold;
                    sum[i] = SUM % 10;

                    if (SUM > 9)
                        hold = 1;
                    else
                        hold = 0;
                }
                sum[MxLen] = hold;

                for (int i = MxLen; i >= 0; i--)
                {
                    if (i == MxLen)
                    {
                        if (sum[i] == 0)
                        {
                            continue;
                        }
                        else
                        {
                            strSum += sum[i];
                        }
                    }
                    else
                    {

                        strSum += sum[i];
                    }
                }

                return (strSum);

            }
            else
            {
                if(n1Negetive==true)//n2-n1
                {
                    return Subtraction(RawNum2, RawNum1);
                
                }
                else//(+n1  -n2)
                {
                    return Subtraction(RawNum1, RawNum2);
                }
            }
        




            /*  Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
              // Write n1+n2=sum  on the screen (green output);
              Console.ForegroundColor = ConsoleColor.Green;
              for (int i = num1Length-1; i >= 0; i--)
              {
                  Console.Write(num1[i]);
              }

              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.Write(" + ");
              Console.ForegroundColor = ConsoleColor.Green;

              for (int i = num2Length-1; i >=0; i--)
              {
                  Console.Write(num2[i]);
              }

              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.Write(" = ");
              Console.ForegroundColor = ConsoleColor.Green;

              for (int i = maxLength; i >=0 ; i--)
              {
                  if(i==maxLength)
                      if (sum[maxLength] == 0)
                          continue;
                  Console.Write(sum[i]);
              }


              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
              Console.ResetColor();
              */


        }

        //##########################<< MINUS >###########################
        
        public string Subtraction(string number1 , string number2)  // change num1-> An1  num2->An2
        {
            ///////////// negetive or posetive is shown by the (Bool Negetive )
            bool NeGeTive = false;

            // define an array
            int[] An1 = new int[number1.Length];
            int[] An2 = new int[number2.Length];
            string RawNum1 = "";
            string RawNum2 = "";




            int Raw1Length; //positive length
            int Raw2Length;
            bool n1Negetive = false;
            bool n2Negetive = false;
           

            /// chek which number is negetive  and intialize the RAw number1
            if (number1[0] == '-')
            {
                for (int i = 1; i < number1.Length; i++)
                {
                    RawNum1 += number1[i];
                }
                n1Negetive = true;
            }
            else
            {
                RawNum1 = number1;
            }
            // RAW number2
            if (number2[0] == '-')
            {
                for (int i = 1; i < number2.Length; i++)
                {
                    RawNum2 += number2[i];
                }
                n2Negetive = true;
            }
            else
            {
                RawNum2 = number2;
            }

            Raw1Length = RawNum1.Length;
            Raw2Length = RawNum2.Length;
            

            //initialaze array of number
            for (int i = 0; i < Raw1Length; i++)
            {
                int index = Raw1Length - 1 - i;
                An1[i] = (int)RawNum1[index] - 48;
            }
            for (int i = 0; i < Raw2Length; i++)
            {
                int index = Raw2Length - 1 - i;
                An2[i] = (int)RawNum2[index] - 48;
            }


            ///////////////////////////////////////////////////////
            if( (n1Negetive == true && n2Negetive == true))
            {
                return Subtraction(RawNum2,RawNum1);
            }
            else if(n1Negetive==true||n2Negetive==true)// +n1 &-n2 or reverse    ( like sum)
            {
                if(n1Negetive==true)  // -(a+b)
                {
                    string result = "-";
                    result += Sum(RawNum1, RawNum2);
                    return result;
                }
                else   //A+B
                {
                    return Sum(RawNum1, RawNum2);
                }
            }
            else
            {
                string strSubtraction = "";



                int MxLen = Raw1Length;
                int MnLen = Raw2Length;

                int An1Length = An1.Length;
                int An2Length = An2.Length;

                if (Raw2Length > Raw1Length)
                {
                    MxLen = Raw2Length;
                    MnLen = Raw1Length;
                }

                int[] n1 = new int[MxLen];
                int[] n2 = new int[MxLen];

                int[] minus = new int[MxLen];


                Array.Copy(An1, n1, An1Length);
                Array.Copy(An2, n2, An2Length);



                if (An1Length > An2Length)
                {
                    // if (num1[An1Length-1]> num2[An2Length - 1])              //chera gozashtam?
                    {
                        for (int i = 0; i < MxLen; i++)
                        {
                            if (i == MnLen)
                            {
                                break;
                            }
                            else if (n1[i] >= n2[i])
                                minus[i] = n1[i] - n2[i];
                            else
                            {
                                //kam kardan ye addad az maratebe bala tar

                                while (n1[i + 1] == 0)    //1001-3
                                {
                                    int j = i + 1;
                                    while (n1[j] == 0)
                                    {
                                        j++;
                                    }
                                    n1[j] -= 1;
                                    n1[j - 1] += 10;

                                }
                                n1[i + 1] -= 1;
                                n1[i] += 10;
                                minus[i] = n1[i] - n2[i];


                            }
                        }
                        for (int i = MnLen; i < MxLen; i++)
                        {
                            minus[i] = n1[i];
                        }

                    }
                }
                else if (An1Length == An2Length)
                {
                    // if n1>n2
                    if (CompareNumbers(RawNum1, RawNum2) == 1)
                    {
                        NeGeTive = false;
                        for (int i = 0; i < MxLen; i++)
                        {
                            //============= copy
                            if (n1[i] >= n2[i])
                                minus[i] = n1[i] - n2[i];
                            else
                            {
                                //kam kardan ye addad az maratebe bala tar
                                if (i == MxLen - 1)
                                {
                                    minus[i] = n2[i] - n1[i];
                                   //negetive = true;
                                }
                                else
                                {
                                    bool end = false; // if cant add any thing to num1 -> end=true;
                                    while (n1[i + 1] == 0)    //1001-3
                                    {

                                        int j = i + 1;
                                        while (n1[j] == 0)
                                        {
                                            if (j == MxLen - 1)
                                            {
                                                end = true;
                                                break;
                                            }
                                            j++;
                                        }
                                        if (end == false)
                                        {
                                            n1[j] -= 1;
                                            n1[j - 1] += 10;
                                        }

                                    }
                                    if (end == false)
                                    {
                                        n1[i + 1] -= 1;
                                        n1[i] += 10;
                                        minus[i] = n1[i] - n2[i];
                                    }
                                }
                            }
                        }

                    }

                    else if (CompareNumbers(number1, number2) == -1)//if n1<n2
                    {
                        NeGeTive = true;

                        for (int i = 0; i < MxLen; i++)
                        {
                            if (n2[i] >= n1[i])
                            {
                                minus[i] = n2[i] - n1[i];
                            }
                            else
                            {
                                while (n2[i + 1] == 0)    //1001-3
                                {
                                    int j = i + 1;
                                    while (n2[j] == 0)
                                    {
                                        j++;
                                    }
                                    n2[j] -= 1;
                                    n2[j - 1] += 10;

                                }
                                n2[i + 1] -= 1;
                                n2[i] += 10;
                                minus[i] = n2[i] - n1[i];



                            }

                        }

                    }


                }
                else if (An1Length < An2Length)
                {
                    NeGeTive = true;

                    for (int i = 0; i < MxLen; i++)
                    {
                        if (i == MnLen)
                        {
                            break;
                        }
                        else if (n2[i] >= n1[i])
                            minus[i] = n2[i] - n1[i];
                        else
                        {
                            //kam kardan ye addad az maratebe bala tar

                            while (n2[i + 1] == 0)    //1001-3
                            {
                                int j = i + 1;
                                while (n2[j] == 0)
                                {
                                    j++;
                                }
                                n2[j] -= 1;
                                n2[j - 1] += 10;

                            }
                            n2[i + 1] -= 1;
                            n2[i] += 10;
                            minus[i] = n2[i] - n1[i];


                        }
                    }
                    for (int i = MnLen; i < MxLen; i++)
                    {
                        minus[i] = n2[i];
                    }


                }
                int StrarterIndex = MxLen - 1; //index of the last zero
            
                while(minus[StrarterIndex] ==0)
                {
                    if (StrarterIndex == 0)
                        break;
                    StrarterIndex--;

                }

                for (int i = StrarterIndex; i >= 0; i--)
                {

                        strSubtraction += minus[i];
                    
                }

                if (NeGeTive == true)
                {
                    string x = "-";
                    x += strSubtraction;
                    return x;
                }
                return strSubtraction;
            }


            ////////////////////////
            

           /* Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = An1Length - 1; i >= 0; i--)
            {
                Console.Write(num1[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = An2Length - 1; i >= 0; i--)
            {
                Console.Write(num2[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" = ");


            Console.ForegroundColor = ConsoleColor.Red;
            if (negetive == true)
                Console.Write("-");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = maxLength-1; i >= 0; i--)
            {
                if (i == maxLength-1)
                    if (minus[maxLength-1] == 0)
                        continue;
                Console.Write(minus[i]);
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------------------------------------------------------------------------\n");
            
             */
        }




        // //########################## << Multiply >>###########################
        public string Multiply(string number1, string number2)
        {
            /*int A1Length = number1.Length;
            int A2Length = number2.Length;*/
            string strMultiply = "";

            string RawNum1 = "";
            string RawNum2 = "";
            int[] multiply = new int[number1.Length+number2.Length];



            int Raw1Length; //positive length
            int Raw2Length;
            bool n1Negetive = false;
            bool n2Negetive = false;


            /// chek which number is negetive  and intialize the RAw number1
            if (number1[0] == '-')
            {
                for (int i = 1; i < number1.Length; i++)
                {
                    RawNum1 += number1[i];
                }
                n1Negetive = true;
            }
            else
            {
                RawNum1 = number1;
            }
            // RAW number2
            if (number2[0] == '-')
            {
                for (int i = 1; i < number2.Length; i++)
                {
                    RawNum2 += number2[i];
                }
                n2Negetive = true;
            }
            else
            {
                RawNum2 = number2;
            }


            bool NeGeTive = false;            
            //sighn
            if(n1Negetive==n2Negetive)
            {
                NeGeTive = false;
            }
            else
            {
                NeGeTive = true;
            }
            //

            Raw1Length = RawNum1.Length;
            Raw2Length = RawNum2.Length;
            /////
            ///
            /// 
            /////////////  Main 
            if ((Raw1Length == 1 && RawNum1[0] == '0')|| (Raw2Length == 1 && RawNum2[0] == '0'))
            {
                return "0";
            }

            int i_n1 = 0; //index of n1
            int i_n2 = 0;
            for (int i = Raw1Length- 1; i >= 0; i--)
            {
                
                int hold = 0;
                int n1 = RawNum1[i]-'0';

                i_n2 = 0;
                for (int j = Raw2Length - 1 ; j>=0; j--)
                {
                    int n2 = RawNum2[j] - '0';

                    int SuM = n1 * n2 + hold + multiply[i_n1 + i_n2];
                    hold = SuM / 10;

                    multiply[i_n1 + i_n2] = SuM % 10;
                    i_n2++;
                }

                // store hold in the next cell ;
                if (hold > 0)
                    multiply[i_n2 + i_n1] += hold;

                i_n1++;
            }

            int index = multiply.Length - 1;

            while (multiply[index] == 0)
                index--;

            for (int i = index; i >= 0; i--)
                strMultiply += multiply[i];
            if(NeGeTive==true)
            {
                string result = "-";
                result += strMultiply;
                return result;
            }
            else
                return strMultiply;

        }
    
        // //########################## << Devision >>###########################
        public string Devision(string number1,string number2)
        {

            if (number2 == "0")
            {
                return "Error! cnat divide sth to 0 !";
            }


            string RawNum1 = "";
            string RawNum2 = "";

   
            bool n1Negetive = false;
            bool n2Negetive = false;


            /// chek which number is negetive  and intialize the RAw number1
            if (number1[0] == '-')
            {
                for (int i = 1; i < number1.Length; i++)
                {
                    RawNum1 += number1[i];
                }
                n1Negetive = true;
            }
            else
            {
                RawNum1 = number1;
            }
            // RAW number2
            if (number2[0] == '-')
            {
                for (int i = 1; i < number2.Length; i++)
                {
                    RawNum2 += number2[i];
                }
                n2Negetive = true;
            }
            else
            {
                RawNum2 = number2;
            }


            bool NeGeTive = false;
            //sighn
            if (n1Negetive == n2Negetive)
            {
                NeGeTive = false;
            }
            else
            {
                NeGeTive = true;
            }


            /////////////////////////////////////////////// main >

            string TestNum = RawNum1;
            string result = "0";
            
            if(RawNum1=="1")
            {
                if(NeGeTive==true)
                {
                    string flag = "-";
                    flag += RawNum2;
                    return flag;
                }
                return RawNum2;
            }
            else if (RawNum2 == "1")
            {
                if (NeGeTive == true)
                {
                    string flag = "-";
                    flag += RawNum1;
                    return flag;
                }
                return RawNum1;
            }
            
            while (CompareNumbers(TestNum, RawNum2) !=-1)
            {
                result=Sum(result, "1");
                TestNum = Subtraction(TestNum, RawNum2);
            }
            if (result != "0")
            {
                if(NeGeTive==true)
                {
                    string answer = "-";
                    answer += result;
                    return answer;
                }
            }
           return result;
        }


        public string Reminder(string number1, string number2)
        {
            string RawNum1 = "";
            string RawNum2 = "";

      
            /// chek which number is negetive  and intialize the RAw number1
            if (number1[0] == '-')
            {
                for (int i = 1; i < number1.Length; i++)
                {
                    RawNum1 += number1[i];
                }
     
            }
            else
            {
                RawNum1 = number1;
            }
            // RAW number2
            if (number2[0] == '-')
            {
                for (int i = 1; i < number2.Length; i++)
                {
                    RawNum2 += number2[i];
                }
     
            }
            else
            {
                RawNum2 = number2;
            }



            string TestNum = RawNum1;
            string reminder = RawNum1;

            while (CompareNumbers(TestNum, RawNum2) != -1)
            {
                if(CompareNumbers(TestNum, RawNum2) == 0)
                {
                    return "0";
                }
                else
                {
                    TestNum = Subtraction(TestNum, RawNum2);
                    reminder = TestNum;

                }
            }
            return reminder;
        }


        public string ABS(string number)
        {
            string RawNumber = "";
            if (number[0] == '-')
            {
                int index = 1;
                while (index <= number.Length - 1)
                {
                    RawNumber += number[index];
                    index++;
                }
                return RawNumber;
            }
            else
                return number;
        }


        public string GCD(string number1 ,string number2)
        {
            if (number2 =="0")
            {
                return number1;
            }
            string holder = Reminder(number1, number2);
            return GCD(number2, holder);
        }
        public string LCM(string number1,string number2)
        {
            string gcd = GCD(number1, number2);
            string divide = Devision(number1, gcd);
            string result = Multiply(number2, divide);
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            //number One & Number Two
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("enter First Number");

            Console.ForegroundColor = ConsoleColor.White;
            string n1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("enter Second Number");

            Console.ForegroundColor = ConsoleColor.White;
            string n2 = Console.ReadLine() ;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the number of Operates you wanna do with the Big numbers Bro!");
            Console.ForegroundColor = ConsoleColor.White;
            int numberOfOperators = int.Parse(Console.ReadLine());

            // get operators
            string[] operators= new string[numberOfOperators];
            for(int i=0;i<numberOfOperators;i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("enter the Operator {0}  sign",i+1);
                Console.ForegroundColor = ConsoleColor.White;

                operators[i] = Console.ReadLine();
            }
            // creat an object for BigNumberOperater class ;
            BigNumOperater Operat1 = new BigNumOperater(n1,n2,numberOfOperators, operators);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\n\n\n <<Finish>>   -------------> Developed By :");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" <Aryana.Bkh>");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\t\t\t     My Github   : ");
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("https://github.com/AryanaBakhshandeh ");

        
            Console.ReadKey(); 
        }
    }
}
