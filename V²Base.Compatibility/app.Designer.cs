using System.Threading.Tasks;
using System.Web.Script.Serialization;
using V_Base.Compatibility.Common;
using V_Base.Compatibility.Core;
namespace V_Base.Compatibility
{
    partial class app
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

        public void setText(string newText)
        {
            
            richTextBox1.Text = newText;
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.logc = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(334, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // logc
            // 
            this.logc.Location = new System.Drawing.Point(208, 10);
            this.logc.Name = "logc";
            this.logc.Size = new System.Drawing.Size(129, 23);
            this.logc.TabIndex = 1;
            this.logc.Text = "Log Configuration";
            this.logc.UseVisualStyleBackColor = true;
            this.logc.Click += new System.EventHandler(this.button1_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(3, 12);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(199, 20);
            this.email.TabIndex = 2;
            this.email.Text = "Enter Your Email";
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Terms and Privacy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 35);
            this.label2.MaximumSize = new System.Drawing.Size(200, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 195);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.logc);
            this.Controls.Add(this.richTextBox1);
            this.Name = "app";
            this.Text = "Villagetronic  Configuration Tool";
            this.Load += new System.EventHandler(this.app_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button logc;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

