// Decompiled with JetBrains decompiler
// Type: etews.Testm
// Assembly: etews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62847F90-FA1F-4F3D-9A4B-2D336655E55A
// Assembly location: C:\Users\NAMS\Desktop\Glow v1.3.8-cleaned.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace etews
{
  [DesignerGenerated]
  public class Testm : Form
  {
    private IContainer components;

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1 = this._Button1;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._Button1 = value;
        Button button2 = this._Button1;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button1 = this._Button2;
        if (button1 != null)
          button1.Click -= eventHandler;
        this._Button2 = value;
        Button button2 = this._Button2;
        if (button2 == null)
          return;
        button2.Click += eventHandler;
      }
    }

    public Testm()
    {
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if ((!disposing ? 0 : (this.components != null ? 1 : 0)) == 0)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.Button1 = new Button();
      this.Button2 = new Button();
      this.SuspendLayout();
      this.Button1.Location = new Point(12, 12);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(210, 23);
      this.Button1.TabIndex = 0;
      this.Button1.Text = "Glow Chams";
      this.Button1.UseVisualStyleBackColor = true;
      this.Button2.FlatAppearance.BorderColor = Color.White;
      this.Button2.Location = new Point(12, 41);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(210, 23);
      this.Button2.TabIndex = 1;
      this.Button2.Text = "Glow Normal";
      this.Button2.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.ClientSize = new Size(234, 75);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Button1);
      this.Name = "Testm";
      this.Text = "Glow v1.3.8";
      this.ResumeLayout(false);
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      Module1.GlowEnemy.rwo2 = false;
      Module1.GlowTeam.rwo2 = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Module1.GlowEnemy.rwo2 = true;
      Module1.GlowTeam.rwo2 = true;
    }
  }
}
