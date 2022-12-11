namespace AndersonLab4
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.chkFlightIncluded = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.grpTripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCredit);
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.grpLocation);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(13, 13);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(200, 311);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(9, 205);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(9, 180);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(101, 19);
            this.radCredit.TabIndex = 2;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(58, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(136, 25);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(110, 273);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 32);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // grpLocation
            // 
            this.grpLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpLocation.Controls.Add(this.chkFlightIncluded);
            this.grpLocation.Controls.Add(this.radMexico);
            this.grpLocation.Controls.Add(this.radFlorida);
            this.grpLocation.Controls.Add(this.radCuba);
            this.grpLocation.Location = new System.Drawing.Point(9, 50);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(185, 124);
            this.grpLocation.TabIndex = 1;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Select Location";
            // 
            // chkFlightIncluded
            // 
            this.chkFlightIncluded.AutoSize = true;
            this.chkFlightIncluded.Enabled = false;
            this.chkFlightIncluded.Location = new System.Drawing.Point(10, 101);
            this.chkFlightIncluded.Name = "chkFlightIncluded";
            this.chkFlightIncluded.Size = new System.Drawing.Size(122, 19);
            this.chkFlightIncluded.TabIndex = 0;
            this.chkFlightIncluded.Text = "Flight Included";
            this.chkFlightIncluded.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(10, 75);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 3;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(10, 49);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 2;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(10, 23);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(68, 21);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 23);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTripInfo
            // 
            this.grpTripInfo.Controls.Add(this.btnConfirm);
            this.grpTripInfo.Controls.Add(this.lblDisplay);
            this.grpTripInfo.Location = new System.Drawing.Point(232, 13);
            this.grpTripInfo.Name = "grpTripInfo";
            this.grpTripInfo.Size = new System.Drawing.Size(235, 311);
            this.grpTripInfo.TabIndex = 1;
            this.grpTripInfo.TabStop = false;
            this.grpTripInfo.Text = "Trip Information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(75, 273);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 32);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(7, 23);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(222, 234);
            this.lblDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTripInfo);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Emily Anderson";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpTripInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpTripInfo;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.CheckBox chkFlightIncluded;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCredit;
    }
}

