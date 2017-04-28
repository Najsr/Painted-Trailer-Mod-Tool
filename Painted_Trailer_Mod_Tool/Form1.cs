using System;
using System.Media;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Painted_Trailer_Mod_Tool
{
    public partial class Form_Main : Form
    {
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;

        Color color;

        string baseCompany = "company_permanent: company.permanent.<intname>\n{\n\tname: \"<intname>\"\n\tsort_name: \"<intname>\"\n\ttrailer_look: default\n}";

        string[] companies = { "agronord.dlc_north", "aria_fd_albg.dlc_north", "aria_fd_esbj.dlc_north", "aria_fd_jnpg.dlc_north", "aria_fd_trbg.dlc_north", "batisse_hs", "bcp", "bhv.dlc_north", "bhv", "bjork.dlc_north", "cont_port.dlc_north", "drekkar.dlc_north", "euroacres", "eurogoodies", "fcp", "fle", "gnt.dlc_north", "ika_bohag.dlc_north", "ika_bohag", "itcc", "kaarfor", "konstnr.dlc_north", "konstnr_br.dlc_north", "konstnr_hs.dlc_north", "konstnr_wind.dlc_north", "lisette_log", "lkwlog", "marina.dlc_north", "ms_stein.dlc_north", "nbfc", "nord_crown.dlc_north", "nord_sten.dlc_north", "norrsken.dlc_north", "norr_food.dlc_north", "ns_chem.dlc_north", "ns_oil.dlc_north", "polarislines.dlc_north", "polar_fish.dlc_north", "posped", "quarry", "renar.dlc_north", "sag_tre.dlc_north", "sanbuilders", "scania_dlr", "scania_fac.dlc_north", "sellplan", "skoda", "stokes", "tradeaux", "trameri", "transinet", "tree_et", "vitas_pwr.dlc_north", "voitureux", "volvo_dlr", "volvo_fac.dlc_north", "vpc.dlc_north", "wgcc" };

        string[] trailerNames = { "fridge", "krone_coolliner", "krone_profiliner", "schmitz_universal" };

        string[] trailers = { "cement", "chemical_cistern", "food_cistern", "fuel_cistern", "livestock" };

        string[] oldTrailers = { "reefer/chassis", "reefer/chassis_a", "container/chassis", "container/chassis" };

        string[] newTrailers = { "krone/fridge", "krone/coolliner", "krone/profiliner", "schmitz/universal" };

        string blankSii = Encoding.UTF8.GetString(Properties.Resources.emptytrailer);

        string newSii;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void buttonPickColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                color = colorDialog1.Color;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string paintName = textBoxModName.Text.Trim();
            if (paintName.Equals(string.Empty) || color.IsEmpty)
            {
                MessageBox.Show("Name is empty or color hasn't been picked yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Directory.CreateDirectory(exeDir + paintName + "/def/vehicle/trailer");
            Directory.CreateDirectory(exeDir + paintName + "/def/company");

            float colourR = color.R / 255f;
            float colourG = color.G / 255f;
            float colourB = color.B / 255f;

            for (int i = 0; i < trailers.Length; i++)
            {
                newSii = blankSii;
                newSii = newSii.Replace("<trailer>", trailers[i] + "/chassis");
                if (trailers[i] == "chemical_cistern")
                {
                    newSii = newSii.Replace("<intname>", "chcistern");
                }
                else
                {
                    newSii = newSii.Replace("<intname>", trailers[i]);
                }
                newSii = newSii.Replace("<r>", colourR.ToString().Replace(",", "."));
                newSii = newSii.Replace("<g>", colourG.ToString().Replace(",", "."));
                newSii = newSii.Replace("<b>", colourB.ToString().Replace(",", "."));
                using (StreamWriter siiout = new StreamWriter(exeDir + paintName + "/def/vehicle/trailer/" + trailers[i] + ".sii"))
                {
                    siiout.Write(newSii);
                }
                Console.Write(trailers[i] + " has been written\n");
            }
            if(checkBoxOldTrailers.Checked)
            {
                for(int i = 0; i < oldTrailers.Length; i++)
                {
                    newSii = blankSii;
                    newSii = newSii.Replace("<trailer>", oldTrailers[i]);
                    newSii = newSii.Replace("<intname>", trailerNames[i].Replace("_", "."));
                    newSii = newSii.Replace("<r>", colourR.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<g>", colourG.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<b>", colourB.ToString().Replace(",", "."));
                    using (StreamWriter siiout = new StreamWriter(exeDir + paintName + "/def/vehicle/trailer/" + trailerNames[i] + ".sii"))
                    {
                        siiout.Write(newSii);
                    }
                }
            }
            else
            {
                for (int i = 0; i < newTrailers.Length; i++)
                {
                    newSii = blankSii;
                    newSii = newSii.Replace("<trailer>", newTrailers[i] + "/chassis");
                    newSii = newSii.Replace("<intname>", trailerNames[i].Replace("_", "."));
                    newSii = newSii.Replace("<r>", colourR.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<g>", colourG.ToString().Replace(",", "."));
                    newSii = newSii.Replace("<b>", colourB.ToString().Replace(",", "."));
                    using (StreamWriter siiout = new StreamWriter(exeDir + paintName + "/def/vehicle/trailer/" + trailerNames[i] + ".sii"))
                    {
                        siiout.Write(newSii);
                    }
                }
            }
            foreach (string currentCompany in companies)
            {
                using (StreamWriter siiout = new StreamWriter(exeDir + paintName + "/def/company/" + currentCompany + ".sii"))
                {
                    siiout.Write(baseCompany.Replace("<intname>", currentCompany.Replace(".dlc_north", "")));
                }
            }

            SystemSounds.Beep.Play();
        }
    }
}
