namespace KWZP2019
{
    partial class NewMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMaintenanceForm));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnAddMaintenance = new System.Windows.Forms.Button();
            this.lblMaintenanceType = new System.Windows.Forms.Label();
            this.combMaintenanceType = new System.Windows.Forms.ComboBox();
            this.combMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.combMaintenanceDesc = new System.Windows.Forms.ComboBox();
            this.lblMaintenanceDesc = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateAccept = new System.Windows.Forms.Label();
            this.dtpDateAccept = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(947, 490);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(194, 153);
            this.btnReturnMain.TabIndex = 4;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnAddMaintenance
            // 
            this.btnAddMaintenance.AutoSize = true;
            this.btnAddMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddMaintenance.FlatAppearance.BorderSize = 3;
            this.btnAddMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAddMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddMaintenance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMaintenance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddMaintenance.Location = new System.Drawing.Point(924, 401);
            this.btnAddMaintenance.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddMaintenance.Name = "btnAddMaintenance";
            this.btnAddMaintenance.Size = new System.Drawing.Size(235, 58);
            this.btnAddMaintenance.TabIndex = 7;
            this.btnAddMaintenance.Text = "Dodaj zlecenie";
            this.btnAddMaintenance.UseVisualStyleBackColor = false;
            // 
            // lblMaintenanceType
            // 
            this.lblMaintenanceType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaintenanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaintenanceType.Location = new System.Drawing.Point(39, 63);
            this.lblMaintenanceType.Name = "lblMaintenanceType";
            this.lblMaintenanceType.Size = new System.Drawing.Size(133, 28);
            this.lblMaintenanceType.TabIndex = 8;
            this.lblMaintenanceType.Text = "Typ obsługi:";
            // 
            // combMaintenanceType
            // 
            this.combMaintenanceType.FormattingEnabled = true;
            this.combMaintenanceType.Location = new System.Drawing.Point(202, 70);
            this.combMaintenanceType.Name = "combMaintenanceType";
            this.combMaintenanceType.Size = new System.Drawing.Size(121, 21);
            this.combMaintenanceType.TabIndex = 9;
            // 
            // combMachine
            // 
            this.combMachine.FormattingEnabled = true;
            this.combMachine.Location = new System.Drawing.Point(202, 128);
            this.combMachine.Name = "combMachine";
            this.combMachine.Size = new System.Drawing.Size(121, 21);
            this.combMachine.TabIndex = 11;
            // 
            // lblMachine
            // 
            this.lblMachine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMachine.Location = new System.Drawing.Point(39, 121);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(133, 28);
            this.lblMachine.TabIndex = 10;
            this.lblMachine.Text = "Maszyna:";
            // 
            // combMaintenanceDesc
            // 
            this.combMaintenanceDesc.FormattingEnabled = true;
            this.combMaintenanceDesc.Location = new System.Drawing.Point(202, 185);
            this.combMaintenanceDesc.Name = "combMaintenanceDesc";
            this.combMaintenanceDesc.Size = new System.Drawing.Size(121, 21);
            this.combMaintenanceDesc.TabIndex = 13;
            // 
            // lblMaintenanceDesc
            // 
            this.lblMaintenanceDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaintenanceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaintenanceDesc.Location = new System.Drawing.Point(39, 178);
            this.lblMaintenanceDesc.Name = "lblMaintenanceDesc";
            this.lblMaintenanceDesc.Size = new System.Drawing.Size(133, 28);
            this.lblMaintenanceDesc.TabIndex = 12;
            this.lblMaintenanceDesc.Text = "Opis obsługi:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateEnd.Location = new System.Drawing.Point(415, 178);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(301, 28);
            this.lblDateEnd.TabIndex = 18;
            this.lblDateEnd.Text = "Data planowanego zakończenia: ";
            // 
            // lblDateStart
            // 
            this.lblDateStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateStart.Location = new System.Drawing.Point(415, 121);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(301, 28);
            this.lblDateStart.TabIndex = 16;
            this.lblDateStart.Text = "Data planowanego rozpoczęcia:";
            // 
            // lblDateAccept
            // 
            this.lblDateAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateAccept.Location = new System.Drawing.Point(415, 63);
            this.lblDateAccept.Name = "lblDateAccept";
            this.lblDateAccept.Size = new System.Drawing.Size(301, 28);
            this.lblDateAccept.TabIndex = 14;
            this.lblDateAccept.Text = "Data złożenia:";
            // 
            // dtpDateAccept
            // 
            this.dtpDateAccept.Location = new System.Drawing.Point(787, 71);
            this.dtpDateAccept.Name = "dtpDateAccept";
            this.dtpDateAccept.Size = new System.Drawing.Size(200, 20);
            this.dtpDateAccept.TabIndex = 22;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(787, 129);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(200, 20);
            this.dtpDateStart.TabIndex = 23;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(787, 186);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpDateEnd.TabIndex = 24;
            // 
            // NewMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.dtpDateAccept);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblDateAccept);
            this.Controls.Add(this.combMaintenanceDesc);
            this.Controls.Add(this.lblMaintenanceDesc);
            this.Controls.Add(this.combMachine);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.combMaintenanceType);
            this.Controls.Add(this.lblMaintenanceType);
            this.Controls.Add(this.btnAddMaintenance);
            this.Controls.Add(this.btnReturnMain);
            this.Name = "NewMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego zlecenia obsługi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnAddMaintenance;
        private System.Windows.Forms.Label lblMaintenanceType;
        private System.Windows.Forms.ComboBox combMaintenanceType;
        private System.Windows.Forms.ComboBox combMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ComboBox combMaintenanceDesc;
        private System.Windows.Forms.Label lblMaintenanceDesc;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateAccept;
        private System.Windows.Forms.DateTimePicker dtpDateAccept;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
    }
}