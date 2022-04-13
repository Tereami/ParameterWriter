using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParameterWriter
{
    public partial class FormWriteView : Form
    {
        public List<string[]> parameters;
        public WriterSettings curSettings;

        public FormWriteView(WriterSettings sets)
        {
            InitializeComponent();

            curSettings = sets;

            foreach(string[] row in sets.WriteViewParameters)
            {
                dataGridView1.Rows.Add(row);
            }
            checkBoxOnlySheets.Checked = sets.WriteViewOnlySheets;
            radioButtonOnlyFirst.Checked = !sets.WriteViewAll;
            radioButtonAllViews.Checked = sets.WriteViewAll;
            textBoxSeparator.Text = sets.WriteViewSeparator;
        }

        private void radioButtonAllViews_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSeparator.Enabled = radioButtonAllViews.Checked;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<string[]> parameters = new List<string[]>();
            if (dataGridView1.Rows.Count == 1) return;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                DataGridViewCellCollection cells = row.Cells;
                string viewParamName = cells[0].Value.ToString();
                string elemParamName = cells[1].Value.ToString();
                string[] paramsRow = { viewParamName, elemParamName };
                parameters.Add(paramsRow);
            }
            curSettings.WriteViewParameters = parameters;
            curSettings.WriteViewOnlySheets = checkBoxOnlySheets.Checked;
            curSettings.WriteViewAll = radioButtonAllViews.Checked;
            curSettings.WriteViewSeparator = textBoxSeparator.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
