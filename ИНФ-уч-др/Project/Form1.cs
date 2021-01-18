using Project.Roles_and_Champions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private StringBuilder sb = new StringBuilder();
        private List<Champion> champions = new List<Champion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool isLevel = int.TryParse(LevelTextBox.Text, out _);
            if (isLevel)
            {
                int level = int.Parse(LevelTextBox.Text);
                Champion champion = new Champion(CharacterTextBox.Text, ChampionTextBox.Text, level);
                this.sb.AppendLine(champion.ToString());
                ListResult.Items.Add(champion.ToString());
                champions.Add(champion);
                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {
            CharacterTextBox.Text = string.Empty;
            ChampionTextBox.Text = string.Empty;
            LevelTextBox.Text = string.Empty;
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            ListResult.Items.Add(new string('-', 25));
            
           champions = champions.OrderBy(x => Guid.NewGuid()).ToList();
            
            for (int i = 0; i < champions.Count; i += 2)
            {               
                if ((i+1 < champions.Count))
                {
                    string result = champions[i].Fight(champions[i + 1]);
                    ListResult.Items.Add(result);
                }

                else
                {
                    ListResult.Items.Add("Please add more champions!");
                }
            }
            ListResult.Items.Add(new string('-', 25));
        }
    }

}


