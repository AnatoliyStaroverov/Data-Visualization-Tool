using System;


namespace Data_Visualization_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            // String example 
            var test1 = new Stringz("abcdeedcba");
            Console.WriteLine("init string: {0} \n", test1.CurrentStr);
            Console.WriteLine("Reverse String  {0} \n" ,test1.reverseString() );
            Console.WriteLine("is IsParindrome : {0}", test1.IsParindrome());
        }
    }
}
