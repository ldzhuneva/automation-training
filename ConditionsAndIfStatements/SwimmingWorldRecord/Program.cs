double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());

double timeForSwimming = distanceInMeters * timeInSecondsForOneMeter;
double timeForMeter = distanceInMeters * timeInSecondsForOneMeter;
double timesDelay = Math.Floor(distanceInMeters / 15);
double finalTime = timeForSwimming + timesDelay * 12.5;
if (finalTime < recordInSeconds)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
}
else
{ 
double neededTime = finalTime - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}