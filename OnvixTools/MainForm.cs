using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Leaf.xNet;
using Newtonsoft.Json.Linq;

namespace OnvixTools
{
    public partial class MainForm : Form
    {
        string FilmMp4URL;
        FilmFormats FormatMp4;

        public MainForm()
        {
            Application.Run(new AuthForm());
            InitializeComponent();

            FilmName.Text = "";
            FilmType.Text = "...";
            UrlTB.Text = Globals.SiteURL;
        }

        private void GetB_Click(object sender, EventArgs e)
        {
            string filmType;
            string FilmId;
            string VoiceId;

            Match regex = Regex.Match(UrlTB.Text, "(.*)\\/(.*)\\/(.*)\\/play\\?stream=(.*)");

            if (regex.Success)
            {
                filmType = regex.Groups[2].Value;
                FilmId = regex.Groups[3].Value;
                VoiceId = regex.Groups[4].Value;
            }
            else
            {
                MessageBox.Show("Error!" + Environment.NewLine + "Enter a valid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (HttpRequest request = new HttpRequest()
            {
                UserAgent = "Mozilla/5.0",
                Cookies = Globals.Cookie
            })
            {
                try
                {
                    #region MainInfo
                    var filmFullInfo = request.Get($"{Globals.SiteURL}/api/mobile/v1/{filmType}s/{FilmId}.json");

                    dynamic film = JObject.Parse(filmFullInfo.ToString());

                    Poster.Load(Globals.SiteURL + film[filmType]["poster"]["medium"]);
                    FilmName.Text = film[filmType]["title_ru"];
                    FilmType.Text = filmType;
                    #endregion

                    var filmVideo = request.Get($"{Globals.SiteURL}/api/mobile/v1/streaming/{filmType}s/{FilmId}/{VoiceId}".Replace("&", "?"));

                    film = JObject.Parse(filmVideo.ToString());

                    if (MP4rb.Checked)
                    {
                        if (film["media_files"]["mp4"] != null)
                        {
                            if (((string)film["media_files"]["mp4"]).StartsWith("http"))
                            {
                                ResultTB.Text = film["media_files"]["mp4"];
                            }
                            else
                            {
                                ResultTB.Text = "https:" + film["media_files"]["mp4"];
                            }
                            FilmMp4URL = ResultTB.Text;

                            #region Create FilmFormats

                            Qu1080.Visible = true;
                            Qu720.Visible = true;
                            Qu480.Visible = true;
                            Qu360.Visible = true;

                            JObject filmFormats = JObject.Parse(request.Get(FilmMp4URL).ToString());

                            FormatMp4 = new FilmFormats()
                            {
                                FullHD = (string)filmFormats["1080"],
                                HD = (string)filmFormats["720"],
                                Normal = (string)filmFormats["480"],
                                Zepa = (string)filmFormats["360"]
                            };

                            if (FormatMp4.FullHD == null)
                            {
                                Qu1080.Visible = false;
                            }
                            if (FormatMp4.HD == null)
                            {
                                Qu720.Visible = false;
                            }
                            if (FormatMp4.Normal == null)
                            {
                                Qu480.Visible = false;
                            }
                            if (FormatMp4.Zepa == null)
                            {
                                Qu360.Visible = false;
                            }
                            #endregion

                            ParsePanel.Visible = true;
                        }
                        else
                        {
                            ResultTB.Text = "Nothing";
                        }
                    }
                    else
                    {
                        if (film["media_files"]["hls"] != null)
                        {
                            if (((string)film["media_files"]["hls"]).StartsWith("http"))
                            {
                                ResultTB.Text = film["media_files"]["hls"];
                            }
                            else
                            {
                                ResultTB.Text = "https:" + film["media_files"]["hls"];
                            }
                        }
                        else
                        {
                            ResultTB.Text = "Nothing";
                        }
                        ParsePanel.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Woops! Something went wrong, contact the developer and send a screenshot of this window." + Environment.NewLine + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void ParseMP4b_Click(object sender, EventArgs e)
        {
            try
            {
                if (MP4rb.Checked && ResultTB.TextLength > 0 && ResultTB.Text != "Nothing")
                {
                    if (Qu360.Checked == true)
                    {
                        ResultTB.Text = FormatMp4.Zepa;
                    }
                    if (Qu480.Checked == true)
                    {
                        ResultTB.Text = FormatMp4.Normal;
                    }
                    if (Qu720.Checked == true)
                    {
                        ResultTB.Text = FormatMp4.HD;
                    }
                    if (Qu1080.Checked == true)
                    {
                        ResultTB.Text = FormatMp4.FullHD;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect result in mp4 format", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Woops! Something went wrong, contact the developer and send a screenshot of this window." + Environment.NewLine + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
