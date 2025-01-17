namespace SRTFPractice
{
    partial class Computations
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
            this.lbProcessID = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArrivalTime = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBurstTime = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWaitingTime = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAveWT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGanttChart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "SJRF CPU Scheduling";
            // 
            // lbProcessID
            // 
            this.lbProcessID.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbProcessID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessID.ForeColor = System.Drawing.Color.White;
            this.lbProcessID.FormattingEnabled = true;
            this.lbProcessID.ItemHeight = 20;
            this.lbProcessID.Location = new System.Drawing.Point(25, 111);
            this.lbProcessID.Name = "lbProcessID";
            this.lbProcessID.Size = new System.Drawing.Size(105, 120);
            this.lbProcessID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrival Time";
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbArrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.ForeColor = System.Drawing.Color.White;
            this.lbArrivalTime.FormattingEnabled = true;
            this.lbArrivalTime.ItemHeight = 20;
            this.lbArrivalTime.Location = new System.Drawing.Point(147, 111);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(105, 120);
            this.lbArrivalTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Burst Time";
            // 
            // lbBurstTime
            // 
            this.lbBurstTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbBurstTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBurstTime.ForeColor = System.Drawing.Color.White;
            this.lbBurstTime.FormattingEnabled = true;
            this.lbBurstTime.ItemHeight = 20;
            this.lbBurstTime.Location = new System.Drawing.Point(270, 111);
            this.lbBurstTime.Name = "lbBurstTime";
            this.lbBurstTime.Size = new System.Drawing.Size(105, 120);
            this.lbBurstTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Waiting Time";
            // 
            // lbWaitingTime
            // 
            this.lbWaitingTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbWaitingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingTime.ForeColor = System.Drawing.Color.White;
            this.lbWaitingTime.FormattingEnabled = true;
            this.lbWaitingTime.ItemHeight = 20;
            this.lbWaitingTime.Location = new System.Drawing.Point(393, 111);
            this.lbWaitingTime.Name = "lbWaitingTime";
            this.lbWaitingTime.Size = new System.Drawing.Size(105, 120);
            this.lbWaitingTime.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(371, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Average:";
            // 
            // lblAveWT
            // 
            this.lblAveWT.AutoSize = true;
            this.lblAveWT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAveWT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveWT.ForeColor = System.Drawing.Color.White;
            this.lblAveWT.Location = new System.Drawing.Point(444, 247);
            this.lblAveWT.Name = "lblAveWT";
            this.lblAveWT.Size = new System.Drawing.Size(21, 23);
            this.lblAveWT.TabIndex = 14;
            this.lblAveWT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gantt Chart:";
            // 
            // dgvGanttChart
            // 
            this.dgvGanttChart.AllowUserToAddRows = false;
            this.dgvGanttChart.AllowUserToDeleteRows = false;
            this.dgvGanttChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanttChart.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGanttChart.Location = new System.Drawing.Point(25, 297);
            this.dgvGanttChart.Name = "dgvGanttChart";
            this.dgvGanttChart.ReadOnly = true;
            this.dgvGanttChart.Size = new System.Drawing.Size(473, 44);
            this.dgvGanttChart.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 33);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(147, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 33);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(270, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 33);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(393, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 33);
            this.panel4.TabIndex = 20;
            // 
            // Computations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SRTFPractice.Properties.Resources._800f81b0_9ff4_4079_ac8b_072443e413471;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGanttChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAveWT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbWaitingTime);
            this.Controls.Add(this.lbBurstTime);
            this.Controls.Add(this.lbArrivalTime);
            this.Controls.Add(this.lbProcessID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Computations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computations";
            this.Load += new System.EventHandler(this.Computations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbProcessID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbArrivalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBurstTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbWaitingTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAveWT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGanttChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}