double filmBudget = double.Parse(Console.ReadLine());

int countStatists = int.Parse(Console.ReadLine());
double priceCostumesPerStatist = double.Parse(Console.ReadLine());

double priceDecor = filmBudget * 0.1;
double priceCostumes = countStatists * priceCostumesPerStatist;
if (countStatists > 150)
{
    priceCostumes *= 0.9;
}

double totalBudget = priceDecor + priceCostumes;

if (totalBudget > filmBudget)
{
    double moneyNeeded = totalBudget - filmBudget;
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");

}
else if (totalBudget <= filmBudget)
{
    double moneyLeft = filmBudget - totalBudget;
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
}


