using UnityEngine;
using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;

namespace LunarMenu.Mods
{
    internal class Fun
    {
        public static void GrabDoug()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GameObject.Find("Floating Bug Holdable").transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
            }
            else if (ControllerInputPoller.instance.leftGrab)
            {
                GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.leftHandTransform.position;
                GameObject.Find("Floating Bug Holdable").transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
            }
        }

        public static void GrabMat()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GameObject.Find("Cave Bat Holdable").transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
            }
            else if (ControllerInputPoller.instance.leftGrab)
            {
                GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.leftHandTransform.position;
                GameObject.Find("Cave Bat Holdable").transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
            }
        }

        public static void RideDoug()
        {
            GorillaTagger.Instance.transform.position = GameObject.Find("Floating Bug Holdable").transform.position;
            GorillaTagger.Instance.transform.rotation = GameObject.Find("Floating Bug Holdable").transform.rotation;
        }

        public static void RideMat()
        {
            GorillaTagger.Instance.transform.position = GameObject.Find("Cave Bat Holdable").transform.position;
            GorillaTagger.Instance.transform.rotation = GameObject.Find("Cave Bat Holdable").transform.rotation;
        }

        public static void DougGun()
        {
            GameObject pointer = null;
            RaycastHit ray;
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    ray = GunInfo.ray;
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                    {
                        GameObject.Find("Floating Bug Holdable").transform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer != null)
                    {
                        GameObject.Destroy(pointer);
                        pointer = null;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    ray = GunInfo.ray;
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                    {
                        GameObject.Find("Floating Bug Holdable").transform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer != null)
                    {
                        GameObject.Destroy(pointer);
                        pointer = null;
                    }
                }
            }
        }

        public static void MatGun()
        {
            GameObject pointer = null;
            RaycastHit ray;
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    ray = GunInfo.ray;
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                    {
                        GameObject.Find("Cave Bat Holdable").transform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer != null)
                    {
                        GameObject.Destroy(pointer);
                        pointer = null;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    pointer = GunInfo.pointer;
                    ray = GunInfo.ray;
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                    {
                        GameObject.Find("Cave Bat Holdable").transform.position = pointer.transform.position;
                    }
                }
                else
                {
                    if (pointer != null)
                    {
                        GameObject.Destroy(pointer);
                        pointer = null;
                    }
                }
            }
        }
    }
}
