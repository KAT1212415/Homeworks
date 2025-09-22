using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf2102.Models;

namespace Wpf2102.ViewModels
{
    public class Class1:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)


        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        private string username;

        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        private string password;

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        private bool isSuccess;
        public bool IsSuccess
        {

            get => isSuccess;
           
              set
            {
                isSuccess = value;
                OnPropertyChanged();
            }
        }

        private string statusMessage;
        public string StatusMessage
        {

            get => statusMessage;

            set
            {
                statusMessage = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand  { get; }
        public Class1()
        {
            username = "";
            password = "";
            isSuccess=false;
            statusMessage = "введите данные";
            LoginCommand  = new RelayCommand(LoginExecute, CanLoginExecute);
        }
        private void LoginExecute(object? parameter)
        {
            IsSuccess = AuthModel.Authenticate(Username, Password);
            StatusMessage = IsSuccess ? "Успешно!" : "Ошибка!";
        }

        private bool CanLoginExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

       






     


    }
}
