namespace CMA.Code.App
{
    partial class TestForm
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
            this.text = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblSubText = new System.Windows.Forms.Label();
            this.subText = new System.Windows.Forms.CheckedListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(123, 39);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(454, 20);
            this.text.TabIndex = 0;
            this.text.Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we\'ll a" +
                "ll have tea";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(59, 39);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text";
            // 
            // lblSubText
            // 
            this.lblSubText.AutoSize = true;
            this.lblSubText.Location = new System.Drawing.Point(59, 69);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.Size = new System.Drawing.Size(43, 13);
            this.lblSubText.TabIndex = 3;
            this.lblSubText.Text = "Subtext";
            // 
            // subText
            // 
            this.subText.FormattingEnabled = true;
            this.subText.Items.AddRange(new object[] {
            "Polly",
            "polly",
            "ll",
            "Ll",
            "X",
            "Polx"});
            this.subText.Location = new System.Drawing.Point(123, 69);
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(160, 94);
            this.subText.TabIndex = 4;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(62, 178);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(44, 15);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Results";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(326, 139);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 496);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.subText);
            this.Controls.Add(this.lblSubText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.text);
            this.Name = "TestForm";
            this.Text = "CMA Code Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.CheckedListBox subText;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnMatch;
    }
}

