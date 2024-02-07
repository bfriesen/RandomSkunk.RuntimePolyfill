// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NETCOREAPP2_2 || NETCOREAPP2_1 || NETCOREAPP2_0 || NETSTANDARD2_0 || NET48 || NET472 || NET471 || NET47 || NET462 || NET461

#nullable enable

namespace System.Runtime.CompilerServices
{
    internal static class RuntimeHelpers
    {
        public static T[] GetSubArray<T>(T[] array, Range range)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            T[] dest;
            (int offset, int length) = range.GetOffsetAndLength(array.Length);

            if (default(T) != null || typeof(T[]) == array.GetType())
            {
                // We know the type of the array to be exactly T[].
                if (length == 0)
                    return Empty<T>.Array;

                dest = new T[length];
            }
            else
            {
                // The array is actually a U[] where U:T.
                dest = (T[])Array.CreateInstance(array.GetType().GetElementType(), length);
            }

            Array.Copy(array, offset, dest, 0, length);
            return dest;
        }

        private static class Empty<T>
        {
            public static readonly T[] Array = new T[0];
        }
    }
}

#endif
