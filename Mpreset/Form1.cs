using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Mpreset
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.minecraftPath == "" || Properties.Settings.Default.profilePath == "")
            {
                mcPath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Roaming\\.minecraft");
                profilePath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Roaming\\MPreset");

                Properties.Settings.Default.minecraftPath = mcPath.Text;
                Properties.Settings.Default.profilePath = profilePath.Text;
            }
            else
            {
                mcPath.Text = Properties.Settings.Default.minecraftPath;
                profilePath.Text = Properties.Settings.Default.profilePath;
            }

            if (!Directory.Exists(profilePath.Text)) Directory.CreateDirectory(profilePath.Text);

            if (!File.Exists(profilePath.Text))
            {
                File.WriteAllText(Path.Combine(profilePath.Text, "profile.db"), "");
                using (SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(profilePath.Text, "profile.db")};Version=3;"))
                {
                    SQLiteCommand command = new SQLiteCommand("CREATE TABLE profile (TEXT name, TEXT path)", conn);
                    command.ExecuteNonQuery();
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={Path.Combine(profilePath.Text, "profile.db")};Version=3;"))
            {
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM profile", conn);
                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        profileList.Items.Add(new )
                    }
                }
            }
        }

        private void mcPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                mcPath.Text = dialog.SelectedPath;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {

        }

        private void applyrun_Click(object sender, EventArgs e)
        {

        }

        private void apply_Click(object sender, EventArgs e)
        {

        }
    }
}
