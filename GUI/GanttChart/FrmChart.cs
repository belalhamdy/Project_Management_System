using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Management_System;
using Project_Management_System.Entities;
using Task = Project_Management_System.Entities.Task;

namespace GanttChart
{
    public partial class FrmChart : Form
    {

        TextBox txtLog;
        GanttChart chart;

        private int projectId;
        private bool showActualHours;

        private Project project;
        private List<Task> tasks;

        // type = 0 -> no actual working hours else it will appear
        // takes the project that you wish to show it's chart
        public FrmChart(int projectId, bool showActualHours = true)
        {
            InitializeComponent();
            this.projectId = projectId;
            this.showActualHours = showActualHours;

            project = Program.dbms.GetProjectByID(projectId);
            tasks = Program.dbms.GetAllTasks(projectId);
        }

        private void FrmChart_Load(object sender, EventArgs e)
        {
            SaveImageToolStripMenuItem.Click += new EventHandler(SaveImageToolStripMenuItem_Click);

            txtLog = new TextBox();
            txtLog.Dock = DockStyle.Fill;
            txtLog.Multiline = true;
            txtLog.Enabled = false;
            txtLog.ScrollBars = ScrollBars.Horizontal;
            //tableLayoutPanel1.Controls.Add(txtLog, 0, 1);

            //first Gantt Chart
            chart = new GanttChart();
            chart.AllowChange = false;
            chart.Dock = DockStyle.Fill;

            chart.FromDate = project.StartingDate;
            chart.ToDate = project.DueDate;

            tableLayoutPanel1.Controls.Add(chart, 0, 0);

            chart.MouseMove += new MouseEventHandler(chart.GanttChart_MouseMove);
            chart.MouseMove += new MouseEventHandler(GanttChart1_MouseMove);
            chart.MouseDragged += new MouseEventHandler(chart.GanttChart_MouseDragged);
            chart.MouseLeave += new EventHandler(chart.GanttChart_MouseLeave);
            chart.ContextMenuStrip = ContextMenuGanttChart1;

            var barInformations = new List<BarInformation>();

            var rnd = new Random();
            var rowIdx = 0;
            for  (var idx = 0 ; idx < tasks.Count ; ++idx)
            {
                var firstColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                var secondColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                if (tasks[idx].IsMilestone)barInformations.Add(new BarInformation("MileStone " + idx + " : " + tasks[idx].Title,
                    project.StartingDate, tasks[idx].DueDate, firstColor, secondColor, rowIdx++));
                else
                {
                    barInformations.Add(new BarInformation("Task " + idx + " : " + tasks[idx].Title,
                        tasks[idx].StartingDate, tasks[idx].DueDate, firstColor, secondColor, rowIdx++));
                    if (!showActualHours || !(tasks[idx].ActualWorkingHours > 0)) continue;
                    var ActualWorkingDays = (double) tasks[idx].ActualWorkingHours / 8.0;
                    barInformations.Add(new BarInformation("Task " +idx + " : " + tasks[idx].Title + " (Actual)",
                        tasks[idx].StartingDate, tasks[idx].StartingDate.AddDays(ActualWorkingDays), firstColor,
                        secondColor, rowIdx++));
                }
            } 
            foreach (var bar in barInformations)
            {
                chart.AddChartBar(bar.RowText, bar, bar.FromTime, bar.ToTime, bar.Color, bar.HoverColor, bar.Index);
            }




        }

        private void GanttChart1_MouseMove(Object sender, MouseEventArgs e)
        {
            List<string> toolTipText = new List<string>();

            if (chart.MouseOverRowText.Length > 0)
            {
                BarInformation val = (BarInformation)chart.MouseOverRowValue;
                toolTipText.Add("[b]Date:");
                toolTipText.Add("From ");
                toolTipText.Add(val.FromTime.ToLongDateString() + " - " + val.FromTime.ToString("HH:mm"));
                toolTipText.Add("To ");
                toolTipText.Add(val.ToTime.ToLongDateString() + " - " + val.ToTime.ToString("HH:mm"));
            }
            else
            {
                toolTipText.Add("");
            }

            chart.ToolTipTextTitle = chart.MouseOverRowText;
            chart.ToolTipText = toolTipText;

        }


        private void SaveImageToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            Control chart = null;
            if (menuItem != null)
            {
                ContextMenuStrip calendarMenu = menuItem.Owner as ContextMenuStrip;

                if (calendarMenu != null)
                {
                    chart = calendarMenu.SourceControl;
                }
            }

            SaveImage(chart);
        }

        private void SaveImage(Control control)
        {
            GanttChart gantt = control as GanttChart;
            string filePath = Interaction.InputBox("Where to save the file?", "Save image", "C:\\Temp\\GanttChartTester.jpg");
            if (filePath.Length == 0)
                return;
            gantt.SaveImage(filePath);
            Interaction.MsgBox("Picture saved", MsgBoxStyle.Information);
        }


        private void FrmChart_Load_1(object sender, EventArgs e)
        {

        }
    }
}
