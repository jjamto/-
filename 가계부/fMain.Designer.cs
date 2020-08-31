namespace 가계부
{
    partial class fMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btIn = new System.Windows.Forms.ToolStripButton();
            this.btOut = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDelete = new System.Windows.Forms.ToolStripButton();
            this.btLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSumIN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSumOut = new System.Windows.Forms.ToolStripStatusLabel();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbMon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbAmt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btIn,
            this.btOut,
            this.btEdit,
            this.btDelete,
            this.btLogin,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.btConfirm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btIn
            // 
            this.btIn.Image = ((System.Drawing.Image)(resources.GetObject("btIn.Image")));
            this.btIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(51, 22);
            this.btIn.Text = "입금";
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btOut
            // 
            this.btOut.Image = ((System.Drawing.Image)(resources.GetObject("btOut.Image")));
            this.btOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(51, 22);
            this.btOut.Text = "출금";
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(51, 22);
            this.btEdit.Text = "편집";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(51, 22);
            this.btDelete.Text = "삭제";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btLogin
            // 
            this.btLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btLogin.Image = ((System.Drawing.Image)(resources.GetObject("btLogin.Image")));
            this.btLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(63, 22);
            this.btLogin.Text = "로그인";
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave,
            this.btLoad});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripDropDownButton1.Text = "TestMenu";
            // 
            // btSave
            // 
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(122, 22);
            this.btSave.Text = "저장";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(122, 22);
            this.btLoad.Text = "불러오기";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "월변경";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.lbMon,
            this.toolStripStatusLabel2,
            this.sbUserName,
            this.toolStripStatusLabel5,
            this.sbSumIN,
            this.toolStripStatusLabel1,
            this.sbSumOut,
            this.toolStripStatusLabel4,
            this.sbAmt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel2.Text = "사용자";
            // 
            // sbUserName
            // 
            this.sbUserName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sbUserName.Name = "sbUserName";
            this.sbUserName.Size = new System.Drawing.Size(16, 21);
            this.sbUserName.Text = "...";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel5.Text = "입금합";
            // 
            // sbSumIN
            // 
            this.sbSumIN.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sbSumIN.Name = "sbSumIN";
            this.sbSumIN.Size = new System.Drawing.Size(19, 21);
            this.sbSumIN.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel3.Text = "선택월";
            // 
            // sbSumOut
            // 
            this.sbSumOut.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sbSumOut.Name = "sbSumOut";
            this.sbSumOut.Size = new System.Drawing.Size(19, 21);
            this.sbSumOut.Text = "0";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv1.ContextMenuStrip = this.contextMenuStrip1;
            this.lv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv1.FullRowSelect = true;
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(0, 25);
            this.lv1.MultiSelect = false;
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(887, 446);
            this.lv1.TabIndex = 2;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.DoubleClick += new System.EventHandler(this.lv1_DoubleClick);
            this.lv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv1_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "날짜";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "분류";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "입금";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "출금";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "비고";
            this.columnHeader5.Width = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.편집ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.편집ToolStripMenuItem.Text = "편집";
            this.편집ToolStripMenuItem.Click += new System.EventHandler(this.편집ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btConfirm.Image")));
            this.btConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(63, 22);
            this.btConfirm.Text = "월마감";
            this.btConfirm.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 21);
            this.toolStripStatusLabel1.Text = "출금합";
            // 
            // lbMon
            // 
            this.lbMon.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(24, 21);
            this.lbMon.Text = "--";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(31, 21);
            this.toolStripStatusLabel4.Text = "잔액";
            // 
            // lbAmt
            // 
            this.sbAmt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sbAmt.Name = "lbAmt";
            this.sbAmt.Size = new System.Drawing.Size(19, 21);
            this.sbAmt.Text = "0";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 497);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "가계부";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btIn;
        private System.Windows.Forms.ToolStripButton btOut;
        private System.Windows.Forms.ToolStripButton btLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbSumOut;
        private System.Windows.Forms.ToolStripStatusLabel sbUserName;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripButton btDelete;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btSave;
        private System.Windows.Forms.ToolStripMenuItem btLoad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel sbSumIN;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btConfirm;
        private System.Windows.Forms.ToolStripStatusLabel lbMon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel sbAmt;
    }
}

