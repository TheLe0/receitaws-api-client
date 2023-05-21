using System;

namespace Receitaws.API.Client.Exceptions;

public class UnauthenticatedNotAllowedException : Exception
{
    public UnauthenticatedNotAllowedException() { }

    public UnauthenticatedNotAllowedException(string message)
        : base(message) { }

    public UnauthenticatedNotAllowedException(string message, Exception inner)
        : base(message, inner) { }
}