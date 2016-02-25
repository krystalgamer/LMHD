// Decompiled with JetBrains decompiler
// Type: etews.My.MySettings
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62847F90-FA1F-4F3D-9A4B-2D336655E55A
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.8-cleaned.exe

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
