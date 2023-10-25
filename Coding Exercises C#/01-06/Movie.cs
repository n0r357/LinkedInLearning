using System;
namespace movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }

        public override string ToString()
        {
            string description = $"{this.title}\n\tRated {this.rating}\n\t{this.reviewScore.ToString()}% on RT";
            if (this.reviewScore >= 75)
            {
                description += " - Certified Fresh!";
            }
            return description;
        }
    }
}