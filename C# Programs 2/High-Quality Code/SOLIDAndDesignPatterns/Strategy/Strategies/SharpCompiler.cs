namespace SharpCompiler.Strategies
{
    public interface ICodeSyntaxValidationStrategy
    {
        void Validate(string code);
    }
}