using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Collections.Specialized;
using System.Web.Configuration;
using System.IO;
using System.Xml;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public Class1()
    {

    }

    public static string ConnectionString()
    {
        return System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
    }
    public static string SCDLBook()
    {
        return System.Configuration.ConfigurationSettings.AppSettings["BookStringNLB"];
    }
    public static string NonSCDLBook()
    {
        return System.Configuration.ConfigurationSettings.AppSettings["PerceptionP4"];
    }
    public static string BookP4()
    {
        return System.Configuration.ConfigurationSettings.AppSettings["ABMBookString"];
    }
    // define the provider for access or sql
    public enum Provider
    {
        SQL = 1, Access = 2
    }
    //return dataset with Procedure
    public DataSet GetDataSet(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.ConnectionString());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        //dbcom.CommandType=CommandType.StoredProcedure;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    public DataSet GetDataSetAATC(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.BookP4());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        //dbcom.CommandType=CommandType.StoredProcedure;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    public SqlDataReader GetDataReader(string sqlText)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataReader dr1 = null;

        dbcon = new SqlConnection(Class1.ConnectionString());
        dbcom = new SqlCommand(sqlText, dbcon);
        try
        {
            dbcom.Connection.Open();
            //dr = dbcom.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            dr1 = dbcom.ExecuteReader();
        }
        catch (Exception err)
        {
            string asasd = err.Message;
            asasd = asasd;
        }
        return dr1;
    }
    public DataSet GetDataSetScdl(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.SCDLBook());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        //dbcom.CommandType=CommandType.StoredProcedure;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    public DataSet GetDataSetNonScdl(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.NonSCDLBook());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        //dbcom.CommandType=CommandType.StoredProcedure;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    //Execute Non Quesry
    public bool ExecuteNonQuery(string sqlText)
    {
        bool result;
        SqlCommand dbcom;
        SqlConnection dbcon;
        dbcon = new SqlConnection(Class1.ConnectionString());
        try
        {
            // connection string


            //call the stored procedure
            dbcom = new SqlCommand(sqlText, dbcon);
            dbcom.CommandType = CommandType.Text;
            dbcon.Open();
            dbcom.ExecuteNonQuery();

            result = true;
        }
        catch (Exception err)
        {
            result = false;
        }
        finally
        {
            dbcon.Close();
        }
        return result;

    }
    public bool ExecuteNonQuerySCDL(string sqlText)
    {
        bool result;
        SqlCommand dbcom;
        SqlConnection dbcon;
        dbcon = new SqlConnection(Class1.SCDLBook());
        try
        {
            // connection string


            //call the stored procedure
            dbcom = new SqlCommand(sqlText, dbcon);
            dbcom.CommandType = CommandType.Text;
            dbcon.Open();
            dbcom.ExecuteNonQuery();

            result = true;
        }
        catch (Exception err)
        {
            result = false;
        }
        finally
        {
            dbcon.Close();
        }
        return result;

    }
    public bool ExecuteNonQueryAATC(string sqlText)
    {
        bool result;
        SqlCommand dbcom;
        SqlConnection dbcon;
        dbcon = new SqlConnection(Class1.BookP4());
        try
        {
            // connection string


            //call the stored procedure
            dbcom = new SqlCommand(sqlText, dbcon);
            dbcom.CommandType = CommandType.Text;
            dbcon.Open();
            dbcom.ExecuteNonQuery();

            result = true;
        }
        catch (Exception err)
        {
            result = false;
        }
        finally
        {
            dbcon.Close();
        }
        return result;

    }
    public bool ExecuteNonQueryNonSCDL(string sqlText)
    {
        bool result;
        SqlCommand dbcom;
        SqlConnection dbcon;
        dbcon = new SqlConnection(Class1.NonSCDLBook());
        try
        {
            // connection string


            //call the stored procedure
            dbcom = new SqlCommand(sqlText, dbcon);
            dbcom.CommandType = CommandType.Text;
            dbcon.Open();
            dbcom.ExecuteNonQuery();

            result = true;
        }
        catch (Exception err)
        {
            result = false;
        }
        finally
        {
            dbcon.Close();
        }
        return result;

    }
    //return dataset by Passing  Query
    public DataSet GetDataSetWithQuery(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.ConnectionString());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        dbcom.CommandType = CommandType.Text;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }

    public DataTable GetDataTableWithQuery(string sqlText)
    {
        DataTable dt = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.ConnectionString());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        dbcom.CommandType = CommandType.Text;
        dadapter = new SqlDataAdapter(dbcom);

        dt = new DataTable();
        dadapter.Fill(dt);
        dbcon.Close();
        return dt;
    }

    public DataSet GetDataSetWithQuerySCDL(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.SCDLBook());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        dbcom.CommandType = CommandType.Text;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    public DataSet GetDataSetWithQueryAATC(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.BookP4());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        dbcom.CommandType = CommandType.Text;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }
    public DataSet GetDataSetWithQueryNonSCDL(string sqlText)
    {
        DataSet ds = null;
        SqlCommand dbcom;
        SqlConnection dbcon;
        SqlDataAdapter dadapter;

        // connection string
        dbcon = new SqlConnection(Class1.NonSCDLBook());

        //call the stored procedure
        dbcom = new SqlCommand(sqlText, dbcon);
        dbcom.CommandType = CommandType.Text;
        dadapter = new SqlDataAdapter(dbcom);

        ds = new DataSet();
        dadapter.Fill(ds, "results");
        dbcon.Close();
        return ds;
    }

    //return int from DataReader but with ExecuteScalar

    public int SingleCellResult(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        int lcchkRec = 0;
        dbcon = new SqlConnection(Class1.ConnectionString());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = (int)dbcom.ExecuteScalar();
            dbcon.Close();
        }
        catch (Exception err)
        {
            lcchkRec = 0;
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public int SingleCellResultSCDL(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        int lcchkRec = 0;
        dbcon = new SqlConnection(Class1.SCDLBook());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = (int)dbcom.ExecuteScalar();
            dbcon.Close();
        }
        catch (Exception err)
        {
            lcchkRec = 0;
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public int SingleCellResultAATC(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        int lcchkRec = 0;
        dbcon = new SqlConnection(Class1.BookP4());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = (int)dbcom.ExecuteScalar();
            dbcon.Close();
        }
        catch (Exception err)
        {
            lcchkRec = 0;
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public int SingleCellResultNonSCDL(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        int lcchkRec = 0;
        dbcon = new SqlConnection(Class1.NonSCDLBook());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = (int)dbcom.ExecuteScalar();
            dbcon.Close();
        }
        catch (Exception err)
        {
            lcchkRec = 0;
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public Boolean SingleCellResultRetBool(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        Boolean returnparam = true;
        int lcchkRec = 0;
        dbcon = new SqlConnection(Class1.ConnectionString());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = dbcom.ExecuteNonQuery();

            if (lcchkRec != -1)
            {
                returnparam = false;
            }
            else
            {
                returnparam = (Boolean)dbcom.ExecuteScalar();
            }
        }
        catch (Exception err)
        {
            //	lcchkRec=0;
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return returnparam;
    }
    //return String from DataReader but with ExecuteScalar
    public string SingleCellResultInString(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        string lcchkRec = "";
        dbcon = new SqlConnection(Class1.ConnectionString());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);

            lcchkRec = dbcom.ExecuteScalar().ToString();
            dbcon.Close();
        }
        catch (Exception err)
        {
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public string SingleCellResultInStringSCDL(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        string lcchkRec = "";
        dbcon = new SqlConnection(Class1.SCDLBook());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = dbcom.ExecuteScalar().ToString();
            dbcon.Close();
        }
        catch (Exception err)
        {
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public string SingleCellResultInStringAATC(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        string lcchkRec = "";
        dbcon = new SqlConnection(Class1.BookP4());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = dbcom.ExecuteScalar().ToString();
            dbcon.Close();
        }
        catch (Exception err)
        {
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        return lcchkRec;
    }
    public string SingleCellResultInStringNonSCDL(string strquery)
    {
        SqlCommand dbcom;
        SqlConnection dbcon;
        string lcchkRec = "";
        dbcon = new SqlConnection(Class1.NonSCDLBook());
        try
        {
            dbcon.Open();
            dbcom = new SqlCommand(strquery, dbcon);
            lcchkRec = dbcom.ExecuteScalar().ToString();
            dbcon.Close();
        }
        catch (Exception err)
        {
        }

        finally
        {
            if (dbcon.State == ConnectionState.Open)
            {
                dbcon.Close();
            }
        }
        if (lcchkRec == "")
        {
            lcchkRec = "NA";
        }
        return lcchkRec;
    }

    public string getPassword(string MerchantId)
    {
        string str;
        long adler;
        str = MerchantId;
        adler = 1;
        return Passadler32(adler, str);
    }

    private string Passadler32(long adler, string strPattern)
    {
        long BASE;
        long s1, s2;
        char[] testchar;
        long intTest = 0;

        BASE = 65521;
        s1 = Passandop(adler, 65535);
        s2 = Passandop(Passcdec(Passrightshift(Passcbin(adler), 16)), 65535);

        for (int n = 0; n < strPattern.Length; n++)
        {

            testchar = (strPattern.Substring(n, 1)).ToCharArray();
            intTest = (long)testchar[0];
            s1 = (s1 + intTest) % BASE;
            s2 = (s2 + s1) % BASE;
        }
        return (Passcdec(Passleftshift(Passcbin(s2), 16)) + s1).ToString();
    }


    private long Passpower(long num)
    {
        long result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = result * 2;
        }
        return result;
    }


    private long Passandop(long op1, long op2)
    {
        string op, op3, op4;
        op = "";

        op3 = Passcbin(op1);
        op4 = Passcbin(op2);

        for (int i = 0; i < 32; i++)
        {
            op = op + "" + ((long.Parse(op3.Substring(i, 1))) & (long.Parse(op4.Substring(i, 1))));
        }
        return Passcdec(op);
    }

    private string Passcbin(long num)
    {
        string bin = "";
        do
        {
            bin = (((num % 2)) + bin).ToString();
            num = (long)Math.Floor(Convert.ToDecimal(num / 2));
        } while (!(num == 0));

        long tempCount = 32 - bin.Length;

        for (int i = 1; i <= tempCount; i++)
        {
            bin = "0" + bin;
        }
        return bin;
    }


    private string Passleftshift(string str, long num)
    {
        long tempCount = 32 - str.Length;

        for (int i = 1; i <= tempCount; i++)
        {

            str = "0" + str;
        }

        for (int i = 1; i <= num; i++)
        {
            str = str + "0";
            str = str.Substring(1, str.Length - 1);
        }
        return str;
    }


    private string Passrightshift(string str, long num)
    {

        for (int i = 1; i <= num; i++)
        {
            str = "0" + str;
            str = str.Substring(0, str.Length - 1);
        }
        return str;
    }

    private long Passcdec(string strNum)
    {
        long dec = 0;
        for (int n = 0; n < strNum.Length; n++)
        {
            dec = dec + (long)(long.Parse(strNum.Substring(n, 1)) * Passpower(strNum.Length - (n + 1)));
        }
        return dec;
    }

    private void checkFormNotSubmit()
    {
        // string strSQL = "";
        // strSQL="select fsubmit from tblabdcandidateinfo "
    }
}