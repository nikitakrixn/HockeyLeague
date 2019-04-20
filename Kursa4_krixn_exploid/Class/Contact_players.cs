//Игроки

namespace Kursa4_krixn_exploid.Class
{
    public class Contact_players:Contact_coachs
    {
        public int id_player { get; set; }

        public string firstname_player { get; set; }

        public string lastname_player { get; set; }

        public int jersey_number_player { get; set; }

        public string country_player { get; set; }

        public string birthday_player { get; set; }

        public string position_player { get; set; }
    }
}
