using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Fundamentals
{
    /// <summary>
    /// A static utility class containing helper tools/methods.
    /// Being static means you don't need to create an instance to use its methods.
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Prompts the user to enter their name and greets them.
        /// If no name is provided, displays a default message.
        /// </summary>
        public static void PromptAndGreetUser()
        {
            // Display a prompt asking the user for their name
            Console.WriteLine("Please, enter your name:");

            // Read the user's input from the console
            // The '?' makes this a nullable string (string?) - it can be null if no input is provided
            string? name = Console.ReadLine();

            // Display a personalized greeting using string interpolation ($"...")
            // The expression inside { } uses a ternary operator (condition ? true_value : false_value)
            // - string.IsNullOrEmpty(name) checks if the name is null or an empty string
            // - If true: displays "You did not provide your name"
            // - If false: displays the actual name entered by the user
            // Note: Parentheses around the ternary operator are required in string interpolation
            Console.WriteLine($"Hello, {(string.IsNullOrEmpty(name) ? "You did not provide your name" : name)}");
        }
    }
}
