using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Body;
public class PipeMid<TInput1, TInput2, TOutput>
{
    internal PipeMid() { }

    public Tail.Pipeline<TInput1, TInput2, TOutput> To(Func<int, Writer<TOutput>> writerGenerator)
    {
        return new Tail.Pipeline<TInput1, TInput2, TOutput>(writerGenerator);
    }
}
