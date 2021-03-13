using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreedingDatabase
{
    public partial class AddBreedingsForm : Form
    {
        private BindingList<Breeding> breedings = new BindingList<Breeding>();

        public IList<Breeding> Breedings
        {
            get
            {
                return breedings.ToList();
            }
        }

        public AddBreedingsForm()
        {
            InitializeComponent();

            breedingBindingSource.DataSource = breedings;
        }

        private void Paste()
        {
            string paste = Clipboard.GetText();
            Regex regex = new Regex(@"<a href=""http:\/\/www[.]aywas[.]com\/breedcp\/index\/breedings/details\/\?id=(\d+)""");
            foreach (Match match in regex.Matches(paste))
            {
                if (long.TryParse(match.Groups[1].Value, out long id) && breedings.All(b => b.Id != id))
                {             
                    breedings.Add(new Breeding() { Id = id });
                }
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void AddBreedingsForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers.HasFlag(Keys.Control))
            {
                e.Handled = true;
                Paste();
            }
        }
    }
}
