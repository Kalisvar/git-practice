using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question no (1)
            //Console.WriteLine("Enter the first Integer:");
            //int firstinteger = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second Integer:");
            //int secondinteger = int.Parse(Console.ReadLine());
            //int Sum = firstinteger + secondinteger;
            //int difference = Math.Abs(firstinteger - secondinteger);
            //int  product = firstinteger * secondinteger;
            //Console.WriteLine("Sum of two Integer:" + Sum + "\nDifference Of two integer:" + difference + "\nProduct of Two integer: " + product);

            // Question no(2)
            //Console.WriteLine("Enter the value a(positive Integer):");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the value b(positive Integer):");
            //int b = int.Parse(Console.ReadLine());
            //double CalculatedValue = Math.Pow(a,b);
            //Console.WriteLine("The value of " + a + " in times of " + b + " is " + CalculatedValue);  

            //Question no (3)
            //Console.WriteLine("Enter the Length:");
            //int length = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Enter the Width:");
            //int width = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Height:");
            //int height =int.Parse(Console.ReadLine());
            //long Volume = length * width * height;
            //Console.WriteLine("The volume of the tank is :" + Volume);

            //Question no (4)
            //Console.WriteLine("Enter the Radius:");
            //float radius = float.Parse(Console.ReadLine());
            //double Perimeter = 2 * Math.PI * radius;
            //Console.WriteLine("The perimeter of a circle is :" + string.Format("{0:0.00}", Perimeter));

           // Question no (5)
            Console.WriteLine("Enter the Numerator:");
            int Numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Denominator:");
            int Denominator = int.Parse(Console.ReadLine());
            int Quotient = Numerator/Denominator;
            int Remainder = Numerator%Denominator;
            Console.WriteLine("Quotient is :" +Quotient);
            Console.WriteLine("Remainder is :" +Remainder);

            //Question(6)
            //Console.WriteLine("Enter the Number:");
            //int number = int.Parse(Console.ReadLine());
            //double calculatedvalue = Math.Pow(number, 2);
            //Console.WriteLine("The square of number is: " + calculatedvalue); 


            //Question (7):
            //Console.WriteLine("Enter the Number:");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The square root of" + number + " is :" + Math.Sqrt(number));

            //Question (8):
            //Console.WriteLine("Enter the Bredth:");
            //int bredth = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the height:");
            //int height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Area of triangle is " + ((1.0 / 2) * (bredth * height)));

            //Question (9):
            //Console.WriteLine("Enter the kilometer:");
            //float number = int.Parse(Console.ReadLine());
            //double convertedvalue = ((number) * (0.621371));
            //Console.WriteLine("mile of " + number +  " kilomter:" +convertedvalue);

            //Question (10):
            //Console.WriteLine("Enter the celsius:");
            //float number = int.Parse(Console.ReadLine());
            //double convertedvalue = ((number * (1.8)) + 32);
            //Console.WriteLine("celsius of " + number + " fahrenheit:" + convertedvalue);


            //Question (11)
            //Console.WriteLine("Enter the First variable: ");
            //int variable1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second variable: ");
            //int variable2 = int.Parse(Console.ReadLine());
            //int variable3 = variable2;
            //variable2 = variable1;
            //variable1 = variable3;
            //Console.WriteLine("swapped variable:" + variable1 + "and" + variable2);


            //Question (12)
            //Console.WriteLine("Enter the First variable: ");
            //int variable1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second variable: ");
            //int variable2 = int.Parse(Console.ReadLine());
            // variable1 = variable1 + variable2;
            // variable2 = variable1 - variable2;
            // variable1 = variable1 - variable2;
            // Console.WriteLine("swapped variable:" + variable1+ "and" + variable2);


            //Question (13)
            //Console.WriteLine("Enter the First variable: ");
            //int variable1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second variable: ");
            //int variable2 = int.Parse(Console.ReadLine());
            //variable1 = variable1^variable2;
            //variable2 = variable1^variable2;
            //variable1 = variable1^variable2;
            //Console.WriteLine("swapped variable:" + variable1 + "and" + variable2);

            //Question(14)
            //Random random = new Random();
            //int result = random.Next(1,100);
            //Console.WriteLine("Random Number  between 1 and 100 is " +result);


            //Question(15):
            //Console.WriteLine("Enter the length in feet:");
            //int length = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width in feet:");
            //int Width = int.Parse(Console.ReadLine());
            //double number = length * Width;
            //double value =  number/ 43560;
            //Console.WriteLine("Area of field in acres is :" +value);

            //Question(16):
            //Console.WriteLine("Enter the Number N :");
            //int number = int.Parse(Console.ReadLine());
            //int sum = (number * (number + 1) / 2);
            //Console.WriteLine( "Sum of Number N is :" +sum);


            //Question (17):
            //Console.WriteLine("Enter the number1:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number2:");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number3:");
            //int number3 = int.Parse(Console.ReadLine());
            //int Value = (number1 + number2 + number3) / 3;
            //Console.WriteLine("Average is :" + Value);



            //Question (18)
            //Console.WriteLine("Enter the Bill amount: ");
            //int amount = int.Parse(Console.ReadLine());
            //double Tipamount = amount * 0.05;
            //Console.WriteLine("Tip for the waiter is " + Tipamount);


            //Question(19)
            //Console.WriteLine("Enter the total Bill amount: ");
            //int totalamount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the tax percentage: ");
            //int tax = int.Parse(Console.ReadLine());
            //double taxamount = totalamount*(tax * 0.01);
            //double netamount = totalamount - taxamount;
            //Console.WriteLine("Tip for the waiter is " +netamount);

            //Question (20)
            //Console.WriteLine("Enter the basic Pay");
            //int basicpay = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Dearness Allowance Percent");
            //int DA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Travelling  Allowance Percent");
            //int TA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Provident Fund Percnet");
            //int PF = int.Parse(Console.ReadLine());
            //double Grosspay = basicpay + (basicpay * DA * 1.0 / 100) + (basicpay * TA * 1.0 / 100) - (basicpay * PF * 1.0 / 100);
            //Console.WriteLine("Grosspay: " + Grosspay);

            //Question(21)
            //Console.WriteLine("Enter the Principal amount:");
            //int Principalamount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of period in years:");
            //float Numberofperiod = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the rate of intrest :");
            //int interest = int.Parse(Console.ReadLine());
            //double simpleinterest = (Principalamount * Numberofperiod * interest) / 100;
            //Console.WriteLine("The Simple intrest is:" + simpleinterest);


            //Question(22):
            //Console.WriteLine("Enter the Principal balance:");
            //int Principalbalance = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of times  interest");
            //float Numberofintrest = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the rate of intrest :");
            //int interest = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of times periods :");
            //int timeperiods = int.Parse(Console.ReadLine());
            //double finalvalue =  Math.Pow((1 + (interest / Numberofintrest)), (Numberofintrest * timeperiods));
            //Console.WriteLine("the compound interest is :" + finalvalue);




            //Question(23)
            //Console.WriteLine("Enter the height in feet");
            //int feet = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the inches");
            //int inches = int.Parse(Console.ReadLine());
            //double  answer = (feet * 30.48) + inches * 2.54;
            //Console.WriteLine("the height in centimeter is :" +answer);


            //Question(24)
            //Console.WriteLine("Enter weight in Kilogram");
            //float Weight = float.Parse(Console.ReadLine()); 
            //Console.WriteLine("Enter Height in Centimeter");
            //float Height = float.Parse(Console.ReadLine());
            //float answer = (Weight / Height) * Height;
            //Console.WriteLine("Body mass Index is" + answer);

            //Question(25)
            //Console.WriteLine("Enter the Roll number:");
            //long RollNo = long.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter the first subject mark out of 100:");
            //int Mark1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second subject mark out of 100:");
            //int Mark2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Third subject mark out of 100:");
            //int Mark3 = int.Parse(Console.ReadLine());
            //int total = Mark1 + Mark2 + Mark3;
            //int Average = total / 3;
            //Console.WriteLine("RollNo " + RollNo + "\nName  " + name + "\ntotal of three subject  " + total + "\nAverage of subject  " + Average); 














        }
    }
}
