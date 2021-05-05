
namespace @new
{
    partial class form1
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.divisibleOutput = new System.Windows.Forms.Label();
            this.positiveOutput = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.BackColor = System.Drawing.Color.Transparent;
            this.integerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerLabel.Location = new System.Drawing.Point(84, 103);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(178, 29);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an integer";
            // 
            // divisibleOutput
            // 
            this.divisibleOutput.BackColor = System.Drawing.Color.White;
            this.divisibleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisibleOutput.Location = new System.Drawing.Point(84, 307);
            this.divisibleOutput.Name = "divisibleOutput";
            this.divisibleOutput.Size = new System.Drawing.Size(395, 29);
            this.divisibleOutput.TabIndex = 1;
            // 
            // positiveOutput
            // 
            this.positiveOutput.BackColor = System.Drawing.Color.White;
            this.positiveOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveOutput.Location = new System.Drawing.Point(84, 247);
            this.positiveOutput.Name = "positiveOutput";
            this.positiveOutput.Size = new System.Drawing.Size(395, 29);
            this.positiveOutput.TabIndex = 2;
            // 
            // integerInput
            // 
            this.integerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerInput.Location = new System.Drawing.Point(328, 100);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 35);
            this.integerInput.TabIndex = 3;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.SandyBrown;
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(510, 95);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(119, 45);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.positiveOutput);
            this.Controls.Add(this.divisibleOutput);
            this.Controls.Add(this.integerLabel);
            this.Name = "form1";
            this.Text = "Am I Positive?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Label divisibleOutput;
        private System.Windows.Forms.Label positiveOutput;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button enterButton;
    }
}

