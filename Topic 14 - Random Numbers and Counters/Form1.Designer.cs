namespace Topic_14___Random_Numbers_and_Counters
{
    partial class FormRandomCounter
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
            this.btnRandomize = new System.Windows.Forms.Button();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.lblRandomCounter = new System.Windows.Forms.Label();
            this.lblLargestNum = new System.Windows.Forms.Label();
            this.lblSmallestNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(33, 120);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(415, 52);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Generate Random Number";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomNumber.Location = new System.Drawing.Point(488, 120);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(40, 42);
            this.lblRandomNumber.TabIndex = 1;
            this.lblRandomNumber.Text = "0";
            // 
            // lblRandomCounter
            // 
            this.lblRandomCounter.AutoSize = true;
            this.lblRandomCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomCounter.Location = new System.Drawing.Point(54, 203);
            this.lblRandomCounter.Name = "lblRandomCounter";
            this.lblRandomCounter.Size = new System.Drawing.Size(394, 37);
            this.lblRandomCounter.TabIndex = 2;
            this.lblRandomCounter.Text = "0 Random Numbers made";
            // 
            // lblLargestNum
            // 
            this.lblLargestNum.AutoSize = true;
            this.lblLargestNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestNum.Location = new System.Drawing.Point(61, 269);
            this.lblLargestNum.Name = "lblLargestNum";
            this.lblLargestNum.Size = new System.Drawing.Size(131, 20);
            this.lblLargestNum.TabIndex = 3;
            this.lblLargestNum.Text = "Largest Number: ";
            // 
            // lblSmallestNum
            // 
            this.lblSmallestNum.AutoSize = true;
            this.lblSmallestNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallestNum.Location = new System.Drawing.Point(61, 306);
            this.lblSmallestNum.Name = "lblSmallestNum";
            this.lblSmallestNum.Size = new System.Drawing.Size(134, 20);
            this.lblSmallestNum.TabIndex = 4;
            this.lblSmallestNum.Text = "Smallest Number:";
            // 
            // FormRandomCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSmallestNum);
            this.Controls.Add(this.lblLargestNum);
            this.Controls.Add(this.lblRandomCounter);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.btnRandomize);
            this.Name = "FormRandomCounter";
            this.Text = "Random Numbers and Counters";
            this.Load += new System.EventHandler(this.FormRandomCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Label lblRandomCounter;
        private System.Windows.Forms.Label lblLargestNum;
        private System.Windows.Forms.Label lblSmallestNum;
    }
}

