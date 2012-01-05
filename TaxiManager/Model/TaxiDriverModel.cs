using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Model
{
    class TaxiDriverModel : Classes.CDBase
    {
        private const string SELCMD = "SELECT * FROM taxi_driver WHERE 1=1 ";
        private const string INSCMD = "INSERT INTO taxi_driver (td_name, td_ic, td_dob, td_address, td_postcode, td_tel, td_hp, td_relname, td_relationship, " +
                                      "td_reladdress, td_relpostcode, td_reltel, td_relhp, td_rel1name, td_relationship1, td_rel1address, td_rel1postcode, " +
                                      "td_rel1tel, td_rel1hp, td_marital, td_kidsno, td_spousename, td_spouseic, td_fathername, td_fatheric, td_mothername, " +
                                      "td_motheric, td_licenseno, td_licenseend, td_taxilicenseno, td_taxilicenseend, td_expyr, td_exptaxiyr, td_lasttaxino, " +
                                      "td_lasttaxicom, td_lastoccup, td_reference, td_reftel, td_applicationfor, td_applicationdate, td_staffid, td_photo, " +
                                      "td_comid, td_taxiid, td_memberid, c_by, c_date, u_by, u_date) " +
                                      "VALUES ('?td_name', '?td_ic', '?td_dob', '?td_address', ?td_postcode, '?td_tel', '?td_hp', '?td_relname', ?td_relationship, " +
                                      "'?td_reladdress', ?td_relpostcode, '?td_reltel', '?td_relhp', '?td_rel1name', ?td_relationship1, '?td_rel1address', ?td_rel1postcode, " +
                                      "'?td_rel1tel', '?td_rel1hp', ?td_marital, ?td_kidsno, '?td_spousename', '?td_spouseic', '?td_fathername', '?td_fatheric', '?td_mothername', " +
                                      "'?td_motheric', '?td_licenseno', '?td_licenseend', '?td_taxilicenseno', '?td_taxilicenseend', ?td_expyr, ?td_exptaxiyr, '?td_lasttaxino', " +
                                      "'?td_lasttaxicom', '?td_lastoccup', '?td_reference', '?td_reftel', ?td_applicationfor, '?td_applicationdate', ?td_staffid, '?td_photo', " +
                                      "?td_comid, ?td_taxiid, '?td_memberid', ?c_by, NOW(), ?c_by, NOW())";
        private const string UPDCMD = "UPDATE taxi_driver SET " +
                                            "td_name = '?td_name', " + 
                                            "td_ic = '?td_ic', " +
                                            "td_dob = '?td_dob', " +
                                            "td_address = '?td_address', " +
                                            "td_postcode = ?td_postcode, " +
                                            "td_tel = '?td_tel', " +
                                            "td_hp = '?td_hp', " +
                                            "td_relname = '?td_relname', " +
                                            "td_relationship = ?td_relationship, " + 
                                            "td_reladdress = '?td_reladdress', " +
                                            "td_relpostcode = ?td_relpostcode, "+
                                            "td_reltel = '?td_reltel', " +
                                            "td_relhp = '?td_relhp', " +
                                            "td_rel1name = '?td_rel1name', " +
                                            "td_relationship1 = ?td_relationship1, " +
                                            "td_rel1address = '?td_rel1address', " +
                                            "td_rel1postcode = ?td_rel1postcode, " +
                                            "td_rel1tel = '?td_rel1tel', " +
                                            "td_rel1hp = '?td_rel1hp', " +
                                            "td_marital = ?td_marital, " +
                                            "td_kidsno = ?td_kidsno, " +
                                            "td_spousename = '?td_spousename', " +
                                            "td_spouseic = '?td_spouseic', " +
                                            "td_fathername = '?td_fathername', " +
                                            "td_fatheric = '?td_fatheric', " +
                                            "td_mothername = '?td_mothername', " +
                                            "td_motheric = '?td_motheric', " +
                                            "td_licenseno = '?td_licenseno', " +
                                            "td_licenseend = '?td_licenseend', " + 
                                            "td_taxilicenseno = '?td_taxilicneseno', " + 
                                            "td_taxilicenseend = '?td_taxilicenseend', " + 
                                            "td_expyr = ?td_expyr, " + 
                                            "td_exptaxiyr = ?td_exptaxiyr, " +
                                            "td_lasttaxino = '?td_lasttaxino', " +
                                            "td_lasttaxicom = '?td_lasttaxicom', " + 
                                            "td_lastoccup = '?td_lastoccup', " + 
                                            "td_reference = '?td_reference', " + 
                                            "td_reftel = '?td_reftel', " +
                                            "td_applicationfor = ?td_applicationfor, " + 
                                            "td_applicationdate = '?td_applicationdate', " + 
                                            "td_staffid = ?td_staffid, " + 
                                            "td_photo = '?td_photo'" +
                                            "td_comid = ?td_comid, " + 
                                            "td_raxiid = ?td_taxiid, " + 
                                            "td_memberid = '?td_memberid', " + 
                                            "u_by = ?u_by " + 
                                      "WHERE taxiid = taxiid";
        private const string DELCMD = "DELETE FROM taxi_driver WHERE taxiid = ?taxiid";

        protected DataTable GetDriverList(string Clauses)
        {
            return GetDTable(SELCMD + Clauses);
        }
        
        public int InsertDriver(string td_name, string td_ic, DateTime td_dob, string td_address, int td_postcode, string td_tel, 
                                string td_hp, string td_relname, int td_relationship, string td_reladdress, int td_relpostcode, 
                                string td_reltel, string td_relhp, string td_rel1name, int td_relationship1, string td_rel1address, 
                                int td_rel1postcode, string td_rel1tel, string td_rel1hp, int td_marital, int td_kidsno, string td_spousename, 
                                string td_spouseic, string td_fathername, string td_fatheric, string td_mothername, string td_motheric, 
                                string td_licenseno, DateTime td_licenseend, string td_taxilicenseno, DateTime td_taxilicenseend, 
                                int td_expyr, int td_exptaxiyr, string td_lasttaxino, string td_lasttaxicom, string td_lastoccup, 
                                string td_reference, string td_reftel, int td_applicationfor, DateTime td_applicationdate, int td_staffid, 
                                string td_photo, int td_comid, int td_taxiid, string td_memberid, int c_by)
        {
            object result = 0;
            string Insert = INSCMD;
            Insert = Insert.Replace("?td_name", td_name);
            Insert = Insert.Replace("?td_ic", td_ic);
            Insert = Insert.Replace("?td_dob", td_dob.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("?td_address", td_address);
            Insert = Insert.Replace("?td_postcode", td_postcode.ToString());
            Insert =Insert.Replace("?td_tel", td_tel);
            Insert = Insert.Replace("?td_hp", td_hp);
            Insert = Insert.Replace("?td_relname", td_relname);
            Insert = Insert.Replace("?td_relationship", td_relationship.ToString());
            Insert = Insert.Replace("?td_reladdress", td_reladdress);
            Insert = Insert.Replace("?td_relpostcode", td_relpostcode.ToString());
            Insert = Insert.Replace ("?td_reltel", td_reltel);
            Insert = Insert.Replace("?td_relhp", td_relhp);
            Insert = Insert.Replace("?td_rel1name", td_rel1name);
            Insert = Insert.Replace("?td_relationship1", td_relationship1.ToString());
            Insert = Insert.Replace("?td_rel1address", td_rel1address);
            Insert = Insert.Replace("?td_rel1postcode", td_rel1postcode.ToString());
            Insert = Insert.Replace("?td_rel1tel", td_rel1tel);
            Insert = Insert.Replace("?td_rel1hp", td_rel1hp);
            Insert = Insert.Replace("?td_marital", td_marital.ToString());
            Insert = Insert.Replace("?td_kidsno", td_kidsno.ToString());
            Insert = Insert.Replace("?td_spousename", td_spousename);
            Insert = Insert.Replace("?td_spouseic", td_spouseic);
            Insert = Insert.Replace("?td_fathername", td_fathername);
            Insert = Insert.Replace("?td_fatheric", td_fatheric);
            Insert = Insert.Replace("?td_mothername", td_mothername);
            Insert = Insert.Replace("?td_motheric", td_motheric);
            Insert = Insert.Replace("?td_licenseno", td_licenseno); 
            Insert = Insert.Replace("?td_licenseend", td_licenseend.ToString("yyyy-MM-dd")); 
            Insert = Insert.Replace("?td_taxilicenseno", td_taxilicenseno); 
            Insert = Insert.Replace("?td_taxilicenseend", td_taxilicenseend.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("?td_expyr", td_expyr.ToString());
            Insert = Insert.Replace("?td_exptaxiyr", td_exptaxiyr.ToString());
            Insert = Insert.Replace("?td_lasttaxino", td_lasttaxino);
            Insert = Insert.Replace("?td_lasttaxicom", td_lasttaxicom);
            Insert = Insert.Replace("?td_lastoccup", td_lastoccup);
            Insert = Insert.Replace("?td_reference", td_reference);
            Insert = Insert.Replace("?td_reftel", td_reftel);
            Insert = Insert.Replace("?td_applicationfor", td_applicationfor.ToString());
            Insert = Insert.Replace("?td_applicationdate", td_applicationdate.ToString("yyyy-MM-dd"));
            Insert = Insert.Replace("?td_staffid", td_staffid.ToString());
            Insert = Insert.Replace("?td_photo", td_photo);
            Insert = Insert.Replace("?td_comid", td_comid.ToString());
            Insert = Insert.Replace("?td_taxiid", td_taxiid.ToString());
            Insert = Insert.Replace("?td_memberid", td_memberid);
            Insert = Insert.Replace("?c_by", c_by.ToString());

            result = ExecuteCommand(Insert);
            return Classes.CConstant.GetResult(result);
        }

        public int UpdateDriver(string td_name, string td_ic, DateTime td_dob, string td_address, int td_postcode, string td_tel, 
                                string td_hp, string td_relname, int td_relationship, string td_reladdress, int td_relpostcode, 
                                string td_reltel, string td_relhp, string td_rel1name, int td_relationship1, string td_rel1address, 
                                int td_rel1postcode, string td_rel1tel, string td_rel1hp, int td_marital, int td_kidsno, string td_spousename, 
                                string td_spouseic, string td_fathername, string td_fatheric, string td_mothername, string td_motheric, 
                                string td_licenseno, DateTime td_licenseend, string td_taxilicenseno, DateTime td_taxilicenseend, 
                                int td_expyr, int td_exptaxiyr, string td_lasttaxino, string td_lasttaxicom, string td_lastoccup, 
                                string td_reference, string td_reftel, int td_applicationfor, DateTime td_applicationdate, int td_staffid, 
                                string td_photo, int td_comid, int td_taxiid, string td_memberid, int u_by, int tdid)
        {
            object result = 0;
            string Update = UPDCMD;
            Update = Update.Replace("?td_name", td_name);
            Update = Update.Replace("?td_ic", td_ic);
            Update = Update.Replace("?td_dob", td_dob.ToString("yyyy-MM-dd"));
            Update = Update.Replace("?td_address", td_address);
            Update = Update.Replace("?td_postcode", td_postcode.ToString());
            Update =Update.Replace("?td_tel", td_tel);
            Update = Update.Replace("?td_hp", td_hp);
            Update = Update.Replace("?td_relname", td_relname);
            Update = Update.Replace("?td_relationship", td_relationship.ToString());
            Update = Update.Replace("?td_reladdress", td_reladdress);
            Update = Update.Replace("?td_relpostcode", td_relpostcode.ToString());
            Update = Update.Replace ("?td_reltel", td_reltel);
            Update = Update.Replace("?td_relhp", td_relhp);
            Update = Update.Replace("?td_rel1name", td_rel1name);
            Update = Update.Replace("?td_relationship1", td_relationship1.ToString());
            Update = Update.Replace("?td_rel1address", td_rel1address); 
            Update = Update.Replace("?td_rel1postcode", td_rel1postcode.ToString());
            Update = Update.Replace("?td_rel1tel", td_rel1tel);
            Update = Update.Replace("?td_rel1hp", td_rel1hp);
            Update = Update.Replace("?td_marital", td_marital.ToString());
            Update = Update.Replace("?td_kidsno", td_kidsno.ToString());
            Update = Update.Replace("?td_spousename", td_spousename);
            Update = Update.Replace("?td_spouseic", td_spouseic);
            Update = Update.Replace("?td_fathername", td_fathername);
            Update = Update.Replace("?td_fatheric", td_fatheric);
            Update = Update.Replace("?td_mothername", td_mothername);
            Update = Update.Replace("?td_motheric", td_motheric);
            Update = Update.Replace("?td_licenseno", td_licenseno); 
            Update = Update.Replace("?td_licenseend", td_licenseend.ToString("yyyy-MM-dd")); 
            Update = Update.Replace("?td_taxilicenseno", td_taxilicenseno); 
            Update = Update.Replace("?td_taxilicenseend", td_taxilicenseend.ToString("yyyy-MM-dd"));
            Update = Update.Replace("?td_expyr", td_expyr.ToString());
            Update = Update.Replace("?td_exptaxiyr", td_exptaxiyr.ToString());
            Update = Update.Replace("?td_lasttaxino", td_lasttaxino);
            Update = Update.Replace("?td_lasttaxicom", td_lasttaxicom);
            Update = Update.Replace("?td_lastoccup", td_lastoccup);
            Update = Update.Replace("?td_reference", td_reference);
            Update = Update.Replace("?td_reftel", td_reftel);
            Update = Update.Replace("?td_applicationfor", td_applicationfor.ToString());
            Update = Update.Replace("?td_applicationdate", td_applicationdate.ToString("yyyy-MM-dd"));
            Update = Update.Replace("?td_staffid", td_staffid.ToString());
            Update = Update.Replace("?td_photo", td_photo);
            Update = Update.Replace("?td_comid", td_comid.ToString());
            Update = Update.Replace("?td_taxiid", td_taxiid.ToString());
            Update = Update.Replace("?td_memberid", td_memberid);
            Update = Update.Replace("?c_by", u_by.ToString());
            Update = Update.Replace("?tdid", tdid.ToString());

            result = ExecuteCommand(Update);
            return Classes.CConstant.GetResult(result);
        }

        public int DeleteDriver(int taxiid)
        {
            object result = 0;
            string Delete = DELCMD;
            Delete = Delete.Replace("?taxiid", taxiid.ToString());

            result = ExecuteCommand(Delete);
            return Classes.CConstant.GetResult(result);
        }
    }
}
