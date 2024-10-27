namespace System.Runtime.Versioning
{
    using System;

    /// <summary>
    /// Base type for all platform-specific API attributes.
    /// </summary>
    public abstract class OSPlatformAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OSPlatformAttribute"/> class.
        /// </summary>
        /// <param name="platformName">Name of the platform.</param>
        internal protected OSPlatformAttribute(string platformName)
        {
            PlatformName = platformName;
        }

        /// <summary>
        /// Gets the name and optional version of the platform that the attribute applies to.
        /// </summary>
        /// <value>The name and optional version of the platform that the attribute applies to.</value>
        public string PlatformName { get; }
    }
}
