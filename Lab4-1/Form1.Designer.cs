namespace Lab4_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnGetHtml;
        private System.Windows.Forms.RichTextBox rtbHtmlContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnGetHtml = new System.Windows.Forms.Button();
            this.rtbHtmlContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(13, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(775, 22);
            this.txtUrl.TabIndex = 0;
            // 
            // btnGetHtml
            // 
            this.btnGetHtml.Location = new System.Drawing.Point(13, 42);
            this.btnGetHtml.Name = "btnGetHtml";
            this.btnGetHtml.Size = new System.Drawing.Size(75, 23);
            this.btnGetHtml.TabIndex = 1;
            this.btnGetHtml.Text = "Get HTML";
            this.btnGetHtml.UseVisualStyleBackColor = true;
            this.btnGetHtml.Click += new System.EventHandler(this.btnGetHtml_Click);
            // 
            // rtbHtmlContent
            // 
            this.rtbHtmlContent.Location = new System.Drawing.Point(13, 72);
            this.rtbHtmlContent.Name = "rtbHtmlContent";
            this.rtbHtmlContent.Size = new System.Drawing.Size(775, 366);
            this.rtbHtmlContent.TabIndex = 2;
            this.rtbHtmlContent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbHtmlContent);
            this.Controls.Add(this.btnGetHtml);
            this.Controls.Add(this.txtUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
