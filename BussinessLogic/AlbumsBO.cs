using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using DataAccess;

// ReSharper disable once CheckNamespace
namespace BussinessLogic {
    /// <summary>
    /// Albums Bussiness Logic
    /// </summary>
    /// <author>Do Quang Quy</author>
    /// <created>08/07/15</created>
    /// <modified>
    /// Nam Chu
    /// 10/07/15
    /// 
    /// -reformat and optimize code
    /// -add some select methods
    /// </modified>

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class AlbumsBO {
        private readonly DatabaseDA databaseDA = new DatabaseDA();

        #region SELECT
        public List<Albums> Sel() {
            try {
                return databaseDA.Albums.ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumBO.Sel:{0}", ex.Message));
            }
        }

        public List<Albums> Sel(bool disable) {
            try {
                return databaseDA.Albums.Where(p => p.Disable == disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumBO.Sel:{0}", ex.Message));
            }
        }

        public Albums Sel_ByID(Int32 ID) {
            try {
                Albums aAlbums = databaseDA.Albums.Where(b => b.ID == ID).ToList()[0];

                return aAlbums;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel: {0}", ex.Message));
            }
        }

        public Albums Sel_ByID(Int32 ID, bool Disable) {
            try {
                Albums aAlbums = databaseDA.Albums.Where(b => b.ID == ID).Where(p => p.Disable == Disable).ToList()[0];

                return aAlbums;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByIDLang(int IDLang) {
            try {
                return databaseDA.Albums.Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByIDLang(int IDLang, bool Disable) {
            try {
                return databaseDA.Albums.Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByCode(string Code) {
            try {
                return databaseDA.Albums.Where(p => p.Code == Code).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByCode(string Code, bool Disable) {
            try {
                return databaseDA.Albums.Where(p => p.Code == Code).Where(p => p.Disable == Disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType(int Type) {
            try {
                return databaseDA.Albums.Where(p => p.Type == Type).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType(int Type, bool Disable) {
            try {
                return databaseDA.Albums.Where(p => p.Type == Type).Where(p => p.Disable == Disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus(int Status) {
            try {
                return databaseDA.Albums.Where(p => p.Status == Status).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus(int Status, bool Disable) {
            try {
                return databaseDA.Albums.Where(p => p.Status == Status).Where(p => p.Disable == Disable).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByCode: {0}", ex.Message));
            }
        }

        public Albums Sel_ByCode_ByIDLang(string Code, int IDLang) {
            try {
                var aListAlbums = databaseDA.Albums.Where(a => a.Code == Code).Where(a => a.IDLang == IDLang).ToList();
                if (aListAlbums.Count > 0) {
                    return aListAlbums[0];
                }
                else
                    return null;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.SelectListAlbums_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }

        public Albums Sel_ByCode_ByIDLang(string Code, int IDLang, bool Disable) {
            try {
                var aListAlbums = databaseDA.Albums.Where(a => a.Code == Code)
                    .Where(a => a.IDLang == IDLang)
                    .Where(a => a.Disable == Disable)
                    .ToList();
                if (aListAlbums.Count > 0) {
                    return aListAlbums[0];
                }
                else
                    return null;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.SelectListAlbums_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByIDLang(int Type, int IDLang) {
            try {
                return databaseDA.Albums.Where(p => p.Type == Type).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByIDLang(int Type, int IDLang, bool Disable) {
            try {
                return
                    databaseDA.Albums.Where(p => p.Type == Type)
                        .Where(z => z.IDLang == IDLang)
                        .Where(z => z.Disable == Disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus_ByIDLang(int Status, int IDLang) {
            try {
                return databaseDA.Albums.Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus_ByIDLang(int Status, int IDLang, bool Disable) {
            try {
                return
                    databaseDA.Albums.Where(p => p.Status == Status)
                        .Where(z => z.IDLang == IDLang)
                        .Where(z => z.Disable == Disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByCode(int Type, string Code) {
            try {
                return databaseDA.Albums.Where(p => p.Type == Type).Where(z => z.Code == Code).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByCode(int Type, string Code, bool Disable) {
            try {
                return
                    databaseDA.Albums.Where(p => p.Type == Type)
                        .Where(z => z.Code == Code)
                        .Where(z => z.Disable == Disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus_ByCode(int Status, string Code) {
            try {
                return databaseDA.Albums.Where(p => p.Status == Status).Where(z => z.Code == Code).ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByStatus_ByCode(int Status, string Code, bool Disable) {
            try {
                return
                    databaseDA.Albums.Where(p => p.Status == Status)
                        .Where(z => z.Code == Code)
                        .Where(z => z.Disable == Disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByStatus:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByStatus_ByIDLang(int Type, int Status, int IDLang) {
            try {
                return
                    databaseDA.Albums.Where(c => c.Type == Type)
                        .Where(p => p.Status == Status)
                        .Where(z => z.IDLang == IDLang)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByType_ByStatus_ByIDLang(int Type, int Status, int IDLang, bool Disable) {
            try {
                return
                    databaseDA.Albums.Where(c => c.Type == Type)
                        .Where(p => p.Status == Status)
                        .Where(z => z.IDLang == IDLang)
                        .Where(z => z.Disable == Disable)
                        .ToList();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }

        public List<Albums> Sel_ByCodeAlbum_ByIDLang(string CodeAlbum, int IDLang) {
            return databaseDA.Albums.Where(p => p.Code == CodeAlbum).Where(a => a.IDLang == IDLang).ToList();
        }
        #endregion

        #region UPDATE
        public int Upd_Albums(Albums aAlbums) {
            try {
                databaseDA.Albums.AddOrUpdate(aAlbums);
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Upd: {0}", ex.Message));
            }
        }

        private int Upd_ListAlbums(List<Albums> aListAlbums) {
            try {
                databaseDA.Albums.AddOrUpdate(aListAlbums.ToArray());
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Ins: {0}", ex.Message));
            }
        }

        public int Upd_Status_ByID(int ID, int NewStatus) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.ID == ID).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Status = NewStatus;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Status_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Type_ByID(int ID, int NewType) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.ID == ID).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Type = NewType;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Disable_ByID(int ID, bool NewDisable) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.ID == ID).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Disable = NewDisable;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }

        public int Upd_Status_ByCode(string Code, int NewStatus) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.Code == Code).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Status = NewStatus;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Status_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Type_ByCode(string Code, int NewType) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.Code == Code).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Type = NewType;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Disable_ByCode(string Code, bool NewDisable) {
            try {
                List<Albums> aListAlbums = databaseDA.Albums.Where(b => b.Code == Code).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Disable = NewDisable;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Status_ByCode_ByIDLang(string Code, int IDLang, int NewStatus) {
            try {
                List<Albums> aListAlbums =
                    databaseDA.Albums.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Status = NewStatus;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Status_ByCode_ByLang:{0}", ex.Message));
            }
        }

        public int Upd_Type_ByCode_ByIDLang(string Code, int IDLang, int NewType) {
            try {
                List<Albums> aListAlbums =
                    databaseDA.Albums.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Type = NewType;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Type_ByCode_ByLang:{0}", ex.Message));
            }
        }

        public int Upd_Disable_ByCode_ByIDLang(string Code, int IDLang, bool NewDisable) {
            try {
                List<Albums> aListAlbums =
                    databaseDA.Albums.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListAlbums.Count > 0) {
                    aListAlbums[0].Disable = NewDisable;
                    databaseDA.Albums.AddOrUpdate(aListAlbums[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("Upd_Disable_ByCode_ByLang:{0}", ex.Message));
            }
        }
        #endregion

        #region INSERT
        public int Ins(Albums aAlbums) {
            try {
                databaseDA.Albums.AddOrUpdate(aAlbums);
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Ins: {0}", ex.Message));
            }
        }

        private int Ins_ListAlbums(ref List<Albums> aListAlbums) {
            try {
                aListAlbums = databaseDA.Albums.AddRange(aListAlbums).ToList();
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Ins: {0}", ex.Message));
            }
        }
        #endregion

        #region DELETE
        private int Del() {
            try {
                List<Albums> aTemp = databaseDA.Albums.ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByCode: {0}", ex.Message));
            }
        }

        private int Del_ListAlbums(List<Albums> aListAlbums) {
            try {
                databaseDA.Albums.RemoveRange(aListAlbums);
                return databaseDA.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByID(Int32 ID) {
            try {
                List<Albums> aTemp = databaseDA.Albums.Where(p => p.ID == ID).ToList();

                if (aTemp.Count > 0) {
                    databaseDA.Albums.Remove(aTemp[0]);
                    return databaseDA.SaveChanges();
                }
                else {
                    throw new Exception(String.Format("AlbumsBO.Del: {0}", "Không tìm thấy Albums có ID = " + ID));
                }
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del: {0}", ex.Message));
            }
        }

        private int Del_ByListID(List<int> aListID) {
            try {
                List<Albums> aTemp =
                    databaseDA.Albums.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByCode: {0}", ex.Message));
            }
        }

        public int Del_ByCode(string Code) {
            try {
                List<Albums> aTemp = databaseDA.Albums.Where(p => p.Code == Code).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByCode: {0}", ex.Message));
            }
        }

        private int Del_ByListCode(List<string> aListCode) {
            try {
                List<Albums> aTemp = databaseDA.Albums.Where(p => aListCode.Contains(p.Code)).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByListCode: {0}", ex.Message));
            }
        }

        public int Del_ByIDLang(int IDLang) {
            try {
                List<Albums> aTemp =
                    databaseDA.Albums.Where(p => p.IDLang == IDLang).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.Remove(aTemp[0]);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByCode_ByIDLang: {0}", ex.Message));
            }
        }

        private int Del_ByListIDLang(List<int> listIDLang) {
            try {
                List<Albums> aTemp = databaseDA.Albums.Where(p => listIDLang.Contains(int.Parse(p.IDLang.ToString()))).ToList();
                if (aTemp.Count > 0) {
                    databaseDA.Albums.RemoveRange(aTemp);
                    return databaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex) {
                throw new Exception(String.Format("AlbumsBO.Del_ByListIDLang {0}", ex.Message));
            }
        }
        #endregion
    }
}