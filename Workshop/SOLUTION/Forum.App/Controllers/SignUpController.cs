using Forum.App;
using Forum.App.Controllers.Contracts;
using Forum.App.Services;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Contracts;
using System;

namespace Forum.App.Controllers
{
	
    public class SignUpController : IController, IReadUserInfoController
	{
        private enum Command
        {
            ReadUsername, ReadPassword, SignUp, Back
        }

        public enum SignUpStatus
        {
            Success, DetailsError, UsernameTakenError
        }
		private const string DETAILS_ERROR = "Invalid Username or Password!";
		private const string USERNAME_TAKEN_ERROR = "Username already in use!";

        public string ErrorMessage { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:
                    this.ReadUsername();
                    return MenuState.Signup;
                case Command.ReadPassword:
                    this.ReadPassword();
                    return MenuState.Signup;
                case Command.SignUp:
                    //try sign up
                    SignUpStatus signedUp = UserService.TrySignUpUser(Username, Password);
                    switch (signedUp)
                    {
                        case SignUpStatus.Success:
                            return MenuState.SuccessfulLogIn;
                        case SignUpStatus.DetailsError:
                            ErrorMessage = DETAILS_ERROR;
                            return MenuState.Error;
                        case SignUpStatus.UsernameTakenError:
                            ErrorMessage = USERNAME_TAKEN_ERROR;
                            return MenuState.Error;
                        
                    }
                    return MenuState.Error;                   
                case Command.Back:
                    ResetSignUp();
                    return MenuState.Back;
                //default:
                //    throw new NotSupportedException();
            }
            throw new System.InvalidOperationException();
        }

        public IView GetView(string userName)
        {
            return new SignUpView(this.ErrorMessage);
        }

        public void ReadPassword()
        {
            Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ResetSignUp()
        {
            ErrorMessage = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
