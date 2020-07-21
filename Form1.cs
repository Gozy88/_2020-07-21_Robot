using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2020_07_21_Robot
{
    public partial class Form1 : Form
    {
        public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gozyo\source\repos\_2020-07-21_Robot\_2020-07-21_Robot\RobotDataBase.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            Paieska1TB.Visible = false;
            Paieska1LB.Visible = false;
            DataNuoTB.Visible = false;
            DataNuoLB.Visible = false;
            DataIkiTB.Visible = false;
            DataIkiLB.Visible = false;
            IeskotiB.Visible = false;
            DataNuoTB.Text = DateTime.MinValue.ToShortDateString();
            DataIkiTB.Text = DateTime.Today.ToShortDateString();
        }

        private void PagalUžsakymaRB_CheckedChanged(object sender, EventArgs e)
        {
            Paieska1TB.Visible = true;
            Paieska1LB.Text = "Užsakymo kodas:";
            Paieska1LB.Visible = true;
            IeskotiB.Visible = true;
            DataNuoTB.Visible = true;
            DataNuoLB.Visible = true;
            DataIkiTB.Visible = true;
            DataIkiLB.Visible = true;
            Paieska1TB.Text = null;        }

        private void PagalGaminioRB_CheckedChanged(object sender, EventArgs e)
        {
            Paieska1TB.Visible = true;
            Paieska1LB.Text = "Gaminio kodas:";
            Paieska1LB.Visible = true;
            IeskotiB.Visible = true;
            DataNuoTB.Visible = true;
            DataNuoLB.Visible = true;
            DataIkiTB.Visible = true;
            DataIkiLB.Visible = true;
            
            Paieska1TB.Text = null;
        }

      

        

        private void IeskotiB_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionString);

            if (PagalUžsakymaRB.Checked)
            {
                var tableData = db.GetTable<DrawingInDB>().Where(x => x.Sheet.Uzsakymai.OrderNumber == Paieska1TB.Text).Where(y => y.Sheet.Uzsakymai.DeliveryDate >= Convert.ToDateTime(DataNuoTB.Text) && y.Sheet.Uzsakymai.DeliveryDate <= Convert.ToDateTime(DataIkiTB.Text));



                DataDGV.DataSource = tableData.Select(x => new { x.Sheet.Amount, x.Code, x.Package, x.TrueName, x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate});
             }
            if (PagalGaminioRB.Checked)
            {
                var tableData = db.GetTable<DrawingInDB>().Where(x => x.Code == Paieska1TB.Text).Where(y => y.Sheet.Uzsakymai.DeliveryDate >= Convert.ToDateTime(DataNuoTB.Text) && y.Sheet.Uzsakymai.DeliveryDate <= Convert.ToDateTime(DataIkiTB.Text)); 

                DataDGV.DataSource = tableData.Select(x => new { x.Sheet.Amount, x.Code, x.Package, x.TrueName, x.Sheet.Uzsakymai.Name, x.Sheet.Uzsakymai.DeliveryDate} );
             }
            
                
        }
    }
 
}
