using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using QualcommQCNFileEditor.Properties;
using System.Globalization;

namespace QualcommQCNFileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " v" + Application.ProductVersion;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            richTextBox1.Visible = false;
        }

        OpenFileDialog FDsource = new OpenFileDialog();
        SaveFileDialog SFdestination = new SaveFileDialog();

        private void SelectBTN_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            TxtSource.Text = "";
            FDsource.Filter = "QCN Files (*.qcn)|*.qcn|All Files (*.*)|*.*";
            FDsource.FilterIndex = 1;
            FDsource.RestoreDirectory = true;

            if (FDsource.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Text = FDsource.FileName;

                QCNread(TxtSource.Text);

                imei1.Text = IMEI_fixing(label3.Text, imei1.Text);

                /* In the selected QCN File,
                 * If only IMEI appears to be registered
                 * If there are characters other than numbers in the IMEI-1 field, let's leave it blank.
                */
               bool status = true;
                string numbers = IMEI_fixing(label4.Text, imei2.Text);

                foreach (char chr in numbers)
                {
                    if (!Char.IsNumber(chr))
                        status = false;
                }

                if (status == false)
                {
                    imei2.Text = "";
                }
                else
                {
                    imei2.Text = IMEI_fixing(label4.Text, imei2.Text);
                }
            }
        }

        private void SingleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SingleRB.Checked == true)
            {
                imei1.Enabled = true;
                imei2.Enabled = false;
                imei2.Text = "";
            }
        }

        private void DualRB_CheckedChanged(object sender, EventArgs e)
        {
            if (DualRB.Checked == true)
            {
                imei1.Enabled = true;
                imei2.Enabled = true;

                /*
                 * When Making Single and Double Selection
                 * IMEI Boxes
                 * Refill ...
                */

                if (label3.Text.Length == 16 && label4.Text.Length == 16)
                {
                    imei1.Text = IMEI_fixing(label3.Text, imei1.Text);

                    bool status = true;
                    string numbers = IMEI_fixing(label4.Text, imei2.Text);

                    foreach (char chr in numbers)
                    {
                        if (!Char.IsNumber(chr))
                            status = false;
                    }

                    if (status == false)
                    {
                        imei2.Text = "";
                    }
                    else
                    {
                        imei2.Text = IMEI_fixing(label4.Text, imei2.Text);
                    }
                }

                /****/

            }
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {

            SFdestination.Filter = "QCN Files (*.qcn)|*.qcn|All Files (*.*)|*.*";
            SFdestination.FilterIndex = 1;
            SFdestination.RestoreDirectory = true;

            if (SFdestination.ShowDialog() == DialogResult.OK && TxtSource.Text != "")
            {
                    if (DualRB.Checked == true && SingleRB.Checked == false)
                    {

                        if (imei1.Text!="" && imei2.Text!="" && IMEIControl(Convert.ToInt64(imei1.Text)) && IMEIControl(Convert.ToInt64(imei2.Text)))
                        {
                            DualSimReg();
                        }
                        else
                        {
                            MessageBox.Show("Missing or Wrong Number.!", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (DualRB.Checked == false && SingleRB.Checked == true)
                    {
                        if (IMEIControl(Convert.ToInt64(imei1.Text)))
                        {
                            SingleSimReg();
                        }
                        else
                        {
                            MessageBox.Show("Missing or Wrong Number.!", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
            else
            {
                MessageBox.Show("Please Fill In The Required Fields.!", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void DualSimReg()
        {

            string[] strArray1 = IMEIreverse(imei1.Text);
            string[] strArray2 = IMEIreverse(imei2.Text);

            BinaryReader binaryReader = new BinaryReader((Stream)File.Open(FDsource.FileName, FileMode.Open), Encoding.ASCII);
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(SFdestination.FileName, FileMode.Create), Encoding.ASCII);

            long num1 = (long)int.Parse(label5.Text); // pointer imei1
            long num2 = (long)int.Parse(label6.Text); // pointer imei2
            long num3 = binaryReader.BaseStream.Length; // pointer last this file

            try
            {
                do
                {
                    byte num4 = binaryReader.ReadByte();
                    binaryWriter.Write(num4);

                    if (binaryReader.BaseStream.Position == num1)
                    {
                        for (int index = 0; index < strArray1.Length; ++index)
                        {
                            binaryWriter.Write(byte.Parse(strArray1[index], NumberStyles.AllowHexSpecifier));
                        }
                        binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + strArray1.Length;
                    }
                    else if (binaryReader.BaseStream.Position == num2)
                    {
                        for (int index1 = 0; index1 < strArray2.Length; ++index1)
                        {
                            binaryWriter.Write(byte.Parse(strArray2[index1], NumberStyles.AllowHexSpecifier));
                        }
                        binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + strArray2.Length;
                    }
                }
                while (binaryReader.BaseStream.Position != num3);

            }
            catch (EndOfStreamException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                binaryReader.Close();
                binaryReader.Dispose();
                binaryWriter.Close();
                binaryWriter.Dispose();
                MessageBox.Show("Completed Successfully !", "Successful...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        void SingleSimReg()
        {

            string[] strArray1 = IMEIreverse(imei1.Text);
            string[] strArray2 = new string[15];

            for (int i = 0; i < 15; i++)
            {
                strArray2[i] = "00";
            }

            BinaryReader binaryReader = new BinaryReader((Stream)File.Open(FDsource.FileName, FileMode.Open), Encoding.ASCII);
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(SFdestination.FileName, FileMode.Create), Encoding.ASCII);

            long num1 = (long)int.Parse(label5.Text); // pointer imei1
            long num2 = (long)int.Parse(label6.Text) - 7; // pointer imei2
            long num3 = binaryReader.BaseStream.Length; // pointer last this file

            try
            {
                do
                {
                    byte num4 = binaryReader.ReadByte();
                    binaryWriter.Write(num4);

                    if (binaryReader.BaseStream.Position == num1)
                    {
                        for (int index = 0; index < strArray1.Length; ++index)
                        {
                            binaryWriter.Write(byte.Parse(strArray1[index], NumberStyles.AllowHexSpecifier));
                        }
                        binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + strArray1.Length; 
                    }
                    else if (binaryReader.BaseStream.Position == num2)
                    {
                        for (int index1 = 0; index1 < strArray2.Length; ++index1)
                        {
                            binaryWriter.Write(byte.Parse(strArray2[index1], NumberStyles.AllowHexSpecifier));
                        }
                        binaryReader.BaseStream.Position = binaryReader.BaseStream.Position + strArray2.Length;
                    }
                }
                while (binaryReader.BaseStream.Position != num3);

            }
            catch (EndOfStreamException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                binaryReader.Close();
                binaryReader.Dispose();
                binaryWriter.Close();
                binaryWriter.Dispose();
                MessageBox.Show("Completed Successfully !", "Successful...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public string[] IMEIreverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse((Array)charArray);
            string str = new string(charArray) + "A";

            string[] strArray = new string[8];

            int num = str.Length;
            int index = 0;
            if (num != 0)
            {
                do
                {
                    int startIndex = num - 2;
                    strArray[index] = str.Substring(startIndex, 2);
                    num = startIndex;
                    ++index;
                }
                while (num != 0);
            }
            return strArray;
        }

        void QCNread(string SourceQCN)
        {
            FileStream fs = new FileStream(SourceQCN, FileMode.Open, FileAccess.Read);

            try
            {
                // Create a byte array of file stream length
                byte[] bytes = File.ReadAllBytes(SourceQCN);
                //Read block of bytes from stream into the byte array
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));

                //richTextBox1.Text = BitConverter.ToString(bytes); //return the byte data

                string hex = BitConverter.ToString(bytes);
                string[] cizgilibyte = hex.Split(new Char[] { '-' }).ToArray();
                string cizgikaldir = String.Join("", cizgilibyte);
                richTextBox1.Text = cizgikaldir;

                int sayac = 0;
                int sayac2 = 0;
                int bulunan_deger = 0;

                ArrayList MyList = new ArrayList();
                ArrayList MyList2 = new ArrayList();

                for (int i = 0; i < 2; i++)
                {
                    bulunan_deger = richTextBox1.Text.IndexOf("01002602000008", sayac);
                    MyList.Add(richTextBox1.Text.Substring(bulunan_deger + 14, 16));
                    sayac = bulunan_deger + 30;
                    sayac2 = sayac - 16;
                    MyList2.Add(sayac2 / 2);
                }

                // The values found have been written to the relevant labels. Transactions Done.
                label3.Text = MyList[0].ToString();
                label4.Text = MyList[1].ToString();
                label5.Text = MyList2[0].ToString(); //imei1 pointer
                label6.Text = MyList2[1].ToString(); //imei2 pointer
            }
            catch (EndOfStreamException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();//File Stream Closed...
                fs.Dispose();
            }

        }

        /*
         * IMEI Verification Started
         */

        static int IMEInumberCheck(int n)
        {
            int a = 0;
            while (n > 0)
            {
                a = a + n % 10;
                n = n / 10;
            }

            return a;
        }

        static Boolean IMEIControl(long n)
        {
            // Numbers in numbers are being converted.
            // to find string length
            String s = n.ToString();
            int len = s.Length;

            if (len != 15)
                return false;

            int sum = 0;
            for (int i = len; i >= 1; i--)
            {
                int d = (int)(n % 10);

                // We double every party
                // digit
                if (i % 2 == 0)
                    d = 2 * d;

                // Find the sum of the numbers found
                sum += IMEInumberCheck(d);
                n = n / 10;
            }

            return (sum % 10 == 0);
        }

        /*
         * IMEI Verification Done
         */

        public static string IMEI_fixing(string IMEIinput, string IMEIinput2)
        {

            string imei = IMEIinput;
            char firstChar = Convert.ToChar(imei.Substring(0, 1));  // 08 8A 36 01 02 34 38 03 87 --> 863102043833078
            string nextChar = imei.Substring(2);

            char[] separate = nextChar.ToCharArray();

            ArrayList MyList = new ArrayList();

            MyList.Add(firstChar);
            MyList.Add(separate[1]);
            MyList.Add(separate[0]);
            MyList.Add(separate[3]);
            MyList.Add(separate[2]);
            MyList.Add(separate[5]);
            MyList.Add(separate[4]);
            MyList.Add(separate[7]);
            MyList.Add(separate[6]);
            MyList.Add(separate[9]);
            MyList.Add(separate[8]);
            MyList.Add(separate[11]);
            MyList.Add(separate[10]);
            MyList.Add(separate[13]);
            MyList.Add(separate[12]);

            StringBuilder sb = new StringBuilder();
            if (MyList.Count == 15)
            {
                for (int i = 0; i <= 14; i++)
                {
                    sb.Append(MyList[i]);
                }
            }

            return IMEIinput2 = sb.ToString();

        }

        private void imei1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void imei2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void imei2_TextChanged(object sender, EventArgs e)
        {
            if (imei2.Text.Length > 0)
            {
                pbIMEI2Error.Visible = true;

                if (IMEIControl(Convert.ToInt64(imei2.Text)))
                {
                    pbIMEI2Error.Image = Resources.Valid;
                }
                else
                {
                    pbIMEI2Error.Image = Resources.inValid;
                }
            }
            else
            {
                pbIMEI2Error.Visible = false;
            }
        }

        private void imei1_TextChanged(object sender, EventArgs e)
        {

            if (imei1.Text.Length > 0)
            {
                pbIMEI1Error.Visible = true;

                if (IMEIControl(Convert.ToInt64(imei1.Text)))
                {
                    pbIMEI1Error.Image = Resources.Valid;
                }
                else
                {
                    pbIMEI1Error.Image = Resources.inValid;
                }
            }
            else
            {
                pbIMEI1Error.Visible = false;
            }
        }
    }
}
