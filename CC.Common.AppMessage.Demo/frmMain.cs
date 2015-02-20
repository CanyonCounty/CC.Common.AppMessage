using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CC.Common.AppMessage;

namespace CC.Common.AppMessage.Demo
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void btnClient_Click(object sender, EventArgs e)
    {
      Process.Start(Application.ExecutablePath, "client");
    }

    private void btnRedLight_Click(object sender, EventArgs e)
    {
      Sender.SendMessage("RedLight");
    }

    private void btnGreenLight_Click(object sender, EventArgs e)
    {
      Sender.SendMessage("GreenLight");
    }
  }
}
