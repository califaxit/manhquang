using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Objects;
using System.Configuration;
using System.Linq;
using DataAccess;
using EntitiesExt;

namespace BussinessLogic
{
    public  class FilesBO
    {
           // code QuyDQ
        DatabaseDA aDatabaseDA = new DatabaseDA();
        

        #region[select]
        //ID
           public Files Sel_ByID(Int32 ID)
        {
            try
            {
                Files aFiles = aDatabaseDA.Files.Where(b => b.ID == ID).ToList()[0];

                return aFiles;


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel: {0}", ex.Message));
            }
        }
           public Files Sel_ByID(Int32 ID,bool Disable)
           {
               try
               {
                   Files aFiles = aDatabaseDA.Files.Where(b => b.ID == ID).Where(p=>p.Disable==Disable).ToList()[0];

                   return aFiles;


               }
               catch (Exception ex)
               {
                   throw new Exception(String.Format("FilesBO.Sel: {0}", ex.Message));
               }
           }
        // IDLang
        public List<Files> Sel_ByIDLang( int IDLang)
        {
            try
            {
                return aDatabaseDA.Files.Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }
		public List<Files> Sel_ByIDLang( int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.Files.Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByIDLang:{0}", ex.Message));
            }
        }
        // IDLang-Status
        public List<Files> Sel_ByStatus_ByIDLang(int Status, int IDLang)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        public List<Files> Sel_ByStatus_ByIDLang(int Status, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).Where(m=>m.Disable==Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByStatus:{0}", ex.Message));
            }
        }
        //IDLang-Type
        public List<Files> Sel_ByType_ByIDLang(int Type, int IDLang)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Type == Type).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Files> Sel_ByType_ByIDLang(int Type, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Type == Type).Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByType:{0}", ex.Message));
            }
        }
        public List<Files> Sel_ByType_ByStatus_ByIDLang(int Type, int Status, int IDLang)
        {
            try
            {
                return aDatabaseDA.Files.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }
        public List<Files> Sel_ByType_ByStatus_ByIDLang(int Type, int Status, int IDLang, bool Disable)
        {
            try
            {
                return aDatabaseDA.Files.Where(c => c.Type == Type).Where(p => p.Status == Status).Where(z => z.IDLang == IDLang).Where(z => z.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByType_ByStatus_ByIDLang:{0}", ex.Message));
            }
        }
        // Code
        public List<Files> Sel_ByCode(string Code)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Code == Code).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByCode: {0}", ex.Message));
            }
        }
        public List<Files> Sel_ByCode(string Code, bool Disable)
        {
            try
            {
                return aDatabaseDA.Files.Where(p => p.Code == Code).Where(p => p.Disable == Disable).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Sel_ByCode: {0}", ex.Message));
            }
        }         
        public List<Files> Sel_ByCode_ByIDLang(string Code, int IDLang)
        {
            try
            {

                List<Files> aListFiles = new List<Files>();


                return aDatabaseDA.Files.Where(a => a.Code == Code).Where(a => a.IDLang == IDLang).ToList();
                
                
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.SelectListFiles_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }
        public List<Files> Sel_ByCode_ByIDLang(string Code, int IDLang, bool Disable)
        {
            try
            {

                List<Files> aListFiles = new List<Files>();


                return aDatabaseDA.Files.Where(a => a.Code == Code).Where(a => a.IDLang == IDLang).Where(a => a.Disable == Disable).ToList();
               
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.SelectListFiles_ByCode_ByCategoryL1: {0}", ex.Message));
            }
        }
        //File extend Abum - QuyDQ
         public List<vw_FilesViewAll> Sel_Ext_ByIDLang(int IDLang)
        {
            try
            {
                return aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_IDLang == IDLang).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
            }
        }
         public List<vw_FilesViewAll> Sel_Ext_ByIDLang(int IDLang, bool Disable)
         {
             try
             {
                 return aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_IDLang == IDLang).Where(m=>m.Albums_Disable==Disable).ToList();
             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByCodeAlbums(string Code)
         {
             try
             {
                 return aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code==Code).ToList();
             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByCodeAlbums(string Code, bool Disable)
         {
             try
             {
                 return aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code == Code).Where(m=>m.Albums_Disable==Disable).ToList();
             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByCodeAlbums(string Code, int IDLang)
         {
             try
             {
                 return aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code == Code).Where(m => m.Files_IDLang == IDLang).ToList();
             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByCodeAlbums(string Code, int IDLang,bool Disable)
         {
             try
             {
                 return aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code == Code).Where(m => m.Files_IDLang == IDLang).Where(m=>m.Albums_Disable==Disable).ToList();
             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.Sel_Ext_ByIDLang: {0}", ex.Message));
             }
         }
         //  vw_FilesViewAll By key - QuyDQ
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeFiles_ByIDLang(string Key, int IDLang)
         {
             try
             {
                 ConfigsBO aConfigsBO = new ConfigsBO();
              

                 List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                 List<string> ListCode = new List<string>();
                 for (int i = 0; i <ListConfig.Count; i++)
                 {
                     ListCode.Add(ListConfig[i].Value.ToString());
                 }
                 string ListCodeTempt = String.Join(",", ListCode);

                 return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).Where(p => p.Files_IDLang == IDLang).ToList();


             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeFiles_ByIDLang(string Key, int IDLang, bool Disable)
         {
             try
             {
                 ConfigsBO aConfigsBO = new ConfigsBO();


                 List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                 List<string> ListCode = new List<string>();
                 for (int i = 0; i < ListConfig.Count; i++)
                 {
                     ListCode.Add(ListConfig[i].Value.ToString());
                 }
                 string ListCodeTempt = String.Join(",", ListCode);

                 return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).Where(p => p.Files_IDLang == IDLang).Where(p=>p.Files_Disable==Disable).ToList();


             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeAlbums_ByIDLang(string Key, int IDLang)
         {
             try
             {
                 ConfigsBO aConfigsBO = new ConfigsBO();


                 List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                 List<string> ListCode = new List<string>();
                 for (int i = 0; i < ListConfig.Count; i++)
                 {
                     ListCode.Add(ListConfig[i].Value.ToString());
                 }
                 string ListCodeTempt = String.Join(",", ListCode);

                 return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code.Contains(ListCodeTempt)).Where(p => p.Files_IDLang == IDLang).ToList();


             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeAlbums_ByIDLang(string Key, int IDLang, bool Disable)
         {
             try
             {
                 ConfigsBO aConfigsBO = new ConfigsBO();


                 List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                 List<string> ListCode = new List<string>();
                 for (int i = 0; i < ListConfig.Count; i++)
                 {
                     ListCode.Add(ListConfig[i].Value.ToString());
                 }
                 string ListCodeTempt = String.Join(",", ListCode);

                 return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Albums_Code.Contains(ListCodeTempt)).Where(p => p.Files_IDLang == IDLang).Where(p=>p.Albums_Disable==Disable).ToList();


             }
             catch (Exception ex)
             {
                 throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
             }
         }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeFiles(string Key)
        {
            try
            {
                ConfigsBO aConfigsBO = new ConfigsBO();


                List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                List<string> ListCode = new List<string>();
                for (int i = 0; i < ListConfig.Count; i++)
                {
                    ListCode.Add(ListConfig[i].Value.ToString());
                }
                string ListCodeTempt = String.Join(",", ListCode);

                return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
            }
        }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeFiles(string Key,bool Disable)
        {
            try
            {
                ConfigsBO aConfigsBO = new ConfigsBO();

                List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                List<string> ListCode = new List<string>();
                for (int i = 0; i < ListConfig.Count; i++)
                {
                    ListCode.Add(ListConfig[i].Value.ToString());
                }
                string ListCodeTempt = String.Join(",", ListCode);

                return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).Where(p=>p.Files_Disable==Disable).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
            }
        }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeAlbums(string Key)
        {
            try
            {
                ConfigsBO aConfigsBO = new ConfigsBO();

                List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                List<string> ListCode = new List<string>();
                for (int i = 0; i < ListConfig.Count; i++)
                {
                    ListCode.Add(ListConfig[i].Value.ToString());
                }
                string ListCodeTempt = String.Join(",", ListCode);

                return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
            }
        }
         public List<vw_FilesViewAll> Sel_Ext_ByKeyCodeAlbums(string Key,bool Disable)
        {
            try
            {
                ConfigsBO aConfigsBO = new ConfigsBO();


                List<Configs> ListConfig = aConfigsBO.Sel_ByAccessKey(Key);
                List<string> ListCode = new List<string>();
                for (int i = 0; i < ListConfig.Count; i++)
                {
                    ListCode.Add(ListConfig[i].Value.ToString());
                }
                string ListCodeTempt = String.Join(",", ListCode);

                return this.aDatabaseDA.vw_FilesViewAll.Where(p => p.Files_Code.Contains(ListCodeTempt)).Where(p=>p.Albums_Disable==Disable).ToList();


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("ContentsBO.SelectContents_ByCode_002: {0}", ex.Message));
            }
        }
        #endregion
        #region [update]
        public int Upd_Status_ByID(int ID, int NewStatus) 
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.ID == ID).ToList();
                if (aListFiles.Count > 0) 
                {
                   
                        aListFiles[0].Status = NewStatus;
                        aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Status_ByID:{0}", ex.Message));
            }
        }
        public int Upd_Type_ByID(int ID, int NewType) 
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.ID == ID).ToList();
                if (aListFiles.Count > 0) 
                {
                   
                        aListFiles[0].Type = NewType;
                        aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
               
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Type_ByID:{0}", ex.Message));
            }
        }
        public int Upd_Disable_ByID(int ID,bool NewDisable) 
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.ID == ID).ToList();
                if (aListFiles.Count > 0) 
                {
                   
                        aListFiles[0].Disable = NewDisable;
                        aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                        return aDatabaseDA.SaveChanges();
                    
                }
                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(String.Format("Upd_Disable_ByID:{0}", ex.Message));
            }
        }
        public int Upd_Status_ByCode(string Code, int NewStatus)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).ToList();
                if (aListFiles.Count > 0)
                {

                    aListFiles[0].Status = NewStatus;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Status_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Type_ByCode(string Code, int NewType)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).ToList();
                if (aListFiles.Count > 0)
                {

                    aListFiles[0].Type = NewType;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Disable_ByCode(string Code, bool NewDisable)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).ToList();
                if (aListFiles.Count > 0)
                {
                    aListFiles[0].Disable = NewDisable;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Type_ByCode:{0}", ex.Message));
            }
        }

        public int Upd_Status_ByCode_ByLang(string Code, int NewStatus, int IDLang)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListFiles.Count > 0)
                {
                    aListFiles[0].Status = NewStatus;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Status_ByCode_ByLang:{0}", ex.Message));
            }
        }


        public int Upd_Type_ByCode_ByLang(string Code, int NewType, int IDLang)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListFiles.Count > 0)
                {
                    aListFiles[0].Type = NewType;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Type_ByCode_ByLang:{0}", ex.Message));
            }
        }

        public int Upd_Disable_ByCode_ByLang(string Code, bool NewDisable, int IDLang)
        {
            try
            {
                List<Files> aListFiles = aDatabaseDA.Files.Where(b => b.Code == Code).Where(z => z.IDLang == IDLang).ToList();
                if (aListFiles.Count > 0)
                {
                    aListFiles[0].Disable = NewDisable;
                    aDatabaseDA.Files.AddOrUpdate(aListFiles[0]);
                    return aDatabaseDA.SaveChanges();

                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Upd_Disable_ByCode_ByLang:{0}", ex.Message));
            }
        }
        public int Upd(List<Files> aListFiles)
        {
            try
            {
                aDatabaseDA.Files.AddOrUpdate(aListFiles.ToArray());
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Ins: {0}", ex.Message));
            }
        }
        public int Upd(Files aFiles)
        {
            try
            {
                aDatabaseDA.Files.AddOrUpdate(aFiles);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Upd: {0}", ex.Message));
            }
        }
        #endregion
        #region[delete]
        public int Del()
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del_ByCode: {0}", ex.Message));
            }
        }
		public int Del_ByID(Int32 ID)
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.Where(p=>p.ID == ID).ToList();
           
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                else
                {
                    throw new Exception(String.Format("FilesBO.Del: {0}", "Không tìm thấy Files có ID = " + ID));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del: {0}", ex.Message));
            }
        }
		
        public int Del_By_ListID(List<int> aListID)
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.Where(p => aListID.Contains(int.Parse(p.ID.ToString()))).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del_ByCode: {0}", ex.Message));
            }
        }
        public int Del(List<Files> aListFiles)
        {
            try
            {
                aDatabaseDA.Files.RemoveRange(aListFiles);
                return aDatabaseDA.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del: {0}", ex.Message));
            }
        }

        public int Del_ByCode(string Code)
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.Where(p => p.Code == Code).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del_ByCode: {0}", ex.Message));
            }
        }
        public int Del_ByCode_ByIDLang(string Code, int IDLang)
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.Where(p => p.Code == Code).Where(p => p.IDLang == IDLang).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.Remove(aTemp[0]);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del_ByCode_ByIDLang: {0}", ex.Message));
            }
        }
        public int Del_By_ListCode(List<string> aListCode)
        {
            try
            {
                List<Files> aTemp = aDatabaseDA.Files.Where(p => aListCode.Contains(p.Code)).ToList();
                if (aTemp.Count > 0)
                {
                    aDatabaseDA.Files.RemoveRange(aTemp);
                    return aDatabaseDA.SaveChanges();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Del_ByCode: {0}", ex.Message));
            }
        }
        #endregion
        #region [insert]
        public int Ins(Files aFiles)
        {
            try
            {
                aDatabaseDA.Files.AddOrUpdate(aFiles);
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Ins: {0}", ex.Message));
            }
        }
        public int Ins(ref List<Files> aListFiles)
        {
            try
            {
                aListFiles = aDatabaseDA.Files.AddRange(aListFiles).ToList();
                return aDatabaseDA.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("FilesBO.Ins: {0}", ex.Message));
            }
        }
        #endregion









    }
}

