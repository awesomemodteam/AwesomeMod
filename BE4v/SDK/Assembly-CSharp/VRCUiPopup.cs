﻿using System;
using System.Linq;
using IL2CPP_Core.Objects;

public class VRCUiPopup : VRCUiPage
{
    public VRCUiPopup(IntPtr ptr) : base(ptr) { }

    public static new IL2Class Instance_Class = PopupReport.Instance_Class.BaseType;
}