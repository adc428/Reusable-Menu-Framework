using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfacesMenuBuilder
    {
        public MainMenu BuildMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
            SubMenuItem dateTimeSubMenu = mainMenu.AddSubMenuItem("Show Current Date/Time");
            SubMenuItem versionCapsSubMenu = mainMenu.AddSubMenuItem("Version and Capitals");
            ShowCurrentDateAction showCurrentDateAction = new ShowCurrentDateAction();
            ShowCurrentTimeAction showCurrentTimeAction = new ShowCurrentTimeAction();
            CountCapitalsAction countCapitalsAction = new CountCapitalsAction();
            ShowVersionAction showVersionAction = new ShowVersionAction();

            dateTimeSubMenu.AddActionItem("Show Current Date", showCurrentDateAction);
            dateTimeSubMenu.AddActionItem("Show Current Time", showCurrentTimeAction);

            versionCapsSubMenu.AddActionItem("Count Capitals", countCapitalsAction);
            versionCapsSubMenu.AddActionItem("Show Version", showVersionAction);

            return mainMenu;
        }
    }
}
