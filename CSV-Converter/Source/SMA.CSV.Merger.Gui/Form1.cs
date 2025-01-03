using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using AT;
using AT.Data;
using AT.ClassExtensions;
using AT.Threading;
using NLog;


using AT.Office.ExcelXML;
using AT.ClassExtensions;


namespace SMA.CSV.Merger
{
    public partial class Form1 : Form
    {        
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        GuiBackgroundWorker  _BgTask;
        SmaCsvTableConverter _Converter;

        public Form1()
        {
            InitializeComponent();
            _BgTask = new GuiBackgroundWorker();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            //NLog
            var target = new NLog.Windows.Forms.RichTextBoxTarget();
            target.Name = "richtText";
            target.ControlName = txtNLog.Name;
            target.FormName = this.Name;
            target.UseDefaultRowColoringRules = true;
            target.AutoScroll = true;
            target.MaxLines = 1000;
            target.Layout = @"${date:format=HH\:mm\:ss} | ${level:uppercase=true} | ${message} | ${exception}";

            NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, LogLevel.Trace);
            


            //Init BackgroundTask, run print job inside
            _BgTask.ProcessRun         += BackgroundTask_Run;
            _BgTask.GuiThreadSafeStart += BackgroundTask_GuiThreadSafeStart;
            _BgTask.GuiThreadSafeEnd   += BackgroundTask_GuiThreadSafeEnd;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new SaveFileDialog();
                dlg.Filter = "XLS|*.xls|CSV|*.csv";
                dlg.Title = "Save merged file.";
                if (dlg.ShowDialog() == DialogResult.OK)
                    txtOutput.SetData(dlg.FileName);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }


        private void btnOpenPath_LinkClicked(object sender, EventArgs e)
        {
            var file = txtOutput.GetFirstUNCPath();
            if(File.Exists(file))
                System.Diagnostics.Process.Start(Path.GetDirectoryName(file));
        }

        private void btnOpenFile_LinkClicked(object sender, EventArgs e)
        {
            var file = txtOutput.GetFirstUNCPath();
            if (File.Exists(file))
                System.Diagnostics.Process.Start(file);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtNLog.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var outputFile = txtOutput.GetUNCPathesAsText();

            if (sender == btnConvert2 && Path.GetExtension(outputFile) != ".csv")
                txtOutput.SetData( Path.ChangeExtension(outputFile, ".csv") );

            if (sender == btnConvert1 && Path.GetExtension(outputFile) != ".xls")
                txtOutput.SetData( Path.ChangeExtension(outputFile, ".xls") );

            _BgTask.Start();
        }

        private void BackgroundTask_GuiThreadSafeStart(object sender, ProcessEventArgs e)
        {
            btnConvert1.Enabled = false;
            btnOpenFile.Enabled = false;
            btnOpenPath.Enabled = false;

            var input  = txtInput.GetUNCPathes();
            var output = txtOutput.GetFirstUNCPath();

            _Converter = new SmaCsvTableConverter(input);
            e.ProcessEndArg = output;
        }

        private void BackgroundTask_Run(object sender, ProcessEventArgs e)
        {
            try
            {
                var table = _Converter.ToDataTable();
                var outputFile = e.ProcessEndArg.ToString();

                var docArgs = new DocumentInputData();
                docArgs.Data3 = table;
                docArgs.FileName = outputFile;


                if (Path.GetExtension(outputFile) == ".csv")
                {
                    var srvc = new DataListExporter();
                    srvc.DocumentProperties = docArgs;
                    srvc.ExportToCsv();
                }
                else
                {
                    var doc = ExcelDocument.CreateFromDataTable(table, docArgs);
                    doc.Save(outputFile);
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex);
            }
        }


        private void BackgroundTask_GuiThreadSafeEnd(object sender, ProcessEventArgs e)
        {
            btnConvert1.Enabled = true;
            btnOpenFile.Enabled = true;
            btnOpenPath.Enabled = true;


            btnOpenFile_LinkClicked(sender, e);
        }
    }
}
