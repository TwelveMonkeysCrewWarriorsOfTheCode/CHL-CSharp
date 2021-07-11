using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectUtilsLibraryHelper;

namespace WinFormsProjectUtilsLibraryHelper
{
    public partial class Form1 : Form
    {
        public Form1()            //Console.WriteLine($"|{timeResult}|");
        {
            InitializeComponent();
            UtilsDateTimeHelper time1, time2, time3, timeResult;
            bool resultcomparison;
            // Time >= Time
            time1 = new UtilsDateTimeHelper(4, 15, 12);
            time2 = new UtilsDateTimeHelper(4, 15, 11);
            resultcomparison = time1 >= time2;
            TxtConsole.Text = $"(Time>=Time)     {time1} >= {time2} = {resultcomparison}\r\n";

            time1 = new UtilsDateTimeHelper(2, 43, 57);
            time2 = new UtilsDateTimeHelper(3, 25);
            time3 = new UtilsDateTimeHelper(6, 8, 57);
            timeResult = time1 + time2;
            TxtConsole.Text += $"|{timeResult}|\r\n";
        }

    }
}
