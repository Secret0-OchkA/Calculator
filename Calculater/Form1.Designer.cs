namespace Calculater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonMultiplay = new System.Windows.Forms.Button();
            this.buttonDivsion = new System.Windows.Forms.Button();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirst = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.listBoxLastOp = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonSum);
            this.flowLayoutPanel3.Controls.Add(this.buttonDifference);
            this.flowLayoutPanel3.Controls.Add(this.buttonMultiplay);
            this.flowLayoutPanel3.Controls.Add(this.buttonDivsion);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(26, 56);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(206, 43);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(3, 3);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(45, 39);
            this.buttonSum.TabIndex = 1;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(54, 3);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(45, 39);
            this.buttonDifference.TabIndex = 2;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // buttonMultiplay
            // 
            this.buttonMultiplay.Location = new System.Drawing.Point(105, 3);
            this.buttonMultiplay.Name = "buttonMultiplay";
            this.buttonMultiplay.Size = new System.Drawing.Size(45, 39);
            this.buttonMultiplay.TabIndex = 3;
            this.buttonMultiplay.Text = "*";
            this.buttonMultiplay.UseVisualStyleBackColor = true;
            this.buttonMultiplay.Click += new System.EventHandler(this.buttonMultiplay_Click);
            // 
            // buttonDivsion
            // 
            this.buttonDivsion.Enabled = false;
            this.buttonDivsion.Location = new System.Drawing.Point(156, 3);
            this.buttonDivsion.Name = "buttonDivsion";
            this.buttonDivsion.Size = new System.Drawing.Size(45, 39);
            this.buttonDivsion.TabIndex = 4;
            this.buttonDivsion.Text = "/";
            this.buttonDivsion.UseVisualStyleBackColor = true;
            this.buttonDivsion.Click += new System.EventHandler(this.buttonDivsion_Click);
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Location = new System.Drawing.Point(131, 30);
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(101, 20);
            this.numericUpDownSecond.TabIndex = 2;
            this.numericUpDownSecond.ValueChanged += new System.EventHandler(this.numericUpDownSecond_ValueChanged);
            // 
            // numericUpDownFirst
            // 
            this.numericUpDownFirst.AllowDrop = true;
            this.numericUpDownFirst.Location = new System.Drawing.Point(26, 30);
            this.numericUpDownFirst.Name = "numericUpDownFirst";
            this.numericUpDownFirst.Size = new System.Drawing.Size(99, 20);
            this.numericUpDownFirst.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(23, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(59, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "labelResult";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // listBoxLastOp
            // 
            this.listBoxLastOp.FormattingEnabled = true;
            this.listBoxLastOp.Location = new System.Drawing.Point(26, 105);
            this.listBoxLastOp.Name = "listBoxLastOp";
            this.listBoxLastOp.Size = new System.Drawing.Size(120, 95);
            this.listBoxLastOp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 226);
            this.Controls.Add(this.listBoxLastOp);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.numericUpDownFirst);
            this.Controls.Add(this.numericUpDownSecond);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonMultiplay;
        private System.Windows.Forms.Button buttonDivsion;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownFirst;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox listBoxLastOp;
    }
}

