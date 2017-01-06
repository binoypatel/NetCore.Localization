using Contoso.Languages;
using System;
using System.Globalization;

namespace ConsoleApplication1.FullNet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("You said {0} in {1}", LocalizedStrings.WelcomeLabel, CultureInfo.CurrentCulture.EnglishName);
            var frenchCulture = new CultureInfo("fr-CA");
            CultureInfo.CurrentCulture = frenchCulture;
            CultureInfo.CurrentUICulture = frenchCulture;
            Console.WriteLine("You said {0} in {1}", LocalizedStrings.WelcomeLabel, CultureInfo.CurrentCulture.EnglishName);
            var germanCulture = new CultureInfo("de");
            CultureInfo.CurrentCulture = germanCulture;
            CultureInfo.CurrentUICulture = germanCulture;
            Console.WriteLine("You said {0} in {1}", LocalizedStrings.WelcomeLabel, CultureInfo.CurrentCulture.EnglishName);
            Console.ReadLine();
        }
    }
}