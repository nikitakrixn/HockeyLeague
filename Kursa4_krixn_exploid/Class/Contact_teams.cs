//Команды

namespace Kursa4_krixn_exploid.Class
{
    public class Contact_teams : Contact_players
    {
        public int id_team { get; set; }

        public string Name_team { get; set; }

        public string City_team { get; set; }

        public string Country_team { get; set; }

        public string CreatedAt_team { get; set; }
    }
}
