namespace PracticeApplication
{
    partial class TestForm
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
            this.RunFunctionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunFunctionButton
            // 
            this.RunFunctionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RunFunctionButton.Location = new System.Drawing.Point(159, 86);
            this.RunFunctionButton.Name = "RunFunctionButton";
            this.RunFunctionButton.Size = new System.Drawing.Size(467, 77);
            this.RunFunctionButton.TabIndex = 0;
            this.RunFunctionButton.Text = "Run Function";
            this.RunFunctionButton.UseVisualStyleBackColor = true;
            this.RunFunctionButton.Click += new System.EventHandler(this.RunFunctionButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunFunctionButton);
            this.Name = "TestForm";
            this.Text = "Test Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunFunctionButton;
    }
}
