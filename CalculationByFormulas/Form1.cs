using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationByFormulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            double CH_latitude = Check_CheckBox(checkBox_CH_latitude, Convert.ToDouble(textBox_CH_latitude.Text));
            double CH_longitude = Check_CheckBox(checkBox_CH_longitude, Convert.ToDouble(textBox_CH_longitude.Text));
            double CH_height = Convert.ToDouble(textBox_CH_height.Text);
            double heightMo = Convert.ToDouble(textBox_heightMo.Text);

            double OH_latitude = Check_CheckBox(checkBox_OH_latitude, Convert.ToDouble(textBox_OH_latitude.Text));
            double OH_longitude = Check_CheckBox(checkBox_OH_longitude, Convert.ToDouble(textBox_OH_longitude.Text));
            double OH_height = Convert.ToDouble(textBox_OH_height.Text);
            double heightNo = Convert.ToDouble(textBox_heightNo.Text);

            double l1, l2;
            
            if (Double.TryParse(textBox_L1.Text, out l1) == true || Double.TryParse(textBox_L2.Text, out l2) == true)
            {
                l1 = Convert.ToDouble(textBox_L1.Text);
                l2 = Convert.ToDouble(textBox_L2.Text);

                MainFormula mainFormula = new MainFormula(CH_latitude, CH_longitude, CH_height, heightMo, 
                    OH_latitude, OH_longitude, OH_height, heightNo,
                    l1, l2);
                ShowResult(mainFormula);
            }
            else
            {
                MainFormula mainFormula = new MainFormula(CH_latitude, CH_longitude, CH_height, heightMo, 
                    OH_latitude, OH_longitude, OH_height, heightNo);
                ShowResult(mainFormula);
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (checkedListBox_Clear.GetItemChecked(0))
            {
                richTextBox_Entered_Data.Text = "";
                checkedListBox_Clear.SetItemChecked(0, false);
            }
            if (checkedListBox_Clear.GetItemChecked(1))
            {
                checkBox_CH_latitude.Checked = false;
                checkBox_CH_longitude.Checked = false;

                checkBox_OH_latitude.Checked = false;
                checkBox_OH_longitude.Checked = false;

                textBox_CH_latitude.Text = "";
                textBox_CH_longitude.Text = "";
                textBox_CH_height.Text = "";
                textBox_heightMo.Text = "";

                textBox_OH_latitude.Text = "";
                textBox_OH_longitude.Text = "";
                textBox_OH_height.Text = "";
                textBox_heightNo.Text = "";

                textBox_L1.Text = "";
                textBox_L2.Text = "";

                checkedListBox_Clear.SetItemChecked(1, false);
            }
            if (checkedListBox_Clear.GetItemChecked(2))
            {
                richTextBox.Text = "";
                checkedListBox_Clear.SetItemChecked(2, false);
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }
        private double Check_CheckBox(CheckBox checkBox, double value)
        {
            if (checkBox.Checked == true)
                return -value;
            return value;
        }
        private void ShowResult(MainFormula mainFormula)
        {
            if (richTextBox.Text != "")
                richTextBox.Text += "\n";

            richTextBox_Entered_Data.Text = mainFormula.ShowInputData();

            richTextBox.Text += mainFormula.ShowOutputData();
        }
    }
}
