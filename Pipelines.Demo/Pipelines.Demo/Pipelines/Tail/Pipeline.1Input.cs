using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Tail;
public class Pipeline<TInput, TOutput>
{
    internal Pipeline(Func<int, Writer<TOutput>> writerGenerator)
    {
        Writers.Add(writerGenerator);
    }

    public virtual Pipeline<TInput, TOutput> AndTo(Func<int, Writer<TOutput>> writerGenerator)
    {
        Writers.Add(writerGenerator);
        return this;
    }

    public virtual Pipeline<TInput, TOutput> Run() { return this; }

    // Properties
    List<Func<int, Writer<TOutput>>> Writers { get; } = new List<Func<int, Writer<TOutput>>>();
}
