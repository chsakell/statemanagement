using StateManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        public static List<Entry> entries;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["entries"] == null)
                {
                    entries = new List<Entry>();
                    entries.Add(new Entry("Entry 1", DateTime.Now));
                    Application["entries"] = entries;
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
            List<Entry> applicationStateEntries = (List<Entry>)Application["entries"];
            int entryCounter = applicationStateEntries.Count + 1;
            applicationStateEntries.Add(new Entry("Entry " + entryCounter, DateTime.Now));
            Application["entries"] = applicationStateEntries;
            bindRepeater();
        }

        private void bindRepeater()
        {
            Repeater1.DataSource = Application["entries"];
            Repeater1.DataBind();
        }
    }
}