using System;

namespace Common
{
    public static class ArgumentValidation
    {
        public static T ThrowIfNull<T>(T argument, string message)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(message);
            }
            return argument;
        }
    }
}
