using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipelines.Demo.Pipelines.Tail;
public class Pipeline<TInput1, TInput2, TOutput> : Pipeline<TInput1, TOutput>
{
    internal Pipeline(Func<int, Writer<TOutput>> writerGenerator) : base(writerGenerator)
    {
    }

    public override Pipeline<TInput1, TInput2, TOutput> AndTo(Func<int, Writer<TOutput>> writerGenerator)
    {
        Writers.Add(writerGenerator);
        return this;
    }

    public override Pipeline<TInput1, TInput2, TOutput> Run() { return this; }

    // Properties
    List<Func<int, Writer<TOutput>>> Writers { get; } = new List<Func<int, Writer<TOutput>>>();
}
