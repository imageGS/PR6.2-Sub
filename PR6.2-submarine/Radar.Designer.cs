namespace PR6._2_submarine
{
    partial class Radar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.triggerRadarOnOff = new System.Windows.Forms.PictureBox();
            this.btnBacktoBridge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerRadarOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBacktoBridge)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PR6._2_submarine.Properties.Resources.radar_gif_12;
            this.pictureBox1.Location = new System.Drawing.Point(273, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // triggerRadarOnOff
            // 
            this.triggerRadarOnOff.BackColor = System.Drawing.Color.Transparent;
            this.triggerRadarOnOff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerRadarOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerRadarOnOff.Location = new System.Drawing.Point(267, 391);
            this.triggerRadarOnOff.Name = "triggerRadarOnOff";
            this.triggerRadarOnOff.Size = new System.Drawing.Size(41, 38);
            this.triggerRadarOnOff.TabIndex = 1;
            this.triggerRadarOnOff.TabStop = false;
            this.triggerRadarOnOff.Click += new System.EventHandler(this.triggerRadarOnOff_Click);
            // 
            // btnBacktoBridge
            // 
            this.btnBacktoBridge.BackColor = System.Drawing.Color.White;
            this.btnBacktoBridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBacktoBridge.Image = global::PR6._2_submarine.Properties.Resources.Back_Button_Transparent;
            this.btnBacktoBridge.Location = new System.Drawing.Point(-3, 497);
            this.btnBacktoBridge.Name = "btnBacktoBridge";
            this.btnBacktoBridge.Size = new System.Drawing.Size(136, 48);
            this.btnBacktoBridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBacktoBridge.TabIndex = 2;
            this.btnBacktoBridge.TabStop = false;
            this.btnBacktoBridge.Click += new System.EventHandler(this.btnBacktoBridge_Click);
            // 
            // Radar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2_submarine.Properties.Resources.maxresdefault1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 544);
            this.ControlBox = false;
            this.Controls.Add(this.btnBacktoBridge);
            this.Controls.Add(this.triggerRadarOnOff);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Radar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Радар";
            this.Load += new System.EventHandler(this.Radar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerRadarOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBacktoBridge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox triggerRadarOnOff;
        private System.Windows.Forms.PictureBox btnBacktoBridge;
    }
}