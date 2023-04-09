/// Чат-бот
/// @author Budaev G.B.
namespace Chat_bot_GB
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox_request = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_report = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_enter.BackgroundImage")));
            this.button_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_enter.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_enter.Image = ((System.Drawing.Image)(resources.GetObject("button_enter.Image")));
            this.button_enter.Location = new System.Drawing.Point(609, 409);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(117, 40);
            this.button_enter.TabIndex = 2;
            this.button_enter.Text = "Отправить";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // textBox_request
            // 
            this.textBox_request.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox_request.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_request.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_request.Location = new System.Drawing.Point(12, 409);
            this.textBox_request.Multiline = true;
            this.textBox_request.Name = "textBox_request";
            this.textBox_request.Size = new System.Drawing.Size(588, 40);
            this.textBox_request.TabIndex = 1;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_clear.BackgroundImage")));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_clear.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.Location = new System.Drawing.Point(735, 409);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(37, 40);
            this.button_clear.TabIndex = 3;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_report
            // 
            this.textBox_report.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox_report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_report.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_report.Location = new System.Drawing.Point(12, 12);
            this.textBox_report.Multiline = true;
            this.textBox_report.Name = "textBox_report";
            this.textBox_report.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_report.Size = new System.Drawing.Size(588, 385);
            this.textBox_report.TabIndex = 0;
            this.textBox_report.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_report);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_request);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_main";
            this.Text = "Чат-бот";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TextBox textBox_request;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_report;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}