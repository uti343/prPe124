using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Renci.SshNet;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Renci.SshNet.Async;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data.Entity.Infrastructure;
using System.Windows.Threading;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        private Button _restartButton;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public login()
        {
            InitializeComponent();
            _restartButton = this.FindName("Button_Restart") as Button;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null)
            {
                MessageBox.Show("Кнопка с именем 'Button_Restart' не найдена!");
            }
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            if (_restartButton == null) return; 
            _restartButton.IsEnabled = false;
            string host = "172.26.1.109"; 
            string username = "tc";
            string password = "324012"; 
            string rebootCommand = "cash reboot";  
            try
            {
                var method = new PasswordAuthenticationMethod(username, password); 
                var connectionInfo = new ConnectionInfo(host, username, method); 
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null) return;
            _restartButton.IsEnabled = false;
            string host = "172.26.1.102";
            string username = "tc";
            string password = "324012"; // **Не храните пароль напрямую! Используйте безопасный метод хранения!**
            string rebootCommand = "cash reboot";
            try
            {
                var method = new PasswordAuthenticationMethod(username, password);
                var connectionInfo = new ConnectionInfo(host, username, method);
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null) return;
            _restartButton.IsEnabled = false;
            string host = "172.26.1.103";
            string username = "tc";
            string password = "324012"; // **Не храните пароль напрямую! Используйте безопасный метод хранения!**
            string rebootCommand = "cash reboot";
            try
            {
                var method = new PasswordAuthenticationMethod(username, password);
                var connectionInfo = new ConnectionInfo(host, username, method);
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null) return;
            _restartButton.IsEnabled = false;
            string host = "172.26.1.104";
            string username = "tc";
            string password = "324012"; // **Не храните пароль напрямую! Используйте безопасный метод хранения!**
            string rebootCommand = "cash reboot";
            try
            {
                var method = new PasswordAuthenticationMethod(username, password);
                var connectionInfo = new ConnectionInfo(host, username, method);
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null) return;
            _restartButton.IsEnabled = false;
            string host = "172.26.1.105";
            string username = "tc";
            string password = "324012"; // **Не храните пароль напрямую! Используйте безопасный метод хранения!**
            string rebootCommand = "cash reboot";
            try
            {
                var method = new PasswordAuthenticationMethod(username, password);
                var connectionInfo = new ConnectionInfo(host, username, method);
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }

        private async void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (_restartButton == null) return;
            _restartButton.IsEnabled = false;
            string host = "172.26.1.106";
            string username = "tc";
            string password = "324012"; // **Не храните пароль напрямую! Используйте безопасный метод хранения!**
            string rebootCommand = "cash reboot";
            try
            {
                var method = new PasswordAuthenticationMethod(username, password);
                var connectionInfo = new ConnectionInfo(host, username, method);
                using (var client = new SshClient(connectionInfo))
                {
                    await client.ConnectAsync(_cancellationTokenSource.Token);
                    var cmd = client.CreateCommand(rebootCommand);
                    var result = cmd.Execute();
                    cmd.Execute();
                    var r = cmd.Result;
                    client.Disconnect();
                }
            }
            catch (OperationCanceledException)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show("Операция отменена."));
            }
            catch (Exception ex)
            {
                this.Dispatcher.Invoke(() => MessageBox.Show($"Ошибка перезагрузки: {ex.Message}"));
            }
            finally
            {
                _restartButton.IsEnabled = true;
                _cancellationTokenSource = new CancellationTokenSource();
            }
        }
    }
}










