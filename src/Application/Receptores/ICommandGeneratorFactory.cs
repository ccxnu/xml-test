public interface ICommandGeneratorFactory
{
    ICommandGenerator GetGenerator(string content);
}
