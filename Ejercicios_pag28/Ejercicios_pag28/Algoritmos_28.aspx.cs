using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios_pag28
{
    public partial class Algoritmos_28 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcu_Click(object sender, EventArgs e)
        {
            double cant_pesos, result;
            double tasa_cam;
            cant_pesos = Convert.ToDouble(textpe.Text);
            tasa_cam = Convert.ToDouble(texttasa.Text);
            result = cant_pesos * tasa_cam;


            lblresult.Text = System.Convert.ToString(result);
        }

        protected void btnboton_Click(object sender, EventArgs e)
        {
            int num1,resul;

            num1 = Convert.ToInt32(txtnum1.Text);
          
            resul = Math.Abs(num1);

            lblresulta.Text = System.Convert.ToString(resul);
        }

        protected void btngana_Click(object sender, EventArgs e)
        {
            int capi;
            double porce = 0.02,result;

            capi = Convert.ToInt32(txtcapi.Text);
           
            result = capi * porce;

            lbltotal.Text= System.Convert.ToString(result);
        }

        protected void btncal_comi_Click(object sender, EventArgs e)
        {
            int sal, vent1, vent2, vent3, tot_vent;
            double porce = 0.10,comi;

            sal = Convert.ToInt32(Textsal.Text);
            vent1= Convert.ToInt32(textven_1.Text);
            vent2= Convert.ToInt32(textven_2.Text);
            vent3= Convert.ToInt32(textven_3.Text);

            tot_vent = vent1 + vent2 + vent3;
            comi = tot_vent * porce;

            lblcomi.Text = System.Convert.ToString(comi);
        }

        protected void btncal_toti_Click(object sender, EventArgs e)
        {

            int sal, vent1, vent2, vent3, tot_vent;
            double porce = 0.10, comi,tota_pago;

            sal = Convert.ToInt32(Textsal.Text);
            vent1 = Convert.ToInt32(textven_1.Text);
            vent2 = Convert.ToInt32(textven_2.Text);
            vent3 = Convert.ToInt32(textven_3.Text);

            tot_vent = vent1 + vent2 + vent3;
            comi = tot_vent * porce;
            tota_pago = sal + comi;

            lbltoti.Text = System.Convert.ToString(tota_pago);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int total_com;
            double desc, porc = 0.15, total_pa;

            total_com = Convert.ToInt32(Texttota_com.Text);

            desc = total_com * porc;

            total_pa = total_com - desc;

            Lbltoti_pagar.Text = System.Convert.ToString(total_pa);
        }

        protected void Btnnota_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, ex_fi, tra_fi;
            double prom, por_notas = 0.55, por_ex_fi = 0.30, por_tra_fi = 0.15,cal_final,not_par,not_exfin,not_calfin;

            cal1 = Convert.ToDouble(Textcal1.Text);
            cal2= Convert.ToDouble(Textcal2.Text);
            cal3= Convert.ToDouble(Textcal3.Text);
            ex_fi= Convert.ToDouble(Textex_fi.Text);
            tra_fi= Convert.ToDouble(Texttra_fi.Text);

            prom = (cal1 + cal2 + cal3) / 3;

            not_par = prom * por_notas;
            not_exfin = ex_fi * por_ex_fi;
            not_calfin = tra_fi * por_tra_fi;

            cal_final = not_par + not_exfin + not_calfin;

            Lblnota.Text = System.Convert.ToString(cal_final);

        }

        protected void Btnmuje_Click(object sender, EventArgs e)
        {
            int cant_muje, cant_homb;
             double porc=100,porc_mujer,  total_alu;

            cant_muje= Convert.ToInt32(Textmuje.Text);
            cant_homb= Convert.ToInt32(Texthom.Text);

            total_alu = cant_homb + cant_muje;
            porc_mujer = cant_muje + porc / total_alu;

            Lblpor_muj.Text = System.Convert.ToString(porc_mujer+"%");
        }

        protected void Btnhom_Click(object sender, EventArgs e)
        {
            int cant_muje, cant_homb;
            double porc = 100, porc_hom, total_alu;

            cant_muje = Convert.ToInt32(Textmuje.Text);
            cant_homb = Convert.ToInt32(Texthom.Text);

            total_alu = cant_homb + cant_muje;
            porc_hom = cant_homb + porc / total_alu;

            Lblpor_hom.Text = System.Convert.ToString(porc_hom+"%");
        }

        protected void Btnedad_Click(object sender, EventArgs e)
        {
            int fech_act, fech_nac, edad;

            fech_nac= Convert.ToInt32(Textnac.Text);
            fech_act= Convert.ToInt32(Textact.Text);

            edad = fech_act - fech_nac;

            Lbledad.Text = System.Convert.ToString(edad);
        }
    }
    }
