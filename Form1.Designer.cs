

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxBoardInText
            // 
            this.tbxBoardInText.Location = new System.Drawing.Point(226, 12);
            this.tbxBoardInText.Multiline = true;
            this.tbxBoardInText.Name = "tbxBoardInText";
            this.tbxBoardInText.Size = new System.Drawing.Size(329, 208);
            this.tbxBoardInText.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 259);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "пересчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // dgvBoardTable
            // 
            this.dgvBoardTable.AllowUserToResizeColumns = false;
            this.dgvBoardTable.AllowUserToResizeRows = false;
            this.dgvBoardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoardTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBoardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoardTable.ColumnHeadersVisible = false;
            this.dgvBoardTable.Location = new System.Drawing.Point(12, 12);
            this.dgvBoardTable.MultiSelect = false;
            this.dgvBoardTable.Name = "dgvBoardTable";
            this.dgvBoardTable.ReadOnly = true;
            this.dgvBoardTable.RowHeadersVisible = false;
            this.dgvBoardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBoardTable.Size = new System.Drawing.Size(208, 208);
            this.dgvBoardTable.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBoardTable);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbxBoardInText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBoardInText;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvBoardTable;
    }
}

