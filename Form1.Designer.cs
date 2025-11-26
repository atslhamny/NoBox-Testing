using System.Windows.Forms;

namespace MyNoBoxWinForm
{
    partial class MyNoBox
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.lblNoboxProcess = new System.Windows.Forms.Label();
         this.lblPreview = new System.Windows.Forms.Label();
         this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
         this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.BtnStart = new System.Windows.Forms.Button();
         this.lblMenu = new System.Windows.Forms.Label();
         this.CBMenu = new System.Windows.Forms.ComboBox();
         this.BtnOther = new System.Windows.Forms.Button();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.timeNowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.logsitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel6.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.tableLayoutPanel5.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
         this.tableLayoutPanel7.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.tableLayoutPanel4.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.logsitemsBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 154);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 30);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // tableLayoutPanel6
         // 
         this.tableLayoutPanel6.ColumnCount = 3;
         this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
         this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 603F));
         this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 0);
         this.tableLayoutPanel6.Controls.Add(this.lblNoboxProcess, 1, 0);
         this.tableLayoutPanel6.Controls.Add(this.lblPreview, 2, 0);
         this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel6.Name = "tableLayoutPanel6";
         this.tableLayoutPanel6.RowCount = 1;
         this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel6.Size = new System.Drawing.Size(352, 24);
         this.tableLayoutPanel6.TabIndex = 0;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = global::MyNoBoxWinForm.Properties.Resources.photo_2022_08_23_15_57_23;
         this.pictureBox2.Location = new System.Drawing.Point(3, 3);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(24, 18);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox2.TabIndex = 0;
         this.pictureBox2.TabStop = false;
         // 
         // lblNoboxProcess
         // 
         this.lblNoboxProcess.AutoSize = true;
         this.lblNoboxProcess.BackColor = System.Drawing.SystemColors.Highlight;
         this.lblNoboxProcess.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblNoboxProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNoboxProcess.ForeColor = System.Drawing.Color.White;
         this.lblNoboxProcess.Location = new System.Drawing.Point(33, 0);
         this.lblNoboxProcess.Name = "lblNoboxProcess";
         this.lblNoboxProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.lblNoboxProcess.Size = new System.Drawing.Size(143, 24);
         this.lblNoboxProcess.TabIndex = 1;
         this.lblNoboxProcess.Text = "NoBox Process";
         this.lblNoboxProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblPreview
         // 
         this.lblPreview.AutoSize = true;
         this.lblPreview.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblPreview.Location = new System.Drawing.Point(182, 0);
         this.lblPreview.Name = "lblPreview";
         this.lblPreview.Size = new System.Drawing.Size(597, 24);
         this.lblPreview.TabIndex = 2;
         // 
         // tableLayoutPanel5
         // 
         this.tableLayoutPanel5.ColumnCount = 3;
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
         this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
         this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
         this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel5.Location = new System.Drawing.Point(361, 3);
         this.tableLayoutPanel5.Name = "tableLayoutPanel5";
         this.tableLayoutPanel5.RowCount = 1;
         this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel5.Size = new System.Drawing.Size(424, 24);
         this.tableLayoutPanel5.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(3, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(94, 24);
         this.label1.TabIndex = 0;
         this.label1.Text = "Test:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(103, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(94, 24);
         this.label2.TabIndex = 1;
         this.label2.Text = "Fail:";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(203, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(218, 24);
         this.label3.TabIndex = 2;
         this.label3.Text = "Pass:";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 1;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Controls.Add(this.webView21, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 1);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 2;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
         this.tableLayoutPanel2.TabIndex = 1;
         // 
         // webView21
         // 
         this.webView21.AllowExternalDrop = true;
         this.webView21.CreationProperties = null;
         this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
         this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
         this.webView21.Location = new System.Drawing.Point(3, 3);
         this.webView21.Name = "webView21";
         this.webView21.Size = new System.Drawing.Size(794, 251);
         this.webView21.TabIndex = 0;
         this.webView21.ZoomFactor = 1D;
         // 
         // tableLayoutPanel7
         // 
         this.tableLayoutPanel7.ColumnCount = 1;
         this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel7.Controls.Add(this.tabControl1, 0, 0);
         this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 1);
         this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 260);
         this.tableLayoutPanel7.Name = "tableLayoutPanel7";
         this.tableLayoutPanel7.RowCount = 2;
         this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.28342F));
         this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.71658F));
         this.tableLayoutPanel7.Size = new System.Drawing.Size(794, 187);
         this.tableLayoutPanel7.TabIndex = 1;
         // 
         // tabControl1
         // 
         this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(3, 3);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(788, 145);
         this.tabControl1.TabIndex = 1;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.tableLayoutPanel3);
         this.tabPage1.Location = new System.Drawing.Point(4, 4);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(780, 119);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Process";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 585F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(774, 113);
         this.tableLayoutPanel3.TabIndex = 0;
         // 
         // tableLayoutPanel4
         // 
         this.tableLayoutPanel4.ColumnCount = 4;
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.5495F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.4505F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
         this.tableLayoutPanel4.Controls.Add(this.BtnStart, 2, 0);
         this.tableLayoutPanel4.Controls.Add(this.lblMenu, 0, 0);
         this.tableLayoutPanel4.Controls.Add(this.CBMenu, 1, 0);
         this.tableLayoutPanel4.Controls.Add(this.BtnOther, 3, 0);
         this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel4.Name = "tableLayoutPanel4";
         this.tableLayoutPanel4.RowCount = 3;
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel4.Size = new System.Drawing.Size(579, 107);
         this.tableLayoutPanel4.TabIndex = 4;
         // 
         // BtnStart
         // 
         this.BtnStart.BackColor = System.Drawing.SystemColors.Highlight;
         this.BtnStart.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnStart.ForeColor = System.Drawing.Color.White;
         this.BtnStart.Location = new System.Drawing.Point(303, 3);
         this.BtnStart.Name = "BtnStart";
         this.BtnStart.Size = new System.Drawing.Size(142, 29);
         this.BtnStart.TabIndex = 0;
         this.BtnStart.Text = "Start";
         this.BtnStart.UseVisualStyleBackColor = false;
         this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
         // 
         // lblMenu
         // 
         this.lblMenu.AutoSize = true;
         this.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.lblMenu.Location = new System.Drawing.Point(3, 0);
         this.lblMenu.Name = "lblMenu";
         this.lblMenu.Size = new System.Drawing.Size(94, 35);
         this.lblMenu.TabIndex = 2;
         this.lblMenu.Text = "Menu";
         // 
         // CBMenu
         // 
         this.CBMenu.Dock = System.Windows.Forms.DockStyle.Fill;
         this.CBMenu.FormattingEnabled = true;
         this.CBMenu.Location = new System.Drawing.Point(103, 3);
         this.CBMenu.Name = "CBMenu";
         this.CBMenu.Size = new System.Drawing.Size(194, 21);
         this.CBMenu.TabIndex = 3;
         this.CBMenu.Text = "All";
         this.CBMenu.SelectedIndexChanged += new System.EventHandler(this.CBMenu_SelectedIndexChanged);
         // 
         // BtnOther
         // 
         this.BtnOther.BackColor = System.Drawing.Color.Black;
         this.BtnOther.Dock = System.Windows.Forms.DockStyle.Fill;
         this.BtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnOther.ForeColor = System.Drawing.Color.White;
         this.BtnOther.Location = new System.Drawing.Point(451, 3);
         this.BtnOther.Name = "BtnOther";
         this.BtnOther.Size = new System.Drawing.Size(125, 29);
         this.BtnOther.TabIndex = 1;
         this.BtnOther.Text = "Other Options";
         this.BtnOther.UseVisualStyleBackColor = false;
         this.BtnOther.Click += new System.EventHandler(this.button2_Click);
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.dataGridView1);
         this.tabPage2.Location = new System.Drawing.Point(4, 4);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(780, 119);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Log";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // dataGridView1
         // 
         this.dataGridView1.AutoGenerateColumns = false;
         this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeNowDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
         this.dataGridView1.DataSource = this.logsitemsBindingSource;
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point(3, 3);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(774, 113);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // timeNowDataGridViewTextBoxColumn
         // 
         this.timeNowDataGridViewTextBoxColumn.DataPropertyName = "timeNow";
         this.timeNowDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
         this.timeNowDataGridViewTextBoxColumn.Name = "timeNowDataGridViewTextBoxColumn";
         // 
         // typeDataGridViewTextBoxColumn
         // 
         this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
         this.typeDataGridViewTextBoxColumn.HeaderText = "Positif/Negatif";
         this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
         // 
         // processDataGridViewTextBoxColumn
         // 
         this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
         this.processDataGridViewTextBoxColumn.HeaderText = "Process";
         this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
         // 
         // resultDataGridViewTextBoxColumn
         // 
         this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
         this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
         this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
         // 
         // logsitemsBindingSource
         // 
         this.logsitemsBindingSource.DataSource = typeof(MyNoBoxWinForm.MyNoBox.logsitems);
         // 
         // MyNoBox
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.tableLayoutPanel2);
         this.Name = "MyNoBox";
         this.Text = "NoBox | Tester";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MyNoBox_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel6.ResumeLayout(false);
         this.tableLayoutPanel6.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.tableLayoutPanel5.ResumeLayout(false);
         this.tableLayoutPanel5.PerformLayout();
         this.tableLayoutPanel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
         this.tableLayoutPanel7.ResumeLayout(false);
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel4.ResumeLayout(false);
         this.tableLayoutPanel4.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.logsitemsBindingSource)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BtnStart;
        private Label lblMenu;
        private ComboBox CBMenu;
        private Label lblNoboxProcess;
        private Label lblPreview;
        private Button BtnOther;
        public Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private BindingSource logsitemsBindingSource;
      private DataGridViewTextBoxColumn timeNowDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
      private DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

