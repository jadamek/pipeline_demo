using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Head;
public class PipeHead<TInput1, TInput2, TInput3>
{
    internal PipeHead() { }

    public Body.PipeMid<TInput1, TInput2, TInput3, TOutput> As<TOutput>(Func<IQueryable<TInput1>, IQueryable<TInput2>, IQueryable<TInput3>, IQueryable<TOutput>> transform)
    {
        return new Body.PipeMid<TInput1, TInput2, TInput3, TOutput>();
    }
}
