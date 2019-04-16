namespace KWZP2019
{
    partial class PartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsForm));
            this.menuParts = new System.Windows.Forms.Panel();
            this.textPartsMenu = new System.Windows.Forms.TextBox();
            this.pictureMenu = new System.Windows.Forms.PictureBox();
            this.panelParts = new System.Windows.Forms.Panel();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.buttonNewPart = new System.Windows.Forms.Button();
            this.menuParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).BeginInit();
            this.panelParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuParts
            // 
            this.menuParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.menuParts.Controls.Add(this.buttonNewPart);
            this.menuParts.Controls.Add(this.textPartsMenu);
            this.menuParts.Controls.Add(this.pictureMenu);
            this.menuParts.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuParts.Location = new System.Drawing.Point(0, 0);
            this.menuParts.Name = "menuParts";
            this.menuParts.Size = new System.Drawing.Size(57, 681);
            this.menuParts.TabIndex = 0;
            // 
            // textPartsMenu
            // 
            this.textPartsMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textPartsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.textPartsMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPartsMenu.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textPartsMenu.ForeColor = System.Drawing.Color.White;
            this.textPartsMenu.Location = new System.Drawing.Point(86, 0);
            this.textPartsMenu.Name = "textPartsMenu";
            this.textPartsMenu.ReadOnly = true;
            this.textPartsMenu.Size = new System.Drawing.Size(139, 59);
            this.textPartsMenu.TabIndex = 2;
            this.textPartsMenu.TabStop = false;
            this.textPartsMenu.Text = "MENU";
            this.textPartsMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPartsMenu.WordWrap = false;
            // 
            // pictureMenu
            // 
            this.pictureMenu.BackColor = System.Drawing.Color.Transparent;
            this.pictureMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureMenu.Image")));
            this.pictureMenu.Location = new System.Drawing.Point(3, 3);
            this.pictureMenu.Name = "pictureMenu";
            this.pictureMenu.Size = new System.Drawing.Size(54, 48);
            this.pictureMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMenu.TabIndex = 2;
            this.pictureMenu.TabStop = false;
            this.pictureMenu.Click += new System.EventHandler(this.pictureMenu_Click);
            // 
            // panelParts
            // 
            this.panelParts.BackColor = System.Drawing.Color.Gray;
            this.panelParts.Controls.Add(this.btnReturnMain);
            this.panelParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParts.Location = new System.Drawing.Point(57, 0);
            this.panelParts.Name = "panelParts";
            this.panelParts.Size = new System.Drawing.Size(1127, 59);
            this.panelParts.TabIndex = 1;
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(1051, 0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(76, 59);
            this.btnReturnMain.TabIndex = 3;
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // buttonNewPart
            // 
            this.buttonNewPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.buttonNewPart.FlatAppearance.BorderSize = 0;
            this.buttonNewPart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonNewPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewPart.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.buttonNewPart.ForeColor = System.Drawing.Color.White;
            this.buttonNewPart.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewPart.Image")));
            this.buttonNewPart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNewPart.Location = new System.Drawing.Point(0, 90);
            this.buttonNewPart.Name = "buttonNewPart";
            this.buttonNewPart.Size = new System.Drawing.Size(250, 67);
            this.buttonNewPart.TabIndex = 2;
            this.buttonNewPart.Text = "         Nowa Część";
            this.buttonNewPart.UseVisualStyleBackColor = false;
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panelParts);
            this.Controls.Add(this.menuParts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parts";
            this.TransparencyKey = System.Drawing.Color.HotPink;
            this.menuParts.ResumeLayout(false);
            this.menuParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMenu)).EndInit();
            this.panelParts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuParts;
        private System.Windows.Forms.PictureBox pictureMenu;
        private System.Windows.Forms.Panel panelParts;
        private System.Windows.Forms.TextBox textPartsMenu;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button buttonNewPart;
    }
}