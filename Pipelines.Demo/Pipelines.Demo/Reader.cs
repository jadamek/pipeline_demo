using System.Collections;
using System.Linq.Expressions;

namespace Pipelines.Demo;
public class Reader<TInput> : IQueryable<TInput>
{
    public Type ElementType => typeof(TInput);

    public Expression Expression => throw new NotImplementedException();

    public IQueryProvider Provider => throw new NotImplementedException();

    public IEnumerator<TInput> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
