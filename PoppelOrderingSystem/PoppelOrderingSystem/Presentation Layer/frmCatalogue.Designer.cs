namespace PoppelOrderingSystem.Presentation_Layer
{
    partial class frmCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogue));
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCatalogue = new System.Windows.Forms.DataGridView();
            this.poppelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poppelDatabaseDataSet = new PoppelOrderingSystem.PoppelDatabaseDataSet();
            this.btnUpdateCatalogue = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatalogueID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEffectiveDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.poppelDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(15, 16);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(179, 98);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(420, 63);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CATALOGUE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCTS:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewCatalogue
            // 
            this.dataGridViewCatalogue.AutoGenerateColumns = false;
            this.dataGridViewCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogue.DataSource = this.poppelDatabaseDataSetBindingSource;
            this.dataGridViewCatalogue.Location = new System.Drawing.Point(15, 195);
            this.dataGridViewCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCatalogue.Name = "dataGridViewCatalogue";
            this.dataGridViewCatalogue.RowHeadersWidth = 51;
            this.dataGridViewCatalogue.RowTemplate.Height = 24;
            this.dataGridViewCatalogue.Size = new System.Drawing.Size(757, 271);
            this.dataGridViewCatalogue.TabIndex = 3;
            this.dataGridViewCatalogue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalogue_CellContentClick);
            // 
            // poppelDatabaseDataSetBindingSource
            // 
            this.poppelDatabaseDataSetBindingSource.DataSource = this.poppelDatabaseDataSet;
            this.poppelDatabaseDataSetBindingSource.Position = 0;
            // 
            // poppelDatabaseDataSet
            // 
            this.poppelDatabaseDataSet.DataSetName = "PoppelDatabaseDataSet";
            this.poppelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdateCatalogue
            // 
            this.btnUpdateCatalogue.Location = new System.Drawing.Point(48, 525);
            this.btnUpdateCatalogue.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCatalogue.Name = "btnUpdateCatalogue";
            this.btnUpdateCatalogue.Size = new System.Drawing.Size(221, 57);
            this.btnUpdateCatalogue.TabIndex = 4;
            this.btnUpdateCatalogue.Text = "Update Catalogue";
            this.btnUpdateCatalogue.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(326, 525);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(221, 57);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(584, 525);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(221, 57);
            this.btnDeleteItem.TabIndex = 6;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(803, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catalogue ID:*";
            // 
            // txtCatalogueID
            // 
            this.txtCatalogueID.Location = new System.Drawing.Point(961, 221);
            this.txtCatalogueID.Name = "txtCatalogueID";
            this.txtCatalogueID.Size = new System.Drawing.Size(157, 29);
            this.txtCatalogueID.TabIndex = 8;
            this.txtCatalogueID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product ID:*";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(961, 272);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(157, 29);
            this.txtProductID.TabIndex = 10;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(869, 328);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(63, 22);
            this.Price.TabIndex = 11;
            this.Price.Text = "Price:*";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(961, 328);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 29);
            this.txtPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(869, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Year:*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(961, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 29);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Effective Date:*";
            // 
            // txtEffectiveDate
            // 
            this.txtEffectiveDate.Location = new System.Drawing.Point(961, 437);
            this.txtEffectiveDate.Name = "txtEffectiveDate";
            this.txtEffectiveDate.Size = new System.Drawing.Size(157, 29);
            this.txtEffectiveDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(831, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "End Date:*";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(961, 488);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(157, 29);
            this.txtEndDate.TabIndex = 18;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(835, 615);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(221, 57);
            this.btnHomePage.TabIndex = 19;
            this.btnHomePage.Text = "<< Home Page";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(947, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "* means mandatory field";
            // 
            // poppelDatabaseDataSetBindingSource1
            // 
            this.poppelDatabaseDataSetBindingSource1.DataSource = this.poppelDatabaseDataSet;
            this.poppelDatabaseDataSetBindingSource1.Position = 0;
            // 
            // frmCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 719);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEffectiveDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatalogueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnUpdateCatalogue);
            this.Controls.Add(this.dataGridViewCatalogue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.logo);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCatalogue";
            this.Text = "Catalogue";
            this.Load += new System.EventHandler(this.frmCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDatabaseDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCatalogue;
        private System.Windows.Forms.Button btnUpdateCatalogue;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalogueID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEffectiveDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource poppelDatabaseDataSetBindingSource;
        private PoppelDatabaseDataSet poppelDatabaseDataSet;
        private System.Windows.Forms.BindingSource poppelDatabaseDataSetBindingSource1;
    }
}