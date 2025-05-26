using LunarMenu.Classes;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using static LunarMenu.Classes.CoolDown;
using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;

namespace LunarMenu.Mods
{
    internal class Movement
    {
        public static void PlatForms()
        {

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (platr == null)
                {
                    platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platr.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platr.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    platr.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                    platr.AddComponent<GorillaSurfaceOverride>().overrideIndex = 165;

                    if (platformType == "normal")
                    {
                        ColorChanger colorChanger = platr.AddComponent<ColorChanger>();
                        colorChanger.colorInfo = new ExtGradient
                        {
                            colors = new GradientColorKey[]
                            {
                        new GradientColorKey(currentColorA, 0f),
                        new GradientColorKey(currentColorB, 0.5f),
                        new GradientColorKey(currentColorA, 1f)
                            }
                        };
                        colorChanger.Start();
                    }
                    else if (platformType == "invis")
                    {
                        platr.GetComponent<Renderer>().enabled = false;
                    }
                }
            }
            else
            {
                if (platr != null)
                {
                    GameObject.Destroy(platr);
                    platr = null;
                }
            }

            if (ControllerInputPoller.instance.leftGrab)
            {
                if (platl == null)
                {
                    platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platl.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platl.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    platl.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                    platl.AddComponent<GorillaSurfaceOverride>().overrideIndex = 165;
                    if (platformType == "normal")
                    {
                        ColorChanger colorChanger = platl.AddComponent<ColorChanger>();
                        colorChanger.colorInfo = new ExtGradient
                        {
                            colors = new GradientColorKey[]
                            {
                        new GradientColorKey(currentColorA, 0f),
                        new GradientColorKey(currentColorB, 0.5f),
                        new GradientColorKey(currentColorA, 1f)
                            }
                        };
                        colorChanger.Start();
                    }
                    else if (platformType == "invis")
                    {
                        platl.GetComponent<Renderer>().enabled = false;
                    }
                }
            }
            else
            {
                if (platl != null)
                {
                    GameObject.Destroy(platl);
                    platl = null;
                }
            }
        }


        public static void SpeedBoost()
        {
            player.jumpMultiplier += Speed;
            if (Speed >= 3f)
            {
                player.jumpMultiplier = 3f;
            }
            else
            {
                player.jumpMultiplier += Speed;
            }
        }

