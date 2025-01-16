namespace WorldDatabaseClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCountries = new Label();
            btnGetAllCountries = new Button();
            lblCountryCode = new Label();
            txtCountryCode = new TextBox();
            btnGetCountrybyCode = new Button();
            lblCityName = new Label();
            txtCityName = new TextBox();
            btnGetCitybyName = new Button();
            lblCitiesinCountry = new Label();
            txtCountryCodeForCities = new TextBox();
            btnGetCitiesbyCountry = new Button();
            listBoxCities = new ListBox();
            listBoxCountries = new ListBox();
            SuspendLayout();
            // 
            // lblCountries
            // 
            lblCountries.AutoSize = true;
            lblCountries.Location = new Point(21, 21);
            lblCountries.Name = "lblCountries";
            lblCountries.Size = new Size(71, 20);
            lblCountries.TabIndex = 2;
            lblCountries.Text = "Countries";
            // 
            // btnGetAllCountries
            // 
            btnGetAllCountries.Location = new Point(111, 17);
            btnGetAllCountries.Name = "btnGetAllCountries";
            btnGetAllCountries.Size = new Size(192, 29);
            btnGetAllCountries.TabIndex = 3;
            btnGetAllCountries.Text = "Get All Countries";
            btnGetAllCountries.UseVisualStyleBackColor = true;
            btnGetAllCountries.Click += btnGetAllCountries_Click;
            // 
            // lblCountryCode
            // 
            lblCountryCode.AutoSize = true;
            lblCountryCode.Location = new Point(21, 87);
            lblCountryCode.Name = "lblCountryCode";
            lblCountryCode.Size = new Size(99, 20);
            lblCountryCode.TabIndex = 4;
            lblCountryCode.Text = "Country Code";
            // 
            // txtCountryCode
            // 
            txtCountryCode.Location = new Point(131, 87);
            txtCountryCode.Name = "txtCountryCode";
            txtCountryCode.Size = new Size(172, 27);
            txtCountryCode.TabIndex = 5;
            // 
            // btnGetCountrybyCode
            // 
            btnGetCountrybyCode.Location = new Point(320, 87);
            btnGetCountrybyCode.Name = "btnGetCountrybyCode";
            btnGetCountrybyCode.Size = new Size(230, 29);
            btnGetCountrybyCode.TabIndex = 6;
            btnGetCountrybyCode.Text = "Get Country by Code";
            btnGetCountrybyCode.UseVisualStyleBackColor = true;
            btnGetCountrybyCode.Click += btnGetCountrybyCode_Click;
            // 
            // lblCityName
            // 
            lblCityName.AutoSize = true;
            lblCityName.Location = new Point(21, 163);
            lblCityName.Name = "lblCityName";
            lblCityName.Size = new Size(78, 20);
            lblCityName.TabIndex = 7;
            lblCityName.Text = "City Name";
            // 
            // txtCityName
            // 
            txtCityName.Location = new Point(111, 160);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(125, 27);
            txtCityName.TabIndex = 8;
            // 
            // btnGetCitybyName
            // 
            btnGetCitybyName.Location = new Point(267, 158);
            btnGetCitybyName.Name = "btnGetCitybyName";
            btnGetCitybyName.Size = new Size(210, 29);
            btnGetCitybyName.TabIndex = 9;
            btnGetCitybyName.Text = "Get City by Name";
            btnGetCitybyName.UseVisualStyleBackColor = true;
            btnGetCitybyName.Click += btnGetCitybyName_Click;
            // 
            // lblCitiesinCountry
            // 
            lblCitiesinCountry.AutoSize = true;
            lblCitiesinCountry.Location = new Point(21, 244);
            lblCitiesinCountry.Name = "lblCitiesinCountry";
            lblCitiesinCountry.Size = new Size(116, 20);
            lblCitiesinCountry.TabIndex = 11;
            lblCitiesinCountry.Text = "Cities in Country";
            // 
            // txtCountryCodeForCities
            // 
            txtCountryCodeForCities.Location = new Point(152, 244);
            txtCountryCodeForCities.Name = "txtCountryCodeForCities";
            txtCountryCodeForCities.Size = new Size(184, 27);
            txtCountryCodeForCities.TabIndex = 12;
            // 
            // btnGetCitiesbyCountry
            // 
            btnGetCitiesbyCountry.Location = new Point(362, 244);
            btnGetCitiesbyCountry.Name = "btnGetCitiesbyCountry";
            btnGetCitiesbyCountry.Size = new Size(188, 29);
            btnGetCitiesbyCountry.TabIndex = 13;
            btnGetCitiesbyCountry.Text = "Get Cities by Country";
            btnGetCitiesbyCountry.UseVisualStyleBackColor = true;
            btnGetCitiesbyCountry.Click += btnGetCitiesbyCountry_Click;
            // 
            // listBoxCities
            // 
            listBoxCities.FormattingEnabled = true;
            listBoxCities.Location = new Point(21, 297);
            listBoxCities.Name = "listBoxCities";
            listBoxCities.Size = new Size(254, 144);
            listBoxCities.TabIndex = 14;
            // 
            // listBoxCountries
            // 
            listBoxCountries.FormattingEnabled = true;
            listBoxCountries.Location = new Point(320, 297);
            listBoxCountries.Name = "listBoxCountries";
            listBoxCountries.Size = new Size(287, 144);
            listBoxCountries.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(listBoxCountries);
            Controls.Add(listBoxCities);
            Controls.Add(btnGetCitiesbyCountry);
            Controls.Add(txtCountryCodeForCities);
            Controls.Add(lblCitiesinCountry);
            Controls.Add(btnGetCitybyName);
            Controls.Add(txtCityName);
            Controls.Add(lblCityName);
            Controls.Add(btnGetCountrybyCode);
            Controls.Add(txtCountryCode);
            Controls.Add(lblCountryCode);
            Controls.Add(btnGetAllCountries);
            Controls.Add(lblCountries);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCountries;
        private Button btnGetAllCountries;
        private Label lblCountryCode;
        private TextBox txtCountryCode;
        private Button btnGetCountrybyCode;
        private Label lblCityName;
        private TextBox txtCityName;
        private Button btnGetCitybyName;
        private Label lblCitiesinCountry;
        private TextBox txtCountryCodeForCities;
        private Button btnGetCitiesbyCountry;
        private ListBox listBoxCities;
        private ListBox listBoxCountries;
    }
}
