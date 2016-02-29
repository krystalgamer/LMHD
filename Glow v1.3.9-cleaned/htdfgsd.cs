// Decompiled with JetBrains decompiler
// Type: etews.htdfgsd
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AF0DBFE5-3ABE-4E5A-B7FA-EB4E10235327
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.9-cleaned.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;

namespace etews
{
  [StandardModule]
  internal sealed class htdfgsd
  {
    public static uint PROCESS_ALL_ACCESS = 2035711;
    private static string string_0;
    private static string string_1;
    private static string string_2;
    private static string string_3;
    private static string string_4;
    private static string string_5;
    private static string string_6;
    private static string string_7;
    private static string string_8;
    private static string string_9;
    private static string string_10;
    private static string string_11;
    private static string string_12;
    private static string string_13;
    private static string string_14;
    private static string string_15;
    private static string string_16;
    private static string string_17;
    private static string string_18;
    private static string string_19;
    private static string string_20;
    private static string string_21;
    private static string string_22;
    private static string string_23;
    private static string string_24;
    private static string string_25;
    private static string string_26;
    private static string string_27;
    private static string string_28;
    private static string string_29;
    private static string string_30;
    private static string string_31;
    private static string string_32;
    private static string string_33;
    private static string string_34;
    private static string string_35;
    private static string string_36;
    private static string string_37;
    private static string string_38;
    private static string string_39;
    private static string string_40;
    private static string string_41;
    private static string string_42;
    private static string string_43;
    private static string string_44;
    private static string string_45;
    private static string string_46;
    private static string string_47;
    private static string string_48;
    private static string string_49;
    private static string string_50;
    private static string string_51;
    private static string string_52;
    private static string string_53;
    private static string string_54;
    private static string string_55;
    private static string string_56;
    private static string string_57;
    private static string string_58;
    private static string string_59;
    private static string string_60;
    private static string string_61;
    private static string string_62;
    private static string string_63;
    private static string string_64;
    private static string string_65;
    private static string string_66;
    private static string string_67;
    private static string string_68;
    private static string string_69;
    private static string string_70;
    private static string string_71;
    private static string string_72;
    private static string string_73;
    private static string string_74;
    private static string string_75;
    private static string string_76;
    private static string string_77;
    private static string string_78;
    private static string string_79;
    private static string string_80;
    private static string string_81;
    private static string string_82;
    private static string string_83;
    private static string string_84;
    private static string string_85;
    private static string string_86;
    private static string string_87;
    private static string string_88;
    private static string string_89;
    private static string string_90;
    private static string string_91;
    private static string string_92;
    private static string string_93;
    private static string string_94;
    private static string string_95;
    private static string string_96;
    private static string string_97;

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int iSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int iSize, ref int lpNumberOfBr);

    public static byte[] Read(int adr, int l)
    {
      byte[] numArray = new byte[checked (l - 1 + 1)];
      int hProcess = (int) Module1.csgoHandle;
      int lpBaseAddress = adr;
      byte[] lpBuffer = numArray;
      int length = numArray.Length;
      int num = 1;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      int& lpNumberOfBytesRead = @num;
      htdfgsd.ReadProcessMemory(hProcess, lpBaseAddress, lpBuffer, length, lpNumberOfBytesRead);
      return numArray;
    }

    public static object ReadInt(int adr, int l)
    {
      return (object) BitConverter.ToInt32(htdfgsd.Read(adr, l), 0);
    }

    public static object ReadBool(int adr, int l)
    {
      return (object) (bool) (BitConverter.ToBoolean(htdfgsd.Read(adr, l), 0) ? 1 : 0);
    }

    public static object ReadSingle(int adr, int l)
    {
      return (object) BitConverter.ToSingle(htdfgsd.Read(adr, l), 0);
    }

    public static object ReadLong(int adr, int l)
    {
      return htdfgsd.ToLong(htdfgsd.Read(adr, l));
    }

    public static void Write(int adr, byte[] Bytes)
    {
      int hProcess = (int) Module1.csgoHandle;
      int lpBaseAddress = adr;
      byte[] lpBuffer = Bytes;
      int length = Bytes.Length;
      int num = 1;
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      int& lpNumberOfBr = @num;
      htdfgsd.WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, length, lpNumberOfBr);
    }

    public static void WriteBool(int adr, int l, bool val)
    {
      byte[] numArray = new byte[checked (l - 1 + 1)];
      byte[] bytes = BitConverter.GetBytes(val);
      htdfgsd.Write(adr, bytes);
    }

    public static void WriteSingle(int adr, int l, float val)
    {
      byte[] numArray = new byte[checked (l - 1 + 1)];
      byte[] bytes = BitConverter.GetBytes(val);
      htdfgsd.Write(adr, bytes);
    }

    public static void WriteInt(int adr, int l, int val)
    {
      byte[] numArray = new byte[checked (l - 1 + 1)];
      byte[] bytes = BitConverter.GetBytes(val);
      htdfgsd.Write(adr, bytes);
    }

    public static object ToLong(byte[] byBytes)
    {
      int num = checked (Information.UBound((Array) byBytes, 1) - Information.LBound((Array) byBytes, 1));
      int index = 0;
      long Expression;
      while (index <= num)
      {
        if (index == 0 & ((int) byBytes[0] & 128) > 0)
          Expression |= checked ((long) Math.Round(-unchecked ((double) byBytes[index] * Math.Pow(2.0, (double) checked (8 * Strings.Len(Expression) - 1 - index)))));
        else
          Expression |= checked ((long) Math.Round(unchecked ((double) byBytes[index] * Math.Pow(2.0, (double) checked (8 * Strings.Len(Expression) - 1 - index)))));
        checked { ++index; }
      }
      return (object) Expression;
    }
  }
}
