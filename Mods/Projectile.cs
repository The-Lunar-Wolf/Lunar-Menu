using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;
using static LunarMenu.Classes.CoolDown;
using UnityEngine;

namespace LunarMenu.Mods
{
    internal class Projectile : MonoBehaviour
    {
        public static async void Urine()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    if (await Delay(250))
                    {
                        FireProjectile("SnowballProjectile(Clone)", GorillaTagger.Instance.bodyCollider.transform.position + new Vector3(0f, -0.15f, 0f), GorillaTagger.Instance.bodyCollider.transform.forward, green, 5f);
                    }
                }
            }
        }
    }
}
