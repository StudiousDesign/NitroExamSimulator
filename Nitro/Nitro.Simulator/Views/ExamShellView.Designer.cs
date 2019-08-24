namespace Nitro.Simulator.Views
{
    partial class ExamShellView
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnEndSession = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnPreviousQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNextQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnShowAnswer = new DevExpress.XtraEditors.CheckButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.examSessionHeaderControl1 = new Nitro.Simulator.CustomControls.ExamSessionHeaderControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.examQuestionControl1 = new Nitro.Simulator.CustomControls.ExamQuestionControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.examQuestionControl1);
            this.layoutControl1.Controls.Add(this.examSessionHeaderControl1);
            this.layoutControl1.Controls.Add(this.btnShowAnswer);
            this.layoutControl1.Controls.Add(this.btnNextQuestion);
            this.layoutControl1.Controls.Add(this.btnPreviousQuestion);
            this.layoutControl1.Controls.Add(this.btnEndSession);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1203, 677);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem1,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1203, 677);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // btnEndSession
            // 
            this.btnEndSession.Location = new System.Drawing.Point(1124, 650);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(74, 22);
            this.btnEndSession.StyleController = this.layoutControl1;
            this.btnEndSession.TabIndex = 5;
            this.btnEndSession.Text = "End Session";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEndSession;
            this.layoutControlItem2.Location = new System.Drawing.Point(1119, 645);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(84, 32);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 645);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1119, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnPreviousQuestion
            // 
            this.btnPreviousQuestion.Location = new System.Drawing.Point(5, 618);
            this.btnPreviousQuestion.Name = "btnPreviousQuestion";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(71, 22);
            this.btnPreviousQuestion.StyleController = this.layoutControl1;
            this.btnPreviousQuestion.TabIndex = 7;
            this.btnPreviousQuestion.Text = "Previous";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPreviousQuestion;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 613);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(81, 32);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(81, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(81, 32);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(86, 618);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(71, 22);
            this.btnNextQuestion.StyleController = this.layoutControl1;
            this.btnNextQuestion.TabIndex = 8;
            this.btnNextQuestion.Text = "Next";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnNextQuestion;
            this.layoutControlItem4.Location = new System.Drawing.Point(81, 613);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(81, 32);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(81, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(81, 32);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(162, 613);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(957, 32);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(1124, 618);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(74, 22);
            this.btnShowAnswer.StyleController = this.layoutControl1;
            this.btnShowAnswer.TabIndex = 9;
            this.btnShowAnswer.Text = "Show Answer";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnShowAnswer;
            this.layoutControlItem5.Location = new System.Drawing.Point(1119, 613);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(84, 32);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // examSessionHeaderControl1
            // 
            this.examSessionHeaderControl1.Location = new System.Drawing.Point(2, 2);
            this.examSessionHeaderControl1.Name = "examSessionHeaderControl1";
            this.examSessionHeaderControl1.Size = new System.Drawing.Size(1199, 49);
            this.examSessionHeaderControl1.TabIndex = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.examSessionHeaderControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 53);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1203, 53);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // examQuestionControl1
            // 
            this.examQuestionControl1.Location = new System.Drawing.Point(2, 55);
            this.examQuestionControl1.Margin = new System.Windows.Forms.Padding(0);
            this.examQuestionControl1.Name = "examQuestionControl1";
            this.examQuestionControl1.Size = new System.Drawing.Size(1199, 556);
            this.examQuestionControl1.TabIndex = 11;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.examQuestionControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1203, 560);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // ExamShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 677);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ExamShellView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamShellView";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckButton btnShowAnswer;
        private DevExpress.XtraEditors.SimpleButton btnNextQuestion;
        private DevExpress.XtraEditors.SimpleButton btnPreviousQuestion;
        private DevExpress.XtraEditors.SimpleButton btnEndSession;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private CustomControls.ExamSessionHeaderControl examSessionHeaderControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private CustomControls.ExamQuestionControl examQuestionControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}