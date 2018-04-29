using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppTheatherAsk
{
    public partial class Form1 : Form
    {
        private string[] domandeS;
        public Form1()
        {
            InitializeComponent();
            domandeS = Helper.CallFTP();
            if (domandeS == null)
            {
            }
            else
            {
                foreach (var domanda in domandeS)
                {
                    listBoxDomande.Items.Add(domanda);
                }
            }

            var timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            domandeS = Helper.CallFTP();

            for (int i = domandeS.Length - 1; i >= 0; i--)
            {
                if (domandeS[i] == "")
                {
                    Array.Resize(ref domandeS, domandeS.Length - 1);

                }
            }




            string[] arr = new string[listBoxDomande.Items.Count];
            for (int i = 0; i < listBoxDomande.Items.Count; i++)
            {
                arr[i] = listBoxDomande.Items[i].ToString();
            }
            if (domandeS == null || domandeS.SequenceEqual(arr))
            {
            }
            else
            {
                listBoxDomande.Items.Clear();

                foreach (var domanda in domandeS)
                {
                    listBoxDomande.Items.Add(domanda);
                }
            }
        }

        private void buttonRifiuta_Click(object sender, EventArgs e)
        {
            domandeS[listBoxDomande.SelectedIndex] = "";
            Array.Sort(domandeS);
            Array.Reverse(domandeS);
            if (domandeS.Length - 1 != 0)
            {
                Array.Resize(ref domandeS, domandeS.Length - 1);
            }
            var newDomande = default(string);
            foreach (var domande in domandeS)
            {
                newDomande += domande + "/";
            }

            Helper.Rifiuta(newDomande);
            domandeS = Helper.CallFTP();
            listBoxDomande.Items.Clear();
            foreach (var domanda in domandeS)
            {
                listBoxDomande.Items.Add(domanda);
            }
        }

        private void buttonAccetta_Click(object sender, EventArgs e)
        {
            var domandaAccettata = Convert.ToString(listBoxDomande.Items[listBoxDomande.SelectedIndex]);
            domandeS[listBoxDomande.SelectedIndex] = "";
            Array.Sort(domandeS);
            Array.Reverse(domandeS);
            if (domandeS.Length - 1 != 0)
            {
                Array.Resize(ref domandeS, domandeS.Length - 1);
                var newDomande = default(string);
                foreach (var domande in domandeS)
                {
                    newDomande += domande + "/";
                }

                Helper.Accetta(domandaAccettata, newDomande);
                domandeS = Helper.CallFTP();
                listBoxDomande.Items.Clear();
                foreach (var domanda in domandeS)
                {
                    listBoxDomande.Items.Add(domanda);
                }
            }
            else
            {
                Helper.Accetta(domandaAccettata, "");
                domandeS = Helper.CallFTP();
                listBoxDomande.Items.Clear();
                foreach (var domanda in domandeS)
                {
                    listBoxDomande.Items.Add(domanda);
                }
            }

        }
    }
}
