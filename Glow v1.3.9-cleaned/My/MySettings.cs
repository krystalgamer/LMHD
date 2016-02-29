// Decompiled with JetBrains decompiler
// Type: etews.My.MySettings
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AF0DBFE5-3ABE-4E5A-B7FA-EB4E10235327
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.9-cleaned.exe

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
