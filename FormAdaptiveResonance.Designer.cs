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
            this.gbSigns = new System.Windows.Forms.GroupBox();
            this.btnDeleteSign = new System.Windows.Forms.Button();
            this.btnSaveVector = new System.Windows.Forms.Button();
            this.cbxSigns = new System.Windows.Forms.ComboBox();
            this.lblListSigns = new System.Windows.Forms.Label();
            this.btnAddSign = new System.Windows.Forms.Button();
            this.btnAllSignsOn = new System.Windows.Forms.Button();
            this.btnAllSignsOff = new System.Windows.Forms.Button();
            this.clbSigns = new System.Windows.Forms.CheckedListBox();
            this.gbPrototypes = new System.Windows.Forms.GroupBox();
            this.gbClusters = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
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
            this.btnToAdd = new System.Windows.Forms.Button();
            this.gbSigns.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttention)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSigns
            // 
            this.gbSigns.Controls.Add(this.btnToAdd);
            this.gbSigns.Controls.Add(this.btnDeleteSign);
            this.gbSigns.Controls.Add(this.btnSaveVector);
            this.gbSigns.Controls.Add(this.cbxSigns);
            this.gbSigns.Controls.Add(this.lblListSigns);
            this.gbSigns.Controls.Add(this.btnAddSign);
            this.gbSigns.Controls.Add(this.btnAllSignsOn);
            this.gbSigns.Controls.Add(this.btnAllSignsOff);
            this.gbSigns.Controls.Add(this.clbSigns);
            this.gbSigns.Location = new System.Drawing.Point(12, 12);
            this.gbSigns.Name = "gbSigns";
            this.gbSigns.Size = new System.Drawing.Size(304, 313);
            this.gbSigns.TabIndex = 0;
            this.gbSigns.TabStop = false;
            this.gbSigns.Text = "Признаки";
            // 
            // btnDeleteSign
            // 
            this.btnDeleteSign.Enabled = false;
            this.btnDeleteSign.Location = new System.Drawing.Point(206, 58);
            this.btnDeleteSign.Name = "btnDeleteSign";
            this.btnDeleteSign.Size = new System.Drawing.Size(92, 34);
            this.btnDeleteSign.TabIndex = 9;
            this.btnDeleteSign.Text = "Удалить вектор";
            this.btnDeleteSign.UseVisualStyleBackColor = true;
            this.btnDeleteSign.Click += new System.EventHandler(this.btnDeleteSign_Click);
            // 
            // btnSaveVector
            // 
            this.btnSaveVector.Enabled = false;
            this.btnSaveVector.Location = new System.Drawing.Point(206, 273);
            this.btnSaveVector.Name = "btnSaveVector";
            this.btnSaveVector.Size = new System.Drawing.Size(92, 34);
            this.btnSaveVector.TabIndex = 8;
            this.btnSaveVector.Text = "Сохранить изменения";
            this.btnSaveVector.UseVisualStyleBackColor = true;
            this.btnSaveVector.Click += new System.EventHandler(this.btnSaveVector_Click);
            // 
            // cbxSigns
            // 
            this.cbxSigns.FormattingEnabled = true;
            this.cbxSigns.Location = new System.Drawing.Point(122, 19);
            this.cbxSigns.Name = "cbxSigns";
            this.cbxSigns.Size = new System.Drawing.Size(176, 21);
            this.cbxSigns.TabIndex = 7;
            this.cbxSigns.SelectedIndexChanged += new System.EventHandler(this.cbxSigns_SelectedIndexChanged);
            // 
            // lblListSigns
            // 
            this.lblListSigns.Location = new System.Drawing.Point(6, 16);
            this.lblListSigns.Name = "lblListSigns";
            this.lblListSigns.Size = new System.Drawing.Size(127, 33);
            this.lblListSigns.TabIndex = 6;
            this.lblListSigns.Text = "Список добавленных признаков";
            // 
            // btnAddSign
            // 
            this.btnAddSign.Location = new System.Drawing.Point(6, 58);
            this.btnAddSign.Name = "btnAddSign";
            this.btnAddSign.Size = new System.Drawing.Size(92, 34);
            this.btnAddSign.TabIndex = 3;
            this.btnAddSign.Text = "Добавить вектор";
            this.btnAddSign.UseVisualStyleBackColor = true;
            this.btnAddSign.Click += new System.EventHandler(this.btnAddSign_Click);
            // 
            // btnAllSignsOn
            // 
            this.btnAllSignsOn.Location = new System.Drawing.Point(6, 273);
            this.btnAllSignsOn.Name = "btnAllSignsOn";
            this.btnAllSignsOn.Size = new System.Drawing.Size(92, 34);
            this.btnAllSignsOn.TabIndex = 2;
            this.btnAllSignsOn.Text = "Установить все";
            this.btnAllSignsOn.UseVisualStyleBackColor = true;
            this.btnAllSignsOn.Click += new System.EventHandler(this.btnAllSignsOn_Click);
            // 
            // btnAllSignsOff
            // 
            this.btnAllSignsOff.Location = new System.Drawing.Point(104, 273);
            this.btnAllSignsOff.Name = "btnAllSignsOff";
            this.btnAllSignsOff.Size = new System.Drawing.Size(92, 34);
            this.btnAllSignsOff.TabIndex = 1;
            this.btnAllSignsOff.Text = "Снять все";
            this.btnAllSignsOff.UseVisualStyleBackColor = true;
            this.btnAllSignsOff.Click += new System.EventHandler(this.btnAllSignsOff_Click);
            // 
            // clbSigns
            // 
            this.clbSigns.FormattingEnabled = true;
            this.clbSigns.Location = new System.Drawing.Point(6, 98);
            this.clbSigns.Name = "clbSigns";
            this.clbSigns.Size = new System.Drawing.Size(292, 169);
            this.clbSigns.TabIndex = 0;
            // 
            // gbPrototypes
            // 
            this.gbPrototypes.Location = new System.Drawing.Point(386, 12);
            this.gbPrototypes.Name = "gbPrototypes";
            this.gbPrototypes.Size = new System.Drawing.Size(254, 313);
            this.gbPrototypes.TabIndex = 1;
            this.gbPrototypes.TabStop = false;
            this.gbPrototypes.Text = "Прототипы";
            // 
            // gbClusters
            // 
            this.gbClusters.Location = new System.Drawing.Point(655, 12);
            this.gbClusters.Name = "gbClusters";
            this.gbClusters.Size = new System.Drawing.Size(272, 313);
            this.gbClusters.TabIndex = 2;
            this.gbClusters.TabStop = false;
            this.gbClusters.Text = "Кластеры";
            // 
            // gbSettings
            // 
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
            this.gbSettings.Location = new System.Drawing.Point(12, 331);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(304, 235);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Настройки алгоритма";
            // 
            // btnCancelSettings
            // 
            this.btnCancelSettings.Enabled = false;
            this.btnCancelSettings.Location = new System.Drawing.Point(171, 190);
            this.btnCancelSettings.Name = "btnCancelSettings";
            this.btnCancelSettings.Size = new System.Drawing.Size(127, 39);
            this.btnCancelSettings.TabIndex = 9;
            this.btnCancelSettings.Text = "Сброс изменений";
            this.btnCancelSettings.UseVisualStyleBackColor = true;
            this.btnCancelSettings.Click += new System.EventHandler(this.btnCancelSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Enabled = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(6, 190);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(127, 39);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Сохранить настройки";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblVectorLength
            // 
            this.lblVectorLength.AutoSize = true;
            this.lblVectorLength.Location = new System.Drawing.Point(6, 78);
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
            this.lblMaxClusters.Location = new System.Drawing.Point(6, 32);
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
            this.nudAttention.ValueChanged += new System.EventHandler(this.nudAttention_ValueChanged);
            // 
            // nudVectorLength
            // 
            this.nudVectorLength.Location = new System.Drawing.Point(203, 71);
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
            this.nudVectorLength.ValueChanged += new System.EventHandler(this.nudVectorLength_ValueChanged);
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
            this.nudBeta.ValueChanged += new System.EventHandler(this.nudBeta_ValueChanged);
            // 
            // nudMaxClusters
            // 
            this.nudMaxClusters.Location = new System.Drawing.Point(203, 32);
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
            this.nudMaxClusters.ValueChanged += new System.EventHandler(this.nudMaxClusters_ValueChanged);
            // 
            // btnToAdd
            // 
            this.btnToAdd.Enabled = false;
            this.btnToAdd.Location = new System.Drawing.Point(108, 58);
            this.btnToAdd.Name = "btnToAdd";
            this.btnToAdd.Size = new System.Drawing.Size(92, 34);
            this.btnToAdd.TabIndex = 10;
            this.btnToAdd.Text = "Вернуться к добавлению";
            this.btnToAdd.UseVisualStyleBackColor = true;
            // 
            // FormAdaptiveResonance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 613);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbClusters);
            this.Controls.Add(this.gbPrototypes);
            this.Controls.Add(this.gbSigns);
            this.Name = "FormAdaptiveResonance";
            this.Text = "Адаптивная резонансная теория";
            this.gbSigns.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttention)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxClusters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSigns;
        private System.Windows.Forms.GroupBox gbPrototypes;
        private System.Windows.Forms.GroupBox gbClusters;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.NumericUpDown nudVectorLength;
        private System.Windows.Forms.NumericUpDown nudBeta;
        private System.Windows.Forms.NumericUpDown nudMaxClusters;
        private System.Windows.Forms.CheckedListBox clbSigns;
        private System.Windows.Forms.Button btnCancelSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblVectorLength;
        private System.Windows.Forms.Label lblAttention;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblMaxClusters;
        private System.Windows.Forms.NumericUpDown nudAttention;
        private System.Windows.Forms.Button btnAllSignsOn;
        private System.Windows.Forms.Button btnAllSignsOff;
        private System.Windows.Forms.Button btnAddSign;
        private System.Windows.Forms.Button btnSaveVector;
        private System.Windows.Forms.ComboBox cbxSigns;
        private System.Windows.Forms.Label lblListSigns;
        private System.Windows.Forms.Button btnDeleteSign;
        private System.Windows.Forms.Button btnToAdd;
    }
}

