using System;
namespace Game
{
    class GameException : System.Exception
    {
        public GameException()
        {
            
        }

        public GameException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : GameException
    {
        public OutOfBoundsException()
        {
            
        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}
