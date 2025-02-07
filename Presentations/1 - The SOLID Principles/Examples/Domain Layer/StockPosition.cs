namespace Wincubate.Module1.DomainLayer
{
    public class StockPosition
    {
        public string Ticker { get; protected set; }
        public int Size { get; protected set; }

        public override string ToString() => $"{Ticker} [{Size}]";

        public StockPosition(string ticker, int size)
        {
            Ticker = ticker;
            Size = size;
        }
    }
}
