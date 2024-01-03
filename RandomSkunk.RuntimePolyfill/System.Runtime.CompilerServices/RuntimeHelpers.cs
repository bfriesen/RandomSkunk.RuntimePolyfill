#if !NETSTANDARD2_1_OR_GREATER && !NET6_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

#pragma warning disable IDE0079
#pragma warning disable IDE0301

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
                    return Array.Empty<T>();

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
    }
}

#endif
