namespace VTS
{
    using System;
    using System.Diagnostics;

    public static class _Assert
    {
        [Conditional("VTS_DEBUG")]
        public static void IsTrue(bool testResult, string failureMessage)
        {
            if(testResult is false)
            {
                throw new InvalidOperationException(failureMessage);
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void IsFalse(bool testResult, string failureMessage)
        {
            if(testResult is true)
            {
                throw new InvalidOperationException(failureMessage);
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void IsNull(object reference, string nameOf)
        {
            if(reference.NotNull())
            {
                throw new InvalidOperationException($"{nameOf} not null!?");
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void NotNull(object reference, string nameOf)
        {
            if(reference is null)
            {
                throw new InvalidOperationException($"{nameOf} not null!?");
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void IsPositive(int value, string nameOf)
        {
            if(value <= 0)
            {
                throw new InvalidOperationException($"{nameOf} ({value}) is not positive!?");
            }
        }

        [Conditional("VTS_DEBUG")]
        public static void IsPositive(float value, string nameOf)
        {
            if(value <= 0.0f)
            {
                throw new InvalidOperationException($"{nameOf} ({value}) is not positive!?");
            }
        }
    }
}