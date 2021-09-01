namespace VTS.Unity
{
    using UnityEngine;

    public static class _Extensions
    {
        public static void SetEnabled(this Component gameComponent, bool enabled)
        {
            gameComponent.gameObject.SetActive(enabled);
        }
    }
}