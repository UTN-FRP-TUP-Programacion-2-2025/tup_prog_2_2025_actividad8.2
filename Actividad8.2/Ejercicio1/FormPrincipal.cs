using Ejercicio1.Models;
using Ejercicio1.Models.Exportadores;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        List<IExportable> lista = new List<IExportable>();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            #region parseo
            string patente = tbPatente.Text;
            DateOnly vencimiento =  new DateOnly( dtpVencimiento.Value.Year,
                                                   dtpVencimiento.Value.Month,
                                                   dtpVencimiento.Value.Day);
            double importe = Convert.ToDouble(tbImporte.Text);
            #endregion

            IExportable nuevo = new Multa(patente, vencimiento, importe);
            lista.Add(nuevo);

            ////agregando lo propio para cumplir el punto 7

            btnActualizar.PerformClick(); //llama al evento onclick del botón Actualizar
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            foreach (IExportable multa in lista)
            {
                lsbVer.Items.Add(multa);
            }

        }

        private void lsbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            IExportable selectedExportable = lsbVer.SelectedItem as IExportable;

            if (selectedExportable != null)
            {
                var multa = selectedExportable as Multa;

                tbPatente.Text = multa.Patente;
                dtpVencimiento.Value = multa.Vencimiento.ToDateTime(new TimeOnly(0, 0));
                tbImporte.Text = multa.Importe.ToString("0.00");
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = " Importando multas";
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json|(txt)|*.txt|(xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int extSelected = openFileDialog1.FilterIndex;
                IExportador exportador= new ExportadorFactory().GetInstance(extSelected);
 
                FileStream fs = null; ;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        IExportable nuevo = new Multa();
                        

                        if(nuevo.Importar(linea, exportador)==true)
                            lista.Add(nuevo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }

                btnActualizar.PerformClick();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string path = saveFileDialog1.FileName;

            //    FileStream fs = null;
            //    StreamWriter sw = null;
            //    try
            //    {
            //        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            //        sw = new StreamWriter(fs);

            //        foreach (Cuenta cuenta in cuentas)
            //        {
            //            string nombre = cuenta.Nombre;
            //            if (cuenta.Nombre.Length > 10)
            //                nombre = nombre.Substring(0, 10);

            //            string linea = $"{ cuenta.DNI,+9}{ nombre,-10}{ cuenta.Importar,+9:f2}";

            //            sw.WriteLine(linea);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        if (sw != null) sw.Close();
            //        if (fs != null) fs.Close();
            //    }
            //}

        }
    }
}
