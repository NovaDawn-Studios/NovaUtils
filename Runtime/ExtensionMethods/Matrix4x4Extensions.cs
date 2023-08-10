using UnityEngine;

namespace NovaDawnStudios.NovaUtils
{
    /// <summary>
    ///     Provides extension methods for the <see cref="Matrix4x4"/> Unity type.
    /// </summary>
    public static class Matrix4x4Extensions
    {
        /// <summary>
        ///     Extracts the rotation from the supplied <paramref name="matrix"/> as a <see cref="Quaternion"/>.
        /// </summary>
        /// <param name="matrix">The matrix we're extracting the rotation from.</param>
        /// <returns>The rotation extracted from the supplied <paramref name="matrix"/>.</returns>
        public static Quaternion ExtractRotation(this Matrix4x4 matrix)
        {
            Vector3 forward;
            forward.x = matrix.m02;
            forward.y = matrix.m12;
            forward.z = matrix.m22;

            Vector3 upwards;
            upwards.x = matrix.m01;
            upwards.y = matrix.m11;
            upwards.z = matrix.m21;

            return Quaternion.LookRotation(forward, upwards);
        }

        /// <summary>
        ///     Extracts the position from the supplied <paramref name="matrix"/> as a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="matrix">The matrix we're extracting the position from.</param>
        /// <returns>The position extracted from the supplied <paramref name="matrix"/>.</returns>
        public static Vector3 ExtractPosition(this Matrix4x4 matrix)
        {
            Vector3 position;
            position.x = matrix.m03;
            position.y = matrix.m13;
            position.z = matrix.m23;
            return position;
        }

        /// <summary>
        ///     Extracts the scale from the supplied <paramref name="matrix"/> as a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="matrix">The matrix we're extracting the scale from.</param>
        /// <returns>The scale extracted from the supplied <paramref name="matrix"/>.</returns>
        public static Vector3 ExtractScale(this Matrix4x4 matrix)
        {
            Vector3 scale;
            scale.x = new Vector4(matrix.m00, matrix.m10, matrix.m20, matrix.m30).magnitude;
            scale.y = new Vector4(matrix.m01, matrix.m11, matrix.m21, matrix.m31).magnitude;
            scale.z = new Vector4(matrix.m02, matrix.m12, matrix.m22, matrix.m32).magnitude;
            return scale;
        }
    }
}
