namespace SRTFPractice
{
    partial class SRTFMain
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
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.tbBurstTime = new System.Windows.Forms.TextBox();
            this.btnEnterATBT = new System.Windows.Forms.Button();
            this.lbArrivalTime = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBurstTime = new System.Windows.Forms.ListBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SRTF CPU Scheduling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Arrival Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Burst Time:";
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArrivalTime.Location = new System.Drawing.Point(204, 122);
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(100, 26);
            this.tbArrivalTime.TabIndex = 3;
            // 
            // tbBurstTime
            // 
            this.tbBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBurstTime.Location = new System.Drawing.Point(204, 175);
            this.tbBurstTime.Name = "tbBurstTime";
            this.tbBurstTime.Size = new System.Drawing.Size(100, 26);
            this.tbBurstTime.TabIndex = 4;
            // 
            // btnEnterATBT
            // 
            this.btnEnterATBT.Location = new System.Drawing.Point(215, 220);
            this.btnEnterATBT.Name = "btnEnterATBT";
            this.btnEnterATBT.Size = new System.Drawing.Size(75, 23);
            this.btnEnterATBT.TabIndex = 5;
            this.btnEnterATBT.Text = "Enter";
            this.btnEnterATBT.UseVisualStyleBackColor = true;
            this.btnEnterATBT.Click += new System.EventHandler(this.btnEnterATBT_Click);
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.FormattingEnabled = true;
            this.lbArrivalTime.ItemHeight = 20;
            this.lbArrivalTime.Location = new System.Drawing.Point(344, 114);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(98, 124);
            this.lbArrivalTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arrival Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Burst Time";
            // 
            // lbBurstTime
            // 
            this.lbBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBurstTime.FormattingEnabled = true;
            this.lbBurstTime.ItemHeight = 20;
            this.lbBurstTime.Location = new System.Drawing.Point(458, 114);
            this.lbBurstTime.Name = "lbBurstTime";
            this.lbBurstTime.Size = new System.Drawing.Size(98, 124);
            this.lbBurstTime.TabIndex = 8;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(409, 253);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(409, 282);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SRTFMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 321);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbBurstTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbArrivalTime);
            this.Controls.Add(this.btnEnterATBT);
            this.Controls.Add(this.tbBurstTime);
            this.Controls.Add(this.tbArrivalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SRTFMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRTF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.TextBox tbBurstTime;
        private System.Windows.Forms.Button btnEnterATBT;
        private System.Windows.Forms.ListBox lbArrivalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbBurstTime;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
    }
}

