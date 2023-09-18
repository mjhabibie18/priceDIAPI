using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DBConnection
{
    private string _ServerName;
    private string _Port;
    private string _DBUserName;
    private string _DBPassword;
    private Sap.Data.Hana.HanaConnection _Connection;
    private Sap.Data.Hana.HanaTransaction _Transaction;

    public DBConnection(string ServerName, string Port, string DBUserName, string DBPassword)
    {
        this._ServerName = ServerName;
        this._Port = Port;
        this._DBUserName = DBUserName;
        this._DBPassword = DBPassword;
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

    public Sap.Data.Hana.HanaConnection Connection()
    {
        return _Connection;
    }

    public bool Connected()
    {
        if (Connection() == null)
        {
            try
            {
                if (Connection().State == System.Data.ConnectionState.Open)
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

        string ConnectionString;

        ConnectionString = "Server=" + ServerName() + ":" + Port() + ";UserID=" + DBUserName() + ";Password=" + DBPassword() + ";";

        try
        {
            _Connection = new Sap.Data.Hana.HanaConnection(ConnectionString);
            Connection().Open();

            return true;
        }
        catch (Exception ex)
        {
            _Connection = null;
            throw new Exception("Connection " + ToString() + " : " + ex.Message);
        }

        return false;
    }

}

