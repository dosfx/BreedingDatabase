using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreedingDatabase
{
    public partial class TestIdForm : Form
    {
        public TestIdForm()
        {
            InitializeComponent();

            DoUpdate();
        }

        private void InputControl_Changed(object sender, EventArgs e)
        {
            DoUpdate();
        }

        private void DoUpdate()
        {
            if (long.TryParse(idTextBox.Text, out long id))
            {
                invalidIdLabel.Visible = false;
                Breeding breeding = new Breeding() { Id = id, IsXaoc = xoacCheckBox.Checked, IsUltraRare = ultraCheckBox.Checked };
                breeding.RollMutant();
                typeResultLabel.BackColor = breeding.BreedingType.GetColor();
                typeResultLabel.Text = breeding.BreedingType.GetName();
                typeResultLabel.Visible = true;
                breeding.RollRare();
                rareResultLabel.BackColor = ColorTranslator.FromHtml(breeding.IsRare ? "#b7e1cd" : "#f7c7c3");
                rareResultLabel.Text = breeding.IsRare ? "yes" : "no";
                rareResultLabel.Visible = breeding.BreedingType != BreedingType.Mutant;
                breeding.RollXaoc();
                xaocResultLabel.BackColor = ColorTranslator.FromHtml(breeding.RolledXaoc ? "#b7e1cd" : "#f7c7c3");
                xaocResultLabel.Text = breeding.RolledXaoc ? "yes" : "no";
                xaocResultLabel.Visible = breeding.BreedingType != BreedingType.Mutant;
                breeding.RollUltraRare();
                ultraResultLabel.BackColor = ColorTranslator.FromHtml(breeding.RolledUltraRare ? "#b7e1cd" : "#f7c7c3");
                ultraResultLabel.Text = breeding.RolledUltraRare ? "yes" : "no";
                ultraResultLabel.Visible = breeding.BreedingType != BreedingType.Mutant;
            }
            else
            {
                invalidIdLabel.Visible = true;
                typeResultLabel.Visible = false;
                rareResultLabel.Visible = false;
                xaocResultLabel.Visible = false;
                ultraResultLabel.Visible = false;
            }
        }
    }
}
