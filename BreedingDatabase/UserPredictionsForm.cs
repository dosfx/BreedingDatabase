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
    public partial class UserPredictionsForm : Form
    {
        private readonly BindingList<Breeding> breedings = new BindingList<Breeding>();

        public IList<Breeding> Breedings
        {
            get
            {
                return breedings.ToList();
            }
        }

        public UserPredictionsForm()
        {
            InitializeComponent();

            breedingBindingSource.DataSource = breedings;
        }

        private void NewIdsGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers.HasFlag(Keys.Control) && e.KeyCode == Keys.V)
            {
                breedings.CancelNew(newIdsGridView.NewRowIndex);
                foreach (Match match in Regex.Matches(Clipboard.GetText(), @"\d+"))
                {
                    if (!long.TryParse(match.Value, out long id)) continue;

                    if (breedings.Any(b => b.Id == id)) continue;

                    breedings.Add(new Breeding() { Id = id });
                }
            }
        }
    }
}
