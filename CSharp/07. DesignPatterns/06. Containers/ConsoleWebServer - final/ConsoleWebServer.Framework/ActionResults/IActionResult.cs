﻿namespace ConsoleWebServer.Framework.ActionResults
{
    /// <summary>
    /// Represents an action result object which provides response.
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        /// Returns the HTTP response generated by the action result
        /// </summary>
        /// <returns>The HTTP response</returns>
        IHttpResponse GetResponse();
    }
}