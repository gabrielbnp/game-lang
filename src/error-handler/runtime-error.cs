public class RuntimeError : Error
{
    public RuntimeError() : base() {}
    public RuntimeError(List<string> code) : base(code) { }

    public void error(Token token, string errorMessage)
    {
        error(token, errorMessage);
        throw new Exception();
    }
}