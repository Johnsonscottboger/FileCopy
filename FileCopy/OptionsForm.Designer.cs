namespace FileCopy
{
    partial class OptionsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.btnTargetPath = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbIncludSubDires = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbEnable = new System.Windows.Forms.CheckBox();
            this.btnTestRegex = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chbContentCompare = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "监听路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标路径:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "过滤条件:";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourcePath.Location = new System.Drawing.Point(92, 54);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(360, 22);
            this.txtSourcePath.TabIndex = 1;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetPath.Location = new System.Drawing.Point(92, 90);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(360, 22);
            this.txtTargetPath.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(92, 129);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(360, 22);
            this.txtFilter.TabIndex = 3;
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.Location = new System.Drawing.Point(451, 53);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(33, 23);
            this.btnSourcePath.TabIndex = 6;
            this.btnSourcePath.Text = "...";
            this.btnSourcePath.UseVisualStyleBackColor = true;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // btnTargetPath
            // 
            this.btnTargetPath.Location = new System.Drawing.Point(451, 89);
            this.btnTargetPath.Name = "btnTargetPath";
            this.btnTargetPath.Size = new System.Drawing.Size(33, 23);
            this.btnTargetPath.TabIndex = 7;
            this.btnTargetPath.Text = "...";
            this.btnTargetPath.UseVisualStyleBackColor = true;
            this.btnTargetPath.Click += new System.EventHandler(this.btnTargetPath_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(218, 257);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 32);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "确  定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 10);
            this.label4.TabIndex = 9;
            this.label4.Text = "正则表达式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "包含子目录:";
            // 
            // chbIncludSubDires
            // 
            this.chbIncludSubDires.AutoSize = true;
            this.chbIncludSubDires.Location = new System.Drawing.Point(99, 172);
            this.chbIncludSubDires.Margin = new System.Windows.Forms.Padding(2);
            this.chbIncludSubDires.Name = "chbIncludSubDires";
            this.chbIncludSubDires.Size = new System.Drawing.Size(15, 14);
            this.chbIncludSubDires.TabIndex = 4;
            this.chbIncludSubDires.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "名    称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 21);
            this.txtName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "启    用:";
            // 
            // chbEnable
            // 
            this.chbEnable.AutoSize = true;
            this.chbEnable.Checked = true;
            this.chbEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbEnable.Location = new System.Drawing.Point(470, 172);
            this.chbEnable.Margin = new System.Windows.Forms.Padding(2);
            this.chbEnable.Name = "chbEnable";
            this.chbEnable.Size = new System.Drawing.Size(15, 14);
            this.chbEnable.TabIndex = 14;
            this.chbEnable.UseVisualStyleBackColor = true;
            // 
            // btnTestRegex
            // 
            this.btnTestRegex.Location = new System.Drawing.Point(451, 129);
            this.btnTestRegex.Name = "btnTestRegex";
            this.btnTestRegex.Size = new System.Drawing.Size(33, 23);
            this.btnTestRegex.TabIndex = 15;
            this.btnTestRegex.Text = "T";
            this.btnTestRegex.UseVisualStyleBackColor = true;
            this.btnTestRegex.Click += new System.EventHandler(this.btnTestRegex_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "启用内容比较:";
            // 
            // chbContentCompare
            // 
            this.chbContentCompare.AutoSize = true;
            this.chbContentCompare.Location = new System.Drawing.Point(115, 202);
            this.chbContentCompare.Margin = new System.Windows.Forms.Padding(2);
            this.chbContentCompare.Name = "chbContentCompare";
            this.chbContentCompare.Size = new System.Drawing.Size(15, 14);
            this.chbContentCompare.TabIndex = 17;
            this.chbContentCompare.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("KaiTi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(27, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "当监听文件发生变化时，首先与目标文件对比，当内容有变化时才复制。";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(469, 202);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "自动识别 _Auto 文件夹:";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 310);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chbContentCompare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTestRegex);
            this.Controls.Add(this.chbEnable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chbIncludSubDires);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnTargetPath);
            this.Controls.Add(this.btnSourcePath);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.Button btnTargetPath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIncludSubDires;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbEnable;
        private System.Windows.Forms.Button btnTestRegex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbContentCompare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
    }
}