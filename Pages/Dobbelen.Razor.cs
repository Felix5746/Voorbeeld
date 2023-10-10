namespace Voorbeeld.Pages
{
    public partial class Dobbelen
    {
        public List<string> CssClasses { get; set; }
        public int Count { get; set; }
        public string Guess { get; set; }

        public string Output { get; set; }

        public Dobbelen()
        {
            CssClasses = new List<string>();

            Output = "";
            Count = 0;
            for (int i = 0; i < 12; i++)
            {
                CssClasses.Add("bg-secondary");
            }
        }

        public void Play()
        {
            Reset();

            if (!int.TryParse(Guess, out _))
            {
                Output = "Please guess a number";
                return;
            }
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                if (random.Next(1, 7) == 6)
                {
                    CssClasses[i] = "bg-success";
                    Count++;
                }
            }

            Output = $"6 was thrown {Count} times";

            if (int.Parse(Guess) == Count)
            {
                Output += "\nYou guessed correct!";
            }
            else
            {
                Output += "\nYou guessed wrong!";
            }
            Guess = "";
        }

        public void Reset()
        {
            Output = "";
            Count = 0;

            for (int i = 0; i < 12; i++)
            {
                CssClasses[i] = "bg-secondary";
            }
        }
    }
}