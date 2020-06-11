namespace ParameterWriter
{
    partial class FormWriter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAllElements = new System.Windows.Forms.RadioButton();
            this.radioViewElements = new System.Windows.Forms.RadioButton();
            this.radioSelectedElements = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSourceParameter = new System.Windows.Forms.ComboBox();
            this.radioButtonWriteOtherPAram = new System.Windows.Forms.RadioButton();
            this.radioButtonWriteValue = new System.Windows.Forms.RadioButton();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxParameter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSetJoinedParameters = new System.Windows.Forms.Button();
            this.radioButtonWriteJoinParameters = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioAllElements);
            this.groupBox1.Controls.Add(this.radioViewElements);
            this.groupBox1.Controls.Add(this.radioSelectedElements);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(217, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вписывать в элементы:";
            // 
            // radioAllElements
            // 
            this.radioAllElements.AutoSize = true;
            this.radioAllElements.Location = new System.Drawing.Point(8, 57);
            this.radioAllElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioAllElements.Name = "radioAllElements";
            this.radioAllElements.Size = new System.Drawing.Size(111, 17);
            this.radioAllElements.TabIndex = 2;
            this.radioAllElements.TabStop = true;
            this.radioAllElements.Text = "Во всем проекте";
            this.radioAllElements.UseVisualStyleBackColor = true;
            this.radioAllElements.CheckedChanged += new System.EventHandler(this.radioAllElements_CheckedChanged);
            // 
            // radioViewElements
            // 
            this.radioViewElements.AutoSize = true;
            this.radioViewElements.Checked = true;
            this.radioViewElements.Location = new System.Drawing.Point(8, 36);
            this.radioViewElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioViewElements.Name = "radioViewElements";
            this.radioViewElements.Size = new System.Drawing.Size(134, 17);
            this.radioViewElements.TabIndex = 1;
            this.radioViewElements.TabStop = true;
            this.radioViewElements.Text = "Все на текущем виде";
            this.radioViewElements.UseVisualStyleBackColor = true;
            this.radioViewElements.CheckedChanged += new System.EventHandler(this.radioViewElements_CheckedChanged);
            // 
            // radioSelectedElements
            // 
            this.radioSelectedElements.AutoSize = true;
            this.radioSelectedElements.Enabled = false;
            this.radioSelectedElements.Location = new System.Drawing.Point(8, 17);
            this.radioSelectedElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioSelectedElements.Name = "radioSelectedElements";
            this.radioSelectedElements.Size = new System.Drawing.Size(84, 17);
            this.radioSelectedElements.TabIndex = 0;
            this.radioSelectedElements.TabStop = true;
            this.radioSelectedElements.Text = "Выбранные";
            this.radioSelectedElements.UseVisualStyleBackColor = true;
            this.radioSelectedElements.CheckedChanged += new System.EventHandler(this.radioSelectedElements_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButtonWriteJoinParameters);
            this.groupBox2.Controls.Add(this.buttonSetJoinedParameters);
            this.groupBox2.Controls.Add(this.comboBoxSourceParameter);
            this.groupBox2.Controls.Add(this.radioButtonWriteOtherPAram);
            this.groupBox2.Controls.Add(this.radioButtonWriteValue);
            this.groupBox2.Controls.Add(this.comboBoxValue);
            this.groupBox2.Controls.Add(this.comboBoxParameter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(217, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Что делаем:";
            // 
            // comboBoxSourceParameter
            // 
            this.comboBoxSourceParameter.Enabled = false;
            this.comboBoxSourceParameter.FormattingEnabled = true;
            this.comboBoxSourceParameter.Location = new System.Drawing.Point(6, 129);
            this.comboBoxSourceParameter.Name = "comboBoxSourceParameter";
            this.comboBoxSourceParameter.Size = new System.Drawing.Size(204, 21);
            this.comboBoxSourceParameter.TabIndex = 5;
            // 
            // radioButtonWriteOtherPAram
            // 
            this.radioButtonWriteOtherPAram.AutoSize = true;
            this.radioButtonWriteOtherPAram.Location = new System.Drawing.Point(8, 106);
            this.radioButtonWriteOtherPAram.Name = "radioButtonWriteOtherPAram";
            this.radioButtonWriteOtherPAram.Size = new System.Drawing.Size(149, 17);
            this.radioButtonWriteOtherPAram.TabIndex = 4;
            this.radioButtonWriteOtherPAram.Text = "Значение из параметра:";
            this.radioButtonWriteOtherPAram.UseVisualStyleBackColor = true;
            this.radioButtonWriteOtherPAram.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonWriteValue
            // 
            this.radioButtonWriteValue.AutoSize = true;
            this.radioButtonWriteValue.Checked = true;
            this.radioButtonWriteValue.Location = new System.Drawing.Point(8, 58);
            this.radioButtonWriteValue.Name = "radioButtonWriteValue";
            this.radioButtonWriteValue.Size = new System.Drawing.Size(161, 17);
            this.radioButtonWriteValue.TabIndex = 4;
            this.radioButtonWriteValue.TabStop = true;
            this.radioButtonWriteValue.Text = "Фиксированное значение:";
            this.radioButtonWriteValue.UseVisualStyleBackColor = true;
            this.radioButtonWriteValue.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(6, 80);
            this.comboBoxValue.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(206, 21);
            this.comboBoxValue.TabIndex = 3;
            // 
            // comboBoxParameter
            // 
            this.comboBoxParameter.FormattingEnabled = true;
            this.comboBoxParameter.Location = new System.Drawing.Point(7, 32);
            this.comboBoxParameter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParameter.Name = "comboBoxParameter";
            this.comboBoxParameter.Size = new System.Drawing.Size(206, 21);
            this.comboBoxParameter.TabIndex = 1;
            this.comboBoxParameter.SelectedIndexChanged += new System.EventHandler(this.comboBoxParameter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Записываем в параметр:";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.Location = new System.Drawing.Point(9, 309);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(74, 25);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(152, 309);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSetJoinedParameters
            // 
            this.buttonSetJoinedParameters.Enabled = false;
            this.buttonSetJoinedParameters.Location = new System.Drawing.Point(8, 180);
            this.buttonSetJoinedParameters.Name = "buttonSetJoinedParameters";
            this.buttonSetJoinedParameters.Size = new System.Drawing.Size(202, 23);
            this.buttonSetJoinedParameters.TabIndex = 6;
            this.buttonSetJoinedParameters.Text = "Задать параметры...";
            this.buttonSetJoinedParameters.UseVisualStyleBackColor = true;
            // 
            // radioButtonWriteJoinParameters
            // 
            this.radioButtonWriteJoinParameters.AutoSize = true;
            this.radioButtonWriteJoinParameters.Location = new System.Drawing.Point(7, 157);
            this.radioButtonWriteJoinParameters.Name = "radioButtonWriteJoinParameters";
            this.radioButtonWriteJoinParameters.Size = new System.Drawing.Size(147, 17);
            this.radioButtonWriteJoinParameters.TabIndex = 7;
            this.radioButtonWriteJoinParameters.TabStop = true;
            this.radioButtonWriteJoinParameters.Text = "Объединить параметры";
            this.radioButtonWriteJoinParameters.UseVisualStyleBackColor = true;
            this.radioButtonWriteJoinParameters.CheckedChanged += new System.EventHandler(this.radioButtonWriteJoinParameters_CheckedChanged);
            // 
            // FormWriter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(239, 341);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполнятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAllElements;
        private System.Windows.Forms.RadioButton radioViewElements;
        private System.Windows.Forms.RadioButton radioSelectedElements;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxSourceParameter;
        private System.Windows.Forms.RadioButton radioButtonWriteOtherPAram;
        private System.Windows.Forms.RadioButton radioButtonWriteValue;
        private System.Windows.Forms.Button buttonSetJoinedParameters;
        private System.Windows.Forms.RadioButton radioButtonWriteJoinParameters;
    }
}