// Decompiled with JetBrains decompiler
// Type: etews.My.Resources.Resources
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A705B193-EBED-4A9B-BB58-E6487135B687
// Assembly location: C:\Users\NAMS\Desktop\GlowV1.2byLMHD-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace etews.My.Resources
{
  [HideModuleName]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [StandardModule]
  [CompilerGenerated]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Resources.resourceMan, (object) null))
          Resources.resourceMan = new ResourceManager("etews.Resources", typeof (Resources).Assembly);
        return Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Resources.resourceCulture;
      }
      set
      {
        Resources.resourceCulture = value;
      }
    }
  }
}
