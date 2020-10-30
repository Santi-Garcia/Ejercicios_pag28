using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_1
{
    public partial class Formulario_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnboton_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(Text1.Text);
            num2 = Convert.ToInt32(Text2.Text);
            result = num1 + num2;

            Lblresult.Text = System.Convert.ToString(result);
        }
    }
}