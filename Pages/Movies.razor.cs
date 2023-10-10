using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Voorbeeld.Pages
{
    public partial class Movies
    {
        public string[] Images { get; set; }

        public Random Random { get; set; }
        public int RandomIndex { get; set; }
        public string RandomImg { get; set; }
        public int CurrentIndex { get; set; }

        public Movies()
        {
            Images = ["breakfast.jpg", "flower.jpg", "flower_red.jpg", "fontain.jpg", "lunch.jpg", "sunset.jpg"];
            Random = new Random();
            CurrentIndex = -1;
        }

        public bool CheckIndex()
        {
            if (CurrentIndex == RandomIndex)
            {
                return false;
            }
            return true;
        }

        public int GenerateNumber()
        {
            return Random.Next(0, Images.Length - 1);
        }

        public void NewImage()
        {
            RandomIndex = GenerateNumber();

            while (!CheckIndex())
            {
                RandomIndex = GenerateNumber();
            }

            RandomImg = Images[RandomIndex];
            CurrentIndex = RandomIndex;
        }
    }
}