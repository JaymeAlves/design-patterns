class HTMLButton : IButton
{
    public void OnClick(ClickEvent e)
    {
        Console.WriteLine("Web event click: " + e.ToString());
    }

    public void Render(int x, int y)
    {
        Console.WriteLine("<button heighy=" + x + "px width=" + y +"px>HTLMButton</button>");
    }
}