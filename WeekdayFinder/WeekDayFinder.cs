using System;
using WeekDayFinder.Models;

namespace WeekDayFinder {
  public class Program {
    public static void Main() {

      // Month Day Year
      // DayOfWeek
      Console.ForegroundColor = ConsoleColor.Yellow;
      PromptDate("Enter in a Date (Month/Day/Year): ");
    }

    public static void PromptDate(string prompt) {
      Console.Write(prompt);
      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "exit") {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Exiting Program");
      } else {
        ValidDate(userInput);
      }
    }

    public static void ValidDate(string userInput) {
      DateTime result;
      DateTime.TryParse(userInput, out result);
      if(result.Year == 1) {
        Console.ForegroundColor = ConsoleColor.Red;
        PromptDate("Enter in a VALID Date (Month/Day/Year OR Exit): ");
      } else {
        Console.ForegroundColor = ConsoleColor.Green;
        Weekday newDay = new Weekday(result.DayOfWeek.ToString());
        Console.WriteLine(newDay.Day.ToString());
        Console.ForegroundColor = ConsoleColor.Yellow;
        PromptDate("Enter new Date or Exit program (Month/Day/Year OR Exit): ");
      }
    }
  }
}