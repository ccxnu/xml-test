public class CommandGeneratorFactory : ICommandGeneratorFactory
{
    private readonly IEnumerable<ICommandGenerator> _generators;

    public CommandGeneratorFactory(IEnumerable<ICommandGenerator> generators)
    {
        _generators = generators;
    }

    public ICommandGenerator GetGenerator(string content)
    {
        return _generators.FirstOrDefault(g => g.CanHandle(content))
               ?? throw new InvalidOperationException("No se encontró un generador para este tipo de contenido.");
    }
}
