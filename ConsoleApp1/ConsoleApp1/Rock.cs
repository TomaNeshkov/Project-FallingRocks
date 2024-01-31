public class Rock
{
    public int X { get; set; }
    public int Y { get; set; }
    public char Symbol { get; set; }

    private char[] Representation = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };

    private Random random = new Random();

    public Rock(int x)
    {
        this.X = x;
        this.Y = 0;
        this.Symbol = Representation[random.Next(0, Representation.Length)];
    }
}