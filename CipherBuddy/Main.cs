using CipherBuddy.Engine.Encrypt;

namespace CipherBuddy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void DecryptFile_Click(object sender, EventArgs e)
        {

            string inputFileName = textBox3.Text;
            string outputFileName = textBox4.Text;

            string privateKeyFileName = textBox2.Text;
            string passPhrase = textBox5.Text;

            bool shouldArmor = false;
            bool shouldCheckIntegrity = false;

         


            PGPEncryptDecrypt.Decrypt(inputFileName,
                          privateKeyFileName,
                          passPhrase,
                          outputFileName);
        }

        private void EncryptFile_Click_1(object sender, EventArgs e)
        {

            string outputFileName = textBox4.Text+@"\output.pgp";

            string Publickey = textBox1.Text;
            string inputFileName = textBox3.Text;

            string privateKeyFileName = textBox2.Text;
            string passPhrase = textBox5.Text;

            bool shouldArmor = false;
            bool shouldCheckIntegrity = false;

           

            PGPEncryptDecrypt.EncryptFile(inputFileName,
                              outputFileName,
                              Publickey,
                              shouldArmor,
                              shouldCheckIntegrity);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Public key File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "asc",
                Filter = "txt or asc files (*.asc)|*.acs",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.asc)|*.asc",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = false,
                CheckPathExists = true,

                FilterIndex = 2,
                RestoreDirectory = true,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
            }
        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}