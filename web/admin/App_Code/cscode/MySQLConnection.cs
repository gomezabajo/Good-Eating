using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.Odbc;

using Microsoft.VisualBasic;

/// <summary>
/// Descripción breve de MySqlConnection
/// </summary>
public class MySqlConnection
{
    private OdbcConnection _conn;

    public OdbcConnection Connection
    {
        get
        {
            return _conn;
        }
        set
        {
            _conn = value;
        }
    }

    public void Open()
    {
        try
        {
            Connection.Open();
        }
        catch
        {
            throw;
        }
    }

    public void Close()
    {
        if (Connection != null)
        {
            Connection.Close();
        }
    }

    public bool Opened()
    {
        if (Connection != null)
        {
            if (Connection.State != ConnectionState.Open)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    public bool Closed()
    {
        if (Connection != null)
        {
            if (Connection.State != ConnectionState.Closed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    public bool TryClose()
    {
        int count = 0;
        while ((Closed() != true) && (count < 3))
        {
            Close();
            count++;
        }
        if (Closed() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TryOpen()
    {
        try
        {
            if (Opened() == false)
            {
                int count = 0;
                do
                {
                    Open();
                    count++;
                    if (Opened() != true)
                    {
                        if (Closed() != true)
                        {
                            if (TryClose() != true)
                            {
                                return false;
                            }
                        }
                    }
                    if ((Opened() == true) || (count >= 3))
                    {
                        break;
                    }
                } while (true);
                if (Opened() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        catch
        {
            throw;
        }
    }

    public void Dispose()
    {
        if (Connection != null)
        {
            Connection.Dispose();
            Connection = null;
        }
    }

    public void Create()
    {
        Connection = new OdbcConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    }
    public MySqlConnection()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
