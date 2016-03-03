// Decompiled with JetBrains decompiler
// Type: etews.My.MySettings
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1D534CED-371A-4D8D-BBBD-29C55B6B70CC
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.4-cleaned.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace etews.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        MySettings mySettings = MySettings.defaultInstance;
        return mySettings;
      }
    }
  }
}
