namespace IS_4
{
    partial class TeamForm
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
            this.buttonTeamCancel = new System.Windows.Forms.Button();
            this.buttonTeamOK = new System.Windows.Forms.Button();
            this.textBoxTrainer = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTeamCancel
            // 
            this.buttonTeamCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonTeamCancel.Location = new System.Drawing.Point(124, 138);
            this.buttonTeamCancel.Name = "buttonTeamCancel";
            this.buttonTeamCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamCancel.TabIndex = 0;
            this.buttonTeamCancel.Text = "Отмена";
            this.buttonTeamCancel.UseVisualStyleBackColor = true;
            // 
            // buttonTeamOK
            // 
            this.buttonTeamOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonTeamOK.Location = new System.Drawing.Point(12, 139);
            this.buttonTeamOK.Name = "buttonTeamOK";
            this.buttonTeamOK.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamOK.TabIndex = 1;
            this.buttonTeamOK.Text = "ОК";
            this.buttonTeamOK.UseVisualStyleBackColor = true;
            // 
            // textBoxTrainer
            // 
            this.textBoxTrainer.Location = new System.Drawing.Point(75, 86);
            this.textBoxTrainer.Name = "textBoxTrainer";
            this.textBoxTrainer.Size = new System.Drawing.Size(124, 20);
            this.textBoxTrainer.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(75, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(124, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тренер";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxTrainer);
            this.Controls.Add(this.buttonTeamOK);
            this.Controls.Add(this.buttonTeamCancel);
            this.Name = "TeamForm";
            this.Text = "Команда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button buttonTeamCancel;
        internal System.Windows.Forms.Button buttonTeamOK;
        internal System.Windows.Forms.TextBox textBoxTrainer;
        internal System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}