namespace EventDrivenProgramming
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// List of controls used to validate and operate on customer information (name, address, etc.).
        /// </summary>
        private readonly List<Control> custInfo = new();

        /// <summary>
        /// List of labels that can be safely cleared to change shown information.0
        /// </summary>
        private readonly List<Control> clearableLbls = new();

        /// <summary>
        /// List of Wallpapers available to the user.
        /// </summary>
        private readonly List<Wallpaper> Wallpapers = new();

        /// <summary>
        /// Wallpaper selected by user.
        /// </summary>
        private Wallpaper? userSelected;

        public Form1()
        {
            InitializeComponent();

            //Add each control related to customer information.
            custInfo.AddRange(new List<Control>()
            {
                txtFirstName,
                txtLastName,
                txtAddr1,
                txtAddr2,
                txtAddrTown,
                cmbCounty,
                txtPostCode,
                txtEmail,
                txtPhoneNum
            });

            //Add each label that can be safely cleared.
            clearableLbls.AddRange(new List<Control>()
            {
                lblSurfArea,
                lblRollsRequired,
                lblFinalPrice,
                lblSelected,
                lblSelectedPrice
            });

            //Add available wallpapers.
            Wallpapers.AddRange(new Wallpaper[]
            {
                new()
                {
                    Name = "Palazo",
                    Price = 9.99M,
                    AssignedBtn = btnPalazzo
                },

                new()
                {
                    Name = "Baubau",
                    Price = 7.99M,
                    AssignedBtn = btnBaubau
                },

                new()
                {
                    Name = "Blue Marble",
                    Price = 12.99M,
                    AssignedBtn = btnMarble
                },

                new()
                {
                    Name = "Feathers",
                    Price = 8.49M,
                    AssignedBtn = btnFeathers
                },

                new()
                {
                    Name = "Flowers",
                    Price = 10.49M,
                    AssignedBtn = btnFlowers
                },

                new()
                {
                    Name = "Lines",
                    Price = 5.99M,
                    AssignedBtn = btnLines
                },

                new()
                {
                    Name = "Geometry",
                    Price = 6.09M,
                    AssignedBtn = btnGeometry
                },

                new()
                {
                    Name = "Pastel",
                    Price = 8.99M,
                    AssignedBtn = btnPastel
                },

                new()
                {
                    Name = "Faux",
                    Price = 6.89M,
                    AssignedBtn = btnFaux
                }
            });

        }

        /// <summary>
        /// Event handler for btnCustomer. Checks all controls have data.
        /// </summary>
        /// <param name="sender">Event caller</param>
        /// <param name="e">Event Arguments</param>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            int reqEntries = custInfo.Count; //Set number of entries with required data to the number of entries in 'custInfo'.

            //Missing information ListBox and Label are displayed.
            if (lstCustError.Visible && lblCheck.Visible)
            {
                lstCustError.Visible = false; //Hide ListBox.
                lblCheck.Visible = false; //Hide Label.
            }

            //Iterate through each control in the custInfo list.
            foreach (Control ctrl in custInfo)
            {
                //ctrl is a Textbox
                if (ctrl is TextBox box)
                {
                    lstCustError.Items.Remove(box.PlaceholderText); //Remove the value in ListBox that is equal to the placeholder text of the control.

                    //TextBox is empty.
                    if (box.Text == "")
                    {
                        lstCustError.Visible = true; //Display missing information Label.
                        lblCheck.Visible = true; //Display missing information ListBox.
                        lstCustError.Items.Add(box.PlaceholderText); //Add missing information to ListBox.
                    }
                    else //TextBox has a value.
                        reqEntries--; //Reduce required entries by 1.
                }
                else if (ctrl is ComboBox comboBox) //ctrl is ComboBox
                {
                    lstCustError.Items.Remove("County"); //Remove "county" item from ListBox

                    if (comboBox.SelectedIndex == -1) //User has not selected an item from county ComboBox.
                    {
                        lstCustError.Visible = true; //Display missing information ListBox.
                        lblCheck.Visible = true; //Display missing information Label.
                        lstCustError.Items.Add("County"); //Add "county" to ListBox.
                    }
                    else //User has selected an item in ComboBox.
                        reqEntries--; //Reduce required entries by 1.
                }
            }

            if (reqEntries <= 0)
                grpDimensions.Enabled = true;
        }

        /// <summary>
        /// Event handler for btnClearInfo and btnClearDims. Resets each control to default (excluding heading labels; lblArea, lblRolls, etc.).
        /// </summary>
        /// <param name="sender">Event caller</param>
        /// <param name="e">Event Arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Cast sender to button.
            Button btnClear = (Button)sender;

            //Loop through each control in the parent GroupBox.
            foreach (Control ctrl in btnClear.Parent.Controls)
            {
                switch (ctrl)
                {
                    //ctrl is a TextBox or ComboBox.
                    case TextBox or ComboBox:
                        ctrl.Text = null; //Clear text.
                        break;
                    //ctrl is ListBox.
                    case ListBox lst:
                        lst.Items.Clear(); //Clear ListBox.
                        lst.Visible = false; //Hide ListBox.
                        break;
                    //ctrl is NumericUpDown.
                    case NumericUpDown num:
                        num.Value = 0; //Reset value to 0.
                        break;
                    //ctrl is a Label within clearableLbls.
                    case Label lbl when clearableLbls.Contains(lbl):
                        lbl.Text = null; //Clear Label.
                        picSelected.Image = null; //Clear Control displaying userSelected wallpaper.
                        userSelected = null; //Clear userSelected (user no longer has a chosen wallpaper).
                        break;
                    //ctrl is the 'Please check the following' Label.
                    case Label lbl when lbl == lblCheck:
                        lbl.Visible = false; //Hide Label.
                        break;
                    //Fall-through for everything else.
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Event handler for btnWallpaper. Calls UpdateWallpaperFields to reset clearable controls in GroupBox.
        /// </summary>
        /// <param name="sender">Event Caller</param>
        /// <param name="e">Event Arguments</param>
        private void btnWallpaper_Click(object sender, EventArgs e)
        {
            //Loop through all Wallpapers selecting the one whose AssignedBtn equals the sender.
            foreach (var wall in from Wallpaper wall in Wallpapers
                                 where wall.AssignedBtn == (Button)sender
                                 select wall)
            {
                UpdateWallpaperFields(wall); //Pass matching Wallpaper to method.
            }
        }

        /// <summary>
        /// Used to update all controls in grpDimensions relating to the user's selected wallpaper.
        /// </summary>
        /// <param name="wall">Wallpaper to display</param>
        private void UpdateWallpaperFields(Wallpaper? wall)
        {
            lblSelected.Text = wall!.Name; //Set lblSelected to show chosen wallpaper name.
            lblSelectedPrice.Text = "£" + wall.Price.ToString(); //Shows price of chosen wallpaper.
            picSelected.Image = wall.AssignedBtn!.Image; //Display chosen wallpaper.
            userSelected = wall; //Set userSelected to chosen wallpaper.
        }

        /// <summary>
        /// Called by btnCalculate to calculate total surface area, rolls required and total price.
        /// </summary>
        /// <param name="sender">Event Caller</param>
        /// <param name="e">Event Arguments</param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Calls Calculate with values from the NumericUpDown controls, with the selected RadioButton.
            Calculate(numLength.Value, numWidth.Value, numHeight.Value, rdoFeet.Checked);
        }

        /// <summary>
        /// Calculates total surface area, number of rolls required and total price.
        /// </summary>
        /// <param name="length">Room Length</param>
        /// <param name="width">Room Width</param>
        /// <param name="height">Room Height</param>
        /// <param name="rdo">Selected RadioButton</param>
        private void Calculate(decimal length, decimal width, decimal height, bool rdo)
        {
            //Total surface area of the room.
            decimal surfaceArea = (2 * length * height) + (2 * width * height);
            
            //Stores number of rolls required to cover the room.
            decimal numRolls;

            //Default unit of measurement (metres)
            string unit = "m";

            //RadioButton is checked (Feet selected).
            if (rdo)
            {
                //Calculate number of required rolls by dividing surface area by Wallpaper area in feet.
                numRolls = surfaceArea / (Wallpaper.AREA * 10.76391M);

                //Set unit of measurement to feet.
                unit = "ft";
            }
            //RadioButton rdoMetres is checked.
            else
                //Calculate number of rolls required when surface area is in metres.
                numRolls = surfaceArea / Wallpaper.AREA;

            //
            numRolls = Math.Ceiling(numRolls);

            lblSurfArea.Text = surfaceArea.ToString() + unit;
            lblRollsRequired.Text = numRolls.ToString();

            if (userSelected != null)
                lblFinalPrice.Text = "£" + Math.Round((decimal)(userSelected.Price * numRolls)!, 2).ToString();
            else
                lblFinalPrice.Text = "Please select a wallpaper.";
        }

        private void numSize_Focus(object sender, EventArgs e)
        {
            NumericUpDown numSize = (NumericUpDown)sender;
            numSize.Select(0, numSize.Text.Length);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OrderData? orderData = JSONFiles.OpenJSONFILE()!;

            if (orderData != null)
            {
                custInfo[0].Text = orderData.FirstName;
                custInfo[1].Text = orderData.LastName;
                custInfo[2].Text = orderData.Addr1;
                custInfo[3].Text = orderData.Addr2;
                custInfo[4].Text = orderData.Town;
                custInfo[5].Text = orderData.County;
                custInfo[6].Text = orderData.Postcode;
                custInfo[7].Text = orderData.Email;
                custInfo[8].Text = orderData.PhoneNum;

                numLength.Value = orderData.length;
                numWidth.Value = orderData.width;
                numHeight.Value = orderData.height;
                rdoMetres.Checked = !orderData.rdo;
                rdoFeet.Checked = orderData.rdo;

                foreach (var w in from Wallpaper w in Wallpapers 
                                  where orderData.wallpaper == w.Name 
                                  select w)
                {
                    UpdateWallpaperFields(w);
                }

                Calculate(orderData.length, orderData.width, orderData.height, orderData.rdo);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (userSelected != null)
            {
                OrderData? orderData = new()
                {
                    FirstName = custInfo[0].Text,
                    LastName = custInfo[1].Text,
                    Addr1 = custInfo[2].Text,
                    Addr2 = custInfo[3].Text,
                    Town = custInfo[4].Text,
                    County = custInfo[5].Text,
                    Postcode = custInfo[6].Text,
                    Email = custInfo[7].Text,
                    PhoneNum = custInfo[8].Text,
                    wallpaper = userSelected!.Name,
                    length = numLength.Value,
                    width = numWidth.Value,
                    height = numHeight.Value,
                    rdo = rdoFeet.Checked
                };

                JSONFiles.SaveJSONFile(orderData);
            }
            else
            {
                string msg = "Please ensure all information has been entered.";
                string caption = "Error: Missing information";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(msg, caption, messageBoxButtons);
            }
        }
    }
}