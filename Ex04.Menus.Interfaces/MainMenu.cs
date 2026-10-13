namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly Menu r_RootMenu;

        public MainMenu(string i_Title)
        {
            const bool v_IsMainMenu = true;

            r_RootMenu = new Menu(i_Title, v_IsMainMenu);
        }

        public SubMenuItem AddSubMenuItem(string i_Title)
        {
            SubMenuItem subMenuItem = new SubMenuItem(i_Title);

            r_RootMenu.AddMenuItem(subMenuItem);

            return subMenuItem;
        }

        public void AddActionItem(string i_Title, IMenuAction i_Action)
        {
            ActionMenuItem actionMenuItem = new ActionMenuItem(i_Title, i_Action);

            r_RootMenu.AddMenuItem(actionMenuItem);
        }

        public void Show()
        {
            ConsoleMenuRenderer.ClearScreen();
            r_RootMenu.Show();
        }
    }
}
