using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Leaf.xNet;

namespace OnvixTools
{
    public partial class AuthForm : Form
    {
        bool badAuth = true;
        BinaryFormatter formatter = new BinaryFormatter();
        public AuthForm()
        {
            InitializeComponent();

            try
            {
                if (File.Exists("data.dat"))
                {
                    using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                    {
                        string[] data = (string[])formatter.Deserialize(fs);

                        LoginTB.Text = data[0];
                        PassTB.Text = data[1];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Load error", "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete("data.dat");
            }
        }

        private void SignInB_Click(object sender, EventArgs e)
        {
            Globals.SiteURL = SiteUrlTB.Text;

            using (HttpRequest http = new HttpRequest()
            {
                UserAgent = "Mozilla/5.0"
            })
            {
                RequestParams content = new RequestParams()
                {
                    ["user[email]"] = LoginTB.Text,
                    ["user[password]"] = PassTB.Text,
                    ["user[remember_me]"] = "true",
                    ["mobile"] = "true",
                    ["redirect_to"] = "/m/"
                };

                try
                {
                    if (http.Post($"{Globals.SiteURL}/users/sign_in.json", content).IsOK)
                    {
                        if (RemLP.Checked)
                        {
                            using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                            {
                                string[] data = new string[] { LoginTB.Text, PassTB.Text };

                                formatter.Serialize(fs, data);
                            }
                        }

                        MessageBox.Show($"Done!", "Auth", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Globals.Cookie = http.Cookies;
                        badAuth = false;
                        Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Error!", "Auth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (badAuth)
            {
                Environment.Exit(0);
            }
        }
    }
}
