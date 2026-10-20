using System;

class ConvertSeconds
{
    static void Main()
    {
        Console.Write("Enter total seconds: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        // 1 hour = 3600 seconds, 1 minute = 60 seconds
        int hours = totalSeconds / 3600;
        int remainingSecondsAfterHours = totalSeconds % 3600;

        int minutes = remainingSecondsAfterHours / 60;
        int seconds = remainingSecondsAfterHours % 60;

        Console.WriteLine($"\n{totalSeconds} seconds = {hours} Hour(s), {minutes} Minute(s), and {seconds} Second(s)");
    }
}