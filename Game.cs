//Modified for step 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Game
    {
        public string team1 { get; set; }

        public string team2 { get; set; }

        public int team1Score { get; set; }

        public int team2Score { get; set; }

        public Game() { }

        public Game( string team1, string team2, int team1Score, int team2Score)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }

        public override string ToString()
        {
            string display = team1 + "Hornets: " + team1Score + "/" + team2 + "Bulldogs: " + team2Score;

            return String.Format("{0}, {1}, {2}, {3}", team1, team2, team1Score, team2Score);
        }
    }
}
