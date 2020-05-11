using FileCopy.Config;
using FileCopy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopy
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            var folderSelect = new FolderBrowserDialog();
            if(folderSelect.ShowDialog() == DialogResult.OK)
            {
                this.txtSourcePath.Text = folderSelect.SelectedPath;
            }
        }

        private void btnTargetPath_Click(object sender, EventArgs e)
        {
            var folderSelect = new FolderBrowserDialog();
            if (folderSelect.ShowDialog() == DialogResult.OK)
            {
                this.txtTargetPath.Text = folderSelect.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var options = new Options()
            {
                SourcePath = this.txtSourcePath.Text,
                TargetPath = this.txtTargetPath.Text,
                Filter = string.IsNullOrWhiteSpace(this.txtFilter.Text) ? null : this.txtFilter.Text,
                IncludeSubDires = this.chbIncludSubDires.Checked
            };
            ConfigManager.Options.Add(options);
            this.DialogResult = DialogResult.OK;
        }
    }
}
