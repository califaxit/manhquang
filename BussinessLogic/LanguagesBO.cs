using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccess;

// ReSharper disable once CheckNamespace

namespace BussinessLogic {
    /// <summary>
    /// LanguagesBO
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// <modified>
    /// Nam Chu
    /// 01/07/15
    /// 
    /// -reformat and optimize code
    /// </modified>
    
    // ReSharper disable once InconsistentNaming
    public class LanguagesBO {
        private readonly DatabaseDA _aDatabaseDa = new DatabaseDA();

        #region SELECT

        public Languages Sel_ByID(Int32 id) {
            try {
                Languages aLanguages = _aDatabaseDa.Languages.Where(b => b.ID == id).ToList()[0];
                return aLanguages;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel: {0}", ex.Message));
            }
        }

        public Languages Sel_ByID(Int32 id, bool disable) {
            try {
                Languages aLanguages =
                    _aDatabaseDa.Languages.Where(b => b.ID == id).Where(b => b.Disable == disable).ToList()[0];
                return aLanguages;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel: {0}", ex.Message));
            }
        }

        public List<Languages> Sel() {
            try {
                return _aDatabaseDa.Languages.ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel:{0}", ex.Message));
            }
        }

        public List<Languages> Sel(bool disable) {
            try {
                return _aDatabaseDa.Languages.Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByType(int type) {
            try {
                return _aDatabaseDa.Languages.Where(p => p.Type == type).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByType(int type, bool disable) {
            try {
                return _aDatabaseDa.Languages.Where(p => p.Type == type).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByStatus(int status) {
            try {
                return _aDatabaseDa.Languages.Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByStatus(int status, bool disable) {
            try {
                return _aDatabaseDa.Languages.Where(p => p.Status == status).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByType_ByStatus(int type, int status) {
            try {
                return _aDatabaseDa.Languages.Where(c => c.Type == type).Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        public List<Languages> Sel_ByType_ByStatus(int type, int status, bool disable) {
            try {
                return
                    _aDatabaseDa.Languages.Where(c => c.Type == type)
                        .Where(p => p.Status == status)
                        .Where(z => z.Disable == disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        #endregion

        #region DELETE

        public int Del_ByID(Int32 id) {
            try {
                List<Languages> aTemp = _aDatabaseDa.Languages.Where(p => p.ID == id).ToList();
                if (aTemp.Count > 0) {
                    _aDatabaseDa.Languages.Remove(aTemp[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                throw new Exception(String.Format("LanguagesBO.Del_ByID: {0}", "Không tìm thấy Languages có ID = " + id));
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByListID(List<int> aListId) {
            try {
                List<Languages> aTemp =
                    _aDatabaseDa.Languages.Where(p => aListId.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    _aDatabaseDa.Languages.RemoveRange(aTemp);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        #endregion

        #region UPDATE

        public int Upd_Status(int id, int newStatus) {
            try {
                List<Languages> aListLanguages = _aDatabaseDa.Languages.Where(b => b.ID == id).ToList();
                if (aListLanguages.Count > 0) {
                    aListLanguages[0].Status = newStatus;
                    _aDatabaseDa.Languages.AddOrUpdate(aListLanguages[0]);
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
                List<Languages> aListLanguages = _aDatabaseDa.Languages.Where(b => b.ID == id).ToList();
                if (aListLanguages.Count > 0) {
                    aListLanguages[0].Type = newType;
                    _aDatabaseDa.Languages.AddOrUpdate(aListLanguages[0]);
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
                List<Languages> aListLanguages = _aDatabaseDa.Languages.Where(b => b.ID == id).ToList();
                if (aListLanguages.Count > 0) {
                    aListLanguages[0].Disable = newDisable;
                    _aDatabaseDa.Languages.AddOrUpdate(aListLanguages[0]);
                    return _aDatabaseDa.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }

        public int Upd_ByListID(List<Languages> aListLanguages) {
            try {
                _aDatabaseDa.Languages.AddOrUpdate(aListLanguages.ToArray());
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }

        public int Upd(Languages aLanguages) {
            try {
                _aDatabaseDa.Languages.AddOrUpdate(aLanguages);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Upd: {0}", ex.Message));
            }
        }

        #endregion

        #region INSERT

        public int Ins(Languages aLanguages) {
            try {
                _aDatabaseDa.Languages.AddOrUpdate(aLanguages);
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }

        public int Ins_ListLanguages(ref List<Languages> aListLanguages) {
            try {
                aListLanguages = _aDatabaseDa.Languages.AddRange(aListLanguages).ToList();
                return _aDatabaseDa.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("LanguagesBO.Ins: {0}", ex.Message));
            }
        }

        #endregion
    }
}