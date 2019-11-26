namespace wf_AI_lab1
{
    partial class FmAntAlg
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
            this.GbxSettings = new System.Windows.Forms.GroupBox();
            this.LblAttractive = new System.Windows.Forms.Label();
            this.NudAttractive = new System.Windows.Forms.NumericUpDown();
            this.BtnCreateNet = new System.Windows.Forms.Button();
            this.LblEvaporation = new System.Windows.Forms.Label();
            this.LblDistancePower = new System.Windows.Forms.Label();
            this.LblPheromonePower = new System.Windows.Forms.Label();
            this.LblAntCount = new System.Windows.Forms.Label();
            this.LblVertexCount = new System.Windows.Forms.Label();
            this.NudEvaporation = new System.Windows.Forms.NumericUpDown();
            this.NudDistancePower = new System.Windows.Forms.NumericUpDown();
            this.NudPheromonePower = new System.Windows.Forms.NumericUpDown();
            this.NudAntCount = new System.Windows.Forms.NumericUpDown();
            this.NudVertexCount = new System.Windows.Forms.NumericUpDown();
            this.GbxNet = new System.Windows.Forms.GroupBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnRandomNet = new System.Windows.Forms.Button();
            this.DgvNet = new System.Windows.Forms.DataGridView();
            this.GbxAnts = new System.Windows.Forms.GroupBox();
            this.DgvAnts = new System.Windows.Forms.DataGridView();
            this.GbxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAttractive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEvaporation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPheromonePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAntCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVertexCount)).BeginInit();
            this.GbxNet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNet)).BeginInit();
            this.GbxAnts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnts)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxSettings
            // 
            this.GbxSettings.Controls.Add(this.LblAttractive);
            this.GbxSettings.Controls.Add(this.NudAttractive);
            this.GbxSettings.Controls.Add(this.BtnCreateNet);
            this.GbxSettings.Controls.Add(this.LblEvaporation);
            this.GbxSettings.Controls.Add(this.LblDistancePower);
            this.GbxSettings.Controls.Add(this.LblPheromonePower);
            this.GbxSettings.Controls.Add(this.LblAntCount);
            this.GbxSettings.Controls.Add(this.LblVertexCount);
            this.GbxSettings.Controls.Add(this.NudEvaporation);
            this.GbxSettings.Controls.Add(this.NudDistancePower);
            this.GbxSettings.Controls.Add(this.NudPheromonePower);
            this.GbxSettings.Controls.Add(this.NudAntCount);
            this.GbxSettings.Controls.Add(this.NudVertexCount);
            this.GbxSettings.Location = new System.Drawing.Point(12, 12);
            this.GbxSettings.Name = "GbxSettings";
            this.GbxSettings.Size = new System.Drawing.Size(369, 288);
            this.GbxSettings.TabIndex = 0;
            this.GbxSettings.TabStop = false;
            this.GbxSettings.Text = "Настройки алгоритма";
            // 
            // LblAttractive
            // 
            this.LblAttractive.Location = new System.Drawing.Point(6, 205);
            this.LblAttractive.Name = "LblAttractive";
            this.LblAttractive.Size = new System.Drawing.Size(232, 32);
            this.LblAttractive.TabIndex = 13;
            this.LblAttractive.Text = "Константа \"привлекательности\"";
            // 
            // NudAttractive
            // 
            this.NudAttractive.Location = new System.Drawing.Point(243, 206);
            this.NudAttractive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAttractive.Name = "NudAttractive";
            this.NudAttractive.Size = new System.Drawing.Size(120, 20);
            this.NudAttractive.TabIndex = 12;
            this.NudAttractive.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // BtnCreateNet
            // 
            this.BtnCreateNet.Location = new System.Drawing.Point(243, 245);
            this.BtnCreateNet.Name = "BtnCreateNet";
            this.BtnCreateNet.Size = new System.Drawing.Size(120, 37);
            this.BtnCreateNet.TabIndex = 10;
            this.BtnCreateNet.Text = "Создать сеть вершин";
            this.BtnCreateNet.UseVisualStyleBackColor = true;
            this.BtnCreateNet.Click += new System.EventHandler(this.BtnCreateNet_Click);
            // 
            // LblEvaporation
            // 
            this.LblEvaporation.Location = new System.Drawing.Point(6, 152);
            this.LblEvaporation.Name = "LblEvaporation";
            this.LblEvaporation.Size = new System.Drawing.Size(232, 32);
            this.LblEvaporation.TabIndex = 9;
            this.LblEvaporation.Text = "Коэффициент испарения феромонов";
            // 
            // LblDistancePower
            // 
            this.LblDistancePower.Location = new System.Drawing.Point(6, 114);
            this.LblDistancePower.Name = "LblDistancePower";
            this.LblDistancePower.Size = new System.Drawing.Size(232, 11);
            this.LblDistancePower.TabIndex = 8;
            this.LblDistancePower.Text = "Степень влияния дистанции";
            // 
            // LblPheromonePower
            // 
            this.LblPheromonePower.Location = new System.Drawing.Point(6, 82);
            this.LblPheromonePower.Name = "LblPheromonePower";
            this.LblPheromonePower.Size = new System.Drawing.Size(232, 11);
            this.LblPheromonePower.TabIndex = 7;
            this.LblPheromonePower.Text = "Степень влияния феромонов";
            // 
            // LblAntCount
            // 
            this.LblAntCount.AutoSize = true;
            this.LblAntCount.Location = new System.Drawing.Point(6, 56);
            this.LblAntCount.Name = "LblAntCount";
            this.LblAntCount.Size = new System.Drawing.Size(118, 13);
            this.LblAntCount.TabIndex = 6;
            this.LblAntCount.Text = "Количество муравьев";
            // 
            // LblVertexCount
            // 
            this.LblVertexCount.AutoSize = true;
            this.LblVertexCount.Location = new System.Drawing.Point(6, 30);
            this.LblVertexCount.Name = "LblVertexCount";
            this.LblVertexCount.Size = new System.Drawing.Size(107, 13);
            this.LblVertexCount.TabIndex = 5;
            this.LblVertexCount.Text = "Количество вершин";
            // 
            // NudEvaporation
            // 
            this.NudEvaporation.DecimalPlaces = 4;
            this.NudEvaporation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.NudEvaporation.Location = new System.Drawing.Point(243, 152);
            this.NudEvaporation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudEvaporation.Name = "NudEvaporation";
            this.NudEvaporation.Size = new System.Drawing.Size(120, 20);
            this.NudEvaporation.TabIndex = 4;
            this.NudEvaporation.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // NudDistancePower
            // 
            this.NudDistancePower.Location = new System.Drawing.Point(244, 114);
            this.NudDistancePower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDistancePower.Name = "NudDistancePower";
            this.NudDistancePower.Size = new System.Drawing.Size(120, 20);
            this.NudDistancePower.TabIndex = 3;
            this.NudDistancePower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudPheromonePower
            // 
            this.NudPheromonePower.Location = new System.Drawing.Point(244, 82);
            this.NudPheromonePower.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPheromonePower.Name = "NudPheromonePower";
            this.NudPheromonePower.Size = new System.Drawing.Size(120, 20);
            this.NudPheromonePower.TabIndex = 2;
            this.NudPheromonePower.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NudAntCount
            // 
            this.NudAntCount.Location = new System.Drawing.Point(244, 56);
            this.NudAntCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudAntCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAntCount.Name = "NudAntCount";
            this.NudAntCount.Size = new System.Drawing.Size(120, 20);
            this.NudAntCount.TabIndex = 1;
            this.NudAntCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NudVertexCount
            // 
            this.NudVertexCount.Location = new System.Drawing.Point(244, 30);
            this.NudVertexCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudVertexCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NudVertexCount.Name = "NudVertexCount";
            this.NudVertexCount.Size = new System.Drawing.Size(120, 20);
            this.NudVertexCount.TabIndex = 0;
            this.NudVertexCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // GbxNet
            // 
            this.GbxNet.Controls.Add(this.BtnStart);
            this.GbxNet.Controls.Add(this.BtnRandomNet);
            this.GbxNet.Controls.Add(this.DgvNet);
            this.GbxNet.Enabled = false;
            this.GbxNet.Location = new System.Drawing.Point(387, 14);
            this.GbxNet.Name = "GbxNet";
            this.GbxNet.Size = new System.Drawing.Size(474, 482);
            this.GbxNet.TabIndex = 1;
            this.GbxNet.TabStop = false;
            this.GbxNet.Text = "Сеть вершин";
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(325, 424);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(143, 52);
            this.BtnStart.TabIndex = 16;
            this.BtnStart.Text = "Запустить алгоритм";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnRandomNet
            // 
            this.BtnRandomNet.Location = new System.Drawing.Point(6, 424);
            this.BtnRandomNet.Name = "BtnRandomNet";
            this.BtnRandomNet.Size = new System.Drawing.Size(143, 52);
            this.BtnRandomNet.TabIndex = 14;
            this.BtnRandomNet.Text = "Заполнить случайными значениями";
            this.BtnRandomNet.UseVisualStyleBackColor = true;
            this.BtnRandomNet.Click += new System.EventHandler(this.BtnRandomNet_Click);
            // 
            // DgvNet
            // 
            this.DgvNet.AllowUserToAddRows = false;
            this.DgvNet.AllowUserToDeleteRows = false;
            this.DgvNet.AllowUserToResizeColumns = false;
            this.DgvNet.AllowUserToResizeRows = false;
            this.DgvNet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvNet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvNet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNet.Location = new System.Drawing.Point(6, 19);
            this.DgvNet.MultiSelect = false;
            this.DgvNet.Name = "DgvNet";
            this.DgvNet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvNet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvNet.Size = new System.Drawing.Size(462, 399);
            this.DgvNet.TabIndex = 0;
            this.DgvNet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNet_CellEndEdit);
            // 
            // GbxAnts
            // 
            this.GbxAnts.Controls.Add(this.DgvAnts);
            this.GbxAnts.Enabled = false;
            this.GbxAnts.Location = new System.Drawing.Point(12, 312);
            this.GbxAnts.Name = "GbxAnts";
            this.GbxAnts.Size = new System.Drawing.Size(369, 184);
            this.GbxAnts.TabIndex = 2;
            this.GbxAnts.TabStop = false;
            this.GbxAnts.Text = "Муравьи";
            // 
            // DgvAnts
            // 
            this.DgvAnts.AllowUserToAddRows = false;
            this.DgvAnts.AllowUserToDeleteRows = false;
            this.DgvAnts.AllowUserToResizeColumns = false;
            this.DgvAnts.AllowUserToResizeRows = false;
            this.DgvAnts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvAnts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvAnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnts.Location = new System.Drawing.Point(9, 19);
            this.DgvAnts.MultiSelect = false;
            this.DgvAnts.Name = "DgvAnts";
            this.DgvAnts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvAnts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvAnts.Size = new System.Drawing.Size(354, 159);
            this.DgvAnts.TabIndex = 1;
            this.DgvAnts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnts_CellEndEdit);
            // 
            // FmAntAlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 508);
            this.Controls.Add(this.GbxAnts);
            this.Controls.Add(this.GbxNet);
            this.Controls.Add(this.GbxSettings);
            this.Name = "FmAntAlg";
            this.Text = "Муравьиный алгоритм";
            this.GbxSettings.ResumeLayout(false);
            this.GbxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAttractive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEvaporation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPheromonePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAntCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVertexCount)).EndInit();
            this.GbxNet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvNet)).EndInit();
            this.GbxAnts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxSettings;
        private System.Windows.Forms.NumericUpDown NudEvaporation;
        private System.Windows.Forms.NumericUpDown NudDistancePower;
        private System.Windows.Forms.NumericUpDown NudPheromonePower;
        private System.Windows.Forms.NumericUpDown NudAntCount;
        private System.Windows.Forms.NumericUpDown NudVertexCount;
        private System.Windows.Forms.Label LblEvaporation;
        private System.Windows.Forms.Label LblDistancePower;
        private System.Windows.Forms.Label LblPheromonePower;
        private System.Windows.Forms.Label LblAntCount;
        private System.Windows.Forms.Label LblVertexCount;
        private System.Windows.Forms.Button BtnCreateNet;
        private System.Windows.Forms.GroupBox GbxNet;
        private System.Windows.Forms.DataGridView DgvNet;
        private System.Windows.Forms.Label LblAttractive;
        private System.Windows.Forms.NumericUpDown NudAttractive;
        private System.Windows.Forms.Button BtnRandomNet;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.GroupBox GbxAnts;
        private System.Windows.Forms.DataGridView DgvAnts;
    }
}

