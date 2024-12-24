using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase();
            string login = log.Text.Trim();
            string password = pass.Password.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля логин и пароль не могут быть пустыми.");
                return;
            }

            try
            {
                dataBase.openConnection();
                using (SqlCommand command = new SqlCommand("INSERT INTO Bhod (Login, Password) VALUES (@Login, @Password)", dataBase.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Аккаунт добавлен");
                        }
                        else
                        {
                            //Более корректная обработка ошибки:
                            //Проверим, существует ли уже такой логин
                            using (SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Bhod WHERE Login = @Login", dataBase.GetConnection()))
                            {
                                checkCommand.Parameters.AddWithValue("@Login", login);
                                int count = (int)checkCommand.ExecuteScalar();
                                if (count > 0)
                                {
                                    MessageBox.Show("Ошибка: Пользователь с таким логином уже существует.");
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка: Не удалось добавить аккаунт. Проверьте данные.");
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) //Проверяем номер ошибки (уникальное ограничение)
                        {
                            MessageBox.Show("Ошибка: Пользователь с таким логином уже существует.");
                        }
                        else
                        {
                            MessageBox.Show($"Произошла ошибка базы данных: {ex.Message}");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
    


    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
