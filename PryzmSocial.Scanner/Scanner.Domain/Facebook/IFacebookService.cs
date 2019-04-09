namespace Scanner.Domain.Facebook
{
    public interface IFacebookService
    {
        GetPostsResult GetPosts(FacebookHandle handle);
    }
}