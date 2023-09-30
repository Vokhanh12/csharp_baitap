class NhanVien
{
    private string _MaNhanVien;
    private string _HoTen;
    private double _HeSoLuong;

    public NhanVien(){
        
    }
    public NhanVien(string MaNhanVien,string HoTen,double HeSoLuong){
        _MaNhanVien = MaNhanVien;
        _HoTen = HoTen;
        _HeSoLuong = HeSoLuong;
    }

    public string MaNhanVien   // property
    {
        get { return _MaNhanVien; }   // get method
        set { _MaNhanVien = value; }  // set method
    }

    public string HoTen   // property
    {
        get { return _HoTen; }   // get method
        set { _HoTen = value; }  // set method
    }

    public double HeSoLuong   // property
    {
        get { return _HeSoLuong; }   // get method
        set { _HeSoLuong = value; }  // set method
    }

    
    public override string ToString(){
        return _MaNhanVien+" , "+_HoTen+" , "+_HeSoLuong;
    }


}