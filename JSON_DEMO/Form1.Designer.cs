namespace JSON_DEMO
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtTWD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(323, 70);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "序列化";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(323, 121);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(75, 23);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "反序列化";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(248, 248);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(75, 23);
            this.btnWeb.TabIndex = 2;
            this.btnWeb.Text = "GO";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(104, 207);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(100, 22);
            this.txtUSD.TabIndex = 3;
            // 
            // txtTWD
            // 
            this.txtTWD.Location = new System.Drawing.Point(356, 209);
            this.txtTWD.Name = "txtTWD";
            this.txtTWD.ReadOnly = true;
            this.txtTWD.Size = new System.Drawing.Size(100, 22);
            this.txtTWD.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTWD);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtTWD;
    }
}

