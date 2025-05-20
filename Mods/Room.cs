using Photon.Pun;
using UnityEngine;
using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;
using static LunarMenu.Notifications.NotifiLib;

namespace LunarMenu.Mods
{
    internal class Room
    {
        public static void Disconnect()
        {
            PhotonNetwork.Disconnect();
        }

        public static void Reconnect()
        {
            if (isInRoom)
            {
                Disconnect();
                PhotonNetwork.JoinRoom(lastRoom);
            }
            else
            {
                PhotonNetwork.JoinRoom(lastRoom);
            }
        }

        public static void QuitGame()
        {
            Application.Quit();
        }

        public static void JoinRandom()
        {
            if (isInRoom)
            {
                Disconnect();
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                PhotonNetwork.JoinRandomRoom();
            }
        }

        public static void DisconnectOnGrip()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    Disconnect();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    Disconnect();
                }
            }
        }

        public static void ReconnectOnGrip()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    Reconnect();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    Reconnect();
                }
            }
        }

        public static void QuitOnGrip()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    QuitGame();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    QuitGame();
                }
            }
        }

        public static void JoinRandomOnGrip()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    JoinRandom();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    JoinRandom();
                }
            }
        }

        public static void DisconnectOnTrigger()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                {
                    Disconnect();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    Disconnect();
                }
            }
        }

        public static void ReconnectOnTrigger()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                {
                    Reconnect();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    Reconnect();
                }
            }
        }

        public static void JoinRandomOnTrigger()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                {
                    JoinRandom();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    JoinRandom();
                }
            }
        }

        public static void QuitGameOnTrigger()
        {
            if (rightHanded)
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0f)
                {
                    QuitGame();
                }
            }
            else
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    QuitGame();
                }
            }
        }

        public static void CheckMaster()
        {
            if (PhotonNetwork.MasterClient == PhotonNetwork.LocalPlayer)
            {
                SendNotification("<color=gray>[</color><color=purple>Master</color><color=gray>]</color> <color=white>You are Master.</color>");
            }
            else
            {
                SendNotification("<color=gray>[</color><color=purple>Master</color><color=gray>]</color> <color=white>You are not Master.</color>");
            }
        }

        public static void SetMaster()
        {
            PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            ClearAllNotifications();
            SendNotification("<color=gray>[</color><color=purple>Output</color><color=gray>]</color> <color=white>Successfully made you Master Client.</color>");
            RPCProtection();
        }

        public static void EnableClearNotiOnDisconnect()
        {
            notiOndis = true;
        }

        public static void DisableClearNotiOnDisconnect()
        {
            notiOndis = false;
        }
    }
}
