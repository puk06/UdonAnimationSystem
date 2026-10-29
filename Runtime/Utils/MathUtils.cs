using net.puk06.UdonAnimation.Models;
using UdonSharp;
using UnityEngine;

namespace net.puk06.UdonAnimation.Utils
{
    public static class MathUtils
    {
        public static float ApplyEasing(float time, TransitionType transitionType)
        {
            switch (transitionType)
            {
                case TransitionType.Linear:
                    return time;
                case TransitionType.EaseIn:
                    return time * time;
                case TransitionType.EaseOut:
                    return 1f - ((1f - time) * (1f - time));
                case TransitionType.EaseInOut:
                    return time * time * (3f - (2f * time));
                default:
                    return time;
            }
        }

        public static bool IsPositiveInfinity(Vector3 vector3)
        {
            return float.IsPositiveInfinity(vector3.x)
                && float.IsPositiveInfinity(vector3.y)
                && float.IsPositiveInfinity(vector3.z);
        }

        public static bool IsPositiveInfinity(Color color)
        {
            return float.IsPositiveInfinity(color.r)
                && float.IsPositiveInfinity(color.g)
                && float.IsPositiveInfinity(color.b)
                && float.IsPositiveInfinity(color.a);
        }
    }
}
