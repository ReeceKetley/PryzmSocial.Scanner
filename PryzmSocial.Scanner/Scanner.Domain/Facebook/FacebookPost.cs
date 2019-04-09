using System;

namespace Scanner.Domain.Facebook
{
    public class FacebookPost
    {
        public FacebookPost()
        {
        }

        public DateTime PostedOn { get; }
        public PostReactions Reactions { get; }
        public PostContent  Content { get; }
        public int NumComments { get; }
        public int NumShares { get; }
    }
}