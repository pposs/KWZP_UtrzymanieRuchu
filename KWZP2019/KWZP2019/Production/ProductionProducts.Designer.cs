﻿namespace KWZP2019
{
    partial class ProductionProducts
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
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btDeleteProduct = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSemiFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddProduct
            // 
            this.btAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btAddProduct.FlatAppearance.BorderSize = 3;
            this.btAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAddProduct.ForeColor = System.Drawing.Color.White;
            this.btAddProduct.Image = global::KWZP2019.Properties.Resources.addp;
            this.btAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAddProduct.Location = new System.Drawing.Point(12, 12);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(150, 130);
            this.btAddProduct.TabIndex = 0;
            this.btAddProduct.Text = "Dodaj";
            this.btAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddProduct.UseVisualStyleBackColor = false;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btEditProduct.FlatAppearance.BorderSize = 3;
            this.btEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEditProduct.ForeColor = System.Drawing.Color.White;
            this.btEditProduct.Image = global::KWZP2019.Properties.Resources.editp;
            this.btEditProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEditProduct.Location = new System.Drawing.Point(168, 12);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(150, 130);
            this.btEditProduct.TabIndex = 1;
            this.btEditProduct.Text = "Edytuj";
            this.btEditProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditProduct.UseVisualStyleBackColor = false;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btDeleteProduct.FlatAppearance.BorderSize = 3;
            this.btDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btDeleteProduct.Image = global::KWZP2019.Properties.Resources.deletep;
            this.btDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDeleteProduct.Location = new System.Drawing.Point(480, 12);
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(150, 130);
            this.btDeleteProduct.TabIndex = 2;
            this.btDeleteProduct.Text = "Usuń";
            this.btDeleteProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDeleteProduct.UseVisualStyleBackColor = false;
            this.btDeleteProduct.Click += new System.EventHandler(this.btDeleteProduct_Click);
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btEnd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btEnd.FlatAppearance.BorderSize = 3;
            this.btEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEnd.ForeColor = System.Drawing.Color.White;
            this.btEnd.Image = global::KWZP2019.Properties.Resources.closep;
            this.btEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEnd.Location = new System.Drawing.Point(636, 12);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(150, 130);
            this.btEnd.TabIndex = 3;
            this.btEnd.Text = "Zamknij";
            this.btEnd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEnd.UseVisualStyleBackColor = false;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoGenerateColumns = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductDataGridViewTextBoxColumn,
            this.idSemiFinishedDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.idTechnologyDataGridViewTextBoxColumn,
            this.inputDateDataGridViewTextBoxColumn});
            this.dataGridProducts.DataSource = this.productBindingSource;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 152);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(776, 286);
            this.dataGridProducts.TabIndex = 4;
            this.dataGridProducts.SelectionChanged += new System.EventHandler(this.dataGridProducts_SelectionChanged);
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "ID Produktu";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            // 
            // idSemiFinishedDataGridViewTextBoxColumn
            // 
            this.idSemiFinishedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idSemiFinishedDataGridViewTextBoxColumn.DataPropertyName = "IdSemiFinished";
            this.idSemiFinishedDataGridViewTextBoxColumn.HeaderText = "ID Półproduktu";
            this.idSemiFinishedDataGridViewTextBoxColumn.Name = "idSemiFinishedDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Kod produktu";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // idTechnologyDataGridViewTextBoxColumn
            // 
            this.idTechnologyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idTechnologyDataGridViewTextBoxColumn.DataPropertyName = "IdTechnology";
            this.idTechnologyDataGridViewTextBoxColumn.HeaderText = "ID Technologii";
            this.idTechnologyDataGridViewTextBoxColumn.Name = "idTechnologyDataGridViewTextBoxColumn";
            // 
            // inputDateDataGridViewTextBoxColumn
            // 
            this.inputDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inputDateDataGridViewTextBoxColumn.DataPropertyName = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.HeaderText = "Data dodania";
            this.inputDateDataGridViewTextBoxColumn.Name = "inputDateDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(KWZP2019.Product);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btRefresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btRefresh.FlatAppearance.BorderSize = 3;
            this.btRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.Image = global::KWZP2019.Properties.Resources.refreshp;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRefresh.Location = new System.Drawing.Point(323, 12);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(150, 130);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Odśwież";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ProductionProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDeleteProduct);
            this.Controls.Add(this.btEditProduct);
            this.Controls.Add(this.btAddProduct);
            this.Name = "ProductionProducts";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.ProductionProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btDeleteProduct;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSemiFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTechnologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDateDataGridViewTextBoxColumn;
    }
}