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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SRTF CPU Scheduling";
            // 
            // lbProcessID
            // 
            this.lbProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessID.FormattingEnabled = true;
            this.lbProcessID.ItemHeight = 20;
            this.lbProcessID.Location = new System.Drawing.Point(25, 99);
            this.lbProcessID.Name = "lbProcessID";
            this.lbProcessID.Size = new System.Drawing.Size(105, 124);
            this.lbProcessID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arrival Time";
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrivalTime.FormattingEnabled = true;
            this.lbArrivalTime.ItemHeight = 20;
            this.lbArrivalTime.Location = new System.Drawing.Point(147, 99);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(105, 124);
            this.lbArrivalTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Burst Time";
            // 
            // lbBurstTime
            // 
            this.lbBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBurstTime.FormattingEnabled = true;
            this.lbBurstTime.ItemHeight = 20;
            this.lbBurstTime.Location = new System.Drawing.Point(270, 99);
            this.lbBurstTime.Name = "lbBurstTime";
            this.lbBurstTime.Size = new System.Drawing.Size(105, 124);
            this.lbBurstTime.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Waiting Time";
            // 
            // lbWaitingTime
            // 
            this.lbWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingTime.FormattingEnabled = true;
            this.lbWaitingTime.ItemHeight = 20;
            this.lbWaitingTime.Location = new System.Drawing.Point(393, 99);
            this.lbWaitingTime.Name = "lbWaitingTime";
            this.lbWaitingTime.Size = new System.Drawing.Size(105, 124);
            this.lbWaitingTime.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Average:";
            // 
            // lblAveWT
            // 
            this.lblAveWT.AutoSize = true;
            this.lblAveWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveWT.Location = new System.Drawing.Point(444, 235);
            this.lblAveWT.Name = "lblAveWT";
            this.lblAveWT.Size = new System.Drawing.Size(18, 20);
            this.lblAveWT.TabIndex = 14;
            this.lblAveWT.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gantt Chart:";
            // 
            // dgvGanttChart
            // 
            this.dgvGanttChart.AllowUserToAddRows = false;
            this.dgvGanttChart.AllowUserToDeleteRows = false;
            this.dgvGanttChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanttChart.Location = new System.Drawing.Point(25, 285);
            this.dgvGanttChart.Name = "dgvGanttChart";
            this.dgvGanttChart.ReadOnly = true;
            this.dgvGanttChart.Size = new System.Drawing.Size(473, 33);
            this.dgvGanttChart.TabIndex = 16;
            // 
            // Computations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 359);
            this.Controls.Add(this.dgvGanttChart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAveWT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbWaitingTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbBurstTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArrivalTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProcessID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Computations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computations";
            this.Load += new System.EventHandler(this.Computations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanttChart)).EndInit();
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
    }
}