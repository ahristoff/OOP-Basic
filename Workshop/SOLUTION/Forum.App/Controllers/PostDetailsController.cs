namespace Forum.App.Controllers
{
    using Forum.App.Controllers.Contracts;
    using Forum.App.Services;
    using Forum.App.UserInterface;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Views;

    public class PostDetailsController : IController, IUserRestrictedController
    {
        private enum Command { Back, AddReply}

        public bool LoggedInUser { get; private set; }
        public int PostId { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Back:
                    ForumViewEngine.ResetBuffer();
                    return MenuState.Back;
                case Command.AddReply:
                    return MenuState.AddReplyToPost;                
            }
            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            var pmv = PostService.GetPostViewModel(PostId);
            return new PostDetailsView(pmv, LoggedInUser);
        }

        public void UserLogIn()
        {
            LoggedInUser = true;
        }

        public void UserLogOut()
        {
            LoggedInUser = false;
        }

        public void SetPostId(int postId)
        {
            PostId = postId;
        }
    }
}
