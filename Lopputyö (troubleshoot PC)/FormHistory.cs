using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PCTroubleshooter
{
    public partial class FormHistory : Form
    {
        private readonly string historyFilePath = Path.Combine(Application.StartupPath, "historia.txt");

        public FormHistory()
        {
            InitializeComponent();
            Form1.FormatButton(btnClose);
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
            lstHistory.Items.Clear();

            if (File.Exists(historyFilePath))
            {
                string[] lines = File.ReadAllLines(historyFilePath);

                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    lstHistory.Items.Add(lines[i]);
                }
            }
            else
            {
                lstHistory.Items.Add("Ei vielä historiaa.");
            }
        }

        private void lstHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstHistory.SelectedItem != null)
            {
                string selectedLine = lstHistory.SelectedItem.ToString();

                if (File.Exists(historyFilePath))
                {
                    List<string> lines = File.ReadAllLines(historyFilePath).ToList();
                    lines.Remove(selectedLine);
                    File.WriteAllLines(historyFilePath, lines);
                }

                LoadHistory();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}