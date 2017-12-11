namespace LuaCtoIceSkid
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
            this.In = new System.Windows.Forms.RichTextBox();
            this.Out = new System.Windows.Forms.RichTextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(12, 12);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(276, 364);
            this.In.TabIndex = 0;
            this.In.Text = "";
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(335, 12);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(286, 364);
            this.Out.TabIndex = 1;
            this.Out.Text = "";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(274, 382);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 417);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.In);
            this.Name = "Form1";
            this.Text = "Lua C to Ice C";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox In;
        private System.Windows.Forms.RichTextBox Out;
        private System.Windows.Forms.Button Convert;
    }
}

