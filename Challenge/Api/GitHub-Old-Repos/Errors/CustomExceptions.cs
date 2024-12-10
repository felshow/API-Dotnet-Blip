using System;

namespace GitHub_Old_Repos.Errors // Verifique se este é o namespace correto
{
    public class GitHubApiException : Exception
    {
        public GitHubApiException(string message) : base(message) { }
        public GitHubApiException(string message, Exception inner) : base(message, inner) { }
    }

    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, Exception inner) : base(message, inner) { }
    }
}
