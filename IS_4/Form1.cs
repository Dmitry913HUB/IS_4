using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace IS_4
{
    public partial class Form1 : Form
    {
        SoccerContext db;
        public Form1()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Players.Load();
            var t = from c in db.Players select new { c.Id, c.Name, c.Age };
            dataGridView1.DataSource = t.ToList();

        }

        public void add()
        {
            PlayerForm plForm = new PlayerForm();
            List<Team> teams = db.Teams.ToList();
            plForm.listBoxComand.DataSource = teams;
            plForm.listBoxComand.ValueMember = "Id";
            plForm.listBoxComand.DisplayMember = "Name";
            DialogResult result = plForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            Player player = new Player();
            player.Age = (int)plForm.numericUpDownAge.Value;
            player.Name = plForm.textBoxName.Text;
            teams.Clear();
            foreach (var v in plForm.listBoxComand.SelectedItems)
            {
                teams.Add((Team)v);
            }
            player.Teams = teams;
            if ((player.Name == "") || (player.Teams.Count == 0))
                MessageBox.Show("Ошибка. Присутствуют пустые поля");
            else
            {
                db.Players.Add(player);
                db.SaveChanges();
                MessageBox.Show("Новый игрок успешно добавлен");
                var t = from c in db.Players select new { c.Id, c.Name, c.Age };

                dataGridView1.DataSource = t.ToList();
            }

        }
        public void change()
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Player player = db.Players.Find(id);
            PlayerForm plForm = new PlayerForm();
            plForm.numericUpDownAge.Value = player.Age;
            plForm.textBoxName.Text = player.Name;
            List<Team> teams = db.Teams.ToList();
            plForm.listBoxComand.DataSource = teams;
            plForm.listBoxComand.ValueMember = "Id";
            plForm.listBoxComand.DisplayMember = "Name";
            foreach (Team te in player.Teams)
                plForm.listBoxComand.SelectedItem = te;
            DialogResult result = plForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            player.Age = (int)plForm.numericUpDownAge.Value;
            player.Name = plForm.textBoxName.Text;
            foreach (var team in teams)
            {
                if (plForm.listBoxComand.SelectedItems.Contains(team))
                {
                    if (!player.Teams.Contains(team))
                        player.Teams.Add(team);
                }
                else
                {
                    if (player.Teams.Contains(team))
                        player.Teams.Remove(team);
                }
            }
            db.Entry(player).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Ифнормация обновлена");
            var t = from c in db.Players select new { c.Id, c.Name, c.Age };

            dataGridView1.DataSource = t.ToList();

        }
        public void remove()
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Не выбран игрок для удаления");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;
            int id = 0;
            bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
            if (converted == false)
                return;
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            MessageBox.Show("Футболист успешно удалён");
            var t = from c in db.Players select new { c.Id, c.Name, c.Age };

            dataGridView1.DataSource = t.ToList();

        }
        public void addToTeam()
        {
            TeamForm tmForm = new TeamForm();
            DialogResult result = tmForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            Team team = new Team();
            team.Name = tmForm.textBoxTitle.Text;
            team.Coach = tmForm.textBoxTrainer.Text;
            team.Players = new List<Player>();
            if ((team.Name == "") || (team.Coach == ""))
                MessageBox.Show("Ошибка. Присутствуют пустые поля");
            else
            {
                db.Teams.Add(team);
                db.SaveChanges();
                MessageBox.Show("Новая команда добавлена");
            }

        }
        //---------------------------------------------------------------------------------------Button
        private void buttonAdd_Click(object sender, EventArgs e) { add(); }
        private void buttonСhange_Click(object sender, EventArgs e) { change(); }
        private void buttonRemove_Click(object sender, EventArgs e) { remove(); }
        private void buttonAddToTeam_Click(object sender, EventArgs e) { addToTeam(); }
    }
}
