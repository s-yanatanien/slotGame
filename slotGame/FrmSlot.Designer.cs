namespace slotGame
{
    partial class FrmSlot
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(181, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 39);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "スタート";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(12, 317);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(145, 39);
            this.btnStop1.TabIndex = 0;
            this.btnStop1.Text = "ストップ";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(181, 317);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(145, 39);
            this.btnStop2.TabIndex = 0;
            this.btnStop2.Text = "ストップ";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(346, 317);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(145, 39);
            this.btnStop3.TabIndex = 0;
            this.btnStop3.Text = "ストップ";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(181, 195);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(145, 116);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 195);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(145, 116);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(346, 195);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(145, 116);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("BIZ UDPゴシック", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(209, 136);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(90, 27);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "あたり";
            this.lblMsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 462);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmSlot";
            this.Text = "スロット";
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label lblMsg;
    }
}

