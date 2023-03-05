namespace QuadraticEquation
{
    partial class QuadraticEquation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuadraticEquation));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InitValueGroupBox = new System.Windows.Forms.GroupBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ALabel = new System.Windows.Forms.Label();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.X2Label = new System.Windows.Forms.Label();
            this.X1Label = new System.Windows.Forms.Label();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.InitValueGroupBox.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.ControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitValueGroupBox
            // 
            this.InitValueGroupBox.Controls.Add(this.CTextBox);
            this.InitValueGroupBox.Controls.Add(this.BTextBox);
            this.InitValueGroupBox.Controls.Add(this.ATextBox);
            this.InitValueGroupBox.Controls.Add(this.CLabel);
            this.InitValueGroupBox.Controls.Add(this.BLabel);
            this.InitValueGroupBox.Controls.Add(this.ALabel);
            this.InitValueGroupBox.Location = new System.Drawing.Point(12, 24);
            this.InitValueGroupBox.Name = "InitValueGroupBox";
            this.InitValueGroupBox.Size = new System.Drawing.Size(258, 189);
            this.InitValueGroupBox.TabIndex = 0;
            this.InitValueGroupBox.TabStop = false;
            this.InitValueGroupBox.Tag = "";
            this.InitValueGroupBox.Text = "Исходные данные";
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(53, 139);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(161, 27);
            this.CTextBox.TabIndex = 5;
            this.CTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABC_KeyPress);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(53, 88);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(161, 27);
            this.BTextBox.TabIndex = 4;
            this.BTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABC_KeyPress);
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(53, 37);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(161, 27);
            this.ATextBox.TabIndex = 3;
            this.ATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ABC_KeyPress);
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(16, 139);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(30, 20);
            this.CLabel.TabIndex = 2;
            this.CLabel.Text = "c =";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(15, 88);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(32, 20);
            this.BLabel.TabIndex = 1;
            this.BLabel.Text = "b =";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(16, 37);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(31, 20);
            this.ALabel.TabIndex = 0;
            this.ALabel.Text = "a =";
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResultGroupBox.Controls.Add(this.X2TextBox);
            this.ResultGroupBox.Controls.Add(this.X1TextBox);
            this.ResultGroupBox.Controls.Add(this.X2Label);
            this.ResultGroupBox.Controls.Add(this.X1Label);
            this.ResultGroupBox.Location = new System.Drawing.Point(276, 24);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(344, 189);
            this.ResultGroupBox.TabIndex = 1;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Результат";
            // 
            // X2TextBox
            // 
            this.X2TextBox.Location = new System.Drawing.Point(93, 109);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.ReadOnly = true;
            this.X2TextBox.Size = new System.Drawing.Size(180, 27);
            this.X2TextBox.TabIndex = 3;
            this.X2TextBox.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            // 
            // X1TextBox
            // 
            this.X1TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.X1TextBox.Location = new System.Drawing.Point(93, 57);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.ReadOnly = true;
            this.X1TextBox.Size = new System.Drawing.Size(180, 27);
            this.X1TextBox.TabIndex = 2;
            this.X1TextBox.GotFocus += new System.EventHandler(this.TextBox_GotFocus);
            // 
            // X2Label
            // 
            this.X2Label.AutoSize = true;
            this.X2Label.Location = new System.Drawing.Point(49, 114);
            this.X2Label.Name = "X2Label";
            this.X2Label.Size = new System.Drawing.Size(38, 20);
            this.X2Label.TabIndex = 1;
            this.X2Label.Text = "x2 =";
            // 
            // X1Label
            // 
            this.X1Label.AutoSize = true;
            this.X1Label.Location = new System.Drawing.Point(49, 60);
            this.X1Label.Name = "X1Label";
            this.X1Label.Size = new System.Drawing.Size(38, 20);
            this.X1Label.TabIndex = 0;
            this.X1Label.Text = "x1 =";
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.CalcBtn);
            this.ControlGroupBox.Controls.Add(this.ClrBtn);
            this.ControlGroupBox.Controls.Add(this.radioButton3);
            this.ControlGroupBox.Controls.Add(this.radioButton2);
            this.ControlGroupBox.Controls.Add(this.radioButton1);
            this.ControlGroupBox.Location = new System.Drawing.Point(12, 234);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(608, 193);
            this.ControlGroupBox.TabIndex = 2;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Управление";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(295, 74);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(118, 55);
            this.CalcBtn.TabIndex = 5;
            this.CalcBtn.Text = "Вычислить";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(464, 74);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(118, 55);
            this.ClrBtn.TabIndex = 3;
            this.ClrBtn.Text = "Очистить";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "способ 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "способ 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "способ 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 439);
            this.Controls.Add(this.ControlGroupBox);
            this.Controls.Add(this.ResultGroupBox);
            this.Controls.Add(this.InitValueGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuadraticEquation";
            this.Text = "Quadratic Equation Calculator";
            this.InitValueGroupBox.ResumeLayout(false);
            this.InitValueGroupBox.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
            this.ControlGroupBox.ResumeLayout(false);
            this.ControlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox InitValueGroupBox;
        private GroupBox ResultGroupBox;
        private Label BLabel;
        private Label ALabel;
        private GroupBox ControlGroupBox;
        private Label CLabel;
        private TextBox CTextBox;
        private TextBox BTextBox;
        private TextBox ATextBox;
        private Label X2Label;
        private Label X1Label;
        private TextBox X2TextBox;
        private TextBox X1TextBox;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button CalcBtn;
        private Button ClrBtn;
    }
}