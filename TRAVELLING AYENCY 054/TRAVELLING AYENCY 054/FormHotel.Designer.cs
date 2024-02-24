namespace TRAVELLING_AYENCY_054
{
    partial class FormHotel
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
            this.buttonCancels = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelStartDays = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBox1Hotel = new System.Windows.Forms.ComboBox();
            this.label2TourName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBedType = new System.Windows.Forms.ComboBox();
            this.textBoxHMBeds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxHMRooms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPriceRange = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancels
            // 
            this.buttonCancels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancels.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonCancels.Location = new System.Drawing.Point(210, 500);
            this.buttonCancels.Name = "buttonCancels";
            this.buttonCancels.Size = new System.Drawing.Size(115, 36);
            this.buttonCancels.TabIndex = 286;
            this.buttonCancels.Text = "Cancel";
            this.buttonCancels.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancels.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Submit.Location = new System.Drawing.Point(29, 500);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(115, 36);
            this.Submit.TabIndex = 285;
            this.Submit.Text = "Submit";
            this.Submit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 27);
            this.label2.TabIndex = 278;
            this.label2.Text = "If you need Rooms, fill this below";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 277;
            // 
            // labelStartDays
            // 
            this.labelStartDays.AutoSize = true;
            this.labelStartDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDays.Location = new System.Drawing.Point(23, 199);
            this.labelStartDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDays.Name = "labelStartDays";
            this.labelStartDays.Size = new System.Drawing.Size(65, 16);
            this.labelStartDays.TabIndex = 276;
            this.labelStartDays.Text = "Start  Day";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Items.AddRange(new object[] {
            "Colombo",
            "Gampaha",
            "Kalutara",
            "Kandy",
            "Galle",
            "Matara"});
            this.comboBoxLocation.Location = new System.Drawing.Point(153, 111);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(182, 21);
            this.comboBoxLocation.TabIndex = 275;
            // 
            // textBoxDays
            // 
            this.textBoxDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDays.Location = new System.Drawing.Point(153, 151);
            this.textBoxDays.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(182, 20);
            this.textBoxDays.TabIndex = 274;
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(23, 155);
            this.labelDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(105, 16);
            this.labelDays.TabIndex = 273;
            this.labelDays.Text = "How Many Days";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.Location = new System.Drawing.Point(23, 114);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(60, 18);
            this.labelDestination.TabIndex = 272;
            this.labelDestination.Text = "Location";
            // 
            // comboBox1Hotel
            // 
            this.comboBox1Hotel.FormattingEnabled = true;
            this.comboBox1Hotel.Items.AddRange(new object[] {
            "Ceylon Grand Hotel",
            "Serendib Beach Resort",
            "Emerald Palace Hotel",
            "Sapphire Sky Hotel",
            "Pearl Sands Resort",
            "Mount Paradise Retreat",
            "Tropical Breeze Hotel",
            "Golden Sun Resort",
            "Azure Bay Hotel",
            "Royal Palm Retreat"});
            this.comboBox1Hotel.Location = new System.Drawing.Point(153, 68);
            this.comboBox1Hotel.Name = "comboBox1Hotel";
            this.comboBox1Hotel.Size = new System.Drawing.Size(182, 21);
            this.comboBox1Hotel.TabIndex = 271;
            // 
            // label2TourName
            // 
            this.label2TourName.AutoSize = true;
            this.label2TourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2TourName.Location = new System.Drawing.Point(23, 73);
            this.label2TourName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2TourName.Name = "label2TourName";
            this.label2TourName.Size = new System.Drawing.Size(79, 16);
            this.label2TourName.TabIndex = 270;
            this.label2TourName.Text = "Hotel Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(153, 27);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(182, 20);
            this.textBoxEmail.TabIndex = 269;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(23, 31);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 268;
            this.labelEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 267;
            this.label1.Text = "Hotels And  Rooms";
            // 
            // comboBoxBedType
            // 
            this.comboBoxBedType.FormattingEnabled = true;
            this.comboBoxBedType.Items.AddRange(new object[] {
            "1 bed ",
            "2 beds",
            "3 beds",
            "6beds",
            "10 beds"});
            this.comboBoxBedType.Location = new System.Drawing.Point(153, 397);
            this.comboBoxBedType.Name = "comboBoxBedType";
            this.comboBoxBedType.Size = new System.Drawing.Size(182, 21);
            this.comboBoxBedType.TabIndex = 290;
            // 
            // textBoxHMBeds
            // 
            this.textBoxHMBeds.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHMBeds.Location = new System.Drawing.Point(153, 434);
            this.textBoxHMBeds.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHMBeds.Name = "textBoxHMBeds";
            this.textBoxHMBeds.Size = new System.Drawing.Size(182, 20);
            this.textBoxHMBeds.TabIndex = 289;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 288;
            this.label4.Text = "How Many Beds";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 287;
            this.label5.Text = "Bed Type";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "AC with SupperRoom",
            "NON AC  with SupperRoom",
            "AC with NormalRoom",
            "NON AC  with NormalRoom"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(153, 326);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(182, 21);
            this.comboBoxRoomType.TabIndex = 294;
            // 
            // textBoxHMRooms
            // 
            this.textBoxHMRooms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHMRooms.Location = new System.Drawing.Point(153, 361);
            this.textBoxHMRooms.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHMRooms.Name = "textBoxHMRooms";
            this.textBoxHMRooms.Size = new System.Drawing.Size(182, 20);
            this.textBoxHMRooms.TabIndex = 293;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 292;
            this.label6.Text = "How Many Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 291;
            this.label7.Text = "Room Type";
            // 
            // comboBoxPriceRange
            // 
            this.comboBoxPriceRange.FormattingEnabled = true;
            this.comboBoxPriceRange.Items.AddRange(new object[] {
            "Low price",
            "Middle Price",
            "High Price"});
            this.comboBoxPriceRange.Location = new System.Drawing.Point(156, 233);
            this.comboBoxPriceRange.Name = "comboBoxPriceRange";
            this.comboBoxPriceRange.Size = new System.Drawing.Size(182, 21);
            this.comboBoxPriceRange.TabIndex = 296;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 295;
            this.label8.Text = "Price Range";
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.comboBoxPriceRange);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxHMRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBedType);
            this.Controls.Add(this.textBoxHMBeds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancels);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelStartDays);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.comboBox1Hotel);
            this.Controls.Add(this.label2TourName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label1);
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancels;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelStartDays;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ComboBox comboBox1Hotel;
        private System.Windows.Forms.Label label2TourName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBedType;
        private System.Windows.Forms.TextBox textBoxHMBeds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox textBoxHMRooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPriceRange;
        private System.Windows.Forms.Label label8;
    }
}