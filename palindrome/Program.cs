using System;
 
namespace PalindromeNS;

public class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type your number");
        string input = Console.ReadLine();
        // limit the program to positive integers to avoid asking ourselves if the minus sign 
        // of the decimal point matter or not for the palindrome rule 
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Invalid string");
            return;
        }
        if (isPositiveInteger(input) == false) {
            Console.WriteLine("Not a positive integer");
            return;
        }
        bool isValidPalindrome = CheckPalindromeNumber(input);
        Console.WriteLine("Result: {0} ", isValidPalindrome);

  	}
  	
    // 
    public static bool isPositiveInteger(string inputString) {
        long inputStringAsInt;
        bool isNumeric = long.TryParse(inputString, out inputStringAsInt);
        if (!isNumeric || inputStringAsInt < 0) {
            return false;
        } else {
            return true;
        }
    }

    // function that acts on a string directly
    // if the number is supplied through the standard input, then this is the best option
  	public static bool CheckPalindromeNumber(string number) {
        bool isValidPalindrome = true;
        int n_digits = number.Length;
        // check digits until n_digits/2. if n_digits is odd, 
        // the middle digit doesn't need to be checked,
        // because it is equal to itself
        for (int i = 0; i < n_digits/2; i++)
        {
            char digit = number[i];
            char mirrorDigit = number[n_digits-1 - i];
            if (digit != mirrorDigit) {
                isValidPalindrome = false;
                break;
            }
        }
       return isValidPalindrome;
  	}

    // function that takes an int as an argument, and does not convert it to a string 
  	public static bool CheckPalindromeNumber(int number) {
        bool isValidPalindrome = true;
        int n_digits = intNDigits(number);

        for (int i = 0; i < n_digits/2; i++)
        {
            int digit = (number / (int)Math.Pow(10,i)) % 10;
            int mirrorDigit = (number / (int)Math.Pow(10, n_digits -1 - i)) % 10;
            if (digit != mirrorDigit) {
                isValidPalindrome = false;
                break;
            }
        }
       return isValidPalindrome;
  	}

    public static int intNDigits(int number) {
        if (number == 0) {
            return 1;
        } else {
            return (int)Math.Log10(   Math.Abs( (double)number )  ) + 1;
        }
    }

    // function that takes an int as an argument, converts it into a string, and reuses the first function
    // this is simpler, but it does use one extra allocation
  	public static bool CheckPalindromeNumberSimpler(int number) {
        string numberAsString = number.ToString();
        return CheckPalindromeNumber(numberAsString);
  	}
 }

