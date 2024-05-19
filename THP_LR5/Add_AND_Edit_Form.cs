using Logic.Creatories;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weapons;

namespace THP_LR5
{
    public partial class Add_AND_Edit_Form : Form
    {
        MilitaryUnit militaryUnit;
        FirearmsCreator firearmsCreator;
        SteelArmsCreator steelArmsCreator;
        bool isEdit;
        int index;
        public Add_AND_Edit_Form(MilitaryUnit _militaryUnit, int _index, bool _isEdit)
        {
            militaryUnit = _militaryUnit;
            index = _index;
            isEdit = _isEdit;
            firearmsCreator = new FirearmsCreator();
            steelArmsCreator = new SteelArmsCreator();
            InitializeComponent();
            if (isEdit)
            {
                groupBox.Enabled = false;
                groupBox.Visible = false;
                this.Text = "Edit";
                Weapon weapon = militaryUnit.Weapons[index];
                textBoxName.Text = weapon.Name;
                textBoxWeight.Text = weapon.Weight.ToString();
                textBoxPrice.Text = weapon.Price.ToString();
                if(weapon is Firearms)
                {
                    radioButtonFirearms.Checked = true;
                }
                else { radioButtonSteelArms.Checked = true;}
                militaryUnit.Weapons.RemoveAt(index);
            }
            else
            {
                this.Text = "Add";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String weight = textBoxWeight.Text;
            String price = textBoxPrice.Text;
            Weapon addedWeapon;
            if (weight.Length ==0){ weight = "0";}
            if (price.Length ==0) { price = "0"; }
            if (radioButtonFirearms.Checked )
            {
                Firearms firearm = firearmsCreator.create(
                    name, 
                    Int32.Parse(weight),
                    Int32.Parse(price)
                    ) as Firearms;
                addedWeapon = firearm;
            }
            else
            {
                SteelArms steelArm = steelArmsCreator.create(
                    name,
                    Int32.Parse(weight), 
                    Int32.Parse(price)
                    ) as SteelArms;
                addedWeapon = steelArm;
            }
            militaryUnit.Weapons.Add(addedWeapon);
            MainForm mainForm = this.Owner as MainForm;
            mainForm.ShowInfo();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
