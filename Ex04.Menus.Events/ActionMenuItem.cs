using System;

namespace Ex04.Menus.Events
{
    public class ActionMenuItem : MenuItem
    {
        public event Action Selected;

        public ActionMenuItem(string i_Title)
            : base(i_Title)
        {
        }

        public override void Execute()
        {
            ConsoleMenuRenderer.ClearScreen();
            OnSelected();
        }

        protected virtual void OnSelected()
        {
            if (Selected != null)
            {
                Selected.Invoke();
            }
        }
    }
}
