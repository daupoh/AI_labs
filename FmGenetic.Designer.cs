namespace wf_AI_lab1
{
    partial class FmGenetic
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
            this.GbxSetting = new System.Windows.Forms.GroupBox();
            this.BtnFindPath = new System.Windows.Forms.Button();
            this.LblMaxDistance = new System.Windows.Forms.Label();
            this.NudMaxDistance = new System.Windows.Forms.NumericUpDown();
            this.BtnUpdateParameters = new System.Windows.Forms.Button();
            this.LblWaitCounter = new System.Windows.Forms.Label();
            this.LblMutateChance = new System.Windows.Forms.Label();
            this.LblCrossbreedingChance = new System.Windows.Forms.Label();
            this.LblGensCount = new System.Windows.Forms.Label();
            this.LblPopulationSize = new System.Windows.Forms.Label();
            this.NudWaitCounter = new System.Windows.Forms.NumericUpDown();
            this.NudMutateChance = new System.Windows.Forms.NumericUpDown();
            this.NudCrossbreedingChance = new System.Windows.Forms.NumericUpDown();
            this.NudGensCount = new System.Windows.Forms.NumericUpDown();
            this.NudPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.GbxLog = new System.Windows.Forms.GroupBox();
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.GbxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWaitCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMutateChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCrossbreedingChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGensCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPopulationSize)).BeginInit();
            this.GbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxSetting
            // 
            this.GbxSetting.Controls.Add(this.BtnFindPath);
            this.GbxSetting.Controls.Add(this.LblMaxDistance);
            this.GbxSetting.Controls.Add(this.NudMaxDistance);
            this.GbxSetting.Controls.Add(this.BtnUpdateParameters);
            this.GbxSetting.Controls.Add(this.LblWaitCounter);
            this.GbxSetting.Controls.Add(this.LblMutateChance);
            this.GbxSetting.Controls.Add(this.LblCrossbreedingChance);
            this.GbxSetting.Controls.Add(this.LblGensCount);
            this.GbxSetting.Controls.Add(this.LblPopulationSize);
            this.GbxSetting.Controls.Add(this.NudWaitCounter);
            this.GbxSetting.Controls.Add(this.NudMutateChance);
            this.GbxSetting.Controls.Add(this.NudCrossbreedingChance);
            this.GbxSetting.Controls.Add(this.NudGensCount);
            this.GbxSetting.Controls.Add(this.NudPopulationSize);
            this.GbxSetting.Location = new System.Drawing.Point(12, 12);
            this.GbxSetting.Name = "GbxSetting";
            this.GbxSetting.Size = new System.Drawing.Size(286, 426);
            this.GbxSetting.TabIndex = 0;
            this.GbxSetting.TabStop = false;
            this.GbxSetting.Text = "Настройки генетики";
            // 
            // BtnFindPath
            // 
            this.BtnFindPath.Location = new System.Drawing.Point(178, 379);
            this.BtnFindPath.Name = "BtnFindPath";
            this.BtnFindPath.Size = new System.Drawing.Size(102, 41);
            this.BtnFindPath.TabIndex = 13;
            this.BtnFindPath.Text = "Найти кратчайший путь";
            this.BtnFindPath.UseVisualStyleBackColor = true;
            this.BtnFindPath.Click += new System.EventHandler(this.BtnFindPath_Click);
            // 
            // LblMaxDistance
            // 
            this.LblMaxDistance.Location = new System.Drawing.Point(6, 265);
            this.LblMaxDistance.Name = "LblMaxDistance";
            this.LblMaxDistance.Size = new System.Drawing.Size(136, 42);
            this.LblMaxDistance.TabIndex = 12;
            this.LblMaxDistance.Text = "Максимальное расстояние между вершинами";
            // 
            // NudMaxDistance
            // 
            this.NudMaxDistance.Location = new System.Drawing.Point(160, 274);
            this.NudMaxDistance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudMaxDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMaxDistance.Name = "NudMaxDistance";
            this.NudMaxDistance.Size = new System.Drawing.Size(120, 20);
            this.NudMaxDistance.TabIndex = 11;
            this.NudMaxDistance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BtnUpdateParameters
            // 
            this.BtnUpdateParameters.Location = new System.Drawing.Point(6, 379);
            this.BtnUpdateParameters.Name = "BtnUpdateParameters";
            this.BtnUpdateParameters.Size = new System.Drawing.Size(102, 41);
            this.BtnUpdateParameters.TabIndex = 10;
            this.BtnUpdateParameters.Text = "Обновить параметры";
            this.BtnUpdateParameters.UseVisualStyleBackColor = true;
            this.BtnUpdateParameters.Click += new System.EventHandler(this.BtnUpdateParameters_Click);
            // 
            // LblWaitCounter
            // 
            this.LblWaitCounter.Location = new System.Drawing.Point(6, 227);
            this.LblWaitCounter.Name = "LblWaitCounter";
            this.LblWaitCounter.Size = new System.Drawing.Size(136, 33);
            this.LblWaitCounter.TabIndex = 9;
            this.LblWaitCounter.Text = "Счетчик ожидания лучшей особи";
            // 
            // LblMutateChance
            // 
            this.LblMutateChance.AutoSize = true;
            this.LblMutateChance.Location = new System.Drawing.Point(6, 148);
            this.LblMutateChance.Name = "LblMutateChance";
            this.LblMutateChance.Size = new System.Drawing.Size(79, 13);
            this.LblMutateChance.TabIndex = 8;
            this.LblMutateChance.Text = "Шанс мутации";
            // 
            // LblCrossbreedingChance
            // 
            this.LblCrossbreedingChance.AutoSize = true;
            this.LblCrossbreedingChance.Location = new System.Drawing.Point(6, 112);
            this.LblCrossbreedingChance.Name = "LblCrossbreedingChance";
            this.LblCrossbreedingChance.Size = new System.Drawing.Size(97, 13);
            this.LblCrossbreedingChance.TabIndex = 7;
            this.LblCrossbreedingChance.Text = "Шанс спаривания";
            // 
            // LblGensCount
            // 
            this.LblGensCount.AutoSize = true;
            this.LblGensCount.Location = new System.Drawing.Point(6, 73);
            this.LblGensCount.Name = "LblGensCount";
            this.LblGensCount.Size = new System.Drawing.Size(98, 13);
            this.LblGensCount.TabIndex = 6;
            this.LblGensCount.Text = "Количество генов";
            // 
            // LblPopulationSize
            // 
            this.LblPopulationSize.AutoSize = true;
            this.LblPopulationSize.Location = new System.Drawing.Point(6, 34);
            this.LblPopulationSize.Name = "LblPopulationSize";
            this.LblPopulationSize.Size = new System.Drawing.Size(102, 13);
            this.LblPopulationSize.TabIndex = 5;
            this.LblPopulationSize.Text = "Размер популяции";
            // 
            // NudWaitCounter
            // 
            this.NudWaitCounter.Location = new System.Drawing.Point(160, 227);
            this.NudWaitCounter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudWaitCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudWaitCounter.Name = "NudWaitCounter";
            this.NudWaitCounter.Size = new System.Drawing.Size(120, 20);
            this.NudWaitCounter.TabIndex = 4;
            this.NudWaitCounter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NudMutateChance
            // 
            this.NudMutateChance.DecimalPlaces = 3;
            this.NudMutateChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NudMutateChance.Location = new System.Drawing.Point(160, 146);
            this.NudMutateChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMutateChance.Name = "NudMutateChance";
            this.NudMutateChance.Size = new System.Drawing.Size(120, 20);
            this.NudMutateChance.TabIndex = 3;
            this.NudMutateChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // NudCrossbreedingChance
            // 
            this.NudCrossbreedingChance.DecimalPlaces = 3;
            this.NudCrossbreedingChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NudCrossbreedingChance.Location = new System.Drawing.Point(160, 110);
            this.NudCrossbreedingChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCrossbreedingChance.Name = "NudCrossbreedingChance";
            this.NudCrossbreedingChance.Size = new System.Drawing.Size(120, 20);
            this.NudCrossbreedingChance.TabIndex = 2;
            this.NudCrossbreedingChance.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // NudGensCount
            // 
            this.NudGensCount.Location = new System.Drawing.Point(160, 71);
            this.NudGensCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudGensCount.Name = "NudGensCount";
            this.NudGensCount.Size = new System.Drawing.Size(120, 20);
            this.NudGensCount.TabIndex = 1;
            this.NudGensCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NudPopulationSize
            // 
            this.NudPopulationSize.Location = new System.Drawing.Point(160, 32);
            this.NudPopulationSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudPopulationSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPopulationSize.Name = "NudPopulationSize";
            this.NudPopulationSize.Size = new System.Drawing.Size(120, 20);
            this.NudPopulationSize.TabIndex = 0;
            this.NudPopulationSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // GbxLog
            // 
            this.GbxLog.Controls.Add(this.TbxLog);
            this.GbxLog.Location = new System.Drawing.Point(304, 12);
            this.GbxLog.Name = "GbxLog";
            this.GbxLog.Size = new System.Drawing.Size(462, 426);
            this.GbxLog.TabIndex = 1;
            this.GbxLog.TabStop = false;
            this.GbxLog.Text = "Лог";
            // 
            // TbxLog
            // 
            this.TbxLog.Location = new System.Drawing.Point(6, 19);
            this.TbxLog.Multiline = true;
            this.TbxLog.Name = "TbxLog";
            this.TbxLog.ReadOnly = true;
            this.TbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxLog.Size = new System.Drawing.Size(450, 391);
            this.TbxLog.TabIndex = 0;
            // 
            // FmGenetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.GbxLog);
            this.Controls.Add(this.GbxSetting);
            this.Name = "FmGenetic";
            this.Text = "Генетические алгоритмы";
            this.GbxSetting.ResumeLayout(false);
            this.GbxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWaitCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMutateChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCrossbreedingChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGensCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPopulationSize)).EndInit();
            this.GbxLog.ResumeLayout(false);
            this.GbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxSetting;
        private System.Windows.Forms.Button BtnFindPath;
        private System.Windows.Forms.Label LblMaxDistance;
        private System.Windows.Forms.NumericUpDown NudMaxDistance;
        private System.Windows.Forms.Button BtnUpdateParameters;
        private System.Windows.Forms.Label LblWaitCounter;
        private System.Windows.Forms.Label LblMutateChance;
        private System.Windows.Forms.Label LblCrossbreedingChance;
        private System.Windows.Forms.Label LblGensCount;
        private System.Windows.Forms.Label LblPopulationSize;
        private System.Windows.Forms.NumericUpDown NudWaitCounter;
        private System.Windows.Forms.NumericUpDown NudMutateChance;
        private System.Windows.Forms.NumericUpDown NudCrossbreedingChance;
        private System.Windows.Forms.NumericUpDown NudGensCount;
        private System.Windows.Forms.NumericUpDown NudPopulationSize;
        private System.Windows.Forms.GroupBox GbxLog;
        private System.Windows.Forms.TextBox TbxLog;
    }
}

