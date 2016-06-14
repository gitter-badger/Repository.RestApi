using System.Linq;

namespace Repository.RestApi
{
    public interface ISet<out T> : IOrderedQueryable<T>
    {
    }
}