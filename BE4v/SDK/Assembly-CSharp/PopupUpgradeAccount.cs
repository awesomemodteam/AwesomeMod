﻿using System;
using System.Linq;
using IL2CPP_Core.Objects;

public class PopupUpgradeAccount : VRCUiPopup
{
    public PopupUpgradeAccount(IntPtr ptr) : base(ptr) { }

	public static new IL2Class Instance_Class = IL2CPP.AssemblyList["Assembly-CSharp"].GetClasses().FirstOrDefault(x => x.GetMethod("CopyToken") != null);
}