        public static void CustomSpeedBoost()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                customSpeed += 0.1f;
            }
            else if (ControllerInputPoller.instance.leftGrab)
            {
                customSpeed -= 0.1f;
            }
            player.jumpMultiplier += customSpeed;
            player.maxJumpSpeed += customSpeed;
            Task.Delay(500);
        }

        public static void LongArms()
        {
            player.transform.localScale = new Vector3(ArmLen, ArmLen, ArmLen);
        }

        public static void CustomLongArms()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                customLongArms += 0.1f;
            }
            else if (ControllerInputPoller.instance.leftGrab)
            {
                customLongArms -= 0.1f;
            }
            player.transform.localScale = new Vector3(customLongArms, customLongArms, customLongArms);
        }

        public static void FixArms()
        {
            player.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        public static void FixSpeed()
        {
            player.jumpMultiplier = 1f;
            player.maxJumpSpeed = 1f;
        }

        public static void Frozone()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (frozoneObject == null)
                {
                    frozoneObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    frozoneObject.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    frozoneObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    frozoneObject.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                    frozoneObject.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
                    if (platformType == "normal")
                    {
                        ColorChanger colorChanger = frozoneObject.AddComponent<ColorChanger>();
                        colorChanger.colorInfo = new ExtGradient
                        {
                            colors = new GradientColorKey[]
                        {
                new GradientColorKey(currentColorA, 0f),
                new GradientColorKey(currentColorB, 0.5f),
                new GradientColorKey(currentColorA, 1f)
                        }
                        };
                        colorChanger.Start();
                    }
                    else if (platformType == "invis")
                    {
                        frozoneObject.GetComponent<Renderer>().material.color = Color.clear;
                    }
                }
                else
                {
                    frozoneObject.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    frozoneObject.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                }
            }
            else
            {
                if (frozoneObject != null)
                {
                    GameObject.Destroy(frozoneObject);
                    frozoneObject = null;
                }
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (frozoneObject2 == null)
                {
                    frozoneObject2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    frozoneObject2.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    frozoneObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    frozoneObject2.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                    frozoneObject2.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
                    if (platformType == "normal")
                    {
                        ColorChanger colorChanger = frozoneObject2.AddComponent<ColorChanger>();
                        colorChanger.colorInfo = new ExtGradient
                        {
                            colors = new GradientColorKey[]
                        {
                new GradientColorKey(currentColorA, 0f),
                new GradientColorKey(currentColorB, 0.5f),
                new GradientColorKey(currentColorA, 1f)
                        }
                        };
                        colorChanger.Start();
                    }
                    else if (platformType == "invis")
                    {
                        frozoneObject2.GetComponent<Renderer>().material.color = Color.clear;
                    }
                }
                else
                {
                    frozoneObject2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    frozoneObject2.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                }
            }
            else
            {
                if (frozoneObject2 != null)
                {
                    GameObject.Destroy(frozoneObject2);
                    frozoneObject2 = null;
                }
            }
        }

        public static void GhostMonkey()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                {
                    if (ghostViewObject == null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        ToggleGhostView();
                    }
                }
                else
                {
                    if (ghostViewObject != null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        ToggleGhostView();
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    if (ghostViewObject == null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        ToggleGhostView();
                    }
                }
                else
                {
                    if (ghostViewObject != null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        ToggleGhostView();
                    }
                }
            }
        }

        public static void InvisMonkey()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerSecondaryButton)
                {
                    if (ghostViewObject == null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = invisPosition;
                        ToggleGhostView();
                    }
                }
                else
                {
                    if (ghostViewObject != null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        ToggleGhostView();
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerSecondaryButton)
                {
                    if (ghostViewObject == null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = invisPosition;
                        ToggleGhostView();
                    }
                }
                else
                {
                    if (ghostViewObject != null)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                        ToggleGhostView();
                    }
                }
            }
        }

        public static async void TeleportGun()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f && await Delay(500))
                    {
                        GorillaTagger.Instance.transform.position = GunInfo.pointer.transform.position;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var GunInfo = CreateGun();
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f && await Delay(500))
                    {
                        GorillaTagger.Instance.transform.position = GunInfo.pointer.transform.position;
                    }
                }
            }
        }

        public static void AntiTagFreeze()
        {
            player.disableMovement = false;
        }

        public static void UncapMaxVelocity()
        {
            player.maxJumpSpeed = 999999999999999999f;
        }

        public static void CarMonkey()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    player.transform.position += (player.bodyCollider.transform.forward * Time.deltaTime) * 15f;
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    player.transform.position += (player.bodyCollider.transform.forward * Time.deltaTime) * 15f;
                }
            }
        }

        public static void Fly()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * flySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * flySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
        }

        public static async void customFly()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    if (await Delay(250))
                    {
                        customFlySpeed -= 0.1f;
                    }
                }
                else if (ControllerInputPoller.instance.leftGrab)
                {
                    if (await Delay(250))
                    {
                        customFlySpeed += 0.1f;
                    }
                }

                if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * customFlySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    if (await Delay(250))
                    {
                        customFlySpeed += 0.1f;
                    }
                }
                else if (ControllerInputPoller.instance.leftGrab)
                {
                    if (await Delay(250))
                    {
                        customFlySpeed -= 0.1f;
                    }
                }

                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * customFlySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
        }

        public static void RigGun()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var info = CreateGun();
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = info.pointer.transform.position;
                    }
                    else
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var info = CreateGun();
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = info.pointer.transform.position;
                    }
                    else
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                    }
                }
            }
        }

        public static void Ascend() // lol 5/10/2025
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.up * Time.deltaTime) * (3f + asendSpeed);
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    asendSpeed += 0.01f;
                }
                else
                {
                    asendSpeed = 1f;
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    player.transform.position += (player.headCollider.transform.up * Time.deltaTime) * (3f + asendSpeed);
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    asendSpeed += 0.1f;
                }
                else
                {
                    asendSpeed = 1f;
                }
            }
        }

        public static void Noclip()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = false;
                    }
                }
                else
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = true;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = false;
                    }
                }
                else
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = true;
                    }
                }
            }
        }

        public static void NoclipFly()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerPrimaryButton)
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = false;
                    }
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * flySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
                else
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = true;
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = false;
                    }
                    player.transform.position += (player.headCollider.transform.forward * Time.deltaTime) * flySpeed;
                    player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
                else
                {
                    foreach (MeshCollider collider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        collider.enabled = true;
                    }
                }
            }
        }

        public static async void FakeLag()
        {
            if (await Delay(fakeLagDelayTime))
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !GorillaTagger.Instance.offlineVRRig.enabled;
            }
        }

        public static void FixRig()
        {
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }

        private static bool isSpectator = false;
        public static async void SpectatorGun()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    var gunInfo = CreateGun();
                    if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f && await Delay(1000))
                    {
                        VRRig a = gunInfo.ray.collider.GetComponent<VRRig>();
                        if (a == GorillaTagger.Instance.offlineVRRig) { return; }
                        isSpectator = !isSpectator;
                        GorillaTagger.Instance.StartCoroutine(Spectate(a, gunInfo.pointer));
                    }
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    var gunInfo = CreateGun();
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f && await Delay(1000))
                    {
                        VRRig a = gunInfo.ray.collider.GetComponent<VRRig>();
                        if (a == GorillaTagger.Instance.offlineVRRig) { return; }
                        isSpectator = !isSpectator;
                        GorillaTagger.Instance.StartCoroutine(Spectate(a, gunInfo.pointer));
                    }
                }
            }
        }

        private static IEnumerator Spectate(VRRig spectPlayer, GameObject pointer)
        {
            if (InvisSpectator)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = invisPosition;
                ToggleGhostView();
            }

            while (isSpectator)
            {
                pointer.transform.position = spectPlayer.transform.position;
                if (pcSpector)
                {
                    GorillaTagger.Instance.thirdPersonCamera.transform.position = spectPlayer.transform.position + ((spectPlayer.transform.up * 2.05f) + (-spectPlayer.transform.forward * 2.05f));
                }
                else
                {
                    GorillaTagger.Instance.transform.position = spectPlayer.transform.position + ((spectPlayer.transform.up * 2.05f) + (-spectPlayer.transform.forward * 2.05f));
                }

                yield return null;
            }

            if (!isSpectator) 
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}