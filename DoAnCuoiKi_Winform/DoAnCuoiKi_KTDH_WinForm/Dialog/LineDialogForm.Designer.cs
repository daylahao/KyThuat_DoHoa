
namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    partial class LineDialogForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.Style = new System.Windows.Forms.GroupBox();
            this.Stylelinecombobox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.endinputy = new System.Windows.Forms.TextBox();
            this.endinputx = new System.Windows.Forms.TextBox();
            this.PointStart = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.startintputy = new System.Windows.Forms.TextBox();
            this.startintputx = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Style.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.PointStart.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Style, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PointStart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.06452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.93548F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorbox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu";
            // 
            // colorbox
            // 
            this.colorbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.colorbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.colorbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorbox.FormattingEnabled = true;
            this.colorbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorbox.Location = new System.Drawing.Point(3, 16);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(247, 21);
            this.colorbox.TabIndex = 0;
            this.colorbox.TabStop = false;
            // 
            // Style
            // 
            this.Style.Controls.Add(this.Stylelinecombobox);
            this.Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Style.Location = new System.Drawing.Point(262, 62);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(253, 90);
            this.Style.TabIndex = 2;
            this.Style.TabStop = false;
            this.Style.Text = "Kiểu";
            // 
            // Stylelinecombobox
            // 
            this.Stylelinecombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Stylelinecombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Stylelinecombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stylelinecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stylelinecombobox.FormattingEnabled = true;
            this.Stylelinecombobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Stylelinecombobox.Items.AddRange(new object[] {
            "Nét liền",
            "Nét đứt",
            "Nét chấm gạch",
            "Nét 2 chấm gạch"});
            this.Stylelinecombobox.Location = new System.Drawing.Point(3, 16);
            this.Stylelinecombobox.Name = "Stylelinecombobox";
            this.Stylelinecombobox.Size = new System.Drawing.Size(247, 21);
            this.Stylelinecombobox.TabIndex = 0;
            this.Stylelinecombobox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(262, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm kết thúc";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.endinputy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.endinputx, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // endinputy
            // 
            this.endinputy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endinputy.Location = new System.Drawing.Point(126, 3);
            this.endinputy.Name = "endinputy";
            this.endinputy.Size = new System.Drawing.Size(118, 20);
            this.endinputy.TabIndex = 3;
            // 
            // endinputx
            // 
            this.endinputx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endinputx.Location = new System.Drawing.Point(3, 3);
            this.endinputx.Name = "endinputx";
            this.endinputx.Size = new System.Drawing.Size(117, 20);
            this.endinputx.TabIndex = 2;
            // 
            // PointStart
            // 
            this.PointStart.AutoSize = true;
            this.PointStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PointStart.Controls.Add(this.tableLayoutPanel3);
            this.PointStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointStart.Location = new System.Drawing.Point(3, 3);
            this.PointStart.Name = "PointStart";
            this.PointStart.Size = new System.Drawing.Size(253, 53);
            this.PointStart.TabIndex = 0;
            this.PointStart.TabStop = false;
            this.PointStart.Text = "Điểm bắt đầu";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.startintputy, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.startintputx, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // startintputy
            // 
            this.startintputy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startintputy.Location = new System.Drawing.Point(126, 3);
            this.startintputy.Name = "startintputy";
            this.startintputy.Size = new System.Drawing.Size(118, 20);
            this.startintputy.TabIndex = 1;
            // 
            // startintputx
            // 
            this.startintputx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startintputx.Location = new System.Drawing.Point(3, 3);
            this.startintputx.Name = "startintputx";
            this.startintputx.Size = new System.Drawing.Size(117, 20);
            this.startintputx.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(80, 41);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.55172F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.44828F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.Controls.Add(this.btn_reset, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_close, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_accept, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 155);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(518, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reset.Location = new System.Drawing.Point(89, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 41);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Mặc định";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_accept.Location = new System.Drawing.Point(396, 3);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(119, 41);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Chấp nhận";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // LineDialogForm
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(518, 202);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LineDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LineDialogForm";
            this.Load += new System.EventHandler(this.LineDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Style.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.PointStart.ResumeLayout(false);
            this.PointStart.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox PointStart;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox startintputy;
        private System.Windows.Forms.TextBox startintputx;
        private System.Windows.Forms.TextBox endinputy;
        private System.Windows.Forms.TextBox endinputx;
        private System.Windows.Forms.GroupBox Style;
        private System.Windows.Forms.ComboBox Stylelinecombobox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox colorbox;
    }
}