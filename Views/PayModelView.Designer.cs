﻿namespace Supermarket_mvp.Views
{
    partial class PayModelView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPagePayModeDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(161, 50);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Location = new Point(3, 128);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 389);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(777, 345);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(777, 356);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(18, 40);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(449, 27);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.search_small;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(473, 29);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 48);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(18, 83);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(505, 246);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = Properties.Resources._new;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(620, 44);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(94, 40);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(620, 106);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(94, 38);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImage = Properties.Resources.delete;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(620, 167);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 39);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = Properties.Resources.cerrar;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(620, 232);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(94, 38);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 13);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(23, 36);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(168, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(24, 114);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(367, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 91);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(25, 196);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(366, 77);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 173);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            label5.Click += label5_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.save;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(47, 290);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 47);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancel;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(166, 290);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 47);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 521);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
    }
}