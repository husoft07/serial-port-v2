namespace System
{
    using System.Runtime.CompilerServices;

    public static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ObjectDisposedException"/> if the specified <paramref name="condition"/> is
        /// <see langword="true"/>.
        /// </summary>
        /// <param name="condition">The condition to evaluate.</param>
        /// <param name="type">
        /// The type whose full name should be included in any resulting <see cref="ObjectDisposedException"/>.
        /// </param>
        /// <exception cref="ObjectDisposedException">
        /// The <paramref name="condition"/> is <see langword="true"/>.
        /// </exception>
        /// <remarks>
        /// Is used to implement CA1513.
        /// <para>
        /// If using with .NET Core 7.0 or later without considering source compatibility to older versions, then use
        /// <c>ObjectDisposedException.ThrowIf</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfDisposed(bool condition, Type type)
        {
#if NET7_0_OR_GREATER
            ObjectDisposedException.ThrowIf(condition, type);
#else
            if (condition)
                throw new ObjectDisposedException(type?.FullName);
#endif
        }

        /// <summary>
        /// Throws an <see cref="ObjectDisposedException"/> if the specified <paramref name="condition"/> is
        /// <see langword="true"/>.
        /// </summary>
        /// <param name="condition">The condition to evaluate.</param>
        /// <param name="instance">
        /// The object whose type's full name should be included in any resulting <see cref="ObjectDisposedException"/>.
        /// </param>
        /// <exception cref="ObjectDisposedException">
        /// The <paramref name="condition"/> is <see langword="true"/>.
        /// </exception>
        /// <remarks>
        /// Is used to implement CA1513.
        /// <para>
        /// If using with .NET Core 7.0 or later without considering source compatibility to older versions, then use
        /// <c>ObjectDisposedException.ThrowIf</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfDisposed(bool condition, object instance)
        {
#if NET7_0_OR_GREATER
            ObjectDisposedException.ThrowIf(condition, instance);
#else
            if (condition)
                throw new ObjectDisposedException(instance?.GetType().FullName);
#endif
        }
    }
}
