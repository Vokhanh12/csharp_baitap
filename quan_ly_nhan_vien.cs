class QuanLyNhanVien{

    List<NhanVien> lstNhanVien;

    public QuanLyNhanVien()
    {
        lstNhanVien = new List<NhanVien>();
    }
  

    //Them Nhan vien
    public void ThemNhanVien(NhanVien nhanvien){
        lstNhanVien.Add(nhanvien);
    }

    //Lay danh sach nhan vien
    public List<NhanVien> getLstNhanVien(){

        return null;

    }

    // chinh lai danh sach nhan vien
    public void setLstNhanVien(List<NhanVien> lsNhanVien){

        this.lstNhanVien = lsNhanVien;

    }

    public void TaoDanhSachNhanVienNgauNhien(int soluong){




        for(int i = 0 ; i < soluong ; i++)
        {
            Random random = new Random();
            double randomNumber = random.NextDouble()*4.0;


            lstNhanVien.Add(new NhanVien($"NV00{i}","NULL",randomNumber));
        

        }


    }

    public void DocDanhSachNhanVien(){

      // Kiểm tra xem danh sách có phần tử nào không
    if (lstNhanVien.Count > 0)
    {
        Console.WriteLine("Danh sách nhân viên:");

        // In tên của từng nhân viên trong danh sách
        foreach (var nhanvien in lstNhanVien)
        {
            Console.WriteLine($"MANV:{nhanvien.MaNhanVien}");
            Console.WriteLine($"HOTEN:{nhanvien.HoTen}");
            Console.WriteLine($"HESOLUONG:{nhanvien.HeSoLuong}");
        }
    }
    else
    {
        Console.WriteLine("Danh sách nhân viên trống.");
    }


    }








}