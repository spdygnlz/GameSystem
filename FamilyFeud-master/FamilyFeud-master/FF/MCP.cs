using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace FF
{
    public partial class MCP : Form
    {
        FFBigBoard mainform = new FFBigBoard();
        SoundPlayer bell = new SoundPlayer("data\\sound\\bell.wav");
        SoundPlayer buzzer = new SoundPlayer("data\\sound\\buzzer.wav");

        public MCP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument XmlReader = new XmlDocument();

            try
            {
                XmlReader.Load("text.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show(null, "No survey XML files were found in data\\rounds\\normal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {
                XmlNodeList XmlAnswer1 = XmlReader["Answers"]["Answer1"].GetElementsByTagName("Name");
                XmlNodeList XmlValue1 = XmlReader["Answers"]["Answer1"].GetElementsByTagName("Value");
                Answer1.Text = XmlAnswer1[0].InnerText;
                Value1.Text = XmlValue1[0].InnerText;
                mainform.BBAnswer1.Image = Image.FromFile("data\\gfx\\1.png");
                Answer1.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer1.Enabled = false;
                mainform.BBAnswer1.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer2 = XmlReader["Answers"]["Answer2"].GetElementsByTagName("Name");
                XmlNodeList XmlValue2 = XmlReader["Answers"]["Answer2"].GetElementsByTagName("Value");
                Answer2.Text = XmlAnswer2[0].InnerText;
                Value2.Text = XmlValue2[0].InnerText;
                mainform.BBAnswer2.Image = Image.FromFile("data\\gfx\\2.png");
                Answer2.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer2.Enabled = false;
                mainform.BBAnswer2.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer3 = XmlReader["Answers"]["Answer3"].GetElementsByTagName("Name");
                XmlNodeList XmlValue3 = XmlReader["Answers"]["Answer3"].GetElementsByTagName("Value");
                Answer3.Text = XmlAnswer3[0].InnerText;
                Value3.Text = XmlValue3[0].InnerText;
                mainform.BBAnswer3.Image = Image.FromFile("data\\gfx\\3.png");
                Answer3.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer3.Enabled = false;
                mainform.BBAnswer3.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer4 = XmlReader["Answers"]["Answer4"].GetElementsByTagName("Name");
                XmlNodeList XmlValue4 = XmlReader["Answers"]["Answer4"].GetElementsByTagName("Value");
                Answer4.Text = XmlAnswer4[0].InnerText;
                Value4.Text = XmlValue4[0].InnerText;
                mainform.BBAnswer4.Image = Image.FromFile("data\\gfx\\4.png");
                Answer4.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer4.Enabled = false;
                mainform.BBAnswer4.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer5 = XmlReader["Answers"]["Answer5"].GetElementsByTagName("Name");
                XmlNodeList XmlValue5 = XmlReader["Answers"]["Answer5"].GetElementsByTagName("Value");
                Answer5.Text = XmlAnswer5[0].InnerText;
                Value5.Text = XmlValue5[0].InnerText;
                mainform.BBAnswer5.Image = Image.FromFile("data\\gfx\\5.png");
                Answer5.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer5.Enabled = false;
                mainform.BBAnswer5.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer6 = XmlReader["Answers"]["Answer6"].GetElementsByTagName("Name");
                XmlNodeList XmlValue6 = XmlReader["Answers"]["Answer6"].GetElementsByTagName("Value");
                Answer6.Text = XmlAnswer6[0].InnerText;
                Value6.Text = XmlValue6[0].InnerText;
                mainform.BBAnswer6.Image = Image.FromFile("data\\gfx\\6.png");
                Answer6.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer6.Enabled = false;
                mainform.BBAnswer6.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer7 = XmlReader["Answers"]["Answer7"].GetElementsByTagName("Name");
                XmlNodeList XmlValue7 = XmlReader["Answers"]["Answer7"].GetElementsByTagName("Value");
                Answer7.Text = XmlAnswer7[0].InnerText;
                Value7.Text = XmlValue7[0].InnerText;
                mainform.BBAnswer7.Image = Image.FromFile("data\\gfx\\7.png");
                Answer7.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer7.Enabled = false;
                mainform.BBAnswer7.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer8 = XmlReader["Answers"]["Answer8"].GetElementsByTagName("Name");
                XmlNodeList XmlValue8 = XmlReader["Answers"]["Answer8"].GetElementsByTagName("Value");
                Answer8.Text = XmlAnswer8[0].InnerText;
                Value8.Text = XmlValue8[0].InnerText;
                mainform.BBAnswer8.Image = Image.FromFile("data\\gfx\\8.png");
                Answer8.Enabled = true;
            }
            catch(NullReferenceException)
            {
                Answer8.Enabled = false;
                mainform.BBAnswer8.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer9 = XmlReader["Answers"]["Answer9"].GetElementsByTagName("Name");
                XmlNodeList XmlValue9 = XmlReader["Answers"]["Answer9"].GetElementsByTagName("Value");
                Answer9.Text = XmlAnswer9[0].InnerText;
                Value9.Text = XmlValue9[0].InnerText;
                mainform.BBAnswer9.Image = Image.FromFile("data\\gfx\\9.png");
                Answer9.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer9.Enabled = false;
                mainform.BBAnswer9.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer10 = XmlReader["Answers"]["Answer10"].GetElementsByTagName("Name");
                XmlNodeList XmlValue10 = XmlReader["Answers"]["Answer10"].GetElementsByTagName("Value");
                Answer10.Text = XmlAnswer10[0].InnerText;
                Value10.Text = XmlValue10[0].InnerText;
                mainform.BBAnswer10.Image = Image.FromFile("data\\gfx\\0.png");
                Answer10.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer10.Enabled = false;
                mainform.BBAnswer10.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {

                XmlNodeList XmlAnswer11 = XmlReader["Answers"]["Answer11"].GetElementsByTagName("Name");
                XmlNodeList XmlValue11 = XmlReader["Answers"]["Answer11"].GetElementsByTagName("Value");
                Answer11.Text = XmlAnswer11[0].InnerText;
                Value11.Text = XmlValue11[0].InnerText;
                mainform.BBAnswer11.Image = Image.FromFile("data\\gfx\\11.png");
                Answer11.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer11.Enabled = false;
                mainform.BBAnswer11.Image = Image.FromFile("data\\gfx\\0.png");
            }

            try
            {
                XmlNodeList XmlAnswer12 = XmlReader["Answers"]["Answer12"].GetElementsByTagName("Name");
                XmlNodeList XmlValue12 = XmlReader["Answers"]["Answer12"].GetElementsByTagName("Value");

                Answer12.Text = XmlAnswer12[0].InnerText;
                Value12.Text = XmlValue12[0].InnerText;
                mainform.BBAnswer12.Image = Image.FromFile("data\\gfx\\12.png");
                Answer12.Enabled = true;
            }
            catch (NullReferenceException)
            {
                Answer12.Enabled = false;
                mainform.BBAnswer12.Image = Image.FromFile("data\\gfx\\0.png");
            }
        }

        /* All hardcoded references to data\rounds\normal are TEMPORARY,
         * they will be replaced with XML nodes in a later version */

        private void Answer1_Click(object sender, EventArgs e)
        {
            SoundPlayer fastbell = new SoundPlayer("data\\sound\\fastbell.wav");
            fastbell.Play();

            mainform.BBAnswer1.Image = Image.FromFile("data\\rounds\\normal\\1.png");
            Answer1.Enabled = false;
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer2.Image = Image.FromFile("data\\rounds\\normal\\2.png");
            Answer2.Enabled = false;
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer3.Image = Image.FromFile("data\\rounds\\normal\\3.png");
            Answer3.Enabled = false;
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer4.Image = Image.FromFile("data\\rounds\\normal\\4.png");
            Answer4.Enabled = false;
        }

        private void Answer5_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer5.Image = Image.FromFile("data\\rounds\\normal\\5.png");
            Answer5.Enabled = false;
        }

        private void Answer6_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer6.Image = Image.FromFile("data\\rounds\\normal\\6.png");
            Answer6.Enabled = false;
        }

        private void Answer7_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer7.Image = Image.FromFile("data\\rounds\\normal\\7.png");
            Answer7.Enabled = false;
        }

        private void Answer8_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer8.Image = Image.FromFile("data\\rounds\\normal\\8.png");
            Answer8.Enabled = false;
        }

        private void Answer9_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer9.Image = Image.FromFile("data\\rounds\\normal\\9.png");
            Answer9.Enabled = false;
        }

        private void Answer10_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer10.Image = Image.FromFile("data\\rounds\\normal\\10.png");
            Answer10.Enabled = false;
        }

        private void Answer11_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer11.Image = Image.FromFile("data\\rounds\\normal\\11.png");
            Answer11.Enabled = false;
        }

        private void Answer12_Click(object sender, EventArgs e)
        {
            bell.Play();

            mainform.BBAnswer12.Image = Image.FromFile("data\\rounds\\normal\\12.png");
            Answer12.Enabled = false;
        }

        private void StrikeSound_Click(object sender, EventArgs e)
        {
            buzzer.Play();

            mainform.StrikeOutbox.Image = Image.FromFile("data\\gfx\\strike1.png");
            mainform.StrikeDisplayTimer.Enabled = true;
        }

        private void MCP_Load(object sender, EventArgs e)
        {       
            mainform.Show();
        }
    }
}
