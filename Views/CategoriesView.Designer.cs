﻿namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabCategoryList = new TabPage();
            BtnCloseCate = new Button();
            BtnDeleteCate = new Button();
            BtnEditCate = new Button();
            BtnNewCate = new Button();
            BtnSearchCate = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabCategoryDetail = new TabPage();
            BtnCancelCate = new Button();
            BtnSaveCate = new Button();
            TxtCategorieObservation = new TextBox();
            label5 = new Label();
            TxtCategoryName = new TextBox();
            label4 = new Label();
            TxtCategoryId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categories;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoryList);
            tabControl1.Controls.Add(tabCategoryDetail);
            tabControl1.Location = new Point(8, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 442);
            tabControl1.TabIndex = 2;
            // 
            // tabCategoryList
            // 
            tabCategoryList.Controls.Add(BtnCloseCate);
            tabCategoryList.Controls.Add(BtnDeleteCate);
            tabCategoryList.Controls.Add(BtnEditCate);
            tabCategoryList.Controls.Add(BtnNewCate);
            tabCategoryList.Controls.Add(BtnSearchCate);
            tabCategoryList.Controls.Add(BtnClose);
            tabCategoryList.Controls.Add(BtnDelete);
            tabCategoryList.Controls.Add(BtnEdit);
            tabCategoryList.Controls.Add(BtnNew);
            tabCategoryList.Controls.Add(DgCategories);
            tabCategoryList.Controls.Add(BtnSearch);
            tabCategoryList.Controls.Add(TxtSearch);
            tabCategoryList.Controls.Add(label2);
            tabCategoryList.Location = new Point(4, 29);
            tabCategoryList.Name = "tabCategoryList";
            tabCategoryList.Padding = new Padding(3);
            tabCategoryList.Size = new Size(744, 409);
            tabCategoryList.TabIndex = 0;
            tabCategoryList.Text = "Category List";
            tabCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnCloseCate
            // 
            BtnCloseCate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCloseCate.BackgroundImage = Properties.Resources.cerrar;
            BtnCloseCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCloseCate.Location = new Point(563, 283);
            BtnCloseCate.Name = "BtnCloseCate";
            BtnCloseCate.Size = new Size(94, 38);
            BtnCloseCate.TabIndex = 12;
            BtnCloseCate.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteCate
            // 
            BtnDeleteCate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeleteCate.BackgroundImage = Properties.Resources.delete;
            BtnDeleteCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDeleteCate.Location = new Point(563, 218);
            BtnDeleteCate.Name = "BtnDeleteCate";
            BtnDeleteCate.Size = new Size(94, 39);
            BtnDeleteCate.TabIndex = 11;
            BtnDeleteCate.UseVisualStyleBackColor = true;
            // 
            // BtnEditCate
            // 
            BtnEditCate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditCate.BackgroundImage = Properties.Resources.edit;
            BtnEditCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEditCate.Location = new Point(563, 157);
            BtnEditCate.Name = "BtnEditCate";
            BtnEditCate.Size = new Size(94, 38);
            BtnEditCate.TabIndex = 10;
            BtnEditCate.UseVisualStyleBackColor = true;
            // 
            // BtnNewCate
            // 
            BtnNewCate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewCate.BackgroundImage = Properties.Resources._new;
            BtnNewCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNewCate.Location = new Point(563, 95);
            BtnNewCate.Name = "BtnNewCate";
            BtnNewCate.Size = new Size(94, 40);
            BtnNewCate.TabIndex = 9;
            BtnNewCate.UseVisualStyleBackColor = true;
            // 
            // BtnSearchCate
            // 
            BtnSearchCate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchCate.BackgroundImage = Properties.Resources.search_small;
            BtnSearchCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearchCate.Location = new Point(438, 22);
            BtnSearchCate.Name = "BtnSearchCate";
            BtnSearchCate.Size = new Size(50, 48);
            BtnSearchCate.TabIndex = 8;
            BtnSearchCate.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(1161, 235);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 38);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(1161, 170);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 39);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(1161, 109);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 38);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(1161, 47);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 40);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(21, 95);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.RowTemplate.Height = 29;
            DgCategories.Size = new Size(489, 296);
            DgCategories.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackgroundImage = Properties.Resources.search_small;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(1014, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(21, 43);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(411, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 20);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            // 
            // tabCategoryDetail
            // 
            tabCategoryDetail.Controls.Add(BtnCancelCate);
            tabCategoryDetail.Controls.Add(BtnSaveCate);
            tabCategoryDetail.Controls.Add(TxtCategorieObservation);
            tabCategoryDetail.Controls.Add(label5);
            tabCategoryDetail.Controls.Add(TxtCategoryName);
            tabCategoryDetail.Controls.Add(label4);
            tabCategoryDetail.Controls.Add(TxtCategoryId);
            tabCategoryDetail.Controls.Add(label3);
            tabCategoryDetail.Location = new Point(4, 29);
            tabCategoryDetail.Name = "tabCategoryDetail";
            tabCategoryDetail.Padding = new Padding(3);
            tabCategoryDetail.Size = new Size(744, 409);
            tabCategoryDetail.TabIndex = 1;
            tabCategoryDetail.Text = "Category Detail";
            tabCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancelCate
            // 
            BtnCancelCate.BackgroundImage = Properties.Resources.cancel;
            BtnCancelCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelCate.Location = new Point(166, 290);
            BtnCancelCate.Name = "BtnCancelCate";
            BtnCancelCate.Size = new Size(94, 47);
            BtnCancelCate.TabIndex = 7;
            BtnCancelCate.UseVisualStyleBackColor = true;
            // 
            // BtnSaveCate
            // 
            BtnSaveCate.BackgroundImage = Properties.Resources.save;
            BtnSaveCate.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSaveCate.Location = new Point(47, 290);
            BtnSaveCate.Name = "BtnSaveCate";
            BtnSaveCate.Size = new Size(94, 47);
            BtnSaveCate.TabIndex = 6;
            BtnSaveCate.UseVisualStyleBackColor = true;
            // 
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.Location = new Point(25, 196);
            TxtCategorieObservation.Multiline = true;
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.PlaceholderText = "Observation";
            TxtCategorieObservation.Size = new Size(366, 77);
            TxtCategorieObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 176);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Observation";
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(24, 114);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(367, 27);
            TxtCategoryName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 94);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 2;
            label4.Text = "Category Name";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(23, 36);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(168, 27);
            TxtCategoryId.TabIndex = 1;
            TxtCategoryId.Text = "0";
            TxtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 16);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Category Id";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 574);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Category Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoryList.ResumeLayout(false);
            tabCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabCategoryDetail.ResumeLayout(false);
            tabCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabCategoryList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage tabCategoryDetail;
        private Button BtnCancelCate;
        private Button BtnSaveCate;
        private TextBox TxtCategorieObservation;
        private Label label5;
        private TextBox TxtCategoryName;
        private Label label4;
        private TextBox TxtCategoryId;
        private Label label3;
        private Button BtnSearchCate;
        private Button BtnCloseCate;
        private Button BtnDeleteCate;
        private Button BtnEditCate;
        private Button BtnNewCate;
    }
}