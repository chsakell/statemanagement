using StateManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ViewState : System.Web.UI.Page
    {
        public static List<Entry> entries;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["entries"] == null)
                {
                    entries = new List<Entry>();
                    entries.Add(new Entry("Entry 1", DateTime.Now));
                    ViewState["entries"] = entries;
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
            List<Entry> viewStateEntries = (List<Entry>)ViewState["entries"];
            int entryCounter = viewStateEntries.Count + 1;
            viewStateEntries.Add(new Entry("Entry " + entryCounter,DateTime.Now));
            ViewState["entries"]= viewStateEntries;
            bindRepeater();
        }

        private void bindRepeater()
        {
            Repeater1.DataSource = ViewState["entries"];
            Repeater1.DataBind();
        }
    }
}