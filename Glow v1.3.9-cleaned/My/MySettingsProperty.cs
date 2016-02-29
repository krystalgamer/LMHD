// Decompiled with JetBrains decompiler
// Type: etews.My.MySettingsProperty
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AF0DBFE5-3ABE-4E5A-B7FA-EB4E10235327
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.9-cleaned.exe

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
