
namespace ParameterWriter
{
    partial class FormWriteView
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElementParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxOnlySheets = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonAllViews = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyFirst = new System.Windows.Forms.RadioButton();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паредать параметры из свойств вида/листа в элементы модели, видимые на них:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewParameter,
            this.ElementParameter});
            this.dataGridView1.Location = new System.Drawing.Point(15, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 181);
            this.dataGridView1.TabIndex = 1;
            // 
            // ViewParameter
            // 
            this.ViewParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ViewParameter.FillWeight = 50F;
            this.ViewParameter.HeaderText = "Параметр вида";
            this.ViewParameter.Name = "ViewParameter";
            // 
            // ElementParameter
            // 
            this.ElementParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElementParameter.FillWeight = 50F;
            this.ElementParameter.HeaderText = "Параметр элемента";
            this.ElementParameter.Name = "ElementParameter";
            // 
            // checkBoxOnlySheets
            // 
            this.checkBoxOnlySheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOnlySheets.AutoSize = true;
            this.checkBoxOnlySheets.Checked = true;
            this.checkBoxOnlySheets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnlySheets.Location = new System.Drawing.Point(15, 231);
            this.checkBoxOnlySheets.Name = "checkBoxOnlySheets";
            this.checkBoxOnlySheets.Size = new System.Drawing.Size(256, 17);
            this.checkBoxOnlySheets.TabIndex = 2;
            this.checkBoxOnlySheets.Text = "Только для видов, расположенных на листах";
            this.checkBoxOnlySheets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxSeparator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonAllViews);
            this.groupBox1.Controls.Add(this.radioButtonOnlyFirst);
            this.groupBox1.Location = new System.Drawing.Point(15, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Если элемент отображается на нескольких видах:";
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Location = new System.Drawing.Point(113, 65);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(65, 20);
            this.textBoxSeparator.TabIndex = 5;
            this.textBoxSeparator.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разделитель:";
            // 
            // radioButtonAllViews
            // 
            this.radioButtonAllViews.AutoSize = true;
            this.radioButtonAllViews.Checked = true;
            this.radioButtonAllViews.Location = new System.Drawing.Point(6, 42);
            this.radioButtonAllViews.Name = "radioButtonAllViews";
            this.radioButtonAllViews.Size = new System.Drawing.Size(211, 17);
            this.radioButtonAllViews.TabIndex = 5;
            this.radioButtonAllViews.TabStop = true;
            this.radioButtonAllViews.Text = "Перечислить для всех видов/листов";
            this.radioButtonAllViews.UseVisualStyleBackColor = true;
            this.radioButtonAllViews.CheckedChanged += new System.EventHandler(this.radioButtonAllViews_CheckedChanged);
            // 
            // radioButtonOnlyFirst
            // 
            this.radioButtonOnlyFirst.AutoSize = true;
            this.radioButtonOnlyFirst.Location = new System.Drawing.Point(6, 19);
            this.radioButtonOnlyFirst.Name = "radioButtonOnlyFirst";
            this.radioButtonOnlyFirst.Size = new System.Drawing.Size(218, 17);
            this.radioButtonOnlyFirst.TabIndex = 5;
            this.radioButtonOnlyFirst.Text = "Задать параметры только из первого";
            this.radioButtonOnlyFirst.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(259, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(181, 362);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormWriteView
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(346, 397);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxOnlySheets);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormWriteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполнить по виду";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxOnlySheets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAllViews;
        private System.Windows.Forms.RadioButton radioButtonOnlyFirst;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementParameter;
    }
}