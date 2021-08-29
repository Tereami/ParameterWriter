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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxParameter = new System.Windows.Forms.ComboBox();
            this.groupBoxSourceData = new System.Windows.Forms.GroupBox();
            this.comboBox_Constructor = new System.Windows.Forms.ComboBox();
            this.radioButton_Constructor = new System.Windows.Forms.RadioButton();
            this.comboBox_OtherParameter = new System.Windows.Forms.ComboBox();
            this.radioButton_OtherParameter = new System.Windows.Forms.RadioButton();
            this.radioButton_ConstValue = new System.Windows.Forms.RadioButton();
            this.comboBox_ConstValue = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxSourceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioAllElements);
            this.groupBox1.Controls.Add(this.radioViewElements);
            this.groupBox1.Controls.Add(this.radioSelectedElements);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxParameter);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(285, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // radioAllElements
            // 
            this.radioAllElements.AutoSize = true;
            this.radioAllElements.Location = new System.Drawing.Point(8, 79);
            this.radioAllElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioAllElements.Name = "radioAllElements";
            this.radioAllElements.Size = new System.Drawing.Size(111, 17);
            this.radioAllElements.TabIndex = 2;
            this.radioAllElements.TabStop = true;
            this.radioAllElements.Text = "Во всем проекте";
            this.radioAllElements.UseVisualStyleBackColor = true;
            // 
            // radioViewElements
            // 
            this.radioViewElements.AutoSize = true;
            this.radioViewElements.Checked = true;
            this.radioViewElements.Location = new System.Drawing.Point(8, 58);
            this.radioViewElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioViewElements.Name = "radioViewElements";
            this.radioViewElements.Size = new System.Drawing.Size(134, 17);
            this.radioViewElements.TabIndex = 1;
            this.radioViewElements.TabStop = true;
            this.radioViewElements.Text = "Все на текущем виде";
            this.radioViewElements.UseVisualStyleBackColor = true;
            // 
            // radioSelectedElements
            // 
            this.radioSelectedElements.AutoSize = true;
            this.radioSelectedElements.Enabled = false;
            this.radioSelectedElements.Location = new System.Drawing.Point(8, 39);
            this.radioSelectedElements.Margin = new System.Windows.Forms.Padding(2);
            this.radioSelectedElements.Name = "radioSelectedElements";
            this.radioSelectedElements.Size = new System.Drawing.Size(84, 17);
            this.radioSelectedElements.TabIndex = 0;
            this.radioSelectedElements.TabStop = true;
            this.radioSelectedElements.Text = "Выбранные";
            this.radioSelectedElements.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Записывать в элементы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "В параметр:";
            // 
            // comboBoxParameter
            // 
            this.comboBoxParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxParameter.FormattingEnabled = true;
            this.comboBoxParameter.Location = new System.Drawing.Point(6, 128);
            this.comboBoxParameter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParameter.Name = "comboBoxParameter";
            this.comboBoxParameter.Size = new System.Drawing.Size(272, 21);
            this.comboBoxParameter.TabIndex = 1;
            this.comboBoxParameter.SelectedIndexChanged += new System.EventHandler(this.comboBoxParameter_SelectedIndexChanged);
            // 
            // groupBoxSourceData
            // 
            this.groupBoxSourceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSourceData.Controls.Add(this.comboBox_Constructor);
            this.groupBoxSourceData.Controls.Add(this.radioButton_Constructor);
            this.groupBoxSourceData.Controls.Add(this.comboBox_OtherParameter);
            this.groupBoxSourceData.Controls.Add(this.radioButton_OtherParameter);
            this.groupBoxSourceData.Controls.Add(this.radioButton_ConstValue);
            this.groupBoxSourceData.Controls.Add(this.comboBox_ConstValue);
            this.groupBoxSourceData.Location = new System.Drawing.Point(9, 169);
            this.groupBoxSourceData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSourceData.Name = "groupBoxSourceData";
            this.groupBoxSourceData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSourceData.Size = new System.Drawing.Size(285, 173);
            this.groupBoxSourceData.TabIndex = 1;
            this.groupBoxSourceData.TabStop = false;
            this.groupBoxSourceData.Text = "Источник данных:";
            // 
            // comboBox_Constructor
            // 
            this.comboBox_Constructor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Constructor.Enabled = false;
            this.comboBox_Constructor.FormattingEnabled = true;
            this.comboBox_Constructor.Location = new System.Drawing.Point(6, 139);
            this.comboBox_Constructor.Name = "comboBox_Constructor";
            this.comboBox_Constructor.Size = new System.Drawing.Size(272, 21);
            this.comboBox_Constructor.TabIndex = 7;
            // 
            // radioButton_Constructor
            // 
            this.radioButton_Constructor.AutoSize = true;
            this.radioButton_Constructor.Location = new System.Drawing.Point(8, 118);
            this.radioButton_Constructor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.radioButton_Constructor.Name = "radioButton_Constructor";
            this.radioButton_Constructor.Size = new System.Drawing.Size(113, 17);
            this.radioButton_Constructor.TabIndex = 6;
            this.radioButton_Constructor.TabStop = true;
            this.radioButton_Constructor.Text = "По конструктору:";
            this.radioButton_Constructor.UseVisualStyleBackColor = true;
            this.radioButton_Constructor.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // comboBox_OtherParameter
            // 
            this.comboBox_OtherParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_OtherParameter.Enabled = false;
            this.comboBox_OtherParameter.FormattingEnabled = true;
            this.comboBox_OtherParameter.Location = new System.Drawing.Point(6, 89);
            this.comboBox_OtherParameter.Name = "comboBox_OtherParameter";
            this.comboBox_OtherParameter.Size = new System.Drawing.Size(272, 21);
            this.comboBox_OtherParameter.TabIndex = 5;
            // 
            // radioButton_OtherParameter
            // 
            this.radioButton_OtherParameter.AutoSize = true;
            this.radioButton_OtherParameter.Location = new System.Drawing.Point(8, 68);
            this.radioButton_OtherParameter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.radioButton_OtherParameter.Name = "radioButton_OtherParameter";
            this.radioButton_OtherParameter.Size = new System.Drawing.Size(142, 17);
            this.radioButton_OtherParameter.TabIndex = 4;
            this.radioButton_OtherParameter.Text = "Из другого параметра:";
            this.radioButton_OtherParameter.UseVisualStyleBackColor = true;
            this.radioButton_OtherParameter.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // radioButton_ConstValue
            // 
            this.radioButton_ConstValue.AutoSize = true;
            this.radioButton_ConstValue.Checked = true;
            this.radioButton_ConstValue.Location = new System.Drawing.Point(8, 20);
            this.radioButton_ConstValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.radioButton_ConstValue.Name = "radioButton_ConstValue";
            this.radioButton_ConstValue.Size = new System.Drawing.Size(161, 17);
            this.radioButton_ConstValue.TabIndex = 4;
            this.radioButton_ConstValue.TabStop = true;
            this.radioButton_ConstValue.Text = "Фиксированное значение:";
            this.radioButton_ConstValue.UseVisualStyleBackColor = true;
            this.radioButton_ConstValue.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // comboBox_ConstValue
            // 
            this.comboBox_ConstValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ConstValue.FormattingEnabled = true;
            this.comboBox_ConstValue.Location = new System.Drawing.Point(6, 40);
            this.comboBox_ConstValue.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ConstValue.Name = "comboBox_ConstValue";
            this.comboBox_ConstValue.Size = new System.Drawing.Size(272, 21);
            this.comboBox_ConstValue.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(142, 354);
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
            this.buttonCancel.Location = new System.Drawing.Point(220, 354);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormWriter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(305, 386);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxSourceData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполнятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSourceData.ResumeLayout(false);
            this.groupBoxSourceData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAllElements;
        private System.Windows.Forms.RadioButton radioViewElements;
        private System.Windows.Forms.RadioButton radioSelectedElements;
        private System.Windows.Forms.GroupBox groupBoxSourceData;
        private System.Windows.Forms.ComboBox comboBox_ConstValue;
        private System.Windows.Forms.ComboBox comboBoxParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox_OtherParameter;
        private System.Windows.Forms.RadioButton radioButton_OtherParameter;
        private System.Windows.Forms.RadioButton radioButton_ConstValue;
        private System.Windows.Forms.ComboBox comboBox_Constructor;
        private System.Windows.Forms.RadioButton radioButton_Constructor;
        private System.Windows.Forms.Label label2;
    }
}