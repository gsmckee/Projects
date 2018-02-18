namespace WWHD
{
    partial class Form1
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
            this.btnFire = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbOrdList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(211, 0);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(0, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Sim";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbOrdList
            // 
            this.cbOrdList.FormattingEnabled = true;
            this.cbOrdList.Items.AddRange(new object[] {
            "Bullet",
            "Circular",
            "Grenade",
            "Missile",
            "Mortar",
            "Rocket"});
            this.cbOrdList.Location = new System.Drawing.Point(84, 0);
            this.cbOrdList.Name = "cbOrdList";
            this.cbOrdList.Size = new System.Drawing.Size(121, 21);
            this.cbOrdList.Sorted = true;
            this.cbOrdList.TabIndex = 2;
            //this.cbOrdList.SelectedIndexChanged += new System.EventHandler(this.cbOrdList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbOrdList);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnFire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbOrdList;
    }
}

