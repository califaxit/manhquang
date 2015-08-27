using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccess;

// ReSharper disable once CheckNamespace

namespace BussinessLogic {
    /// <summary>
    /// PermitDetailsBO
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// <modified>01/07/15</modified>
    
    // ReSharper disable once InconsistentNaming
    public class PermitDetailsBO {
        private readonly DatabaseDA _aDatabaseDa = new DatabaseDA();

        #region SELECT

        public List<PermitDetails> Sel() {
            try {
                return _aDatabaseDa.PermitDetails.ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel(bool disable) {
            try {
                return _aDatabaseDa.PermitDetails.Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel:{0}", ex.Message));
            }
        }

        public PermitDetails Sel_ByID(Int32 id) {
            try {
                PermitDetails aPermitDetails = _aDatabaseDa.PermitDetails.Where(b => b.ID == id).ToList()[0];
                return aPermitDetails;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel: {0}", ex.Message));
            }
        }

        public PermitDetails Sel_ByID(Int32 id, bool disable) {
            try {
                PermitDetails aPermitDetails =
                    _aDatabaseDa.PermitDetails.Where(b => b.ID == id).Where(b => b.Disable == disable).ToList()[0];
                return aPermitDetails;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel: {0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByType(int type) {
            try {
                return _aDatabaseDa.PermitDetails.Where(p => p.Type == type).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByType(int type, bool disable) {
            try {
                return _aDatabaseDa.PermitDetails.Where(p => p.Type == type).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByStatus(int status) {
            try {
                return _aDatabaseDa.PermitDetails.Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByStatus(int status, bool disable) {
            try {
                return
                    _aDatabaseDa.PermitDetails.Where(p => p.Status == status).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByType_ByStatus(int type, int status) {
            try {
                return _aDatabaseDa.PermitDetails.Where(c => c.Type == type).Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        public List<PermitDetails> Sel_ByType_ByStatus(int type, int status, bool disable) {
            try {
                return
                    _aDatabaseDa.PermitDetails.Where(c => c.Type == type)
                        .Where(p => p.Status == status)
                        .Where(z => z.Disable == disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        #endregion

        #region UPDATE

        public int Upd(PermitDetails aPermitDetails) {
            try {
                _aDatabaseDa.PermitDetails.AddOrUpdate(aPermitDetails);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Upd: {0}", ex.Message));
            }
        }

        public int Upd_Status(int id, int newStatus) {
            try {
                List<PermitDetails> aListPermitDetails = _aDatabaseDa.PermitDetails.Where(b => b.ID == id).ToList();
                if (aListPermitDetails.Count > 0) {
                    aListPermitDetails[0].Status = newStatus;
                    _aDatabaseDa.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Status_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Type(int id, int newType) {
            try {
                List<PermitDetails> aListPermitDetails = _aDatabaseDa.PermitDetails.Where(b => b.ID == id).ToList();
                if (aListPermitDetails.Count > 0) {
                    aListPermitDetails[0].Type = newType;
                    _aDatabaseDa.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Disable(int id, bool newDisable) {
            try {
                List<PermitDetails> aListPermitDetails = _aDatabaseDa.PermitDetails.Where(b => b.ID == id).ToList();
                if (aListPermitDetails.Count > 0) {
                    aListPermitDetails[0].Disable = newDisable;
                    _aDatabaseDa.PermitDetails.AddOrUpdate(aListPermitDetails[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }

        public int Upd_ByListID(List<PermitDetails> aListPermitDetails) {
            try {
                _aDatabaseDa.PermitDetails.AddOrUpdate(aListPermitDetails.ToArray());
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion

        #region DELETE

        public int Del_ByID(Int32 id) {
            try {
                List<PermitDetails> aTemp = _aDatabaseDa.PermitDetails.Where(p => p.ID == id).ToList();

                if (aTemp.Count > 0) {
                    _aDatabaseDa.PermitDetails.Remove(aTemp[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                throw new Exception(String.Format("PermitDetailsBO.Del_ByID: {0}",
                    "Không tìm thấy PermitDetails có ID = " + id));
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByListID(List<int> aListId) {
            try {
                List<PermitDetails> aTemp =
                    _aDatabaseDa.PermitDetails.Where(p => aListId.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    _aDatabaseDa.PermitDetails.RemoveRange(aTemp);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        #endregion

        #region INSERT

        public int Ins(PermitDetails aPermitDetails) {
            try {
                _aDatabaseDa.PermitDetails.AddOrUpdate(aPermitDetails);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }

        public int Ins_ListPermitDetails(ref List<PermitDetails> aListPermitDetails) {
            try {
                aListPermitDetails = _aDatabaseDa.PermitDetails.AddRange(aListPermitDetails).ToList();
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitDetailsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion
    }
}