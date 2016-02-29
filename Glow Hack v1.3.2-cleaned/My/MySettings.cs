// Decompiled with JetBrains decompiler
// Type: etews.My.MySettings
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E489A02-D358-4E9A-ADAC-CF37A140F6F1
// Assembly location: C:\Users\NAMS\Desktop\Glow Hack v1.3.2-cleaned.exe

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
