using UnityEngine;

namespace NovaDawnStudios.NovaUtils
{
    /// <summary>
    ///     Provides extension methods for the <see cref="AudioSource"/> Unity type.
    /// </summary>
    public static class AudioSourceExtensions
    {
        /// <summary>
        ///     Sets a maximum distance for the given <paramref name="audioSource"/> instance with a simple falloff curve that hits exactly 0 at 
        ///     <paramref name="maxDist"/>.
        /// </summary>
        /// <param name="audioSource">The <see cref="AudioSource"/> instance we're setting the distance of.</param>
        /// <param name="maxDist">The maximum distance the supplied <paramref name="audioSource"/> will be audible at.</param>
        public static void SetMaxDistanceWithFalloff(this AudioSource audioSource, float maxDist)
        {
            audioSource.maxDistance = maxDist;
            audioSource.rolloffMode = AudioRolloffMode.Custom;

            var ac = new AnimationCurve();
            for (float i = 0; i < 1.0f; i += 0.1f)
            {
                ac.AddKey(i * maxDist, Mathf.Pow(1.0f / 2048.0f, i));
            }
            ac.AddKey(maxDist, 0.0f);

            audioSource.SetCustomCurve(AudioSourceCurveType.CustomRolloff, ac);
        }
    }
}