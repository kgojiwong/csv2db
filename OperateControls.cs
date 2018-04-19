﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoDatabase
{

    public class OperateControls
    {
        private static Form1 mainForm = Program.getMainForm();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        internal delegate void setStatusLabelTextDelegate(string text);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        internal delegate void setProgressBarValueDelegate(int value);

        internal delegate void appendTextBoxTextDelegate(string text);

        internal delegate void setProgressBarMaxDelegate(int value);
        internal static void setStatusLabelText(string text)
        {
            mainForm.toolStripStatusLabel1.Text = text;
            return;
        }

        internal static void setProgressBar(int value)
        {
            mainForm.toolStripProgressBar1.Value = value;
            return;
        }

        internal static void SetProgressBarMax(int value)
        {
            mainForm.toolStripProgressBar1.Maximum = value;
        }
        internal static void appendTextBoxText(string text)
        {
            mainForm.textBoxLog.AppendText(text);
        }
    }
}
