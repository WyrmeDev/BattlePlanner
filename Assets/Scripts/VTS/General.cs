namespace VTS
{
    using System;
    using Random = UnityEngine.Random;

    public static class _Constants
    {
        public const int INDEX_NOT_FOUND = -1;
    }

    public static class _Extensions
    {
        public static bool NotNull(this object reference) => !( reference is null );
    }

    public static class _Utilities
    {
        public static void DoNothing() { }

        public static bool RandomBool()
        {
            return Random.value > 0.5f;
        }
    }

    public class UnhandledSwitchCaseException : Exception
    {
        public UnhandledSwitchCaseException(object value) : base(string.Format("Unhandled switch case {0}!?", value)) { }
    }
}