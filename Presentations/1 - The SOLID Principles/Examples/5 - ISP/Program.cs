using System.Threading.Tasks;

namespace Wincubate.Module1
{
    static class Program
    {
        static async Task Main(string[] args)
        {

            //string sourceFilePath = @"..\..\..\..\Files\StockPositions1.csv";
            //string sourceFilePath = @"..\..\..\..\Files\StockPositions2.json";
            //string sourceFilePath = @"http://solid.wincubate.net/stockpositions.json";
            //string destinationFilePath = @"..\..\..\..\Files\Result.csv";
            //string destinationFilePath = @"..\..\..\..\Files\Result.json";

            StockAnalyzer analyzer = new StockAnalyzer();
            await analyzer.ProcessAsync();
        }
    }
}
