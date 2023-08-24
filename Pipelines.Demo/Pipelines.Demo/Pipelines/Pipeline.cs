using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pipelines.Demo.Pipelines.Head;

namespace Pipelines.Demo.Pipelines;
public class Pipeline
{
    public PipeHead<TInput> From<TInput>(Func<int, Reader<TInput>> generator)
    {
        return new PipeHead<TInput>();
    }
}
