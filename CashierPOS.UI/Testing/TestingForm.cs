
namespace CashierPOS.UI.Testing
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    string filePath = openFileDialog.FileName;

                    // Load the image into the PictureBox
                    pictureboxDriver.Image = Image.FromFile(filePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureboxDriver.Image != null)
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureboxDriver.Image.Save(ms, pictureboxDriver.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
                var tt = imageBytes;

                // Store to database
                // .............


                // for get image from database. use when update to list imgae 
                getImageFromDatabase(imageBytes);

            }
        }

        private void getImageFromDatabase(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                var stringImg = Image.FromStream(ms);
                pictureBoxGetBack.Image = stringImg;
            }
        }
    }
}