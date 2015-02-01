using StateManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SessionState : System.Web.UI.Page
    {
        public static List<Entry> entries;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["entries"] == null)
                {
                    entries = new List<Entry>();
                    entries.Add(new Entry("Entry 1", DateTime.Now));
                    Session["entries"] = entries;
                    bindRepeater();
                }
                else
                {
                    bindRepeater();
                }
            }
        }

        protected void btnAddEntry_Click(object sender, EventArgs e)
        {
            List<Entry> sessionStateEntries = (List<Entry>)Session["entries"];
            int entryCounter = sessionStateEntries.Count + 1;
            sessionStateEntries.Add(new Entry("Entry " + entryCounter, DateTime.Now));
            Session["entries"] = sessionStateEntries;
            bindRepeater();
        }

        private void bindRepeater()
        {
            Repeater1.DataSource = Session["entries"];
            Repeater1.DataBind();
        }
    }
}