using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace C5
{
    public partial class Form2 : Form
    {
        private int nrCamere;
        private int nrZile;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ocupareTableAdapter.Fill(this.rHDS.Ocupare);
            this.rezervariTableAdapter.Fill(this.rHDS.Rezervari);

            nrZile = rHDS.Ocupare.Rows.Count;
            nrCamere = rHDS.Ocupare.Columns.Count - 1;

            filtreazaStoc();
        }
        private void filtreazaStoc()
        {
            string filter = $"DataSosire >= #05/01/2024#AND DataPlecare <= #05/31/2024#";

            rezervariBindingSource.Filter = filter;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String camera;
            int z1, z2;
            DateTime d1, d2;
            DataRow r2;
            String client;

            foreach (DataRow r1 in rHDS.Rezervari)
            {
                client = r1["Nume"].ToString();
                camera = r1["Camera"].ToString();
                d1 = (DateTime)r1["DataSosire"];
                d2 = (DateTime)r1["DataPlecare"];
                z1 = d1.Day;
                z2 = d2.Day;
                if (d1.Month == 5 && d2.Month == 5)
                {
                    for (int i = z1; i < z2; i++)
                    {
                        r2 = rHDS.Ocupare.Rows[i - 1];
                        r2[camera] = client;


                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contor = 0;

            foreach (DataRow r in rHDS.Ocupare)
            {
                for (int i = 1; i <= nrCamere; i++)
                    if (r[i].ToString() != "") contor++;
            }

            txtGradOcupare.Text = "" + contor + " rezervari";
            txtProcent.Text = "" + contor * 100 / (nrCamere * nrZile) + " %";

            int[] yval = new int[nrCamere];

            string[] xval = new string[nrCamere];

            for (int i = 1; i <= nrCamere; i++)
                xval[i - 1] = rHDS.Ocupare.Columns[i].Caption;

            foreach (DataRow r in rHDS.Ocupare)
            {
                for (int i = 1; i <= nrCamere; i++)
                    if (r[i].ToString() != "") yval[i - 1]++;
            }
            chart1.Series[0].Points.DataBindXY(xval, yval);
            chart1.Series[0].Name = "Grad ocupare";
            chart1.Series[0].ChartType = SeriesChartType.Column;



        }


    }
}
