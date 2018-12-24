using Forum.App.Controllers.Contracts;
using Forum.App.Services;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Contracts;
using Forum.App.Views;
using System;

namespace Forum.App.Controllers
{

    public class LogInController : IController, IReadUserInfoController
    {
        private enum Command
        {
            ReadUsername, ReadPassword, LogIn, Back
        }

        public string Username { get; private set; }

        private string Password { get; set; }

        private bool Error { get; set; }

        public LogInController()
        {
            ResetLogin();
        }


        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:
                    this.ReadUsername();
                    return MenuState.Login;
                case Command.ReadPassword:
                    this.ReadPassword();
                    return MenuState.Login;                  
                case Command.LogIn:
                    //Log in user
                    var userLoggedIn = UserService.TryLogInUser(Username, Password);
                    if (userLoggedIn)
                    {
                        return MenuState.SuccessfulLogIn;
                    }
                    this.Error = true;     
                    return MenuState.Error;
                case Command.Back:
                    ResetLogin();
                    return MenuState.Back;
                default:
                    throw new InvalidOperationException();

            }         
        }

        public IView GetView(string userName)
        {
            return new LogInView(this.Error, this.Username, this.Password.Length);           
        }

        public void ReadPassword()
        {
            this.Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            this.Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        private void ResetLogin()
        {
            Username = string.Empty;
            Password = string.Empty;
            Error = false;
        }
    }
}
