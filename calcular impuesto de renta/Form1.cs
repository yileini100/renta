using System.Diagnostics.Eventing.Reader;

namespace calcular_impuesto_de_renta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string Status;
            double sueldoNeto;
            double isr;
            double afp, sfs;

            // Obtener los datos ingresados por el usuario
            double sueldo = Convert.ToDouble(txt_Sueldo.Text);

            //PROCESO

             afp = sueldo * 0.0287; // 2.87%
             sfs = sueldo* 0.0304; // 3.04%


            double totalDescuentos = afp + sfs;
            sueldoNeto = (sueldo - totalDescuentos) * 12;

            
            if (sueldoNeto <= 416220.00)
            {
                isr = 0;
                txt_Status.Text = " no aplica";
            }
            else if (sueldoNeto >= 416220.01 && sueldoNeto <= 624329.00)
            {
                isr = (sueldoNeto- 416220.00) * 0.15;
                txt_Status.Text = "aplica";
            }
            else if (sueldoNeto >= 624329.01 && sueldoNeto <= 867123.00)
            {
                isr = (sueldoNeto - 624329.00) * 0.20 + 31216.00 / 12;
                txt_Status.Text = "aplica";
            }
            else if (sueldoNeto <= 867123.01 && sueldoNeto <= 100000.00)
            {
                isr = (sueldoNeto - 867123.00) * 0.25 + 79776.00 / 12;
                txt_Status.Text = "aplica";
            }
            else
            {
                isr = (sueldoNeto - 1000000.00) * 0.30 + 181920.00 / 12;
                txt_Status.Text = "aplica";
            }



            //salida de ddatos
            txt_ISR.Text = isr.ToString();
            txt_AFP.Text = afp.ToString("0.00");
            txt_SFS.Text = sfs.ToString("0.00");
       
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txt_Sueldo.Clear();  
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_ISR.Clear();
            txt_Status.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
