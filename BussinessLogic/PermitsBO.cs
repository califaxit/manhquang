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
    public class PermitsBO {
        private readonly DatabaseDA _aDatabaseDa = new DatabaseDA();

        public List<vw_PermitsViewAll> GetAllInfoLogin_Ext_ByUsername(string username) {
            try {
                return _aDatabaseDa.vw_PermitsViewAll.Where(a => a.SystemUsers_Username == username).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("SystemUsersDA_GetPermitViewAll_ByUsername: {0}", ex.Message));
            }
        }

        public List<vw_PermitsViewAll> GetAllInfoLogin_ByUsername(string userName) {
            try {
                return
                    _aDatabaseDa.vw_PermitsViewAll.Where(p => p.SystemUsers_Username == userName)
                        .Where(p => p.SystemUsers_Disable == false)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("SystemUsersDA_GetAllInfoLogin_ByUsername: {0}", ex.Message));
            }
        }

        #region SELECT

        public List<Permits> Sel() {
            try {
                return _aDatabaseDa.Permits.ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel:{0}", ex.Message));
            }
        }

        public List<Permits> Sel(bool disable) {
            try {
                return _aDatabaseDa.Permits.Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel:{0}", ex.Message));
            }
        }

        public Permits Sel_ByID(Int32 id) {
            try {
                Permits aPermits = _aDatabaseDa.Permits.Where(b => b.ID == id).ToList()[0];
                return aPermits;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel: {0}", ex.Message));
            }
        }

        public Permits Sel_ByID(Int32 id, bool disable) {
            try {
                Permits aPermits =
                    _aDatabaseDa.Permits.Where(b => b.ID == id).Where(b => b.Disable == disable).ToList()[0];
                return aPermits;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel: {0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByType(int type) {
            try {
                return _aDatabaseDa.Permits.Where(p => p.Type == type).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByType(int type, bool disable) {
            try {
                return _aDatabaseDa.Permits.Where(p => p.Type == type).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByStatus(int status) {
            try {
                return _aDatabaseDa.Permits.Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByStatus(int status, bool disable) {
            try {
                return _aDatabaseDa.Permits.Where(p => p.Status == status).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByType_ByStatus(int type, int status) {
            try {
                return _aDatabaseDa.Permits.Where(c => c.Type == type).Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        public List<Permits> Sel_ByType_ByStatus(int type, int status, bool disable) {
            try {
                return
                    _aDatabaseDa.Permits.Where(c => c.Type == type)
                        .Where(p => p.Status == status)
                        .Where(z => z.Disable == disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        #endregion

        #region DELETE

        public int Del_ByID(Int32 id) {
            try {
                List<Permits> aTemp = _aDatabaseDa.Permits.Where(p => p.ID == id).ToList();

                if (aTemp.Count > 0) {
                    _aDatabaseDa.Permits.Remove(aTemp[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                else {
                    throw new Exception(String.Format("PermitsBO.Del_ByID: {0}", "Không tìm thấy Permits có ID = " + id));
                }
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByListID(List<int> aListId) {
            try {
                List<Permits> aTemp =
                    _aDatabaseDa.Permits.Where(p => aListId.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    _aDatabaseDa.Permits.RemoveRange(aTemp);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        #endregion

        #region UPDATE

        public int Upd(Permits aPermits) {
            try {
                _aDatabaseDa.Permits.AddOrUpdate(aPermits);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Upd: {0}", ex.Message));
            }
        }

        public int Upd_Status(int id, int newStatus) {
            try {
                List<Permits> aListPermits = _aDatabaseDa.Permits.Where(b => b.ID == id).ToList();
                if (aListPermits.Count > 0) {
                    aListPermits[0].Status = newStatus;
                    _aDatabaseDa.Permits.AddOrUpdate(aListPermits[0]);
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
                List<Permits> aListPermits = _aDatabaseDa.Permits.Where(b => b.ID == id).ToList();
                if (aListPermits.Count > 0) {
                    aListPermits[0].Type = newType;
                    _aDatabaseDa.Permits.AddOrUpdate(aListPermits[0]);
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
                List<Permits> aListPermits = _aDatabaseDa.Permits.Where(b => b.ID == id).ToList();
                if (aListPermits.Count > 0) {
                    aListPermits[0].Disable = newDisable;
                    _aDatabaseDa.Permits.AddOrUpdate(aListPermits[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }

        public int Upd_ListPermit(List<Permits> aListPermits) {
            try {
                _aDatabaseDa.Permits.AddOrUpdate(aListPermits.ToArray());
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion

        #region INSERT

        public int Ins(Permits aPermits) {
            try {
                _aDatabaseDa.Permits.AddOrUpdate(aPermits);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }

        public int Ins_ListPermits(ref List<Permits> aListPermits) {
            try {
                aListPermits = _aDatabaseDa.Permits.AddRange(aListPermits).ToList();
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("PermitsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion
    }
}