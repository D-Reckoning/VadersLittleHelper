using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VadersLittleHelper.BackEnd.ObjectTypes;

namespace VadersLittleHelper.Interface
{
    public partial class CardBrowser : Form
    {
        public CardBrowser()
        {
            InitializeComponent();

            ddCardType.DataSource = Enum.GetValues(typeof(Faction));
            ddCardType.SelectedIndex = 0;
            
            lstCards.DisplayMember = "Name";
            lstCards.DataSource = GetPilotWithMatchingFaction((Faction)ddCardType.SelectedIndex);

        }

        private void lstCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCards.DataSource = GetPilotWithMatchingFaction((Faction)ddCardType.SelectedIndex);
        }

        private IList<IPilot> GetPilotWithMatchingFaction(Faction faction)
        {
            return new List<IPilot>(
                Program.CardHandler.Pilots
                .Where(p => p.Faction == faction));
        }
    }
}
