using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    internal static class PostService
    {
        public static Category GetCategory(int id)
        {
            var forumData = new ForumData();
            var category = forumData.Categories.Single(c => c.Id == id);
            return category;
        }

        public static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Single(p => p.Id == postId);

            var replies = new List<ReplyViewModel>();
            foreach (var x in post.ReplyIds)
            {
                var reply = forumData.Replies.First(r => r.Id == x);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        public static string[] GetAllCategoryNames()
        {
            var forumData = new ForumData();
            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();
            return allCategories;
        }

        public static IEnumerable<Post> GetPostByCategory(int categoryId)
        {
            var forumData = new ForumData();
            var postIds = forumData.Categories.First(c => c.Id == categoryId).PostIds;
            return forumData.Posts.Where(p => postIds.Contains(p.Id));
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Find(p => p.Id == postId);
            PostViewModel pmv = new PostViewModel(post);
              
            return pmv;
        }

        private static Category EnsureCategory(PostViewModel postViewModel, ForumData forumData)
        {
            var categoryName = postViewModel.Category;
            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);

            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.Last().Id + 1 : 1;
                category = new Category(categoryId, categoryName, new List<int>());
                forumData.Categories.Add(category);
                forumData.SaveChanges();  ///
            }
            return category;
        }
        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var isContentValid = postViewModel.Content.Any();
            var isCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);

            if (!isTitleValid || !isContentValid || !isCategoryValid)
            {
                return false;
            }
            var forumData = new ForumData();
            var category = EnsureCategory(postViewModel, forumData);

            var postId = forumData.Posts.Last()?.Id + 1 ?? 1;
            var author = forumData.Users.Single(u => u.Username == postViewModel.Author);
            var content = string.Join("", postViewModel.Content);

            var post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());

            forumData.Posts.Add(post);
            category.PostIds.Add(postId);
            author.PostIds.Add(postId);
            forumData.SaveChanges();
            postViewModel.PostId = postId;

            return true;
        }
    }
}
