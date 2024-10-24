namespace ソケット通信
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_Port = new System.Windows.Forms.TextBox();
            this.lbl_IPAddress = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_ReceivedMsg = new System.Windows.Forms.Label();
            this.txb_IPAddress = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_ConnectionStatus = new System.Windows.Forms.Label();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.lst_ReceivedMsg = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNextCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Port
            // 
            this.txb_Port.BackColor = System.Drawing.Color.Beige;
            this.txb_Port.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_Port.Location = new System.Drawing.Point(122, 64);
            this.txb_Port.Name = "txb_Port";
            this.txb_Port.Size = new System.Drawing.Size(184, 22);
            this.txb_Port.TabIndex = 6;
            this.txb_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Port.TextChanged += new System.EventHandler(this.Txb_Port_TextChanged);
            this.txb_Port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb_Port_KeyDown);
            // 
            // lbl_IPAddress
            // 
            this.lbl_IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_IPAddress.Location = new System.Drawing.Point(16, 16);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(92, 30);
            this.lbl_IPAddress.TabIndex = 0;
            this.lbl_IPAddress.Text = "IPアドレス";
            this.lbl_IPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Port
            // 
            this.lbl_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Port.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Port.Location = new System.Drawing.Point(16, 60);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(92, 30);
            this.lbl_Port.TabIndex = 1;
            this.lbl_Port.Text = "ポート";
            this.lbl_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Message
            // 
            this.lbl_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Message.Location = new System.Drawing.Point(16, 145);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(92, 30);
            this.lbl_Message.TabIndex = 2;
            this.lbl_Message.Text = "送信文字列";
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ReceivedMsg
            // 
            this.lbl_ReceivedMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReceivedMsg.Location = new System.Drawing.Point(16, 232);
            this.lbl_ReceivedMsg.Name = "lbl_ReceivedMsg";
            this.lbl_ReceivedMsg.Size = new System.Drawing.Size(92, 30);
            this.lbl_ReceivedMsg.TabIndex = 4;
            this.lbl_ReceivedMsg.Text = "受信文字列";
            this.lbl_ReceivedMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_IPAddress
            // 
            this.txb_IPAddress.BackColor = System.Drawing.Color.Beige;
            this.txb_IPAddress.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_IPAddress.Location = new System.Drawing.Point(122, 20);
            this.txb_IPAddress.Name = "txb_IPAddress";
            this.txb_IPAddress.Size = new System.Drawing.Size(184, 22);
            this.txb_IPAddress.TabIndex = 5;
            this.txb_IPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_IPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txb_IPAddress_KeyDown);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Connect.Location = new System.Drawing.Point(321, 16);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(44, 74);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "接続";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // lbl_ConnectionStatus
            // 
            this.lbl_ConnectionStatus.Location = new System.Drawing.Point(16, 107);
            this.lbl_ConnectionStatus.Name = "lbl_ConnectionStatus";
            this.lbl_ConnectionStatus.Size = new System.Drawing.Size(349, 30);
            this.lbl_ConnectionStatus.TabIndex = 8;
            this.lbl_ConnectionStatus.Text = "------------------------  未接続  ------------------------";
            this.lbl_ConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_Message
            // 
            this.txb_Message.BackColor = System.Drawing.Color.Beige;
            this.txb_Message.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_Message.Location = new System.Drawing.Point(122, 149);
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(243, 22);
            this.txb_Message.TabIndex = 9;
            this.txb_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_SendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendMessage.Location = new System.Drawing.Point(122, 179);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(91, 34);
            this.btn_SendMessage.TabIndex = 10;
            this.btn_SendMessage.Text = "送信";
            this.btn_SendMessage.UseVisualStyleBackColor = false;
            this.btn_SendMessage.Click += new System.EventHandler(this.Btn_SendMessage_Click);
            // 
            // lst_ReceivedMsg
            // 
            this.lst_ReceivedMsg.BackColor = System.Drawing.Color.Beige;
            this.lst_ReceivedMsg.FormattingEnabled = true;
            this.lst_ReceivedMsg.ItemHeight = 12;
            this.lst_ReceivedMsg.Location = new System.Drawing.Point(122, 232);
            this.lst_ReceivedMsg.Name = "lst_ReceivedMsg";
            this.lst_ReceivedMsg.ScrollAlwaysVisible = true;
            this.lst_ReceivedMsg.Size = new System.Drawing.Size(243, 148);
            this.lst_ReceivedMsg.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(122, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "アプリ起動";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(274, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "アプリ停止";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNextCommand
            // 
            this.btnNextCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNextCommand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCommand.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNextCommand.Location = new System.Drawing.Point(274, 179);
            this.btnNextCommand.Name = "btnNextCommand";
            this.btnNextCommand.Size = new System.Drawing.Size(91, 34);
            this.btnNextCommand.TabIndex = 14;
            this.btnNextCommand.Text = " >>";
            this.btnNextCommand.UseVisualStyleBackColor = false;
            this.btnNextCommand.Click += new System.EventHandler(this.btnNextCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(380, 437);
            this.Controls.Add(this.btnNextCommand);
            this.Controls.Add(this.lbl_ReceivedMsg);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_IPAddress);
            this.Controls.Add(this.txb_Port);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.txb_IPAddress);
            this.Controls.Add(this.lst_ReceivedMsg);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.lbl_ConnectionStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PLC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_IPAddress;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_ReceivedMsg;
        private System.Windows.Forms.TextBox txb_IPAddress;
        private System.Windows.Forms.TextBox txb_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_ConnectionStatus;
        private System.Windows.Forms.TextBox txb_Message;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.ListBox lst_ReceivedMsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNextCommand;
    }
}

