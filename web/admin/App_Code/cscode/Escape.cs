using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections;
using System.Text.RegularExpressions;

using System.Threading;

/// <summary>
/// Descripción breve de Escape
/// </summary>
public class Escape
{
    public static readonly string[] Separadores = { " y ", " Y ", "/", "\\", ",", ";", "-" };

    public static string[] Split(string source, string sep)
    {
        if (source == null)
        {
            return null;
        }
        if (sep == null)
        {
            return null;
        }
        if (source == string.Empty)
        {
            string[] arrs = new string[1];
            arrs[0] = string.Empty;
            return arrs;
        }
        if (sep == string.Empty)
        {
            string[] arrs = new string[1];
            arrs[0] = source;
            return arrs;
        }

        if (source.StartsWith(sep))
        {
            string[] arrs = new string[1];
            arrs[0] = source.Substring(sep.Length, source.Length - sep.Length);
            return arrs;
        }

        if (source.EndsWith(sep))
        {
            string[] arrs = new string[1];
            arrs[0] = source.Substring(0, source.Length - sep.Length);
            return arrs;
        }

        ArrayList arrayListTarget = new ArrayList();
        string temp = null;
        int length = sep.Length;

        if (sep.Length == 1)
        {
            for (int i = 0; i < source.Length; i++)
            {
                temp = string.Empty;
                while ((i < source.Length) && (source[i].ToString() == sep))
                {
                    i++;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                while ((i < source.Length) && (source[i].ToString() != sep))
                {
                    temp += source[i].ToString();
                    i++;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                while ((i < source.Length) && (source[i].ToString() == sep))
                {
                    i++;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                i -= 1;
                arrayListTarget.Add(temp);
                temp = null;
            }
            if (temp != null)
            {
                arrayListTarget.Add(temp);
            }
            string[] target = new string[arrayListTarget.Count - 1];
            for (int i = 0; i < arrayListTarget.Count; i++)
            {
                target[i] = arrayListTarget[i] as string;
            }
            return target;
        }
        else
        {
            for (int i = 0; i < source.Length; i++)
            {
                temp = string.Empty;
                while ((i + length < source.Length) && (source.Substring(i, length) == sep))
                {
                    i += length;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                while ((i + length < source.Length) && (source.Substring(i, length) != sep))
                {
                    temp += source[i].ToString();
                    i++;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                while ((i + length < source.Length) && (source.Substring(i, length) == sep))
                {
                    i += length;
                    if (i > (source.Length - 1))
                    {
                        break;
                    }
                }
                if (i > (source.Length - 1))
                {
                    break;
                }
                i -= 1;
                if (i >= 0)
                {
                    if (((i + length) == (source.Length - 1)) && (source.Substring(i, length) != sep))
                    {
                        while (i < source.Length - 1)
                        {
                            temp = temp + source[i + 1];
                            i++;
                        }
                    }
                    arrayListTarget.Add(temp);
                }
                else
                {
                    i += length;
                }
                temp = null;
            }
            if (temp != null)
            {
                arrayListTarget.Add(temp);
            }
            string[] target = new string[arrayListTarget.Count - 1];
            for (int i = 0; i < arrayListTarget.Count; i++)
            {
                target[i] = arrayListTarget[i] as string;
            }
            return target;
        }
    }

    public static bool IsNull(object o)
    {
        if (o == null)
        {
            return true;
        }
        else
        {
            return o.GetType().Equals(typeof(DBNull));
        }
    }

    public static string MySql(string s)
    {
        if (s == null)
        {
            return null;
        }

        // SQL Encoding for MySql Recommended here:
        // http://au.php.net/manual/en/function.mysql-real-escape-string.php
        // it scapes \r, \n, \x00, \x1a, backslash, single quotes, and double quotes

        return Regex.Replace(s, @"[\r\n\x00\x1a\'""]", @"\$0");
    }

    public static string getString(object o)
    {
        if (!IsNull(o))
        {
            return o.ToString();
        }
        else
        {
            return string.Empty;
        }
    }

    public static int getInt(object o)
    {
        if (!IsNull(o))
        {
            return int.Parse(o.ToString());
        }
        else
        {
            return -1;
        }
    }

    public static DateTime getDate(object o)
    {
        if (!IsNull(o))
        {
            return DateTime.Parse(o.ToString());
        }
        else
        {
            return DateTime.MinValue;
        }
    }

    public static string getDateAsString(object o)
    {
        if (!IsNull(o))
        {
            return DateTime.Parse(o.ToString()).ToString("d");
        }
        else
        {
            return string.Empty;
        }
    }

    public static string getDateTimeAsString(object o)
    {
        if (!IsNull(o))
        {
            return DateTime.Parse(o.ToString()).ToString("dd/MM/yyyy HH:mm:ss.f");
        }
        else
        {
            return string.Empty;
        }
    }

    public static double getDouble(object o)
    {
        if (!IsNull(o))
        {
            return double.Parse(o.ToString());
        }
        else
        {
            return -1.0;
        }
    }

    public static string getDoubleAsString(object o)
    {
        if (!IsNull(o))
        {
            return double.Parse(o.ToString()).ToString("0.##");
        }
        else
        {
            return null;
        }
    }

    // funcion que formatea un double
    public static string formatd(object o)
    {
        string ret = string.Empty;

        if (o.GetType().Equals(typeof(DBNull)) == false)
        {
            string cad = o.ToString();
            try
            {
                if (cad == null)
                {
                    ret = string.Empty;
                }
                else
                {
                    cad = double.Parse(cad).ToString("0.##");
                    if (cad.Length < 1)
                    {
                        return "0,00";
                    }
                    else
                    {
                        int i = cad.Length - 1;
                        while ((i >= 0) && (char.IsDigit(cad, i)))
                        {
                            i -= 1;
                        }
                        if ((i >= 0) && (cad[i].ToString() != ","))
                        {
                            return "0,00";
                        }
                        if (i >= 0)
                        {
                            int pcoma = i;
                            int pprimd = i + 1 < cad.Length ? i + 1 : -1;
                            int psegd = i + 2 < cad.Length ? i + 2 : -1;

                            string s = string.Empty;
                            string r = string.Empty;
                            int ceros = 0;

                            if ((pprimd != -1) && char.IsDigit(cad, pprimd))
                            {
                                s += cad[pprimd];

                                if ((psegd != -1) && char.IsDigit(cad, psegd))
                                {
                                    s += cad[psegd];
                                }
                                else
                                {
                                    s += "0";
                                }

                                s = "," + s;
                                i--;

                                while ((i >= 0) && char.IsDigit(cad, i))
                                {
                                    if ((((pcoma - i + 2) % 3) == 0) && (pcoma != (i + 1)))
                                    {
                                        s = "." + s;
                                    }
                                    s = cad[i] + s;
                                    i--;
                                }

                                i = 0;
                                while ((i < s.Length) && (s[i].ToString() == "0" || s[i].ToString() == "."))
                                {
                                    i++;
                                }
                                ceros = i;
                                r = string.Empty;
                                i = 0;
                                while ((i + ceros) < s.Length)
                                {
                                    r += s[ceros + i];
                                    i++;
                                }
                                ret = r;
                            }
                            else
                            {
                                s = ",00";
                                i = cad.Length - 2;
                                pcoma = cad.Length - 1;
                                while ((i >= 0) && char.IsDigit(cad, i))
                                {
                                    if ((((pcoma - i + 2) % 3) == 0) && (pcoma != (i + 1)))
                                    {
                                        s = "." + s;
                                    }
                                    s = cad[i] + s;
                                    i--;
                                }
                                i = 0;
                                while ((i < s.Length) && ((s[i].ToString() == "0") || (s[i].ToString() == ".")))
                                {
                                    i++;
                                }
                                ceros = i;
                                r = string.Empty;
                                i = 0;
                                while ((i + ceros) < s.Length)
                                {
                                    r += s[ceros + i];
                                    i++;
                                }
                                ret = r;
                            }
                        }
                        else
                        {
                            string s = ",00";

                            i = cad.Length - 1;
                            int pcoma = cad.Length;
                            while ((i >= 0) && (char.IsDigit(cad, i)))
                            {
                                if ((((pcoma - i + 2) % 3) == 0) && (pcoma != (i + 1)))
                                {
                                    s = "." + s;
                                }
                                s = cad[i] + s;
                                i--;
                            }

                            i = 0;
                            while ((i < s.Length) && ((s[i].ToString() == "0") || (s[i].ToString() == ".")))
                            {
                                i += 1;
                            }
                            int ceros = i;
                            string r = string.Empty;
                            i = 0;
                            while ((i + ceros) < s.Length)
                            {
                                r += s[ceros + i];
                                i++;
                            }
                            ret = r;
                        }
                    }
                }

            }
            catch
            {
                throw;
            }
            if (ret.StartsWith(",") && (ret.Length > 1))
            {
                ret = "0" + ret;
            }
        }
        return ret;
    }

    // funcion que formatea un double para insertar en la base de datos
    public static string formatb(object o)
    {
        string ret = string.Empty;

        if (!IsNull(o))
        {
            string s = o.ToString();
            try
            {
                if (s == null)
                {
                    ret = string.Empty;
                }
                else
                {
                    ret = double.Parse(s).ToString("0.##");
                }
            }
            catch
            {
                throw;
            }
        }
        return ret.Replace(",", ".");
    }

    // formatea una fecha
    public static string formatdate(object o)
    {
        if (!IsNull(o))
        {
            string[] sp = string.Format("{0:u}", DateTime.Parse(o as string)).Split(' ');
            if (sp.Length > 0)
            {
                string[] d = sp[0].Split('-');
                string rt = string.Empty;
                if (d.Length > 2)
                {
                    rt = d[2] + "/" + d[1] + "/" + d[0];
                }
                return rt;
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }

    public static string formatdateMySql(object o)
    {
        if (!IsNull(o))
        {
            Nullable<DateTime> d = o as Nullable<DateTime>;
            if (d != null)
            {
                string sd = string.Format("{0:u}", d);
                if (sd != null)
                {
                    string[] sp = sd.Split(' ');
                    if (sp.Count() > 0)
                    {
                        return sp[0];
                    }
                }
            }
        }
        return null;
    }

    // formatea una fecha con la hora
    public static string formatdatetime(object o)
    {
        if (!IsNull(o))
        {
            return string.Format("{0:u}", DateTime.Parse(o as string));
        }
        else
        {
            return null;
        }
    }

    public static string formatname(string name)
    {
        if (name != null)
        {
            name = name.Trim();
            if (name != string.Empty)
            {
                name = name.ToLower();
                string[] splitname = name.Split();
                int count = 0;
                for (int i = 0; i < splitname.Length; i++)
                {
                    if (splitname[i].Length > 0)
                    {
                        count++;
                    }
                }
                List<string> listname = new List<string>();
                int k = 0;
                for (int i = 0; i < splitname.Length; i++)
                {
                    if (k > count)
                    {
                        break;
                    }
                    if (splitname[i].Length > 0)
                    {
                        listname.Add(splitname[i]);
                        k = k + 1;
                    }
                }
                for (int i = 0; i < listname.Count; i++)
                {
                    if (listname[i].Contains(".") == false)
                    {
                        listname[i] = listname[i].Substring(0, 1).ToUpper() + listname[i].Substring(1, listname[i].Length - 1);
                    }
                    else
                    {
                        string[] wp = listname[i].Split('.');
                        int cwp = 0;
                        for (int j = 0; j < wp.Length; j++)
                        {
                            if (wp[j].Length > 0)
                            {
                                cwp++;
                            }
                        }
                        List<string> lwp = new List<string>();
                        int m = 0;
                        for (int j = 0; j < wp.Length; j++)
                        {
                            if (m > cwp)
                            {
                                break;
                            }
                            if (wp[j].Length > 0)
                            {
                                lwp.Add(wp[j].Substring(0, 1).ToUpper() + wp[j].Substring(1, wp[j].Length - 1) + ".");
                                m = m + 1;
                            }
                        }
                        string n = string.Empty;
                        for (int j = 0; j < lwp.Count - 1; j++)
                        {
                            n += lwp[j] + " ";
                        }
                        n += lwp[lwp.Count - 1];
                        listname[i] = n;
                    }
                }
                name = string.Empty;

                for (int i = 0; i < listname.Count - 1; i++)
                {
                    name += listname[i] + " ";
                }

                name += listname[listname.Count - 1];
                return name;
            }
        }
        return string.Empty;
    }

    public static bool IsDate(string stime)
    {
        DateTime dtime;
        return (DateTime.TryParse(stime, out dtime));
    }

    public static bool IsDouble(string sbudget)
    {
        double dbudget;
        return (double.TryParse(sbudget, out dbudget));
    }

    public static string formattext(string text)
    {
        return text.ToUpper().Replace("Á", "A").Replace("É", "E").Replace("Í", "I").Replace("Ó", "O").Replace("Ú", "U");
    }

    public static bool getBoolean(object objeto)
    {
        if (IsNull(objeto) == false)
        {
            return Convert.ToBoolean(objeto);
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Executes a shell command synchronously.
    /// </summary>
    /// <param name="command">string command</param>
    /// <returns>string, as output of the command.</returns>
    public static void ExecuteCommandSync(object command)
    {
        try
        {
            // create the ProcessStartInfo using "cmd" as the program to be run,
            // and "/c " as the parameters.
            // Incidentally, /c tells cmd that we want it to execute the command that follows,
            // and then exit.
            System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

            // The following commands are needed to redirect the standard output.
            // This means that it will be redirected to the Process.StandardOutput StreamReader.
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            // Get the output into a string
            string result = proc.StandardOutput.ReadToEnd();
            // Display the command output.
            Console.WriteLine(result);
        }
        catch
        {
            // Log the exception
        }
    }
    /// <summary>
    /// Execute the command Asynchronously.
    /// </summary>
    /// <param name="command">string command.</param>
    public static void ExecuteCommandAsync(string command)
    {
        try
        {
            //Asynchronously start the Thread to process the Execute command request.
            Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync));
            //Make the thread as background thread.
            objThread.IsBackground = true;
            //Set the Priority of the thread.
            objThread.Priority = ThreadPriority.AboveNormal;
            //Start the thread.
            objThread.Start(command);
        }
        catch
        {
            // Log the exception
        }
    }

    /// <summary>
    /// Change special characters in string to build a Windows folder.
    /// </summary>
    /// <param name="name">folder's string name.</param>
    public static string WindowsFolder(string name)
    {
        string folder = System.Text.RegularExpressions.Regex.Replace(name, @"[*?:\|<>\\/]", "_");
        if (folder[folder.Length - 1] == '.')
        {
            folder = folder.Substring(0, folder.Length - 1);
        }
        return folder;
    }

    public static string getFileName(string filename)
    {
        if (filename.Contains('\\') == true)
        {
            string newfilename = string.Empty;
            for (int i = filename.Length - 1; i >= 0; i--)
            {
                if (filename[i] == '\\')
                {
                    break;
                }
                newfilename += filename[i];
            }
            filename = string.Empty;
            for (int i = newfilename.Length - 1; i >= 0; i--)
            {
                filename += newfilename[i];
            }
        }
        return filename.Replace("'", "_").Replace("+", "_");
    }

    public static bool IsValidEmail(string strIn)
    {
        // Return true if strIn is in valid e-mail format.
        return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }

    public Escape()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
