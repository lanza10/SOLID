
using SRP;

class Program
{
    private static void Main()
    {
        StandardMessages.SayWelcome();

        var birthDate = new BirthDate();

        var year = BirthDateDataCapture.AskForData("year");

        if (!YearValidator.ValidYear(year, birthDate))
        {
            StandardMessages.EndApp();
            return;
        }

        var month = BirthDateDataCapture.AskForData("month");
        if (!MonthValidator.ValidMonth(month, birthDate))
        {
            StandardMessages.EndApp();
            return;
        }


        var day = BirthDateDataCapture.AskForData("day");
        if (!DayValidator.ValidDay(day, birthDate))
        {
            StandardMessages.EndApp();
            return;
        }

        BirthDatePrinter.PrintBirthDate(birthDate);

    }
}