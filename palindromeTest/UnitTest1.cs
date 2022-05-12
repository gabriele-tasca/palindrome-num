using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalindromeNS;

namespace palindromeTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStringPalindrome()
    {
        // Tests that we expect to return true.
        string[] numbers = { "1234321", "9876789", "121", "1", "95677659" };
        foreach (var number in numbers)
        {
            bool result = Palindrome.CheckPalindromeNumber(number);
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': true; Actual: {1}",
                                 number, result));
        }
    }

    [TestMethod]
    public void TestStringNotPalindrome()
    {
        // Tests that we expect to return false.
        string[] numbers = { "2111154", "12", "347" };
        foreach (var number in numbers)
        {
            bool result = Palindrome.CheckPalindromeNumber(number);
            Assert.IsFalse(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 number, result));
        }
    }

    [TestMethod]
    public void TestIntPalindrome()
    {
        // Tests that we expect to return false.
        int[] numbers = { 1234321, 9876789, 121, 1, 95677659 };
        foreach (var number in numbers)
        {
            bool result = Palindrome.CheckPalindromeNumber(number);
            Assert.IsTrue(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 number == null ? "<null>" : number, result));
        }
    }

    [TestMethod]
    public void TestIntNotPalindrome()
    {
        // Tests that we expect to return false.
        int[] numbers = { 2111154, 12, 347 };
        foreach (var number in numbers)
        {
            bool result = Palindrome.CheckPalindromeNumber(number);
            Assert.IsFalse(result,
                   string.Format("Expected for '{0}': false; Actual: {1}",
                                 number == null ? "<null>" : number, result));
        }
    }
}