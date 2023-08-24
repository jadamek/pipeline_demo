using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Head;
public class PipeHead<TInput1, TInput2>
{
    internal PipeHead() { }

    public PipeHead<TInput1, TInput2, TInput3> AndFrom<TInput3>(Func<int, Reader<TInput3>> generator)
    {
        return new PipeHead<TInput1, TInput2, TInput3>();
    }

    public Body.PipeMid<TInput1, TInput2, TOutput> As<TOutput>(Func<IEnumerable<TInput1>, IEnumerable<TInput2>, IQueryable<TOutput>> transform)
    {
        return new Body.PipeMid<TInput1, TInput2, TOutput>();
    }
}
