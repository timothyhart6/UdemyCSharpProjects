using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{

    class Program
    {

        static void Main(string[] args)
        {
            var post = new Post("Test Title", "Test Description");

            post.DownVote();
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.DisplayVoteCount();
        }
    }
    
}
