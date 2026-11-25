namespace ActividadFormularios
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
            btnm = new Button();
            SuspendLayout();
            // 
            // btnm
            // 
            btnm.Location = new Point(545, 163);
            btnm.Name = "btnm";
            btnm.Size = new Size(112, 34);
            btnm.TabIndex = 0;
            btnm.Text = "saludar";
            btnm.UseVisualStyleBackColor = true;
            btnm.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnm);
            Name = "Form1";
            Text = "Bienvenida";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnm;
    }
}
