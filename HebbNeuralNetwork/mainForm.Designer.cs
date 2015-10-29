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
            this.standartInputPanel = new System.Windows.Forms.Panel();
            this.outputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.userInputPanel = new System.Windows.Forms.Panel();
            this.inputDataGroupBox.SuspendLayout();
            this.outputDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataGroupBox
            // 
            this.inputDataGroupBox.Controls.Add(this.standartInputPanel);
            this.inputDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputDataGroupBox.Name = "inputDataGroupBox";
            this.inputDataGroupBox.Size = new System.Drawing.Size(460, 150);
            this.inputDataGroupBox.TabIndex = 0;
            this.inputDataGroupBox.TabStop = false;
            this.inputDataGroupBox.Text = "Input";
            // 
            // standartInputPanel
            // 
            this.standartInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standartInputPanel.AutoScroll = true;
            this.standartInputPanel.Location = new System.Drawing.Point(6, 19);
            this.standartInputPanel.Name = "standartInputPanel";
            this.standartInputPanel.Size = new System.Drawing.Size(448, 125);
            this.standartInputPanel.TabIndex = 0;
            // 
            // outputDataGroupBox
            // 
            this.outputDataGroupBox.Controls.Add(this.userInputPanel);
            this.outputDataGroupBox.Location = new System.Drawing.Point(478, 12);
            this.outputDataGroupBox.Name = "outputDataGroupBox";
            this.outputDataGroupBox.Size = new System.Drawing.Size(100, 150);
            this.outputDataGroupBox.TabIndex = 1;
            this.outputDataGroupBox.TabStop = false;
            this.outputDataGroupBox.Text = "Output";
            // 
            // userInputPanel
            // 
            this.userInputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputPanel.Location = new System.Drawing.Point(6, 19);
            this.userInputPanel.Name = "userInputPanel";
            this.userInputPanel.Size = new System.Drawing.Size(88, 125);
            this.userInputPanel.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 468);
            this.Controls.Add(this.outputDataGroupBox);
            this.Controls.Add(this.inputDataGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Hebb Neural Network";
            this.inputDataGroupBox.ResumeLayout(false);
            this.outputDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.Panel standartInputPanel;
        private System.Windows.Forms.GroupBox outputDataGroupBox;
        private System.Windows.Forms.Panel userInputPanel;

    }
}

