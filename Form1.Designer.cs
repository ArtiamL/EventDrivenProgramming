namespace EventDrivenProgramming
{
    partial class Form1 : Form
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
            grpCustomerInfo = new GroupBox();
            lblCheck = new Label();
            lstCustError = new ListBox();
            btnClearInfo = new Button();
            btnCustomer = new Button();
            txtPhoneNum = new TextBox();
            txtEmail = new TextBox();
            cmbCounty = new ComboBox();
            txtPostCode = new TextBox();
            txtAddrTown = new TextBox();
            txtLastName = new TextBox();
            txtAddr2 = new TextBox();
            txtAddr1 = new TextBox();
            txtFirstName = new TextBox();
            grpWallpapers = new GroupBox();
            btnFaux = new Button();
            btnPastel = new Button();
            btnGeometry = new Button();
            btnLines = new Button();
            btnFlowers = new Button();
            btnFeathers = new Button();
            btnMarble = new Button();
            btnBaubau = new Button();
            btnPalazo = new Button();
            lblSelectedPrice = new Label();
            lblSelected = new Label();
            lblPrice = new Label();
            lblWallpaper = new Label();
            grpDimensions = new GroupBox();
            picSelected = new Label();
            lblFinalPrice = new Label();
            btnClearDims = new Button();
            lblCost = new Label();
            btnCalculate = new Button();
            lblRollsRequired = new Label();
            lblRolls = new Label();
            lblSurfArea = new Label();
            lblArea = new Label();
            rdoFeet = new RadioButton();
            rdoMetres = new RadioButton();
            numHeight = new NumericUpDown();
            lblHeight = new Label();
            numWidth = new NumericUpDown();
            lblwidth = new Label();
            numLength = new NumericUpDown();
            lblLength = new Label();
            menuStrip = new MenuStrip();
            mItemFile = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiSave = new ToolStripMenuItem();
            grpCustomerInfo.SuspendLayout();
            grpWallpapers.SuspendLayout();
            grpDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // grpCustomerInfo
            // 
            grpCustomerInfo.Controls.Add(lblCheck);
            grpCustomerInfo.Controls.Add(lstCustError);
            grpCustomerInfo.Controls.Add(btnClearInfo);
            grpCustomerInfo.Controls.Add(btnCustomer);
            grpCustomerInfo.Controls.Add(txtPhoneNum);
            grpCustomerInfo.Controls.Add(txtEmail);
            grpCustomerInfo.Controls.Add(cmbCounty);
            grpCustomerInfo.Controls.Add(txtPostCode);
            grpCustomerInfo.Controls.Add(txtAddrTown);
            grpCustomerInfo.Controls.Add(txtLastName);
            grpCustomerInfo.Controls.Add(txtAddr2);
            grpCustomerInfo.Controls.Add(txtAddr1);
            grpCustomerInfo.Controls.Add(txtFirstName);
            grpCustomerInfo.FlatStyle = FlatStyle.Flat;
            grpCustomerInfo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            grpCustomerInfo.Location = new Point(10, 23);
            grpCustomerInfo.Margin = new Padding(3, 2, 3, 2);
            grpCustomerInfo.Name = "grpCustomerInfo";
            grpCustomerInfo.Padding = new Padding(3, 2, 3, 2);
            grpCustomerInfo.Size = new Size(672, 269);
            grpCustomerInfo.TabIndex = 1;
            grpCustomerInfo.TabStop = false;
            grpCustomerInfo.Text = "Customer Info";
            // 
            // lblCheck
            // 
            lblCheck.AutoSize = true;
            lblCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheck.ForeColor = Color.Red;
            lblCheck.Location = new Point(340, 97);
            lblCheck.Name = "lblCheck";
            lblCheck.Size = new Size(195, 21);
            lblCheck.TabIndex = 12;
            lblCheck.Text = "Please check the following:";
            lblCheck.Visible = false;
            // 
            // lstCustError
            // 
            lstCustError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCustError.ForeColor = Color.Red;
            lstCustError.FormattingEnabled = true;
            lstCustError.ItemHeight = 21;
            lstCustError.Location = new Point(340, 128);
            lstCustError.Margin = new Padding(3, 2, 3, 2);
            lstCustError.Name = "lstCustError";
            lstCustError.SelectionMode = SelectionMode.None;
            lstCustError.Size = new Size(324, 88);
            lstCustError.TabIndex = 11;
            lstCustError.TabStop = false;
            lstCustError.Visible = false;
            // 
            // btnClearInfo
            // 
            btnClearInfo.BackColor = Color.White;
            btnClearInfo.FlatAppearance.BorderColor = Color.Maroon;
            btnClearInfo.FlatStyle = FlatStyle.Flat;
            btnClearInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearInfo.ForeColor = Color.Black;
            btnClearInfo.Location = new Point(122, 224);
            btnClearInfo.Margin = new Padding(3, 2, 3, 2);
            btnClearInfo.Name = "btnClearInfo";
            btnClearInfo.Size = new Size(108, 34);
            btnClearInfo.TabIndex = 10;
            btnClearInfo.Text = "Clear";
            btnClearInfo.UseVisualStyleBackColor = false;
            btnClearInfo.Click += btnClear_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.LightSeaGreen;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(9, 224);
            btnCustomer.Margin = new Padding(3, 2, 3, 2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(108, 34);
            btnCustomer.TabIndex = 9;
            btnCustomer.Text = "Continue";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNum.Location = new Point(340, 62);
            txtPhoneNum.Margin = new Padding(4);
            txtPhoneNum.MaxLength = 11;
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.PlaceholderText = "Phone Number";
            txtPhoneNum.Size = new Size(324, 29);
            txtPhoneNum.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(340, 30);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email Address";
            txtEmail.Size = new Size(324, 29);
            txtEmail.TabIndex = 7;
            // 
            // cmbCounty
            // 
            cmbCounty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCounty.FlatStyle = FlatStyle.Flat;
            cmbCounty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCounty.FormattingEnabled = true;
            cmbCounty.Items.AddRange(new object[] { "Aberdeenshire", "Angus", "Antrim", "Argyll & Bute", "Armagh", "Ayrshire", "Banffshire", "Bath and North East Somerset", "Bedfordshire", "Berkshire", "Berwickshire", "Blaenau Gwent", "Borders", "Bridgend", "Bristol", "Buckinghamshire", "Caerphilly", "Caithness", "Cambridgeshire", "Cardiff", "Carmarthenshire", "Ceredigion", "Cheshire", "Clackmannanshire", "Conwy", "Cornwall", "County Durham", "Cumbria", "Denbighshire", "Derbyshire", "Devon", "Dorset", "Down", "Dumfries & Galloway", "Dunbartonshire", "East Ayrshire", "East Dunbartonshire", "East Lothian", "East Renfrewshire", "East Riding of Yorkshire", "East Sussex", "Essex", "Fermanagh", "Fife", "Flintshire", "Gloucestershire", "Greater London", "Greater Manchester", "Gwynedd", "Hampshire", "Herefordshire", "Hertfordshire", "Highland", "Inverclyde", "Isle of Anglesey", "Isle of Wight", "Isles of Scilly", "Kent", "Kincardineshire", "Lanarkshire", "Lancashire", "Leicestershire", "Lincolnshire", "Londonderry", "Merseyside", "Merthyr Tydfil", "Midlothian", "Monmouthshire", "Moray", "Neath Port Talbot.", "Newport.", "Norfolk", "North Ayrshire", "North Lanarkshire", "North Somerset", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottinghamshire", "Orkney", "Oxfordshire", "Pembrokeshire", "Perth & Kinross", "Powys", "Renfrewshire", "Rhondda Cynon Taff", "Rutland", "Shetland", "Shropshire", "Somerset", "South Ayrshire", "South Gloucestershire", "South Lanarkshire", "South Yorkshire", "Staffordshire", "Stirlingshire", "Suffolk", "Surrey", "Swansea", "Torfaen", "Tyne & Wear", "Tyrone", "Vale of Glamorgan", "Warwickshire", "West Dunbartonshire", "West Lothian", "West Midlands", "West Sussex", "West Yorkshire", "Western Isles", "Wiltshire", "Worcestershire", "Wrexham" });
            cmbCounty.Location = new Point(7, 159);
            cmbCounty.Margin = new Padding(3, 2, 3, 2);
            cmbCounty.Name = "cmbCounty";
            cmbCounty.Size = new Size(324, 29);
            cmbCounty.Sorted = true;
            cmbCounty.TabIndex = 5;
            // 
            // txtPostCode
            // 
            txtPostCode.CharacterCasing = CharacterCasing.Upper;
            txtPostCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostCode.Location = new Point(7, 192);
            txtPostCode.Margin = new Padding(4);
            txtPostCode.MaxLength = 8;
            txtPostCode.Name = "txtPostCode";
            txtPostCode.PlaceholderText = "Postcode";
            txtPostCode.Size = new Size(324, 29);
            txtPostCode.TabIndex = 6;
            // 
            // txtAddrTown
            // 
            txtAddrTown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddrTown.Location = new Point(7, 128);
            txtAddrTown.Margin = new Padding(4);
            txtAddrTown.Name = "txtAddrTown";
            txtAddrTown.PlaceholderText = "Town/City";
            txtAddrTown.Size = new Size(324, 29);
            txtAddrTown.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(172, 30);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(160, 29);
            txtLastName.TabIndex = 1;
            // 
            // txtAddr2
            // 
            txtAddr2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddr2.Location = new Point(7, 94);
            txtAddr2.Margin = new Padding(4);
            txtAddr2.Name = "txtAddr2";
            txtAddr2.PlaceholderText = "Address Line 2";
            txtAddr2.Size = new Size(324, 29);
            txtAddr2.TabIndex = 3;
            // 
            // txtAddr1
            // 
            txtAddr1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddr1.Location = new Point(7, 62);
            txtAddr1.Margin = new Padding(4);
            txtAddr1.Name = "txtAddr1";
            txtAddr1.PlaceholderText = "Address Line 1";
            txtAddr1.Size = new Size(324, 29);
            txtAddr1.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(7, 30);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(160, 29);
            txtFirstName.TabIndex = 0;
            // 
            // grpWallpapers
            // 
            grpWallpapers.Controls.Add(btnFaux);
            grpWallpapers.Controls.Add(btnPastel);
            grpWallpapers.Controls.Add(btnGeometry);
            grpWallpapers.Controls.Add(btnLines);
            grpWallpapers.Controls.Add(btnFlowers);
            grpWallpapers.Controls.Add(btnFeathers);
            grpWallpapers.Controls.Add(btnMarble);
            grpWallpapers.Controls.Add(btnBaubau);
            grpWallpapers.Controls.Add(btnPalazo);
            grpWallpapers.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            grpWallpapers.Location = new Point(688, 9);
            grpWallpapers.Margin = new Padding(3, 2, 3, 2);
            grpWallpapers.Name = "grpWallpapers";
            grpWallpapers.Padding = new Padding(3, 2, 3, 2);
            grpWallpapers.Size = new Size(595, 536);
            grpWallpapers.TabIndex = 3;
            grpWallpapers.TabStop = false;
            grpWallpapers.Text = "Wallpapers";
            // 
            // btnFaux
            // 
            btnFaux.BackColor = SystemColors.Control;
            btnFaux.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnFaux.FlatAppearance.BorderSize = 0;
            btnFaux.FlatStyle = FlatStyle.Flat;
            btnFaux.Image = Properties.Resources.sample_3d_wooden_beam_charcoal_silver_faux_wood_block_pattern_wallpaper_exclusive_9016_p10052_28698_image;
            btnFaux.Location = new Point(397, 364);
            btnFaux.Margin = new Padding(3, 2, 3, 2);
            btnFaux.Name = "btnFaux";
            btnFaux.Size = new Size(191, 164);
            btnFaux.TabIndex = 8;
            btnFaux.UseVisualStyleBackColor = false;
            btnFaux.Click += btnWallpaper_Click;
            // 
            // btnPastel
            // 
            btnPastel.BackColor = SystemColors.Control;
            btnPastel.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnPastel.FlatAppearance.BorderSize = 0;
            btnPastel.FlatStyle = FlatStyle.Flat;
            btnPastel.Image = Properties.Resources.pastel;
            btnPastel.Location = new Point(201, 364);
            btnPastel.Margin = new Padding(3, 2, 3, 2);
            btnPastel.Name = "btnPastel";
            btnPastel.Size = new Size(191, 164);
            btnPastel.TabIndex = 7;
            btnPastel.TabStop = false;
            btnPastel.UseVisualStyleBackColor = false;
            btnPastel.Click += btnWallpaper_Click;
            // 
            // btnGeometry
            // 
            btnGeometry.BackColor = SystemColors.Control;
            btnGeometry.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnGeometry.FlatAppearance.BorderSize = 0;
            btnGeometry.FlatStyle = FlatStyle.Flat;
            btnGeometry.Image = Properties.Resources.marino_geometric_squares_grey_wallpaper_by_fine_decor_fd42391_p3166_12788_image;
            btnGeometry.Location = new Point(5, 364);
            btnGeometry.Margin = new Padding(3, 2, 3, 2);
            btnGeometry.Name = "btnGeometry";
            btnGeometry.Size = new Size(191, 164);
            btnGeometry.TabIndex = 6;
            btnGeometry.TabStop = false;
            btnGeometry.UseVisualStyleBackColor = false;
            btnGeometry.Click += btnWallpaper_Click;
            // 
            // btnLines
            // 
            btnLines.BackColor = SystemColors.Control;
            btnLines.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnLines.FlatAppearance.BorderSize = 0;
            btnLines.FlatStyle = FlatStyle.Flat;
            btnLines.Image = Properties.Resources.lines;
            btnLines.Location = new Point(397, 196);
            btnLines.Margin = new Padding(3, 2, 3, 2);
            btnLines.Name = "btnLines";
            btnLines.Size = new Size(191, 164);
            btnLines.TabIndex = 5;
            btnLines.TabStop = false;
            btnLines.UseVisualStyleBackColor = false;
            btnLines.Click += btnWallpaper_Click;
            // 
            // btnFlowers
            // 
            btnFlowers.BackColor = SystemColors.Control;
            btnFlowers.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnFlowers.FlatAppearance.BorderSize = 0;
            btnFlowers.FlatStyle = FlatStyle.Flat;
            btnFlowers.Image = Properties.Resources.julia_miller_yond_interiors_wallpaper_floral_in_bathroom;
            btnFlowers.Location = new Point(201, 196);
            btnFlowers.Margin = new Padding(3, 2, 3, 2);
            btnFlowers.Name = "btnFlowers";
            btnFlowers.Size = new Size(191, 164);
            btnFlowers.TabIndex = 4;
            btnFlowers.TabStop = false;
            btnFlowers.UseVisualStyleBackColor = false;
            btnFlowers.Click += btnWallpaper_Click;
            // 
            // btnFeathers
            // 
            btnFeathers.BackColor = SystemColors.Control;
            btnFeathers.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnFeathers.FlatAppearance.BorderSize = 0;
            btnFeathers.FlatStyle = FlatStyle.Flat;
            btnFeathers.Image = Properties.Resources.Ekran_Resmi_2023_01_30_18_48_26;
            btnFeathers.Location = new Point(5, 196);
            btnFeathers.Margin = new Padding(3, 2, 3, 2);
            btnFeathers.Name = "btnFeathers";
            btnFeathers.Size = new Size(191, 164);
            btnFeathers.TabIndex = 3;
            btnFeathers.TabStop = false;
            btnFeathers.UseVisualStyleBackColor = false;
            btnFeathers.Click += btnWallpaper_Click;
            // 
            // btnMarble
            // 
            btnMarble.BackColor = SystemColors.Control;
            btnMarble.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnMarble.FlatAppearance.BorderSize = 0;
            btnMarble.FlatStyle = FlatStyle.Flat;
            btnMarble.Image = Properties.Resources.Blue_marble;
            btnMarble.Location = new Point(397, 28);
            btnMarble.Margin = new Padding(3, 2, 3, 2);
            btnMarble.Name = "btnMarble";
            btnMarble.Size = new Size(191, 164);
            btnMarble.TabIndex = 2;
            btnMarble.TabStop = false;
            btnMarble.UseVisualStyleBackColor = false;
            btnMarble.Click += btnWallpaper_Click;
            // 
            // btnBaubau
            // 
            btnBaubau.BackColor = SystemColors.Control;
            btnBaubau.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnBaubau.FlatAppearance.BorderSize = 0;
            btnBaubau.FlatStyle = FlatStyle.Flat;
            btnBaubau.ForeColor = Color.Black;
            btnBaubau.Image = Properties.Resources._51100128_Tropical_White_Baubauwall_Wallpaper_room3_3;
            btnBaubau.Location = new Point(201, 28);
            btnBaubau.Margin = new Padding(3, 2, 3, 2);
            btnBaubau.Name = "btnBaubau";
            btnBaubau.Size = new Size(191, 164);
            btnBaubau.TabIndex = 1;
            btnBaubau.TabStop = false;
            btnBaubau.UseVisualStyleBackColor = false;
            btnBaubau.Click += btnWallpaper_Click;
            // 
            // btnPalazo
            // 
            btnPalazo.BackColor = SystemColors.Control;
            btnPalazo.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnPalazo.FlatAppearance.BorderSize = 0;
            btnPalazo.FlatStyle = FlatStyle.Flat;
            btnPalazo.ForeColor = SystemColors.ControlText;
            btnPalazo.Image = Properties.Resources.Palazo;
            btnPalazo.Location = new Point(5, 28);
            btnPalazo.Margin = new Padding(3, 2, 3, 2);
            btnPalazo.Name = "btnPalazo";
            btnPalazo.Size = new Size(191, 164);
            btnPalazo.TabIndex = 0;
            btnPalazo.UseVisualStyleBackColor = false;
            btnPalazo.Click += btnWallpaper_Click;
            // 
            // lblSelectedPrice
            // 
            lblSelectedPrice.AutoSize = true;
            lblSelectedPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedPrice.Location = new Point(520, 117);
            lblSelectedPrice.Margin = new Padding(4);
            lblSelectedPrice.Name = "lblSelectedPrice";
            lblSelectedPrice.Size = new Size(0, 21);
            lblSelectedPrice.TabIndex = 21;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelected.Location = new Point(520, 57);
            lblSelected.Margin = new Padding(4);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(0, 21);
            lblSelected.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(520, 86);
            lblPrice.Margin = new Padding(4);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 25);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "Price:";
            // 
            // lblWallpaper
            // 
            lblWallpaper.AutoSize = true;
            lblWallpaper.Location = new Point(520, 30);
            lblWallpaper.Margin = new Padding(4);
            lblWallpaper.Name = "lblWallpaper";
            lblWallpaper.Size = new Size(102, 25);
            lblWallpaper.TabIndex = 18;
            lblWallpaper.Text = "Wallpaper:";
            // 
            // grpDimensions
            // 
            grpDimensions.Controls.Add(picSelected);
            grpDimensions.Controls.Add(lblSelectedPrice);
            grpDimensions.Controls.Add(lblFinalPrice);
            grpDimensions.Controls.Add(lblSelected);
            grpDimensions.Controls.Add(btnClearDims);
            grpDimensions.Controls.Add(lblPrice);
            grpDimensions.Controls.Add(lblCost);
            grpDimensions.Controls.Add(lblWallpaper);
            grpDimensions.Controls.Add(btnCalculate);
            grpDimensions.Controls.Add(lblRollsRequired);
            grpDimensions.Controls.Add(lblRolls);
            grpDimensions.Controls.Add(lblSurfArea);
            grpDimensions.Controls.Add(lblArea);
            grpDimensions.Controls.Add(rdoFeet);
            grpDimensions.Controls.Add(rdoMetres);
            grpDimensions.Controls.Add(numHeight);
            grpDimensions.Controls.Add(lblHeight);
            grpDimensions.Controls.Add(numWidth);
            grpDimensions.Controls.Add(lblwidth);
            grpDimensions.Controls.Add(numLength);
            grpDimensions.Controls.Add(lblLength);
            grpDimensions.Enabled = false;
            grpDimensions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            grpDimensions.Location = new Point(10, 297);
            grpDimensions.Margin = new Padding(3, 2, 3, 2);
            grpDimensions.Name = "grpDimensions";
            grpDimensions.Padding = new Padding(3, 2, 3, 2);
            grpDimensions.Size = new Size(672, 248);
            grpDimensions.TabIndex = 2;
            grpDimensions.TabStop = false;
            grpDimensions.Text = "Room Dimensions";
            // 
            // picSelected
            // 
            picSelected.BackColor = Color.White;
            picSelected.BorderStyle = BorderStyle.FixedSingle;
            picSelected.Location = new Point(322, 28);
            picSelected.Name = "picSelected";
            picSelected.Size = new Size(191, 164);
            picSelected.TabIndex = 17;
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinalPrice.Location = new Point(116, 181);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(0, 21);
            lblFinalPrice.TabIndex = 15;
            // 
            // btnClearDims
            // 
            btnClearDims.BackColor = Color.White;
            btnClearDims.FlatAppearance.BorderColor = Color.Maroon;
            btnClearDims.FlatStyle = FlatStyle.Flat;
            btnClearDims.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearDims.ForeColor = Color.Black;
            btnClearDims.Location = new Point(120, 206);
            btnClearDims.Margin = new Padding(3, 2, 3, 2);
            btnClearDims.Name = "btnClearDims";
            btnClearDims.Size = new Size(108, 34);
            btnClearDims.TabIndex = 16;
            btnClearDims.Text = "Clear";
            btnClearDims.UseVisualStyleBackColor = false;
            btnClearDims.Click += btnClear_Click;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCost.Location = new Point(7, 179);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(98, 25);
            lblCost.TabIndex = 13;
            lblCost.Text = "Total Cost:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightSeaGreen;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(7, 206);
            btnCalculate.Margin = new Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(108, 34);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblRollsRequired
            // 
            lblRollsRequired.AutoSize = true;
            lblRollsRequired.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRollsRequired.Location = new Point(172, 152);
            lblRollsRequired.Name = "lblRollsRequired";
            lblRollsRequired.Size = new Size(0, 21);
            lblRollsRequired.TabIndex = 12;
            // 
            // lblRolls
            // 
            lblRolls.AutoSize = true;
            lblRolls.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRolls.Location = new Point(7, 152);
            lblRolls.Name = "lblRolls";
            lblRolls.Size = new Size(146, 21);
            lblRolls.TabIndex = 11;
            lblRolls.Text = "Total Rolls required:";
            // 
            // lblSurfArea
            // 
            lblSurfArea.AutoSize = true;
            lblSurfArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSurfArea.Location = new Point(163, 124);
            lblSurfArea.Name = "lblSurfArea";
            lblSurfArea.Size = new Size(0, 21);
            lblSurfArea.TabIndex = 10;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblArea.Location = new Point(7, 124);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(137, 21);
            lblArea.TabIndex = 9;
            lblArea.Text = "Total Surface Area:";
            // 
            // rdoFeet
            // 
            rdoFeet.AutoSize = true;
            rdoFeet.CheckAlign = ContentAlignment.MiddleRight;
            rdoFeet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoFeet.Location = new Point(172, 56);
            rdoFeet.Margin = new Padding(3, 2, 3, 2);
            rdoFeet.Name = "rdoFeet";
            rdoFeet.Size = new Size(57, 25);
            rdoFeet.TabIndex = 8;
            rdoFeet.TabStop = true;
            rdoFeet.Text = "Feet";
            rdoFeet.UseVisualStyleBackColor = true;
            // 
            // rdoMetres
            // 
            rdoMetres.AutoSize = true;
            rdoMetres.CheckAlign = ContentAlignment.MiddleRight;
            rdoMetres.Checked = true;
            rdoMetres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoMetres.Location = new Point(172, 27);
            rdoMetres.Margin = new Padding(3, 2, 3, 2);
            rdoMetres.Name = "rdoMetres";
            rdoMetres.Size = new Size(76, 25);
            rdoMetres.TabIndex = 7;
            rdoMetres.TabStop = true;
            rdoMetres.Text = "Metres";
            rdoMetres.UseVisualStyleBackColor = true;
            // 
            // numHeight
            // 
            numHeight.DecimalPlaces = 2;
            numHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numHeight.Location = new Point(79, 88);
            numHeight.Margin = new Padding(3, 2, 3, 2);
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(86, 29);
            numHeight.TabIndex = 6;
            numHeight.TextAlign = HorizontalAlignment.Center;
            numHeight.Click += numSize_Focus;
            numHeight.Enter += numSize_Focus;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeight.Location = new Point(6, 90);
            lblHeight.Margin = new Padding(4);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(59, 21);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "Height:";
            // 
            // numWidth
            // 
            numWidth.DecimalPlaces = 2;
            numWidth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numWidth.Location = new Point(79, 58);
            numWidth.Margin = new Padding(3, 2, 3, 2);
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(86, 29);
            numWidth.TabIndex = 4;
            numWidth.TextAlign = HorizontalAlignment.Center;
            numWidth.Click += numSize_Focus;
            numWidth.Enter += numSize_Focus;
            // 
            // lblwidth
            // 
            lblwidth.AutoSize = true;
            lblwidth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblwidth.Location = new Point(5, 60);
            lblwidth.Margin = new Padding(4);
            lblwidth.Name = "lblwidth";
            lblwidth.Size = new Size(55, 21);
            lblwidth.TabIndex = 3;
            lblwidth.Text = "Width:";
            // 
            // numLength
            // 
            numLength.DecimalPlaces = 2;
            numLength.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numLength.Location = new Point(79, 28);
            numLength.Margin = new Padding(3, 2, 3, 2);
            numLength.Name = "numLength";
            numLength.Size = new Size(86, 29);
            numLength.TabIndex = 2;
            numLength.TextAlign = HorizontalAlignment.Center;
            numLength.Click += numSize_Focus;
            numLength.Enter += numSize_Focus;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.Location = new Point(5, 30);
            lblLength.Margin = new Padding(4);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(61, 21);
            lblLength.TabIndex = 1;
            lblLength.Text = "Length:";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mItemFile });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(1292, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mItemFile
            // 
            mItemFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpen, tsmiSave });
            mItemFile.Name = "mItemFile";
            mItemFile.Size = new Size(37, 20);
            mItemFile.Text = "File";
            // 
            // tsmiOpen
            // 
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(114, 22);
            tsmiOpen.Text = "Open";
            tsmiOpen.Click += tsmiOpen_Click;
            // 
            // tsmiSave
            // 
            tsmiSave.Name = "tsmiSave";
            tsmiSave.Size = new Size(114, 22);
            tsmiSave.Text = "Save As";
            tsmiSave.Click += tsmiSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1292, 553);
            Controls.Add(grpDimensions);
            Controls.Add(grpWallpapers);
            Controls.Add(menuStrip);
            Controls.Add(grpCustomerInfo);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Wallpaper Warehouse";
            grpCustomerInfo.ResumeLayout(false);
            grpCustomerInfo.PerformLayout();
            grpWallpapers.ResumeLayout(false);
            grpDimensions.ResumeLayout(false);
            grpDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpCustomerInfo;
        private TextBox txtFirstName;
        private TextBox txtAddr1;
        private TextBox txtAddr2;
        private TextBox txtLastName;
        private TextBox txtPostCode;
        private TextBox txtAddrTown;
        private ComboBox cmbCounty;
        private Button btnCustomer;
        private TextBox txtPhoneNum;
        private TextBox txtEmail;
        private Button btnClearInfo;
        private GroupBox grpWallpapers;
        private Button btnFaux;
        private Button btnPastel;
        private Button btnGeometry;
        private Button btnLines;
        private Button btnFlowers;
        private Button btnFeathers;
        private Button btnMarble;
        private Button btnBaubau;
        private Button btnPalazo;
        private Label lblPrice;
        private Label lblWallpaper;
        private ListBox lstCustError;
        private Label lblCheck;
        private Label lblSelectedPrice;
        private Label lblSelected;
        private GroupBox grpDimensions;
        private Label lblLength;
        private NumericUpDown numLength;
        private RadioButton rdoMetres;
        private NumericUpDown numHeight;
        private Label lblHeight;
        private NumericUpDown numWidth;
        private Label lblwidth;
        private RadioButton rdoFeet;
        private Label lblFinalPrice;
        private Button btnClearDims;
        private Label lblCost;
        private Button btnCalculate;
        private Label lblRollsRequired;
        private Label lblRolls;
        private Label lblSurfArea;
        private Label lblArea;
        private Label picSelected;
        private MenuStrip menuStrip;
        private ToolStripMenuItem mItemFile;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiSave;
    }
}