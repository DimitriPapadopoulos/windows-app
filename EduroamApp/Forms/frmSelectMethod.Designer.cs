namespace EduroamApp
{
	partial class frmSelectMethod
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnNewProfile = new System.Windows.Forms.Button();
			this.btnLocalProfile = new System.Windows.Forms.Button();
			this.btnExisting = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// label1
			//
			this.label1.Location = new System.Drawing.Point(55, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(405, 108);
			this.label1.TabIndex = 2;
			this.label1.Text = "Connect to quickly gain access to eduroam.\r\nIf you have previously downloaded a e" +
	"ap-config file from your institution  you can use this instead";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// btnNewProfile
			//
			this.btnNewProfile.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnNewProfile.Location = new System.Drawing.Point(93, 221);
			this.btnNewProfile.Name = "btnNewProfile";
			this.btnNewProfile.Size = new System.Drawing.Size(326, 95);
			this.btnNewProfile.TabIndex = 3;
			this.btnNewProfile.Text = "Connect to eduroam";
			this.btnNewProfile.UseVisualStyleBackColor = false;
			this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
			//
			// btnLocalProfile
			//
			this.btnLocalProfile.BackColor = System.Drawing.Color.White;
			this.btnLocalProfile.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnLocalProfile.Location = new System.Drawing.Point(168, 322);
			this.btnLocalProfile.Name = "btnLocalProfile";
			this.btnLocalProfile.Size = new System.Drawing.Size(169, 40);
			this.btnLocalProfile.TabIndex = 4;
			this.btnLocalProfile.Text = "Use eap-config file";
			this.btnLocalProfile.UseVisualStyleBackColor = false;
			this.btnLocalProfile.Click += new System.EventHandler(this.btnLocalProfile_Click);
			//
			// btnExisting
			//
			this.btnExisting.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExisting.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnExisting.Location = new System.Drawing.Point(93, 120);
			this.btnExisting.Name = "btnExisting";
			this.btnExisting.Size = new System.Drawing.Size(326, 95);
			this.btnExisting.TabIndex = 5;
			this.btnExisting.Text = "Connect with existing profile";
			this.btnExisting.UseVisualStyleBackColor = false;
			this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
			//
			// frmSelectMethod
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(511, 493);
			this.Controls.Add(this.btnExisting);
			this.Controls.Add(this.btnLocalProfile);
			this.Controls.Add(this.btnNewProfile);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmSelectMethod";
			this.Text = "frm2";
			this.Load += new System.EventHandler(this.frmSelectMethod_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnNewProfile;
		private System.Windows.Forms.Button btnLocalProfile;
		private System.Windows.Forms.Button btnExisting;
	}
}