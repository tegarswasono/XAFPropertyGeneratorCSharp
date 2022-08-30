
namespace XAFPropertyGeneratorCSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.bGenerate = new System.Windows.Forms.Button();
            this.rtbDestination = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSource
            // 
            this.rtbSource.Location = new System.Drawing.Point(41, 51);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(917, 273);
            this.rtbSource.TabIndex = 0;
            this.rtbSource.Text = "";
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(41, 356);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(917, 34);
            this.bGenerate.TabIndex = 1;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // rtbDestination
            // 
            this.rtbDestination.Location = new System.Drawing.Point(41, 428);
            this.rtbDestination.Name = "rtbDestination";
            this.rtbDestination.Size = new System.Drawing.Size(917, 273);
            this.rtbDestination.TabIndex = 2;
            this.rtbDestination.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 768);
            this.Controls.Add(this.rtbDestination);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.rtbSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.RichTextBox rtbDestination;
    }
}

