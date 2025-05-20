using LunarMenu.Notifications;
using Photon.Pun;
using UnityEngine;
using static LunarMenu.Menu.Main;
using static LunarMenu.Classes.RigManager;

namespace LunarMenu.Mods
{
    internal class Safty
    {
        public static void AntiReportDisconnect()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                float threshold = 0.35f;

                                if (D1 < threshold || D2 < threshold)
                                {
                                    PhotonNetwork.Disconnect();
                                    RPCProtection();
                                    NotifiLib.SendNotification("<color=grey>[</color><color=red>ANTI-REPORT</color><color=grey>]</color> <color=white>" + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you, you have been disconnected.</color>");
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static void AntiReportJoinRandom()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                float threshold = 0.35f;

                                if (D1 < threshold || D2 < threshold)
                                {
                                    PhotonNetwork.Disconnect();
                                    RPCProtection();
                                    NotifiLib.SendNotification("<color=grey>[</color><color=red>ANTI-REPORT</color><color=grey>]</color> <color=white>" + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you, you are now joining a random lobby.</color>");
                                    PhotonNetwork.JoinRandomRoom();
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static void AntiReportReconnect()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                float threshold = 0.35f;

                                if (D1 < threshold || D2 < threshold)
                                {
                                    PhotonNetwork.Disconnect();
                                    RPCProtection();
                                    NotifiLib.SendNotification("<color=grey>[</color><color=red>ANTI-REPORT</color><color=grey>]</color> <color=white>" + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you, you have been disconnected. Joining back now.</color>");
                                    PhotonNetwork.JoinRoom(lastRoom);
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static void AntiReportAlert()
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform report = line.reportButton.gameObject.transform;
                        foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                        {
                            if (vrrig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float D1 = Vector3.Distance(vrrig.rightHandTransform.position, report.position);
                                float D2 = Vector3.Distance(vrrig.leftHandTransform.position, report.position);

                                float threshold = 0.35f;

                                if (D1 < threshold || D2 < threshold)
                                {
                                    NotifiLib.SendNotification("<color=grey>[</color><color=red>ANTI-REPORT</color><color=grey>]</color> <color=white>" + GetPlayerFromVRRig(vrrig).NickName + " attempted to report you.</color>");
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static void NoFingerMovement()
        {
            ControllerInputPoller.instance.leftControllerGripFloat = 0f;
            ControllerInputPoller.instance.rightControllerGripFloat = 0f;
            ControllerInputPoller.instance.leftControllerIndexFloat = 0f;
            ControllerInputPoller.instance.rightControllerIndexFloat = 0f;
            ControllerInputPoller.instance.leftControllerPrimaryButton = false;
            ControllerInputPoller.instance.leftControllerSecondaryButton = false;
            ControllerInputPoller.instance.rightControllerPrimaryButton = false;
            ControllerInputPoller.instance.rightControllerSecondaryButton = false;
        }

        public static void EnableAntiCheatReport()
        {
            antiCheat = true;
        }

        public static void DisableAntiCheatReport() 
        { 
            antiCheat = false; 
        }
    }
}
