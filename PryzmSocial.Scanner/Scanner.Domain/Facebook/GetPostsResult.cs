using System.Collections.Generic;

namespace Scanner.Domain.Facebook
{
    public class GetPostsResult
    {
        public GetPostsResult(GetPostsResultCode code)
        {
            Code = code;
        }

        public GetPostsResult(IEnumerable<FacebookPost> posts)
        {
            Code = GetPostsResultCode.Success;
            Posts = posts;
        }

        public GetPostsResultCode Code { get; }

        public IEnumerable<FacebookPost> Posts { get; }
    }
}