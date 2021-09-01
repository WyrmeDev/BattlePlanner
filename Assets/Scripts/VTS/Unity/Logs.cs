namespace VTS.Unity
{
    using System.Diagnostics;
    using UnityEngine;
    using Debug = UnityEngine.Debug;

    public static class _LogExtensions
    {
        [Conditional("VTS_DEBUG")]
        public static void LogMessage(this object reference, string message)
        {
            if(reference is Object unityObject)
            {
                Debug.Log(message, unityObject);
            }
            else
            {
                Debug.Log(message);
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void LogWarning(this object reference, string message)
        {
            if(reference is Object unityObject)
            {
                Debug.LogWarning(message, unityObject);
            }
            else
            {
                Debug.LogWarning(message);
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void LogIfTrue(this object reference, bool testResult, string message)
        {
            if(testResult is false)
            {
                reference.LogWarning(message);
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void LogError(this object reference, string message)
        {
            if(reference is Object unityObject)
            {
                Debug.LogWarning(message, unityObject);
            }
            else
            {
                Debug.LogWarning(message);
            }
        }
    }
}