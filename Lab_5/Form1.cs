using System;
using System.IO;
using System.Windows.Forms;

namespace Lab_5
{
    
    public class INIReader {
        private Stream stream;
        public INIReader(Stream aStream)
        {
            stream = aStream;
        }
    }
    public partial class BlockEditor : Form
    {
        public BlockEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Renas\\source\\repos\\Lab_5";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();
                
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    
                    int countBlock = 0;
                    while (!reader.EndOfStream)
                    {
                        String str = reader.ReadLine();
                        if (str.Contains("[\"")&& str.Contains("\"]"))
                        {
                            countBlock++;
                        }
                    }
                    filePathTextBox.Text = countBlock.ToString();
                }
                
            }
        }

        private void AddBlockBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBlockBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditFieldBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
