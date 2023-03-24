using ImageMagick;

namespace ConvertImage
{
    public partial class Form1 : Form
    {

        public string [] selectHEICFile;
        public string [] convertNewFiles;
        public string destinationFolder;
        public string oldFolder;
        public string newFile;
        public int imageNumber;

        public List <string> DesFiles;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < textBox3.Lines.Length-1; i++)
            {

                convertNewFiles = textBox3.Lines;
                //textBox4.Text = convertNewFiles[i];

                using (MagickImage image = new MagickImage(selectHEICFile[i]))
                {

                    image.Write(convertNewFiles[i]);
                }
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            try { 
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    string[] folder = Directory.GetFiles(fbd.SelectedPath);
                        oldFolder = fbd.SelectedPath;
                    selectHEICFile = Directory.GetFiles(fbd.SelectedPath, "*.heic");

                    textBox1.Text = selectHEICFile.Length.ToString();
                    imageNumber = selectHEICFile.Length;
                        //textBox2.Text = textBox2.Text + fbd.SelectedPath;
                        for (int i = 0; i < selectHEICFile.Length ; i++)
                        {
                            //convertNewFiles = selectHEICFile[i].ToString().Replace(fbd.SelectedPath + @"\", "");
                            textBox2.Text = textBox2.Text + selectHEICFile[i].ToString().Replace(fbd.SelectedPath+@"\", "") + Environment.NewLine;
                        }


                }
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.StackTrace);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectDes_Click(object sender, EventArgs e)
        {
            using (var desFolder = new FolderBrowserDialog())
            {
                DialogResult result = desFolder.ShowDialog();
                
                List<string> DesFiles = new List<string>();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(desFolder.SelectedPath))
                {
                    //string[] aa = textBox2.Text.Split(new char[] { '\u002C' });
                    string [] aa = textBox2.Lines;
                    
                    for (int i = 0;i < textBox2.Lines.Length-1;i++)
                        //textBox2.Text = textBox2.Lines.Length.ToString();
                    //destinationFolder = desFolder.SelectedPath;
                    {
                        
                        textBox3.Text = textBox3.Text+ desFolder.SelectedPath+@"\"+aa[i].Replace(".heic",".jpg")+Environment.NewLine;
                        
                        //textBox2.Text = (aa[i]+ desFolder.SelectedPath);
                        //DesFiles.Add(aa[i] + desFolder.SelectedPath);

                        //textBox2.Text = textBox2.Lines.Length.ToString();
                    }

                    //foreach (string desFile in DesFiles)
                    //{
                        //textBox2.Text = desFile+"aaaaaaaaa"+Environment.NewLine;
                    //}
                    //textBox2.Text = desFolder.SelectedPath+ convertNewFiles[i];
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}