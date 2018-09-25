using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Probablity_Project_Txt
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int pos1;
        int pos2;
        string month;
        string month_index;
        string data;
        string data1;
        string data2;
        int length;
        int pos_cut1;
        int pos_cut2;
        int array_pos = 0;
        double[,] array;
        Series series1;
        Series series2;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            pos1 = 0;
            pos2 = 0;
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            if (choose_item5.SelectedItem.ToString() == "書報期刊")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("書報期刊.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

            else if (choose_item5.SelectedItem.ToString() == "學雜費")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("學雜費.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

            else if (choose_item5.SelectedItem.ToString() == "補習及學習費")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("補習及學習費.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

            else if (choose_item5.SelectedItem.ToString() == "教養設備及用具")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("教養設備及用具.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

            else if (choose_item5.SelectedItem.ToString() == "娛樂設備")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("娛樂設備.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

            else if (choose_item5.SelectedItem.ToString() == "娛樂服務")
            {
                StreamReader sr_mon = new StreamReader("Month.txt");
                StreamReader sr = new StreamReader("娛樂服務.txt");
                for (int i = 0; i < 197; i++)
                {
                    month = sr_mon.ReadLine();
                    if (begin_mon.SelectedItem.ToString() == month) pos1 = i;

                    if (end_mon.SelectedItem.ToString() == month) pos2 = i;
                }
                length = pos2 - pos1 + 1;
                array_pos = 0;
                array = new double[2, length];
                StreamReader sr_month = new StreamReader("Month.txt");

                for (int i = 0; i < 197; i++)
                {
                    data = sr.ReadLine();
                    month_index = sr_month.ReadLine();
                    if (i >= pos1 && i <= pos2)
                    {
                        listBox4.Items.Add(data);

                        pos_cut1 = data.IndexOf("\t");
                        pos_cut2 = data.LastIndexOf("\t");
                        data1 = data.Substring(pos_cut1 + 1, (pos_cut2 - pos_cut1 - 1));
                        data2 = data.Substring(pos_cut2);
                        array[0, array_pos] = double.Parse(data1);
                        array[1, array_pos] = double.Parse(data2);
                        array_pos++;
                    }
                }

                series1 = new Series("原始值", 200);
                series2 = new Series("年增率", 200);

                //設定線條顏色
                series1.Color = Color.Blue;
                series2.Color = Color.Red;

                //設定字型
                series1.Font = new System.Drawing.Font("新細明體", 14);
                series2.Font = new System.Drawing.Font("標楷體", 12);

                //折線圖
                series1.ChartType = SeriesChartType.Line;
                series2.ChartType = SeriesChartType.Line;

                //將數值顯示在線上
                //series1.IsValueShownAsLabel = true;
                //series2.IsValueShownAsLabel = true;

                //將數值新增至序列
                for (int index = 0; index < length; index++)
                {
                    series1.Points.AddXY(index, array[0, index]);
                    series2.Points.AddXY(index, array[1, index]);
                }

                //將序列新增到圖上
                this.chart1.Series.Add(series1);
                this.chart1.Series.Add(series2);

                //標題
                this.chart1.Titles.Add("作圖");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (choose_item5.SelectedItem.ToString() == "書報期刊")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("書報期刊.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            else if (choose_item5.SelectedItem.ToString() == "學雜費")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("學雜費.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            else if (choose_item5.SelectedItem.ToString() == "補習及學習費")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("補習及學習費.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            else if (choose_item5.SelectedItem.ToString() == "教養設備及用具")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("教養設備及用具.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            else if (choose_item5.SelectedItem.ToString() == "娛樂設備")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("娛樂設備.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            else if (choose_item5.SelectedItem.ToString() == "娛樂服務")
            {
                try
                {
                    linkLabel1.LinkVisited = true;
                    System.Diagnostics.Process.Start("娛樂服務.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }
        }
    }
}
