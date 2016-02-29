// Decompiled with JetBrains decompiler
// Type: etews.My.MySettingsProperty
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E489A02-D358-4E9A-ADAC-CF37A140F6F1
// Assembly location: C:\Users\NAMS\Desktop\Glow Hack v1.3.2-cleaned.exe

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
