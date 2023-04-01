using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AL_SULTAN.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void loadPage(UserControl PageuserControl)
        {
            //Load Old Page
            var oldpage=main.panelcontainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldpage != null)
            {
                main.panelcontainer.Controls.Remove(oldpage);  //Remove Old Page
                oldpage.Dispose();
            }
            //Load New Page
            PageuserControl.Dock = DockStyle.Fill;  
            main.panelcontainer.Controls.Add(PageuserControl);
        }
    }
}
