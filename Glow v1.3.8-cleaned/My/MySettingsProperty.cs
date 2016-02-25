// Decompiled with JetBrains decompiler
// Type: etews.My.MySettingsProperty
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62847F90-FA1F-4F3D-9A4B-2D336655E55A
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.8-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace etews.My
{
  [StandardModule]
  [DebuggerNonUserCode]
  [HideModuleName]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings @default = MySettings.Default;
        return @default;
      }
    }
  }
}
