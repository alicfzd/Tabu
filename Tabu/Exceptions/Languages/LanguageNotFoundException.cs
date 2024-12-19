using System.Runtime.Serialization;

namespace Tabu.Exceptions.Languages
{

    public class LanguageNotFoundException : Exception, IBaseException
    {
        public int StatusCode => StatusCodes.Status404NotFound;

        public string ErrorMessage { get; }
        public LanguageNotFoundException()
        {
            ErrorMessage = "Language Not Found";
        }

        protected LanguageNotFoundException(string message) : base(message)
        {
            ErrorMessage = message;
        }
    }
}
