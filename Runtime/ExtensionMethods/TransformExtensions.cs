using UnityEngine;

namespace NovaDawnStudios.NovaUtils
{
    /// <summary>
    ///     Provides extension methods for the <see cref="Transform"/> Unity type.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        ///     Sets the position, rotation and scale of the supplied <paramref name="transform"/> to the given <paramref name="matrix"/>.
        /// </summary>
        /// <param name="transform">The transform we're setting the matrix on.</param>
        /// <param name="matrix">The matrix we're setting the transform to.</param>
        public static void SetMatrix(this Transform transform, Matrix4x4 matrix)
        {
            transform.localScale = matrix.ExtractScale();
            transform.rotation = matrix.ExtractRotation();
            transform.position = matrix.ExtractPosition();
        }

        /// <summary>
        ///     Destroys all child <see cref="GameObject"/>s of the supplied <paramref name="transform"/>.
        /// </summary>
        /// <param name="transform">The transform whose children we will be destroying.</param>
        public static void DestroyAllChildren(this Transform transform)
        {
            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                Object.Destroy(transform.GetChild(i).gameObject);
            }
        }
    }
}