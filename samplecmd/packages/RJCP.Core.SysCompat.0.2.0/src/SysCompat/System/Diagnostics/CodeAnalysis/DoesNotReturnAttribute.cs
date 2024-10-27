namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that a method will never return under any circumstance.
    /// </summary>
    /// <remarks>
    /// For more information, see Nullable static analysis in the C# guide.
    /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/nullable-analysis
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public class DoesNotReturnAttribute : Attribute { }
}
