namespace CSharpAppSensoRestClient
{
    partial class formAppSensorRestClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAppSensorRestClient));
            this.lbRequestURL = new System.Windows.Forms.Label();
            this.tbRequestURL = new System.Windows.Forms.TextBox();
            this.lbRequestHeader = new System.Windows.Forms.Label();
            this.tbRequestHeader = new System.Windows.Forms.TextBox();
            this.lbRequestOutput = new System.Windows.Forms.Label();
            this.tbRequestOutput = new System.Windows.Forms.TextBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRequestURL
            // 
            this.lbRequestURL.AutoSize = true;
            this.lbRequestURL.Location = new System.Drawing.Point(12, 12);
            this.lbRequestURL.Name = "lbRequestURL";
            this.lbRequestURL.Size = new System.Drawing.Size(97, 17);
            this.lbRequestURL.TabIndex = 0;
            this.lbRequestURL.Text = "Request URL:";
            // 
            // tbRequestURL
            // 
            this.tbRequestURL.Location = new System.Drawing.Point(135, 12);
            this.tbRequestURL.Name = "tbRequestURL";
            this.tbRequestURL.Size = new System.Drawing.Size(502, 22);
            this.tbRequestURL.TabIndex = 1;
            this.tbRequestURL.Text = "http://localhost:8085/api/v1.0/responses";
            // 
            // lbRequestHeader
            // 
            this.lbRequestHeader.AutoSize = true;
            this.lbRequestHeader.Location = new System.Drawing.Point(12, 41);
            this.lbRequestHeader.Name = "lbRequestHeader";
            this.lbRequestHeader.Size = new System.Drawing.Size(116, 17);
            this.lbRequestHeader.TabIndex = 2;
            this.lbRequestHeader.Text = "Request Header:";
            // 
            // tbRequestHeader
            // 
            this.tbRequestHeader.Location = new System.Drawing.Point(135, 41);
            this.tbRequestHeader.Name = "tbRequestHeader";
            this.tbRequestHeader.Size = new System.Drawing.Size(502, 22);
            this.tbRequestHeader.TabIndex = 3;
            this.tbRequestHeader.Text = "myclientapp";
            // 
            // lbRequestOutput
            // 
            this.lbRequestOutput.AutoSize = true;
            this.lbRequestOutput.Location = new System.Drawing.Point(12, 71);
            this.lbRequestOutput.Name = "lbRequestOutput";
            this.lbRequestOutput.Size = new System.Drawing.Size(112, 17);
            this.lbRequestOutput.TabIndex = 4;
            this.lbRequestOutput.Text = "Request Output:";
            // 
            // tbRequestOutput
            // 
            this.tbRequestOutput.Location = new System.Drawing.Point(135, 71);
            this.tbRequestOutput.Multiline = true;
            this.tbRequestOutput.Name = "tbRequestOutput";
            this.tbRequestOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRequestOutput.Size = new System.Drawing.Size(502, 310);
            this.tbRequestOutput.TabIndex = 5;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(655, 12);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(185, 369);
            this.btnSendRequest.TabIndex = 6;
            this.btnSendRequest.Text = "SEND!";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // formAppSensorRestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 393);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.tbRequestOutput);
            this.Controls.Add(this.lbRequestOutput);
            this.Controls.Add(this.tbRequestHeader);
            this.Controls.Add(this.lbRequestHeader);
            this.Controls.Add(this.tbRequestURL);
            this.Controls.Add(this.lbRequestURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formAppSensorRestClient";
            this.Text = "AppSensor REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRequestURL;
        private System.Windows.Forms.TextBox tbRequestURL;
        private System.Windows.Forms.Label lbRequestHeader;
        private System.Windows.Forms.TextBox tbRequestHeader;
        private System.Windows.Forms.Label lbRequestOutput;
        private System.Windows.Forms.TextBox tbRequestOutput;
        private System.Windows.Forms.Button btnSendRequest;
    }
}

