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
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxParameter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вписывать в элементы:";
            // 
            // radioAllElements
            // 
            this.radioAllElements.AutoSize = true;
            this.radioAllElements.Location = new System.Drawing.Point(7, 88);
            this.radioAllElements.Name = "radioAllElements";
            this.radioAllElements.Size = new System.Drawing.Size(161, 24);
            this.radioAllElements.TabIndex = 2;
            this.radioAllElements.TabStop = true;
            this.radioAllElements.Text = "Во всем проекте";
            this.radioAllElements.UseVisualStyleBackColor = true;
            // 
            // radioViewElements
            // 
            this.radioViewElements.AutoSize = true;
            this.radioViewElements.Checked = true;
            this.radioViewElements.Location = new System.Drawing.Point(7, 57);
            this.radioViewElements.Name = "radioViewElements";
            this.radioViewElements.Size = new System.Drawing.Size(196, 24);
            this.radioViewElements.TabIndex = 1;
            this.radioViewElements.TabStop = true;
            this.radioViewElements.Text = "Все на текущем виде";
            this.radioViewElements.UseVisualStyleBackColor = true;
            // 
            // radioSelectedElements
            // 
            this.radioSelectedElements.AutoSize = true;
            this.radioSelectedElements.Enabled = false;
            this.radioSelectedElements.Location = new System.Drawing.Point(7, 26);
            this.radioSelectedElements.Name = "radioSelectedElements";
            this.radioSelectedElements.Size = new System.Drawing.Size(121, 24);
            this.radioSelectedElements.TabIndex = 0;
            this.radioSelectedElements.TabStop = true;
            this.radioSelectedElements.Text = "Выбранные";
            this.radioSelectedElements.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxValue);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxParameter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Что записывать:";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(11, 113);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(309, 28);
            this.comboBoxValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значение:";
            // 
            // comboBoxParameter
            // 
            this.comboBoxParameter.FormattingEnabled = true;
            this.comboBoxParameter.Location = new System.Drawing.Point(11, 50);
            this.comboBoxParameter.Name = "comboBoxParameter";
            this.comboBoxParameter.Size = new System.Drawing.Size(309, 28);
            this.comboBoxParameter.TabIndex = 1;
            this.comboBoxParameter.SelectedIndexChanged += new System.EventHandler(this.comboBoxParameter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр:";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOk.Location = new System.Drawing.Point(13, 327);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(111, 38);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(228, 327);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 38);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormWriter
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(359, 377);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}