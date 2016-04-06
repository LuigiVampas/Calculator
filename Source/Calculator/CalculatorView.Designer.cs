﻿namespace Calculator
{
    partial class CalculatorView
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
            this.components = new System.ComponentModel.Container();
            this._calculatingString = new System.Windows.Forms.TextBox();
            this._oneButton = new System.Windows.Forms.Button();
            this._fiveButton = new System.Windows.Forms.Button();
            this._threeButton = new System.Windows.Forms.Button();
            this._eightButton = new System.Windows.Forms.Button();
            this._sixButton = new System.Windows.Forms.Button();
            this._nineButton = new System.Windows.Forms.Button();
            this._twoButton = new System.Windows.Forms.Button();
            this._sevenButton = new System.Windows.Forms.Button();
            this._fourButton = new System.Windows.Forms.Button();
            this._zeroButton = new System.Windows.Forms.Button();
            this._resultButton = new System.Windows.Forms.Button();
            this._modButton = new System.Windows.Forms.Button();
            this._powButton = new System.Windows.Forms.Button();
            this._multiplyButton = new System.Windows.Forms.Button();
            this._divideButton = new System.Windows.Forms.Button();
            this._minusButton = new System.Windows.Forms.Button();
            this._plusButton = new System.Windows.Forms.Button();
            this._calculatorViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._calculatorViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _calculatingString
            // 
            this._calculatingString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._calculatingString.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._calculatorViewModelBindingSource, "CalculatingString", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._calculatingString.Location = new System.Drawing.Point(12, 12);
            this._calculatingString.Name = "_calculatingString";
            this._calculatingString.Size = new System.Drawing.Size(347, 20);
            this._calculatingString.TabIndex = 0;
            // 
            // _oneButton
            // 
            this._oneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._oneButton.Location = new System.Drawing.Point(17, 48);
            this._oneButton.Name = "_oneButton";
            this._oneButton.Size = new System.Drawing.Size(45, 39);
            this._oneButton.TabIndex = 1;
            this._oneButton.Text = "1";
            this._oneButton.UseVisualStyleBackColor = true;
            this._oneButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _fiveButton
            // 
            this._fiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._fiveButton.Location = new System.Drawing.Point(68, 92);
            this._fiveButton.Name = "_fiveButton";
            this._fiveButton.Size = new System.Drawing.Size(45, 39);
            this._fiveButton.TabIndex = 5;
            this._fiveButton.Text = "5";
            this._fiveButton.UseVisualStyleBackColor = true;
            this._fiveButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _threeButton
            // 
            this._threeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._threeButton.Location = new System.Drawing.Point(119, 49);
            this._threeButton.Name = "_threeButton";
            this._threeButton.Size = new System.Drawing.Size(45, 39);
            this._threeButton.TabIndex = 3;
            this._threeButton.Text = "3";
            this._threeButton.UseVisualStyleBackColor = true;
            this._threeButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _eightButton
            // 
            this._eightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._eightButton.Location = new System.Drawing.Point(68, 135);
            this._eightButton.Name = "_eightButton";
            this._eightButton.Size = new System.Drawing.Size(45, 39);
            this._eightButton.TabIndex = 8;
            this._eightButton.Text = "8";
            this._eightButton.UseVisualStyleBackColor = true;
            this._eightButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _sixButton
            // 
            this._sixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sixButton.Location = new System.Drawing.Point(119, 92);
            this._sixButton.Name = "_sixButton";
            this._sixButton.Size = new System.Drawing.Size(45, 39);
            this._sixButton.TabIndex = 6;
            this._sixButton.Text = "6";
            this._sixButton.UseVisualStyleBackColor = true;
            this._sixButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _nineButton
            // 
            this._nineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._nineButton.Location = new System.Drawing.Point(119, 135);
            this._nineButton.Name = "_nineButton";
            this._nineButton.Size = new System.Drawing.Size(45, 39);
            this._nineButton.TabIndex = 9;
            this._nineButton.Text = "9";
            this._nineButton.UseVisualStyleBackColor = true;
            this._nineButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _twoButton
            // 
            this._twoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._twoButton.Location = new System.Drawing.Point(68, 49);
            this._twoButton.Name = "_twoButton";
            this._twoButton.Size = new System.Drawing.Size(45, 39);
            this._twoButton.TabIndex = 2;
            this._twoButton.Text = "2";
            this._twoButton.UseVisualStyleBackColor = true;
            this._twoButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _sevenButton
            // 
            this._sevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._sevenButton.Location = new System.Drawing.Point(17, 135);
            this._sevenButton.Name = "_sevenButton";
            this._sevenButton.Size = new System.Drawing.Size(45, 39);
            this._sevenButton.TabIndex = 7;
            this._sevenButton.Text = "7";
            this._sevenButton.UseVisualStyleBackColor = true;
            this._sevenButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _fourButton
            // 
            this._fourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._fourButton.Location = new System.Drawing.Point(17, 92);
            this._fourButton.Name = "_fourButton";
            this._fourButton.Size = new System.Drawing.Size(45, 39);
            this._fourButton.TabIndex = 4;
            this._fourButton.Text = "4";
            this._fourButton.UseVisualStyleBackColor = true;
            this._fourButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _zeroButton
            // 
            this._zeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._zeroButton.Location = new System.Drawing.Point(68, 178);
            this._zeroButton.Name = "_zeroButton";
            this._zeroButton.Size = new System.Drawing.Size(45, 39);
            this._zeroButton.TabIndex = 10;
            this._zeroButton.Text = "0";
            this._zeroButton.UseVisualStyleBackColor = true;
            this._zeroButton.Click += new System.EventHandler(this.InvokeNumberButtonPressed);
            // 
            // _resultButton
            // 
            this._resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._resultButton.Location = new System.Drawing.Point(227, 178);
            this._resultButton.Name = "_resultButton";
            this._resultButton.Size = new System.Drawing.Size(114, 39);
            this._resultButton.TabIndex = 11;
            this._resultButton.Text = "=";
            this._resultButton.UseVisualStyleBackColor = true;
            this._resultButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _modButton
            // 
            this._modButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._modButton.Location = new System.Drawing.Point(296, 135);
            this._modButton.Name = "_modButton";
            this._modButton.Size = new System.Drawing.Size(45, 39);
            this._modButton.TabIndex = 12;
            this._modButton.Text = "%";
            this._modButton.UseVisualStyleBackColor = true;
            this._modButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _powButton
            // 
            this._powButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._powButton.Location = new System.Drawing.Point(227, 135);
            this._powButton.Name = "_powButton";
            this._powButton.Size = new System.Drawing.Size(45, 39);
            this._powButton.TabIndex = 13;
            this._powButton.Text = "^";
            this._powButton.UseVisualStyleBackColor = true;
            this._powButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _multiplyButton
            // 
            this._multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._multiplyButton.Location = new System.Drawing.Point(227, 92);
            this._multiplyButton.Name = "_multiplyButton";
            this._multiplyButton.Size = new System.Drawing.Size(45, 39);
            this._multiplyButton.TabIndex = 14;
            this._multiplyButton.Text = "*";
            this._multiplyButton.UseVisualStyleBackColor = true;
            this._multiplyButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _divideButton
            // 
            this._divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._divideButton.Location = new System.Drawing.Point(296, 92);
            this._divideButton.Name = "_divideButton";
            this._divideButton.Size = new System.Drawing.Size(45, 39);
            this._divideButton.TabIndex = 15;
            this._divideButton.Text = "/";
            this._divideButton.UseVisualStyleBackColor = true;
            this._divideButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _minusButton
            // 
            this._minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._minusButton.Location = new System.Drawing.Point(296, 49);
            this._minusButton.Name = "_minusButton";
            this._minusButton.Size = new System.Drawing.Size(45, 39);
            this._minusButton.TabIndex = 16;
            this._minusButton.Text = "-";
            this._minusButton.UseVisualStyleBackColor = true;
            this._minusButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _plusButton
            // 
            this._plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._plusButton.Location = new System.Drawing.Point(227, 49);
            this._plusButton.Name = "_plusButton";
            this._plusButton.Size = new System.Drawing.Size(45, 39);
            this._plusButton.TabIndex = 17;
            this._plusButton.Text = "+";
            this._plusButton.UseVisualStyleBackColor = true;
            this._plusButton.Click += new System.EventHandler(this.InvokeSignButtonPressed);
            // 
            // _calculatorViewModelBindingSource
            // 
            this._calculatorViewModelBindingSource.DataSource = typeof(Presentation.CalculatorViewModel);
            // 
            // CalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 253);
            this.Controls.Add(this._plusButton);
            this.Controls.Add(this._minusButton);
            this.Controls.Add(this._divideButton);
            this.Controls.Add(this._multiplyButton);
            this.Controls.Add(this._powButton);
            this.Controls.Add(this._modButton);
            this.Controls.Add(this._resultButton);
            this.Controls.Add(this._zeroButton);
            this.Controls.Add(this._fourButton);
            this.Controls.Add(this._sevenButton);
            this.Controls.Add(this._twoButton);
            this.Controls.Add(this._nineButton);
            this.Controls.Add(this._sixButton);
            this.Controls.Add(this._eightButton);
            this.Controls.Add(this._threeButton);
            this.Controls.Add(this._fiveButton);
            this.Controls.Add(this._oneButton);
            this.Controls.Add(this._calculatingString);
            this.Name = "CalculatorView";
            this.ShowIcon = false;
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this._calculatorViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _calculatingString;
        private System.Windows.Forms.Button _oneButton;
        private System.Windows.Forms.Button _fiveButton;
        private System.Windows.Forms.Button _threeButton;
        private System.Windows.Forms.Button _eightButton;
        private System.Windows.Forms.Button _sixButton;
        private System.Windows.Forms.Button _nineButton;
        private System.Windows.Forms.Button _twoButton;
        private System.Windows.Forms.Button _sevenButton;
        private System.Windows.Forms.Button _fourButton;
        private System.Windows.Forms.Button _zeroButton;
        private System.Windows.Forms.Button _resultButton;
        private System.Windows.Forms.Button _modButton;
        private System.Windows.Forms.Button _powButton;
        private System.Windows.Forms.Button _multiplyButton;
        private System.Windows.Forms.Button _divideButton;
        private System.Windows.Forms.Button _minusButton;
        private System.Windows.Forms.Button _plusButton;
        private System.Windows.Forms.BindingSource _calculatorViewModelBindingSource;
    }
}

