//Игры

namespace Kursa4_krixn_exploid.Class
{
    public class Contact_games : Contact_LineUP
    {
        public int id_games { get; set; }

        public string City_games { get; set; }

        public string Date_games { get; set; }

        public int Arena_games { get; set; }

        public int HomeTeam_games { get; set; }

        public int AwayTeam_games { get; set; }

        public int HomeScore_games { get; set; }

        public int AwayScore_games { get; set; }

        public bool Status_games { get; set; }
    }
}
