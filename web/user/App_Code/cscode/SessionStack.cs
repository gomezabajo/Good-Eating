using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SessionStack
/// </summary>
public class SessionStack : System.Web.UI.Page
{
    private System.Collections.Stack _st = null;

    public System.Collections.Stack this[string key]
    {
        get
        {
            if (Session[key] != null)
            {
                return Session[key] as System.Collections.Stack;
            }
            else
            {
                return null;
            }
        }
        set
        {
            _st = value;
            Session[key] = _st;
        }
    }

    public void Build(string key)
    {
        this[key] = new System.Collections.Stack();
    }

    public void Save(string key, System.Collections.Stack s)
    {
        this[key] = s;
    }

    public void Delete(string key)
    {
        _st = null;
        Session.Remove(key);
    }

    public void Push(string key, object value)
    {
        if (this[key] != null)
        {
            _st.Push(value);
            Save(key, _st);
        }
    }

    public object Pop(string key)
    {
        if (this[key] != null)
        {
            if (this[key].Count > 0)
            {
                object o = _st.Pop();
                Save(key, _st);
                return o;
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

    public int Count(string key)
    {
        if (this[key] != null)
        {
            return this[key].Count;
        }
        else
        {
            return 0;
        }
    }

    public object Peek(string key)
    {
        if (this[key] != null)
        {
            if (this[key].Count > 0)
            {
                return this[key].Peek();

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

    public object[] ToArray(string key)
    {
        if (this[key] != null)
        {
            return this[key].ToArray();
        }
        else
        {
            return null;
        }
    }

    public SessionStack()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
