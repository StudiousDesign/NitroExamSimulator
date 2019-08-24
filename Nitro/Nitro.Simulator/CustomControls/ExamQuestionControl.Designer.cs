namespace Nitro.Simulator.CustomControls
{
    partial class ExamQuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciQuestionText = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.placeholderAnswerControl1 = new Nitro.Simulator.CustomControls.PlaceholderAnswerControl();
            this.lciAnswerControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAnswerControl)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.placeholderAnswerControl1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1059, 513);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciQuestionText,
            this.lciAnswerControl});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1059, 513);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciQuestionText
            // 
            this.lciQuestionText.Control = this.textEdit1;
            this.lciQuestionText.Location = new System.Drawing.Point(0, 0);
            this.lciQuestionText.Name = "lciQuestionText";
            this.lciQuestionText.Size = new System.Drawing.Size(1039, 96);
            this.lciQuestionText.Text = "Question Text";
            this.lciQuestionText.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciQuestionText.TextSize = new System.Drawing.Size(74, 13);
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "zjjhkdzfjkhdfzsjkfdjkf";
            this.textEdit1.Location = new System.Drawing.Point(12, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(1035, 76);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 5;
            // 
            // placeholderAnswerControl1
            // 
            this.placeholderAnswerControl1.Location = new System.Drawing.Point(12, 124);
            this.placeholderAnswerControl1.Name = "placeholderAnswerControl1";
            this.placeholderAnswerControl1.Size = new System.Drawing.Size(1035, 377);
            this.placeholderAnswerControl1.TabIndex = 6;
            // 
            // lciAnswerControl
            // 
            this.lciAnswerControl.Control = this.placeholderAnswerControl1;
            this.lciAnswerControl.Location = new System.Drawing.Point(0, 96);
            this.lciAnswerControl.Name = "lciAnswerControl";
            this.lciAnswerControl.Size = new System.Drawing.Size(1039, 397);
            this.lciAnswerControl.Text = "Answer Control";
            this.lciAnswerControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciAnswerControl.TextSize = new System.Drawing.Size(74, 13);
            // 
            // ExamQuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ExamQuestionControl";
            this.Size = new System.Drawing.Size(1059, 513);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAnswerControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionText;
        private PlaceholderAnswerControl placeholderAnswerControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciAnswerControl;
    }
}
