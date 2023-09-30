//dotnet add package EPPlus  
//to read excel
using OfficeOpenXml;
//dotnet add package Xceed.Words.NET 
//to read word
using Xceed.Words.NET;
//
using System;
using System.IO;


abstract class HeThong
{
    public abstract void docFile(string filePath);
    public abstract List<NhanVien> layDanhSachTuFile(string filePath);

}

class Excel : HeThong
{
    public override void docFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.Write(worksheet.Cells[row, col].Value.ToString() + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Tệp Excel không tồn tại.");
        }
    }

    public override List<NhanVien> layDanhSachTuFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            List<NhanVien> lstNhanVien = new List<NhanVien>();

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                NhanVien nhanVien = new NhanVien(); // Tạo một đối tượng NhanVien mới cho mỗi hàng

                    for(int i = 0 ; i < colCount ; i++)
                    {
                        
                        for(int j = 0 ; j < rowCount ; j++)
                        {
                            string cellValue = worksheet.Cells[i,j].Value?.ToString();
                            switch(i)
                            {
                                case 0:
                                nhanVien.MaNhanVien = cellValue;
                                break;

                                case 1:
                                nhanVien.HoTen = cellValue;
                                break;

                                case 2:
                                nhanVien.HeSoLuong = double.Parse(cellValue);
                                break;

                                default:
                                Console.WriteLine($"code da sida roi con gap bug");
                                break;
                            }

                            lstNhanVien.Add(nhanVien);


                        }
                    }


            }

            return lstNhanVien;

        }
        else
        {
            Console.WriteLine("Tệp Excel không tồn tại.");
            return null;
        }
    }
}

class Word : HeThong
{
      public override void docFile(string filePath)
    {
        if (System.IO.File.Exists(filePath))
        {
            using (DocX document = DocX.Load(filePath))
            {
                foreach (var paragraph in document.Paragraphs)
                {
                    Console.WriteLine(paragraph.Text);
                }
            }
        }
        else
        {
            Console.WriteLine("Tệp Word không tồn tại.");
        }
    }

    public override List<NhanVien> layDanhSachTuFile(string filePath)
    {
        throw new NotImplementedException();
    }
}
