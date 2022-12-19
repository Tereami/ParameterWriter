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
            this.comboBoxTargetParameter = new System.Windows.Forms.ComboBox();
            this.groupBoxSourceData = new System.Windows.Forms.GroupBox();
            this.comboBox_Constructor = new System.Windows.Forms.ComboBox();
            this.radioButton_Constructor = new System.Windows.Forms.RadioButton();
            this.comboBox_Level = new System.Windows.Forms.ComboBox();
            this.radioButton_Level = new System.Windows.Forms.RadioButton();
            this.comboBox_OtherParameter = new System.Windows.Forms.ComboBox();
            this.radioButton_OtherParameter = new System.Windows.Forms.RadioButton();
            this.radioButton_ConstValue = new System.Windows.Forms.RadioButton();
            this.comboBox_ConstValue = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.checkBox_ShowLog = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSourceData.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTargetParameter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(279, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // radioAllElements
            // 
            this.radioAllElements.AutoSize = true;
            this.radioAllElements.Location = new System.Drawing.Point(8, 83);
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
            this.radioViewElements.Location = new System.Drawing.Point(8, 60);
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
            this.radioSelectedElements.Location = new System.Drawing.Point(8, 37);
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
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Записывать в элементы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "В параметр:";
            // 
            // comboBoxTargetParameter
            // 
            this.comboBoxTargetParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetParameter.FormattingEnabled = true;
            this.comboBoxTargetParameter.Location = new System.Drawing.Point(5, 125);
            this.comboBoxTargetParameter.Name = "comboBoxTargetParameter";
            this.comboBoxTargetParameter.Size = new System.Drawing.Size(269, 21);
            this.comboBoxTargetParameter.TabIndex = 1;
            this.comboBoxTargetParameter.SelectedIndexChanged += new System.EventHandler(this.comboBoxParameter_SelectedIndexChanged);
            // 
            // groupBoxSourceData
            // 
            this.groupBoxSourceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSourceData.Controls.Add(this.comboBox_Constructor);
            this.groupBoxSourceData.Controls.Add(this.radioButton_Constructor);
            this.groupBoxSourceData.Controls.Add(this.comboBox_Level);
            this.groupBoxSourceData.Controls.Add(this.radioButton_Level);
            this.groupBoxSourceData.Controls.Add(this.comboBox_OtherParameter);
            this.groupBoxSourceData.Controls.Add(this.radioButton_OtherParameter);
            this.groupBoxSourceData.Controls.Add(this.radioButton_ConstValue);
            this.groupBoxSourceData.Controls.Add(this.comboBox_ConstValue);
            this.groupBoxSourceData.Location = new System.Drawing.Point(12, 175);
            this.groupBoxSourceData.Name = "groupBoxSourceData";
            this.groupBoxSourceData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSourceData.Size = new System.Drawing.Size(279, 224);
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
            this.comboBox_Constructor.Location = new System.Drawing.Point(5, 192);
            this.comboBox_Constructor.Name = "comboBox_Constructor";
            this.comboBox_Constructor.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Constructor.TabIndex = 7;
            // 
            // radioButton_Constructor
            // 
            this.radioButton_Constructor.AutoSize = true;
            this.radioButton_Constructor.Location = new System.Drawing.Point(8, 169);
            this.radioButton_Constructor.Name = "radioButton_Constructor";
            this.radioButton_Constructor.Size = new System.Drawing.Size(113, 17);
            this.radioButton_Constructor.TabIndex = 6;
            this.radioButton_Constructor.TabStop = true;
            this.radioButton_Constructor.Text = "По конструктору:";
            this.radioButton_Constructor.UseVisualStyleBackColor = true;
            this.radioButton_Constructor.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // comboBox_Level
            // 
            this.comboBox_Level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Level.Enabled = false;
            this.comboBox_Level.FormattingEnabled = true;
            this.comboBox_Level.Location = new System.Drawing.Point(5, 141);
            this.comboBox_Level.Name = "comboBox_Level";
            this.comboBox_Level.Size = new System.Drawing.Size(269, 21);
            this.comboBox_Level.TabIndex = 5;
            // 
            // radioButton_Level
            // 
            this.radioButton_Level.AutoSize = true;
            this.radioButton_Level.Location = new System.Drawing.Point(8, 118);
            this.radioButton_Level.Name = "radioButton_Level";
            this.radioButton_Level.Size = new System.Drawing.Size(80, 17);
            this.radioButton_Level.TabIndex = 4;
            this.radioButton_Level.Text = "Из уровня:";
            this.radioButton_Level.UseVisualStyleBackColor = true;
            this.radioButton_Level.CheckedChanged += new System.EventHandler(this.radioButtonWriteValue_CheckedChanged);
            // 
            // comboBox_OtherParameter
            // 
            this.comboBox_OtherParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_OtherParameter.Enabled = false;
            this.comboBox_OtherParameter.FormattingEnabled = true;
            this.comboBox_OtherParameter.Location = new System.Drawing.Point(5, 91);
            this.comboBox_OtherParameter.Name = "comboBox_OtherParameter";
            this.comboBox_OtherParameter.Size = new System.Drawing.Size(269, 21);
            this.comboBox_OtherParameter.TabIndex = 5;
            // 
            // radioButton_OtherParameter
            // 
            this.radioButton_OtherParameter.AutoSize = true;
            this.radioButton_OtherParameter.Location = new System.Drawing.Point(8, 68);
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
            this.radioButton_ConstValue.Location = new System.Drawing.Point(8, 18);
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
            this.comboBox_ConstValue.Location = new System.Drawing.Point(5, 41);
            this.comboBox_ConstValue.Name = "comboBox_ConstValue";
            this.comboBox_ConstValue.Size = new System.Drawing.Size(269, 21);
            this.comboBox_ConstValue.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(137, 537);
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
            this.buttonCancel.Location = new System.Drawing.Point(217, 537);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(74, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(6, 19);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(268, 25);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Открыть сохраненный";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(6, 50);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(268, 25);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить текущий";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Controls.Add(this.buttonExecute);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сценарии";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecute.Location = new System.Drawing.Point(6, 81);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(268, 25);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Пакетная обработка";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // checkBox_ShowLog
            // 
            this.checkBox_ShowLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_ShowLog.AutoSize = true;
            this.checkBox_ShowLog.Location = new System.Drawing.Point(12, 542);
            this.checkBox_ShowLog.Name = "checkBox_ShowLog";
            this.checkBox_ShowLog.Size = new System.Drawing.Size(90, 17);
            this.checkBox_ShowLog.TabIndex = 7;
            this.checkBox_ShowLog.Text = "Вывести лог";
            this.checkBox_ShowLog.UseVisualStyleBackColor = true;
            this.checkBox_ShowLog.Visible = false;
            // 
            // FormWriter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(303, 574);
            this.Controls.Add(this.checkBox_ShowLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxSourceData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FormWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполнятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSourceData.ResumeLayout(false);
            this.groupBoxSourceData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAllElements;
        private System.Windows.Forms.RadioButton radioViewElements;
        private System.Windows.Forms.RadioButton radioSelectedElements;
        private System.Windows.Forms.GroupBox groupBoxSourceData;
        private System.Windows.Forms.ComboBox comboBox_ConstValue;
        private System.Windows.Forms.ComboBox comboBoxTargetParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox_OtherParameter;
        private System.Windows.Forms.RadioButton radioButton_OtherParameter;
        private System.Windows.Forms.RadioButton radioButton_ConstValue;
        private System.Windows.Forms.ComboBox comboBox_Constructor;
        private System.Windows.Forms.RadioButton radioButton_Constructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Level;
        private System.Windows.Forms.RadioButton radioButton_Level;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.CheckBox checkBox_ShowLog;
    }
}