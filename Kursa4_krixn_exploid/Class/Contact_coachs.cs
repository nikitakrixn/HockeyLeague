//Тренеры

namespace Kursa4_krixn_exploid.Class
{
    public class Contact_coachs:Contact_games
    {
        public int id_coach { get; set; }

        public string firstname_coach { get; set; }

        public string lastname_coach { get; set; }

        public string country_coach { get; set; }

        public int experience_coach { get; set; }

        public string birthday_coach { get; set; }
    }
}
