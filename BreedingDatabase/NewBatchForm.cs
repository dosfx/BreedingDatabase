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
    public partial class NewBatchForm : Form
    {
        private BindingList<Breeding> breedings = new BindingList<Breeding>();

        public IList<Breeding> Breedings
        {
            get
            {
                return breedings.ToList();
            }
        }

        public NewBatchForm()
        {
            InitializeComponent();

            breedingBindingSource.DataSource = breedings;
        }
    }
}
