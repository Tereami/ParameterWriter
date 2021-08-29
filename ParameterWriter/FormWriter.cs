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
    public enum WriterMode
    {
        AllInProject,
        OnlySelected,
        OnCurrentView
    }

    public enum SourceMode
    {
        FixValue,
        OtherParameter,
        Constructor
    }

    public partial class FormWriter : Form
    {
        //public Dictionary<string, HashSet<object>> valuesBase;
        //public HashSet<string> parametersList;

        //public string paramName;
        //public string source;
        public WriterMode writerMode;
        //public SourceMode sourceMode;
        Dictionary<string, HashSet<string>> values;

        public WriterSettings sets;


        public FormWriter(bool haveSelectedElements, Dictionary<string, HashSet<string>> ValuesBase, WriterSettings s)
        {
            InitializeComponent();

            values = ValuesBase;
            List<string> paramsList = ValuesBase.Keys.ToList(); //parameters.ToList();
            paramsList.Sort();
            comboBoxParameter.DataSource = paramsList;
            comboBoxParameter.Text = s.targetParamName;
            comboBox_OtherParameter.DataSource = paramsList.ToList();

            sets = s;
            comboBox_Constructor.DataSource = s.constructorHistory;
            comboBox_Constructor.Text = s.currentCostructor;

            if (haveSelectedElements)
            {
                radioSelectedElements.Checked = true;
                radioSelectedElements.Enabled = false;
                radioViewElements.Enabled = false;
                radioAllElements.Enabled = false;
            }

            switch (s.sourceMode)
            {
                case SourceMode.FixValue:
                    radioButton_ConstValue.Checked = true;
                    break;
                case SourceMode.OtherParameter:
                    radioButton_OtherParameter.Checked = true;
                    break;
                case SourceMode.Constructor:
                    radioButton_Constructor.Checked = true;
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            sets.targetParamName = comboBoxParameter.Text;

            if (radioSelectedElements.Checked) writerMode = WriterMode.OnlySelected;
            if (radioViewElements.Checked) writerMode = WriterMode.OnCurrentView;
            if (radioAllElements.Checked) writerMode = WriterMode.AllInProject;

            if (radioButton_ConstValue.Checked)
            {
                sets.sourceMode = SourceMode.FixValue;
                sets.sourceParameterName = comboBox_ConstValue.Text;
            }
            else if (radioButton_OtherParameter.Checked)
            {
                sets.sourceMode = SourceMode.OtherParameter;
                sets.sourceParameterName = comboBox_OtherParameter.Text;
            }
            else if (radioButton_Constructor.Checked)
            {
                sets.sourceMode = SourceMode.Constructor;
                sets.sourceParameterName = comboBox_Constructor.Text;
            }

            sets.currentCostructor = comboBox_Constructor.Text;
            if (!sets.constructorHistory.Contains(comboBox_Constructor.Text))
            {
                sets.constructorHistory.Add(comboBox_Constructor.Text);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curParam = comboBoxParameter.SelectedValue.ToString();
            List<string> curValues = values[curParam].ToList(); ;
            curValues.Sort();
            comboBox_ConstValue.DataSource = curValues;
        }

        private void radioButtonWriteValue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            string suffix = rbtn.Name.Split('_')[1];

            foreach (Control child in groupBoxSourceData.Controls)
            {
                if (child.Name.StartsWith("radio"))
                    continue;
                if (child.Name.EndsWith(suffix))
                    child.Enabled = rbtn.Enabled;
                else
                    child.Enabled = !rbtn.Enabled;
            }
        }
    }
}
