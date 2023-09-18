using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
public class SBOConnection
{

    private string _ServerName;
    private string _Port;
    private string _DBUserName;
    private string _DBPassword;
    private string _DBServerType;
    private string _CompanyDB;
    private string _SBOUserName;
    private string _SBOPassword;
    private string _SBOLicenseServer;
    private string _SBOAddOnIdentifier;

    private SAPbobsCOM.Company _Company;


    public SBOConnection(string ServerName, string Port, string DBUserName, string DBPassword, string DBServerType, string CompanyDB, string SBODatabaseName, string SBOUserName, string SBOPassword, string SBOLicenseServer, string SBOAddOnIdentifier)
    {
        this._ServerName = ServerName;
        this._Port = Port;
        this._DBUserName = DBUserName;
        this._DBPassword = DBPassword;
        this._DBServerType = DBServerType;
        this._CompanyDB = CompanyDB;
        this._SBOUserName = SBOUserName;
        this._SBOPassword = SBOPassword;
        this._SBOLicenseServer = SBOLicenseServer;
        this._SBOAddOnIdentifier = SBOAddOnIdentifier;
    }

    public void ChangeUserPass(string SBOUserName, string SBOPassword)
    {
        this._SBOUserName = SBOUserName;
        this._SBOPassword = SBOPassword;
    }


    public string ServerName()
    {
        return _ServerName;
    }

    public string Port()
    {
        return _Port;
    }

    public string DBUserName()
    {
        return _DBUserName;
    }

    public string DBPassword()
    {
        return _DBPassword;
    }

    public string DBServerType()
    {
        return _DBServerType;
    }

    public string CompanyDB()
    {
        return _CompanyDB;
    }

    public string SBOUserName()
    {
        return _SBOUserName;
    }

    public string SBOPassword()
    {
        return _SBOPassword;
    }

    public string SBOLicenseServer()
    {
        return _SBOLicenseServer;
    }

    public string SBOAddOnIdentifier()
    {
        return _SBOAddOnIdentifier;
    }
    public SAPbobsCOM.Company Company()
    {
        return _Company;
    }

    public bool Connected()
    {
        if (Company() == null)
        {
            try
            {
                if (Company().Connected == true)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        return true;
    }

    public bool Connect()
    {
        if (Connected() == true)
        {
            return true;
        }

        _Company = new SAPbobsCOM.Company();
        int iError;
        string sErrMsg = "";

        try
        {
            if (Company().Connected == false)
            {
                if (string.Equals("2005", DBServerType()))
                    Company().DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005;
                else if (string.Equals("2008", DBServerType()))
                    Company().DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008;
                else if (string.Equals("2012", DBServerType()))
                    Company().DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
                else if (string.Equals("2014", DBServerType()))
                    Company().DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014;
                else if (string.Equals("HANA", DBServerType()))
                    Company().DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;

                if (Company().DbServerType == SAPbobsCOM.BoDataServerTypes.dst_HANADB)
                    Company().Server = ServerName() + ":" + Port();
                else
                    Company().Server = ServerName();

                Company().DbUserName = DBUserName();
                Company().DbPassword = DBPassword();

                Company().CompanyDB = CompanyDB();
                Company().UserName = SBOUserName();
                Company().Password = SBOPassword();
                Company().LicenseServer = SBOLicenseServer();
                Company().XmlExportType = SAPbobsCOM.BoXmlExportTypes.xet_ExportImportMode;
                Company().AddonIdentifier = SBOAddOnIdentifier();

                iError = Company().Connect();
                if (iError != 0)
                {
                    Company().GetLastError(out iError, out sErrMsg);
                    throw new Exception(iError.ToString() + " - " + sErrMsg);
                }
                else
                {
                    sErrMsg = "Connected to SAP Database - " + CompanyDB();

                    return true;
                }
            }
            else
            {
                sErrMsg = "SAP Business One already connected to - " + CompanyDB();
                return true;
            }
        }
        catch (Exception ex)
        {
            _Company = null;
            throw new Exception(ex.Message);
        }

        return false;
    }

    public bool Disconnect()
    {
        if (Company() == null)
            return true;
        try
        {
            if (Company().Connected)
            {
                Company().Disconnect();
                return true;
            }
        }
        catch (Exception ex)
        {
            _Company = null;
            throw new Exception("Connection " + ToString() + " : " + ex.Message);
        }
        return true;
    }



}

