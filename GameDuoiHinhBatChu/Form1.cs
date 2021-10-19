using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameDuoiHinhBatChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region Khai Báo Biến
        string[] ListPhoto;  // Lưu đường dẫn của hình ảnh
        int index; // Vị trí xuất hiện tấm hình trong mảng

        int indexDaDung;
        int[] listIndexDaDung;
        int diem = 0;

        TextBox[] txtDapAn;
        ButtonX[] listGoiYDapAN;

        string[] listDapAn = {"BAOLA",
                                "KINHDO",
                                "HUNGTHU",
                                "tinhtruong",
                                "baoquat",
                                "caumay",
                                "nhaccu",
                                "tranhthu",
                                "noithat",
                                "dauthu",
                                "Noigian",
                                "nemdagiautay",
                                "gaungua",
                                "baophu",
                                "langthang",
                                "chidiem",
                                "congtrai",
                                "badong",
                                "thankhoc",
                                "Aimo",
                                "Thongtan",
                                "baotu",
                                "muinhon",
                                "luclac",
                                "thoo",
                                "nhahat",
                                "Aomua",
                                "Baothuc",
                                "Xemtuong",
                                "coloa",
                                "Bongda",
                                "Hongtam",
                                "daituong",
                                "bactinh",
                                "HaiLong",
                                "bioi",
                                "Badausautay",
                                "xichlo",
                                "Ngangu",
                                "binhhoadidong",
                                "DongCamCongKho",
                                "Batron",
                                "Traumong",
                                "Nguao",
                                "Khotam",
                                "Baxa",
                                "Tichphan",
                                "Xehoa",
                                "Cobap",
                                "xuongrong",
                                "Hanhha",
                                "Detien",
                                "Kiemchuyen",
                                "nhanduc",
                                "Taihoa",
                                "Chantuong",
                                "bamoi",
                                "Congbo",
                                "Baotay",
                                "Bachimbaynoi",
                                "binhchannhuvai",
                                "Khoanhong",
                                "Hamhau",
                                "baphai",
                                "hinhbinhhanh",
                                "Matkhau",
                                "bienhieu",
                                "Dailungtonvai",
                                "tangca",
                                "taomeo",
                                "thichthu",
                                "Anhhao",
                                "Balo",
                                "Xauho",
                                "nhantu",
                                "Mangdidong",
                                "Baodong",
                                "Cuutunhatsinh",
                                "Bandao",
                                "keocualuaxe",
                                "Caokien",
                                "Quycu",
                                "Homcongduc",
                                "Nanglong",
                                "candauvan",
                                "Kinhhoang",
                                "Bachanboncang",
                                "Bihai",
                                "Kichdong",
                                "bikich",
                                "Mahoa",
                                "Macarong",
                                "Cohoi",
                                "Thamhoa",
                                "MaTuy",
                                "Tungtang",
                                "RuaTien",
                                "BinhYen",
                                "Auyem",
                                "Xalan",
                                "Nhanhieu",
                                "Dongcam",
                                "Batcahaitay",
                                "VuonBachthu",
                                "Thuongdinh",
                                "Nhagiao",
                                "Moitruong",
                                "Manocanh",
                                "Tiendao",
                                "Baongu",
                                "Dinhcong",
                                "Chiso",
                                "Anmay",
                                "Banhtrai",
                                "ThachCao",
                                "Xaphong",
                                "Xedieu",
                                "Banhquy",
                                "Nhica",
                                "Hoangthat",
                                "Nhaong",
                                "Sotroi",
                                "Nutthatcotrai",
                                "vituyen",
                                "Daphop",
                                "Hoami",
                                "Batbi",
                                "tRANHCUOP",
                                "Yeuot",
                                "Danhlua",
                                "LienThu",
                                "Dongdao",
                                "Thieuta",
                                "trieukien",
                                "Gauquan",
                                "tuantrangmat",
                                "Masat",
                                "Thieutuong",
                                "Nhaphanlo",
                                "Samsung",
                                "Bochanbotay",
                                "Hoaluc",
                                "giaima",
                                "Tinhco",
                                "Giaithich",
                                "TuanHanh",
                                "ThienNga",
                                "Tongtulenh",
                                "Daotobualon",
                                "Tutung",
                                "Cocua",
                                "TongTIch",
                                "Traicam",
                                "omai",
                                "Thutuong",
                                "Mamanh",
                                "Dondoc",
                                "Xangang",
                                "Holytinh",
                                "Pepsi",
                                "Biquan",
                                "Giatrentroi",
                                "Baodong",
                                "Nokia",
                                "Bosung",
                                "LinhDao",
                                "Hoidong",
                                "Gachhoa",
                                "Taotau",
                                "Baibac",
                                "Giacay",
                                "TranhCodong",
                                "Tebao",
                                "Hasi",
                                "TieuThuong",
                                "Damma",
                                "guongcau",
                                "Tinhso",
                                "trinoitringoai",
                                "Matthiet",
                                "Caytrai",
                                "Bibach",
                                "Ducnuocbeoco",
                                "Mynhanngu",
                                "Dacuoi",
                                "Ytu",
                                "Daugau",
                                "Dainhan",
                                "ChinChan",
                                "Thucongmynghe",
                                "Taytrong",
                                "Daumoi",
                                "Giaothong",
                                "TaoBao",
                                "Daugio",
                                "Hanhhung",
                                "Hutchankhong",
                                "Bankinh",
                                "Docnhatvonhi",
                                "Nhonho"
                                };
        string[] listDapAnTiengViet = {"Bao La",
                                    "Kinh Độ",
                                    "Hứng Thú",
                                    "Tình Trường",
                                    "Bao Quát",
                                    "Cầu Mây",
                                    "Nhạc Cụ",
                                    "Tranh Thủ",
                                    "Nội Thất",
                                    "Đầu Thú",
                                    "Nội Gián",
                                    "Ném Đá Giấu Tay",
                                    "Gấu Ngựa",
                                    "Bao Phủ",
                                    "Lang Thang",
                                    "Chỉ Điểm",
                                    "Công Trái",
                                    "Ba Động",
                                    "Than Khóc",
                                    "Ái Mộ",
                                    "Thông Tấn",
                                    "Bao Tử",
                                    "Mũi Nhọn",
                                    "Lục Lạc",
                                    "Thờ Ơ",
                                    "Nhà Hát",
                                    "Áo Mưa",
                                    "Báo Thức",
                                    "Xem Tướng",
                                    "Cổ Loa",
                                    "Bóng Đá",
                                    "Hồng Tâm",
                                    "Đại Tướng",
                                    "Bạc Tình",
                                    "Hài Lòng",
                                    "Bỉ Ổi",
                                    "Ba Đầu Sáu Tay",
                                    "Xích Lô",
                                    "Ngã Ngũ",
                                    "Bình Hoa Di Động",
                                    "Đồng Cam Cộng Khổ",
                                    "Ba Trợn",
                                    "Trâu Mộng",
                                    "Ngựa Ô",
                                    "Khổ Tâm",
                                    "Bà Xã",
                                    "Tích Phân",
                                    "Xe Hoa",
                                    "Cơ Bắp",
                                    "Xương Rồng",
                                    "Hành Hạ",
                                    "Đê Tiện",
                                    "Kiếm Chuyện",
                                    "Nhân Đức",
                                    "Tai Họa",
                                    "Chân Tướng",
                                    "Bà Mối",
                                    "Công Bố",
                                    "Bao Tay",
                                    "Ba Chìm Bảy Nổi",
                                    "Bình Chân Như Vại",
                                    "Khoan Hồng",
                                    "Hàm Hậu",
                                    "Ba Phải",
                                    "Hình Bình Hành",
                                    "Mật Khẩu",
                                    "Biển Hiệu",
                                    "Dài Lưng Tốn Vải",
                                    "Tăng Ca",
                                    "Táo Mèo",
                                    "Thích Thú",
                                    "Anh Hào",
                                    "Ba Lô",
                                    "Xấu Hổ",
                                    "Nhân Từ",
                                    "Mạng Di Động",
                                    "Báo Động",
                                    "Cửu Tử Nhất Sinh",
                                    "Bán Đảo",
                                    "Kéo Cưa Lừa Xẻ",
                                    "Cao Kiến",
                                    "Quy Củ",
                                    "Hòm Công Đức",
                                    "Nặng Lòng",
                                    "Cân Đẩu Vân",
                                    "Kinh Hoàng",
                                    "Ba Chân Bốn Cẳng",
                                    "Bi Hài",
                                    "Kích Động",
                                    "Bi Kịch",
                                    "Mã Hóa",
                                    "Ma Cà Rồng",
                                    "Cơ Hội",
                                    "Thảm Họa",
                                    "Ma Túy",
                                    "Tung Tăng",
                                    "Rửa Tiền",
                                    "Bình Yên",
                                    "Âu Yếm",
                                    "Xà Lan",
                                    "Nhãn Hiệu",
                                    "Đồng Cảm",
                                    "Bắt Cá Hai Tay",
                                    "Vườn Bách Thú",
                                    "Thượng Đỉnh",
                                    "Nhà Giáo",
                                    "Môi Trường",
                                    "Ma Nơ Canh",
                                    "Tiền Đạo",
                                    "Bào Ngư",
                                    "Đình Công",
                                    "Chỉ Số",
                                    "Ăn Mày",
                                    "Bánh Trái",
                                    "Thạch Cao",
                                    "Xà Phòng",
                                    "Xe Điếu",
                                    "Bánh Quy",
                                    "Nhị Ca",
                                    "Hoàng Thất",
                                    "Nhà Ống",
                                    "Số Trời",
                                    "Nút Thắt Cổ Chai",
                                    "Vĩ Tuyến",
                                    "Đập Hộp",
                                    "Họa Mi",
                                    "Bắt Bí",
                                    "Tranh Cướp",
                                    "Yếu Ớt",
                                    "Đánh Lừa",
                                    "Liên Thủ",
                                    "Đông Đảo",
                                    "Thiếu Tá",
                                    "Triệu Kiến",
                                    "Gấu Quần",
                                    "Tuần Trăng Mật",
                                    "Ma Sát",
                                    "Thiếu Tướng",
                                    "Nhà Phân Lô",
                                    "SamSung",
                                    "Bó Chân Bó Tay",
                                    "Hỏa Lực",
                                    "Giải Mã",
                                    "Tình Cờ",
                                    "Giải Thích",
                                    "Tuần Hành",
                                    "Thiên Nga",
                                    "Tổng Tư Lệnh",
                                    "Đao To Búa Lớn",
                                    "Tứ Tung",
                                    "Cò Cưa",
                                    "Tông Tích",
                                    "Trái Cấm",
                                    "Ô Mai",
                                    "Thủ Tướng",
                                    "Ma Mãnh",
                                    "Đơn Độc",
                                    "Xà Ngang",
                                    "Hồ Ly Tinh",
                                    "PepSi",
                                    "Bi Quan",
                                    "Giá Trên Trời",
                                    "Báo Động",
                                    "Nokia",
                                    "Bổ Sung",
                                    "Lính Đảo",
                                    "Hội Đồng",
                                    "Gạch Hoa",
                                    "Táo Tàu",
                                    "Bài Bạc",
                                    "Giả Cầy",
                                    "Tranh Cổ Động",
                                    "Tế Bào",
                                    "Hạ Sĩ",
                                    "Tiểu Thương",
                                    "Đám Ma",
                                    "Gương Cầu",
                                    "Tính Sổ",
                                    "Trĩ Nội Trĩ Ngoại",
                                    "Mật Thiết",
                                    "Cây Trái",
                                    "Bí Bách",
                                    "Đục Nước Béo Cò",
                                    "Mỹ Nhân Ngư",
                                    "Đá Cuội",
                                    "Ý Tứ",
                                    "Đầu Gấu",
                                    "Đại Nhân",
                                    "Chín Chắn",
                                    "Thủ Công Mỹ Nghệ",
                                    "Tay Trong",
                                    "Đầu Mối",
                                    "Giao Thông",
                                    "Táo Bạo",
                                    "Dầu Gió",
                                    "Hành Hung",
                                    "Hút Chân Không",
                                    "Bán Kính",
                                    "Độc Nhất Vô Nhị",
                                    "Nho Nhỏ"
                                    };
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDiem.Text = "ĐIỂM CỦA BẠN: " + diem.ToString();

            ListPhoto = new string[200];

            for (int i = 1; i <= ListPhoto.Length; i++)
            {
                ListPhoto[i - 1] = "photo/" + i + ".jpg";  // Lưu đường dẫn vào từng phần tử của ListPhoto
            }

            listIndexDaDung = new int[ListPhoto.Length]; // Khai báo số phần tử của list index đã dùng bằng phần từ của list photo

            Random rd = new Random();
            index = rd.Next(0, ListPhoto.Length);

            indexDaDung = 0;
            // Cập nhậ list index đã dùng.
            listIndexDaDung[indexDaDung] = index;

            ptrPhoto.BackgroundImage = Image.FromFile(ListPhoto[index]); // Load hình ảnh lên pictureBox
            ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;

            HienThiCacODapAn();

            HienThiCacNutGoiYDapAn();

            PhatSinhTextGoiYDapAn();

            lblCauHoi.Text = "CÂU SỐ " + (indexDaDung + 1).ToString();
        }
        /// <summary>
        /// HIỂN THỊ CÁC Ô ĐÁP ÁN - TỰ ĐỘNG TẠO RA CÁC Ô TEXTBOX
        /// </summary>
        private void HienThiCacODapAn()
        {
            // Tạo TextBox
            int soluongtextbox = listDapAn[index].Length;

            txtDapAn = new TextBox[soluongtextbox];
            txtDapAn[0] = new TextBox();
            txtDapAn[0].AutoSize = false;
            txtDapAn[0].Location = new Point((((ptrPhoto.Width - ((soluongtextbox * 28) + ((soluongtextbox - 1) * 10))) / 2) + ptrPhoto.Location.X), ptrPhoto.Location.Y + ptrPhoto.Size.Height + 20);
            txtDapAn[0].Size = new Size(28, 28);
            txtDapAn[0].ReadOnly = true;
            txtDapAn[0].Cursor = Cursors.Arrow;
            txtDapAn[0].TextAlign = HorizontalAlignment.Center;
            txtDapAn[0].BackColor = Color.Gold;
            txtDapAn[0].Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDapAn[0].ForeColor = SystemColors.Desktop;
            txtDapAn[0].TabIndex = 30;
            txtDapAn[0].Click += Form1_Click;

            this.Controls.Add(txtDapAn[0]);

            for (int i = 1; i < soluongtextbox; ++i)
            {
                txtDapAn[i] = new TextBox();
                txtDapAn[i].AutoSize = false;
                txtDapAn[i].Location = new Point(txtDapAn[i - 1].Location.X + txtDapAn[i - 1].Width + 10, txtDapAn[0].Location.Y);
                txtDapAn[i].Size = new Size(28, 28);
                txtDapAn[i].ReadOnly = true;
                txtDapAn[i].Cursor = Cursors.Arrow;
                txtDapAn[i].TextAlign = HorizontalAlignment.Center;
                txtDapAn[i].BackColor = Color.Gold;
                txtDapAn[i].Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                txtDapAn[i].ForeColor = SystemColors.Desktop;
                txtDapAn[i].TabIndex = 30;
                txtDapAn[i].TabIndex = 30;
                txtDapAn[i].Click += Form1_Click;

                this.Controls.Add(txtDapAn[i]);
            }
        }
        /// <summary>
        /// HIỂN THỊ CÁC NÚT GỢI Ý ĐÁP ÁN - TỰ ĐỘNG TẠO RA CÁC BUTTON DỰ THEO ĐÁP ÁN CÂU HỎI (ĐÁP ÁN * 2)
        /// </summary>
        private void HienThiCacNutGoiYDapAn()
        {
            // Tạo nút gợi ý đáp án.
            listGoiYDapAN = new ButtonX[txtDapAn.Length * 2];

            // Tạo gọi ý đáp án 0. Đại diện cho số lẻ
            listGoiYDapAN[0] = new ButtonX();
            listGoiYDapAN[0].Location = new Point((((ptrPhoto.Width - (((listGoiYDapAN.Length / 2) * 30) + (((listGoiYDapAN.Length / 2) - 1) * 10))) / 2)
                + ptrPhoto.Location.X), ptrPhoto.Location.Y + ptrPhoto.Size.Height + 80);
            listGoiYDapAN[0].Size = new Size(30, 30);
            listGoiYDapAN[0].Text = "0";
            listGoiYDapAN[0].ColorTable = eButtonColor.BlueOrb;
            listGoiYDapAN[0].Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listGoiYDapAN[0].TextColor = Color.Yellow;
            listGoiYDapAN[0].TabIndex = 0;
            listGoiYDapAN[0].Click += Form1_Click;

            this.Controls.Add(listGoiYDapAN[0]);

            // Tạo gợi ý đáp án 1. Đại diện cho số lẻ
            listGoiYDapAN[1] = new ButtonX();
            listGoiYDapAN[1].Location = new Point((((ptrPhoto.Width - (((listGoiYDapAN.Length / 2) * 30) + (((listGoiYDapAN.Length / 2) - 1) * 10))) / 2)
                + ptrPhoto.Location.X), ptrPhoto.Location.Y + ptrPhoto.Size.Height + 120);
            listGoiYDapAN[1].Size = new Size(30, 30);
            listGoiYDapAN[1].Text = "1";
            listGoiYDapAN[1].ColorTable = eButtonColor.BlueOrb;
            listGoiYDapAN[1].Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listGoiYDapAN[1].TextColor = Color.Yellow;
            listGoiYDapAN[1].TabIndex = 0;
            listGoiYDapAN[1].Click += Form1_Click;
            this.Controls.Add(listGoiYDapAN[1]);

            for (int i = 2; i < listGoiYDapAN.Length; i++)
            {
                listGoiYDapAN[i] = new ButtonX();
                listGoiYDapAN[i].Location = new Point((listGoiYDapAN[i - 2].Location.X) + listGoiYDapAN[i - 2].Width + 10, listGoiYDapAN[i - 2].Location.Y);
                listGoiYDapAN[i].Size = new Size(30, 30);
                listGoiYDapAN[i].Text = i.ToString();
                listGoiYDapAN[i].ColorTable = eButtonColor.BlueOrb;
                listGoiYDapAN[i].Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                listGoiYDapAN[i].TextColor = Color.Yellow;
                listGoiYDapAN[i].TabIndex = 0;
                listGoiYDapAN[i].Click += Form1_Click;

                this.Controls.Add(listGoiYDapAN[i]);
            }
        }
        /// <summary>
        /// SỰ KIỆN CLICK CHO TẤT CẢ CÁC NÚT NHẤN BUTTON GỢI Ý ĐÁP ÁN - VÀ TEXTBOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click cho nút Button
            if (sender is ButtonX)  // Xử lý sự kiện click cho nút Button
            {
                bool check = false;

                // Điền Text từ Button vào ô txtBox rỗng theo chiều từ trái sang phải
                for (int i = 0; i < txtDapAn.Length; i++)
                {
                    if (txtDapAn[i].Text == "") // Gặp ô đầu tiên rỗng thì điền vào
                    {
                        txtDapAn[i].Text = ((ButtonX)sender).Text; // Add text từ nút Button vào ô đáp án
                        ((ButtonX)sender).Visible = false; // Ẩn nút button đi.

                        break;
                    }
                }

                // Kiểm tra tình trạng các ô textBox đã được lấp đầu hay chưa để kiểm tra đúng/sai.
                foreach (TextBox txt in txtDapAn)
                {
                    if (txt.Text == "") // Phát hiên 1 ô txtBox rỗng thì chưa đủ điều kiện để kiểm tra.
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false) // Tất cả các ô đáp án đã được lấp đầy ký tự ==>> Kiểm tra đáp án đúng/sai
                {
                    string s = "";

                    // Duyệt qua tất cả các ô đáp án mà người chơi đã chọn để nói lại thành 1 chuỗi rồi đem đi so sánh với kết quả.
                    for (int i = 0; i < txtDapAn.Length; i++)
                    {
                        s += txtDapAn[i].Text;
                    }

                    // So sánh s với đáp án để phân biệt đúng sai.
                    if (s.ToUpper() == listDapAn[index].ToUpper())
                    {
                        SoundPlayer player = new SoundPlayer("soud/chienthang.wav");
                        player.Play();
                        fDapAn fda = new fDapAn();
                        fda.temp = listDapAnTiengViet[index];
                        fda.ShowDialog();

                        ChuyenCauTiepTheo();

                        diem = diem + 12;
                        lblDiem.Text = "ĐIỂM CỦA BẠN: " + (diem).ToString();
                    }
                    else
                    {
                        MessageBox.Show("ĐÁP ÁN KHÔNG CHÍNH XÁC!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset toàn bộ ô đáp án.
                        foreach (TextBox textbox in txtDapAn)
                        {
                            this.Controls.Remove(textbox);
                        }
                        
                        // Reset toàn bộ nút gợi ý đáp án.
                        foreach (ButtonX btn in listGoiYDapAN)
                        {
                            this.Controls.Remove(btn);
                        }
                        HienThiCacODapAn();
                        HienThiCacNutGoiYDapAn();
                        PhatSinhTextGoiYDapAn();
                    }
                }
            }

            // Xử lý sự kiện click cho ô TextBox
            else if (sender is TextBox)   // Xử lý sự kiện click cho ô TextBox
            {
                // Lấy text đó đi vào danh sách các Button đã bị ẩn đi và kiểm tra xem Button nào có text tương ứng thì cho hiển lên lại.
                foreach (ButtonX btn in listGoiYDapAN)
                {
                    if (btn.Visible == false && btn.Text == ((TextBox)sender).Text)
                    {
                        btn.Visible = true;
                        break;
                    }
                }

                // Reset text  của textBox đi
                ((TextBox)sender).ResetText(); // Xóa text đi.
            }
        }
        /// <summary>
        /// ĐƯA RA CÁ KÝ TỰ GỢI Ý ĐÁP ÁN VÀ HIỂN THỊ LÊN BUTTON
        /// </summary>
        private void PhatSinhTextGoiYDapAn()
        {
            char[] DSKyTuDapAnGoiY = new char[listGoiYDapAN.Length];

            // Đưa các ký tự đáp án đúng vào mảng DSKyTuDapAnGoiY.
            for (int i = 0; i < DSKyTuDapAnGoiY.Length / 2; i++)
            {
                char kytu = listDapAn[index][i];
                if (Char.IsLower(kytu))
                {
                    DSKyTuDapAnGoiY[i] = (char)(kytu - 32);
                }
                else
                {
                    DSKyTuDapAnGoiY[i] = kytu;
                }

            }

            Random rd = new Random();

            // Phát sinh ngẫu nhiên ra các ký tự còn lại
            // Phạm vi random trong bảng chữ cái viết hoa (mã ASCII) // A -> Z = 65 -> 90
            for (int i = DSKyTuDapAnGoiY.Length / 2; i < DSKyTuDapAnGoiY.Length; i++)
            {

                DSKyTuDapAnGoiY[i] = (char)rd.Next(65, 91); // Ép kiểu char lấy ra ký tự có mã ASCII tương ứng

            }

            int[] mangindexdadung = new int[listGoiYDapAN.Length];
            int soluong = 0;

            // Trộn lẫn và đọc lên Button
            for (int i = 0; i < listGoiYDapAN.Length; i++)
            {

                bool check;
                do
                {
                    rd = new Random();
                    int idx = rd.Next(0, listGoiYDapAN.Length);

                    // Kierm tra xem có bị trùng hay không?
                    check = true;
                    for (int j = 0; j < soluong; j++)
                    {
                        if (idx == mangindexdadung[j])
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check == true)
                    {
                        // Hiển thị ký tự lên nút button
                        listGoiYDapAN[i].Text = DSKyTuDapAnGoiY[idx].ToString();

                        // Cập nhật idx vào danh sách các index đã dùng của Danh sách các ký tự gợi ý đáp án.
                        mangindexdadung[soluong++] = idx;
                    }
                } while (check == false);
            }
        }
        /// <summary>
        /// KIỂM TRA TRẢ LỜI ĐÚNG SAU VÀ CHUYỂN QUA CÂU TIẾP THEO
        /// </summary>
        private void ChuyenCauTiepTheo()
        {
            bool check;

            do
            {
                if (indexDaDung == listIndexDaDung.Length - 1)
                {
                    MessageBox.Show("Xin chúc mừng, bạn đã phá đảo trò chơi!");
                    this.Close();
                    break;
                }

                Random rd = new Random();
                index = rd.Next(0, ListPhoto.Length);

                check = true;

                for (int i = 0; i <= indexDaDung; ++i)
                {
                    if (listIndexDaDung[i] == index) // Phát hiện bị trùng index
                    {
                        check = false;
                        break; // Thoát ra không chạy nữa
                    }
                }

                if (check == true) // Nếu không bị trùng thì hiển thị hình lên và lưu index đó lại
                {
                    ptrPhoto.BackgroundImage = Image.FromFile(ListPhoto[index]);
                    ptrPhoto.BackgroundImageLayout = ImageLayout.Stretch;

                    listIndexDaDung[++indexDaDung] = index; //Lưu vào mảng index đã dùng

                    lblCauHoi.Text = "CÂU SỐ " + (indexDaDung + 1).ToString();

                    // Reset các TextBox đã được tạo ra ở câu trước đó
                    foreach (TextBox textbox in txtDapAn)
                    {
                        this.Controls.Remove(textbox);
                    }

                    HienThiCacODapAn();

                    // Reset danh sách các nút nhấn gợi ý đáp án.
                    foreach (ButtonX btn in listGoiYDapAN)
                    {
                        this.Controls.Remove(btn);
                    }

                    HienThiCacNutGoiYDapAn();

                    PhatSinhTextGoiYDapAn();
                }
            } while (check == false); //Nếu check = false thì sẽ lặp lại quy trình random
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
