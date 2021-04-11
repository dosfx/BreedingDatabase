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
    public partial class ArtistsForm : Form
    {
        public ArtistsForm()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        public IList<Artist> Artists
        {
            get => (IList<Artist>)artistBindingSource.DataSource;
            set => artistBindingSource.DataSource = new BindingList<Artist>(value);
        }

        private void ArtistGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            artistGridView[e.ColumnIndex, e.RowIndex].ReadOnly = (artistGridView.Rows[e.RowIndex].DataBoundItem as Artist)?.Id == Artist.UserArtist.Id;
        }
    }
}
