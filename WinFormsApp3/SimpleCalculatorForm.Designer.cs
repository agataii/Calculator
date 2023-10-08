namespace WinFormsApp3
{
    partial class SimpleCalculatorForm
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
            this._monitorLabel = new System.Windows.Forms.Label();
            this._monitorInfoLabel = new System.Windows.Forms.Label();
            this._plusMinusButton = new System.Windows.Forms.Button();
            this._button0 = new System.Windows.Forms.Button();
            this._dotButton = new System.Windows.Forms.Button();
            this._equalButton = new System.Windows.Forms.Button();
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._button3 = new System.Windows.Forms.Button();
            this._plusButton = new System.Windows.Forms.Button();
            this._button4 = new System.Windows.Forms.Button();
            this._button5 = new System.Windows.Forms.Button();
            this._button6 = new System.Windows.Forms.Button();
            this._minusButton = new System.Windows.Forms.Button();
            this._button7 = new System.Windows.Forms.Button();
            this._button8 = new System.Windows.Forms.Button();
            this._button9 = new System.Windows.Forms.Button();
            this._divideButton = new System.Windows.Forms.Button();
            this._percentButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this._backspaceButton = new System.Windows.Forms.Button();
            this._multiplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _monitorLabel
            // 
            this._monitorLabel.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._monitorLabel.Location = new System.Drawing.Point(12, 65);
            this._monitorLabel.Name = "_monitorLabel";
            this._monitorLabel.Size = new System.Drawing.Size(318, 73);
            this._monitorLabel.TabIndex = 0;
            this._monitorLabel.Text = "0";
            this._monitorLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // _monitorInfoLabel
            // 
            this._monitorInfoLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._monitorInfoLabel.Location = new System.Drawing.Point(11, 9);
            this._monitorInfoLabel.Name = "_monitorInfoLabel";
            this._monitorInfoLabel.Size = new System.Drawing.Size(318, 56);
            this._monitorInfoLabel.TabIndex = 0;
            this._monitorInfoLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // _plusMinusButton
            // 
            this._plusMinusButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._plusMinusButton.Location = new System.Drawing.Point(12, 474);
            this._plusMinusButton.Name = "_plusMinusButton";
            this._plusMinusButton.Size = new System.Drawing.Size(75, 75);
            this._plusMinusButton.TabIndex = 1;
            this._plusMinusButton.Text = "+/-";
            this._plusMinusButton.UseVisualStyleBackColor = true;
            this._plusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // _button0
            // 
            this._button0.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button0.Location = new System.Drawing.Point(93, 474);
            this._button0.Name = "_button0";
            this._button0.Size = new System.Drawing.Size(75, 75);
            this._button0.TabIndex = 1;
            this._button0.Text = "0";
            this._button0.UseVisualStyleBackColor = true;
            this._button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // _dotButton
            // 
            this._dotButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._dotButton.Location = new System.Drawing.Point(174, 474);
            this._dotButton.Name = "_dotButton";
            this._dotButton.Size = new System.Drawing.Size(75, 75);
            this._dotButton.TabIndex = 1;
            this._dotButton.Text = ".";
            this._dotButton.UseVisualStyleBackColor = true;
            this._dotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // _equalButton
            // 
            this._equalButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._equalButton.Location = new System.Drawing.Point(255, 474);
            this._equalButton.Name = "_equalButton";
            this._equalButton.Size = new System.Drawing.Size(75, 75);
            this._equalButton.TabIndex = 1;
            this._equalButton.Text = "=";
            this._equalButton.UseVisualStyleBackColor = true;
            this._equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // _button1
            // 
            this._button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button1.Location = new System.Drawing.Point(12, 393);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(75, 75);
            this._button1.TabIndex = 1;
            this._button1.Text = "1";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // _button2
            // 
            this._button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button2.Location = new System.Drawing.Point(93, 393);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(75, 75);
            this._button2.TabIndex = 1;
            this._button2.Text = "2";
            this._button2.UseVisualStyleBackColor = true;
            this._button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // _button3
            // 
            this._button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button3.Location = new System.Drawing.Point(174, 393);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(75, 75);
            this._button3.TabIndex = 1;
            this._button3.Text = "3";
            this._button3.UseVisualStyleBackColor = true;
            this._button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // _plusButton
            // 
            this._plusButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._plusButton.Location = new System.Drawing.Point(255, 393);
            this._plusButton.Name = "_plusButton";
            this._plusButton.Size = new System.Drawing.Size(75, 75);
            this._plusButton.TabIndex = 1;
            this._plusButton.Text = "+";
            this._plusButton.UseVisualStyleBackColor = true;
            this._plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // _button4
            // 
            this._button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button4.Location = new System.Drawing.Point(12, 312);
            this._button4.Name = "_button4";
            this._button4.Size = new System.Drawing.Size(75, 75);
            this._button4.TabIndex = 1;
            this._button4.Text = "4";
            this._button4.UseVisualStyleBackColor = true;
            this._button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // _button5
            // 
            this._button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button5.Location = new System.Drawing.Point(93, 312);
            this._button5.Name = "_button5";
            this._button5.Size = new System.Drawing.Size(75, 75);
            this._button5.TabIndex = 1;
            this._button5.Text = "5";
            this._button5.UseVisualStyleBackColor = true;
            this._button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // _button6
            // 
            this._button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button6.Location = new System.Drawing.Point(174, 312);
            this._button6.Name = "_button6";
            this._button6.Size = new System.Drawing.Size(75, 75);
            this._button6.TabIndex = 1;
            this._button6.Text = "6";
            this._button6.UseVisualStyleBackColor = true;
            this._button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // _minusButton
            // 
            this._minusButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._minusButton.Location = new System.Drawing.Point(255, 312);
            this._minusButton.Name = "_minusButton";
            this._minusButton.Size = new System.Drawing.Size(75, 75);
            this._minusButton.TabIndex = 1;
            this._minusButton.Text = "-";
            this._minusButton.UseVisualStyleBackColor = true;
            this._minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // _button7
            // 
            this._button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button7.Location = new System.Drawing.Point(12, 231);
            this._button7.Name = "_button7";
            this._button7.Size = new System.Drawing.Size(75, 75);
            this._button7.TabIndex = 1;
            this._button7.Text = "7";
            this._button7.UseVisualStyleBackColor = true;
            this._button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // _button8
            // 
            this._button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button8.Location = new System.Drawing.Point(93, 231);
            this._button8.Name = "_button8";
            this._button8.Size = new System.Drawing.Size(75, 75);
            this._button8.TabIndex = 1;
            this._button8.Text = "8";
            this._button8.UseVisualStyleBackColor = true;
            this._button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // _button9
            // 
            this._button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._button9.Location = new System.Drawing.Point(174, 231);
            this._button9.Name = "_button9";
            this._button9.Size = new System.Drawing.Size(75, 75);
            this._button9.TabIndex = 1;
            this._button9.Text = "9";
            this._button9.UseVisualStyleBackColor = true;
            this._button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // _divideButton
            // 
            this._divideButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._divideButton.Location = new System.Drawing.Point(255, 231);
            this._divideButton.Name = "_divideButton";
            this._divideButton.Size = new System.Drawing.Size(75, 75);
            this._divideButton.TabIndex = 1;
            this._divideButton.Text = "/";
            this._divideButton.UseVisualStyleBackColor = true;
            this._divideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // _percentButton
            // 
            this._percentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._percentButton.Location = new System.Drawing.Point(12, 150);
            this._percentButton.Name = "_percentButton";
            this._percentButton.Size = new System.Drawing.Size(75, 75);
            this._percentButton.TabIndex = 1;
            this._percentButton.Text = "%";
            this._percentButton.UseVisualStyleBackColor = true;
            this._percentButton.Click += new System.EventHandler(this._percentButton_Click);
            // 
            // _clearButton
            // 
            this._clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._clearButton.Location = new System.Drawing.Point(93, 150);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(75, 75);
            this._clearButton.TabIndex = 1;
            this._clearButton.Text = "C";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this.СlearButton_Click);
            // 
            // _backspaceButton
            // 
            this._backspaceButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._backspaceButton.Location = new System.Drawing.Point(174, 150);
            this._backspaceButton.Name = "_backspaceButton";
            this._backspaceButton.Size = new System.Drawing.Size(75, 75);
            this._backspaceButton.TabIndex = 1;
            this._backspaceButton.Text = "<-";
            this._backspaceButton.UseVisualStyleBackColor = true;
            this._backspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // _multiplyButton
            // 
            this._multiplyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._multiplyButton.Location = new System.Drawing.Point(255, 150);
            this._multiplyButton.Name = "_multiplyButton";
            this._multiplyButton.Size = new System.Drawing.Size(75, 75);
            this._multiplyButton.TabIndex = 1;
            this._multiplyButton.Text = "*";
            this._multiplyButton.UseVisualStyleBackColor = true;
            this._multiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SimpleCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 563);
            this.Controls.Add(this._multiplyButton);
            this.Controls.Add(this._divideButton);
            this.Controls.Add(this._minusButton);
            this.Controls.Add(this._plusButton);
            this.Controls.Add(this._equalButton);
            this.Controls.Add(this._backspaceButton);
            this.Controls.Add(this._button9);
            this.Controls.Add(this._button6);
            this.Controls.Add(this._button3);
            this.Controls.Add(this._clearButton);
            this.Controls.Add(this._dotButton);
            this.Controls.Add(this._button8);
            this.Controls.Add(this._button5);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._percentButton);
            this.Controls.Add(this._button0);
            this.Controls.Add(this._button7);
            this.Controls.Add(this._button4);
            this.Controls.Add(this._button1);
            this.Controls.Add(this._plusMinusButton);
            this.Controls.Add(this._monitorInfoLabel);
            this.Controls.Add(this._monitorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SimpleCalculatorForm";
            this.Text = "Обычный калькулятор";
            this.ResumeLayout(false);

        }

        #endregion

        private Label _monitorLabel;
        private Label _monitorInfoLabel;
        private Button _plusMinusButton;
        private Button _button0;
        private Button _dotButton;
        private Button _equalButton;
        private Button _button1;
        private Button _button2;
        private Button _button3;
        private Button _plusButton;
        private Button _button4;
        private Button _button5;
        private Button _button6;
        private Button _minusButton;
        private Button _button7;
        private Button _button8;
        private Button _button9;
        private Button _divideButton;
        private Button _percentButton;
        private Button _clearButton;
        private Button _backspaceButton;
        private Button _multiplyButton;
    }
}