

namespace LunarMenu.Mods
{
    internal class Admin
    {
        public static void GetPositionOfPlayer()
        {
            UnityEngine.Debug.Log(GorillaTagger.Instance.offlineVRRig.transform.position);
        }

        public static void GetPositionOfPlayerHand()
        {
            UnityEngine.Debug.Log(GorillaTagger.Instance.rightHandTransform.position);
        }
    }
}
