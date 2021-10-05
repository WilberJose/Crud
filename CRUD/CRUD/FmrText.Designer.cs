
namespace CRUD
{
    partial class FmrText
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
            this.btntext = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btntext
            // 
            this.btntext.Location = new System.Drawing.Point(252, 202);
            this.btntext.Name = "btntext";
            this.btntext.Size = new System.Drawing.Size(276, 84);
            this.btntext.TabIndex = 0;
            this.btntext.Text = "text";
            this.btntext.UseSelectable = true;
            this.btntext.Click += new System.EventHandler(this.btntext_Click);
            // 
            // FmrText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntext);
            this.Name = "FmrText";
            this.Text = "FmrText";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btntext;
    }
}