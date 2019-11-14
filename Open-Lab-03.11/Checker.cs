using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string ispalindrome = str.Substring(0, str.Length);
            char[] arr = str.ToCharArray();
            
            Array.Reverse(arr);
            
            string temp = new string(arr);
            string first = temp.Substring(0, temp.Length);

            return str.Equals(first);
        } 
    }
}
