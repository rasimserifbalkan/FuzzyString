using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyString;
using FuzzyStringSample.Models;


namespace FuzzyStringSample
{
    public partial class Form1 : Form
    {
        BindingList<KeyModel> _bindingList = new BindingList<KeyModel>();
        public Form1()
        {
            InitializeComponent();
     
            _bindingList.Add(new KeyModel() { Text = "Kapali" });
            _bindingList.Add(new KeyModel() { Text = "Kagithane" });
            _bindingList.Add(new KeyModel() { Text = "Kâgithane" });
            _bindingList.Add(new KeyModel() { Text = "KÂGITHANE" });
            _bindingList.Add(new KeyModel() { Text = "hastahane" });
            _bindingList.Add(new KeyModel() { Text = "Kagıthane" });
            bindKeys.DataSource = _bindingList;
        }

        private void BtnAddKey_Click(object sender, EventArgs e)
        {
            _bindingList.Add(new KeyModel() { Text = txtKey.Text });
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {



        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            double tolare = 0;
            if (numericUpDown1.Value < 10)
            {
                tolare = ((double) numericUpDown1.Value / 10);
            }
            else if (numericUpDown1.Value >= 10 && numericUpDown1.Value < 100)
            {
                tolare = ((double)numericUpDown1.Value / 100);
            }
            else if (numericUpDown1.Value > 100 && numericUpDown1.Value <= 999)
            {
                tolare = ((double)numericUpDown1.Value / 1000);
            }
            label1.Text = tolare.ToString();

            if (txtSearch.Text.Length == 0)
            {
                return;
            }
          

            List<FuzzyStringComparisonOptions> options = new List<FuzzyStringComparisonOptions>();

            // Choose which algorithms should weigh in for the comparison
            options.Add(FuzzyStringComparisonOptions.UseOverlapCoefficient);
            options.Add(FuzzyStringComparisonOptions.UseLongestCommonSubsequence);
            options.Add(FuzzyStringComparisonOptions.UseLongestCommonSubstring);
            options.Add(FuzzyStringComparisonOptions.UseJaccardDistance);

            // Choose the relative strength of the comparison - is it almost exactly equal? or is it just close?
            FuzzyStringComparisonTolerance tolerance = FuzzyStringComparisonTolerance.Normal;
          
            var result = _bindingList.Where(x => x.Text.ApproximatelyEquals(txtSearch.Text, tolare, options.ToArray())).ToList();
            binResult.DataSource = result;

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TxtSearch_TextChanged(sender, e);
        }

        private void NumericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            TxtSearch_TextChanged(sender, e);
        }
    }
}
