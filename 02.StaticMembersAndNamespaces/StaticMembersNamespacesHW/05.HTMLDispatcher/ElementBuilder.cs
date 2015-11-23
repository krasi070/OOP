using System;

class ElementBuilder
{
    public ElementBuilder(string element)
    {
        this.Element = string.Format("<{0}></{0}>", element);
    }

    public string Element { get; set; }

    public void AddAttribute(string attribute, string value)
    {
        int index = this.Element.IndexOf('>');
        this.Element = this.Element.Insert(index, string.Format(" {0}=\"{1}\"", attribute, value));
    }

    public void AddContent(string content)
    {
        int index = this.Element.IndexOf('>') + 1;
        this.Element = this.Element.Insert(index, content);
    }

    public static string operator *(ElementBuilder e, int n)
    {
        string currElement = e.Element + "";
        for (int i = 1; i < n; i++)
        {
            e.Element += currElement;
        }
        return e.Element;
    }
}

