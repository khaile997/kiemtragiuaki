using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtragiuaki
{
    public partial class Frmnhaplieutiso : Form
    {
        public Frmnhaplieutiso()
        {
            InitializeComponent();
        }

        string connectionstring = Kiemtragiuaki.Properties.Settings.Default.DatabaseBangdiembongdaConnectionString;
        private void Frmnhaplieutiso_Load(object sender, EventArgs e)
        {
           

        }

        public void themlanmot()
        {
            // chuyển kiểu dữ liệu nhập trên textbox thành kiểu int và lưu vào biến tỉ số tương ứng
            int tisoA = Convert.ToInt32(txtTisoA.Text);
            int tisoB = Convert.ToInt32(txtTisoB.Text);
            int hieusoA = 0, hieusoB = 0, diemA = 0, diemB = 0;
            // lấy tỉ số 2 đội lưu vào biến tỉ số và sau đó dùng biến tỉ số để lưu vào csdl
            string tisoluot1 = (tisoA + "-" + tisoB).ToString();
            
            string tisoluot2 = (tisoB + "-" + tisoA).ToString();
           
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtbang.Text) || String.IsNullOrEmpty(txtDoiA.Text) || String.IsNullOrEmpty(txtDoiB.Text)
                || String.IsNullOrEmpty(txtTisoA.Text) || String.IsNullOrEmpty(txtTisoB.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }
            if (tisoA > tisoB)
            {
                hieusoA = tisoA - tisoB;
                diemA = 3;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiA.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiB.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot1);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoA);
                            command.Parameters.AddWithValue("@Diem", diemA);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (tisoB > tisoA)
            {
                hieusoB = tisoB - tisoA;
                diemB = 0;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiA.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiB.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot1);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoB);
                            command.Parameters.AddWithValue("@Diem", diemB);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (tisoA == tisoB)
            {
                hieusoA = tisoA - tisoB;
                diemA = 1;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiA.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiB.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot1);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoA);
                            command.Parameters.AddWithValue("@Diem", diemA);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        public void themlanhai()
        {
            // chuyển kiểu dữ liệu nhập trên textbox thành kiểu int và lưu vào biến tỉ số tương ứng
            int tisoA = Convert.ToInt32(txtTisoA.Text);
            int tisoB = Convert.ToInt32(txtTisoB.Text);
            int hieusoA = 0, hieusoB = 0, diemA = 0, diemB = 0;
            // lấy tỉ số 2 đội lưu vào biến tỉ số và sau đó dùng biến tỉ số để lưu vào csdl
            string tisoluot1 = (tisoA + "-" + tisoB).ToString();
           
            string tisoluot2 = (tisoB + "-" + tisoA).ToString();
           
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtbang.Text) || String.IsNullOrEmpty(txtDoiA.Text) || String.IsNullOrEmpty(txtDoiB.Text)
                || String.IsNullOrEmpty(txtTisoA.Text) || String.IsNullOrEmpty(txtTisoB.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }
            if (tisoA > tisoB)
            {
                hieusoA = tisoB - tisoA;
                diemA = 0;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiB.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiA.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot2);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoA);
                            command.Parameters.AddWithValue("@Diem", diemA);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (tisoB > tisoA)
            {
                hieusoB = tisoB - tisoA;
                diemB = 3;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiB.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiA.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot2);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoB);
                            command.Parameters.AddWithValue("@Diem", diemB);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if (tisoA == tisoB)
            {
                hieusoA = tisoA - tisoB;
                diemA = 1;
                // Tạo câu lệnh để thực thi đến database
                string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [SoTranDaThiDau], [HieuSo], [Diem]) VALUES(@TenBang, @TenDoi, @TenDoiDoiThu, @TiSo, @SoTranDaThiDau, @HieuSo, @Diem)";
                // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        try
                        {
                            // Mở kết nối đến Database Server
                            connection.Open();
                            // Truyền dữ liệu vào đúng tham số
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@TenBang", txtbang.Text);
                            command.Parameters.AddWithValue("@TenDoi", txtDoiB.Text);
                            command.Parameters.AddWithValue("@TenDoiDoiThu", txtDoiA.Text);
                            command.Parameters.AddWithValue("@Tiso", tisoluot1);
                            command.Parameters.AddWithValue("@SoTranDaThiDau", 1);
                            command.Parameters.AddWithValue("@HieuSo", hieusoA);
                            command.Parameters.AddWithValue("@Diem", diemA);
                            // Thực thi câu lệnh
                            int effect = command.ExecuteNonQuery();
                            // Ngắt kết nối đến Database Server
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo nếu có lỗi
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
        private void btnluu_Click_1(object sender, EventArgs e)
        {
            themlanmot();
            themlanhai();
        }

        private void btnxemkq_Click(object sender, EventArgs e)
        {
            FrmKetqua frm = new FrmKetqua();
            frm.ShowDialog();
            this.Close();

        }


    }
}
