
namespace ThreadForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberCounter = new System.Windows.Forms.Label();
            this.singleThreadButton = new System.Windows.Forms.Button();
            this.traditionanlInvokingButton = new System.Windows.Forms.Button();
            this.awaitButton = new System.Windows.Forms.Button();
            this.awaitWithoutCtxSyncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberCounter
            // 
            this.numberCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberCounter.Font = new System.Drawing.Font("Microsoft PhagsPa", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberCounter.Location = new System.Drawing.Point(439, 138);
            this.numberCounter.Name = "numberCounter";
            this.numberCounter.Size = new System.Drawing.Size(489, 239);
            this.numberCounter.TabIndex = 0;
            this.numberCounter.Text = "0";
            this.numberCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singleThreadButton
            // 
            this.singleThreadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.singleThreadButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.singleThreadButton.Location = new System.Drawing.Point(236, 427);
            this.singleThreadButton.Name = "singleThreadButton";
            this.singleThreadButton.Size = new System.Drawing.Size(424, 111);
            this.singleThreadButton.TabIndex = 1;
            this.singleThreadButton.Text = "Single Thread Button";
            this.singleThreadButton.UseVisualStyleBackColor = true;
            this.singleThreadButton.Click += new System.EventHandler(this.CountWithSingleThread);
            // 
            // traditionanlInvokingButton
            // 
            this.traditionanlInvokingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.traditionanlInvokingButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.traditionanlInvokingButton.Location = new System.Drawing.Point(713, 427);
            this.traditionanlInvokingButton.Name = "traditionanlInvokingButton";
            this.traditionanlInvokingButton.Size = new System.Drawing.Size(462, 111);
            this.traditionanlInvokingButton.TabIndex = 2;
            this.traditionanlInvokingButton.Text = "Traditional Invoke Button";
            this.traditionanlInvokingButton.UseVisualStyleBackColor = true;
            this.traditionanlInvokingButton.Click += new System.EventHandler(this.InvokeThread);
            // 
            // awaitButton
            // 
            this.awaitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.awaitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.awaitButton.Location = new System.Drawing.Point(236, 574);
            this.awaitButton.Name = "awaitButton";
            this.awaitButton.Size = new System.Drawing.Size(424, 111);
            this.awaitButton.TabIndex = 3;
            this.awaitButton.Text = "Await Button";
            this.awaitButton.UseVisualStyleBackColor = true;
            this.awaitButton.Click += new System.EventHandler(this.AwaitThread);
            // 
            // awaitWithoutCtxSyncButton
            // 
            this.awaitWithoutCtxSyncButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.awaitWithoutCtxSyncButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.awaitWithoutCtxSyncButton.Location = new System.Drawing.Point(713, 574);
            this.awaitWithoutCtxSyncButton.Name = "awaitWithoutCtxSyncButton";
            this.awaitWithoutCtxSyncButton.Size = new System.Drawing.Size(462, 111);
            this.awaitWithoutCtxSyncButton.TabIndex = 4;
            this.awaitWithoutCtxSyncButton.Text = "Await Button Without Context Sync";
            this.awaitWithoutCtxSyncButton.UseVisualStyleBackColor = true;
            this.awaitWithoutCtxSyncButton.Click += new System.EventHandler(this.AwaitThreadWithoutContextSync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 880);
            this.Controls.Add(this.awaitWithoutCtxSyncButton);
            this.Controls.Add(this.awaitButton);
            this.Controls.Add(this.traditionanlInvokingButton);
            this.Controls.Add(this.singleThreadButton);
            this.Controls.Add(this.numberCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberCounter;
        private System.Windows.Forms.Button singleThreadButton;
        private System.Windows.Forms.Button traditionanlInvokingButton;
        private System.Windows.Forms.Button awaitButton;
        private System.Windows.Forms.Button awaitWithoutCtxSyncButton;
    }
}

