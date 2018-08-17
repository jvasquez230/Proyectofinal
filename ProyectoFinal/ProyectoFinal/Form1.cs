using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ano = dateTimePicker1.Value.Year;
            var mes = dateTimePicker1.Value.Month;
            var dias = dateTimePicker1.Value.Day;

            var diasano = 365;
            var resultado = 0.00;
            var anoresultado = ano;

            var bisiesto = 0;

            var edadenano = DateTime.Now.Year - ano;

            for (int i = 0; i < edadenano; i++)
            {
                if (anoresultado % 4 == 0 && anoresultado % 100 != 0 || anoresultado % 400 == 0)
                {
                    bisiesto += 1;
                }
                anoresultado += 1;
            }

            var anoresultados = ((DateTime.Now.Year - ano) * diasano);
            var mesresultado = DateTime.Now.Month - mes;
            var diasresultado = (DateTime.Now.Day - dias) + bisiesto;

            resultado = (anoresultados + diasresultado + (mesresultado) * (diasano / 12));
            label2.Text = $"Usted tiene {resultado.ToString("#,##;#,##;0")} dias vividos";
        
        
        }
    }
}
