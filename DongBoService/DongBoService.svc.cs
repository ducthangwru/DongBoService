using DongBoService.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DongBoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DongBoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DongBoService.svc or DongBoService.svc.cs at the Solution Explorer and start debugging.
    public class DongBoService : IDongBoService
    {
        public bool DongBoGoiBD()
        {
            return DongBoDB.DongBoGoiBD();
        }

        public bool DongBoHienTuong()
        {
            return DongBoDB.DongBoHienTuong();
        }

        public bool DongBoHuyen()
        {
            return DongBoDB.DongBoHuyen();
        }

        public bool DongBoKho()
        {
            return DongBoDB.DongBoKho();
        }

        public bool DongBoLoi()
        {
            return DongBoDB.DongBoLoi();
        }

        public bool DongBoMaSC()
        {
            return DongBoDB.DongBoMaSC();
        }

        public bool DongBoNhomVatTu()
        {
            return DongBoDB.DongBoNhomVatTu();
        }

        public bool DongBoPhiKM()
        {
            return DongBoDB.DongBoPhiKM();
        }

        public bool DongBoSerial()
        {
            return DongBoDB.DongBoSerial();
        }

        public bool DongBoTinh()
        {
            return DongBoDB.DongBoTinh();
        }

        public bool DongBoVatTu()
        {
            return DongBoDB.DongBoVatTu();
        }

        public bool DongBoVung()
        {
            return DongBoDB.DongBoVung();
        }

        public bool DongBoXa()
        {
            return DongBoDB.DongBoXa();
        }

        public bool DongBoStatus()
        {
            return DongBoDB.DongBoStatus();
        }

        public bool DongBoVungQuanLy()
        {
            return DongBoDB.DongBoVungQuanLy();
        }

        public bool DongBoDanhMucKhac()
        {
            return DongBoDB.DongBoDanhMucKhac();
        }
    }
}
