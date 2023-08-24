using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Body;
public class PipeMid<TInput, TOutput>
{
    internal PipeMid() { }

    public Tail.Pipeline<TInput, TOutput> To(Func<int, Writer<TOutput>> writerGenerator)
    {
        return new Tail.Pipeline<TInput, TOutput>(writerGenerator);
    }
}
