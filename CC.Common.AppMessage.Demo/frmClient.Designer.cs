namespace CC.Common.AppMessage.Demo
{
  partial class frmClient
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
      this.picture = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblStatus = new System.Windows.Forms.Label();
      this.btnToggle = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // picture
      // 
      this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picture.Location = new System.Drawing.Point(0, 38);
      this.picture.Name = "picture";
      this.picture.Size = new System.Drawing.Size(364, 284);
      this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.picture.TabIndex = 0;
      this.picture.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnToggle);
      this.panel1.Controls.Add(this.lblStatus);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(364, 38);
      this.panel1.TabIndex = 1;
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(12, 9);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(35, 13);
      this.lblStatus.TabIndex = 0;
      this.lblStatus.Text = "label1";
      // 
      // btnToggle
      // 
      this.btnToggle.Location = new System.Drawing.Point(277, 9);
      this.btnToggle.Name = "btnToggle";
      this.btnToggle.Size = new System.Drawing.Size(75, 23);
      this.btnToggle.TabIndex = 1;
      this.btnToggle.Text = "Toggle";
      this.btnToggle.UseVisualStyleBackColor = true;
      this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
      // 
      // frmClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(364, 322);
      this.Controls.Add(this.picture);
      this.Controls.Add(this.panel1);
      this.Name = "frmClient";
      this.Text = "Client";
      this.Load += new System.EventHandler(this.frmClient_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox picture;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnToggle;
  }
}