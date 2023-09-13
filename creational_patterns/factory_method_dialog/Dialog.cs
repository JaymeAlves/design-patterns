abstract class Dialog 
{
    public abstract IButton CreateButton();
    public void render()
    {
        IButton okButton = CreateButton();
        okButton.OnClick(ClickEvent.CloseDialog);
        okButton.Render(100, 200);
    }
}