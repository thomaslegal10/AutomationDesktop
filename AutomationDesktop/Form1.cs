using System.Runtime.InteropServices;

namespace AutomationDesktop
{
    public partial class Form1 : Form
    {
        private List<Commands> commands = new List<Commands>();
        private bool start_mapeamento = false;
        public int stepe = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_mapear_Click(object sender, EventArgs e)
        {
            start_mapeamento = true;
            bt_mapear.Visible = false;
            bt_parar.Visible = true;
            new Thread(new ThreadStart(Mapear)).Start();
        }

        private void Mapear()
        {
            while (start_mapeamento)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;

                this.Invoke(delegate
                {
                    this.lbl_x.Text = "X:" + x.ToString();
                    this.lbl_y.Text = "Y:" + y.ToString();
                });
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (start_mapeamento)
            {
                new Thread(new ThreadStart(CallFormAgain)).Start();

                commands.Add(new Commands { Type = "Click", Value = MousePosition });
                lv_itens.Items.Add(new ListViewItem(new String[] { stepe.ToString(), "Click", string.Concat(MousePosition.X.ToString(), ',', MousePosition.Y.ToString()) }));
                stepe++;
            }
        }

        private void CallFormAgain()
        {
            this.Invoke(delegate
            {
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;
                else
                {
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                    BringToFront();
                }

                Activate();
            });
        }

        private void bt_parar_Click(object sender, EventArgs e)
        {
            start_mapeamento = false;
            bt_mapear.Visible = true;
            bt_parar.Visible = false;
        }

        private void bt_add_texto_Click(object sender, EventArgs e)
        {
            if (start_mapeamento)
            {
                start_mapeamento = false;
            }
            string promptValue = ShowDialog("Informa um valor", "RPA");
            if (!string.IsNullOrEmpty(promptValue))
            {
                commands.Add(new Commands { Type = "Text", Value = promptValue });
                lv_itens.Items.Add(new ListViewItem(new String[] { stepe.ToString(), "Text", promptValue }));
                stepe++;
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) =>
            {
                prompt.Close();
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(StartProccess)).Start();
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private void StartProccess()
        {
            foreach (var command in commands)
            {
                if (command.Type == "Click")
                {
                    this.Invoke(delegate
                    {
                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        Thread.Sleep(1000);
                        Cursor.Position = command.Value;

                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(100);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    });
                }
                else
                {
                    SendKeys.SendWait(command.Value);
                }
            }
        }
    }
}