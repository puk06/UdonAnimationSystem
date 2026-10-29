using UnityEngine;

namespace net.puk06.UdonAnimation.Utils
{
    /// <summary>
    /// Transform 操作の共通処理。
    /// RectTransform 専用ではなく、すべての Component / GameObject の Transform を扱います。
    /// 位置・回転・スケールはすべてローカル空間の値です。
    /// </summary>
    public static class TransformUtils
    {
        public static Transform GetTransform(Component targetObject)
        {
            if (targetObject == null) return null;

            return targetObject.transform;
        }

        public static Transform GetTransform(GameObject targetObject)
        {
            if (targetObject == null) return null;

            return targetObject.transform;
        }

        /// <summary>
        /// GameObject を Component ベースの API に渡すための変換。
        /// </summary>
        public static Component ToComponent(GameObject targetObject)
        {
            if (targetObject == null) return null;

            return targetObject.transform;
        }

        public static Vector3 GetPosition(Component targetObject)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return Vector3.positiveInfinity;

            return transform.localPosition;
        }

        public static void SetPosition(Component targetObject, Vector3 position)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return;

            transform.localPosition = position;
        }

        public static Vector3 GetRotation(Component targetObject)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return Vector3.positiveInfinity;

            return transform.localEulerAngles;
        }

        public static void SetRotation(Component targetObject, Vector3 rotation)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return;

            transform.localEulerAngles = rotation;
        }

        public static Vector3 GetScale(Component targetObject)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return Vector3.positiveInfinity;

            return transform.localScale;
        }

        public static void SetScale(Component targetObject, Vector3 scale)
        {
            Transform transform = GetTransform(targetObject);
            if (transform == null) return;

            transform.localScale = scale;
        }
    }
}
