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
        private readonly Options _options;

        public OptionsForm():this(null)
        {
            
        }

        public OptionsForm(Options options)
        {
            this._options = options;
            InitializeComponent();
            InitializeOptions(options);
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
            if (this._options == null)
            {
                var options = new Options()
                {
                    Name = this.txtName.Text,
                    SourcePath = this.txtSourcePath.Text,
                    TargetPath = this.txtTargetPath.Text,
                    Filter = string.IsNullOrWhiteSpace(this.txtFilter.Text) ? null : this.txtFilter.Text,
                    IncludeSubDires = this.chbIncludSubDires.Checked,
                    Enable = this.chbEnable.Checked
                };
                ConfigManager.Options.Add(options);
            }
            else
            {
                this._options.Name = this.txtName.Text;
                this._options.SourcePath = this.txtSourcePath.Text;
                this._options.TargetPath = this.txtTargetPath.Text;
                this._options.Filter = string.IsNullOrWhiteSpace(this.txtFilter.Text) ? null : this.txtFilter.Text;
                this._options.IncludeSubDires = this.chbIncludSubDires.Checked;
                this._options.Enable = this.chbEnable.Checked;
            }
            ConfigManager.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void InitializeOptions(Options options)
        {
            if (options == null)
                return;
            this.txtName.Text = options.Name;
            this.txtSourcePath.Text = options.SourcePath;
            this.txtTargetPath.Text = options.TargetPath;
            this.txtFilter.Text = options.Filter;
            this.chbIncludSubDires.Checked = options.IncludeSubDires;
            this.chbEnable.Checked = options.Enable;
        }

        private void btnTestRegex_Click(object sender, EventArgs e)
        {
            var form = new RegexTest(this.txtFilter.Text);
            form.ShowDialog(this);
        }
    }
}
