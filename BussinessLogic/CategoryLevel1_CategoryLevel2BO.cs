using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Linq;
using DataAccess;
using EntitiesExt;
namespace Bussiness
{
   public class CategoryLevel1_CategoryLevel2BO
    {
        DatabaseDA aDatabaseDA = new DatabaseDA();
        public int Ins(CategoryLevel1_CategoryLevel2 aCategoryLevel1_CategoryLevel2)
        {
            try
            {
                aDatabaseDA.CategoryLevel1_CategoryLevel2.Add(aCategoryLevel1_CategoryLevel2);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<CategoryLevel1_CategoryLevel2> aListCategoryLevel1_CategoryLevel2)
        {
            try
            {
                aListCategoryLevel1_CategoryLevel2 = aDatabaseDA.CategoryLevel1_CategoryLevel2.AddRange(aListCategoryLevel1_CategoryLevel2).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(List<CategoryLevel1_CategoryLevel2> aListCategoryLevel1_CategoryLevel2)
        {
            try
            {
                aDatabaseDA.CategoryLevel1_CategoryLevel2.AddOrUpdate(aListCategoryLevel1_CategoryLevel2.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(CategoryLevel1_CategoryLevel2 aCategoryLevel1_CategoryLevel2)
        {
            try
            {
                aDatabaseDA.CategoryLevel1_CategoryLevel2.AddOrUpdate(aCategoryLevel1_CategoryLevel2);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Upd: {0}", ex.Message));
            }
        }

        //===========================================================================================
        public int Del_ByID(Int32 ID)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => p.ID == ID).ToList();

                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del: {0}", "Không tìm thấy CategoryLevel1CategoryLevel2 có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Contents_CategoryLevel1BO.Del: {0}", ex.Message));
            }
        }
        public int Del(List<CategoryLevel1_CategoryLevel2> aListCategoryLevel1CategoryLevel2)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aListCategoryLevel1CategoryLevel2).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByCodeCategoryLevel1(string CodeCategoryLevel1)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => p.CodeCategoryLevel1 == CodeCategoryLevel1).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByCodeCategoryLevel1: {0}", ex.Message));
            }
        }
        public int Del_ByCodeCategoryLevel1_ByIDLang(string CodeCategoryLevel1, int IDLang)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => p.CodeCategoryLevel1 == CodeCategoryLevel1).Where(p => p.IDLang == IDLang).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByCodeCategoryLevel1_ByIDLang: {0}", ex.Message));
            }
        }

        public int Del_ByCodeCategoryLevel1_ByCodeCategoryLevel2(string CodeCategoryLevel1, string CodeCategoryLevel2)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => p.CodeCategoryLevel1 == CodeCategoryLevel1).Where(p => p.CodeCategoryLevel2 == CodeCategoryLevel2).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByCodeCategoryLevel1_ByCodeCategoryLevel2: {0}", ex.Message));
            }
        }

        public int Del_ByListCodeCategoryLevel1(List<string> aListCodeCategoryLevel1)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => aListCodeCategoryLevel1.Contains(p.CodeCategoryLevel1)).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByListCodeCategoryLevel1: {0}", ex.Message));
            }
        }
        public int Del_ByListCodeCategoryLevel2(List<string> aListCodeCategoryLevel2)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => aListCodeCategoryLevel2.Contains(p.CodeCategoryLevel2)).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByListCodeCategoryLevel2: {0}", ex.Message));
            }
        }
        public int Del_ByListID(List<int> aListID)
        {
            try
            {
                List<CategoryLevel1_CategoryLevel2> aTemp = aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => aListID.Contains(p.ID)).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.CategoryLevel1_CategoryLevel2.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("CategoryLevel1_CategoryLevel2BO.Del_ByListID: {0}", ex.Message));
            }
        }

        public int Del(CategoryLevel1_CategoryLevel2 aItem)
        {
            this.aDatabaseDA.CategoryLevel1_CategoryLevel2.Remove(aItem);
            return aDatabaseDA.SaveChanges();

        }

        public int Del(List<int> aListIDCategoryLevel1_CategoryLevel2)
        {
            List<CategoryLevel1_CategoryLevel2> aList = this.aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => aListIDCategoryLevel1_CategoryLevel2.Contains(p.ID)).ToList();
            return aDatabaseDA.SaveChanges();
        }

        //=============================================================================================
        public List<CategoryLevel1_CategoryLevel2> Sel_ByCodeCategoryLevel1_ByIDLang(string CodeCategoryLevel1, int IDLang)
        {
            return this.aDatabaseDA.CategoryLevel1_CategoryLevel2.Where(p => p.CodeCategoryLevel1 == CodeCategoryLevel1).Where(a => a.IDLang == IDLang).ToList();
        }
        public List<CategoryLevel1_CategoryLevel2> Sel()
        {
            return this.aDatabaseDA.CategoryLevel1_CategoryLevel2.ToList();
        }

        
    }
}
