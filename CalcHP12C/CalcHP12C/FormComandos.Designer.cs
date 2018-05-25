namespace CalcHP12C
{
    partial class FormComandos
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
            this.richTextBoxCod = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxCod
            // 
            this.richTextBoxCod.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCod.Location = new System.Drawing.Point(30, 41);
            this.richTextBoxCod.Name = "richTextBoxCod";
            this.richTextBoxCod.Size = new System.Drawing.Size(693, 330);
            this.richTextBoxCod.TabIndex = 0;
            this.richTextBoxCod.Text = "";
            // 
            // FormComandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxCod);
            this.Name = "FormComandos";
            this.Text = "FormComandos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCod;
    }
}