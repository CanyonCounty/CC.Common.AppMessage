using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CC.Common.AppMessage;

namespace CC.Common.AppMessage.Demo
{
  public partial class frmClient : Form
  {
    private enum Light
    {
      None,
      Red,
      Green
    }

    private Light _light = Light.None;

    public frmClient()
    {
      InitializeComponent();
    }

    private void frmClient_Load(object sender, EventArgs e)
    {
      // Create a new receiver object and use the ReceivedMessage delegate
      new Receiver(ReceivedMessage);
    }
    
    /// <summary>
    /// This method gets called each time a message is received
    /// </summary>
    /// <param name="sender">The object that sent the message</param>
    /// <param name="message">The message sent, this could be a JSON payload</param>
    private void ReceivedMessage(object sender, string message)
    {
      // This demo just shows that Received Message can be setup as a router or messages
      if (message.Equals("RedLight"))
      {
        RedLight(message);
      }
      else if (message.Equals("GreenLight"))
      {
        GreenLight(message);
      }
    }

    private void SetStatus(string status)
    {
      lblStatus.Text = status;
    }

    private void RedLight(string message)
    {
      if (this.InvokeRequired)
        Invoke((Action)delegate {
          picture.Image = Properties.Resources._232px_Red_Light_Icon_svg;
          _light = Light.Red;
          SetStatus(message); 
        });
      else
        SetStatus(message);
    }

    private void GreenLight(string message)
    {
      if (this.InvokeRequired)
        Invoke((Action)delegate {
          picture.Image = Properties.Resources._232px_Green_Light_Icon_svg;
          _light = Light.Green;
          SetStatus(message); 
        });
      else
        SetStatus(message);
    }

    private void btnToggle_Click(object sender, EventArgs e)
    {
      // I can even send a message to myself
      if (_light == Light.Green)
        Sender.SendMessage("RedLight");
      else if (_light == Light.Red)
        Sender.SendMessage("GreenLight");
    }

  }
}
