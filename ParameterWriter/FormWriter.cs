﻿using System;
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
        OtherParameter
    }

    public partial class FormWriter : Form
    {
        //public Dictionary<string, HashSet<object>> valuesBase;
        //public HashSet<string> parametersList;

        public string paramName;
        public string source;
        public WriterMode writerMode;
        public SourceMode sourceMode;
        Dictionary<string, HashSet<string>> values;


        public FormWriter(bool haveSelectedElements, Dictionary<string, HashSet<string>> ValuesBase) //List<string> ParametersList)
        {
            InitializeComponent();

            values = ValuesBase;
            List<string> paramsList = ValuesBase.Keys.ToList(); //parameters.ToList();
            paramsList.Sort();
            comboBoxParameter.DataSource = paramsList;
            comboBoxSourceParameter.DataSource = paramsList.ToList();

            if(haveSelectedElements)
            {
                radioSelectedElements.Checked = true;
                radioSelectedElements.Enabled = false;
                radioViewElements.Enabled = false;
                radioAllElements.Enabled = false;
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            paramName = comboBoxParameter.Text;

            if (radioSelectedElements.Checked) writerMode = WriterMode.OnlySelected;
            if (radioViewElements.Checked) writerMode = WriterMode.OnCurrentView;
            if (radioAllElements.Checked) writerMode = WriterMode.AllInProject;

            if (radioButtonWriteValue.Checked)
            {
                sourceMode = SourceMode.FixValue;
                source = comboBoxValue.Text;
            }
            if (radioButtonWriteOtherPAram.Checked)
            {
                sourceMode = SourceMode.OtherParameter;
                source = comboBoxSourceParameter.Text;
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
            comboBoxValue.DataSource = curValues;
        }

        private void radioButtonWriteValue_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxValue.Enabled = true;
            comboBoxSourceParameter.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxValue.Enabled = false;
            comboBoxSourceParameter.Enabled = true;
        }
    }
}
