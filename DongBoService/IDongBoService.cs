using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DongBoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDongBoService" in both code and config file together.
    [ServiceContract]
    public interface IDongBoService
    {
        [OperationContract]
        bool DongBoVung();

        [OperationContract]
        bool DongBoTinh();

        [OperationContract]
        bool DongBoHuyen();

        [OperationContract]
        bool DongBoXa();

        [OperationContract]
        bool DongBoSerial();

        [OperationContract]
        bool DongBoVatTu();

        [OperationContract]
        bool DongBoNhomVatTu();

        [OperationContract]
        bool DongBoKho();

        [OperationContract]
        bool DongBoHienTuong();

        [OperationContract]
        bool DongBoLoi();

        [OperationContract]
        bool DongBoMaSC();

        [OperationContract]
        bool DongBoGoiBD();

        [OperationContract]
        bool DongBoPhiKM();

        [OperationContract]
        bool DongBoStatus();

        [OperationContract]
        bool DongBoVungQuanLy();

        [OperationContract]
        bool DongBoDanhMucKhac();
    }
}
