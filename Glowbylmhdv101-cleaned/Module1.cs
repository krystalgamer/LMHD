// Decompiled with JetBrains decompiler
// Type: etews.Module1
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7ABB810A-5B1E-43E5-8F91-AF575CE4F3DC
// Assembly location: C:\Users\NAMS\Desktop\Glowbylmhdv101-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace etews
{
  [StandardModule]
  internal sealed class Module1
  {
    private static Thread thread_glow = new Thread(new ThreadStart(Module1.Glow));
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
      Console.Title = "GLOW BY LMHD v1.0.1";
      try
      {
        Module1.csgoProcess = Process.GetProcessesByName("csgo")[0];
        Module1.csgoHandle = (IntPtr) Module1.OpenProcess(htdfgsd.PROCESS_ALL_ACCESS, false, Module1.csgoProcess.Id);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "RUN CSGO", MsgBoxStyle.OkOnly, (object) "ERROR");
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
      Console.ReadLine();
    }

    private static void DrawGlow(int pGlowIn, Module1.GlowStruct col)
    {
      object objectValue = RuntimeHelpers.GetObjectValue(htdfgsd.ReadInt(checked (Module1.bClient + Offsets.oGlowObject), 4));
      // ISSUE: variable of a boxed type
      __Boxed<int> local1 = (ValueType) checked (pGlowIn * 56 + 4);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local1)), 4, col.r);
      // ISSUE: variable of a boxed type
      __Boxed<int> local2 = (ValueType) checked (pGlowIn * 56 + 8);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local2)), 4, col.g);
      // ISSUE: variable of a boxed type
      __Boxed<int> local3 = (ValueType) checked (pGlowIn * 56 + 12);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local3)), 4, col.b);
      // ISSUE: variable of a boxed type
      __Boxed<int> local4 = (ValueType) checked (pGlowIn * 56 + 16);
      htdfgsd.WriteSingle(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local4)), 4, col.a);
      // ISSUE: variable of a boxed type
      __Boxed<int> local5 = (ValueType) checked (pGlowIn * 56 + 36);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local5)), 1, col.rwo);
      // ISSUE: variable of a boxed type
      __Boxed<int> local6 = (ValueType) checked (pGlowIn * 56 + 38);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local6)), 1, col.rwo);
      // ISSUE: variable of a boxed type
      __Boxed<int> local7 = (ValueType) checked (pGlowIn * 56 + 37);
      htdfgsd.WriteBool(Conversions.ToInteger(Operators.AddObject(objectValue, (object) local7)), 1, col.rwuo);
    }

    public static void Glow()
    {
      while (true)
      {
        Module1.GlowStruct col1 = new Module1.GlowStruct()
        {
          r = (float) rgrdy.glow_enemy_r / (float) byte.MaxValue,
          g = (float) rgrdy.glow_enemy_g / (float) byte.MaxValue,
          b = (float) rgrdy.glow_enemy_b / (float) byte.MaxValue,
          a = (float) rgrdy.glow_alpha / (float) byte.MaxValue,
          rwo = true,
          rwuo = false
        };
        Module1.GlowStruct col2 = new Module1.GlowStruct()
        {
          r = (float) rgrdy.glow_team_r / (float) byte.MaxValue,
          g = (float) rgrdy.glow_team_g / (float) byte.MaxValue,
          b = (float) rgrdy.glow_team_b / (float) byte.MaxValue,
          a = (float) rgrdy.glow_alpha / (float) byte.MaxValue,
          rwo = true,
          rwuo = false
        };
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
            Module1.DrawGlow(Conversions.ToInteger(objectValue3), col2);
            goto label_1;
          }
          else
          {
            Module1.DrawGlow(Conversions.ToInteger(objectValue3), col1);
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
      public bool rwuo;
    }
  }
}
