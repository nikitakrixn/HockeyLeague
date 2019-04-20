using System.Data;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Kursa4_krixn_exploid.Class
{
    //ООП наследуем всё от класса
    public partial class Sqlconnect : Contact_teams
    {
        #region Переменные
        public string connection; //Строка подключения
        public string query; //Строка запроса
        public static SqlConnection connect = null;
        #endregion

        #region SQL
        //Метод для подключения
        public void sqlConnect()
        {
            connect = new SqlConnection(connection);
        }

        //Метод закрытия подключения
        public void ConnectClose()
        {
            connect.Close();
        }

        //Проверка есть ли подключение к бд
        public bool IsConnection
        {
            get
            {
                if (connect.State == System.Data.ConnectionState.Closed) connect.Open();
                return true;
            }
        }

        #endregion

        #region ПРОСМОТР,УДАЛЕНИЕ,РЕДАКТИРОВАНИЕ
        //Просмотр с таблицы из бд, с помощью строки запроса
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connect.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }

        //Редактирование из таблицы TEAM получаем данные из класса Contact_teams и передаём их в параметры
        public bool Update_Team()
        {
            bool isReady = false;
            string sql_query = "EXEC Teams_Update @id_team, @Name, @City, @Country, @CreatedAt";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@Name", Name_team);
                cmd.Parameters.AddWithValue("@City", City_team);
                cmd.Parameters.AddWithValue("@Country", Country_team);
                cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt_team);
                cmd.Parameters.AddWithValue("@id_team", id_team);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Вставка в таблицу TEAM получаем данные из класса Contact_teams и передаём их в параметры
        public bool Insert_Team()
        {
            bool isReady = false;
            string sql_query = "EXEC Teams_Insert @Name, @City, @Country, @CreatedAt";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@Name", Name_team);
                cmd.Parameters.AddWithValue("@City", City_team);
                cmd.Parameters.AddWithValue("@Country", Country_team);
                cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt_team);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;

        }

        //Удаление из таблицы TEAM получаем данные из класса Contact_teams и передаём их в параметры
        public bool Delete_Team()
        {
            bool isReady = false;
            string sql_query = "Exec Teams_Delete @id_team";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@id_team", id_team);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Редактирование из таблицы PLAYER получаем данные из класса Contact_players и передаём их в параметры
        public bool Update_Player()
        {
            bool isReady = false;
            string sql_query = "EXEC Players_Update @id_player, @Firstname, @Lastname, @Jersey, @Country, @Birthday, @Position";
            //Создаёт новое подключение с запросом Update
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@Firstname", firstname_player);
                cmd.Parameters.AddWithValue("@Lastname", lastname_player);
                cmd.Parameters.AddWithValue("@Jersey", jersey_number_player);
                cmd.Parameters.AddWithValue("@Country", country_player);
                cmd.Parameters.AddWithValue("@Birthday", birthday_player);
                cmd.Parameters.AddWithValue("@Position", position_player);
                cmd.Parameters.AddWithValue("@id_player", id_player);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Вставка в таблицу PLAYER получаем данные из класса Contact_players и передаём их в параметры
        public bool Insert_Player()
        {
            bool isReady = false;
            string sql_query = "Exec Players_Insert @Firstname,@Lastname,@Jersey,@Country,@Birthday,@Position";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@Firstname", firstname_player);
                cmd.Parameters.AddWithValue("@Lastname", lastname_player);
                cmd.Parameters.AddWithValue("@Jersey", jersey_number_player);
                cmd.Parameters.AddWithValue("@Country", country_player);
                cmd.Parameters.AddWithValue("@Birthday", birthday_player);
                cmd.Parameters.AddWithValue("@Position", position_player);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Удаление из таблицы PLAYER получаем данные из класса Contact_players и передаём их в параметры
        public bool Delete_Player()
        {
            bool isReady = false;
            string sql_query = "Exec Players_Delete @id_player";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@id_player", id_player);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

       //Добавление в таблицу Coach получая данные из класса Contact_Coachs и передаём их в параметры
       public bool Insert_Coach()
        {
            bool isReady = false;
            string sql_query = "Exec Coachs_Insert @FirstName, @Lastname, @country, @exp, @birthday";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@FirstName", firstname_coach);
                cmd.Parameters.AddWithValue("@Lastname", lastname_coach);
                cmd.Parameters.AddWithValue("@country", country_coach);
                cmd.Parameters.AddWithValue("@exp", experience_coach);
                cmd.Parameters.AddWithValue("@birthday", birthday_coach);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Вставка в таблицу COACH получаем данные из класса Contact_coachs и передаём их в параметры
        public bool Update_Coach()
        {
            bool isReady = false;
            string sql_query = "EXEC Coachs_Update @id_coach, @FirstName, @Lastname, @country, @exp, @birthday";
            //Создаёт новое подключение с запросом Update
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@FirstName", firstname_coach);
                cmd.Parameters.AddWithValue("@Lastname", lastname_coach);
                cmd.Parameters.AddWithValue("@country", country_coach);
                cmd.Parameters.AddWithValue("@exp", experience_coach);
                cmd.Parameters.AddWithValue("@birthday", birthday_coach);
                cmd.Parameters.AddWithValue("@id_coach", id_coach);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Удаление из таблицы COACH получаем данные из класса Contact_coachs и передаём их в параметры
        public bool Delete_Coach()
        {
            bool isReady = false;
            string sql_query = "Exec Coachs_Delete @id_coach";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@id_coach", id_coach);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Добавление в таблицу Games получая данные из класса Contact_Games и передаём их в параметры
        public bool Insert_Game()
        {
            bool isReady = false;
            string sql_query = "Exec Games_Insert @City, @Date, @arenaid, @hteamid, @ateamid";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@City", City_games);
                cmd.Parameters.AddWithValue("@Date", Date_games);
                cmd.Parameters.AddWithValue("@arenaid", Arena_games);
                cmd.Parameters.AddWithValue("@hteamid", HomeTeam_games);
                cmd.Parameters.AddWithValue("@ateamid", AwayTeam_games);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Вставка в таблицу Game получаем данные из класса Contact_Games и передаём их в параметры
        public bool Update_Game()
        {
            bool isReady = false;
            string sql_query = "EXEC Games_Update @id_game, @City, @date, @Arena, @hteamid, @ateamid, @hscore, @ascore, @status_game";
            //Создаёт новое подключение с запросом Update
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@City", City_games);
                cmd.Parameters.AddWithValue("@date", Date_games);
                cmd.Parameters.AddWithValue("@Arena", Arena_games);
                cmd.Parameters.AddWithValue("@hteamid", HomeTeam_games);
                cmd.Parameters.AddWithValue("@ateamid", AwayTeam_games);
                cmd.Parameters.AddWithValue("@hscore", HomeScore_games);
                cmd.Parameters.AddWithValue("@ascore", AwayScore_games);
                cmd.Parameters.AddWithValue("@status_game", Status_games);
                cmd.Parameters.AddWithValue("@id_game", id_games);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Удаление из таблицы GAMES получаем данные из класса Contact_Games и передаём их в параметры
        public bool Delete_Game()
        {
            bool isReady = false;
            string sql_query = "Exec Games_Delete @id_game";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@id_game", id_games);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Добавление в таблицу LINEUP получая данные из класса Contact_LineUP и передаём их в параметры
        public bool Update_LineUP()
        {
            bool isReady = false;
            string sql_query = "Exec LineUp_Update @teamid, @playerid, @coachid, @datefrom, @dateby";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@teamid", id_team);
                cmd.Parameters.AddWithValue("@playerid", id_player);
                cmd.Parameters.AddWithValue("@coachid", id_coach);
                cmd.Parameters.AddWithValue("@datefrom", datefrom);
                cmd.Parameters.AddWithValue("@dateby", dateby);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }

        //Удаление из таблицы LINEUP получаем данные из класса Contact_LineUP и передаём их в параметры
        public bool Delete_LineUP()
        {
            bool isReady = false;
            string sql_query = "Exec LineUp_Delete @lineupid";
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@lineupid", id_lineup);
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;
        }
        #endregion

        #region CHECK ROLES SQL

        //Проверка на Админа
        public bool Check_Admin()
        {
            bool IsAdmin = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('db_owner')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int Admin = dr.GetInt32(0);
                            if (Admin == 1) IsAdmin = true;
                            else IsAdmin = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsAdmin;
        }

        //Проверка на Гостя(Нового пользователя)
        public bool Check_Guest()
        {
            bool IsNewUser = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('New_User')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsNewUser = true;
                            else IsNewUser = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsNewUser;
        }

        //Проверка на Менеджера Команд
        public bool Check_ManagerTeams()
        {
            bool IsManagerTeams = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('Manager_Teams')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsManagerTeams = true;
                            else IsManagerTeams = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsManagerTeams;
        }

        //Проверка на Менеджера Игр
        public bool Check_ManagerGames()
        {
            bool IsManagerGames = false;
            try
            {
                //Выполняем подключение
                connect.Open();

                //Выполняем запрос на распознавание роли db_owner
                using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('Manager_Games')", connect))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Вносим данные в переменную
                            int NewUser = dr.GetInt32(0);
                            if (NewUser == 1) IsManagerGames = true;
                            else IsManagerGames = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Закрываем подключение
                connect.Close();
            }
            return IsManagerGames;
        }
        #endregion
    }
}
