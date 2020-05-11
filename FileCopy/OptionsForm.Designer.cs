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
            this.txtSourcePath.Location = new System.Drawing.Point(92, 54);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(392, 21);
            this.txtSourcePath.TabIndex = 3;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(92, 90);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(392, 21);
            this.txtTargetPath.TabIndex = 4;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(92, 129);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(392, 21);
            this.txtFilter.TabIndex = 5;
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
            this.btnOk.Location = new System.Drawing.Point(213, 211);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(69, 32);
            this.btnOk.TabIndex = 8;
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
            this.chbIncludSubDires.Location = new System.Drawing.Point(99, 171);
            this.chbIncludSubDires.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbIncludSubDires.Name = "chbIncludSubDires";
            this.chbIncludSubDires.Size = new System.Drawing.Size(15, 14);
            this.chbIncludSubDires.TabIndex = 11;
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
            this.txtName.TabIndex = 13;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 265);
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
            this.Name = "OptionsForm";
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
    }
}