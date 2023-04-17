
class Program
{
    static async Task Main(string[] args)
    {
       
        {
            Console.WriteLine(" BTC price is : ");

            BTC calculator = new BTC();
            decimal averagePrice = await calculator.CalculateAveragePrice();
            decimal lastPrice = calculator.GetLastPrice();

            Console.WriteLine($"BTC price for the next 8 Hours: ${averagePrice}");

            decimal percentageError = percentageerror.Calculate(lastPrice, averagePrice);

            Console.WriteLine($"Percentage error: {percentageError}%");
  
        }
    }
}

