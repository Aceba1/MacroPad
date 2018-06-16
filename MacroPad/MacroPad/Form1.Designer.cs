namespace MacroPad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelSerialStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageScript = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxScript = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxAddWhere = new System.Windows.Forms.ListBox();
            this.labelAddWhere = new System.Windows.Forms.Label();
            this.listBoxAddType = new System.Windows.Forms.ListBox();
            this.labelAddType = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonEditDelete = new System.Windows.Forms.Button();
            this.buttonEditMoveDown = new System.Windows.Forms.Button();
            this.buttonEditMoveUp = new System.Windows.Forms.Button();
            this.textBoxEditDelayValue = new System.Windows.Forms.TextBox();
            this.labelEditDelay = new System.Windows.Forms.Label();
            this.listBoxEditPinMode = new System.Windows.Forms.ListBox();
            this.labelEditPinMode = new System.Windows.Forms.Label();
            this.textBoxEditPinId = new System.Windows.Forms.TextBox();
            this.labelEditPinId = new System.Windows.Forms.Label();
            this.labelEditEmpty = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.tabPageDirect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxOverride = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxOverridePModeUp = new System.Windows.Forms.ListBox();
            this.labelOverridePModeUp = new System.Windows.Forms.Label();
            this.listBoxOverridePModeDown = new System.Windows.Forms.ListBox();
            this.labelOverridePModeDown = new System.Windows.Forms.Label();
            this.textBoxOverrideId = new System.Windows.Forms.TextBox();
            this.labelOverrideId = new System.Windows.Forms.Label();
            this.textBoxOverrideKey = new System.Windows.Forms.TextBox();
            this.labelOverrideKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonOverrideAdd = new System.Windows.Forms.Button();
            this.buttonOverrideDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxOverrideRecord = new System.Windows.Forms.CheckBox();
            this.checkBoxOverride = new System.Windows.Forms.CheckBox();
            this.richTextBoxOverrideInput = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageScript.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.tabPageDirect.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 331);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonConnect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxLoop);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRun);
            this.splitContainer1.Panel2.Controls.Add(this.labelSerialStatus);
            this.splitContainer1.Size = new System.Drawing.Size(454, 20);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConnect.Location = new System.Drawing.Point(0, 0);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(126, 20);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Auto-Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxLoop.Location = new System.Drawing.Point(202, 0);
            this.checkBoxLoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(50, 20);
            this.checkBoxLoop.TabIndex = 2;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.Loop_CheckedChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRun.Location = new System.Drawing.Point(252, 0);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(73, 20);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Start Script";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // labelSerialStatus
            // 
            this.labelSerialStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialStatus.Location = new System.Drawing.Point(0, 0);
            this.labelSerialStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSerialStatus.Name = "labelSerialStatus";
            this.labelSerialStatus.Size = new System.Drawing.Size(325, 20);
            this.labelSerialStatus.TabIndex = 0;
            this.labelSerialStatus.Text = "No serial";
            this.labelSerialStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageScript);
            this.tabControl1.Controls.Add(this.tabPageDirect);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 325);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChanged);
            // 
            // tabPageScript
            // 
            this.tabPageScript.Controls.Add(this.tableLayoutPanel2);
            this.tabPageScript.Location = new System.Drawing.Point(4, 22);
            this.tabPageScript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageScript.Name = "tabPageScript";
            this.tabPageScript.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageScript.Size = new System.Drawing.Size(446, 299);
            this.tabPageScript.TabIndex = 0;
            this.tabPageScript.Text = "Script";
            this.tabPageScript.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxScript, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 295);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listBoxScript
            // 
            this.listBoxScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxScript.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBoxScript.FormattingEnabled = true;
            this.listBoxScript.Location = new System.Drawing.Point(114, 2);
            this.listBoxScript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxScript.Name = "listBoxScript";
            this.listBoxScript.Size = new System.Drawing.Size(326, 291);
            this.listBoxScript.TabIndex = 0;
            this.listBoxScript.SelectedIndexChanged += new System.EventHandler(this.Script_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelEdit, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(108, 291);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.listBoxAddWhere);
            this.panelAdd.Controls.Add(this.labelAddWhere);
            this.panelAdd.Controls.Add(this.listBoxAddType);
            this.panelAdd.Controls.Add(this.labelAddType);
            this.panelAdd.Controls.Add(this.labelAdd);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(2, 2);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(104, 158);
            this.panelAdd.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.Location = new System.Drawing.Point(0, 136);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 20);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add it";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // listBoxAddWhere
            // 
            this.listBoxAddWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxAddWhere.FormattingEnabled = true;
            this.listBoxAddWhere.Items.AddRange(new object[] {
            "At Top",
            "Above Sel",
            "Below Sel",
            "At Bottom"});
            this.listBoxAddWhere.Location = new System.Drawing.Point(0, 93);
            this.listBoxAddWhere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAddWhere.Name = "listBoxAddWhere";
            this.listBoxAddWhere.Size = new System.Drawing.Size(104, 43);
            this.listBoxAddWhere.TabIndex = 8;
            // 
            // labelAddWhere
            // 
            this.labelAddWhere.AutoSize = true;
            this.labelAddWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddWhere.Location = new System.Drawing.Point(0, 76);
            this.labelAddWhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddWhere.Name = "labelAddWhere";
            this.labelAddWhere.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelAddWhere.Size = new System.Drawing.Size(72, 17);
            this.labelAddWhere.TabIndex = 7;
            this.labelAddWhere.Text = "Where to add";
            this.labelAddWhere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxAddType
            // 
            this.listBoxAddType.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxAddType.FormattingEnabled = true;
            this.listBoxAddType.Items.AddRange(new object[] {
            "Set Pin",
            "Pause"});
            this.listBoxAddType.Location = new System.Drawing.Point(0, 33);
            this.listBoxAddType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAddType.Name = "listBoxAddType";
            this.listBoxAddType.Size = new System.Drawing.Size(104, 43);
            this.listBoxAddType.TabIndex = 6;
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddType.Location = new System.Drawing.Point(0, 20);
            this.labelAddType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(64, 13);
            this.labelAddType.TabIndex = 5;
            this.labelAddType.Text = "Type to add";
            this.labelAddType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAdd
            // 
            this.labelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(0, 0);
            this.labelAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelAdd.Size = new System.Drawing.Size(104, 20);
            this.labelAdd.TabIndex = 10;
            this.labelAdd.Text = "Add CMD";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEdit
            // 
            this.panelEdit.AutoScroll = true;
            this.panelEdit.Controls.Add(this.buttonEditDelete);
            this.panelEdit.Controls.Add(this.buttonEditMoveDown);
            this.panelEdit.Controls.Add(this.buttonEditMoveUp);
            this.panelEdit.Controls.Add(this.textBoxEditDelayValue);
            this.panelEdit.Controls.Add(this.labelEditDelay);
            this.panelEdit.Controls.Add(this.listBoxEditPinMode);
            this.panelEdit.Controls.Add(this.labelEditPinMode);
            this.panelEdit.Controls.Add(this.textBoxEditPinId);
            this.panelEdit.Controls.Add(this.labelEditPinId);
            this.panelEdit.Controls.Add(this.labelEditEmpty);
            this.panelEdit.Controls.Add(this.labelEdit);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEdit.Location = new System.Drawing.Point(2, 164);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(104, 125);
            this.panelEdit.TabIndex = 1;
            // 
            // buttonEditDelete
            // 
            this.buttonEditDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEditDelete.Location = new System.Drawing.Point(0, 212);
            this.buttonEditDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditDelete.Name = "buttonEditDelete";
            this.buttonEditDelete.Size = new System.Drawing.Size(87, 20);
            this.buttonEditDelete.TabIndex = 15;
            this.buttonEditDelete.Text = "Delete";
            this.buttonEditDelete.UseVisualStyleBackColor = true;
            this.buttonEditDelete.Visible = false;
            this.buttonEditDelete.Click += new System.EventHandler(this.EditDelete);
            // 
            // buttonEditMoveDown
            // 
            this.buttonEditMoveDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditMoveDown.Location = new System.Drawing.Point(0, 192);
            this.buttonEditMoveDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditMoveDown.Name = "buttonEditMoveDown";
            this.buttonEditMoveDown.Size = new System.Drawing.Size(87, 20);
            this.buttonEditMoveDown.TabIndex = 14;
            this.buttonEditMoveDown.Text = "Move down";
            this.buttonEditMoveDown.UseVisualStyleBackColor = true;
            this.buttonEditMoveDown.Visible = false;
            this.buttonEditMoveDown.Click += new System.EventHandler(this.EditMoveDown);
            // 
            // buttonEditMoveUp
            // 
            this.buttonEditMoveUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditMoveUp.Location = new System.Drawing.Point(0, 172);
            this.buttonEditMoveUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditMoveUp.Name = "buttonEditMoveUp";
            this.buttonEditMoveUp.Size = new System.Drawing.Size(87, 20);
            this.buttonEditMoveUp.TabIndex = 13;
            this.buttonEditMoveUp.Text = "Move up";
            this.buttonEditMoveUp.UseVisualStyleBackColor = true;
            this.buttonEditMoveUp.Visible = false;
            this.buttonEditMoveUp.Click += new System.EventHandler(this.EditMoveUp);
            // 
            // textBoxEditDelayValue
            // 
            this.textBoxEditDelayValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEditDelayValue.Location = new System.Drawing.Point(0, 152);
            this.textBoxEditDelayValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditDelayValue.Name = "textBoxEditDelayValue";
            this.textBoxEditDelayValue.Size = new System.Drawing.Size(87, 20);
            this.textBoxEditDelayValue.TabIndex = 12;
            this.textBoxEditDelayValue.Visible = false;
            this.textBoxEditDelayValue.WordWrap = false;
            this.textBoxEditDelayValue.TextChanged += new System.EventHandler(this.EditDelayValue_TextChanged);
            // 
            // labelEditDelay
            // 
            this.labelEditDelay.AutoSize = true;
            this.labelEditDelay.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEditDelay.Location = new System.Drawing.Point(0, 139);
            this.labelEditDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditDelay.Name = "labelEditDelay";
            this.labelEditDelay.Size = new System.Drawing.Size(64, 13);
            this.labelEditDelay.TabIndex = 11;
            this.labelEditDelay.Text = "Delay Value";
            this.labelEditDelay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEditDelay.Visible = false;
            // 
            // listBoxEditPinMode
            // 
            this.listBoxEditPinMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxEditPinMode.FormattingEnabled = true;
            this.listBoxEditPinMode.Items.AddRange(new object[] {
            "Lock",
            "Ground",
            "Power"});
            this.listBoxEditPinMode.Location = new System.Drawing.Point(0, 96);
            this.listBoxEditPinMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxEditPinMode.Name = "listBoxEditPinMode";
            this.listBoxEditPinMode.Size = new System.Drawing.Size(87, 43);
            this.listBoxEditPinMode.TabIndex = 10;
            this.listBoxEditPinMode.Visible = false;
            this.listBoxEditPinMode.SelectedIndexChanged += new System.EventHandler(this.EditPinMode_SelectedIndexChanged);
            // 
            // labelEditPinMode
            // 
            this.labelEditPinMode.AutoSize = true;
            this.labelEditPinMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEditPinMode.Location = new System.Drawing.Point(0, 79);
            this.labelEditPinMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditPinMode.Name = "labelEditPinMode";
            this.labelEditPinMode.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelEditPinMode.Size = new System.Drawing.Size(52, 17);
            this.labelEditPinMode.TabIndex = 9;
            this.labelEditPinMode.Text = "Pin Mode";
            this.labelEditPinMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEditPinMode.Visible = false;
            // 
            // textBoxEditPinId
            // 
            this.textBoxEditPinId.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEditPinId.Location = new System.Drawing.Point(0, 59);
            this.textBoxEditPinId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditPinId.Name = "textBoxEditPinId";
            this.textBoxEditPinId.Size = new System.Drawing.Size(87, 20);
            this.textBoxEditPinId.TabIndex = 8;
            this.textBoxEditPinId.Visible = false;
            this.textBoxEditPinId.WordWrap = false;
            this.textBoxEditPinId.TextChanged += new System.EventHandler(this.EditPinId_TextChanged);
            // 
            // labelEditPinId
            // 
            this.labelEditPinId.AutoSize = true;
            this.labelEditPinId.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEditPinId.Location = new System.Drawing.Point(0, 46);
            this.labelEditPinId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditPinId.Name = "labelEditPinId";
            this.labelEditPinId.Size = new System.Drawing.Size(34, 13);
            this.labelEditPinId.TabIndex = 7;
            this.labelEditPinId.Text = "Pin Id";
            this.labelEditPinId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEditPinId.Visible = false;
            // 
            // labelEditEmpty
            // 
            this.labelEditEmpty.AutoSize = true;
            this.labelEditEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEditEmpty.Location = new System.Drawing.Point(0, 20);
            this.labelEditEmpty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEditEmpty.Name = "labelEditEmpty";
            this.labelEditEmpty.Size = new System.Drawing.Size(88, 26);
            this.labelEditEmpty.TabIndex = 3;
            this.labelEditEmpty.Text = "Select a cmd to \r\nedit it\'s properties";
            // 
            // labelEdit
            // 
            this.labelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(0, 0);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelEdit.Size = new System.Drawing.Size(87, 20);
            this.labelEdit.TabIndex = 2;
            this.labelEdit.Text = "Edit CMD";
            this.labelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageDirect
            // 
            this.tabPageDirect.Controls.Add(this.tableLayoutPanel4);
            this.tabPageDirect.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDirect.Name = "tabPageDirect";
            this.tabPageDirect.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageDirect.Size = new System.Drawing.Size(445, 299);
            this.tabPageDirect.TabIndex = 1;
            this.tabPageDirect.Text = "Direct";
            this.tabPageDirect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.listBoxOverride, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.richTextBoxOverrideInput, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(441, 295);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // listBoxOverride
            // 
            this.listBoxOverride.BackColor = System.Drawing.Color.White;
            this.listBoxOverride.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOverride.ForeColor = System.Drawing.Color.Black;
            this.listBoxOverride.FormattingEnabled = true;
            this.listBoxOverride.Location = new System.Drawing.Point(2, 2);
            this.listBoxOverride.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOverride.Name = "listBoxOverride";
            this.listBoxOverride.Size = new System.Drawing.Size(260, 250);
            this.listBoxOverride.TabIndex = 1;
            this.listBoxOverride.SelectedIndexChanged += new System.EventHandler(this.Override_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.listBoxOverridePModeUp);
            this.panel1.Controls.Add(this.labelOverridePModeUp);
            this.panel1.Controls.Add(this.listBoxOverridePModeDown);
            this.panel1.Controls.Add(this.labelOverridePModeDown);
            this.panel1.Controls.Add(this.textBoxOverrideId);
            this.panel1.Controls.Add(this.labelOverrideId);
            this.panel1.Controls.Add(this.textBoxOverrideKey);
            this.panel1.Controls.Add(this.labelOverrideKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(266, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 250);
            this.panel1.TabIndex = 2;
            // 
            // listBoxOverridePModeUp
            // 
            this.listBoxOverridePModeUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxOverridePModeUp.FormattingEnabled = true;
            this.listBoxOverridePModeUp.Items.AddRange(new object[] {
            "Lock",
            "Ground",
            "Power"});
            this.listBoxOverridePModeUp.Location = new System.Drawing.Point(0, 183);
            this.listBoxOverridePModeUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOverridePModeUp.Name = "listBoxOverridePModeUp";
            this.listBoxOverridePModeUp.Size = new System.Drawing.Size(173, 43);
            this.listBoxOverridePModeUp.TabIndex = 17;
            this.listBoxOverridePModeUp.Visible = false;
            this.listBoxOverridePModeUp.SelectedIndexChanged += new System.EventHandler(this.OverridePModeUp_SelectedIndexChanged);
            // 
            // labelOverridePModeUp
            // 
            this.labelOverridePModeUp.AutoSize = true;
            this.labelOverridePModeUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverridePModeUp.Location = new System.Drawing.Point(0, 166);
            this.labelOverridePModeUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverridePModeUp.Name = "labelOverridePModeUp";
            this.labelOverridePModeUp.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelOverridePModeUp.Size = new System.Drawing.Size(69, 17);
            this.labelOverridePModeUp.TabIndex = 16;
            this.labelOverridePModeUp.Text = "Pin Mode Up";
            this.labelOverridePModeUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOverridePModeUp.Visible = false;
            // 
            // listBoxOverridePModeDown
            // 
            this.listBoxOverridePModeDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxOverridePModeDown.FormattingEnabled = true;
            this.listBoxOverridePModeDown.Items.AddRange(new object[] {
            "Lock",
            "Ground",
            "Power"});
            this.listBoxOverridePModeDown.Location = new System.Drawing.Point(0, 123);
            this.listBoxOverridePModeDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOverridePModeDown.Name = "listBoxOverridePModeDown";
            this.listBoxOverridePModeDown.Size = new System.Drawing.Size(173, 43);
            this.listBoxOverridePModeDown.TabIndex = 14;
            this.listBoxOverridePModeDown.Visible = false;
            this.listBoxOverridePModeDown.SelectedIndexChanged += new System.EventHandler(this.OverridePModeDown_SelectedIndexChanged);
            // 
            // labelOverridePModeDown
            // 
            this.labelOverridePModeDown.AutoSize = true;
            this.labelOverridePModeDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverridePModeDown.Location = new System.Drawing.Point(0, 106);
            this.labelOverridePModeDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverridePModeDown.Name = "labelOverridePModeDown";
            this.labelOverridePModeDown.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelOverridePModeDown.Size = new System.Drawing.Size(83, 17);
            this.labelOverridePModeDown.TabIndex = 13;
            this.labelOverridePModeDown.Text = "Pin Mode Down";
            this.labelOverridePModeDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOverridePModeDown.Visible = false;
            // 
            // textBoxOverrideId
            // 
            this.textBoxOverrideId.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxOverrideId.Location = new System.Drawing.Point(0, 86);
            this.textBoxOverrideId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOverrideId.Name = "textBoxOverrideId";
            this.textBoxOverrideId.Size = new System.Drawing.Size(173, 20);
            this.textBoxOverrideId.TabIndex = 12;
            this.textBoxOverrideId.Visible = false;
            this.textBoxOverrideId.WordWrap = false;
            this.textBoxOverrideId.TextChanged += new System.EventHandler(this.OverrideId_TextChanged);
            // 
            // labelOverrideId
            // 
            this.labelOverrideId.AutoSize = true;
            this.labelOverrideId.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverrideId.Location = new System.Drawing.Point(0, 73);
            this.labelOverrideId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverrideId.Name = "labelOverrideId";
            this.labelOverrideId.Size = new System.Drawing.Size(34, 13);
            this.labelOverrideId.TabIndex = 11;
            this.labelOverrideId.Text = "Pin Id";
            this.labelOverrideId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOverrideId.Visible = false;
            // 
            // textBoxOverrideKey
            // 
            this.textBoxOverrideKey.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOverrideKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxOverrideKey.ForeColor = System.Drawing.Color.Gray;
            this.textBoxOverrideKey.Location = new System.Drawing.Point(0, 53);
            this.textBoxOverrideKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOverrideKey.Name = "textBoxOverrideKey";
            this.textBoxOverrideKey.ReadOnly = true;
            this.textBoxOverrideKey.Size = new System.Drawing.Size(173, 20);
            this.textBoxOverrideKey.TabIndex = 1;
            this.textBoxOverrideKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOverrideKey.Visible = false;
            this.textBoxOverrideKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OverrideAssignKey);
            // 
            // labelOverrideKey
            // 
            this.labelOverrideKey.AutoSize = true;
            this.labelOverrideKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverrideKey.Location = new System.Drawing.Point(0, 40);
            this.labelOverrideKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverrideKey.Name = "labelOverrideKey";
            this.labelOverrideKey.Size = new System.Drawing.Size(61, 13);
            this.labelOverrideKey.TabIndex = 15;
            this.labelOverrideKey.Text = "Control Key";
            this.labelOverrideKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelOverrideKey.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Edit Override";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonOverrideAdd);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonOverrideDelete);
            this.splitContainer2.Size = new System.Drawing.Size(173, 20);
            this.splitContainer2.SplitterDistance = 89;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonOverrideAdd
            // 
            this.buttonOverrideAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOverrideAdd.Location = new System.Drawing.Point(0, 0);
            this.buttonOverrideAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOverrideAdd.Name = "buttonOverrideAdd";
            this.buttonOverrideAdd.Size = new System.Drawing.Size(89, 20);
            this.buttonOverrideAdd.TabIndex = 0;
            this.buttonOverrideAdd.Text = "Add";
            this.buttonOverrideAdd.UseVisualStyleBackColor = true;
            this.buttonOverrideAdd.Click += new System.EventHandler(this.OverrideAdd_Click);
            // 
            // buttonOverrideDelete
            // 
            this.buttonOverrideDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOverrideDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonOverrideDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOverrideDelete.Name = "buttonOverrideDelete";
            this.buttonOverrideDelete.Size = new System.Drawing.Size(81, 20);
            this.buttonOverrideDelete.TabIndex = 1;
            this.buttonOverrideDelete.Text = "Remove";
            this.buttonOverrideDelete.UseVisualStyleBackColor = true;
            this.buttonOverrideDelete.Click += new System.EventHandler(this.OverrideDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxOverrideRecord);
            this.panel2.Controls.Add(this.checkBoxOverride);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(266, 256);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 37);
            this.panel2.TabIndex = 3;
            // 
            // checkBoxOverrideRecord
            // 
            this.checkBoxOverrideRecord.AutoSize = true;
            this.checkBoxOverrideRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxOverrideRecord.Location = new System.Drawing.Point(0, 17);
            this.checkBoxOverrideRecord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxOverrideRecord.Name = "checkBoxOverrideRecord";
            this.checkBoxOverrideRecord.Size = new System.Drawing.Size(173, 17);
            this.checkBoxOverrideRecord.TabIndex = 5;
            this.checkBoxOverrideRecord.Text = "Record input to Script";
            this.checkBoxOverrideRecord.UseVisualStyleBackColor = true;
            this.checkBoxOverrideRecord.CheckedChanged += new System.EventHandler(this.checkBoxOverrideRecord_CheckedChanged);
            // 
            // checkBoxOverride
            // 
            this.checkBoxOverride.AutoSize = true;
            this.checkBoxOverride.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxOverride.Location = new System.Drawing.Point(0, 0);
            this.checkBoxOverride.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxOverride.Name = "checkBoxOverride";
            this.checkBoxOverride.Size = new System.Drawing.Size(173, 17);
            this.checkBoxOverride.TabIndex = 4;
            this.checkBoxOverride.Text = "Send input to Serial";
            this.checkBoxOverride.UseVisualStyleBackColor = true;
            this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.CheckBoxOverride_CheckedChanged);
            // 
            // richTextBoxOverrideInput
            // 
            this.richTextBoxOverrideInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxOverrideInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxOverrideInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxOverrideInput.FormattingEnabled = true;
            this.richTextBoxOverrideInput.Location = new System.Drawing.Point(2, 256);
            this.richTextBoxOverrideInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxOverrideInput.Name = "richTextBoxOverrideInput";
            this.richTextBoxOverrideInput.Size = new System.Drawing.Size(260, 37);
            this.richTextBoxOverrideInput.TabIndex = 4;
            this.richTextBoxOverrideInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OverrideKeyDown);
            this.richTextBoxOverrideInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OverrideKeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem,
            this.directToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.scriptToolStripMenuItem.Text = "Script";
            this.scriptToolStripMenuItem.Click += new System.EventHandler(this.ScriptToolStripMenuItem_Click);
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.directToolStripMenuItem.Text = "Direct";
            this.directToolStripMenuItem.Click += new System.EventHandler(this.DirectToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem1,
            this.directToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // scriptToolStripMenuItem1
            // 
            this.scriptToolStripMenuItem1.Name = "scriptToolStripMenuItem1";
            this.scriptToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.scriptToolStripMenuItem1.Text = "Script";
            this.scriptToolStripMenuItem1.Click += new System.EventHandler(this.ScriptToolStripMenuItem1_Click);
            // 
            // directToolStripMenuItem1
            // 
            this.directToolStripMenuItem1.Name = "directToolStripMenuItem1";
            this.directToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.directToolStripMenuItem1.Text = "Direct";
            this.directToolStripMenuItem1.Click += new System.EventHandler(this.DirectToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 377);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MacroPad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OverrideKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OverrideKeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageScript.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.tabPageDirect.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelSerialStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageScript;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxScript;
        private System.Windows.Forms.TabPage tabPageDirect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxAddWhere;
        private System.Windows.Forms.Label labelAddWhere;
        private System.Windows.Forms.ListBox listBoxAddType;
        private System.Windows.Forms.Label labelAddType;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label labelEditEmpty;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelEditPinId;
        private System.Windows.Forms.TextBox textBoxEditDelayValue;
        private System.Windows.Forms.Label labelEditDelay;
        private System.Windows.Forms.ListBox listBoxEditPinMode;
        private System.Windows.Forms.Label labelEditPinMode;
        private System.Windows.Forms.TextBox textBoxEditPinId;
        private System.Windows.Forms.Button buttonEditDelete;
        private System.Windows.Forms.Button buttonEditMoveDown;
        private System.Windows.Forms.Button buttonEditMoveUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListBox listBoxOverride;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonOverrideAdd;
        private System.Windows.Forms.Button buttonOverrideDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxOverrideRecord;
        private System.Windows.Forms.CheckBox checkBoxOverride;
        private System.Windows.Forms.TextBox textBoxOverrideKey;
        private System.Windows.Forms.ListBox listBoxOverridePModeUp;
        private System.Windows.Forms.Label labelOverridePModeUp;
        private System.Windows.Forms.ListBox listBoxOverridePModeDown;
        private System.Windows.Forms.Label labelOverridePModeDown;
        private System.Windows.Forms.TextBox textBoxOverrideId;
        private System.Windows.Forms.Label labelOverrideId;
        private System.Windows.Forms.Label labelOverrideKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.ListBox richTextBoxOverrideInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem1;
    }
}

