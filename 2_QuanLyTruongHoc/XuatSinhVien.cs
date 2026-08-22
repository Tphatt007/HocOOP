using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace HocOPP
{
    
    public interface IXuat<T>
    {
        string Xuat(IEnumerable<T> ds);
       
    }
    public class XuattheoTXT<T> : IXuat<T>
    {
        public string Xuat(IEnumerable<T> ds)
        {
            return "Xuat theo TXT";
        }
    }
    public class XuattheoCSV<T> : IXuat<T>
    {
        public string Xuat(IEnumerable<T> ds)
        {
            return "Xuat theo CSV";
        }
    }
    public class XuattheoJSON<T> : IXuat<T>
    {
        public string Xuat(IEnumerable<T> ds)
        {
            return "Xuat theo JSON";
        }
    }
}
