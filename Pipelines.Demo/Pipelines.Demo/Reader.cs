using System.Collections;
using System.Linq.Expressions;

namespace Pipelines.Demo;
public class Reader<TInput> : IEnumerator<TInput>
{
    public TInput Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
