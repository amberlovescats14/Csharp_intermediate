using System;
namespace Mosh_Part2.exerecises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime CreatedAt { get; set; }
        private int Votes = 0;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = new DateTime();

        }

        public void UpVote()
        {
            Votes += 1;
            Console.WriteLine("Thumbs up");
        }

        public void DownVote()
        {
            Votes -= 1;
            Console.WriteLine("Thumbs down");
        }

        public int GetVoteCount()
        {
            return Votes;
        }
    }
}
