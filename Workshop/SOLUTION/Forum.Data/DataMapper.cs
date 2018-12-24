using Forum.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Forum.Data
{
    class DataMapper
    {
        //where will data stored
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";

        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";
        // wenn not exists config file put default value

        static DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH);
        }

        private static readonly Dictionary<string, string> config;
        //key users, value users.csv
        //readonly - only one have been read 

        private static void EnsureConfigFile(string configPath)
        {
            //ensure whether is config file aviable
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
                //wenn no write default
            }

        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                //ensure whether is file aviable. wenn no create
                File.Create(path).Close(); // close - because returns stream
            }
        }

        private static string[] ReadLines(string path)
        {
            //check whether the file exists
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines;
        }

        private static void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        //read config
        private static Dictionary<string, string> LoadConfig(string configPath)
        {

            EnsureConfigFile(configPath); // ensure configfile exists
            var contens = ReadLines(configPath);//read content from config file

            var config = contens
                .Select(l => l.Split('='))
                .ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return config;//return configfile in dict -> key users value - users.csv + path to rootfolder
                          //see above -> private const string DEFAULT_CONFIG 
        }

        //Category
        public static List<Category> LoadCategories()
        {
            //we take all categories as lines and then we will it parse as objects

            var categories = new List<Category>();
            var lines = ReadLines(config["categories"]);

            foreach (var x in lines)
            {
                var args = x.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var name = args[1];
                var postIds = args[2]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var category = new Category(id, name, postIds);
                categories.Add(category);
            }

            return categories;
        }

        public static void SaveCategories(List<Category> categories)
        {
            //save categories in file
            var lines = new List<string>();

            foreach (var x in categories)
            {
                var line = string.Format("{0};{1};{2}", x.Id, x.Name, string.Join(",", x.PostIds));
                lines.Add(line);
            }

            WriteLines(config["categories"], lines.ToArray());
        }

        //User
        public static List<User> LoadUsers()
        {
            var users = new List<User>();
            var lines = ReadLines(config["users"]);

            foreach (var x in lines)
            {
                var args = x.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var username = args[1];
                var password = args[2];
                //var postIds = args[3]
                //    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                //    .Select(int.Parse)
                //    .ToArray();

                var user = new User(id, username, password);
                users.Add(user);
            }

            return users;
        }

        public static void SaveUsers(List<User> users)
        {

            var lines = new List<string>();

            foreach (var x in users)
            {
                var line = string.Format("{0};{1};{2}", x.Id, x.Username, x.Password);
                lines.Add(line);
            }

            WriteLines(config["users"], lines.ToArray());
        }

        //Post
        public static List<Post> LoadPost()
        {
            var posts = new List<Post>();
            var lines = ReadLines(config["posts"]);

            foreach (var x in lines)
            {
                var args = x.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var title = args[1];
                var content = args[2];
                var categoryId = int.Parse(args[3]);
                var authorId = int.Parse(args[4]);
                var replyIds = args[5]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var post = new Post(id, title, content, categoryId, authorId, replyIds);
                posts.Add(post);
            }

            return posts;
        }

        public static void SavePosts(List<Post> posts)
        {

            var lines = new List<string>();

            foreach (var x in posts)
            {
                var line = string.Format("{0};{1};{2};{3};{4};{5}", x.Id, x.Title, x.Content, x.CategoryId, x.AuthorId, string.Join(",", x.ReplyIds));
                lines.Add(line);
            }

            WriteLines(config["posts"], lines.ToArray());
        }

        //Reply
        public static List<Reply> LoadReplies()
        {

            var replies = new List<Reply>();
            var lines = ReadLines(config["replies"]);

            foreach (var x in lines)
            {
                var args = x.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(args[0]);
                var content = args[1];
                var authorId = int.Parse(args[2]);
                var postId = int.Parse(args[3]);

                var reply = new Reply(id, content, authorId, postId);
                replies.Add(reply);
            }

            return replies;
        }

        public static void SaveReplies(List<Reply> replies)
        {

            var lines = new List<string>();

            foreach (var x in replies)
            {
                var line = string.Format("{0};{1};{2};{3}", x.Id, x.Content, x.AuthorId, x.PostId);
                lines.Add(line);
            }

            WriteLines(config["replies"], lines.ToArray());
        }
    }
}