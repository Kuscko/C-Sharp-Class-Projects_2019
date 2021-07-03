namespace BoundControlsApp
{
    partial class frmBoundData
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
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label onHandQuantityLabel;
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._MMABooks_3DataSet = new BoundControlsApp._MMABooks_3DataSet();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.MMABooks_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new BoundControlsApp._MMABooks_3DataSetTableAdapters.ProductsTableAdapter();
            this.productsAdapterManager = new BoundControlsApp._MMABooks_3DataSetTableAdapters.TableAdapterManager();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.onHandQuantityTextBox = new System.Windows.Forms.TextBox();
            productCodeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            onHandQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._MMABooks_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMABooks_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this._MMABooks_3DataSet;
            // 
            // _MMABooks_3DataSet
            // 
            this._MMABooks_3DataSet.DataSetName = "_MMABooks_3DataSet";
            this._MMABooks_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(104, 147);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(185, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(266, 147);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(347, 147);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(266, 176);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(347, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MMABooks_BindingSource
            // 
            this.MMABooks_BindingSource.DataSource = this._MMABooks_3DataSet;
            this.MMABooks_BindingSource.Position = 0;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsAdapterManager
            // 
            this.productsAdapterManager.BackupDataSetBeforeUpdate = false;
            this.productsAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.productsAdapterManager.UpdateOrder = BoundControlsApp._MMABooks_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(17, 41);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 15;
            productCodeLabel.Text = "Product Code:";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(118, 38);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(304, 20);
            this.productCodeTextBox.TabIndex = 16;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(17, 67);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 17;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 64);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(304, 20);
            this.descriptionTextBox.TabIndex = 18;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(17, 93);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 19;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(118, 90);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(304, 20);
            this.unitPriceTextBox.TabIndex = 20;
            // 
            // onHandQuantityLabel
            // 
            onHandQuantityLabel.AutoSize = true;
            onHandQuantityLabel.Location = new System.Drawing.Point(17, 119);
            onHandQuantityLabel.Name = "onHandQuantityLabel";
            onHandQuantityLabel.Size = new System.Drawing.Size(95, 13);
            onHandQuantityLabel.TabIndex = 21;
            onHandQuantityLabel.Text = "On Hand Quantity:";
            // 
            // onHandQuantityTextBox
            // 
            this.onHandQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "OnHandQuantity", true));
            this.onHandQuantityTextBox.Location = new System.Drawing.Point(118, 116);
            this.onHandQuantityTextBox.Name = "onHandQuantityTextBox";
            this.onHandQuantityTextBox.Size = new System.Drawing.Size(304, 20);
            this.onHandQuantityTextBox.TabIndex = 22;
            // 
            // frmBoundData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 226);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(onHandQuantityLabel);
            this.Controls.Add(this.onHandQuantityTextBox);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Name = "frmBoundData";
            this.Text = "Bound Data Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._MMABooks_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMABooks_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.BindingSource MMABooks_BindingSource;
        private _MMABooks_3DataSet _MMABooks_3DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private _MMABooks_3DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnRemove;
        private _MMABooks_3DataSetTableAdapters.TableAdapterManager productsAdapterManager;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox onHandQuantityTextBox;
    }
}

