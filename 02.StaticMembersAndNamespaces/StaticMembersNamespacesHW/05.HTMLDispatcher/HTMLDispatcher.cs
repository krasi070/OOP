using System;

static class HTMLDispatcher
{
    public static string CreateImage(string imageSource, string alt, string title)
    {
        ElementBuilder eb = new ElementBuilder("img");
        eb.AddAttribute("src", imageSource);
        eb.AddAttribute("alt", alt);
        eb.AddAttribute("title", title);
        return eb.Element;
    }

    public static string CreateURL(string url, string title, string text)
    {
        ElementBuilder eb = new ElementBuilder("a");
        eb.AddAttribute("href", url);
        eb.AddAttribute("title", title);
        eb.AddContent(text);
        return eb.Element;
    }

    public static string CreateInput(string inputType, string name, string value)
    {
        ElementBuilder eb = new ElementBuilder("input");
        eb.AddAttribute("type", inputType);
        eb.AddAttribute("name", name);
        eb.AddAttribute("value", value);
        return eb.Element;
    }
}

