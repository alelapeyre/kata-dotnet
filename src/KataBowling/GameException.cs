using System;

namespace KataBowling
{
    public class GameException : Exception
    {
        public GameException(string message) : base(message)
        {

        }
    }
}
