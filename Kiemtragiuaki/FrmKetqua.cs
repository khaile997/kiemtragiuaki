using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki
{
    public partial class FrmKetqua : Form
    {
        public FrmKetqua()
        {
            InitializeComponent();
        }
        

      

        private void FrmKetqua_Load(object sender, EventArgs e)
        {
            this.bangDiemThiDauTableAdapter.Fill(this.databaseBangdiembongdaDataSet.BangDiemThiDau);
            pnbangdiem.Hide();
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            pnbangdiem.Show();
        }
    }
}
