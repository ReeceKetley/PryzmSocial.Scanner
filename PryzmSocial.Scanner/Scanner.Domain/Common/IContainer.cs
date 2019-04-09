namespace Scanner.Domain.Common
{
    public interface IContainer
    {
        T Resolve<T>() where T : class;
    }
}