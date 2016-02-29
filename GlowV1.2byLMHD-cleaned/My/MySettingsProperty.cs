// Decompiled with JetBrains decompiler
// Type: etews.My.MySettingsProperty
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A705B193-EBED-4A9B-BB58-E6487135B687
// Assembly location: C:\Users\NAMS\Desktop\GlowV1.2byLMHD-cleaned.exe

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
