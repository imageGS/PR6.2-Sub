namespace PR6._2_submarine
{
    partial class Room
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
            this.components = new System.ComponentModel.Container();
            this.triggerShelf = new System.Windows.Forms.PictureBox();
            this.triggerPillow = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBacktoBridge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.triggerShelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerPillow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBacktoBridge)).BeginInit();
            this.SuspendLayout();
            // 
            // triggerShelf
            // 
            this.triggerShelf.BackColor = System.Drawing.Color.Transparent;
            this.triggerShelf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerShelf.Location = new System.Drawing.Point(142, 234);
            this.triggerShelf.Name = "triggerShelf";
            this.triggerShelf.Size = new System.Drawing.Size(191, 216);
            this.triggerShelf.TabIndex = 0;
            this.triggerShelf.TabStop = false;
            this.triggerShelf.Click += new System.EventHandler(this.triggerShelf_Click);
            this.triggerShelf.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // triggerPillow
            // 
            this.triggerPillow.BackColor = System.Drawing.Color.Transparent;
            this.triggerPillow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.triggerPillow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triggerPillow.Location = new System.Drawing.Point(508, 134);
            this.triggerPillow.Name = "triggerPillow";
            this.triggerPillow.Size = new System.Drawing.Size(155, 114);
            this.triggerPillow.TabIndex = 0;
            this.triggerPillow.TabStop = false;
            this.triggerPillow.Click += new System.EventHandler(this.triggerPillow_Click);
            this.triggerPillow.MouseEnter += new System.EventHandler(this.triggerPillow_MouseEnter);
            // 
            // btnBacktoBridge
            // 
            this.btnBacktoBridge.BackColor = System.Drawing.Color.White;
            this.btnBacktoBridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBacktoBridge.Image = global::PR6._2_submarine.Properties.Resources.Back_Button_Transparent;
            this.btnBacktoBridge.Location = new System.Drawing.Point(0, -1);
            this.btnBacktoBridge.Name = "btnBacktoBridge";
            this.btnBacktoBridge.Size = new System.Drawing.Size(136, 48);
            this.btnBacktoBridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBacktoBridge.TabIndex = 3;
            this.btnBacktoBridge.TabStop = false;
            this.btnBacktoBridge.Click += new System.EventHandler(this.btnBacktoBridge_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR6._2_submarine.Properties.Resources._4be1e08903235_560c54eb593e4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 491);
            this.ControlBox = false;
            this.Controls.Add(this.btnBacktoBridge);
            this.Controls.Add(this.triggerPillow);
            this.Controls.Add(this.triggerShelf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 530);
            this.MinimumSize = new System.Drawing.Size(910, 530);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комната капитана";
            ((System.ComponentModel.ISupportInitialize)(this.triggerShelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerPillow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBacktoBridge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox triggerShelf;
        private System.Windows.Forms.PictureBox triggerPillow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnBacktoBridge;
    }
}