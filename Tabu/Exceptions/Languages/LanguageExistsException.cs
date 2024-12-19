namespace Tabu.Exceptions.Languages
{
    public class LanguageExistsException : Exception, IBaseException
    {
        public int StatusCode => StatusCodes.Status409Conflict;

        public string ErrorMessage { get; }
        public LanguageExistsException()
        {
            ErrorMessage = "Language already added in db";
        }

        public LanguageExistsException(string? message) : base()
        {
            ErrorMessage = message;
        }
    }
}
