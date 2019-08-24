using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Nitro.Simulator.Entities;
using Nitro.Simulator.ExtensionMethods;
using Nitro.Simulator.Infrastructure;

namespace Nitro.Simulator.Views
{
    [Export(typeof(ExamSelectorView))]
    public partial class ExamSelectorView : XtraForm
    {
        private readonly IStorageManager _storageManager;
        private BindingList<ExamFileInfo> _examFiles;

        [ImportingConstructor]
        public ExamSelectorView(IStorageManager storageManager)
        {
            Load += ExamSelectorView_Load;
            _storageManager = storageManager;
            InitializeComponent();
        }

        private void ExamSelectorView_Load(object sender, EventArgs e)
        {
            _examFiles = new BindingList<ExamFileInfo>(_storageManager.GetExamFileInfoList());
            gridControlExamList.DataSource = _examFiles;
            gridViewExamList.BestFitColumns(true);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (xtraLoadFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            List<ExamFileInfo> examFileInfos = xtraLoadFileDialog.FileNames.ToExamFileInfoList();
            _storageManager.SaveExamFileInfos(examFileInfos);
            ExamSelectorView_Load(sender, e);
        }

        private void gridViewExamList_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
            BindingList<ExamFileInfo> dataSource = (BindingList<ExamFileInfo>)gridViewExamList.DataSource;
            int[] selectedRows = gridViewExamList.GetSelectedRows();
            if (!selectedRows.Any())
                return;
            int selectedRowHandle = selectedRows[0];
            ExamFileInfo info = dataSource[gridViewExamList.GetDataSourceRowIndex(selectedRowHandle)];

            _storageManager.RemoveExamInfo(info);
            ExamSelectorView_Load(sender, e);
        }
    }
}