namespace TipsterApp
{
    partial class HomeForm
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
            this.btnAnnual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioLoss = new System.Windows.Forms.RadioButton();
            this.radioWin = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnViewBets = new System.Windows.Forms.Button();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPopular = new System.Windows.Forms.Button();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnnual
            // 
            this.btnAnnual.Location = new System.Drawing.Point(752, 50);
            this.btnAnnual.Name = "btnAnnual";
            this.btnAnnual.Size = new System.Drawing.Size(195, 90);
            this.btnAnnual.TabIndex = 11;
            this.btnAnnual.Text = "Annual Reports";
            this.btnAnnual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Track:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount Bet:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioLoss);
            this.groupBox.Controls.Add(this.radioWin);
            this.groupBox.Location = new System.Drawing.Point(40, 436);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(504, 100);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Bet Outcome:";
            // 
            // radioLoss
            // 
            this.radioLoss.AutoSize = true;
            this.radioLoss.Location = new System.Drawing.Point(370, 0);
            this.radioLoss.Name = "radioLoss";
            this.radioLoss.Size = new System.Drawing.Size(68, 24);
            this.radioLoss.TabIndex = 1;
            this.radioLoss.TabStop = true;
            this.radioLoss.Text = "Loss";
            this.radioLoss.UseVisualStyleBackColor = true;
            // 
            // radioWin
            // 
            this.radioWin.AutoSize = true;
            this.radioWin.Location = new System.Drawing.Point(194, 0);
            this.radioWin.Name = "radioWin";
            this.radioWin.Size = new System.Drawing.Size(61, 24);
            this.radioWin.TabIndex = 0;
            this.radioWin.TabStop = true;
            this.radioWin.Text = "Win";
            this.radioWin.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 542);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 90);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Bet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnViewBets
            // 
            this.btnViewBets.Location = new System.Drawing.Point(441, 542);
            this.btnViewBets.Name = "btnViewBets";
            this.btnViewBets.Size = new System.Drawing.Size(195, 90);
            this.btnViewBets.TabIndex = 17;
            this.btnViewBets.Text = "View All Bets";
            this.btnViewBets.UseVisualStyleBackColor = true;
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(186, 82);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(310, 26);
            this.txtTrack.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(186, 199);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(310, 26);
            this.dateTimePicker.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(186, 311);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(310, 26);
            this.txtAmount.TabIndex = 20;
            // 
            // btnPopular
            // 
            this.btnPopular.Location = new System.Drawing.Point(752, 169);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(195, 90);
            this.btnPopular.TabIndex = 21;
            this.btnPopular.Text = "Most Popular Track";
            this.btnPopular.UseVisualStyleBackColor = true;
            // 
            // btnHighLow
            // 
            this.btnHighLow.Location = new System.Drawing.Point(752, 289);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(195, 90);
            this.btnHighLow.TabIndex = 22;
            this.btnHighLow.Text = "Highest/Lowest Bet";
            this.btnHighLow.UseVisualStyleBackColor = true;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(752, 415);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(195, 90);
            this.btnSuccess.TabIndex = 23;
            this.btnSuccess.Text = "Success Rate";
            this.btnSuccess.UseVisualStyleBackColor = true;
            // 
            // btnHtml
            // 
            this.btnHtml.Location = new System.Drawing.Point(752, 542);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(195, 90);
            this.btnHtml.TabIndex = 24;
            this.btnHtml.Text = "Generate Html";
            this.btnHtml.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 709);
            this.Controls.Add(this.btnHtml);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.btnPopular);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtTrack);
            this.Controls.Add(this.btnViewBets);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnual);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotTipster";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioLoss;
        private System.Windows.Forms.RadioButton radioWin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnViewBets;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.Button btnHighLow;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button btnHtml;
    }
}

