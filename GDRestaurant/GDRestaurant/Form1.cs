using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDRestaurant
{
    public partial class Form1 : Form
    {
        // Main
        const double Price_ChickenBirany = 6.9;
        const double Price_MattonKacchi = 8.9;
        const double Price_FishRice = 7.9;
        const double Price_PotatoFish = 6.9;
        const double Price_ChowmingNoodles = 5.9;
        const double Price_KalaBhuna = 9.9;
        const double Price_DuckKhichuri = 8.9;
        const double Price_ChikenSpecialBhuna = 10.9;
        // sides
        const double Price_SpecialSalad = 2.9;
        const double Price_Dhoi = 3.9;
        const double Price_PlanRice = 1.9;
        const double Price_khusbuPolaw = 2.9;
        // Drinks
        const double Price_Pepsi = 0.9;
        const double Price_Lacchi = 0.9;
        const double Price_Frooto = 1;
        const double Price_Borhani = 1.5;
        // Shakes
        const double Price_BengaliSpicyTea = 2;
        const double Price_CafeMocca = 1.3;
        const double Price_AppleMilkShake = 3;        
        const double Price_GrapeandIceShake = 1.9;

        const double Tax_Rate = 13;

        double iTax, iSubTotal, iTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void MPage_Load(object sender, EventArgs e)
        {
            cmbPaymentType.Items.Add("Master Card ");
            cmbPaymentType.Items.Add("Cash");
            cmbPaymentType.Items.Add("Debit Card");
            cmbPaymentType.Items.Add("Visa Card");
            

            EnableTextBoxes();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //............Exit Button...............

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show(" Confirm You want to Exit the Application ? ", " GD Restaurant ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)

            {
                Application.Exit();
            }
            


            
        }

        //...............Reset textBox.................

        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);

            };
            func(Controls);

        }

        //..........Reset CheckBox.........

        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);

            };
            func(Controls);

        }

        //...............Enable/disable textbox .............

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);

            };
            func(Controls);

        }

        //............Reset Button.................

        private void Button2_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        //..............Main Dishes.................


        private void ChFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChickenBirany.Checked == true)
            {
                txtChickenBirany.Enabled = true;
                txtChickenBirany.Text = "";
                txtChickenBirany.Focus();

            }
            else
            {
                txtChickenBirany.Enabled = false;
                txtChickenBirany.Text = "0";
            }
        }

        private void ChkMattonKacchi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMattonKacchi.Checked == true)
            {
                txtMattonKacchi.Enabled = true;
                txtMattonKacchi.Text = "";
                txtMattonKacchi.Focus();

            }
            else
            {
                txtMattonKacchi.Enabled = false;
                txtMattonKacchi.Text = "0";
            }
        }

        private void ChkFishRice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFishRice.Checked == true)
            {
                txtFishRice.Enabled = true;
                txtFishRice.Text = "";
                txtFishRice.Focus();

            }
            else
            {
                txtFishRice.Enabled = false;
                txtFishRice.Text = "0";
            }
        }

        private void ChkPotatoFish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotatoFish.Checked == true)
            {
                txtPotatoFish.Enabled = true;
                txtPotatoFish.Text = "";
                txtPotatoFish.Focus();

            }
            else
            {
                txtPotatoFish.Enabled = false;
                txtPotatoFish.Text = "0";
            }
        }

        private void ChkChowmingNoodles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChowmingNoodles.Checked == true)
            {
                txtChowmingNoodles.Enabled = true;
                txtChowmingNoodles.Text = "";
                txtChowmingNoodles.Focus();

            }
            else
            {
                txtChowmingNoodles.Enabled = false;
                txtChowmingNoodles.Text = "0";
            }
        }

        private void ChkKalaBhuna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKalaBhuna.Checked == true)
            {
                txtKalaBhuna.Enabled = true;
                txtKalaBhuna.Text = "";
                txtKalaBhuna.Focus();

            }
            else
            {
                txtKalaBhuna.Enabled = false;
                txtKalaBhuna.Text = "0";
            }
        }

        private void ChkDuckKhichuri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuckKhichuri.Checked == true)
            {
                txtDuckKhichuri.Enabled = true;
                txtDuckKhichuri.Text = "";
                txtDuckKhichuri.Focus();

            }
            else
            {
                txtDuckKhichuri.Enabled = false;
                txtDuckKhichuri.Text = "0";
            }
        }

        private void ChkChikenSpecialBhuna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChikenSpecialBhuna.Checked == true)
            {
                txtChikenSpecialBhuna.Enabled = true;
                txtChikenSpecialBhuna.Text = "";
                txtChikenSpecialBhuna.Focus();

            }
            else
            {
                txtChikenSpecialBhuna.Enabled = false;
                txtChikenSpecialBhuna.Text = "0";
            }
        }


        //...............Drinks...............

        private void ChkPepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepsi.Checked == true)
            {
                txtPepsi.Enabled = true;
                txtPepsi.Text = "";
                txtPepsi.Focus();

            }
            else
            {
                txtPepsi.Enabled = false;
                txtPepsi.Text = "0";
            }
        }

        private void ChkLacchi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLacchi.Checked == true)
            {
                txtLacchi.Enabled = true;
                txtLacchi.Text = "";
                txtLacchi.Focus();

            }
            else
            {
                txtLacchi.Enabled = false;
                txtLacchi.Text = "0";
            }
        }

        private void ChkFrooto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrooto.Checked == true)
            {
                txtFrooto.Enabled = true;
                txtFrooto.Text = "";
                txtFrooto.Focus();

            }
            else
            {
                txtFrooto.Enabled = false;
                txtFrooto.Text = "0";
            }
        }

        private void ChkBorhani_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorhani.Checked == true)
            {
                txtBorhani.Enabled = true;
                txtBorhani.Text = "";
                txtBorhani.Focus();

            }
            else
            {
                txtBorhani.Enabled = false;
                txtBorhani.Text = "0";
            }
        }


        //.................Shakes................

        private void ChkBengaliSpicyTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBengaliSpicyTea.Checked == true)
            {
                txtBengaliSpicyTea.Enabled = true;
                txtBengaliSpicyTea.Text = "";
                txtBengaliSpicyTea.Focus();

            }
            else
            {
                txtBengaliSpicyTea.Enabled = false;
                txtBengaliSpicyTea.Text = "0";
            }
        }

        private void ChkCafeMocca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafeMocca.Checked == true)
            {
                txtCafeMocca.Enabled = true;
                txtCafeMocca.Text = "";
                txtCafeMocca.Focus();

            }
            else
            {
                txtCafeMocca.Enabled = false;
                txtCafeMocca.Text = "0";
            }
        }

        private void ChkAppleMilkShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppleMilkShake.Checked == true)
            {
                txtAppleMilkShake.Enabled = true;
                txtAppleMilkShake.Text = "";
                txtAppleMilkShake.Focus();

            }
            else
            {
                txtAppleMilkShake.Enabled = false;
                txtAppleMilkShake.Text = "0";
            }
        }

        private void ChkGrapeandIceShake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGrapeandIceShake.Checked == true)
            {
                txtGrapeandIceShake.Enabled = true;
                txtGrapeandIceShake.Text = "";
                txtGrapeandIceShake.Focus();

            }
            else
            {
                txtGrapeandIceShake.Enabled = false;
                txtGrapeandIceShake.Text = "0";
            }
        }


        //....................Sides.....................

        private void ChkSpecialSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecialSalad.Checked == true)
            {
                txtSpecialSalad.Enabled = true;
                txtSpecialSalad.Text = "";
                txtSpecialSalad.Focus();

            }
            else
            {
                txtSpecialSalad.Enabled = false;
                txtSpecialSalad.Text = "0";
            }
        }

        private void ChkDhoi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDhoi.Checked == true)
            {
                txtDhoi.Enabled = true;
                txtDhoi.Text = "";
                txtDhoi.Focus();

            }
            else
            {
                txtDhoi.Enabled = false;
                txtDhoi.Text = "0";
            }
        }

        private void CmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.Text == "Cash")
            {
                txtPaymentType.Enabled = true;
                txtPaymentType.Text = "";
                txtPaymentType.Focus();
            }
            else
            {
                txtPaymentType.Enabled = false;
                txtPaymentType.Text = "0";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[20];
                itemcost[0] = Convert.ToDouble(txtChickenBirany.Text) * Price_ChickenBirany;
                itemcost[1] = Convert.ToDouble(txtMattonKacchi.Text) * Price_MattonKacchi;
                itemcost[2] = Convert.ToDouble(txtFishRice.Text) * Price_FishRice;
                itemcost[3] = Convert.ToDouble(txtPotatoFish.Text) * Price_PotatoFish;
                itemcost[4] = Convert.ToDouble(txtChowmingNoodles.Text) * Price_ChowmingNoodles;
                itemcost[5] = Convert.ToDouble(txtKalaBhuna.Text) * Price_KalaBhuna;
                itemcost[6] = Convert.ToDouble(txtDuckKhichuri.Text) * Price_DuckKhichuri;
                itemcost[7] = Convert.ToDouble(txtChikenSpecialBhuna.Text) * Price_ChikenSpecialBhuna;
                itemcost[8] = Convert.ToDouble(txtSpecialSalad.Text) * Price_SpecialSalad;
                itemcost[9] = Convert.ToDouble(txtDhoi.Text) * Price_Dhoi;
                itemcost[10] = Convert.ToDouble(txtPlanRice.Text) * Price_PlanRice;
                itemcost[11] = Convert.ToDouble(txtkhusbuPolaw.Text) * Price_khusbuPolaw;
                itemcost[12] = Convert.ToDouble(txtPepsi.Text) * Price_Pepsi;
                itemcost[13] = Convert.ToDouble(txtLacchi.Text) * Price_Lacchi;
                itemcost[14] = Convert.ToDouble(txtFrooto.Text) * Price_Frooto;
                itemcost[15] = Convert.ToDouble(txtBorhani.Text) * Price_Borhani;
                itemcost[16] = Convert.ToDouble(txtBengaliSpicyTea.Text) * Price_BengaliSpicyTea;
                itemcost[17] = Convert.ToDouble(txtCafeMocca.Text) * Price_CafeMocca;
                itemcost[18] = Convert.ToDouble(txtAppleMilkShake.Text) * Price_AppleMilkShake;
                itemcost[19] = Convert.ToDouble(txtGrapeandIceShake.Text) * Price_GrapeandIceShake;


            double cost, iChange ;

            if (cmbPaymentType.Text == "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                    itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] +
                    itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] +
                    itemcost[18] + itemcost[19];

                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);

                iChange = Convert.ToDouble(txtPaymentType.Text);
                cost = iChange - (iTax + iTotal);
                txtChange.Text = Convert.ToString(cost);

                txtChange.Text = String.Format("{0:C}", cost);
                txtTax.Text = String.Format("{0:C}", iTax);
                txtSubTotal.Text = String.Format("{0:C}", iSubTotal);
                txtTotal.Text = String.Format("{0:C}", iTotal);

            }
            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                    itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] +
                    itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] +
                    itemcost[18] + itemcost[19];

                txtSubTotal.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                txtTax.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                txtTotal.Text = Convert.ToString(iTotal);
                              
                                
                txtTax.Text = String.Format("{0:C}", iTax);
                txtSubTotal.Text = String.Format("{0:C}", iSubTotal);
                txtTotal.Text = String.Format("{0:C}", iTotal);
            }
                

            
        }

        private void ChkPlanRice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlanRice.Checked == true)
            {
                txtPlanRice.Enabled = true;
                txtPlanRice.Text = "";
                txtPlanRice.Focus();

            }
            else
            {
                txtPlanRice.Enabled = false;
                txtPlanRice.Text = "0";
            }
        }

        private void ChkkhusbuPolaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkkhusbuPolaw.Checked == true)
            {
                txtkhusbuPolaw.Enabled = true;
                txtkhusbuPolaw.Text = "";
                txtkhusbuPolaw.Focus();

            }
            else
            {
                txtkhusbuPolaw.Enabled = false;
                txtkhusbuPolaw.Text = "0";
            }
        }
    }
}
