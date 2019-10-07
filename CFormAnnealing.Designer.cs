

namespace wf_AI_lab1
{
    partial class CFormAnnealing
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
            this.m_rTbxBoardInText = new System.Windows.Forms.TextBox();
            this.m_rBtnAnnealing = new System.Windows.Forms.Button();
            this.m_rDgvBoardTable = new System.Windows.Forms.DataGridView();
            this.gbxAnnealingParams = new System.Windows.Forms.GroupBox();
            this.m_rBtnDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCountOfSteps = new System.Windows.Forms.Label();
            this.lblSizeOfBoard = new System.Windows.Forms.Label();
            this.m_rNumFinTemp = new System.Windows.Forms.NumericUpDown();
            this.m_rNumInitTemp = new System.Windows.Forms.NumericUpDown();
            this.m_rNumAlpha = new System.Windows.Forms.NumericUpDown();
            this.m_rNumCountOfSteps = new System.Windows.Forms.NumericUpDown();
            this.m_rNumSizeBoard = new System.Windows.Forms.NumericUpDown();
            this.m_rGbxLog = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_rDgvBoardTable)).BeginInit();
            this.gbxAnnealingParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumFinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumInitTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumCountOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumSizeBoard)).BeginInit();
            this.m_rGbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_rTbxBoardInText
            // 
            this.m_rTbxBoardInText.Location = new System.Drawing.Point(6, 19);
            this.m_rTbxBoardInText.Multiline = true;
            this.m_rTbxBoardInText.Name = "m_rTbxBoardInText";
            this.m_rTbxBoardInText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_rTbxBoardInText.Size = new System.Drawing.Size(301, 220);
            this.m_rTbxBoardInText.TabIndex = 0;
            // 
            // m_rBtnAnnealing
            // 
            this.m_rBtnAnnealing.Location = new System.Drawing.Point(9, 211);
            this.m_rBtnAnnealing.Name = "m_rBtnAnnealing";
            this.m_rBtnAnnealing.Size = new System.Drawing.Size(137, 41);
            this.m_rBtnAnnealing.TabIndex = 1;
            this.m_rBtnAnnealing.Text = "Запустить алгоритм";
            this.m_rBtnAnnealing.UseVisualStyleBackColor = true;
            this.m_rBtnAnnealing.Click += new System.EventHandler(this.BtnAnnealing_Click);
            // 
            // m_rDgvBoardTable
            // 
            this.m_rDgvBoardTable.AllowUserToResizeColumns = false;
            this.m_rDgvBoardTable.AllowUserToResizeRows = false;
            this.m_rDgvBoardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_rDgvBoardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_rDgvBoardTable.ColumnHeadersVisible = false;
            this.m_rDgvBoardTable.Location = new System.Drawing.Point(331, 12);
            this.m_rDgvBoardTable.MultiSelect = false;
            this.m_rDgvBoardTable.Name = "m_rDgvBoardTable";
            this.m_rDgvBoardTable.ReadOnly = true;
            this.m_rDgvBoardTable.RowHeadersVisible = false;
            this.m_rDgvBoardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.m_rDgvBoardTable.Size = new System.Drawing.Size(370, 510);
            this.m_rDgvBoardTable.TabIndex = 2;
            // 
            // gbxAnnealingParams
            // 
            this.gbxAnnealingParams.Controls.Add(this.m_rBtnDefault);
            this.gbxAnnealingParams.Controls.Add(this.label2);
            this.gbxAnnealingParams.Controls.Add(this.label1);
            this.gbxAnnealingParams.Controls.Add(this.m_rBtnAnnealing);
            this.gbxAnnealingParams.Controls.Add(this.lbl);
            this.gbxAnnealingParams.Controls.Add(this.lblCountOfSteps);
            this.gbxAnnealingParams.Controls.Add(this.lblSizeOfBoard);
            this.gbxAnnealingParams.Controls.Add(this.m_rNumFinTemp);
            this.gbxAnnealingParams.Controls.Add(this.m_rNumInitTemp);
            this.gbxAnnealingParams.Controls.Add(this.m_rNumAlpha);
            this.gbxAnnealingParams.Controls.Add(this.m_rNumCountOfSteps);
            this.gbxAnnealingParams.Controls.Add(this.m_rNumSizeBoard);
            this.gbxAnnealingParams.Location = new System.Drawing.Point(12, 12);
            this.gbxAnnealingParams.Name = "gbxAnnealingParams";
            this.gbxAnnealingParams.Size = new System.Drawing.Size(313, 265);
            this.gbxAnnealingParams.TabIndex = 3;
            this.gbxAnnealingParams.TabStop = false;
            this.gbxAnnealingParams.Text = "Параметры алгоритма";
            // 
            // m_rBtnDefault
            // 
            this.m_rBtnDefault.Location = new System.Drawing.Point(170, 211);
            this.m_rBtnDefault.Name = "m_rBtnDefault";
            this.m_rBtnDefault.Size = new System.Drawing.Size(137, 41);
            this.m_rBtnDefault.TabIndex = 10;
            this.m_rBtnDefault.Text = "Сброс параметров";
            this.m_rBtnDefault.UseVisualStyleBackColor = true;
            this.m_rBtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Конечная \"температура\"";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Начальная \"температура\"";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 93);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(123, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Скорость \"остывания\"";
            // 
            // lblCountOfSteps
            // 
            this.lblCountOfSteps.AutoSize = true;
            this.lblCountOfSteps.Location = new System.Drawing.Point(6, 57);
            this.lblCountOfSteps.Name = "lblCountOfSteps";
            this.lblCountOfSteps.Size = new System.Drawing.Size(100, 13);
            this.lblCountOfSteps.TabIndex = 6;
            this.lblCountOfSteps.Text = "Количество шагов";
            // 
            // lblSizeOfBoard
            // 
            this.lblSizeOfBoard.AutoSize = true;
            this.lblSizeOfBoard.Location = new System.Drawing.Point(6, 21);
            this.lblSizeOfBoard.Name = "lblSizeOfBoard";
            this.lblSizeOfBoard.Size = new System.Drawing.Size(79, 13);
            this.lblSizeOfBoard.TabIndex = 5;
            this.lblSizeOfBoard.Text = "Размер доски";
            // 
            // m_rNumFinTemp
            // 
            this.m_rNumFinTemp.DecimalPlaces = 3;
            this.m_rNumFinTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumFinTemp.Location = new System.Drawing.Point(170, 174);
            this.m_rNumFinTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.m_rNumFinTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumFinTemp.Name = "m_rNumFinTemp";
            this.m_rNumFinTemp.Size = new System.Drawing.Size(137, 20);
            this.m_rNumFinTemp.TabIndex = 4;
            this.m_rNumFinTemp.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumFinTemp.ValueChanged += new System.EventHandler(this.NumFinTemp_ValueChanged);
            // 
            // m_rNumInitTemp
            // 
            this.m_rNumInitTemp.DecimalPlaces = 3;
            this.m_rNumInitTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumInitTemp.Location = new System.Drawing.Point(170, 130);
            this.m_rNumInitTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.m_rNumInitTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumInitTemp.Name = "m_rNumInitTemp";
            this.m_rNumInitTemp.Size = new System.Drawing.Size(137, 20);
            this.m_rNumInitTemp.TabIndex = 3;
            this.m_rNumInitTemp.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.m_rNumInitTemp.ValueChanged += new System.EventHandler(this.NumInitTemp_ValueChanged);
            // 
            // m_rNumAlpha
            // 
            this.m_rNumAlpha.DecimalPlaces = 3;
            this.m_rNumAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.m_rNumAlpha.Location = new System.Drawing.Point(170, 91);
            this.m_rNumAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_rNumAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.m_rNumAlpha.Name = "m_rNumAlpha";
            this.m_rNumAlpha.Size = new System.Drawing.Size(137, 20);
            this.m_rNumAlpha.TabIndex = 2;
            this.m_rNumAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // m_rNumCountOfSteps
            // 
            this.m_rNumCountOfSteps.Location = new System.Drawing.Point(170, 55);
            this.m_rNumCountOfSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.m_rNumCountOfSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_rNumCountOfSteps.Name = "m_rNumCountOfSteps";
            this.m_rNumCountOfSteps.Size = new System.Drawing.Size(137, 20);
            this.m_rNumCountOfSteps.TabIndex = 1;
            this.m_rNumCountOfSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // m_rNumSizeBoard
            // 
            this.m_rNumSizeBoard.Location = new System.Drawing.Point(170, 21);
            this.m_rNumSizeBoard.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_rNumSizeBoard.Name = "m_rNumSizeBoard";
            this.m_rNumSizeBoard.Size = new System.Drawing.Size(137, 20);
            this.m_rNumSizeBoard.TabIndex = 0;
            this.m_rNumSizeBoard.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // m_rGbxLog
            // 
            this.m_rGbxLog.Controls.Add(this.m_rTbxBoardInText);
            this.m_rGbxLog.Location = new System.Drawing.Point(12, 283);
            this.m_rGbxLog.Name = "m_rGbxLog";
            this.m_rGbxLog.Size = new System.Drawing.Size(313, 252);
            this.m_rGbxLog.TabIndex = 4;
            this.m_rGbxLog.TabStop = false;
            this.m_rGbxLog.Text = "Лог алгоритма";
            // 
            // CFormAnnealing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 540);
            this.Controls.Add(this.m_rGbxLog);
            this.Controls.Add(this.gbxAnnealingParams);
            this.Controls.Add(this.m_rDgvBoardTable);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 578);
            this.Name = "CFormAnnealing";
            this.Text = "Алгоритм \"отжига\"";
            ((System.ComponentModel.ISupportInitialize)(this.m_rDgvBoardTable)).EndInit();
            this.gbxAnnealingParams.ResumeLayout(false);
            this.gbxAnnealingParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumFinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumInitTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumCountOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_rNumSizeBoard)).EndInit();
            this.m_rGbxLog.ResumeLayout(false);
            this.m_rGbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox m_rTbxBoardInText;
        private System.Windows.Forms.Button m_rBtnAnnealing;
        private System.Windows.Forms.DataGridView m_rDgvBoardTable;
        private System.Windows.Forms.GroupBox gbxAnnealingParams;
        private System.Windows.Forms.NumericUpDown m_rNumAlpha;
        private System.Windows.Forms.NumericUpDown m_rNumCountOfSteps;
        private System.Windows.Forms.NumericUpDown m_rNumSizeBoard;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCountOfSteps;
        private System.Windows.Forms.Label lblSizeOfBoard;
        private System.Windows.Forms.NumericUpDown m_rNumFinTemp;
        private System.Windows.Forms.NumericUpDown m_rNumInitTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_rBtnDefault;
        private System.Windows.Forms.GroupBox m_rGbxLog;
    }
}

