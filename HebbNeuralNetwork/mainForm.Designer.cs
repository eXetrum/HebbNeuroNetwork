namespace HebbNeuralNetwork
{
    partial class mainForm
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
            this.inputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.inputPanel);
            this.inputDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Size = new System.Drawing.Size(440, 140);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Input";
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPanel.AutoScroll = true;
            this.inputPanel.Location = new System.Drawing.Point(6, 19);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(428, 115);
            this.inputPanel.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 468);
            this.Controls.Add(this.inputDataGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Hebb Neural Network";
            this.inputDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.Panel inputPanel;

    }
}

