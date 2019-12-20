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
            this.BtnLearnNet = new System.Windows.Forms.Button();
            this.BtnStartNet = new System.Windows.Forms.Button();
            this.BtnToVector = new System.Windows.Forms.Button();
            this.BtnClearDraw = new System.Windows.Forms.Button();
            this.RbnField15 = new System.Windows.Forms.RadioButton();
            this.RbnField8 = new System.Windows.Forms.RadioButton();
            this.RbnField3 = new System.Windows.Forms.RadioButton();
            this.DgvDraw = new System.Windows.Forms.DataGridView();
            this.TbxInputVector = new System.Windows.Forms.TextBox();
            this.GbxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxDraw
            // 
            this.GbxDraw.Controls.Add(this.BtnLearnNet);
            this.GbxDraw.Controls.Add(this.BtnStartNet);
            this.GbxDraw.Controls.Add(this.BtnToVector);
            this.GbxDraw.Controls.Add(this.BtnClearDraw);
            this.GbxDraw.Controls.Add(this.RbnField15);
            this.GbxDraw.Controls.Add(this.RbnField8);
            this.GbxDraw.Controls.Add(this.RbnField3);
            this.GbxDraw.Controls.Add(this.DgvDraw);
            this.GbxDraw.Location = new System.Drawing.Point(12, 12);
            this.GbxDraw.Name = "GbxDraw";
            this.GbxDraw.Size = new System.Drawing.Size(369, 490);
            this.GbxDraw.TabIndex = 0;
            this.GbxDraw.TabStop = false;
            this.GbxDraw.Text = "Панель рисования";
            // 
            // BtnLearnNet
            // 
            this.BtnLearnNet.Location = new System.Drawing.Point(105, 433);
            this.BtnLearnNet.Name = "BtnLearnNet";
            this.BtnLearnNet.Size = new System.Drawing.Size(109, 48);
            this.BtnLearnNet.TabIndex = 7;
            this.BtnLearnNet.Text = "Обучить сеть";
            this.BtnLearnNet.UseVisualStyleBackColor = true;
            this.BtnLearnNet.Click += new System.EventHandler(this.BtnLearnNet_Click);
            // 
            // BtnStartNet
            // 
            this.BtnStartNet.Location = new System.Drawing.Point(254, 436);
            this.BtnStartNet.Name = "BtnStartNet";
            this.BtnStartNet.Size = new System.Drawing.Size(109, 48);
            this.BtnStartNet.TabIndex = 6;
            this.BtnStartNet.Text = "Запустить сеть";
            this.BtnStartNet.UseVisualStyleBackColor = true;
            this.BtnStartNet.Click += new System.EventHandler(this.BtnStartNet_Click);
            // 
            // BtnToVector
            // 
            this.BtnToVector.Location = new System.Drawing.Point(254, 379);
            this.BtnToVector.Name = "BtnToVector";
            this.BtnToVector.Size = new System.Drawing.Size(109, 48);
            this.BtnToVector.TabIndex = 5;
            this.BtnToVector.Text = "Получить вектор";
            this.BtnToVector.UseVisualStyleBackColor = true;
            this.BtnToVector.Click += new System.EventHandler(this.BtnToVector_Click);
            // 
            // BtnClearDraw
            // 
            this.BtnClearDraw.Location = new System.Drawing.Point(105, 379);
            this.BtnClearDraw.Name = "BtnClearDraw";
            this.BtnClearDraw.Size = new System.Drawing.Size(109, 48);
            this.BtnClearDraw.TabIndex = 4;
            this.BtnClearDraw.Text = "Очистить все";
            this.BtnClearDraw.UseVisualStyleBackColor = true;
            this.BtnClearDraw.Click += new System.EventHandler(this.BtnClearDraw_Click);
            // 
            // RbnField15
            // 
            this.RbnField15.AutoSize = true;
            this.RbnField15.Location = new System.Drawing.Point(6, 410);
            this.RbnField15.Name = "RbnField15";
            this.RbnField15.Size = new System.Drawing.Size(83, 17);
            this.RbnField15.TabIndex = 3;
            this.RbnField15.TabStop = true;
            this.RbnField15.Text = "Поле 15х15";
            this.RbnField15.UseVisualStyleBackColor = true;
            this.RbnField15.CheckedChanged += new System.EventHandler(this.RbnField15_CheckedChanged);
            // 
            // RbnField8
            // 
            this.RbnField8.AutoSize = true;
            this.RbnField8.Location = new System.Drawing.Point(6, 387);
            this.RbnField8.Name = "RbnField8";
            this.RbnField8.Size = new System.Drawing.Size(71, 17);
            this.RbnField8.TabIndex = 2;
            this.RbnField8.TabStop = true;
            this.RbnField8.Text = "Поле 8х8";
            this.RbnField8.UseVisualStyleBackColor = true;
            this.RbnField8.CheckedChanged += new System.EventHandler(this.RbnField8_CheckedChanged);
            // 
            // RbnField3
            // 
            this.RbnField3.AutoSize = true;
            this.RbnField3.Location = new System.Drawing.Point(6, 364);
            this.RbnField3.Name = "RbnField3";
            this.RbnField3.Size = new System.Drawing.Size(71, 17);
            this.RbnField3.TabIndex = 1;
            this.RbnField3.TabStop = true;
            this.RbnField3.Text = "Поле 3х3";
            this.RbnField3.UseVisualStyleBackColor = true;
            this.RbnField3.CheckedChanged += new System.EventHandler(this.RbnField3_CheckedChanged);
            // 
            // DgvDraw
            // 
            this.DgvDraw.AllowUserToAddRows = false;
            this.DgvDraw.AllowUserToDeleteRows = false;
            this.DgvDraw.AllowUserToResizeColumns = false;
            this.DgvDraw.AllowUserToResizeRows = false;
            this.DgvDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDraw.ColumnHeadersVisible = false;
            this.DgvDraw.Location = new System.Drawing.Point(0, 19);
            this.DgvDraw.MultiSelect = false;
            this.DgvDraw.Name = "DgvDraw";
            this.DgvDraw.ReadOnly = true;
            this.DgvDraw.RowHeadersVisible = false;
            this.DgvDraw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvDraw.Size = new System.Drawing.Size(363, 339);
            this.DgvDraw.TabIndex = 0;
            this.DgvDraw.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDraw_CellMouseDown);
            this.DgvDraw.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDraw_CellMouseMove);
            // 
            // TbxInputVector
            // 
            this.TbxInputVector.Location = new System.Drawing.Point(400, 31);
            this.TbxInputVector.Multiline = true;
            this.TbxInputVector.Name = "TbxInputVector";
            this.TbxInputVector.ReadOnly = true;
            this.TbxInputVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxInputVector.Size = new System.Drawing.Size(388, 415);
            this.TbxInputVector.TabIndex = 1;
            // 
            // FmSimpleNeuroNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 529);
            this.Controls.Add(this.TbxInputVector);
            this.Controls.Add(this.GbxDraw);
            this.Name = "FmSimpleNeuroNet";
            this.Text = "Простая нейро-сеть";
            this.Shown += new System.EventHandler(this.FmSimpleNeuroNet_Shown);
            this.GbxDraw.ResumeLayout(false);
            this.GbxDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDraw;
        private System.Windows.Forms.DataGridView DgvDraw;
        private System.Windows.Forms.RadioButton RbnField15;
        private System.Windows.Forms.RadioButton RbnField8;
        private System.Windows.Forms.RadioButton RbnField3;
        private System.Windows.Forms.Button BtnClearDraw;
        private System.Windows.Forms.Button BtnToVector;
        private System.Windows.Forms.TextBox TbxInputVector;
        private System.Windows.Forms.Button BtnStartNet;
        private System.Windows.Forms.Button BtnLearnNet;
    }
}

