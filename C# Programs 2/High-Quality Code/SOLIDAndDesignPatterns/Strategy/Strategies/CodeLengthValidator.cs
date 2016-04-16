namespace SharpCompiler.Strategies
{
    using SharpCompiler.Exceptions;

    public class CodeLengthValidator : ICodeSyntaxValidationStrategy
    {
        public void Validate(string code)
        {
            if (!code.Contains("using System.Net;"))
            {
                throw new CompilationException(
                    "The code cannot be compiled without \"using System.Net;\"");
            }
        }
    }
}