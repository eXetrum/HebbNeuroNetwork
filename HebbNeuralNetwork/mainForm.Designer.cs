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
            this.btnTrain = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.btnRecognize = new System.Windows.Forms.Button();
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
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(12, 168);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 197);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(560, 151);
            this.log.TabIndex = 3;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Enabled = false;
            this.btnRecognize.Location = new System.Drawing.Point(503, 168);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(75, 23);
            this.btnRecognize.TabIndex = 4;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 468);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.log);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.outputDataGroupBox);
            this.Controls.Add(this.inputDataGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "Hebb Neural Network";
            this.inputDataGroupBox.ResumeLayout(false);
            this.outputDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputDataGroupBox;
        private System.Windows.Forms.Panel standartInputPanel;
        private System.Windows.Forms.GroupBox outputDataGroupBox;
        private System.Windows.Forms.Panel userInputPanel;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button btnRecognize;

    }
}

