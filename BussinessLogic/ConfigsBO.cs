using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccess;

// ReSharper disable once CheckNamespace

namespace BussinessLogic {
    /// <summary>
    /// ConfigsBO
    /// </summary>
    /// <author> Nam Chu </author>
    /// <created>10/06/15</created>
    /// 
    /// <modified>
    /// Nam Chu
    /// 01/07/15
    /// 
    /// - reformat and optimize code
    /// </modified>
    
    // ReSharper disable once InconsistentNaming
    public class ConfigsBO {
        // ReSharper disable once InconsistentNaming
        private readonly DatabaseDA databaseDA = new DatabaseDA();

        #region Select

        public List<Configs> Sel() {
            try {
                return databaseDA.Configs.ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel:{0}", ex.Message));
            }
        }

        public List<Configs> Sel(bool disable) {
            try {
                return databaseDA.Configs.Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel:{0}", ex.Message));
            }
        }

        public Configs Sel_ByID(Int32 id) {
            try {
                Configs aConfigs = databaseDA.Configs.Where(b => b.ID == id).ToList()[0];
                return aConfigs;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel: {0}", ex.Message));
            }
        }

        public Configs Sel_ByID(Int32 id, bool disable) {
            try {
                Configs aConfigs =
                    databaseDA.Configs.Where(b => b.ID == id).Where(b => b.Disable == disable).ToList()[0];
                return aConfigs;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel: {0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByType(int type) {
            try {
                return databaseDA.Configs.Where(p => p.Type == type).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByType(int type, bool disable) {
            try {
                return databaseDA.Configs.Where(p => p.Type == type).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByStatus(int status) {
            try {
                return databaseDA.Configs.Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByStatus(int status, bool disable) {
            try {
                return databaseDA.Configs.Where(p => p.Status == status).Where(z => z.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByAccessKey(string key) {
            try {
                List<Configs> aListConfigs = databaseDA.Configs.Where(c => c.AccessKey == key).ToList();
                if (aListConfigs.Count > 0) {
                    return aListConfigs;
                }
                return null;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsDA_GetByKey: {0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByAccessKey(string key, bool disable) {
            try {
                List<Configs> aListConfigs =
                    databaseDA.Configs.Where(c => c.AccessKey == key).Where(c => c.Disable == disable).ToList();
                if (aListConfigs.Count > 0) {
                    return aListConfigs;
                }
                return null;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsDA_GetByKey: {0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByType_ByStatus(int type, int status) {
            try {
                return databaseDA.Configs.Where(c => c.Type == type).Where(p => p.Status == status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        public List<Configs> Sel_ByType_ByStatus(int type, int status, bool disable) {
            try {
                return
                    databaseDA.Configs.Where(c => c.Type == type)
                        .Where(p => p.Status == status)
                        .Where(z => z.Disable == disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Sel_ByType_ByStatus:{0}", ex.Message));
            }
        }

        #endregion

        #region Update

        public int Upd_Status(int id, int newStatus) {
            try {
                List<Configs> aListConfigs = databaseDA.Configs.Where(b => b.ID == id).ToList();
                if (aListConfigs.Count > 0) {
                    aListConfigs[0].Status = newStatus;
                    databaseDA.Configs.AddOrUpdate(aListConfigs[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Status_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Type(int id, int newType) {
            try {
                List<Configs> aListConfigs = databaseDA.Configs.Where(b => b.ID == id).ToList();
                if (aListConfigs.Count > 0) {
                    aListConfigs[0].Type = newType;
                    databaseDA.Configs.AddOrUpdate(aListConfigs[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Disable(int id, bool newDisable) {
            try {
                List<Configs> aListConfigs = databaseDA.Configs.Where(b => b.ID == id).ToList();
                if (aListConfigs.Count > 0) {
                    aListConfigs[0].Disable = newDisable;
                    databaseDA.Configs.AddOrUpdate(aListConfigs[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }

        public int Upd(Configs aConfigs) {
            try {
                databaseDA.Configs.AddOrUpdate(aConfigs);
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Upd: {0}", ex.Message));
            }
        }

        public int Upd_ListConfigs(List<Configs> aListConfigs) {
            try {
                databaseDA.Configs.AddOrUpdate(aListConfigs.ToArray());
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion

        #region Delete

        public int Del(Int32 id) {
            try {
                List<Configs> aTemp = databaseDA.Configs.Where(p => p.ID == id).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Configs.Remove(aTemp[0]);
                    return databaseDA.SaveChanges();
                }
                throw new Exception(String.Format("ConfigsBO.Del_ByID: {0}", "Không tìm thấy Configs có ID = " + id));
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ListID(List<int> aListId) {
            try {
                List<Configs> aTemp =
                    databaseDA.Configs.Where(p => aListId.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Configs.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Del_By_ListID: {0}", ex.Message));
            }
        }

        #endregion

        #region Insert

        public int Ins(Configs aConfigs) {
            try {
                databaseDA.Configs.AddOrUpdate(aConfigs);
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }

        public int Ins_ListConfigs (ref List<Configs> aListConfigs) {
            try {
                aListConfigs = databaseDA.Configs.AddRange(aListConfigs).ToList();
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("ConfigsBO.Ins: {0}", ex.Message));
            }
        }

        #endregion
    }
}