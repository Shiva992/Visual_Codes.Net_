using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqOperation
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var distinct = from p in ListBox1.Items.OfType<ListItem>()
                        .Concat(ListBox2.Items.OfType<ListItem>())
                        .Where(o => o.Selected)
                        .Distinct()
                           select new
                           {
                               Text = p.Text
                           };


            foreach (var item in distinct)
            {
                Response.Write(item.Text + "<br/>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var list1 = from p in ListBox1.Items.OfType<ListItem>()
                        .Where(o => o.Selected)
                        select new
                        {
                            Text = p.Text
                        };

            var list2 = from p in ListBox2.Items.OfType<ListItem>()
                    .Where(o => o.Selected)
                        select new
                        {
                            Text = p.Text
                        };

            var unique = list1.Union(list2);

            foreach (var item in unique)
            {
                Response.Write(item.Text + "<br/>");
            }
        }
    }
}