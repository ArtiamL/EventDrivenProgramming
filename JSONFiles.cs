using System.Text.Json;

namespace EventDrivenProgramming;

/// <summary>
/// Provides values to store data for JSON serialization.
/// </summary>
internal class OrderData
{
    public string? FirstName { get; set; } //Customer first name.
    public string? LastName { get; set; } //Customer last name.
    public string? Addr1 { get; set; } //Customer address line 1.

    public string? Addr2 { get; set; } //Customer address line 2.
    public string? Town { get; set; } //Customer town.
    public string? County { get; set; } //Customer county.
    public string? Postcode { get; set; } //Customer postcode.
    public string? Email { get; set; } //Customer email.
    public string? PhoneNum { get; set; } //Customer phone number.

    public string? wallpaper { get; set; } //Customer's selected wallpaper.

    public decimal length { get; set; } //Length of customer room.
    public decimal width { get; set; } //Width of customer room.
    public decimal height { get; set; } //Height of customer room .
    public bool rdo { get; set; } //Selected RadioButton
}

internal class JSONFiles
{
    /// <summary>
    /// Serializes data into JSON file.
    /// </summary>
    /// <param name="customerData">Data to serialize.</param>
    /// <exception cref="NullReferenceException">Thrown if customerData is null</exception>
    public static void SaveJSONFile(OrderData customerData)
    {
        if (customerData == null)
            throw new NullReferenceException();

        //Create save file dialogue for saving data.
        SaveFileDialog saveFileDialog = new SaveFileDialog()
        {
            InitialDirectory = @".\orders\", //Starting directory of dialog.
            Filter = "JSON Files|*.json", //File format filter.
            DefaultExt = "json", //Default extension format.
            Title = "Save new customer", //Title of dialogue.
            RestoreDirectory = true, //Restores previous directory if different from initial.
            CheckPathExists = true, //Ensures path exists before saving.
        };

        //Show dialogue. When "OK" is pressed, serialize and save file.
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filename = saveFileDialog.FileName; //Store user's filename.
            string json = JsonSerializer.Serialize(customerData); //Serialize data into JSON format.
            File.WriteAllText(filename, json); //Write to file.
        }
    }

    /// <summary>
    /// Deserializes JSON file and returns OrderData object.
    /// </summary>
    /// <returns>Deserialized JSON as OrderData object.</returns>
    public static OrderData? OpenJSONFILE()
    {
        //Create open file dialogue for opening a file.
        OpenFileDialog openFileDialog = new()
        {
            InitialDirectory = @".\orders\", //Starting directory.
            Filter = "JSON Files|*.json", //File format filter.
            DefaultExt ="json", //Default extension format.
            Title = "Open order", //Dialogue title.
            RestoreDirectory = true, //Restores previous directory if different from initial.
            CheckFileExists = true, //Ensures file exists before opening.
            CheckPathExists = true, //Ensures path exists before opening.
        };

        ////Show dialogue. When "OK" is pressed, open file and deserialize data.
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filename = openFileDialog.FileName; //Store user's filename.
            string json = File.ReadAllText(filename); //Deserialize data from JSON format.
            try
            {
                return JsonSerializer.Deserialize<OrderData?>(json)!; //Return deserialized data as OrderData object.
            }
            catch (JsonException je)
            {
                string msg = "There was an error reading the file:\n" + je.Message.ToString();    //Set error message to be displayed.
                string caption = "Error: Invalid format";  //Set title of error message box.
                MessageBox.Show(msg, caption, MessageBoxButtons.OK);    //Show error message box on screen.
            }
        }

        return null;    //OrderData cannot be generated correctly.
    }
}
