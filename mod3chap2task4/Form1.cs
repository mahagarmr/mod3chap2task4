namespace mod3chap2task4
{
    public partial class Form1 : Form
    {
        private string filePath;
        private string word;

        public Form1()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please select a file and enter a word to search for.");
                return;
            }

            searchButton.Enabled = false;

            try
            {
                int count = await SearchFileAsync(filePath, word);
                MessageBox.Show($"The word '{word}' was found {count} times in the file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching the file: {ex.Message}");
            }

            searchButton.Enabled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                fileLabel.Text = filePath;
            }
        }

        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            word = wordTextBox.Text;
        }

        private async Task<int> SearchFileAsync(string filePath, string word)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    count += CountOccurrences(line, word);
                }
            }

            return count;
        }

        private int CountOccurrences(string line, string word)
        {
            int count = 0;
            int index = line.IndexOf(word);

            while (index != -1)
            {
                count++;
                index = line.IndexOf(word, index + 1);
            }

            return count;
        }
    }
}