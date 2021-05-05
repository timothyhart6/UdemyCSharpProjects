using System;

namespace CSharpTutorial
{
    class Post
    {
        string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public int VoteCount { get; }
    }

}
