
namespace TestMain
{
    partial class JokeForm
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
            this.lblUCID = new System.Windows.Forms.Label();
            this.lblJoke = new System.Windows.Forms.Label();
            this.txtUCID = new System.Windows.Forms.TextBox();
            this.txtJoke = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUCID
            // 
            this.lblUCID.AutoSize = true;
            this.lblUCID.Location = new System.Drawing.Point(678, 435);
            this.lblUCID.Name = "lblUCID";
            this.lblUCID.Size = new System.Drawing.Size(62, 25);
            this.lblUCID.TabIndex = 0;
            this.lblUCID.Text = "UCID";
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(683, 484);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(58, 25);
            this.lblJoke.TabIndex = 1;
            this.lblJoke.Text = "Joke";
            // 
            // txtUCID
            // 
            this.txtUCID.Location = new System.Drawing.Point(772, 435);
            this.txtUCID.Name = "txtUCID";
            this.txtUCID.Size = new System.Drawing.Size(100, 31);
            this.txtUCID.TabIndex = 2;
            // 
            // txtJoke
            // 
            this.txtJoke.Location = new System.Drawing.Point(772, 484);
            this.txtJoke.Name = "txtJoke";
            this.txtJoke.Size = new System.Drawing.Size(234, 31);
            this.txtJoke.TabIndex = 3;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(888, 638);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(176, 64);
            this.cmdSubmit.TabIndex = 4;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(731, 568);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 5;
            // 
            // JokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 1160);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.txtJoke);
            this.Controls.Add(this.txtUCID);
            this.Controls.Add(this.lblJoke);
            this.Controls.Add(this.lblUCID);
            this.Name = "JokeForm";
            this.Text = "JokeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUCID;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.TextBox txtUCID;
        private System.Windows.Forms.TextBox txtJoke;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label lblStatus;
    }
}