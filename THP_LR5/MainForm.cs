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
using Logic;
using Logic.Creatories;
using System.Reflection.Emit;

namespace THP_LR5
{
    public partial class MainForm : Form
    {
        MilitaryUnitCreator militaryUnitCreator = new MilitaryUnitCreator();
        PrintSum printSum = new PrintSum();
        CalculatePrice calculatePrice = new CalculatePrice();
        MilitaryUnit militaryUnit;

        public MainForm()
        {   
            militaryUnit = militaryUnitCreator.create();
            InitializeComponent();
        }

        public void ShowInfo()
        {
            WeaponList.Items.Clear();
            foreach (Weapon weapon in militaryUnit.Weapons)
            {
                WeaponList.Items.Add($"Название: {weapon.Name} " +
                    $"\tЦена: {weapon.Price} \tВес: {weapon.Weight}");
            }
            AmountPrice.Text = printSum.Print(calculatePrice.Calculate(militaryUnit));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add_AND_Edit_Form AddForm = new Add_AND_Edit_Form(
                militaryUnit, 
                WeaponList.SelectedIndex, 
                false);
            AddForm.Owner = this;
            AddForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            if (WeaponList.SelectedIndex != -1)
            {
                Add_AND_Edit_Form AddForm = new Add_AND_Edit_Form(militaryUnit, WeaponList.SelectedIndex, true);
                AddForm.Owner = this;
                AddForm.ShowDialog();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (WeaponList.SelectedIndex != -1)
            {
                militaryUnit.Weapons.RemoveAt(WeaponList.SelectedIndex);
                ShowInfo();
            }
        }
    }
}
