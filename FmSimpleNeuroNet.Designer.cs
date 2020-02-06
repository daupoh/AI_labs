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
            this.GbxDraw = new System.Windows.Forms.GroupBox();
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
            this.BtnAnalyse = new System.Windows.Forms.Button();
            this.TbxInputVector = new System.Windows.Forms.TextBox();
            this.GbxLearning = new System.Windows.Forms.GroupBox();
            this.NudAges = new System.Windows.Forms.NumericUpDown();
            this.LblAges = new System.Windows.Forms.Label();
            this.PrbLearning = new System.Windows.Forms.ProgressBar();
            this.LbxTests = new System.Windows.Forms.ListBox();
            this.BtnAddTest = new System.Windows.Forms.Button();
            this.RbtEq = new System.Windows.Forms.RadioButton();
            this.RbtProp = new System.Windows.Forms.RadioButton();
            this.RbtXor = new System.Windows.Forms.RadioButton();
            this.RbtOr = new System.Windows.Forms.RadioButton();
            this.RbtnAnd = new System.Windows.Forms.RadioButton();
            this.GbxSetting = new System.Windows.Forms.GroupBox();
            this.LblLevelNeuronCounts = new System.Windows.Forms.Label();
            this.TbxLevelNeuronCounts = new System.Windows.Forms.TextBox();
            this.RbtNot = new System.Windows.Forms.RadioButton();
            this.GbxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).BeginInit();
            this.GbxLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAges)).BeginInit();
            this.GbxSetting.SuspendLayout();
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
            // BtnSymEq
            // 
            this.BtnSymEq.Location = new System.Drawing.Point(114, 364);
            this.BtnSymEq.Name = "BtnSymEq";
            this.BtnSymEq.Size = new System.Drawing.Size(48, 46);
            this.BtnSymEq.TabIndex = 12;
            this.BtnSymEq.Text = "=";
            this.BtnSymEq.UseVisualStyleBackColor = true;
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
            this.BtnSymProp.Location = new System.Drawing.Point(60, 364);
            this.BtnSymProp.Name = "BtnSymProp";
            this.BtnSymProp.Size = new System.Drawing.Size(48, 46);
            this.BtnSymProp.TabIndex = 11;
            this.BtnSymProp.Text = "->";
            this.BtnSymProp.UseVisualStyleBackColor = true;
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
            this.BtnSymXor.Location = new System.Drawing.Point(6, 364);
            this.BtnSymXor.Name = "BtnSymXor";
            this.BtnSymXor.Size = new System.Drawing.Size(48, 46);
            this.BtnSymXor.TabIndex = 10;
            this.BtnSymXor.Text = "XOR";
            this.BtnSymXor.UseVisualStyleBackColor = true;
            // 
            // BtnSymAnd
            // 
            this.BtnSymAnd.Location = new System.Drawing.Point(114, 420);
            this.BtnSymAnd.Name = "BtnSymAnd";
            this.BtnSymAnd.Size = new System.Drawing.Size(48, 46);
            this.BtnSymAnd.TabIndex = 5;
            this.BtnSymAnd.Text = "AND";
            this.BtnSymAnd.UseVisualStyleBackColor = true;
            // 
            // BtnSymNot
            // 
            this.BtnSymNot.Location = new System.Drawing.Point(6, 420);
            this.BtnSymNot.Name = "BtnSymNot";
            this.BtnSymNot.Size = new System.Drawing.Size(48, 46);
            this.BtnSymNot.TabIndex = 9;
            this.BtnSymNot.Text = "NOT";
            this.BtnSymNot.UseVisualStyleBackColor = true;
            // 
            // BtnSymOr
            // 
            this.BtnSymOr.Location = new System.Drawing.Point(60, 420);
            this.BtnSymOr.Name = "BtnSymOr";
            this.BtnSymOr.Size = new System.Drawing.Size(48, 46);
            this.BtnSymOr.TabIndex = 8;
            this.BtnSymOr.Text = "OR";
            this.BtnSymOr.UseVisualStyleBackColor = true;
            // 
            // BtnLearnNet
            // 
            this.BtnLearnNet.Location = new System.Drawing.Point(6, 286);
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
            // GbxLearning
            // 
            this.GbxLearning.Controls.Add(this.RbtNot);
            this.GbxLearning.Controls.Add(this.NudAges);
            this.GbxLearning.Controls.Add(this.LblAges);
            this.GbxLearning.Controls.Add(this.PrbLearning);
            this.GbxLearning.Controls.Add(this.LbxTests);
            this.GbxLearning.Controls.Add(this.BtnLearnNet);
            this.GbxLearning.Controls.Add(this.BtnAddTest);
            this.GbxLearning.Controls.Add(this.RbtEq);
            this.GbxLearning.Controls.Add(this.RbtProp);
            this.GbxLearning.Controls.Add(this.RbtXor);
            this.GbxLearning.Controls.Add(this.RbtOr);
            this.GbxLearning.Controls.Add(this.RbtnAnd);
            this.GbxLearning.Enabled = false;
            this.GbxLearning.Location = new System.Drawing.Point(387, 123);
            this.GbxLearning.Name = "GbxLearning";
            this.GbxLearning.Size = new System.Drawing.Size(313, 367);
            this.GbxLearning.TabIndex = 2;
            this.GbxLearning.TabStop = false;
            this.GbxLearning.Text = "Обучение сети";
            // 
            // NudAges
            // 
            this.NudAges.Location = new System.Drawing.Point(166, 253);
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
            this.LblAges.Location = new System.Drawing.Point(11, 254);
            this.LblAges.Name = "LblAges";
            this.LblAges.Size = new System.Drawing.Size(94, 19);
            this.LblAges.TabIndex = 8;
            this.LblAges.Text = "Количество эпох";
            // 
            // PrbLearning
            // 
            this.PrbLearning.Location = new System.Drawing.Point(6, 338);
            this.PrbLearning.Name = "PrbLearning";
            this.PrbLearning.Size = new System.Drawing.Size(301, 23);
            this.PrbLearning.TabIndex = 16;
            // 
            // LbxTests
            // 
            this.LbxTests.FormattingEnabled = true;
            this.LbxTests.Location = new System.Drawing.Point(131, 19);
            this.LbxTests.Name = "LbxTests";
            this.LbxTests.Size = new System.Drawing.Size(176, 186);
            this.LbxTests.TabIndex = 15;
            // 
            // BtnAddTest
            // 
            this.BtnAddTest.Location = new System.Drawing.Point(6, 155);
            this.BtnAddTest.Name = "BtnAddTest";
            this.BtnAddTest.Size = new System.Drawing.Size(119, 50);
            this.BtnAddTest.TabIndex = 14;
            this.BtnAddTest.Text = "Добавить случай";
            this.BtnAddTest.UseVisualStyleBackColor = true;
            // 
            // RbtEq
            // 
            this.RbtEq.AutoSize = true;
            this.RbtEq.Location = new System.Drawing.Point(70, 65);
            this.RbtEq.Name = "RbtEq";
            this.RbtEq.Size = new System.Drawing.Size(31, 17);
            this.RbtEq.TabIndex = 13;
            this.RbtEq.TabStop = true;
            this.RbtEq.Text = "=";
            this.RbtEq.UseVisualStyleBackColor = true;
            // 
            // RbtProp
            // 
            this.RbtProp.AutoSize = true;
            this.RbtProp.Location = new System.Drawing.Point(70, 42);
            this.RbtProp.Name = "RbtProp";
            this.RbtProp.Size = new System.Drawing.Size(34, 17);
            this.RbtProp.TabIndex = 12;
            this.RbtProp.TabStop = true;
            this.RbtProp.Text = "->";
            this.RbtProp.UseVisualStyleBackColor = true;
            // 
            // RbtXor
            // 
            this.RbtXor.AutoSize = true;
            this.RbtXor.Location = new System.Drawing.Point(6, 65);
            this.RbtXor.Name = "RbtXor";
            this.RbtXor.Size = new System.Drawing.Size(41, 17);
            this.RbtXor.TabIndex = 11;
            this.RbtXor.TabStop = true;
            this.RbtXor.Text = "Xor";
            this.RbtXor.UseVisualStyleBackColor = true;
            // 
            // RbtOr
            // 
            this.RbtOr.AutoSize = true;
            this.RbtOr.Location = new System.Drawing.Point(6, 42);
            this.RbtOr.Name = "RbtOr";
            this.RbtOr.Size = new System.Drawing.Size(36, 17);
            this.RbtOr.TabIndex = 10;
            this.RbtOr.TabStop = true;
            this.RbtOr.Text = "Or";
            this.RbtOr.UseVisualStyleBackColor = true;
            // 
            // RbtnAnd
            // 
            this.RbtnAnd.AutoSize = true;
            this.RbtnAnd.Location = new System.Drawing.Point(6, 19);
            this.RbtnAnd.Name = "RbtnAnd";
            this.RbtnAnd.Size = new System.Drawing.Size(44, 17);
            this.RbtnAnd.TabIndex = 9;
            this.RbtnAnd.TabStop = true;
            this.RbtnAnd.Text = "And";
            this.RbtnAnd.UseVisualStyleBackColor = true;
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
            // RbtNot
            // 
            this.RbtNot.AutoSize = true;
            this.RbtNot.Location = new System.Drawing.Point(70, 19);
            this.RbtNot.Name = "RbtNot";
            this.RbtNot.Size = new System.Drawing.Size(42, 17);
            this.RbtNot.TabIndex = 18;
            this.RbtNot.TabStop = true;
            this.RbtNot.Text = "Not";
            this.RbtNot.UseVisualStyleBackColor = true;
            // 
            // FmSimpleNeuroNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 509);
            this.Controls.Add(this.GbxSetting);
            this.Controls.Add(this.GbxLearning);
            this.Controls.Add(this.TbxInputVector);
            this.Controls.Add(this.GbxDraw);
            this.Name = "FmSimpleNeuroNet";
            this.Text = "Простая нейро-сеть";
            this.Shown += new System.EventHandler(this.FmSimpleNeuroNet_Shown);
            this.GbxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).EndInit();
            this.GbxLearning.ResumeLayout(false);
            this.GbxLearning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAges)).EndInit();
            this.GbxSetting.ResumeLayout(false);
            this.GbxSetting.PerformLayout();
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
        private System.Windows.Forms.GroupBox GbxLearning;
        private System.Windows.Forms.GroupBox GbxSetting;
        private System.Windows.Forms.Label LblLevelNeuronCounts;
        private System.Windows.Forms.TextBox TbxLevelNeuronCounts;
        private System.Windows.Forms.NumericUpDown NudAges;
        private System.Windows.Forms.Label LblAges;
        private System.Windows.Forms.ProgressBar PrbLearning;
        private System.Windows.Forms.ListBox LbxTests;
        private System.Windows.Forms.Button BtnAddTest;
        private System.Windows.Forms.RadioButton RbtEq;
        private System.Windows.Forms.RadioButton RbtProp;
        private System.Windows.Forms.RadioButton RbtXor;
        private System.Windows.Forms.RadioButton RbtOr;
        private System.Windows.Forms.RadioButton RbtnAnd;
        private System.Windows.Forms.RadioButton RbtNot;
    }
}

