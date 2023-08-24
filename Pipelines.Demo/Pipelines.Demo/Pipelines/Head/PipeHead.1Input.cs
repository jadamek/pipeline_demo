using Pipelines.Demo.Pipelines.Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Head;
public class PipeHead<TInput>
{
    internal PipeHead() { }
    public PipeHead<TInput, TInput2> AndFrom<TInput2>(Func<int, Reader<TInput2>> generator)
    {
        return new PipeHead<TInput, TInput2>();
    }

    public Body.PipeMid<TInput, TOutput> As<TOutput>(Func<IEnumerable<TInput>, IQueryable<TOutput>> transform)
    {
        return new Body.PipeMid<TInput, TOutput>();
    }

    public Tail.Pipeline<TInput, TInput> To(Func<int, Writer<TInput>> writerGenerator)
    {
        return new Tail.Pipeline<TInput, TInput>(writerGenerator);
    }
}
