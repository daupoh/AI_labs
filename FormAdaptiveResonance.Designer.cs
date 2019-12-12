namespace wf_AI_lab2
{
    partial class FormAdaptiveResonance
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
            this.GbSigns = new System.Windows.Forms.GroupBox();
            this.BtnAddRandPrototype = new System.Windows.Forms.Button();
            this.BtnAddRandSign = new System.Windows.Forms.Button();
            this.BtnAddPrototype = new System.Windows.Forms.Button();
            this.CbxPrototypes = new System.Windows.Forms.ComboBox();
            this.LblVectorPrototypes = new System.Windows.Forms.Label();
            this.BtnToAdd = new System.Windows.Forms.Button();
            this.BtnDeleteSign = new System.Windows.Forms.Button();
            this.BtnSaveVector = new System.Windows.Forms.Button();
            this.CbxSigns = new System.Windows.Forms.ComboBox();
            this.LblListSigns = new System.Windows.Forms.Label();
            this.BtnAddSign = new System.Windows.Forms.Button();
            this.BtnAllSignsOn = new System.Windows.Forms.Button();
            this.BtnAllSignsOff = new System.Windows.Forms.Button();
            this.ClbSigns = new System.Windows.Forms.CheckedListBox();
            this.gbClusters = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.CbxClusterSigns = new System.Windows.Forms.ComboBox();
            this.LblClusterSigns = new System.Windows.Forms.Label();
            this.CbxClusters = new System.Windows.Forms.ComboBox();
            this.LblClusters = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.BtnStartResonance = new System.Windows.Forms.Button();
            this.btnCancelSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblVectorLength = new System.Windows.Forms.Label();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblMaxClusters = new System.Windows.Forms.Label();
            this.nudAttention = new System.Windows.Forms.NumericUpDown();
            this.nudVectorLength = new System.Windows.Forms.NumericUpDown();
            this.nudBeta = new System.Windows.Forms.NumericUpDown();
            this.nudMaxClusters = new System.Windows.Forms.NumericUpDown();
            this.nicAddVectorSucces = new System.Windows.Forms.NotifyIcon(this.components);
            this.GbLog = new System.Windows.Forms.GroupBox();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.GbSigns.SuspendLayout();
            this.gbClusters.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttention)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxClusters)).BeginInit();
            this.GbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSigns
            // 
            this.GbSigns.Controls.Add(this.BtnAddRandPrototype);
            this.GbSigns.Controls.Add(this.BtnAddRandSign);
            this.GbSigns.Controls.Add(this.BtnAddPrototype);
            this.GbSigns.Controls.Add(this.CbxPrototypes);
            this.GbSigns.Controls.Add(this.LblVectorPrototypes);
            this.GbSigns.Controls.Add(this.BtnToAdd);
            this.GbSigns.Controls.Add(this.BtnDeleteSign);
            this.GbSigns.Controls.Add(this.BtnSaveVector);
            this.GbSigns.Controls.Add(this.CbxSigns);
            this.GbSigns.Controls.Add(this.LblListSigns);
            this.GbSigns.Controls.Add(this.BtnAddSign);
            this.GbSigns.Controls.Add(this.BtnAllSignsOn);
            this.GbSigns.Controls.Add(this.BtnAllSignsOff);
            this.GbSigns.Controls.Add(this.ClbSigns);
            this.GbSigns.Location = new System.Drawing.Point(12, 12);
            this.GbSigns.Name = "GbSigns";
            this.GbSigns.Size = new System.Drawing.Size(304, 519);
            this.GbSigns.TabIndex = 0;
            this.GbSigns.TabStop = false;
            this.GbSigns.Text = "Признаки и прототипы";
            // 
            // BtnAddRandPrototype
            // 
            this.BtnAddRandPrototype.Location = new System.Drawing.Point(71, 145);
            this.BtnAddRandPrototype.Name = "BtnAddRandPrototype";
            this.BtnAddRandPrototype.Size = new System.Drawing.Size(129, 34);
            this.BtnAddRandPrototype.TabIndex = 15;
            this.BtnAddRandPrototype.Text = "Добавить случайный вектор";
            this.BtnAddRandPrototype.UseVisualStyleBackColor = true;
            this.BtnAddRandPrototype.Click += new System.EventHandler(this.BtnAddRandPrototype_Click);
            // 
            // BtnAddRandSign
            // 
            this.BtnAddRandSign.Location = new System.Drawing.Point(71, 63);
            this.BtnAddRandSign.Name = "BtnAddRandSign";
            this.BtnAddRandSign.Size = new System.Drawing.Size(129, 34);
            this.BtnAddRandSign.TabIndex = 14;
            this.BtnAddRandSign.Text = "Добавить случайный вектор";
            this.BtnAddRandSign.UseVisualStyleBackColor = true;
            this.BtnAddRandSign.Click += new System.EventHandler(this.BtnRandSign_Click);
            // 
            // BtnAddPrototype
            // 
            this.BtnAddPrototype.Location = new System.Drawing.Point(206, 145);
            this.BtnAddPrototype.Name = "BtnAddPrototype";
            this.BtnAddPrototype.Size = new System.Drawing.Size(92, 34);
            this.BtnAddPrototype.TabIndex = 13;
            this.BtnAddPrototype.Text = "Добавить вектор";
            this.BtnAddPrototype.UseVisualStyleBackColor = true;
            this.BtnAddPrototype.Click += new System.EventHandler(this.BtnAddPrototype_Click);
            // 
            // CbxPrototypes
            // 
            this.CbxPrototypes.FormattingEnabled = true;
            this.CbxPrototypes.Location = new System.Drawing.Point(122, 118);
            this.CbxPrototypes.Name = "CbxPrototypes";
            this.CbxPrototypes.Size = new System.Drawing.Size(176, 21);
            this.CbxPrototypes.TabIndex = 12;
            this.CbxPrototypes.SelectedIndexChanged += new System.EventHandler(this.CbxPrototypes_SelectedIndexChanged);
            // 
            // LblVectorPrototypes
            // 
            this.LblVectorPrototypes.Location = new System.Drawing.Point(6, 118);
            this.LblVectorPrototypes.Name = "LblVectorPrototypes";
            this.LblVectorPrototypes.Size = new System.Drawing.Size(127, 33);
            this.LblVectorPrototypes.TabIndex = 11;
            this.LblVectorPrototypes.Text = "Список добавленных векторов прототипов";
            // 
            // BtnToAdd
            // 
            this.BtnToAdd.Enabled = false;
            this.BtnToAdd.Location = new System.Drawing.Point(6, 188);
            this.BtnToAdd.Name = "BtnToAdd";
            this.BtnToAdd.Size = new System.Drawing.Size(131, 34);
            this.BtnToAdd.TabIndex = 10;
            this.BtnToAdd.Text = "Вернуться к добавлению";
            this.BtnToAdd.UseVisualStyleBackColor = true;
            this.BtnToAdd.Click += new System.EventHandler(this.BtnToAdd_Click);
            // 
            // BtnDeleteSign
            // 
            this.BtnDeleteSign.Enabled = false;
            this.BtnDeleteSign.Location = new System.Drawing.Point(167, 188);
            this.BtnDeleteSign.Name = "BtnDeleteSign";
            this.BtnDeleteSign.Size = new System.Drawing.Size(131, 34);
            this.BtnDeleteSign.TabIndex = 9;
            this.BtnDeleteSign.Text = "Удалить вектор";
            this.BtnDeleteSign.UseVisualStyleBackColor = true;
            this.BtnDeleteSign.Click += new System.EventHandler(this.BtnDeleteSign_Click);
            // 
            // BtnSaveVector
            // 
            this.BtnSaveVector.Enabled = false;
            this.BtnSaveVector.Location = new System.Drawing.Point(206, 479);
            this.BtnSaveVector.Name = "BtnSaveVector";
            this.BtnSaveVector.Size = new System.Drawing.Size(92, 34);
            this.BtnSaveVector.TabIndex = 8;
            this.BtnSaveVector.Text = "Сохранить изменения";
            this.BtnSaveVector.UseVisualStyleBackColor = true;
            this.BtnSaveVector.Click += new System.EventHandler(this.BtnSaveVector_Click);
            // 
            // CbxSigns
            // 
            this.CbxSigns.FormattingEnabled = true;
            this.CbxSigns.Location = new System.Drawing.Point(122, 36);
            this.CbxSigns.Name = "CbxSigns";
            this.CbxSigns.Size = new System.Drawing.Size(176, 21);
            this.CbxSigns.TabIndex = 7;
            this.CbxSigns.SelectedIndexChanged += new System.EventHandler(this.CbxSigns_SelectedIndexChanged);
            // 
            // LblListSigns
            // 
            this.LblListSigns.Location = new System.Drawing.Point(6, 33);
            this.LblListSigns.Name = "LblListSigns";
            this.LblListSigns.Size = new System.Drawing.Size(127, 33);
            this.LblListSigns.TabIndex = 6;
            this.LblListSigns.Text = "Список добавленных векторов признаков";
            // 
            // BtnAddSign
            // 
            this.BtnAddSign.Location = new System.Drawing.Point(206, 63);
            this.BtnAddSign.Name = "BtnAddSign";
            this.BtnAddSign.Size = new System.Drawing.Size(92, 34);
            this.BtnAddSign.TabIndex = 3;
            this.BtnAddSign.Text = "Добавить вектор";
            this.BtnAddSign.UseVisualStyleBackColor = true;
            this.BtnAddSign.Click += new System.EventHandler(this.BtnAddSign_Click);
            // 
            // BtnAllSignsOn
            // 
            this.BtnAllSignsOn.Location = new System.Drawing.Point(6, 479);
            this.BtnAllSignsOn.Name = "BtnAllSignsOn";
            this.BtnAllSignsOn.Size = new System.Drawing.Size(92, 34);
            this.BtnAllSignsOn.TabIndex = 2;
            this.BtnAllSignsOn.Text = "Установить все";
            this.BtnAllSignsOn.UseVisualStyleBackColor = true;
            this.BtnAllSignsOn.Click += new System.EventHandler(this.BtnAllSignsOn_Click);
            // 
            // BtnAllSignsOff
            // 
            this.BtnAllSignsOff.Location = new System.Drawing.Point(104, 479);
            this.BtnAllSignsOff.Name = "BtnAllSignsOff";
            this.BtnAllSignsOff.Size = new System.Drawing.Size(92, 34);
            this.BtnAllSignsOff.TabIndex = 1;
            this.BtnAllSignsOff.Text = "Снять все";
            this.BtnAllSignsOff.UseVisualStyleBackColor = true;
            this.BtnAllSignsOff.Click += new System.EventHandler(this.BtnAllSignsOff_Click);
            // 
            // ClbSigns
            // 
            this.ClbSigns.FormattingEnabled = true;
            this.ClbSigns.Location = new System.Drawing.Point(6, 228);
            this.ClbSigns.Name = "ClbSigns";
            this.ClbSigns.Size = new System.Drawing.Size(292, 244);
            this.ClbSigns.TabIndex = 0;
            // 
            // gbClusters
            // 
            this.gbClusters.Controls.Add(this.BtnReset);
            this.gbClusters.Controls.Add(this.CbxClusterSigns);
            this.gbClusters.Controls.Add(this.LblClusterSigns);
            this.gbClusters.Controls.Add(this.CbxClusters);
            this.gbClusters.Controls.Add(this.LblClusters);
            this.gbClusters.Enabled = false;
            this.gbClusters.Location = new System.Drawing.Point(322, 253);
            this.gbClusters.Name = "gbClusters";
            this.gbClusters.Size = new System.Drawing.Size(312, 148);
            this.gbClusters.TabIndex = 2;
            this.gbClusters.TabStop = false;
            this.gbClusters.Text = "Кластеры";
            // 
            // BtnReset
            // 
            this.BtnReset.Enabled = false;
            this.BtnReset.Location = new System.Drawing.Point(6, 91);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(188, 41);
            this.BtnReset.TabIndex = 12;
            this.BtnReset.Text = "Подготовить новые данные";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // CbxClusterSigns
            // 
            this.CbxClusterSigns.Enabled = false;
            this.CbxClusterSigns.FormattingEnabled = true;
            this.CbxClusterSigns.Location = new System.Drawing.Point(122, 52);
            this.CbxClusterSigns.Name = "CbxClusterSigns";
            this.CbxClusterSigns.Size = new System.Drawing.Size(176, 21);
            this.CbxClusterSigns.TabIndex = 10;
            // 
            // LblClusterSigns
            // 
            this.LblClusterSigns.Location = new System.Drawing.Point(6, 55);
            this.LblClusterSigns.Name = "LblClusterSigns";
            this.LblClusterSigns.Size = new System.Drawing.Size(127, 33);
            this.LblClusterSigns.TabIndex = 9;
            this.LblClusterSigns.Text = "Список признаков кластера";
            // 
            // CbxClusters
            // 
            this.CbxClusters.FormattingEnabled = true;
            this.CbxClusters.Location = new System.Drawing.Point(122, 19);
            this.CbxClusters.Name = "CbxClusters";
            this.CbxClusters.Size = new System.Drawing.Size(176, 21);
            this.CbxClusters.TabIndex = 8;
            this.CbxClusters.SelectedIndexChanged += new System.EventHandler(this.CbxClusters_SelectedIndexChanged);
            // 
            // LblClusters
            // 
            this.LblClusters.Location = new System.Drawing.Point(6, 22);
            this.LblClusters.Name = "LblClusters";
            this.LblClusters.Size = new System.Drawing.Size(127, 33);
            this.LblClusters.TabIndex = 7;
            this.LblClusters.Text = "Список кластеров";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.BtnStartResonance);
            this.gbSettings.Controls.Add(this.btnCancelSettings);
            this.gbSettings.Controls.Add(this.btnSaveSettings);
            this.gbSettings.Controls.Add(this.lblVectorLength);
            this.gbSettings.Controls.Add(this.lblAttention);
            this.gbSettings.Controls.Add(this.lblBeta);
            this.gbSettings.Controls.Add(this.lblMaxClusters);
            this.gbSettings.Controls.Add(this.nudAttention);
            this.gbSettings.Controls.Add(this.nudVectorLength);
            this.gbSettings.Controls.Add(this.nudBeta);
            this.gbSettings.Controls.Add(this.nudMaxClusters);
            this.gbSettings.Location = new System.Drawing.Point(322, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(312, 235);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Настройки алгоритма";
            // 
            // BtnStartResonance
            // 
            this.BtnStartResonance.Enabled = false;
            this.BtnStartResonance.Location = new System.Drawing.Point(6, 188);
            this.BtnStartResonance.Name = "BtnStartResonance";
            this.BtnStartResonance.Size = new System.Drawing.Size(85, 41);
            this.BtnStartResonance.TabIndex = 10;
            this.BtnStartResonance.Text = "Запуск алгоритма";
            this.BtnStartResonance.UseVisualStyleBackColor = true;
            this.BtnStartResonance.Click += new System.EventHandler(this.BtnStartResonance_Click);
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.Enabled = false;
            this.btnCancelSettings.Location = new System.Drawing.Point(213, 188);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(85, 41);
            this.btnCancelSettings.TabIndex = 9;
            this.btnCancelSettings.Text = "Сброс изменений";
            this.btnCancelSettings.UseVisualStyleBackColor = true;
            this.btnCancelSettings.Click += new System.EventHandler(this.BtnCancelSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Enabled = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(109, 188);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(85, 41);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Сохранить настройки";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // lblVectorLength
            // 
            this.lblVectorLength.AutoSize = true;
            this.lblVectorLength.Location = new System.Drawing.Point(6, 38);
            this.lblVectorLength.Name = "lblVectorLength";
            this.lblVectorLength.Size = new System.Drawing.Size(84, 13);
            this.lblVectorLength.TabIndex = 7;
            this.lblVectorLength.Text = "Длина вектора";
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(6, 150);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(145, 13);
            this.lblAttention.TabIndex = 6;
            this.lblAttention.Text = "Параметр внимательности";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(6, 112);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(83, 13);
            this.lblBeta.TabIndex = 5;
            this.lblBeta.Text = "Бета-параметр";
            // 
            // lblMaxClusters
            // 
            this.lblMaxClusters.Location = new System.Drawing.Point(6, 77);
            this.lblMaxClusters.Name = "lblMaxClusters";
            this.lblMaxClusters.Size = new System.Drawing.Size(153, 33);
            this.lblMaxClusters.TabIndex = 4;
            this.lblMaxClusters.Text = "Максимальное количество кластеров";
            // 
            // nudAttention
            // 
            this.nudAttention.DecimalPlaces = 3;
            this.nudAttention.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudAttention.Location = new System.Drawing.Point(203, 148);
            this.nudAttention.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAttention.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudAttention.Name = "nudAttention";
            this.nudAttention.Size = new System.Drawing.Size(95, 20);
            this.nudAttention.TabIndex = 3;
            this.nudAttention.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.nudAttention.ValueChanged += new System.EventHandler(this.NudAttention_ValueChanged);
            // 
            // nudVectorLength
            // 
            this.nudVectorLength.Location = new System.Drawing.Point(203, 31);
            this.nudVectorLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudVectorLength.Name = "nudVectorLength";
            this.nudVectorLength.Size = new System.Drawing.Size(95, 20);
            this.nudVectorLength.TabIndex = 2;
            this.nudVectorLength.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudVectorLength.ValueChanged += new System.EventHandler(this.NudVectorLength_ValueChanged);
            // 
            // nudBeta
            // 
            this.nudBeta.Location = new System.Drawing.Point(203, 110);
            this.nudBeta.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBeta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBeta.Name = "nudBeta";
            this.nudBeta.Size = new System.Drawing.Size(95, 20);
            this.nudBeta.TabIndex = 1;
            this.nudBeta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBeta.ValueChanged += new System.EventHandler(this.NudBeta_ValueChanged);
            // 
            // nudMaxClusters
            // 
            this.nudMaxClusters.Location = new System.Drawing.Point(203, 77);
            this.nudMaxClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxClusters.Name = "nudMaxClusters";
            this.nudMaxClusters.Size = new System.Drawing.Size(95, 20);
            this.nudMaxClusters.TabIndex = 0;
            this.nudMaxClusters.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxClusters.ValueChanged += new System.EventHandler(this.NudMaxClusters_ValueChanged);
            // 
            // nicAddVectorSucces
            // 
            this.nicAddVectorSucces.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicAddVectorSucces.Icon = global::wf_AI_lab2.Properties.Resources.droid;
            this.nicAddVectorSucces.Visible = true;
            // 
            // GbLog
            // 
            this.GbLog.Controls.Add(this.TbLog);
            this.GbLog.Location = new System.Drawing.Point(640, 12);
            this.GbLog.Name = "GbLog";
            this.GbLog.Size = new System.Drawing.Size(471, 513);
            this.GbLog.TabIndex = 3;
            this.GbLog.TabStop = false;
            this.GbLog.Text = "Лог алгоритма";
            // 
            // TbLog
            // 
            this.TbLog.Location = new System.Drawing.Point(6, 19);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.ReadOnly = true;
            this.TbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbLog.Size = new System.Drawing.Size(459, 488);
            this.TbLog.TabIndex = 15;
            // 
            // FormAdaptiveResonance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 543);
            this.Controls.Add(this.GbLog);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbClusters);
            this.Controls.Add(this.GbSigns);
            this.Name = "FormAdaptiveResonance";
            this.Text = "Адаптивная резонансная теория";
            this.GbSigns.ResumeLayout(false);
            this.gbClusters.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttention)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxClusters)).EndInit();
            this.GbLog.ResumeLayout(false);
            this.GbLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSigns;
        private System.Windows.Forms.GroupBox gbClusters;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.NumericUpDown nudVectorLength;
        private System.Windows.Forms.NumericUpDown nudBeta;
        private System.Windows.Forms.NumericUpDown nudMaxClusters;
        private System.Windows.Forms.CheckedListBox ClbSigns;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblVectorLength;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblMaxClusters;
        private System.Windows.Forms.NumericUpDown nudAttention;
        private System.Windows.Forms.Button BtnAllSignsOn;
        private System.Windows.Forms.Button BtnAllSignsOff;
        private System.Windows.Forms.Button BtnAddSign;
        private System.Windows.Forms.Button BtnSaveVector;
        private System.Windows.Forms.ComboBox CbxSigns;
        private System.Windows.Forms.Label LblListSigns;
        private System.Windows.Forms.Button BtnDeleteSign;
        private System.Windows.Forms.Button BtnToAdd;
        private System.Windows.Forms.Button BtnAddPrototype;
        private System.Windows.Forms.ComboBox CbxPrototypes;
        private System.Windows.Forms.Label LblVectorPrototypes;
        private System.Windows.Forms.NotifyIcon nicAddVectorSucces;
        private System.Windows.Forms.ComboBox CbxClusterSigns;
        private System.Windows.Forms.Label LblClusterSigns;
        private System.Windows.Forms.ComboBox CbxClusters;
        private System.Windows.Forms.Label LblClusters;
        private System.Windows.Forms.Button BtnStartResonance;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnAddRandSign;
        private System.Windows.Forms.Button BtnAddRandPrototype;
        private System.Windows.Forms.GroupBox GbLog;
        private System.Windows.Forms.TextBox TbLog;
    }
}

