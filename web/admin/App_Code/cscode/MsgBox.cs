using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Web.UI;
using System.Web;
using System.Text;


namespace System.Web.UI
{
    public class MsgBox
    {


        private static Hashtable m_executingPages = new Hashtable();

        private MsgBox()
        {
        }

        public static void Show(string msg)
        {
            //si esta es la primera vez que la pagina llama a este metodo
            if ((m_executingPages.Contains(HttpContext.Current.Handler) == false))
            {
                //intenta convertir el httphandler a page
                Page executingPage = (Page)HttpContext.Current.Handler;
                if ((executingPage != null))
                {
                    // crea una cola para manejar uno o más mensajes
                    Queue msgQueue = new Queue();

                    //añade el mensaje a la cola
                    msgQueue.Enqueue(msg);

                    //añade nuestra cola de mensajes a la tabla hash. usa la referencia de la pagina
                    //(IHttpHandler) como clave
                    m_executingPages.Add(HttpContext.Current.Handler, msgQueue);

                    //activa el evento unload para que podamos incluir codigo JavaScript para las alertas
                    executingPage.Unload += ExecutingPage_Unload;
                }
            }
            else
            {
                //si hemos llegado aqui el metodo ya ha sido llamado desde la pagina
                //ya hemos creado la cola de mensajes y grabado en la tabla hash
                Queue queue = (Queue)m_executingPages[HttpContext.Current.Handler];

                //añade el mensaje a la cola
                queue.Enqueue(msg);
            }
        }

        public static void Confirm(string msg, string hidden, string form)
        {
            //si esta es la primera vez que la pagina llama a este metodo
            if ((m_executingPages.Contains(HttpContext.Current.Handler) == false))
            {
                //intenta convertir el httphandler a page
                Page executingPageConfirmation = (Page)HttpContext.Current.Handler;
                List<string> trio = new List<string>();
                trio.Add(msg);
                trio.Add(hidden);
                trio.Add(form);

                if ((executingPageConfirmation != null))
                {
                    //crea una cola para manejar uno o más mensajes
                    Queue msgQueue = new Queue();

                    //añade el mensaje a la cola
                    msgQueue.Enqueue(trio);

                    //añade la cola de mensajes a la tabla hash. utiliza la referencia a la pagina
                    //(IHttpHandler) como clave
                    m_executingPages.Add(HttpContext.Current.Handler, msgQueue);

                    //activa el evento de unload para que podamos incluir codigo javascript para las alertas
                    executingPageConfirmation.Unload += ExecutingPageConfirmation_Unload;
                }
            }
            else
            {
                //si hemos llegado aqui el metodo ya ha sido llamado por la pagina
                //ya hemos creado la cola de mensajes y guardado en la tabla hash
                List<string> trio = new List<string>();
                trio.Add(msg);
                trio.Add(hidden);
                trio.Add(form);

                Queue queue = (Queue)m_executingPages[HttpContext.Current.Handler];

                //añade el mensaje a la cola
                queue.Enqueue(trio);
            }
        }

        //nuestra pagina ha terminado de ejecutarse asi que vamos a incluir el codigo javascript para reproducir las alertas
        private static void ExecutingPage_Unload(object sender, EventArgs e)
        {
            //obtiene la cola de mensajes de la tabla hash
            Queue queue = (Queue)m_executingPages[HttpContext.Current.Handler];
            if ((queue != null))
            {
                StringBuilder sb = new StringBuilder();

                //cuantos mensajes se han registrado?
                int count = queue.Count;

                //utiliza el stringbuilder para construir nuestro codigo javascript
                sb.Append("<script language='javascript'>");

                //recorre los mensajes registrados
                string msg = string.Empty;
                while ((count > 0))
                {
                    count = count - 1;
                    msg = Convert.ToString(queue.Dequeue());
                    msg = msg.Replace("\"", "'");
                    sb.Append("alert(\"" + msg + "\")");
                }

                //cierra el javascript
                sb.Append("</script>");

                //hemos terminado, por tanto quitamos la referencia de la tabla hash
                m_executingPages.Remove(HttpContext.Current.Handler);

                //escribe el javascirpt al final del response stream
                HttpContext.Current.Response.Write(sb.ToString());
            }
        }
        //nuestra pagina ha terminado de ejecutarse asi que vamos a incluir el codigo javascript para reproducir las alertas
        private static void ExecutingPageConfirmation_Unload(object sender, EventArgs e)
        {
            //obtiene la cola de mensajes de la tabla hash
            Queue queue = (Queue)m_executingPages[HttpContext.Current.Handler];
            if ((queue != null))
            {
                StringBuilder sb = new StringBuilder();

                //cuantos mensajes se han registrado?
                int count = queue.Count;

                //obtiene la confirmacion registrada
                List<string> trio = new List<string>();
                string msg = string.Empty;
                string hidden = string.Empty;
                string form = string.Empty;

                if ((count >= 1))
                {
                    trio = (List<string>)queue.Dequeue();
                    msg = trio[0];
                    msg = msg.Replace("\"", "'");
                    hidden = trio[1];
                    hidden = hidden.Replace("\"", "'");
                    form = trio[2];
                    form = form.Replace("\"", "'");
                }
                //utiliza el stringbuilder para construir nuestro codigo javascript
                sb.Append("<script language='javascript'>");

                sb.Append(" if (confirm(\"" + msg + "\")) ");
                sb.Append(" { ");
                sb.Append(" var f1 = document.forms['" + form + "']; ");
                sb.Append(" var e1 = f1.elements['" + hidden + "'] ");
                sb.Append(" document.forms['" + form + "'].elements['" + hidden + "'].value='1';" + "document.forms['" + form + "'].submit(); }");
                sb.Append(" else { ");
                sb.Append(" document.forms['" + form + "'].elements['" + hidden + "'].value='0';" + "document.forms['" + form + "'].submit(); }");

                //cierra el javascript
                sb.Append("</script>");

                //hemos terminado, por tanto quitamos la referencia de la tabla hash
                m_executingPages.Remove(HttpContext.Current.Handler);

                //escribe el javascirpt al final del response stream
                HttpContext.Current.Response.Write(sb.ToString());
            }
        }
    }
}