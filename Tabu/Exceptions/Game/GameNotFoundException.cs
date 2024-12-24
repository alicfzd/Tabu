﻿namespace Tabu.Exceptions.Game
{
    public class GameNotFoundException : Exception, IBaseException
    {
        public int StatusCode => StatusCodes.Status404NotFound;

        public string ErrorMessage { get; }
        public GameNotFoundException()
        {
            ErrorMessage = "Game Not Found";
        }

        protected GameNotFoundException(string message) : base(message)
        {
            ErrorMessage = message;
        }
    }
}
