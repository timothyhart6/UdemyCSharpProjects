using System;

namespace CSharpTutorial
{
    class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime CreateTime { get; set; }
        private int VoteCount { get; set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreateTime = DateTime.Now;
        }

        public void Upvote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }

        public void DisplayVoteCount()
        {
            Console.WriteLine(VoteCount);
        }
    }

    

}
