
namespace AppBaiTapKTDH
{
    partial class Form1
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
            this.Container_Button = new System.Windows.Forms.Panel();
            this.Container_InputPos = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.Btn_EnterDrawing = new System.Windows.Forms.Button();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.Container_Drawing = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Container_Button.SuspendLayout();
            this.Container_InputPos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Container_Drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Container_Button
            // 
            this.Container_Button.Controls.Add(this.Container_InputPos);
            this.Container_Button.Controls.Add(this.labelCoordinates);
            this.Container_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Container_Button.Location = new System.Drawing.Point(0, 0);
            this.Container_Button.Name = "Container_Button";
            this.Container_Button.Size = new System.Drawing.Size(200, 450);
            this.Container_Button.TabIndex = 1;
            // 
            // Container_InputPos
            // 
            this.Container_InputPos.Controls.Add(this.groupBox2);
            this.Container_InputPos.Controls.Add(this.groupBox1);
            this.Container_InputPos.Controls.Add(this.Btn_EnterDrawing);
            this.Container_InputPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Container_InputPos.Location = new System.Drawing.Point(0, 13);
            this.Container_InputPos.Name = "Container_InputPos";
            this.Container_InputPos.Size = new System.Drawing.Size(200, 89);
            this.Container_InputPos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxY);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(98, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toạ Độ Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxY.Location = new System.Drawing.Point(3, 16);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(96, 20);
            this.textBoxY.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toạ Độ X";
            // 
            // textBoxX
            // 
            this.textBoxX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxX.Location = new System.Drawing.Point(3, 16);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(92, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // Btn_EnterDrawing
            // 
            this.Btn_EnterDrawing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_EnterDrawing.Location = new System.Drawing.Point(0, 66);
            this.Btn_EnterDrawing.Name = "Btn_EnterDrawing";
            this.Btn_EnterDrawing.Size = new System.Drawing.Size(200, 23);
            this.Btn_EnterDrawing.TabIndex = 2;
            this.Btn_EnterDrawing.Text = "button1";
            this.Btn_EnterDrawing.UseVisualStyleBackColor = true;
            this.Btn_EnterDrawing.Click += new System.EventHandler(this.Btn_EnterDrawing_Click);
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCoordinates.Location = new System.Drawing.Point(0, 0);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(200, 13);
            this.labelCoordinates.TabIndex = 0;
            this.labelCoordinates.Text = "label1";
            // 
            // Container_Drawing
            // 
            this.Container_Drawing.Controls.Add(this.pictureBox);
            this.Container_Drawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Drawing.Location = new System.Drawing.Point(200, 0);
            this.Container_Drawing.Name = "Container_Drawing";
            this.Container_Drawing.Size = new System.Drawing.Size(600, 450);
            this.Container_Drawing.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn_EnterDrawing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Container_Drawing);
            this.Controls.Add(this.Container_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Container_Button.ResumeLayout(false);
            this.Container_InputPos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Container_Drawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container_Button;
        private System.Windows.Forms.Panel Container_Drawing;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Panel Container_InputPos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button Btn_EnterDrawing;
    }
}

