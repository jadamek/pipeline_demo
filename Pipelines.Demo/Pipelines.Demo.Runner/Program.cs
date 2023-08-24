var pipeline =
    new Pipelines.Demo.Pipelines.Pipeline()
    .From((n) => new Pipelines.Demo.Reader<string>())
    .To((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .Run();

var pipeline1 =
    new Pipelines.Demo.Pipelines.Pipeline()
    .From((n) => new Pipelines.Demo.Reader<string>())
    .AndFrom((n) => new Pipelines.Demo.Reader<int>())
    .AndFrom((n) => new Pipelines.Demo.Reader<float>())
    .As((x, y, z) => Array.Empty<double>().AsQueryable())
    .To((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .AndTo((n) => new Pipelines.Demo.Writer<double>())
    .Run();

var pipeline2 =
    new Pipelines.Demo.Pipelines.Pipeline()
    .From((n) => new Pipelines.Demo.Reader<string>())
    .To((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .AndTo((n) => new Pipelines.Demo.Writer<string>())
    .Run();