using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy
{
    public partial class RegexTest : Form
    {
        public RegexTest():this(null)
        {
            
        }

        public RegexTest(string pattern)
        {
            InitializeComponent();
            this.txtPattern.Text = pattern;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPattern.Text))
                return;
            var regex = new Regex(this.txtPattern.Text.Trim(), RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
            var result = regex.Matches(this.txtSource.Text);
            var builder = new StringBuilder();
            foreach(Match it in result)
            {
                builder.AppendLine(it.Value);
            }
            this.txtResult.Text = builder.ToString();
        }
    }
}
