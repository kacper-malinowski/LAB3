namespace ImageProcessing {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            originalPicture = new PictureBox();
            negativeBox = new PictureBox();
            desaturatedBox = new PictureBox();
            satanizedBox = new PictureBox();
            thresholdedBox = new PictureBox();
            loadButton = new Button();
            processButton = new Button();
            openFileDialogImage = new OpenFileDialog();
            loadLabel = new Label();
            desaturizedLabel = new Label();
            negativeLaber = new Label();
            satanizedLabel = new Label();
            thresholdedLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)originalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negativeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desaturatedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)satanizedBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thresholdedBox).BeginInit();
            SuspendLayout();
            // 
            // originalPicture
            // 
            originalPicture.BorderStyle = BorderStyle.FixedSingle;
            originalPicture.Location = new Point(12, 191);
            originalPicture.Name = "originalPicture";
            originalPicture.Size = new Size(350, 350);
            originalPicture.TabIndex = 0;
            originalPicture.TabStop = false;
            // 
            // negativeBox
            // 
            negativeBox.BorderStyle = BorderStyle.FixedSingle;
            negativeBox.Location = new Point(790, 12);
            negativeBox.Name = "negativeBox";
            negativeBox.Size = new Size(350, 350);
            negativeBox.TabIndex = 1;
            negativeBox.TabStop = false;
            // 
            // desaturatedBox
            // 
            desaturatedBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            desaturatedBox.BorderStyle = BorderStyle.FixedSingle;
            desaturatedBox.Location = new Point(434, 12);
            desaturatedBox.Name = "desaturatedBox";
            desaturatedBox.Size = new Size(350, 350);
            desaturatedBox.TabIndex = 2;
            desaturatedBox.TabStop = false;
            // 
            // satanizedBox
            // 
            satanizedBox.BorderStyle = BorderStyle.FixedSingle;
            satanizedBox.Location = new Point(434, 368);
            satanizedBox.Name = "satanizedBox";
            satanizedBox.Size = new Size(350, 350);
            satanizedBox.TabIndex = 3;
            satanizedBox.TabStop = false;
            // 
            // thresholdedBox
            // 
            thresholdedBox.BorderStyle = BorderStyle.FixedSingle;
            thresholdedBox.Location = new Point(790, 368);
            thresholdedBox.Name = "thresholdedBox";
            thresholdedBox.Size = new Size(350, 350);
            thresholdedBox.TabIndex = 4;
            thresholdedBox.TabStop = false;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(368, 288);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(60, 74);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // processButton
            // 
            processButton.Location = new Point(368, 368);
            processButton.Name = "processButton";
            processButton.Size = new Size(60, 74);
            processButton.TabIndex = 6;
            processButton.Text = "Process";
            processButton.UseVisualStyleBackColor = true;
            processButton.Click += processButton_Click;
            // 
            // openFileDialogImage
            // 
            openFileDialogImage.FileName = "openFileDialogImage";
            // 
            // loadLabel
            // 
            loadLabel.AutoSize = true;
            loadLabel.Font = new Font("Segoe UI", 14F);
            loadLabel.Location = new Point(34, 353);
            loadLabel.Name = "loadLabel";
            loadLabel.Size = new Size(314, 25);
            loadLabel.TabIndex = 7;
            loadLabel.Text = "Load image using the \"Load\" button";
            // 
            // desaturizedLabel
            // 
            desaturizedLabel.AutoSize = true;
            desaturizedLabel.Font = new Font("Segoe UI", 14F);
            desaturizedLabel.Location = new Point(550, 172);
            desaturizedLabel.Name = "desaturizedLabel";
            desaturizedLabel.Size = new Size(112, 25);
            desaturizedLabel.TabIndex = 8;
            desaturizedLabel.Text = "Desaturized";
            // 
            // negativeLaber
            // 
            negativeLaber.AutoSize = true;
            negativeLaber.Font = new Font("Segoe UI", 14F);
            negativeLaber.Location = new Point(931, 172);
            negativeLaber.Name = "negativeLaber";
            negativeLaber.Size = new Size(87, 25);
            negativeLaber.TabIndex = 9;
            negativeLaber.Text = "Negative";
            // 
            // satanizedLabel
            // 
            satanizedLabel.AutoSize = true;
            satanizedLabel.Font = new Font("Segoe UI", 14F);
            satanizedLabel.Location = new Point(559, 529);
            satanizedLabel.Name = "satanizedLabel";
            satanizedLabel.Size = new Size(94, 25);
            satanizedLabel.TabIndex = 10;
            satanizedLabel.Text = "Satanized";
            // 
            // thresholdedLabel
            // 
            thresholdedLabel.AutoSize = true;
            thresholdedLabel.Font = new Font("Segoe UI", 14F);
            thresholdedLabel.Location = new Point(919, 529);
            thresholdedLabel.Name = "thresholdedLabel";
            thresholdedLabel.Size = new Size(117, 25);
            thresholdedLabel.TabIndex = 11;
            thresholdedLabel.Text = "Thresholded";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 729);
            Controls.Add(thresholdedLabel);
            Controls.Add(satanizedLabel);
            Controls.Add(negativeLaber);
            Controls.Add(desaturizedLabel);
            Controls.Add(loadLabel);
            Controls.Add(processButton);
            Controls.Add(loadButton);
            Controls.Add(thresholdedBox);
            Controls.Add(satanizedBox);
            Controls.Add(desaturatedBox);
            Controls.Add(negativeBox);
            Controls.Add(originalPicture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)originalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)negativeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)desaturatedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)satanizedBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)thresholdedBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox originalPicture;
        private PictureBox pictureBox2;
        private PictureBox desaturatedBox;
        private PictureBox satanizedBox;
        private PictureBox thresholdedBox;
        private Button loadButton;
        private Button processButton;
        private OpenFileDialog openFileDialogImage;
        private PictureBox negativeBox;
        private Label loadLabel;
        private Label desaturizedLabel;
        private Label negativeLaber;
        private Label satanizedLabel;
        private Label thresholdedLabel;
    }
}
