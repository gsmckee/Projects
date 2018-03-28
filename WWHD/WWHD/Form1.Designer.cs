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
            this.lblVelX = new System.Windows.Forms.Label();
            this.lblVelY = new System.Windows.Forms.Label();
            this.tbVelX = new System.Windows.Forms.TextBox();
            this.tbVelY = new System.Windows.Forms.TextBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.lblU_inputError = new System.Windows.Forms.Label();
            this.btnEnterCoords = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(3, 0);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(75, 23);
            this.btnFire.TabIndex = 0;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(3, 26);
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
            this.cbOrdList.Location = new System.Drawing.Point(736, 23);
            this.cbOrdList.Name = "cbOrdList";
            this.cbOrdList.Size = new System.Drawing.Size(121, 21);
            this.cbOrdList.Sorted = true;
            this.cbOrdList.TabIndex = 2;
            this.cbOrdList.SelectedIndexChanged += new System.EventHandler(this.cbOrdList_SelectedIndexChanged);
            // 
            // lblVelX
            // 
            this.lblVelX.AutoSize = true;
            this.lblVelX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelX.Location = new System.Drawing.Point(444, 6);
            this.lblVelX.Name = "lblVelX";
            this.lblVelX.Size = new System.Drawing.Size(93, 15);
            this.lblVelX.TabIndex = 3;
            this.lblVelX.Text = "X coord velocity";
            // 
            // lblVelY
            // 
            this.lblVelY.AutoSize = true;
            this.lblVelY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelY.Location = new System.Drawing.Point(445, 29);
            this.lblVelY.Name = "lblVelY";
            this.lblVelY.Size = new System.Drawing.Size(92, 15);
            this.lblVelY.TabIndex = 4;
            this.lblVelY.Text = "Y coord velocity";
            // 
            // tbVelX
            // 
            this.tbVelX.Location = new System.Drawing.Point(543, 1);
            this.tbVelX.Name = "tbVelX";
            this.tbVelX.Size = new System.Drawing.Size(100, 20);
            this.tbVelX.TabIndex = 5;
            // 
            // tbVelY
            // 
            this.tbVelY.Location = new System.Drawing.Point(543, 24);
            this.tbVelY.Name = "tbVelY";
            this.tbVelY.Size = new System.Drawing.Size(100, 20);
            this.tbVelY.TabIndex = 6;
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShape.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShape.Location = new System.Drawing.Point(755, 2);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(81, 18);
            this.lblShape.TabIndex = 7;
            this.lblShape.Text = "Select Image";
            // 
            // lblU_inputError
            // 
            this.lblU_inputError.AutoSize = true;
            this.lblU_inputError.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblU_inputError.ForeColor = System.Drawing.Color.Red;
            this.lblU_inputError.Location = new System.Drawing.Point(85, 4);
            this.lblU_inputError.Name = "lblU_inputError";
            this.lblU_inputError.Size = new System.Drawing.Size(132, 18);
            this.lblU_inputError.TabIndex = 8;
            this.lblU_inputError.Text = "Coord entry incomp msg";
            this.lblU_inputError.Visible = false;
            // 
            // btnEnterCoords
            // 
            this.btnEnterCoords.Location = new System.Drawing.Point(649, 12);
            this.btnEnterCoords.Name = "btnEnterCoords";
            this.btnEnterCoords.Size = new System.Drawing.Size(75, 23);
            this.btnEnterCoords.TabIndex = 9;
            this.btnEnterCoords.Text = "Enter Coords";
            this.btnEnterCoords.UseVisualStyleBackColor = true;
            this.btnEnterCoords.Click += new System.EventHandler(this.btnEnterCoords_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(88, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 332);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnterCoords);
            this.Controls.Add(this.lblU_inputError);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.tbVelY);
            this.Controls.Add(this.tbVelX);
            this.Controls.Add(this.lblVelY);
            this.Controls.Add(this.lblVelX);
            this.Controls.Add(this.cbOrdList);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnFire);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbOrdList;
        private System.Windows.Forms.Label lblVelX;
        private System.Windows.Forms.Label lblVelY;
        private System.Windows.Forms.TextBox tbVelX;
        private System.Windows.Forms.TextBox tbVelY;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblU_inputError;
        private System.Windows.Forms.Button btnEnterCoords;
        private System.Windows.Forms.Button btnReset;
    }
}

