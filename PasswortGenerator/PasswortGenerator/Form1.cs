using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace PasswortGenerator
{
    public partial class Main : Form
    {
        //Globale Variablen
        #region Globale Variablen
        public bool save, hash, both;

        public DateTime dtime = DateTime.Now;
        static PerformanceCounter cpu;

        public string slog;
        public string sPass;
        public string[] password = new string[92];

        public float cpuusage;

        public decimal drandom;
        public decimal dlength;

        #endregion

        //Main region
        #region Main
        public Main()
        {
            InitialisierePerformanceCounter();
            InitializeComponent();
            cpuusage = GetCPUusage();
            dtime = DateTime.Now;
            slog = "[" + dtime + "] - Successfully Initialized - CPU usage: " + cpuusage+"%";
            writer(slog);
             
        }
        #endregion

        //Button Click method
        #region button click
        private void btngenerate_Click(object sender, EventArgs e)
        {
            try
            {
                dlength = numlength.Value;
                //stringarray bekommt arraybereich aus dlength
                #region lowcase
                password[0] = "a";
                password[1] = "b";
                password[2] = "c";
                password[3] = "d";
                password[4] = "e";
                password[5] = "f";
                password[6] = "g";
                password[7] = "h";
                password[8] = "i";
                password[9] = "j";
                password[10] = "k";
                password[11] = "l";
                password[12] = "m";
                password[13] = "n";
                password[14] = "o";
                password[15] = "p";
                password[16] = "q";
                password[17] = "r";
                password[18] = "s";
                password[19] = "t";
                password[20] = "u";
                password[21] = "v";
                password[22] = "w";
                password[23] = "x";
                password[24] = "y";
                password[25] = "z";
                #endregion
                #region Upcase
                password[26] = "A"; 
                password[27] = "B";
                password[28] = "C";
                password[29] = "D";
                password[30] = "E";
                password[31] = "F";
                password[32] = "G";
                password[33] = "H";
                password[34] = "I";
                password[35] = "J";
                password[36] = "K";
                password[37] = "L";
                password[38] = "M";
                password[39] = "N";
                password[39] = "O";
                password[40] = "P";
                password[41] = "Q";
                password[42] = "R";
                password[43] = "S";
                password[44] = "T";
                password[45] = "U";
                password[46] = "V";
                password[47] = "W";
                password[48] = "X";
                password[49] = "Y";
                password[50] = "Z";
                #endregion
                #region Numbers
                password[51] = "0";
                password[52] = "1";
                password[53] = "2";
                password[54] = "3";
                password[55] = "4";
                password[56] = "5";
                password[57] = "6";
                password[58] = "7";
                password[59] = "8";
                password[60] = "9";
                #endregion
                #region specials
                password[61] = "!";
                password[62] = "'";
                password[63] = "§";
                password[64] = "$";
                password[65] = "%";
                password[66] = "&";
                password[67] = "/";
                password[68] = "(";
                password[69] = ")";
                password[70] = "=";
                password[71] = "?";
                password[72] = "´";
                password[73] = "*";
                password[74] = "@";
                password[75] = "-";
                password[76] = ":";
                password[77] = ";";
                password[78] = "<";
                password[79] = ">";
                password[80] = ",";
                password[81] = ".";
                password[82] = "_";
                password[83] = "~";
                password[84] = "#";
                password[85] = "`";
                password[86] = "|";
                password[87] = "+";
                password[88] = "}";
                password[89] = "]";
                password[90] = "[";
                password[91] = "{";
                #endregion

                //Calling methods
                #region calling methods
                if (drandom <= 3)
                {
                    dtime = DateTime.Now;
                    cpuusage = GetCPUusage();
                    slog = "[" + dtime + "] - Calling method under 3 - CPU usage: " + cpuusage + "%";
                    writer(slog);

                    lowcase();
                }

                else if (drandom > 8)
                {
                    dtime = DateTime.Now;
                    cpuusage = GetCPUusage();
                    slog = "[" + dtime + "] - Calling method above 8 - CPU usage: " + cpuusage + "%";
                    writer(slog);

                    lownumupspec();
                }

                else if (drandom > 6)
                {
                    dtime = DateTime.Now;
                    cpuusage = GetCPUusage();
                    slog = "[" + dtime + "] - Calling method above 6 - CPU usage: " + cpuusage + "%";
                    writer(slog);

                    lowupnum();
                }

                else if (drandom > 3)
                {
                    dtime = DateTime.Now;
                    cpuusage = GetCPUusage();
                    slog = "[" + dtime + "] - Calling method above 3 - CPU usage: " + cpuusage + "%";
                    writer(slog);

                    lowup();
                }

                else
                {
                    dtime = DateTime.Now;
                    cpuusage = GetCPUusage();
                    slog = "[" + dtime + "] - Calling methods went wrong - CPU usage: " + cpuusage + "%";
                    writer(slog);
                    MessageBox.Show("Something went wrong, please try again");
                }

                #endregion
            }
            catch (Exception ex)
            {
                //If error, a userspecific error will be logged and shown
                dtime = DateTime.Now;
                cpuusage = GetCPUusage();
                slog = "[" + dtime + "] - "+ ex.Message +"- CPU usage: " + cpuusage+"%";
                writer(slog);
                MessageBox.Show("An Unexpected error occured. Error-ID: "+ex.Data);
                throw;
            }
        }
        #endregion

        //value Changed
        #region numrandomvaluechanged
        private void numrandom_ValueChanged(object sender, EventArgs e)
        {
            drandom = numrandom.Value;
        }
        #endregion

        //Menubar
        #region Menubar
        private void softwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Version 1.0.0a\nCreated and Designed by Artur Bobb\nhttps://github.com/Chookees");
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Software Info shown - CPU usage: " + cpuusage+"%";
            writer(slog);
        }

        private void openReadmetxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Readme.txt");
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Readme opened - CPU usage: " + cpuusage+"%";
            writer(slog);
        }

        private void showLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("log.txt");
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - log opened - CPU usage: " + cpuusage+"%";
            writer(slog);
        }

        private void showVersionlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("versionlog.txt");
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - versionlog opened - CPU usage: " + cpuusage+"%";
            writer(slog);
        }
        #endregion

        //True false checkboxes
        #region cB's

        private void cBsave_CheckedChanged(object sender, EventArgs e)
        {
            if (cBsave.Checked)
            {
                save = true;
                cBhash.Enabled = true; 
            }

            else
            {
                save = false;
                cBhash.Enabled = false;
            }
        }

        private void cBhash_CheckedChanged(object sender, EventArgs e)
        {
            if (cBhash.Checked)
            {
                hash = true;
            }

            else
            {
                hash = false;
            }
        }

        private void cBboth_CheckedChanged(object sender, EventArgs e)
        {
            if (cBboth.Checked)
            {
                hash = false;
                save = false;
                both = true;

                cBhash.Enabled = false;
                cBsave.Enabled = false;
            }

            else if (cBboth.Checked == false && cBsave.Checked == true)
            {
                save = true;
                
                cBhash.Enabled = true;
                cBsave.Enabled = true;
                both = false;
            }

            else
            {
                save = true;
                cBhash.Enabled = false;
                cBsave.Enabled = true;
            }
        }
        #endregion

        //Double click on label
        #region dblclick
        private void label8_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Save the Password Hashed and Clear in a txt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - label both clicked - CPU usage: " + cpuusage + "%";
            writer(slog);
        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Under strength 3 there will be only lowcase Letters, above 3 are with Upcase,\nabove 6 there will be Numbers included and above 8 there are special Characters included.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Labelbox strength clicked - CPU usage: " + cpuusage + "%";
            writer(slog);
        }
        #endregion

        //Streamwriter
        #region Writer
        public void writer(string text)
        {
            try
            {
                string file = "log.txt";
                if (!File.Exists(file))
                {
                    using (StreamWriter txtcreate = File.CreateText(file))
                    {
                        txtcreate.WriteLine(text);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(file, true))
                    {
                        sw.WriteLine(text);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An Unexpected error occured. Error-ID: " + ex.Data);
                throw;
            }

        }
        #endregion

        //Readin the processor usage
        #region Read Processorusage
        static void InitialisierePerformanceCounter() // Initialisieren
        {
            cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }

        static float GetCPUusage() // Liefert die aktuelle Auslastung zurück
        {
            cpu.NextValue();
            Thread.Sleep(500);
            return cpu.NextValue();           
        }
        #endregion

        //Generating the Password
        #region Generating

        //lowcase method
        #region lowcase
        private void lowcase()
        {
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Called method lowcase - CPU usage: " + cpuusage + "%";
            writer(slog);

            Random rnd = new Random();

            for (int i = 0; i < dlength; i++)
            {
                int index = rnd.Next(0, 25);
                sPass = sPass + password[index];
                cpuusage = GetCPUusage();
            }
            dtime = DateTime.Now;
            slog = "[" + dtime + "] - Successfully created Password on lowcase - CPU usage: " + cpuusage + "%";
            writer(slog);

            if (both == true)
            {
                writekeyboth();
                save = false;
                hash = false;
            }

            if (hash == true)
            {
                writekeyshash();
                save = false;
            }

            if (save == true)
            {
                writekeysplain();
            }
            
            Clipboard.SetText(sPass);
            sPass = null;
        }
        #endregion

        //lowup method
        #region lowup
        private void lowup()
        {
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Called method lowup - CPU usage: " + cpuusage + "%";
            writer(slog);

            Random rnd = new Random();

            for (int i = 0; i < dlength; i++)
            {
                int index = rnd.Next(0, 50);
                sPass = sPass + password[index];
                cpuusage = GetCPUusage();
            }
            dtime = DateTime.Now;
            slog = "[" + dtime + "] - Successfully created Password on lowup - CPU usage: " + cpuusage + "%";
            writer(slog);

            if (both == true)
            {
                writekeyboth();
                save = false;
                hash = false;
            }

            if (hash == true)
            {
                writekeyshash();
                save = false;
            }

            if (save == true)
            {
                writekeysplain();
            }

            Clipboard.SetText(sPass);
            sPass = null;
        }
        #endregion

        //lowupnum method
        #region lowupnum
        private void lowupnum()
        {
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Called method lowupnum - CPU usage: " + cpuusage + "%";
            writer(slog);

            Random rnd = new Random();

            for (int i = 0; i < dlength; i++)
            {
                int index = rnd.Next(0, 60);
                sPass = sPass + password[index];
                cpuusage = GetCPUusage();
            }
            dtime = DateTime.Now;
            slog = "[" + dtime + "] - Successfully created Password on lowupnum - CPU usage: " + cpuusage + "%";
            writer(slog);

            if (both == true)
            {
                writekeyboth();
                save = false;
                hash = false;
            }

            if (hash == true)
            {
                writekeyshash();
                save = false;
            }

            if (save == true)
            {
                writekeysplain();
            }

            Clipboard.SetText(sPass);
            sPass = null;
        }
        #endregion

        //lownumupspec Method
        #region lownumupspec
        private void lownumupspec()
        {
            dtime = DateTime.Now;
            cpuusage = GetCPUusage();
            slog = "[" + dtime + "] - Called method lownumupspec - CPU usage: " + cpuusage + "%";
            writer(slog);

            Random rnd = new Random();

            for (int i = 0; i < dlength; i++)
            {
                int index = rnd.Next(0, 91);
                sPass = sPass + password[index];
                cpuusage = GetCPUusage();
            }
            dtime = DateTime.Now;
            slog = "[" + dtime + "] - Successfully created Password on lownumupspec - CPU usage: " + cpuusage + "%";
            writer(slog);

            if (both == true)
            {
                writekeyboth();
            }

            if (hash == true)
            {
                writekeyshash();
            }

            if (save == true)
            {
                writekeysplain();
            }

            Clipboard.SetText(sPass);
            sPass = null;
        }
        #endregion

        #endregion

        //Writing the Password to a txtfile
        #region writekeys
        private void writekeysplain()
        {
            if (!File.Exists("keys.txt"))
            {
                using (StreamWriter swpass = File.CreateText("keys.txt"))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass);
                }
            }
            else
            {
                using (StreamWriter swpass = new StreamWriter("keys.txt", true))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass);
                }

            }
        }
        #endregion

        //Writing the Password defaced to a txt
        #region writekeyhash
        private void writekeyshash()
        {
            if (!File.Exists("keys.txt"))
            {
                using (StreamWriter swpass = File.CreateText("keys.txt"))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass.GetHashCode());
                }
            }
            else
            {
                using (StreamWriter swpass = new StreamWriter("keys.txt", true))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass.GetHashCode());
                }

            }
        }
        #endregion

        //Write defaced and clear to txt
        #region writekeyboth
        private void writekeyboth()
        {
            if (!File.Exists("keys.txt"))
            {
                using (StreamWriter swpass = File.CreateText("keys.txt"))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass);
                    swpass.WriteLine("And defaced: "+sPass.GetHashCode());
                }
            }

            else
            {
                using (StreamWriter swpass = new StreamWriter("keys.txt", true))
                {
                    swpass.WriteLine("[" + dtime + "] - " + sPass);
                    swpass.WriteLine("And defaced: " + sPass.GetHashCode());
                }

            }
        }
        #endregion
    }
}
