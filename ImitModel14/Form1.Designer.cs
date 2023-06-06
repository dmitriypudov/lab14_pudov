
namespace SimulationModel14
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OperatorsNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FlowLambda = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.OperatorLambda = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalClients = new System.Windows.Forms.Label();
            this.MaxQueue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlowLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTime)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(658, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(658, 75);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(130, 45);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // OperatorsNumber
            // 
            this.OperatorsNumber.Location = new System.Drawing.Point(155, 12);
            this.OperatorsNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.OperatorsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OperatorsNumber.Name = "OperatorsNumber";
            this.OperatorsNumber.Size = new System.Drawing.Size(44, 27);
            this.OperatorsNumber.TabIndex = 2;
            this.OperatorsNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во гардеробов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Интенсивность потока:";
            // 
            // FlowLambda
            // 
            this.FlowLambda.DecimalPlaces = 1;
            this.FlowLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FlowLambda.Location = new System.Drawing.Point(179, 49);
            this.FlowLambda.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FlowLambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.FlowLambda.Name = "FlowLambda";
            this.FlowLambda.Size = new System.Drawing.Size(57, 27);
            this.FlowLambda.TabIndex = 5;
            this.FlowLambda.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Интенсивность гардеробщиков:";
            // 
            // OperatorLambda
            // 
            this.OperatorLambda.DecimalPlaces = 1;
            this.OperatorLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.OperatorLambda.Location = new System.Drawing.Point(242, 85);
            this.OperatorLambda.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.OperatorLambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.OperatorLambda.Name = "OperatorLambda";
            this.OperatorLambda.Size = new System.Drawing.Size(51, 27);
            this.OperatorLambda.TabIndex = 7;
            this.OperatorLambda.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Общее время: ";
            // 
            // TotalTime
            // 
            this.TotalTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TotalTime.Location = new System.Drawing.Point(121, 121);
            this.TotalTime.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TotalTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Size = new System.Drawing.Size(52, 27);
            this.TotalTime.TabIndex = 9;
            this.TotalTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Общее количество посетителей:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество в очереди: ";
            // 
            // TotalClients
            // 
            this.TotalClients.AutoSize = true;
            this.TotalClients.Location = new System.Drawing.Point(482, 207);
            this.TotalClients.Name = "TotalClients";
            this.TotalClients.Size = new System.Drawing.Size(17, 20);
            this.TotalClients.TabIndex = 13;
            this.TotalClients.Text = "0";
            // 
            // MaxQueue
            // 
            this.MaxQueue.AutoSize = true;
            this.MaxQueue.Location = new System.Drawing.Point(447, 252);
            this.MaxQueue.Name = "MaxQueue";
            this.MaxQueue.Size = new System.Drawing.Size(17, 20);
            this.MaxQueue.TabIndex = 14;
            this.MaxQueue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 360);
            this.Controls.Add(this.MaxQueue);
            this.Controls.Add(this.TotalClients);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OperatorLambda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FlowLambda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorsNumber);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OperatorsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlowLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown OperatorsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FlowLambda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown OperatorLambda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TotalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalClients;
        private System.Windows.Forms.Label MaxQueue;
    }
}

