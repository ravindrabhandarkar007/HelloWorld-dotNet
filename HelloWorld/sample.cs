using System;

namespace SampleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This code will fail some of the pre-commit checks

            Console.WriteLine("Hello, World!");

            // The following line contains a trailing whitespace
            string message = "This line has trailing whitespace.    ";

            // The following line contains a merge conflict marker
            int x = 10 <<<<<<< HEAD;

            // The following line contains incorrect casing for a namespace
            var date = DateTime.Now;

            // The following code contains more issues:

            // The following line is too long and will fail the line length check
            string longString = "This is a very long string that exceeds the maximum line length allowed by the pre-commit checks.";

            // The following line contains tabs instead of spaces and will fail the mixed line ending check
Console.WriteLine("This line contains tabs\tand should use spaces instead.");

            // The following line contains an incorrect indentation and will fail the code formatting check
        Console.WriteLine("This line is not properly indented.");

            // The following method has inconsistent spacing around the parenthesis and will fail the spacing check
            MethodWithSpacingIssue   (  );

            // The following line uses single quotes for a string and will fail the string literal check
            string singleQuotesString = 'This should use double quotes.';

            // The following line uses an incorrect escape sequence and will fail the escape character check
            string invalidEscape = "This has an invalid escape sequence: \k";
        }

        // The following method is missing an access modifier and will fail the accessibility check
        static void MethodWithSpacingIssue()
        {
            Console.WriteLine("This method has spacing issues.");
        }
    }
}
