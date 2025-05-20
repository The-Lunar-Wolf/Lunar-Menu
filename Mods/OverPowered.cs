using UnityEngine;
using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;
using static LunarMenu.Notifications.NotifiLib;
using static LunarMenu.Classes.RigManager;
using static LunarMenu.Classes.CoolDown;

namespace LunarMenu.Mods
{
    internal class OverPowered
    {
        public static void TagGun()
        {
            GameObject pointer = null;
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                    {
                        GorillaTagger.Instance.leftHandTransform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer == null) { return; }
                    GameObject.Destroy(pointer);
                    pointer = null;
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                    {
                        GorillaTagger.Instance.rightHandTransform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer == null) { return; }
                    GameObject.Destroy(pointer);
                    pointer = null;
                }
            }
        }

        public static void TagAll()
        {
            GorillaTagger.Instance.offlineVRRig.enabled = false;
            foreach (VRRig player in GorillaParent.instance.vrrigs)
            {
                GorillaTagger.Instance.rightHandTransform.position = player.transform.position;
            }
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }

        public static async void FreezeGun()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f && await Delay(250))
                    {
                        VRRig Fucker = GunInfo.ray.collider.GetComponentInParent<VRRig>();
                        if (Fucker)
                        {
                            Fucker.enabled = false;
                            RPCProtection();
                        }
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f && await Delay(250))
                    {
                        VRRig Fucker = GunInfo.ray.collider.GetComponentInParent<VRRig>();
                        if (Fucker)
                        {
                            Fucker.enabled = false;
                            RPCProtection();
                        }
                    }
                }
            }
        }

        public static async void FreezeAll()
        {
            foreach (VRRig player in GorillaParent.instance.vrrigs)
            {
                player.enabled = false;
                await Delay(1);
            }
            RPCProtection();
            SendNotification("<color=gray>[</color><color=purple>Output</color><color=gray>]</color> <color=white>Successfully freezed everyone in the room</color>");
        }

        public static async void HidePlayerGun()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f && await Delay(250))
                    {
                        VRRig player1 = GunInfo.ray.collider.GetComponentInParent<VRRig>();
                        if (player1)
                        {
                            player1.enabled = false;
                            player1.transform.position = new Vector3(99999999999f, 999999999999f, 9999999999f);
                            RPCProtection();
                        }
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f && await Delay(250))
                    {
                        VRRig player1 = GunInfo.ray.collider.GetComponentInParent<VRRig>();
                        if (player1)
                        {
                            player1.enabled = false;
                            player1.transform.position = new Vector3(99999999999f, 999999999999f, 9999999999f);
                            RPCProtection();
                        }
                    }
                }
            }
        }
    }
}
