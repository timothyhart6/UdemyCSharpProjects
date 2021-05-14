using System;

namespace CSharpTutorial
{
    class Post
    {
        private readonly string _title;
        private readonly string _description;
        private readonly DateTime _createTime;
        private int VoteCount { get; set; }

        public Post(string title, string description)
        {
            this._title = title;
            this._description = description;
            this._createTime = DateTime.Now;
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
            Console.WriteLine(_title);
            Console.WriteLine(_description);
            Console.WriteLine(_createTime);
        }
    }

    

}
