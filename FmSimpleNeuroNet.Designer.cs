namespace wf_AI_lab1
{
    partial class FmSimpleNeuroNet
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GbxDraw = new System.Windows.Forms.GroupBox();
            this.BtnAnalyse = new System.Windows.Forms.Button();
            this.BtnSymEq = new System.Windows.Forms.Button();
            this.BtnClearDraw = new System.Windows.Forms.Button();
            this.BtnSymProp = new System.Windows.Forms.Button();
            this.DgvDraw = new System.Windows.Forms.DataGridView();
            this.BtnSymXor = new System.Windows.Forms.Button();
            this.BtnSymAnd = new System.Windows.Forms.Button();
            this.BtnSymNot = new System.Windows.Forms.Button();
            this.BtnSymOr = new System.Windows.Forms.Button();
            this.BtnLearnNet = new System.Windows.Forms.Button();
            this.BtnStartNet = new System.Windows.Forms.Button();
            this.TbxInputVector = new System.Windows.Forms.TextBox();
            this.GbxTest = new System.Windows.Forms.GroupBox();
            this.NudEq = new System.Windows.Forms.NumericUpDown();
            this.NudProp = new System.Windows.Forms.NumericUpDown();
            this.NudNot = new System.Windows.Forms.NumericUpDown();
            this.NudXor = new System.Windows.Forms.NumericUpDown();
            this.NudOr = new System.Windows.Forms.NumericUpDown();
            this.NudAnd = new System.Windows.Forms.NumericUpDown();
            this.RbtNot = new System.Windows.Forms.RadioButton();
            this.NudAges = new System.Windows.Forms.NumericUpDown();
            this.LblAges = new System.Windows.Forms.Label();
            this.PrbLearning = new System.Windows.Forms.ProgressBar();
            this.BtnAddTest = new System.Windows.Forms.Button();
            this.RbtEq = new System.Windows.Forms.RadioButton();
            this.RbtProp = new System.Windows.Forms.RadioButton();
            this.RbtXor = new System.Windows.Forms.RadioButton();
            this.RbtOr = new System.Windows.Forms.RadioButton();
            this.RbtnAnd = new System.Windows.Forms.RadioButton();
            this.GbxSetting = new System.Windows.Forms.GroupBox();
            this.LblLevelNeuronCounts = new System.Windows.Forms.Label();
            this.TbxLevelNeuronCounts = new System.Windows.Forms.TextBox();
            this.TmrLearning = new System.Windows.Forms.Timer(this.components);
            this.GbxLearning = new System.Windows.Forms.GroupBox();
            this.GbxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).BeginInit();
            this.GbxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudXor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAges)).BeginInit();
            this.GbxSetting.SuspendLayout();
            this.GbxLearning.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDraw
            // 
            this.GbxDraw.Controls.Add(this.BtnAnalyse);
            this.GbxDraw.Controls.Add(this.BtnSymEq);
            this.GbxDraw.Controls.Add(this.BtnClearDraw);
            this.GbxDraw.Controls.Add(this.BtnSymProp);
            this.GbxDraw.Controls.Add(this.DgvDraw);
            this.GbxDraw.Controls.Add(this.BtnSymXor);
            this.GbxDraw.Controls.Add(this.BtnSymAnd);
            this.GbxDraw.Controls.Add(this.BtnSymNot);
            this.GbxDraw.Controls.Add(this.BtnSymOr);
            this.GbxDraw.Location = new System.Drawing.Point(12, 12);
            this.GbxDraw.Name = "GbxDraw";
            this.GbxDraw.Size = new System.Drawing.Size(369, 478);
            this.GbxDraw.TabIndex = 0;
            this.GbxDraw.TabStop = false;
            this.GbxDraw.Text = "Панель рисования";
            // 
            // BtnAnalyse
            // 
            this.BtnAnalyse.Enabled = false;
            this.BtnAnalyse.Location = new System.Drawing.Point(207, 420);
            this.BtnAnalyse.Name = "BtnAnalyse";
            this.BtnAnalyse.Size = new System.Drawing.Size(156, 46);
            this.BtnAnalyse.TabIndex = 5;
            this.BtnAnalyse.Text = "Распознать";
            this.BtnAnalyse.UseVisualStyleBackColor = true;
            this.BtnAnalyse.Click += new System.EventHandler(this.BtnToVector_Click);
            // 
            // BtnSymEq
            // 
            this.BtnSymEq.Location = new System.Drawing.Point(114, 420);
            this.BtnSymEq.Name = "BtnSymEq";
            this.BtnSymEq.Size = new System.Drawing.Size(48, 46);
            this.BtnSymEq.TabIndex = 12;
            this.BtnSymEq.Text = "=";
            this.BtnSymEq.UseVisualStyleBackColor = true;
            this.BtnSymEq.Click += new System.EventHandler(this.BtnSymEq_Click);
            // 
            // BtnClearDraw
            // 
            this.BtnClearDraw.Location = new System.Drawing.Point(207, 364);
            this.BtnClearDraw.Name = "BtnClearDraw";
            this.BtnClearDraw.Size = new System.Drawing.Size(156, 46);
            this.BtnClearDraw.TabIndex = 4;
            this.BtnClearDraw.Text = "Очистить все";
            this.BtnClearDraw.UseVisualStyleBackColor = true;
            this.BtnClearDraw.Click += new System.EventHandler(this.BtnClearDraw_Click);
            // 
            // BtnSymProp
            // 
            this.BtnSymProp.Location = new System.Drawing.Point(60, 420);
            this.BtnSymProp.Name = "BtnSymProp";
            this.BtnSymProp.Size = new System.Drawing.Size(48, 46);
            this.BtnSymProp.TabIndex = 11;
            this.BtnSymProp.Text = "->";
            this.BtnSymProp.UseVisualStyleBackColor = true;
            this.BtnSymProp.Click += new System.EventHandler(this.BtnSymProp_Click);
            // 
            // DgvDraw
            // 
            this.DgvDraw.AllowUserToAddRows = false;
            this.DgvDraw.AllowUserToDeleteRows = false;
            this.DgvDraw.AllowUserToResizeColumns = false;
            this.DgvDraw.AllowUserToResizeRows = false;
            this.DgvDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDraw.ColumnHeadersVisible = false;
            this.DgvDraw.Location = new System.Drawing.Point(6, 19);
            this.DgvDraw.MultiSelect = false;
            this.DgvDraw.Name = "DgvDraw";
            this.DgvDraw.ReadOnly = true;
            this.DgvDraw.RowHeadersVisible = false;
            this.DgvDraw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvDraw.Size = new System.Drawing.Size(357, 339);
            this.DgvDraw.TabIndex = 0;
            this.DgvDraw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDraw_CellMouseDown);
            this.DgvDraw.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDraw_CellMouseMove);
            // 
            // BtnSymXor
            // 
            this.BtnSymXor.Location = new System.Drawing.Point(114, 364);
            this.BtnSymXor.Name = "BtnSymXor";
            this.BtnSymXor.Size = new System.Drawing.Size(48, 46);
            this.BtnSymXor.TabIndex = 10;
            this.BtnSymXor.Text = "XOR";
            this.BtnSymXor.UseVisualStyleBackColor = true;
            this.BtnSymXor.Click += new System.EventHandler(this.BtnSymXor_Click);
            // 
            // BtnSymAnd
            // 
            this.BtnSymAnd.Location = new System.Drawing.Point(6, 365);
            this.BtnSymAnd.Name = "BtnSymAnd";
            this.BtnSymAnd.Size = new System.Drawing.Size(48, 46);
            this.BtnSymAnd.TabIndex = 5;
            this.BtnSymAnd.Text = "AND";
            this.BtnSymAnd.UseVisualStyleBackColor = true;
            this.BtnSymAnd.Click += new System.EventHandler(this.BtnSymAnd_Click);
            // 
            // BtnSymNot
            // 
            this.BtnSymNot.Location = new System.Drawing.Point(6, 420);
            this.BtnSymNot.Name = "BtnSymNot";
            this.BtnSymNot.Size = new System.Drawing.Size(48, 46);
            this.BtnSymNot.TabIndex = 9;
            this.BtnSymNot.Text = "NOT";
            this.BtnSymNot.UseVisualStyleBackColor = true;
            this.BtnSymNot.Click += new System.EventHandler(this.BtnSymNot_Click);
            // 
            // BtnSymOr
            // 
            this.BtnSymOr.Location = new System.Drawing.Point(60, 365);
            this.BtnSymOr.Name = "BtnSymOr";
            this.BtnSymOr.Size = new System.Drawing.Size(48, 46);
            this.BtnSymOr.TabIndex = 8;
            this.BtnSymOr.Text = "OR";
            this.BtnSymOr.UseVisualStyleBackColor = true;
            this.BtnSymOr.Click += new System.EventHandler(this.BtnSymOr_Click);
            // 
            // BtnLearnNet
            // 
            this.BtnLearnNet.Location = new System.Drawing.Point(188, 56);
            this.BtnLearnNet.Name = "BtnLearnNet";
            this.BtnLearnNet.Size = new System.Drawing.Size(119, 46);
            this.BtnLearnNet.TabIndex = 7;
            this.BtnLearnNet.Text = "Обучить сеть";
            this.BtnLearnNet.UseVisualStyleBackColor = true;
            this.BtnLearnNet.Click += new System.EventHandler(this.BtnLearnNet_Click);
            // 
            // BtnStartNet
            // 
            this.BtnStartNet.Location = new System.Drawing.Point(6, 59);
            this.BtnStartNet.Name = "BtnStartNet";
            this.BtnStartNet.Size = new System.Drawing.Size(122, 40);
            this.BtnStartNet.TabIndex = 6;
            this.BtnStartNet.Text = "Создать сеть";
            this.BtnStartNet.UseVisualStyleBackColor = true;
            this.BtnStartNet.Click += new System.EventHandler(this.BtnStartNet_Click);
            // 
            // TbxInputVector
            // 
            this.TbxInputVector.Location = new System.Drawing.Point(706, 12);
            this.TbxInputVector.Multiline = true;
            this.TbxInputVector.Name = "TbxInputVector";
            this.TbxInputVector.ReadOnly = true;
            this.TbxInputVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxInputVector.Size = new System.Drawing.Size(337, 478);
            this.TbxInputVector.TabIndex = 1;
            // 
            // GbxTest
            // 
            this.GbxTest.Controls.Add(this.NudEq);
            this.GbxTest.Controls.Add(this.NudProp);
            this.GbxTest.Controls.Add(this.NudNot);
            this.GbxTest.Controls.Add(this.NudXor);
            this.GbxTest.Controls.Add(this.NudOr);
            this.GbxTest.Controls.Add(this.NudAnd);
            this.GbxTest.Controls.Add(this.RbtNot);
            this.GbxTest.Controls.Add(this.BtnAddTest);
            this.GbxTest.Controls.Add(this.RbtEq);
            this.GbxTest.Controls.Add(this.RbtProp);
            this.GbxTest.Controls.Add(this.RbtXor);
            this.GbxTest.Controls.Add(this.RbtOr);
            this.GbxTest.Controls.Add(this.RbtnAnd);
            this.GbxTest.Enabled = false;
            this.GbxTest.Location = new System.Drawing.Point(387, 123);
            this.GbxTest.Name = "GbxTest";
            this.GbxTest.Size = new System.Drawing.Size(313, 178);
            this.GbxTest.TabIndex = 2;
            this.GbxTest.TabStop = false;
            this.GbxTest.Text = "Тестовые случаи";
            // 
            // NudEq
            // 
            this.NudEq.Location = new System.Drawing.Point(238, 71);
            this.NudEq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudEq.Name = "NudEq";
            this.NudEq.ReadOnly = true;
            this.NudEq.Size = new System.Drawing.Size(69, 20);
            this.NudEq.TabIndex = 24;
            // 
            // NudProp
            // 
            this.NudProp.Location = new System.Drawing.Point(238, 45);
            this.NudProp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudProp.Name = "NudProp";
            this.NudProp.ReadOnly = true;
            this.NudProp.Size = new System.Drawing.Size(69, 20);
            this.NudProp.TabIndex = 23;
            // 
            // NudNot
            // 
            this.NudNot.Location = new System.Drawing.Point(238, 19);
            this.NudNot.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudNot.Name = "NudNot";
            this.NudNot.ReadOnly = true;
            this.NudNot.Size = new System.Drawing.Size(69, 20);
            this.NudNot.TabIndex = 22;
            // 
            // NudXor
            // 
            this.NudXor.Location = new System.Drawing.Point(59, 71);
            this.NudXor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudXor.Name = "NudXor";
            this.NudXor.ReadOnly = true;
            this.NudXor.Size = new System.Drawing.Size(69, 20);
            this.NudXor.TabIndex = 21;
            // 
            // NudOr
            // 
            this.NudOr.Location = new System.Drawing.Point(59, 45);
            this.NudOr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudOr.Name = "NudOr";
            this.NudOr.ReadOnly = true;
            this.NudOr.Size = new System.Drawing.Size(69, 20);
            this.NudOr.TabIndex = 20;
            // 
            // NudAnd
            // 
            this.NudAnd.Location = new System.Drawing.Point(59, 19);
            this.NudAnd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAnd.Name = "NudAnd";
            this.NudAnd.ReadOnly = true;
            this.NudAnd.Size = new System.Drawing.Size(69, 20);
            this.NudAnd.TabIndex = 19;
            // 
            // RbtNot
            // 
            this.RbtNot.AutoSize = true;
            this.RbtNot.Location = new System.Drawing.Point(166, 19);
            this.RbtNot.Name = "RbtNot";
            this.RbtNot.Size = new System.Drawing.Size(42, 17);
            this.RbtNot.TabIndex = 18;
            this.RbtNot.TabStop = true;
            this.RbtNot.Text = "Not";
            this.RbtNot.UseVisualStyleBackColor = true;
            this.RbtNot.CheckedChanged += new System.EventHandler(this.RbtNot_CheckedChanged);
            // 
            // NudAges
            // 
            this.NudAges.Location = new System.Drawing.Point(166, 30);
            this.NudAges.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAges.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAges.Name = "NudAges";
            this.NudAges.Size = new System.Drawing.Size(141, 20);
            this.NudAges.TabIndex = 17;
            this.NudAges.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblAges
            // 
            this.LblAges.Location = new System.Drawing.Point(6, 30);
            this.LblAges.Name = "LblAges";
            this.LblAges.Size = new System.Drawing.Size(94, 19);
            this.LblAges.TabIndex = 8;
            this.LblAges.Text = "Количество эпох";
            // 
            // PrbLearning
            // 
            this.PrbLearning.Location = new System.Drawing.Point(6, 108);
            this.PrbLearning.Name = "PrbLearning";
            this.PrbLearning.Size = new System.Drawing.Size(301, 23);
            this.PrbLearning.TabIndex = 16;
            // 
            // BtnAddTest
            // 
            this.BtnAddTest.Location = new System.Drawing.Point(6, 120);
            this.BtnAddTest.Name = "BtnAddTest";
            this.BtnAddTest.Size = new System.Drawing.Size(119, 50);
            this.BtnAddTest.TabIndex = 14;
            this.BtnAddTest.Text = "Добавить случай";
            this.BtnAddTest.UseVisualStyleBackColor = true;
            this.BtnAddTest.Click += new System.EventHandler(this.BtnAddTest_Click);
            // 
            // RbtEq
            // 
            this.RbtEq.AutoSize = true;
            this.RbtEq.Location = new System.Drawing.Point(166, 71);
            this.RbtEq.Name = "RbtEq";
            this.RbtEq.Size = new System.Drawing.Size(31, 17);
            this.RbtEq.TabIndex = 13;
            this.RbtEq.TabStop = true;
            this.RbtEq.Text = "=";
            this.RbtEq.UseVisualStyleBackColor = true;
            this.RbtEq.CheckedChanged += new System.EventHandler(this.RbtEq_CheckedChanged);
            // 
            // RbtProp
            // 
            this.RbtProp.AutoSize = true;
            this.RbtProp.Location = new System.Drawing.Point(166, 45);
            this.RbtProp.Name = "RbtProp";
            this.RbtProp.Size = new System.Drawing.Size(34, 17);
            this.RbtProp.TabIndex = 12;
            this.RbtProp.TabStop = true;
            this.RbtProp.Text = "->";
            this.RbtProp.UseVisualStyleBackColor = true;
            this.RbtProp.CheckedChanged += new System.EventHandler(this.RbtProp_CheckedChanged);
            // 
            // RbtXor
            // 
            this.RbtXor.AutoSize = true;
            this.RbtXor.Location = new System.Drawing.Point(6, 71);
            this.RbtXor.Name = "RbtXor";
            this.RbtXor.Size = new System.Drawing.Size(41, 17);
            this.RbtXor.TabIndex = 11;
            this.RbtXor.TabStop = true;
            this.RbtXor.Text = "Xor";
            this.RbtXor.UseVisualStyleBackColor = true;
            this.RbtXor.CheckedChanged += new System.EventHandler(this.RbtXor_CheckedChanged);
            // 
            // RbtOr
            // 
            this.RbtOr.AutoSize = true;
            this.RbtOr.Location = new System.Drawing.Point(6, 45);
            this.RbtOr.Name = "RbtOr";
            this.RbtOr.Size = new System.Drawing.Size(36, 17);
            this.RbtOr.TabIndex = 10;
            this.RbtOr.TabStop = true;
            this.RbtOr.Text = "Or";
            this.RbtOr.UseVisualStyleBackColor = true;
            this.RbtOr.CheckedChanged += new System.EventHandler(this.RbtOr_CheckedChanged);
            // 
            // RbtnAnd
            // 
            this.RbtnAnd.AutoSize = true;
            this.RbtnAnd.Checked = true;
            this.RbtnAnd.Location = new System.Drawing.Point(6, 19);
            this.RbtnAnd.Name = "RbtnAnd";
            this.RbtnAnd.Size = new System.Drawing.Size(44, 17);
            this.RbtnAnd.TabIndex = 9;
            this.RbtnAnd.TabStop = true;
            this.RbtnAnd.Text = "And";
            this.RbtnAnd.UseVisualStyleBackColor = true;
            this.RbtnAnd.CheckedChanged += new System.EventHandler(this.RbtnAnd_CheckedChanged);
            // 
            // GbxSetting
            // 
            this.GbxSetting.Controls.Add(this.LblLevelNeuronCounts);
            this.GbxSetting.Controls.Add(this.TbxLevelNeuronCounts);
            this.GbxSetting.Controls.Add(this.BtnStartNet);
            this.GbxSetting.Location = new System.Drawing.Point(387, 12);
            this.GbxSetting.Name = "GbxSetting";
            this.GbxSetting.Size = new System.Drawing.Size(313, 105);
            this.GbxSetting.TabIndex = 3;
            this.GbxSetting.TabStop = false;
            this.GbxSetting.Text = "Настройка сети";
            // 
            // LblLevelNeuronCounts
            // 
            this.LblLevelNeuronCounts.Location = new System.Drawing.Point(6, 22);
            this.LblLevelNeuronCounts.Name = "LblLevelNeuronCounts";
            this.LblLevelNeuronCounts.Size = new System.Drawing.Size(156, 34);
            this.LblLevelNeuronCounts.TabIndex = 7;
            this.LblLevelNeuronCounts.Text = "Число нейронов в скрытых уровнях (через запятую)";
            // 
            // TbxLevelNeuronCounts
            // 
            this.TbxLevelNeuronCounts.Location = new System.Drawing.Point(166, 22);
            this.TbxLevelNeuronCounts.Name = "TbxLevelNeuronCounts";
            this.TbxLevelNeuronCounts.Size = new System.Drawing.Size(141, 20);
            this.TbxLevelNeuronCounts.TabIndex = 0;
            // 
            // TmrLearning
            // 
            this.TmrLearning.Interval = 10;
            this.TmrLearning.Tick += new System.EventHandler(this.TmrLearning_Tick);
            // 
            // GbxLearning
            // 
            this.GbxLearning.Controls.Add(this.LblAges);
            this.GbxLearning.Controls.Add(this.NudAges);
            this.GbxLearning.Controls.Add(this.BtnLearnNet);
            this.GbxLearning.Controls.Add(this.PrbLearning);
            this.GbxLearning.Location = new System.Drawing.Point(387, 348);
            this.GbxLearning.Name = "GbxLearning";
            this.GbxLearning.Size = new System.Drawing.Size(313, 142);
            this.GbxLearning.TabIndex = 4;
            this.GbxLearning.TabStop = false;
            this.GbxLearning.Text = "Обучение сети";
            // 
            // FmSimpleNeuroNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 509);
            this.Controls.Add(this.GbxLearning);
            this.Controls.Add(this.GbxSetting);
            this.Controls.Add(this.GbxTest);
            this.Controls.Add(this.TbxInputVector);
            this.Controls.Add(this.GbxDraw);
            this.Name = "FmSimpleNeuroNet";
            this.Text = "Простая нейро-сеть";
            this.Shown += new System.EventHandler(this.FmSimpleNeuroNet_Shown);
            this.GbxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).EndInit();
            this.GbxTest.ResumeLayout(false);
            this.GbxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudXor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAges)).EndInit();
            this.GbxSetting.ResumeLayout(false);
            this.GbxSetting.PerformLayout();
            this.GbxLearning.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDraw;
        private System.Windows.Forms.DataGridView DgvDraw;
        private System.Windows.Forms.Button BtnClearDraw;
        private System.Windows.Forms.Button BtnAnalyse;
        private System.Windows.Forms.TextBox TbxInputVector;
        private System.Windows.Forms.Button BtnStartNet;
        private System.Windows.Forms.Button BtnLearnNet;
        private System.Windows.Forms.Button BtnSymEq;
        private System.Windows.Forms.Button BtnSymProp;
        private System.Windows.Forms.Button BtnSymXor;
        private System.Windows.Forms.Button BtnSymAnd;
        private System.Windows.Forms.Button BtnSymNot;
        private System.Windows.Forms.Button BtnSymOr;
        private System.Windows.Forms.GroupBox GbxTest;
        private System.Windows.Forms.GroupBox GbxSetting;
        private System.Windows.Forms.Label LblLevelNeuronCounts;
        private System.Windows.Forms.TextBox TbxLevelNeuronCounts;
        private System.Windows.Forms.NumericUpDown NudAges;
        private System.Windows.Forms.Label LblAges;
        private System.Windows.Forms.ProgressBar PrbLearning;
        private System.Windows.Forms.Button BtnAddTest;
        private System.Windows.Forms.RadioButton RbtEq;
        private System.Windows.Forms.RadioButton RbtProp;
        private System.Windows.Forms.RadioButton RbtXor;
        private System.Windows.Forms.RadioButton RbtOr;
        private System.Windows.Forms.RadioButton RbtnAnd;
        private System.Windows.Forms.RadioButton RbtNot;
        private System.Windows.Forms.NumericUpDown NudEq;
        private System.Windows.Forms.NumericUpDown NudProp;
        private System.Windows.Forms.NumericUpDown NudNot;
        private System.Windows.Forms.NumericUpDown NudXor;
        private System.Windows.Forms.NumericUpDown NudOr;
        private System.Windows.Forms.NumericUpDown NudAnd;
        private System.Windows.Forms.Timer TmrLearning;
        private System.Windows.Forms.GroupBox GbxLearning;
    }
}

