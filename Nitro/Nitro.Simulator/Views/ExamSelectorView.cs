using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Nitro.Simulator.Entities;
using Nitro.Simulator.ExtensionMethods;
using Nitro.Simulator.Infrastructure;
using Nitro.Simulator.Infrastructure.Interfaces;

namespace Nitro.Simulator.Views
{
    [Export(typeof(ExamSelectorView))]
    public partial class ExamSelectorView : XtraForm
    {
        private readonly IStorageManager _storageManager;
        private readonly IExamManager _examManager;
        private BindingList<ExamFileInfo> _examFiles;

        public ExamFileInfo SelectedExamFile
        {
            get
            {
                BindingList<ExamFileInfo> dataSource = (BindingList<ExamFileInfo>)gridViewExamList.DataSource;

                if (dataSource == null)
                    return null;

                int[] selectedRows = gridViewExamList.GetSelectedRows();
                if (!selectedRows.Any())
                    return null;

                int selectedRowHandle = selectedRows[0];
                return dataSource[gridViewExamList.GetDataSourceRowIndex(selectedRowHandle)];
            }
        }

        [ImportingConstructor]
        public ExamSelectorView(IStorageManager storageManager, IExamManager examManager)
        {
            _storageManager = storageManager;
            _examManager = examManager;
            _examManager.OnExamCompleted += OnExamCompleted;
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (xtraLoadFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            List<ExamFileInfo> examFileInfos = xtraLoadFileDialog.FileNames.ToExamFileInfoList();
            _storageManager.SaveExamFileInfos(examFileInfos);
            ExamSelectorView_Load(sender, e);
        }

        private void gridViewExamList_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        {
            var view = (GridView)sender;

            if (view != null && view.RowCount != 0)
                return;

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Nothing to see here...", e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (SelectedExamFile != null && MessageBox.Show("Are you sure?", "Remove exam file", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _storageManager.RemoveExamInfo(SelectedExamFile);
                ExamSelectorView_Load(sender, e);
            }
        }

        private void ExamSelectorView_Load(object sender, EventArgs e)
        {
            _examFiles = new BindingList<ExamFileInfo>(_storageManager.GetExamFileInfoList());
            gridControlExamList.DataSource = _examFiles;
            gridViewExamList.BestFitColumns(true);
        }

        private void btnStartSelected_Click(object sender, EventArgs e)
        {
            this.Hide();
            _examManager.BeginExam(SelectedExamFile);
        }

        private void OnExamCompleted(object sender, ExamOutcome e)
        {
            this.Show();
        }
    }
}