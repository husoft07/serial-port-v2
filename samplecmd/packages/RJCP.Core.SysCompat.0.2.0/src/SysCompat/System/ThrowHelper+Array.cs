namespace System
{
    using System.Runtime.CompilerServices;

    public static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the <paramref name="array"/> is of length zero.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to validate against.</param>
        /// <param name="arrayName">The name of the <paramref name="array"/> parameter.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="array"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">The <paramref name="array"/> has a length of zero.</exception>
        public static void ThrowIfArrayEmpty<T>(T[] array,
            [CallerArgumentExpression(nameof(array))] string arrayName = null)
        {
            ThrowIfNull(array, arrayName);
            if (array.Length is 0)
                throw new ArgumentException($"{arrayName}.Length must be non-zero.", arrayName);
        }

        /// <summary>
        /// Throws an exception if <paramref name="index"/> is out of bounds for <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">A generic type for a single ranked array.</typeparam>
        /// <param name="array">The array to validate against.</param>
        /// <param name="index">The index to validate as being in <paramref name="array"/>.</param>
        /// <param name="arrayName">The name of the <paramref name="array"/> parameter.</param>
        /// <param name="indexName">The name of the <paramref name="index"/> parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"/> is <see langword="null"/>..</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The <paramref name="index"/> is less than zero, or exceeds the boundary of <paramref name="array"/>.
        /// </exception>
        public static void ThrowIfArrayOutOfBounds<T>(T[] array, int index,
            [CallerArgumentExpression(nameof(array))] string arrayName = null,
            [CallerArgumentExpression(nameof(index))] string indexName = null)
        {
            ThrowIfNull(array, arrayName);
            ThrowIfNotBetween(index, 0, array.Length - 1, indexName);
        }

        /// <summary>
        /// Throws an exception if <paramref name="index"/> is out of bounds for <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">A generic type for a single ranked array.</typeparam>
        /// <param name="array">The array to validate against.</param>
        /// <param name="index">The index to validate as being in <paramref name="array"/>.</param>
        /// <param name="arrayName">The name of the <paramref name="array"/> parameter.</param>
        /// <param name="indexName">The name of the <paramref name="index"/> parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"/> is <see langword="null"/>..</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// The <paramref name="index"/> is less than zero, or exceeds the boundary of <paramref name="array"/>.
        /// </exception>
        public static void ThrowIfArrayOutOfBounds<T>(T[] array, long index,
            [CallerArgumentExpression(nameof(array))] string arrayName = null,
            [CallerArgumentExpression(nameof(index))] string indexName = null)
        {
            ThrowIfNull(array, arrayName);
            ThrowIfNotBetween(index, 0, array.LongLength - 1, indexName);
        }

        /// <summary>
        /// Throws an exception if <paramref name="offset"/> or <paramref name="length"/> can cause an out of bounds
        /// access to <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">A generic type for a single ranked array.</typeparam>
        /// <param name="array">The array to validate against.</param>
        /// <param name="offset">The index to validate as being in <paramref name="array"/>.</param>
        /// <param name="length">
        /// The length to validate as being in bounds with <paramref name="offset"/> within <paramref name="array"/>.
        /// </param>
        /// <param name="arrayName">Name of the <paramref name="array"/> parameter.</param>
        /// <param name="offsetName">Name of the <paramref name="offset"/> parameter.</param>
        /// <param name="lengthName">Name of the <paramref name="length"/> parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset"/> is must be zero or positive;
        /// <para>- or -</para>
        /// <paramref name="length"/> is must be zero or positive.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="array"/> out of bounds access with <paramref name="offset"/> and <paramref name="length"/>
        /// exceeding the array length.
        /// </exception>
        public static void ThrowIfArrayOutOfBounds<T>(T[] array, int offset, int length,
            [CallerArgumentExpression(nameof(array))] string arrayName = null,
            [CallerArgumentExpression(nameof(offset))] string offsetName = null,
            [CallerArgumentExpression(nameof(length))] string lengthName = null)
        {
            ThrowIfNull(array, arrayName);
            ThrowIfNegative(offset, offsetName);
            ThrowIfNegative(length, lengthName);
            if (offset > array.Length - length)
                throw new ArgumentException($"{arrayName} out of bounds access with offset '{offset}' and length '{length}' exceeding '{array.Length}'.");
        }

        /// <summary>
        /// Throws an exception if <paramref name="offset"/> or <paramref name="length"/> can cause an out of bounds
        /// access to <paramref name="array"/>.
        /// </summary>
        /// <typeparam name="T">A generic type for a single ranked array.</typeparam>
        /// <param name="array">The array to validate against.</param>
        /// <param name="offset">The index to validate as being in <paramref name="array"/>.</param>
        /// <param name="length">
        /// The length to validate as being in bounds with <paramref name="offset"/> within <paramref name="array"/>.
        /// </param>
        /// <param name="arrayName">Name of the <paramref name="array"/> parameter.</param>
        /// <param name="offsetName">Name of the <paramref name="offset"/> parameter.</param>
        /// <param name="lengthName">Name of the <paramref name="length"/> parameter.</param>
        /// <exception cref="ArgumentNullException"><paramref name="array"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="offset"/> is must be zero or positive;
        /// <para>- or -</para>
        /// <paramref name="length"/> is must be zero or positive.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <paramref name="array"/> out of bounds access with <paramref name="offset"/> and <paramref name="length"/>
        /// exceeding the array length.
        /// </exception>
        public static void ThrowIfArrayOutOfBounds<T>(T[] array, long offset, long length,
            [CallerArgumentExpression(nameof(array))] string arrayName = null,
            [CallerArgumentExpression(nameof(offset))] string offsetName = null,
            [CallerArgumentExpression(nameof(length))] string lengthName = null)
        {
            ThrowIfNull(array, arrayName);
            ThrowIfNegative(offset, offsetName);
            ThrowIfNegative(length, lengthName);
            if (offset > array.LongLength - length)
                throw new ArgumentException($"{arrayName} out of bounds access with offset '{offset}' and length '{length}' exceeding '{array.LongLength}'.");
        }
    }
}
