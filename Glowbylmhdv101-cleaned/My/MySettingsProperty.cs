// Decompiled with JetBrains decompiler
// Type: etews.My.MySettingsProperty
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ABB810A-5B1E-43E5-8F91-AF575CE4F3DC
// Assembly location: C:\Users\NAMS\Desktop\Glowbylmhdv101-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace etews.My
{
  [DebuggerNonUserCode]
  [HideModuleName]
  [StandardModule]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
