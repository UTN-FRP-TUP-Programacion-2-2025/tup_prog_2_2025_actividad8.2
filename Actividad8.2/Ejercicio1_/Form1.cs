using Ejercicio1_.Models;

namespace Ejercicio1_
{
    public partial class Form1 : Form
    {
        List<IExportable> exportables = new List<IExportable>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IExportable nuevo = null;

            string patente = textBox1.Text;
            DateOnly vencimiento = new DateOnly(dateTimePicker1.Value.Year,
               dateTimePicker1.Value.Month,
               dateTimePicker1.Value.Day);
            double importe = Convert.ToDouble(textBox2.Text);

            nuevo = new Multa(patente, vencimiento, importe);

            exportables.Sort();
            int idx = exportables.BinarySearch(nuevo);
            if (idx >= 0)
            {
                Multa multa = exportables[idx] as Multa;
                multa.Importe += importe;
                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
            }
            else
                exportables.Add(nuevo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //listBox1.Items.AddRange( exportables.ToArray() );
            foreach (IExportable multa in exportables)
            {
                listBox1.Items.Add(multa);
            }
        }
    }
}
