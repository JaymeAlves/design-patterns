class WindowsButton : IButton
{
    public void Render(int x, int y)
    {
        Console.WriteLine("windows button rendered " + x + " " + y);
    }

    void IButton.OnClick(ClickEvent e)
    {
        Console.WriteLine("Windows event click: " + e.ToString());
    }
}