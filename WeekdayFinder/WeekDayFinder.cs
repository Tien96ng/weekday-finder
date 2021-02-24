using System;
using WeekDayFinder.Models;

namespace WeekDayFinder {
  public class Program {
    public static void Main() {

      // Month Day Year
      // DayOfWeek
      ValidDate(PromptDate("Enter in a Date: "));
    }

    public static string PromptDate(string prompt) {
      // "Enter in a Date: "
      Console.Write(prompt);
      string userInput = Console.ReadLine();
      return userInput;
    }

    public static void ValidDate(string userInput) {
      DateTime result;
      DateTime.TryParse(userInput, out result);
      if(result.Year == 1) {
        PromptDate("Enter in a VALID Date: ");
      } else {
        Weekday newDay = new Weekday(result.DayOfWeek.ToString());
        Console.WriteLine(newDay.Day.ToString());
        
      }
    }
  }
}