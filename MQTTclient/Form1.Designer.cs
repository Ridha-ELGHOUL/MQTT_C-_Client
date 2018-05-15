namespace MQTT_Client_
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msgpub = new System.Windows.Forms.TextBox();
            this.txtopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtTopicSubscribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.bntsubs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Topic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Recieved Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Topic";
            // 
            // msgpub
            // 
            this.msgpub.Location = new System.Drawing.Point(477, 327);
            this.msgpub.Multiline = true;
            this.msgpub.Name = "msgpub";
            this.msgpub.Size = new System.Drawing.Size(161, 56);
            this.msgpub.TabIndex = 21;
            // 
            // txtopic
            // 
            this.txtopic.Location = new System.Drawing.Point(242, 327);
            this.txtopic.Multiline = true;
            this.txtopic.Name = "txtopic";
            this.txtopic.Size = new System.Drawing.Size(136, 29);
            this.txtopic.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Topic";
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(477, 160);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(161, 56);
            this.txtReceived.TabIndex = 18;
            // 
            // txtTopicSubscribe
            // 
            this.txtTopicSubscribe.Location = new System.Drawing.Point(242, 160);
            this.txtTopicSubscribe.Multiline = true;
            this.txtTopicSubscribe.Name = "txtTopicSubscribe";
            this.txtTopicSubscribe.Size = new System.Drawing.Size(136, 29);
            this.txtTopicSubscribe.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Not Connected";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Publish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntsubs
            // 
            this.bntsubs.Location = new System.Drawing.Point(392, 121);
            this.bntsubs.Name = "bntsubs";
            this.bntsubs.Size = new System.Drawing.Size(75, 23);
            this.bntsubs.TabIndex = 14;
            this.bntsubs.Text = "Subscribe";
            this.bntsubs.UseVisualStyleBackColor = true;
            this.bntsubs.Click += new System.EventHandler(this.bntsubs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connection to MQTT Broker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "publish";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msgpub);
            this.Controls.Add(this.txtopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtTopicSubscribe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntsubs);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msgpub;
        private System.Windows.Forms.TextBox txtopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.TextBox txtTopicSubscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bntsubs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

