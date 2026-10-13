namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        private readonly IMenuAction r_Action;

        public ActionMenuItem(string i_Title, IMenuAction i_Action)
            : base(i_Title)
        {
            if (i_Action == null)
            {
                throw new System.ArgumentNullException("i_Action");
            }
            r_Action = i_Action;
        }

        public override void Execute()
        {
            ConsoleMenuRenderer.ClearScreen();
            r_Action.Execute();
        }
    }
}
