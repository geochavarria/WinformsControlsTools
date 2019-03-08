using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolMenuStrip
{
    public partial class StartProject : Form
    {
        public StartProject()
        {
            InitializeComponent();
        }

        List<string> lstItemMenu = new List<string>()
        {
            { "Menu 1"},
            { "Menu 2"},
            { "Menu 3"},
            { "Menu 4"},
            { "Menu 5"},
        };


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuStrip_Click(object sender, EventArgs e)
        {
            ContextMenuStrip dialogMenu = new ContextMenuStrip();

            //Location Button
            this.Cursor = new Cursor(Cursor.Current.Handle);

            dialogMenu.Items.Add("Menu 1");
            dialogMenu.Items.Add("Menu 2");
            dialogMenu.Items.Add("Menu 3");
            dialogMenu.Items.Add("Menu 4");
            dialogMenu.Items.Add("Menu 5");


            dialogMenu.Show(Cursor.Position.X, Cursor.Position.Y);

            dialogMenu.ItemClicked += new ToolStripItemClickedEventHandler(DialogMenuPrint_ItemClicked);
        }
        private void DialogMenuPrint_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string message = $"This is {e.ClickedItem.ToString()} ";

            switch (e.ClickedItem.ToString())
            {
                case "Menu 1":
                                       
                    break;
                case "Menu 2":
                   
                    break;
                case "Menu 3":
                   
                    break;
                case "Menu 4":
                   
                    break;
                default:
                    break;
            }

            MessageBox.Show(message,"Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
