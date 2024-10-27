namespace System.Runtime.Versioning
{
    using System;

    /// <summary>
    /// Indicates that an API is supported for a specified platform or operating system. If a version is specified, the
    /// API cannot be called from an earlier version. Multiple attributes can be applied to indicate support on multiple
    /// operating systems.
    /// </summary>
    /// <remarks>
    /// Callers can apply a SupportedOSPlatformAttribute or use guards to prevent calls to APIs on unsupported operating
    /// systems. A given platform should only be specified once.
    /// <para>This attribute is provided for compatibility to older frameworks. It isn't used anywhere.</para>
    /// </remarks>
    [AttributeUsage(
        AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor |
        AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field |
        AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module |
        AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public sealed class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedOSPlatformAttribute"/> class for the specified
        /// supported OS platform..
        /// </summary>
        /// <param name="platformName">The supported OS platform name, optionally including a version.</param>
        public SupportedOSPlatformAttribute(string platformName)
            : base(platformName) { }
    }
}
