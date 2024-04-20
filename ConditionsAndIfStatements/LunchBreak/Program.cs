string movieName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int lunchBreakDuration = int.Parse(Console.ReadLine());

double timeForLunch = lunchBreakDuration / 8.0;
double relaxTime = lunchBreakDuration / 4.0;

double totalTime = episodeDuration + timeForLunch + relaxTime;
double timeDifference = Math.Abs(totalTime - lunchBreakDuration);

if (totalTime <= lunchBreakDuration)
{
    
    Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeDifference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(timeDifference)} more minutes.");
}

