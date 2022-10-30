using System;
using IL2CPP_Core.Objects;
using IL2Photon.Realtime;
using IL2ExitGames.Client.Photon;
using BE4v.Mods;
using BE4v.MenuEdit;
using BE4v.Patch.Core;
using BE4v.SDK;
using UnityEngine;

namespace BE4v.Patch.List
{
    public class Serilize : IPatch
    {
        public delegate bool _OpRaiseEvent(IntPtr instance, byte operationCode, IntPtr operationParameters, IntPtr raiseEventOptions, SendOptions sendOptions, IntPtr method);
        public static void Toggle()
        {
            Status.isSerilize = !Status.isSerilize;
            CustomQuickMenu.Menus.MainMenu.Serilize.Refresh();
        }

        public void Start()
        {
            IL2Method method = IL2Photon.Realtime.LoadBalancingClient.Instance_Class.GetMethod("OpRaiseEvent");
            if (method == null)
                throw new NullReferenceException();


            patch = new IL2Patch(method, (_OpRaiseEvent)OpRaiseEvent);
            __OpRaiseEvent = patch.CreateDelegate<_OpRaiseEvent>();
            patch.Enabled = false;
        }


        public static bool OpRaiseEvent(IntPtr instance, byte operationCode, IntPtr operationParameters, IntPtr raiseEventOptions, SendOptions sendOptions, IntPtr method)
        {
            if (Mods.Min.ClientConsole.isLog)
            {
                byte[] array = null;
                if (operationParameters != IntPtr.Zero)
                {
                    array = new IL2Array<byte>(operationParameters).GetAsByteArray();
                }
                $"Event Code: {operationCode} by len: {(array?.Length??-1)} |".RedPrefix("Logger");
            }
            if (Status.isSerilize)
            {
                if (operationCode != 1
                && operationCode != 6
                && operationCode != EventCode.Join
                && operationCode != EventCode.Leave
                )
                {
                    return true;
                }
            }
            /*
            if (Mod_Console.crashToggle)
            {
                if (operationCode == 6)
                {
                    IL2Array<byte> array = new IL2Array<byte>(operationParameters);
                    int len = array.Length;
                    int ifCount = 0;
                    short sh = 0;
                    for (int i = len - 1; i <= 0; i--)
                    {
                        if (array[i] == 4)
                        {
                            if (i + 5 < len)
                            {
                                // 80, 108, 97, 121
                                if (
                                    array[i + 2] == 80
                                && array[i + 3] == 108
                                && array[i + 4] == 97
                                && array[i + 5] == 121
                                )
                                {
                                    byte[] bytes = new byte[2];
                                    sh = 80;
                                    bytes = BitConverter.GetBytes(sh);

                                    array[i] = bytes[0];
                                    array[i + 1] = bytes[1];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            */
            try
            {
                return __OpRaiseEvent(instance, operationCode, operationParameters, raiseEventOptions, sendOptions, method);
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static IL2Patch patch;

        public static _OpRaiseEvent __OpRaiseEvent;
    }
}
