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

            ddCard.Items.Add("Pilots");
            ddCard.Items.Add("Upgrades");
            ddCard.SelectedIndex = 0;

            
            
            
            lstCards.DisplayMember = "Name";
            lstCards.DataSource = GetPilotWithMatchingFaction((Faction)ddCardType.SelectedIndex);
            lstCards.SelectedIndex = 0;

        }

        private void lstCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCards.SelectedItem is IPilot pilot)
            {
                lblPilotSkill.Visible = true;
                lblFirePower.Visible = true;
                lblAgility.Visible = true;
                lblHull.Visible = true;
                lblShields.Visible = true;
                lblUpgradeType.Visible = false;

                lblCardName.Text = pilot.Name;
                txtCardText.Text = pilot.Text;
                lblCardPoints.Text = $"{pilot.Pts} pts";

                lblShip.Text = pilot.Ship;
                lblPilotSkill.Text = pilot.PilotSkill.ToString();
                lblFirePower.Text = pilot.FirePower.ToString();
                lblAgility.Text = pilot.Agility.ToString();
                lblHull.Text = pilot.Hull.ToString();
                lblShields.Text = pilot.Shields.ToString();
            }
            else if (lstCards.SelectedItem is IUpgrade upgrade)
            {
                lblPilotSkill.Visible = false;
                lblFirePower.Visible = false;
                lblAgility.Visible = false;
                lblHull.Visible = false;
                lblShields.Visible = false;
                lblUpgradeType.Visible = true;

                lblCardName.Text = upgrade.Name;
                txtCardText.Text = upgrade.Text;
                lblCardPoints.Text = $"{upgrade.Pts} pts";

                lblShip.Text = upgrade.Limited ? "Limited" : "";
                lblUpgradeType.Text = upgrade.Type.ToString();
            }
            else
            {
                throw new InvalidOperationException("Dropdown has Selected an Invalid Member - this should not be possible!");
            }
            
        }

        private void ddCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddCard.SelectedIndex)
            {
                case 0:
                    {
                        lstCards.DataSource = GetPilotWithMatchingFaction((Faction)ddCardType.SelectedIndex);
                        break;
                    }
                case 1:
                    {
                        lstCards.DataSource = GetUpgradeWithMatchingType((UpgradeType)ddCardType.SelectedIndex);
                        break;
                    }
                default:
                    {
                        throw new InvalidOperationException("Dropdown has Selected an Invalid Member - this should not be possible!");
                    }
            }
            
        }

        private IList<IUpgrade> GetUpgradeWithMatchingType(UpgradeType type)
        {
            return new List<IUpgrade>(
                Program.CardHandler.Upgrades
                .Where(u => u.Type == type));
        }

        private IList<IPilot> GetPilotWithMatchingFaction(Faction faction)
        {
            return new List<IPilot>(
                Program.CardHandler.Pilots
                .Where(p => p.Faction == faction));
        }

        private void PilotCardBrowser_Load(object sender, EventArgs e)
        {

        }

        private void ddCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ddCard.SelectedIndex)
            {
                case 0:
                    {
                        ddCardType.DataSource = Enum.GetValues(typeof(Faction));
                        break;
                    }
                case 1:
                    {
                        ddCardType.DataSource = Enum.GetValues(typeof(UpgradeType));
                        break;
                    }
                default:
                    {
                        throw new InvalidOperationException("Dropdown has Selected an Invalid Member - this should not be possible!");
                    }
            }
            ddCardType.SelectedIndex = 0;
        }
    }
}
