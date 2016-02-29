// Decompiled with JetBrains decompiler
// Type: etews.Module1
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E489A02-D358-4E9A-ADAC-CF37A140F6F1
// Assembly location: C:\Users\NAMS\Desktop\Glow Hack v1.3.2-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace etews
{
  [StandardModule]
  internal sealed class Module1
  {
    private static Thread thread_glow = new Thread(new ThreadStart(Module1.Glow));
    public static Module1.GlowStruct GlowEnemy = new Module1.GlowStruct()
    {
      r = (float) rgrdy.glow_enemy_r / (float) byte.MaxValue,
      g = (float) rgrdy.glow_enemy_g / (float) byte.MaxValue,
      b = (float) rgrdy.glow_enemy_b / (float) byte.MaxValue,
      a = (float) rgrdy.glow_alpha / (float) byte.MaxValue,
      rwo2 = false,
      rwo = true,
      rwuo = false
    };
    public static Module1.GlowStruct GlowTeam = new Module1.GlowStruct()
    {
      r = (float) rgrdy.glow_team_r / (float) byte.MaxValue,
      g = (float) rgrdy.glow_team_g / (float) byte.MaxValue,
      b = (float) rgrdy.glow_team_b / (float) byte.MaxValue,
      a = (float) rgrdy.glow_alpha / (float) byte.MaxValue,
      rwo2 = false,
      rwo = true,
      rwuo = false
    };
    public static int bClient;
    public static int bEngine;
    public static IntPtr csgoHandle;
    public static Process csgoProcess;

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long OpenProcess(uint dwDesiredAcess, bool bInheritHandle, int dwProcessId);

    [STAThread]
    public static void Main()
    {
      Console.Title = "GLOW BY LMHD v1.3.2";
      try
      {
        Module1.csgoProcess = Process.GetProcessesByName("csgo")[0];
        Module1.csgoHandle = (IntPtr) Module1.OpenProcess(htdfgsd.PROCESS_ALL_ACCESS, false, Module1.csgoProcess.Id);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Install .Net 3.5 or higher Or Start CSGO", MsgBoxStyle.OkOnly, (object) "ERROR");
        Environment.Exit(0);
        ProjectData.ClearProjectError();
      }
      try
      {
        foreach (ProcessModule processModule in (ReadOnlyCollectionBase) Module1.csgoProcess.Modules)
        {
          if (Operators.CompareString(processModule.ModuleName, "engine.dll", false) == 0)
            Module1.bEngine = (int) processModule.BaseAddress;
          if (Operators.CompareString(processModule.ModuleName, "client.dll", false) == 0)
            Module1.bClient = (int) processModule.BaseAddress;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      Module1.thread_glow.Start();
      Application.Run((Form) new Testm());
      Console.ReadLine();
    }

    private static void DrawGlow(int pGlowIn, Module1.GlowStruct col)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(checked (Module1.bClient + Offsets.oGlowObject), 4));
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 4))), 4, col.r);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 8))), 4, col.g);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 12))), 4, col.b);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 16))), 4, col.a);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 36))), 1, col.rwo);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 38))), 1, col.rwo2);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) checked (pGlowIn * 56 + 37))), 1, col.rwuo);
    }

    public static void Glow()
    {
      while (true)
      {
        int num = 1;
        do
        {
          object objectValue1 = RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(checked (Module1.bClient + Offsets.oLocalPlayer), 4));
          object objectValue2 = RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(checked (Module1.bClient + Offsets.oEntityList + (num - 1) * 16), 4));
          if (Conversions.ToBoolean(Operators.NotObject(RuntimeHelpers.GetObjectValue(htdfgsd.ReadBool(Conversions.ToInteger(Operators.AddObject(objectValue2, (object) Offsets.oDormant)), 4)))))
            goto label_2;
label_1:
          checked { ++num; }
          continue;
label_2:
          object objectValue3 = RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(Conversions.ToInteger(Operators.AddObject(objectValue2, (object) Offsets.oGlowIndex)), 4));
          if (Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(Conversions.ToInteger(Operators.AddObject(objectValue2, (object) Offsets.oTeam)), 4)), RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(Conversions.ToInteger(Operators.AddObject(objectValue1, (object) Offsets.oTeam)), 4)), false))
          {
            Module1.DrawGlow(Conversions.ToInteger(objectValue3), Module1.GlowTeam);
            goto label_1;
          }
          else
          {
            Module1.DrawGlow(Conversions.ToInteger(objectValue3), Module1.GlowEnemy);
            goto label_1;
          }
        }
        while (num <= 64);
        Thread.Sleep(17);
      }
    }

    public struct GlowStruct
    {
      public float r;
      public float g;
      public float b;
      public float a;
      public bool rwo;
      public bool rwo2;
      public bool rwuo;
    }
  }
}
