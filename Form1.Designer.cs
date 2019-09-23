

namespace wf_AI_lab1
{
    partial class Form1
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
            this.tbxBoardInText = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvBoardTable = new System.Windows.Forms.DataGridView();
            this.gbxAnnealingParams = new System.Windows.Forms.GroupBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCountOfSteps = new System.Windows.Forms.Label();
            this.lblSizeOfBoard = new System.Windows.Forms.Label();
            this.numFinTemp = new System.Windows.Forms.NumericUpDown();
            this.numInitTemp = new System.Windows.Forms.NumericUpDown();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.numCountOfSteps = new System.Windows.Forms.NumericUpDown();
            this.numSizeBoard = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardTable)).BeginInit();
            this.gbxAnnealingParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBoardInText
            // 
            this.tbxBoardInText.Location = new System.Drawing.Point(12, 283);
            this.tbxBoardInText.Multiline = true;
            this.tbxBoardInText.Name = "tbxBoardInText";
            this.tbxBoardInText.Size = new System.Drawing.Size(232, 208);
            this.tbxBoardInText.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(9, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 41);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Запустить алгоритм";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // dgvBoardTable
            // 
            this.dgvBoardTable.AllowUserToResizeColumns = false;
            this.dgvBoardTable.AllowUserToResizeRows = false;
            this.dgvBoardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoardTable.ColumnHeadersVisible = false;
            this.dgvBoardTable.Location = new System.Drawing.Point(267, 12);
            this.dgvBoardTable.MultiSelect = false;
            this.dgvBoardTable.Name = "dgvBoardTable";
            this.dgvBoardTable.ReadOnly = true;
            this.dgvBoardTable.RowHeadersVisible = false;
            this.dgvBoardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBoardTable.Size = new System.Drawing.Size(370, 370);
            this.dgvBoardTable.TabIndex = 2;
            // 
            // gbxAnnealingParams
            // 
            this.gbxAnnealingParams.Controls.Add(this.btnDefault);
            this.gbxAnnealingParams.Controls.Add(this.label2);
            this.gbxAnnealingParams.Controls.Add(this.label1);
            this.gbxAnnealingParams.Controls.Add(this.btnCalculate);
            this.gbxAnnealingParams.Controls.Add(this.lbl);
            this.gbxAnnealingParams.Controls.Add(this.lblCountOfSteps);
            this.gbxAnnealingParams.Controls.Add(this.lblSizeOfBoard);
            this.gbxAnnealingParams.Controls.Add(this.numFinTemp);
            this.gbxAnnealingParams.Controls.Add(this.numInitTemp);
            this.gbxAnnealingParams.Controls.Add(this.numAlpha);
            this.gbxAnnealingParams.Controls.Add(this.numCountOfSteps);
            this.gbxAnnealingParams.Controls.Add(this.numSizeBoard);
            this.gbxAnnealingParams.Location = new System.Drawing.Point(12, 12);
            this.gbxAnnealingParams.Name = "gbxAnnealingParams";
            this.gbxAnnealingParams.Size = new System.Drawing.Size(232, 265);
            this.gbxAnnealingParams.TabIndex = 3;
            this.gbxAnnealingParams.TabStop = false;
            this.gbxAnnealingParams.Text = "Параметры алгоритма";
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(135, 211);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(87, 41);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Сброс параметров";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
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
            // numFinTemp
            // 
            this.numFinTemp.DecimalPlaces = 3;
            this.numFinTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numFinTemp.Location = new System.Drawing.Point(135, 174);
            this.numFinTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numFinTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numFinTemp.Name = "numFinTemp";
            this.numFinTemp.Size = new System.Drawing.Size(87, 20);
            this.numFinTemp.TabIndex = 4;
            this.numFinTemp.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numFinTemp.ValueChanged += new System.EventHandler(this.NumFinTemp_ValueChanged);
            // 
            // numInitTemp
            // 
            this.numInitTemp.DecimalPlaces = 3;
            this.numInitTemp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numInitTemp.Location = new System.Drawing.Point(137, 130);
            this.numInitTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInitTemp.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numInitTemp.Name = "numInitTemp";
            this.numInitTemp.Size = new System.Drawing.Size(85, 20);
            this.numInitTemp.TabIndex = 3;
            this.numInitTemp.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numInitTemp.ValueChanged += new System.EventHandler(this.NumInitTemp_ValueChanged);
            // 
            // numAlpha
            // 
            this.numAlpha.DecimalPlaces = 3;
            this.numAlpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numAlpha.Location = new System.Drawing.Point(137, 91);
            this.numAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAlpha.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(85, 20);
            this.numAlpha.TabIndex = 2;
            this.numAlpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // numCountOfSteps
            // 
            this.numCountOfSteps.Location = new System.Drawing.Point(137, 55);
            this.numCountOfSteps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCountOfSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountOfSteps.Name = "numCountOfSteps";
            this.numCountOfSteps.Size = new System.Drawing.Size(85, 20);
            this.numCountOfSteps.TabIndex = 1;
            this.numCountOfSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSizeBoard
            // 
            this.numSizeBoard.Location = new System.Drawing.Point(137, 21);
            this.numSizeBoard.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSizeBoard.Name = "numSizeBoard";
            this.numSizeBoard.Size = new System.Drawing.Size(85, 20);
            this.numSizeBoard.TabIndex = 0;
            this.numSizeBoard.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.gbxAnnealingParams);
            this.Controls.Add(this.dgvBoardTable);
            this.Controls.Add(this.tbxBoardInText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardTable)).EndInit();
            this.gbxAnnealingParams.ResumeLayout(false);
            this.gbxAnnealingParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountOfSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSizeBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBoardInText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvBoardTable;
        private System.Windows.Forms.GroupBox gbxAnnealingParams;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.NumericUpDown numCountOfSteps;
        private System.Windows.Forms.NumericUpDown numSizeBoard;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCountOfSteps;
        private System.Windows.Forms.Label lblSizeOfBoard;
        private System.Windows.Forms.NumericUpDown numFinTemp;
        private System.Windows.Forms.NumericUpDown numInitTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDefault;
    }
}

