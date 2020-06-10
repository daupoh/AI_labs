namespace wf_AI_lab1
{
    partial class FmAnts
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
            this.LblRepeatRun = new System.Windows.Forms.Label();
            this.NudRepeatRun = new System.Windows.Forms.NumericUpDown();
            this.LblMaxDistance = new System.Windows.Forms.Label();
            this.NudMaxDistance = new System.Windows.Forms.NumericUpDown();
            this.NudDistancePower = new System.Windows.Forms.NumericUpDown();
            this.LblDistancePower = new System.Windows.Forms.Label();
            this.NudPheromonePower = new System.Windows.Forms.NumericUpDown();
            this.BtnFindPath = new System.Windows.Forms.Button();
            this.LblPheromonePower = new System.Windows.Forms.Label();
            this.LblAttractive = new System.Windows.Forms.Label();
            this.LblEsporation = new System.Windows.Forms.Label();
            this.LblVertexCount = new System.Windows.Forms.Label();
            this.LblAntsCount = new System.Windows.Forms.Label();
            this.NudAttractive = new System.Windows.Forms.NumericUpDown();
            this.NudEsporation = new System.Windows.Forms.NumericUpDown();
            this.NudVertexCount = new System.Windows.Forms.NumericUpDown();
            this.NudAntsCount = new System.Windows.Forms.NumericUpDown();
            this.GbxLog = new System.Windows.Forms.GroupBox();
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.GbxSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRepeatRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPheromonePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAttractive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEsporation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVertexCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAntsCount)).BeginInit();
            this.GbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxSetting
            // 
            this.GbxSetting.Controls.Add(this.LblRepeatRun);
            this.GbxSetting.Controls.Add(this.NudRepeatRun);
            this.GbxSetting.Controls.Add(this.LblMaxDistance);
            this.GbxSetting.Controls.Add(this.NudMaxDistance);
            this.GbxSetting.Controls.Add(this.NudDistancePower);
            this.GbxSetting.Controls.Add(this.LblDistancePower);
            this.GbxSetting.Controls.Add(this.NudPheromonePower);
            this.GbxSetting.Controls.Add(this.BtnFindPath);
            this.GbxSetting.Controls.Add(this.LblPheromonePower);
            this.GbxSetting.Controls.Add(this.LblAttractive);
            this.GbxSetting.Controls.Add(this.LblEsporation);
            this.GbxSetting.Controls.Add(this.LblVertexCount);
            this.GbxSetting.Controls.Add(this.LblAntsCount);
            this.GbxSetting.Controls.Add(this.NudAttractive);
            this.GbxSetting.Controls.Add(this.NudEsporation);
            this.GbxSetting.Controls.Add(this.NudVertexCount);
            this.GbxSetting.Controls.Add(this.NudAntsCount);
            this.GbxSetting.Location = new System.Drawing.Point(12, 12);
            this.GbxSetting.Name = "GbxSetting";
            this.GbxSetting.Size = new System.Drawing.Size(286, 462);
            this.GbxSetting.TabIndex = 0;
            this.GbxSetting.TabStop = false;
            this.GbxSetting.Text = "Настройки алгоритма";
            // 
            // LblRepeatRun
            // 
            this.LblRepeatRun.Location = new System.Drawing.Point(6, 341);
            this.LblRepeatRun.Name = "LblRepeatRun";
            this.LblRepeatRun.Size = new System.Drawing.Size(118, 47);
            this.LblRepeatRun.TabIndex = 20;
            this.LblRepeatRun.Text = "Количество повторных забегов";
            // 
            // NudRepeatRun
            // 
            this.NudRepeatRun.Location = new System.Drawing.Point(160, 341);
            this.NudRepeatRun.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudRepeatRun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudRepeatRun.Name = "NudRepeatRun";
            this.NudRepeatRun.Size = new System.Drawing.Size(120, 20);
            this.NudRepeatRun.TabIndex = 19;
            this.NudRepeatRun.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LblMaxDistance
            // 
            this.LblMaxDistance.Location = new System.Drawing.Point(6, 276);
            this.LblMaxDistance.Name = "LblMaxDistance";
            this.LblMaxDistance.Size = new System.Drawing.Size(118, 47);
            this.LblMaxDistance.TabIndex = 18;
            this.LblMaxDistance.Text = "Наибольшее расстояние между вершинами";
            // 
            // NudMaxDistance
            // 
            this.NudMaxDistance.Location = new System.Drawing.Point(160, 276);
            this.NudMaxDistance.Maximum = new decimal(new int[] {
            10000,
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
            this.NudMaxDistance.TabIndex = 17;
            this.NudMaxDistance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // NudDistancePower
            // 
            this.NudDistancePower.DecimalPlaces = 3;
            this.NudDistancePower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NudDistancePower.Location = new System.Drawing.Point(160, 218);
            this.NudDistancePower.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudDistancePower.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NudDistancePower.Name = "NudDistancePower";
            this.NudDistancePower.Size = new System.Drawing.Size(120, 20);
            this.NudDistancePower.TabIndex = 16;
            this.NudDistancePower.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LblDistancePower
            // 
            this.LblDistancePower.Location = new System.Drawing.Point(6, 218);
            this.LblDistancePower.Name = "LblDistancePower";
            this.LblDistancePower.Size = new System.Drawing.Size(118, 47);
            this.LblDistancePower.TabIndex = 15;
            this.LblDistancePower.Text = "Степень влияния обратного расстояния";
            // 
            // NudPheromonePower
            // 
            this.NudPheromonePower.DecimalPlaces = 3;
            this.NudPheromonePower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NudPheromonePower.Location = new System.Drawing.Point(160, 185);
            this.NudPheromonePower.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudPheromonePower.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NudPheromonePower.Name = "NudPheromonePower";
            this.NudPheromonePower.Size = new System.Drawing.Size(120, 20);
            this.NudPheromonePower.TabIndex = 14;
            this.NudPheromonePower.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BtnFindPath
            // 
            this.BtnFindPath.Location = new System.Drawing.Point(160, 405);
            this.BtnFindPath.Name = "BtnFindPath";
            this.BtnFindPath.Size = new System.Drawing.Size(120, 51);
            this.BtnFindPath.TabIndex = 13;
            this.BtnFindPath.Text = "Найти кратчайший путь";
            this.BtnFindPath.UseVisualStyleBackColor = true;
            this.BtnFindPath.Click += new System.EventHandler(this.BtnFindPath_Click);
            // 
            // LblPheromonePower
            // 
            this.LblPheromonePower.Location = new System.Drawing.Point(6, 185);
            this.LblPheromonePower.Name = "LblPheromonePower";
            this.LblPheromonePower.Size = new System.Drawing.Size(136, 33);
            this.LblPheromonePower.TabIndex = 9;
            this.LblPheromonePower.Text = "Степень влияния феромонов";
            // 
            // LblAttractive
            // 
            this.LblAttractive.Location = new System.Drawing.Point(6, 136);
            this.LblAttractive.Name = "LblAttractive";
            this.LblAttractive.Size = new System.Drawing.Size(136, 49);
            this.LblAttractive.TabIndex = 8;
            this.LblAttractive.Text = "Константа \"привлекательности\" пути";
            // 
            // LblEsporation
            // 
            this.LblEsporation.Location = new System.Drawing.Point(6, 103);
            this.LblEsporation.Name = "LblEsporation";
            this.LblEsporation.Size = new System.Drawing.Size(118, 27);
            this.LblEsporation.TabIndex = 7;
            this.LblEsporation.Text = "Коэффициент испарения феромонов";
            // 
            // LblVertexCount
            // 
            this.LblVertexCount.AutoSize = true;
            this.LblVertexCount.Location = new System.Drawing.Point(6, 58);
            this.LblVertexCount.Name = "LblVertexCount";
            this.LblVertexCount.Size = new System.Drawing.Size(107, 13);
            this.LblVertexCount.TabIndex = 6;
            this.LblVertexCount.Text = "Количество вершин";
            // 
            // LblAntsCount
            // 
            this.LblAntsCount.AutoSize = true;
            this.LblAntsCount.Location = new System.Drawing.Point(6, 32);
            this.LblAntsCount.Name = "LblAntsCount";
            this.LblAntsCount.Size = new System.Drawing.Size(118, 13);
            this.LblAntsCount.TabIndex = 5;
            this.LblAntsCount.Text = "Количество муравьев";
            // 
            // NudAttractive
            // 
            this.NudAttractive.Location = new System.Drawing.Point(160, 136);
            this.NudAttractive.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAttractive.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NudAttractive.Name = "NudAttractive";
            this.NudAttractive.Size = new System.Drawing.Size(120, 20);
            this.NudAttractive.TabIndex = 3;
            this.NudAttractive.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NudEsporation
            // 
            this.NudEsporation.DecimalPlaces = 3;
            this.NudEsporation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NudEsporation.Location = new System.Drawing.Point(160, 103);
            this.NudEsporation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudEsporation.Name = "NudEsporation";
            this.NudEsporation.Size = new System.Drawing.Size(120, 20);
            this.NudEsporation.TabIndex = 2;
            this.NudEsporation.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // NudVertexCount
            // 
            this.NudVertexCount.Location = new System.Drawing.Point(160, 58);
            this.NudVertexCount.Maximum = new decimal(new int[] {
            200,
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
            this.NudVertexCount.TabIndex = 1;
            this.NudVertexCount.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // NudAntsCount
            // 
            this.NudAntsCount.Location = new System.Drawing.Point(160, 32);
            this.NudAntsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAntsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAntsCount.Name = "NudAntsCount";
            this.NudAntsCount.Size = new System.Drawing.Size(120, 20);
            this.NudAntsCount.TabIndex = 0;
            this.NudAntsCount.Value = new decimal(new int[] {
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
            this.GbxLog.Size = new System.Drawing.Size(675, 462);
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
            this.TbxLog.Size = new System.Drawing.Size(663, 430);
            this.TbxLog.TabIndex = 0;
            // 
            // FmAnts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 482);
            this.Controls.Add(this.GbxLog);
            this.Controls.Add(this.GbxSetting);
            this.Name = "FmAnts";
            this.Text = "Муравьиный алгоритм";
            this.GbxSetting.ResumeLayout(false);
            this.GbxSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRepeatRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDistancePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPheromonePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAttractive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEsporation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVertexCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAntsCount)).EndInit();
            this.GbxLog.ResumeLayout(false);
            this.GbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxSetting;
        private System.Windows.Forms.Button BtnFindPath;
        private System.Windows.Forms.Label LblPheromonePower;
        private System.Windows.Forms.Label LblAttractive;
        private System.Windows.Forms.Label LblEsporation;
        private System.Windows.Forms.Label LblVertexCount;
        private System.Windows.Forms.Label LblAntsCount;
        private System.Windows.Forms.NumericUpDown NudAttractive;
        private System.Windows.Forms.NumericUpDown NudEsporation;
        private System.Windows.Forms.NumericUpDown NudVertexCount;
        private System.Windows.Forms.NumericUpDown NudAntsCount;
        private System.Windows.Forms.GroupBox GbxLog;
        private System.Windows.Forms.TextBox TbxLog;
        private System.Windows.Forms.NumericUpDown NudPheromonePower;
        private System.Windows.Forms.Label LblMaxDistance;
        private System.Windows.Forms.NumericUpDown NudMaxDistance;
        private System.Windows.Forms.NumericUpDown NudDistancePower;
        private System.Windows.Forms.Label LblDistancePower;
        private System.Windows.Forms.Label LblRepeatRun;
        private System.Windows.Forms.NumericUpDown NudRepeatRun;
    }
}

