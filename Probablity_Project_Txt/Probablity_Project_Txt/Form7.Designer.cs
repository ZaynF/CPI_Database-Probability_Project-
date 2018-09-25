namespace Probablity_Project_Txt
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.end_mon = new System.Windows.Forms.ComboBox();
            this.begin_mon = new System.Windows.Forms.ComboBox();
            this.choose_item6 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 12;
            this.listBox4.Location = new System.Drawing.Point(56, 103);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(238, 460);
            this.listBox4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(63, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "月份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F);
            this.label2.Location = new System.Drawing.Point(193, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "年增率(%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(138, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "原始值";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // end_mon
            // 
            this.end_mon.FormattingEnabled = true;
            this.end_mon.Items.AddRange(new object[] {
            "2001M01",
            "2001M02",
            "2001M03",
            "2001M04",
            "2001M05",
            "2001M06",
            "2001M07",
            "2001M08",
            "2001M09",
            "2001M10",
            "2001M11",
            "2001M12",
            "2002M01",
            "2002M02",
            "2002M03",
            "2002M04",
            "2002M05",
            "2002M06",
            "2002M07",
            "2002M08",
            "2002M09",
            "2002M10",
            "2002M11",
            "2002M12",
            "2003M01",
            "2003M02",
            "2003M03",
            "2003M04",
            "2003M05",
            "2003M06",
            "2003M07",
            "2003M08",
            "2003M09",
            "2003M10",
            "2003M11",
            "2003M12",
            "2004M01",
            "2004M02",
            "2004M03",
            "2004M04",
            "2004M05",
            "2004M06",
            "2004M07",
            "2004M08",
            "2004M09",
            "2004M10",
            "2004M11",
            "2004M12",
            "2005M01",
            "2005M02",
            "2005M03",
            "2005M04",
            "2005M05",
            "2005M06",
            "2005M07",
            "2005M08",
            "2005M09",
            "2005M10",
            "2005M11",
            "2005M12",
            "2006M01",
            "2006M02",
            "2006M03",
            "2006M04",
            "2006M05",
            "2006M06",
            "2006M07",
            "2006M08",
            "2006M09",
            "2006M10",
            "2006M11",
            "2006M12",
            "2007M01",
            "2007M02",
            "2007M03",
            "2007M04",
            "2007M05",
            "2007M06",
            "2007M07",
            "2007M08",
            "2007M09",
            "2007M10",
            "2007M11",
            "2007M12",
            "2008M01",
            "2008M02",
            "2008M03",
            "2008M04",
            "2008M05",
            "2008M06",
            "2008M07",
            "2008M08",
            "2008M09",
            "2008M10",
            "2008M11",
            "2008M12",
            "2009M01",
            "2009M02",
            "2009M03",
            "2009M04",
            "2009M05",
            "2009M06",
            "2009M07",
            "2009M08",
            "2009M09",
            "2009M10",
            "2009M11",
            "2009M12",
            "2010M01",
            "2010M02",
            "2010M03",
            "2010M04",
            "2010M05",
            "2010M06",
            "2010M07",
            "2010M08",
            "2010M09",
            "2010M10",
            "2010M11",
            "2010M12",
            "2011M01",
            "2011M02",
            "2011M03",
            "2011M04",
            "2011M05",
            "2011M06",
            "2011M07",
            "2011M08",
            "2011M09",
            "2011M10",
            "2011M11",
            "2011M12",
            "2012M01",
            "2012M02",
            "2012M03",
            "2012M04",
            "2012M05",
            "2012M06",
            "2012M07",
            "2012M08",
            "2012M09",
            "2012M10",
            "2012M11",
            "2012M12",
            "2013M01",
            "2013M02",
            "2013M03",
            "2013M04",
            "2013M05",
            "2013M06",
            "2013M07",
            "2013M08",
            "2013M09",
            "2013M10",
            "2013M11",
            "2013M12",
            "2014M01",
            "2014M02",
            "2014M03",
            "2014M04",
            "2014M05",
            "2014M06",
            "2014M07",
            "2014M08",
            "2014M09",
            "2014M10",
            "2014M11",
            "2014M12",
            "2015M01",
            "2015M02",
            "2015M03",
            "2015M04",
            "2015M05",
            "2015M06",
            "2015M07",
            "2015M08",
            "2015M09",
            "2015M10",
            "2015M11",
            "2015M12",
            "2016M01",
            "2016M02",
            "2016M03",
            "2016M04",
            "2016M05",
            "2016M06",
            "2016M07",
            "2016M08",
            "2016M09",
            "2016M10",
            "2016M11",
            "2016M12",
            "2017M01",
            "2017M02",
            "2017M03",
            "2017M04",
            "2017M05"});
            this.end_mon.Location = new System.Drawing.Point(540, 43);
            this.end_mon.Name = "end_mon";
            this.end_mon.Size = new System.Drawing.Size(121, 20);
            this.end_mon.TabIndex = 13;
            // 
            // begin_mon
            // 
            this.begin_mon.FormattingEnabled = true;
            this.begin_mon.Items.AddRange(new object[] {
            "2001M01",
            "2001M02",
            "2001M03",
            "2001M04",
            "2001M05",
            "2001M06",
            "2001M07",
            "2001M08",
            "2001M09",
            "2001M10",
            "2001M11",
            "2001M12",
            "2002M01",
            "2002M02",
            "2002M03",
            "2002M04",
            "2002M05",
            "2002M06",
            "2002M07",
            "2002M08",
            "2002M09",
            "2002M10",
            "2002M11",
            "2002M12",
            "2003M01",
            "2003M02",
            "2003M03",
            "2003M04",
            "2003M05",
            "2003M06",
            "2003M07",
            "2003M08",
            "2003M09",
            "2003M10",
            "2003M11",
            "2003M12",
            "2004M01",
            "2004M02",
            "2004M03",
            "2004M04",
            "2004M05",
            "2004M06",
            "2004M07",
            "2004M08",
            "2004M09",
            "2004M10",
            "2004M11",
            "2004M12",
            "2005M01",
            "2005M02",
            "2005M03",
            "2005M04",
            "2005M05",
            "2005M06",
            "2005M07",
            "2005M08",
            "2005M09",
            "2005M10",
            "2005M11",
            "2005M12",
            "2006M01",
            "2006M02",
            "2006M03",
            "2006M04",
            "2006M05",
            "2006M06",
            "2006M07",
            "2006M08",
            "2006M09",
            "2006M10",
            "2006M11",
            "2006M12",
            "2007M01",
            "2007M02",
            "2007M03",
            "2007M04",
            "2007M05",
            "2007M06",
            "2007M07",
            "2007M08",
            "2007M09",
            "2007M10",
            "2007M11",
            "2007M12",
            "2008M01",
            "2008M02",
            "2008M03",
            "2008M04",
            "2008M05",
            "2008M06",
            "2008M07",
            "2008M08",
            "2008M09",
            "2008M10",
            "2008M11",
            "2008M12",
            "2009M01",
            "2009M02",
            "2009M03",
            "2009M04",
            "2009M05",
            "2009M06",
            "2009M07",
            "2009M08",
            "2009M09",
            "2009M10",
            "2009M11",
            "2009M12",
            "2010M01",
            "2010M02",
            "2010M03",
            "2010M04",
            "2010M05",
            "2010M06",
            "2010M07",
            "2010M08",
            "2010M09",
            "2010M10",
            "2010M11",
            "2010M12",
            "2011M01",
            "2011M02",
            "2011M03",
            "2011M04",
            "2011M05",
            "2011M06",
            "2011M07",
            "2011M08",
            "2011M09",
            "2011M10",
            "2011M11",
            "2011M12",
            "2012M01",
            "2012M02",
            "2012M03",
            "2012M04",
            "2012M05",
            "2012M06",
            "2012M07",
            "2012M08",
            "2012M09",
            "2012M10",
            "2012M11",
            "2012M12",
            "2013M01",
            "2013M02",
            "2013M03",
            "2013M04",
            "2013M05",
            "2013M06",
            "2013M07",
            "2013M08",
            "2013M09",
            "2013M10",
            "2013M11",
            "2013M12",
            "2014M01",
            "2014M02",
            "2014M03",
            "2014M04",
            "2014M05",
            "2014M06",
            "2014M07",
            "2014M08",
            "2014M09",
            "2014M10",
            "2014M11",
            "2014M12",
            "2015M01",
            "2015M02",
            "2015M03",
            "2015M04",
            "2015M05",
            "2015M06",
            "2015M07",
            "2015M08",
            "2015M09",
            "2015M10",
            "2015M11",
            "2015M12",
            "2016M01",
            "2016M02",
            "2016M03",
            "2016M04",
            "2016M05",
            "2016M06",
            "2016M07",
            "2016M08",
            "2016M09",
            "2016M10",
            "2016M11",
            "2016M12",
            "2017M01",
            "2017M02",
            "2017M03",
            "2017M04",
            "2017M05"});
            this.begin_mon.Location = new System.Drawing.Point(321, 44);
            this.begin_mon.Name = "begin_mon";
            this.begin_mon.Size = new System.Drawing.Size(121, 20);
            this.begin_mon.TabIndex = 12;
            // 
            // choose_item6
            // 
            this.choose_item6.FormattingEnabled = true;
            this.choose_item6.Items.AddRange(new object[] {
            "醫療費用",
            "藥品及保健食品",
            "醫療保健器材"});
            this.choose_item6.Location = new System.Drawing.Point(60, 43);
            this.choose_item6.Name = "choose_item6";
            this.choose_item6.Size = new System.Drawing.Size(121, 20);
            this.choose_item6.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(345, 103);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(465, 465);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(243, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "開始月份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(462, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "結束月份";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("新細明體", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(301, 550);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "全圖";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 591);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.end_mon);
            this.Controls.Add(this.begin_mon);
            this.Controls.Add(this.choose_item6);
            this.Name = "Form7";
            this.Text = "醫藥保健類";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox end_mon;
        private System.Windows.Forms.ComboBox begin_mon;
        private System.Windows.Forms.ComboBox choose_item6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}