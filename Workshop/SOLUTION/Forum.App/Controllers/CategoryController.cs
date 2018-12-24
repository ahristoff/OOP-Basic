namespace Forum.App.Controllers
{
    using System;

    using Forum.App.Controllers.Contracts;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Services;
    using System.Linq;
    using Forum.App.Views;

    public class CategoryController : IController, IPaginationController
    {
        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        private enum Command
        {
            Back = 0,
            ViewPost = 1,
            PreviousPage = 11,
            NextPage = 12
        }

        public int CurrentPage { get; set ; }

        private string[] PostTitles { get; set; }

        private bool IsFirstPage => CurrentPage == 0; //

        private bool IsLastPage => CurrentPage == LastPage; //

        public CategoryController()
        {
            CurrentPage = 0;
            SetCategory(0);
        }

        private int LastPage => PostTitles.Length / 11;

        public int CategoryId { get; private set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Back:
                    return MenuState.Back;
                case Command.ViewPost:
                    return MenuState.ViewPost;
                case Command.PreviousPage:
                    return MenuState.OpenCategory;
                case Command.NextPage:
                    return MenuState.OpenCategory;               
            }
            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            GetPosts();
            string categoryName = PostService.GetCategory(CategoryId).Name;
            return new CategoryView(categoryName, PostTitles, IsFirstPage, IsLastPage);
        }

        public void SetCategory(int categoryId)
        {
            CategoryId = categoryId;
        }

        private void ChangePage(bool forward = true)
        {
            CurrentPage += forward ? 1 : -1;
            GetPosts();
        }

        private void GetPosts()
        {
            var allCategoryPosts = PostService.GetPostByCategory(CategoryId);

            PostTitles = allCategoryPosts
                .Skip(CurrentPage * PAGE_OFFSET)
                .Take(PAGE_OFFSET)
                .Select(p => p.Title)
                .ToArray();
        }
    }
}
