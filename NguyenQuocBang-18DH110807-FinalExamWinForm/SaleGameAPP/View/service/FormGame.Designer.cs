namespace SaleGameAPP.View.Service
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.saleGameDataSet = new SaleGameAPP.SaleGameDataSet();
            this.dgvGame = new System.Windows.Forms.DataGridView();
            this.saleGameDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureImgGame = new System.Windows.Forms.PictureBox();
            this.tbMSHH = new System.Windows.Forms.TextBox();
            this.tbTenGame = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdExist = new System.Windows.Forms.RadioButton();
            this.rdNorExist = new System.Windows.Forms.RadioButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnBrowser = new FontAwesome.Sharp.IconButton();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleGameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGameDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgGame)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saleGameDataSet
            // 
            this.saleGameDataSet.DataSetName = "SaleGameDataSet";
            this.saleGameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvGame
            // 
            this.dgvGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dgvGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGame.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.dgvGame.Location = new System.Drawing.Point(0, 395);
            this.dgvGame.Name = "dgvGame";
            this.dgvGame.RowTemplate.Height = 24;
            this.dgvGame.Size = new System.Drawing.Size(882, 208);
            this.dgvGame.TabIndex = 0;
            // 
            // saleGameDataSetBindingSource
            // 
            this.saleGameDataSetBindingSource.DataSource = this.saleGameDataSet;
            this.saleGameDataSetBindingSource.Position = 0;
            // 
            // pictureImgGame
            // 
            this.pictureImgGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureImgGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pictureImgGame.Location = new System.Drawing.Point(373, 0);
            this.pictureImgGame.Name = "pictureImgGame";
            this.pictureImgGame.Size = new System.Drawing.Size(509, 133);
            this.pictureImgGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureImgGame.TabIndex = 1;
            this.pictureImgGame.TabStop = false;
            // 
            // tbMSHH
            // 
            this.tbMSHH.Location = new System.Drawing.Point(115, 32);
            this.tbMSHH.Name = "tbMSHH";
            this.tbMSHH.Size = new System.Drawing.Size(209, 22);
            this.tbMSHH.TabIndex = 2;
            // 
            // tbTenGame
            // 
            this.tbTenGame.Location = new System.Drawing.Point(115, 96);
            this.tbTenGame.Name = "tbTenGame";
            this.tbTenGame.Size = new System.Drawing.Size(209, 22);
            this.tbTenGame.TabIndex = 3;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(115, 170);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(209, 22);
            this.tbGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "MSHH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(8, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá (VND)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên game:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.rdNorExist);
            this.panel1.Controls.Add(this.rdExist);
            this.panel1.Controls.Add(this.tbTenGame);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbMSHH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 320);
            this.panel1.TabIndex = 10;
            // 
            // rdExist
            // 
            this.rdExist.AutoSize = true;
            this.rdExist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.rdExist.Location = new System.Drawing.Point(115, 242);
            this.rdExist.Name = "rdExist";
            this.rdExist.Size = new System.Drawing.Size(101, 23);
            this.rdExist.TabIndex = 11;
            this.rdExist.TabStop = true;
            this.rdExist.Text = "Còn hàng";
            this.rdExist.UseVisualStyleBackColor = true;
            // 
            // rdNorExist
            // 
            this.rdNorExist.AutoSize = true;
            this.rdNorExist.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNorExist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.rdNorExist.Location = new System.Drawing.Point(240, 242);
            this.rdNorExist.Name = "rdNorExist";
            this.rdNorExist.Size = new System.Drawing.Size(95, 23);
            this.rdNorExist.TabIndex = 12;
            this.rdNorExist.TabStop = true;
            this.rdNorExist.Text = "Hết hàng";
            this.rdNorExist.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(882, 75);
            this.panelTitle.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panel2.Controls.Add(this.panelBtn);
            this.panel2.Controls.Add(this.pictureImgGame);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 320);
            this.panel2.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconSize = 16;
            this.btnAdd.Location = new System.Drawing.Point(18, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0D;
            this.btnAdd.Size = new System.Drawing.Size(136, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconSize = 16;
            this.btnDelete.Location = new System.Drawing.Point(361, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(136, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconSize = 16;
            this.btnUpdate.Location = new System.Drawing.Point(193, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(136, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnBrowser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBrowser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.btnBrowser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBrowser.IconColor = System.Drawing.Color.Black;
            this.btnBrowser.IconSize = 16;
            this.btnBrowser.Location = new System.Drawing.Point(361, 25);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Rotation = 0D;
            this.btnBrowser.Size = new System.Drawing.Size(136, 41);
            this.btnBrowser.TabIndex = 14;
            this.btnBrowser.Text = "Browsser";
            this.btnBrowser.UseVisualStyleBackColor = false;
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelBtn.Controls.Add(this.btnBrowser);
            this.panelBtn.Controls.Add(this.btnDelete);
            this.panelBtn.Controls.Add(this.btnAdd);
            this.panelBtn.Controls.Add(this.btnUpdate);
            this.panelBtn.Location = new System.Drawing.Point(373, 133);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(509, 197);
            this.panelBtn.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(97, 10, 97, 10);
            this.pictureBox1.Size = new System.Drawing.Size(148, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.dgvGame);
            this.Name = "FormGame";
            this.Text = "Menu Game";
            ((System.ComponentModel.ISupportInitialize)(this.saleGameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGameDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImgGame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SaleGameDataSet saleGameDataSet;
        private System.Windows.Forms.DataGridView dgvGame;
        private System.Windows.Forms.BindingSource saleGameDataSetBindingSource;
        private System.Windows.Forms.PictureBox pictureImgGame;
        private System.Windows.Forms.TextBox tbMSHH;
        private System.Windows.Forms.TextBox tbTenGame;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNorExist;
        private System.Windows.Forms.RadioButton rdExist;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBtn;
        private FontAwesome.Sharp.IconButton btnBrowser;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}