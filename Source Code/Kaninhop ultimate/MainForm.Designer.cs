namespace Kaninhop_ultimate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AInputTextBox = new System.Windows.Forms.TextBox();
            this.BInputTextBox = new System.Windows.Forms.TextBox();
            this.CInputTextBox = new System.Windows.Forms.TextBox();
            this._cInputTextBox = new System.Windows.Forms.TextBox();
            this._bInputTextBox = new System.Windows.Forms.TextBox();
            this._aInputTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CalculationsTextBox = new System.Windows.Forms.TextBox();
            this.SidesLabel = new System.Windows.Forms.Label();
            this.AngelsLabel = new System.Windows.Forms.Label();
            this._aInputLabel = new System.Windows.Forms.Label();
            this._bInputLabel = new System.Windows.Forms.Label();
            this._cInputLabel = new System.Windows.Forms.Label();
            this.CInputLabel = new System.Windows.Forms.Label();
            this.BInputLabel = new System.Windows.Forms.Label();
            this.AInputLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CalculationsTextBoxLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.TopLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.RoundToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoundToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoundToNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AInputTextBox
            // 
            this.AInputTextBox.Location = new System.Drawing.Point(85, 143);
            this.AInputTextBox.Name = "AInputTextBox";
            this.AInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.AInputTextBox.TabIndex = 4;
            this.AInputTextBox.Text = "0";
            this.AInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // BInputTextBox
            // 
            this.BInputTextBox.Location = new System.Drawing.Point(191, 143);
            this.BInputTextBox.Name = "BInputTextBox";
            this.BInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.BInputTextBox.TabIndex = 5;
            this.BInputTextBox.Text = "0";
            this.BInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // CInputTextBox
            // 
            this.CInputTextBox.Location = new System.Drawing.Point(297, 143);
            this.CInputTextBox.Name = "CInputTextBox";
            this.CInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.CInputTextBox.TabIndex = 6;
            this.CInputTextBox.Text = "0";
            this.CInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // _cInputTextBox
            // 
            this._cInputTextBox.Location = new System.Drawing.Point(297, 98);
            this._cInputTextBox.Name = "_cInputTextBox";
            this._cInputTextBox.Size = new System.Drawing.Size(100, 20);
            this._cInputTextBox.TabIndex = 3;
            this._cInputTextBox.Text = "0";
            this._cInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // _bInputTextBox
            // 
            this._bInputTextBox.Location = new System.Drawing.Point(191, 98);
            this._bInputTextBox.Name = "_bInputTextBox";
            this._bInputTextBox.Size = new System.Drawing.Size(100, 20);
            this._bInputTextBox.TabIndex = 2;
            this._bInputTextBox.Text = "0";
            this._bInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // _aInputTextBox
            // 
            this._aInputTextBox.Location = new System.Drawing.Point(85, 98);
            this._aInputTextBox.Name = "_aInputTextBox";
            this._aInputTextBox.Size = new System.Drawing.Size(100, 20);
            this._aInputTextBox.TabIndex = 1;
            this._aInputTextBox.Text = "0";
            this._aInputTextBox.TextChanged += new System.EventHandler(this.Information_Changed);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(403, 84);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(132, 46);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CalculationsTextBox
            // 
            this.CalculationsTextBox.Location = new System.Drawing.Point(555, 40);
            this.CalculationsTextBox.Multiline = true;
            this.CalculationsTextBox.Name = "CalculationsTextBox";
            this.CalculationsTextBox.ReadOnly = true;
            this.CalculationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CalculationsTextBox.Size = new System.Drawing.Size(303, 202);
            this.CalculationsTextBox.TabIndex = 9;
            // 
            // SidesLabel
            // 
            this.SidesLabel.AutoSize = true;
            this.SidesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidesLabel.Location = new System.Drawing.Point(17, 98);
            this.SidesLabel.Name = "SidesLabel";
            this.SidesLabel.Size = new System.Drawing.Size(49, 20);
            this.SidesLabel.TabIndex = 8;
            this.SidesLabel.Text = "Sides";
            // 
            // AngelsLabel
            // 
            this.AngelsLabel.AutoSize = true;
            this.AngelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngelsLabel.Location = new System.Drawing.Point(17, 143);
            this.AngelsLabel.Name = "AngelsLabel";
            this.AngelsLabel.Size = new System.Drawing.Size(58, 20);
            this.AngelsLabel.TabIndex = 9;
            this.AngelsLabel.Text = "Angels";
            // 
            // _aInputLabel
            // 
            this._aInputLabel.AutoSize = true;
            this._aInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._aInputLabel.Location = new System.Drawing.Point(120, 72);
            this._aInputLabel.Name = "_aInputLabel";
            this._aInputLabel.Size = new System.Drawing.Size(18, 20);
            this._aInputLabel.TabIndex = 10;
            this._aInputLabel.Text = "a";
            // 
            // _bInputLabel
            // 
            this._bInputLabel.AutoSize = true;
            this._bInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bInputLabel.Location = new System.Drawing.Point(230, 70);
            this._bInputLabel.Name = "_bInputLabel";
            this._bInputLabel.Size = new System.Drawing.Size(18, 20);
            this._bInputLabel.TabIndex = 11;
            this._bInputLabel.Text = "b";
            // 
            // _cInputLabel
            // 
            this._cInputLabel.AutoSize = true;
            this._cInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cInputLabel.Location = new System.Drawing.Point(334, 69);
            this._cInputLabel.Name = "_cInputLabel";
            this._cInputLabel.Size = new System.Drawing.Size(17, 20);
            this._cInputLabel.TabIndex = 12;
            this._cInputLabel.Text = "c";
            // 
            // CInputLabel
            // 
            this.CInputLabel.AutoSize = true;
            this.CInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CInputLabel.Location = new System.Drawing.Point(334, 119);
            this.CInputLabel.Name = "CInputLabel";
            this.CInputLabel.Size = new System.Drawing.Size(20, 20);
            this.CInputLabel.TabIndex = 15;
            this.CInputLabel.Text = "C";
            // 
            // BInputLabel
            // 
            this.BInputLabel.AutoSize = true;
            this.BInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInputLabel.Location = new System.Drawing.Point(230, 120);
            this.BInputLabel.Name = "BInputLabel";
            this.BInputLabel.Size = new System.Drawing.Size(20, 20);
            this.BInputLabel.TabIndex = 14;
            this.BInputLabel.Text = "B";
            // 
            // AInputLabel
            // 
            this.AInputLabel.AutoSize = true;
            this.AInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AInputLabel.Location = new System.Drawing.Point(120, 122);
            this.AInputLabel.Name = "AInputLabel";
            this.AInputLabel.Size = new System.Drawing.Size(20, 20);
            this.AInputLabel.TabIndex = 13;
            this.AInputLabel.Text = "A";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.Location = new System.Drawing.Point(17, 180);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(282, 16);
            this.InformationLabel.TabIndex = 16;
            this.InformationLabel.Text = "Surface Area: 0 Circumference: 0 Angle Sum: 0";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllButton.Location = new System.Drawing.Point(403, 129);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(132, 46);
            this.ClearAllButton.TabIndex = 8;
            this.ClearAllButton.Text = "Clear all";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // CalculationsTextBoxLabel
            // 
            this.CalculationsTextBoxLabel.AutoSize = true;
            this.CalculationsTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationsTextBoxLabel.Location = new System.Drawing.Point(644, 9);
            this.CalculationsTextBoxLabel.Name = "CalculationsTextBoxLabel";
            this.CalculationsTextBoxLabel.Size = new System.Drawing.Size(130, 25);
            this.CalculationsTextBoxLabel.TabIndex = 18;
            this.CalculationsTextBoxLabel.Text = "Calculations";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(18, 51);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 19;
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.ForeColor = System.Drawing.Color.Black;
            this.TopLabel.Location = new System.Drawing.Point(156, 3);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(252, 31);
            this.TopLabel.TabIndex = 20;
            this.TopLabel.Text = "Kaninhop Ultimate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "© Kristian Skov Johansen";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.DescriptionLabel.Location = new System.Drawing.Point(155, 35);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(254, 15);
            this.DescriptionLabel.TabIndex = 22;
            this.DescriptionLabel.Text = "Input three known values, and press calculate";
            // 
            // RoundToNumericUpDown
            // 
            this.RoundToNumericUpDown.Location = new System.Drawing.Point(476, 7);
            this.RoundToNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RoundToNumericUpDown.Name = "RoundToNumericUpDown";
            this.RoundToNumericUpDown.Size = new System.Drawing.Size(61, 20);
            this.RoundToNumericUpDown.TabIndex = 23;
            this.RoundToNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RoundToNumericUpDown.ValueChanged += new System.EventHandler(this.RoundToNumericUpDown_ValueChanged);
            // 
            // RoundToLabel
            // 
            this.RoundToLabel.AutoSize = true;
            this.RoundToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundToLabel.ForeColor = System.Drawing.Color.Black;
            this.RoundToLabel.Location = new System.Drawing.Point(414, 9);
            this.RoundToLabel.Name = "RoundToLabel";
            this.RoundToLabel.Size = new System.Drawing.Size(60, 15);
            this.RoundToLabel.TabIndex = 24;
            this.RoundToLabel.Text = "Round to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 247);
            this.Controls.Add(this.RoundToLabel);
            this.Controls.Add(this.RoundToNumericUpDown);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.CalculationsTextBoxLabel);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.CInputLabel);
            this.Controls.Add(this.BInputLabel);
            this.Controls.Add(this.AInputLabel);
            this.Controls.Add(this._cInputLabel);
            this.Controls.Add(this._bInputLabel);
            this.Controls.Add(this._aInputLabel);
            this.Controls.Add(this.AngelsLabel);
            this.Controls.Add(this.SidesLabel);
            this.Controls.Add(this.CalculationsTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this._cInputTextBox);
            this.Controls.Add(this._bInputTextBox);
            this.Controls.Add(this._aInputTextBox);
            this.Controls.Add(this.CInputTextBox);
            this.Controls.Add(this.BInputTextBox);
            this.Controls.Add(this.AInputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(890, 290);
            this.MinimumSize = new System.Drawing.Size(890, 290);
            this.Name = "Form1";
            this.Text = "Kaninhop Ultimate";
            ((System.ComponentModel.ISupportInitialize)(this.RoundToNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AInputTextBox;
        private System.Windows.Forms.TextBox BInputTextBox;
        private System.Windows.Forms.TextBox CInputTextBox;
        private System.Windows.Forms.TextBox _cInputTextBox;
        private System.Windows.Forms.TextBox _bInputTextBox;
        private System.Windows.Forms.TextBox _aInputTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox CalculationsTextBox;
        private System.Windows.Forms.Label SidesLabel;
        private System.Windows.Forms.Label AngelsLabel;
        private System.Windows.Forms.Label _aInputLabel;
        private System.Windows.Forms.Label _bInputLabel;
        private System.Windows.Forms.Label _cInputLabel;
        private System.Windows.Forms.Label CInputLabel;
        private System.Windows.Forms.Label BInputLabel;
        private System.Windows.Forms.Label AInputLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label CalculationsTextBoxLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.NumericUpDown RoundToNumericUpDown;
        private System.Windows.Forms.Label RoundToLabel;
    }
}

