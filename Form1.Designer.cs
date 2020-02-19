namespace wf_AI_lab1
{
    partial class FmSemanticNet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSemanticNet));
            this.TbxChat = new System.Windows.Forms.TextBox();
            this.TbxRequest = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxChat
            // 
            this.TbxChat.Location = new System.Drawing.Point(12, 12);
            this.TbxChat.Multiline = true;
            this.TbxChat.Name = "TbxChat";
            this.TbxChat.ReadOnly = true;
            this.TbxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxChat.Size = new System.Drawing.Size(580, 381);
            this.TbxChat.TabIndex = 0;
            this.TbxChat.Text = resources.GetString("TbxChat.Text");
            this.TbxChat.Enter += new System.EventHandler(this.TbxChat_Enter);
            // 
            // TbxRequest
            // 
            this.TbxRequest.Location = new System.Drawing.Point(12, 402);
            this.TbxRequest.Name = "TbxRequest";
            this.TbxRequest.Size = new System.Drawing.Size(450, 20);
            this.TbxRequest.TabIndex = 1;
            this.TbxRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxRequest_KeyDown);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(468, 399);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(124, 23);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Отправить";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // FmSemanticNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbxRequest);
            this.Controls.Add(this.TbxChat);
            this.Name = "FmSemanticNet";
            this.Text = "Фреймы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxChat;
        private System.Windows.Forms.TextBox TbxRequest;
        private System.Windows.Forms.Button BtnSend;
    }
}

