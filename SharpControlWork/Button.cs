namespace SharpControlWork
{
    class Button
    {
        public delegate void ClickHandler();

        public event ClickHandler OnClick;

        public void Click()
        {
            if (OnClick != null) OnClick();
        }
    }
}
