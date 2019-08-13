using DiscordRPC;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CustomPresenceTool
{
    public partial class MainForm : MetroForm
    {
        private DiscordRpcClient m_Client;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (m_Client != null)
            {
                button_Connect.Text = "Connect";
                label_StatusDescription.Text = "Not Connected";
                m_Client.Dispose();
                m_Client = null;
            }
            else
            {
                button_Connect.Text = "Disconnect";
                label_StatusDescription.Text = "Connecting";
                m_Client = new DiscordRpcClient(textBox_ClientID.Text);
                m_Client.OnReady += (_sender, _e) =>
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        label_StatusDescription.Text = "Ready";
                        ShowMessage($"OnReady: {_e.User.Username}#{_e.User.Discriminator}");
                    }));
                };
                m_Client.OnClose += (_sender, _e) =>
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        label_StatusDescription.Text = "Not Connected";
                        ShowMessage($"OnClose: {_e.Code} {_e.Reason}");
                    }));
                };
                m_Client.OnError += (_sender, _e) =>
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        label_StatusDescription.Text = "Error Occured";
                        ShowMessage($"OnError: {_e.Code} {_e.Message}");
                    }));
                };
                m_Client.OnConnectionEstablished += (_sender, _e) =>
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        label_StatusDescription.Text = "Connected";
                        ShowMessage($"OnConnectionEstablished: Pipe#{_e.ConnectedPipe}");
                    }));
                };
                m_Client.OnConnectionFailed += (_sender, _e) =>
                {
                    BeginInvoke(new MethodInvoker(() =>
                    {
                        label_StatusDescription.Text = "Connect Failed";
                        ShowMessage($"OnConnectionFailed: Pipe#{_e.FailedPipe}");
                    }));
                };
                m_Client.OnPresenceUpdate += (_sender, _e) =>
                {
                    // ShowMessage("OnPresenceUpdate");
                };
                m_Client.Initialize();
            }
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            var form = HelpForm.Instance;
            if (form == null)
            {
                form = new HelpForm();
            }
            form.Show();
        }

        private void ShowMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() =>
                {
                    ShowMessage(message);
                }));
            }
            else
            {
                listBox_Log.BeginUpdate();
                while (listBox_Log.Items.Count >= 100)
                {
                    listBox_Log.Items.RemoveAt(0);
                }
                listBox_Log.Items.Add(message);
                listBox_Log.SelectedIndex = listBox_Log.Items.Count - 1;
                listBox_Log.EndUpdate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_Client != null)
            {
                m_Client.Invoke();

                var has = false;
                var rp = new RichPresence();

                if (checkBox_Details.Checked &&
                    textBox_Details.Text.Length >= 2)
                {
                    rp.Details = textBox_Details.Text;
                    has = true;
                }

                if (checkBox_State.Checked &&
                    textBox_State.Text.Length >= 2)
                {
                    rp.State = textBox_State.Text;
                    has = true;
                }

                if (checkBox_LargeImageKey.Checked ||
                    checkBox_LargeImageText.Checked ||
                    checkBox_SmallImageKey.Checked ||
                    checkBox_SmallImageText.Checked)
                {
                    var a = new Assets();
                    if (checkBox_LargeImageKey.Checked)
                    {
                        a.LargeImageKey = textBox_LargeImageKey.Text;
                    }
                    if (checkBox_LargeImageText.Checked)
                    {
                        a.LargeImageText = textBox_LargeImageText.Text;
                    }
                    if (checkBox_SmallImageKey.Checked)
                    {
                        a.SmallImageKey = textBox_SmallImageKey.Text;
                    }
                    if (checkBox_SmallImageText.Checked)
                    {
                        a.SmallImageText = textBox_SmallImageText.Text;
                    }
                    rp.Assets = a;
                    has = true;
                }

                // Details나 State가 설정되어야 값이 나옴
                // PC는 상관이 없는데 MOBILE에서 그럼
                if (checkBox_Start.Checked ||
                    checkBox_End.Checked)
                {
                    var timestamps = new Timestamps();
                    if (checkBox_Start.Checked)
                    {
                        timestamps.Start = dtp_Start.Value.ToUniversalTime();
                    }
                    // Start가 설정되어야 함.
                    // 안그럼 디코가 터짐
                    if (checkBox_Start.Checked &&
                        checkBox_End.Checked)
                    {
                        timestamps.End = dtp_End.Value.ToUniversalTime();
                    }
                    rp.Timestamps = timestamps;
                    has = true;
                }

                if (checkBox_Party.Checked &&
                    nud_PartySize.Value < nud_PartyMax.Value)
                {
                    rp.WithParty(new Party
                    {
                        ID = "pypy",
                        Size = (int)nud_PartySize.Value,
                        Max = (int)nud_PartyMax.Value
                    });
                    has = true;
                }

                if (has)
                {
                    m_Client.SetPresence(rp);
                }
                else
                {
                    m_Client.SetPresence(null);
                }
            }
        }

        private void listBox_Log_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox_Log.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var file = File.Open("config.ini", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var reader = new StreamReader(file, Encoding.UTF8))
                    {
                        for (; ; )
                        {
                            var line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            var array = line.Split(new char[] { '=' }, 2);
                            if (array.Length == 2)
                            {
                                var controls = Controls.Find(array[0], false);
                                if (controls.Length > 0)
                                {
                                    if (controls[0] is MetroCheckBox checkBox)
                                    {
                                        if (bool.TryParse(array[1], out bool result))
                                        {
                                            checkBox.Checked = result;
                                        }
                                    }
                                    else if (controls[0] is MetroTextBox textBox)
                                    {
                                        textBox.Text = array[1];
                                    }
                                    else if (controls[0] is DateTimePicker dtp)
                                    {
                                        if (long.TryParse(array[1], out long result))
                                        {
                                            dtp.Value = new DateTime(result);
                                        }
                                    }
                                    else if (controls[0] is NumericUpDown nud)
                                    {
                                        if (decimal.TryParse(array[1], out decimal result))
                                        {
                                            nud.Value = result;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (var file = File.Open("config.ini", FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (var writer = new StreamWriter(file, Encoding.UTF8))
                    {
                        foreach (var control in Controls)
                        {
                            if (control is MetroCheckBox checkBox)
                            {
                                writer.WriteLine("{0}={1}", checkBox.Name, checkBox.Checked);
                            }
                            else if (control is MetroTextBox textBox)
                            {
                                writer.WriteLine("{0}={1}", textBox.Name, textBox.Text);
                            }
                            else if (control is DateTimePicker dtp)
                            {
                                writer.WriteLine("{0}={1}", dtp.Name, dtp.Value.Ticks);
                            }
                            else if (control is NumericUpDown nud)
                            {
                                writer.WriteLine("{0}={1}", nud.Name, nud.Value);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            dtp_End.MinDate = dtp_Start.Value;
        }

        private void nud_PartyMax_ValueChanged(object sender, EventArgs e)
        {
            nud_PartySize.Maximum = nud_PartyMax.Value;
        }
    }
}
