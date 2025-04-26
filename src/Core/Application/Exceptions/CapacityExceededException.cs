namespace Healthcare.Application.Exceptions;

public class CapacityExceededException : ApplicationException
{
    public CapacityExceededException(string message) : base(message)
    {
    }
}
