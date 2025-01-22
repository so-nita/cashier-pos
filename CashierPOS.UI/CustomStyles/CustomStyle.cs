using Microsoft.IdentityModel.Tokens;

namespace CashierPOS.UI.CustomStyles
{
    public class CustomStyle 
    {

        #region Formate phone number as 0123456789 -> 012 345 6789
        public static string FormatPhoneNumber(string input)
        {
            // Remove any non-numeric characters from the input
            string numericInput = new string(input.Where(char.IsDigit).ToArray());
            // Check if the input has more than 3 characters
            if (numericInput.Length > 3)
            {
                // Insert spaces at appropriate positions
                numericInput = numericInput.Insert(3, " ");
                if (numericInput.Length > 7)
                {
                    numericInput = numericInput.Insert(7, " ");
                }
            }
            // Prepend '0' if it's missing and ensure it doesn't start with multiple zeros
            if (numericInput.StartsWith("0"))
            {
                // If the number starts with multiple zeros, remove the extra zeros
                numericInput = "0" + numericInput.TrimStart('0');
            }
            else if (numericInput.Length > 0)
            {
                // Ensure the number starts with '0'
                numericInput = "0" + numericInput;
            }
            return numericInput;
        }

        #endregion


        #region Formate Currency number as 1000000 to 1,000,000 $
        public static string FormatAmountCurrency(string input, string currency = null!)
        {
            // Remove any non-numeric characters from the input
            string numericInput = new string(input.Where(char.IsDigit).ToArray());
            // Check if input is not empty and parse it as an integer
            if (!string.IsNullOrWhiteSpace(numericInput) && int.TryParse(numericInput, out int amount))
            {
                // Convert the integer amount to a formatted string with comma separators
                string formattedAmount = amount.ToString("#,##0").Trim();
                // Add "$" or "រ" sign to the formatted amount
                if (currency?.Trim() == "$")
                {
                    var currency_ = "$ ";
                    return currency_ += formattedAmount;
                }
                if(currency.IsNullOrEmpty())
                {
                    return formattedAmount;
                }
                //formattedAmount += currency;
                return formattedAmount += " ​៛";
            }
            
            return input; // Return input unchanged if it's empty or not a valid number
        }
        #endregion


        #region Round Up for Currecy KH ex: 4150 to 4200
        public static decimal RoundUpCurrencyKh(decimal value)
        {
            // Calculate the remainder when dividing by 100
            decimal remainder = value % 100;

            // If the remainder is greater than 0, round up to the next multiple of 1000
            if (remainder > 0)
            {
                value += 100 - remainder;
            }
            return value;
        }

        #endregion


        #region Round Down for Currency KH ex: 4150 to 4100
        public static decimal RoundDownCurrencyKh(decimal value)
        {
            // Calculate the remainder when dividing by 100
            decimal remainder = value % 100;

            // If the remainder is greater than 0, round down to the previous multiple of 100
            if (remainder > 0)
            {
                value -= remainder;
            }
            return value;
        }
        #endregion



        #region Convert String To Decimal that include the currency letter 
        public static decimal ConvertStringToDecimal(string value, string stringReplace)
        {
            /*if (stringReplace == "រ" || stringReplace == "៛")
            {
                stringReplace = "៛";
            }*/
            string cleanedValue = value.Trim().Replace(stringReplace.Trim(), "");
            return (decimal.TryParse(cleanedValue, out decimal result)) ? result : 0;
        }

        #endregion


        #region Validation input only Number
        public static void ValidationNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion


        #region Validation input only Text
        public static void ValidationTextOnly(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion


        #region Validation input only Email
        public static void ValidationEmailOnly(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                var email = textBox.Text.Trim();
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
                {
                    MessageBox.Show("Valid email address");
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        #region Convert from string to Image 
        private static string DefaultImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTl20Tuf0ZhpbNa24X1Kaw3NgZ1Rhy2bdbkGw&usqp=CAU";
        /*// Get Image 
        public static async Task<Image> GetImageFromUrl(string url)
        {
            HttpClient client = new HttpClient();
            try
            {
                byte[] imageBytes = await client.GetByteArrayAsync(url);

                var stream = new MemoryStream(imageBytes);
                return Image.FromStream(stream);
            }
            catch  
            {
                byte[] imageBytes = await client.GetByteArrayAsync(DefaultImage);

                var stream = new MemoryStream(imageBytes);
                return Image.FromStream(stream);
            }
        }*/
        private static HttpClient _httpClient = new HttpClient();
        //--private static string _imgaeBaseUrl = "http://172.26.16.113:8082/";
        private static string _imgaeBaseUrl = "http://10.2.3.2:3060/";
        public static async Task<Image> GetImageFromUrl(string url)
        {
            try
            {
                var image = _imgaeBaseUrl + url;
                if (string.IsNullOrEmpty(url))
                {
                    return await GetDefaultImage();
                }
                using (HttpResponseMessage response = await _httpClient.GetAsync(image/*url*/))
                {
                    response.EnsureSuccessStatusCode();
                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    {
                        try
                        {
                            return Image.FromStream(stream);
                        }
                        catch
                        {
                            return await GetDefaultImage();
                        }
                    }
                }
            }
            catch (HttpRequestException)
            {
                return await GetDefaultImage();
            }
        }
        private static async Task<Image> GetDefaultImage()
        {
            byte[] imageBytes = await _httpClient.GetByteArrayAsync(DefaultImage);
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(stream);
            }
        }
        #endregion


        public static void AttachDynamicKeyEvent(TextBox sourceTextBox, Control destinationTextBox)
        {
            sourceTextBox.KeyDown += (sender, e) => HandleDynamicKeyEvent(sender!, e, destinationTextBox);
        }

        private static void HandleDynamicKeyEvent(object sender, KeyEventArgs e, Control nextTextBox)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                MoveFocus(nextTextBox);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                MoveFocus(nextTextBox);
                e.Handled = true;
            }
        }
        private static void MoveFocus(Control nextControl)
        {
            nextControl?.Focus();
        }

        public static void OnMouseHover_Placeholder(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text != textBox.Tag?.ToString())
                {
                    textBox.ForeColor = Color.Black;
                    var text = textBox.Text;
                    textBox.Text = text;
                }
            }
        }

        public static void OnMouseLeave_Placeholder(object sender, EventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if (textBox.Text == "")
                {
                    textBox.Text = textBox.Tag?.ToString();
                    textBox.ForeColor = Color.DarkGray;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                }
            }
        }
    }
}
