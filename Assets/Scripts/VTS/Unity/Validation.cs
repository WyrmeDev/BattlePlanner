namespace VTS.Unity
{
    using System;
    using System.Diagnostics;
    using Debug = UnityEngine.Debug;
    using Object = UnityEngine.Object;

    public static class _Validation
    {
        [Conditional("UNITY_EDITOR")]
        public static void Validate(this Object unityObject, bool testResult, string failureMessage, Action additionalTestCallback = null)
        {
            if(testResult is false)
            {
                Debug.LogError($"[{unityObject.name}] {failureMessage}", unityObject);
            }
            else
            {
                additionalTestCallback?.Invoke();
            }
        }

        [Conditional("UNITY_EDITOR")]
        public static void ValidateExists(this Object unityObject, Object componentObject, string nameOf, Action additionalTestCallback = null)
        {
            if(componentObject == null)
            {
                Debug.LogError($"[{unityObject.name}] {nameOf} is not assigned!?", unityObject);
            }
            else
            {
                additionalTestCallback?.Invoke();
            }
        }
    }
}