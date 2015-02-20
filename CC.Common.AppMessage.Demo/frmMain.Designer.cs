namespace CC.Common.AppMessage.Demo
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnRedLight = new System.Windows.Forms.Button();
      this.btnGreenLight = new System.Windows.Forms.Button();
      this.btnClient = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnRedLight
      // 
      this.btnRedLight.Location = new System.Drawing.Point(14, 98);
      this.btnRedLight.Name = "btnRedLight";
      this.btnRedLight.Size = new System.Drawing.Size(75, 23);
      this.btnRedLight.TabIndex = 0;
      this.btnRedLight.Text = "Red Light";
      this.btnRedLight.UseVisualStyleBackColor = true;
      this.btnRedLight.Click += new System.EventHandler(this.btnRedLight_Click);
      // 
      // btnGreenLight
      // 
      this.btnGreenLight.Location = new System.Drawing.Point(95, 98);
      this.btnGreenLight.Name = "btnGreenLight";
      this.btnGreenLight.Size = new System.Drawing.Size(75, 23);
      this.btnGreenLight.TabIndex = 1;
      this.btnGreenLight.Text = "Green Light";
      this.btnGreenLight.UseVisualStyleBackColor = true;
      this.btnGreenLight.Click += new System.EventHandler(this.btnGreenLight_Click);
      // 
      // btnClient
      // 
      this.btnClient.Location = new System.Drawing.Point(14, 29);
      this.btnClient.Name = "btnClient";
      this.btnClient.Size = new System.Drawing.Size(156, 23);
      this.btnClient.TabIndex = 2;
      this.btnClient.Text = "Start Client Process";
      this.btnClient.UseVisualStyleBackColor = true;
      this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(255, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Just for the demo, start up another instance of myself";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 82);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(109, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Update the icon color";
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(13, 161);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(259, 92);
      this.label3.TabIndex = 5;
      this.label3.Text = "Now for fun, start up as many clients as you\'d like. Even on another computer (sa" +
    "me subnet). Firewall rules apply.";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnClient);
      this.Controls.Add(this.btnGreenLight);
      this.Controls.Add(this.btnRedLight);
      this.Name = "frmMain";
      this.Text = "App Message Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRedLight;
    private System.Windows.Forms.Button btnGreenLight;
    private System.Windows.Forms.Button btnClient;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

