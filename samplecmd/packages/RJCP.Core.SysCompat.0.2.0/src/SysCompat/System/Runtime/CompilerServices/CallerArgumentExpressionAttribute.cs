namespace System.Runtime.CompilerServices
{
    using System;

    /// <summary>
    /// Indicates that a parameter captures the expression passed for another parameter as a string..
    /// </summary>
    /// <remarks>
    /// A class for backwards compatibility to use the feature with C# 10 language features with frameworks older than
    /// .NET Core 6.0. It is tested to work with .NET Framework 4.0.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public sealed class CallerArgumentExpressionAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerArgumentExpressionAttribute"/> class.
        /// </summary>
        /// <param name="parameterName">The name of the parameter whose expression should be captured as a string.</param>
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        /// <summary>
        /// Gets the name of the parameter whose expression should be captured as a string.
        /// </summary>
        /// <value>The name of the parameter whose expression should be captured.</value>
        public string ParameterName { get; }
    }
}
