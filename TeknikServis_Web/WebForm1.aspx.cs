using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis_Web.Entitiy;

namespace TeknikServis_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var Degerler = db.TBLURUNTAKIP.ToList();
            //Repeater1.DataSource = Degerler;
            //Repeater1.DataBind();
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            var Degerler = db.TBLURUNTAKIP.Where(x => x.SERİNO == TextBox1.Text);
            Repeater1.DataSource = Degerler.ToList();
            Repeater1.DataBind();
        }
    }
}