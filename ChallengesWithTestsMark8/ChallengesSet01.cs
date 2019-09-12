using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
           {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var minus = minuend - subtrahend;
            return minus;
        } 
         

        public int Add(int number1, int number2)
        {
            var cg = number1 + number2;
            return cg;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
       
        
        
         
        
        

        

        public long Multiply(long factor1, long factor2)
        {
            long gg = factor1 * factor2;
            return gg;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return ("Hello!");
            }
            else
            {
                return ("Hello, " + nameOfPerson + "!");
            }
        }

        public string GetHey()
        {
            string x = "HEY!";
            return x;
        }
    }
}
