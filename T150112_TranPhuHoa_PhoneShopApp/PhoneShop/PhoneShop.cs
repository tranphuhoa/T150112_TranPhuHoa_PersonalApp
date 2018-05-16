using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T150112_TranPhuHoa_PhoneShopApp.PhoneShop
{
    public partial class PhoneShop : Form
    {
        public PhoneShop()
        {
            InitializeComponent();
        }

        private void Phone_Load(object sender, EventArgs e)
        {
            ShowPhoneList();
        }

        private void ShowPhoneList()
        {
            var db = new T150112Entities();
            this.listview.DataSource = db.SanPhams.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.ShowPhoneList();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = new T150112Entities();
            for (int i = 0; i < this.listview.SelectedRows.Count; i++)
            {
                var row = this.listview.SelectedRows[i];
                var item = (SanPham)row.DataBoundItem;
                try
                {
                    var product = db.SanPhams.Find(item.MaSP);
                    db.SanPhams.Remove(product);
                    db.SaveChanges(); // Do-It
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.ShowPhoneList();
        }
    }
}
