using DelegatesMainMenu = Ex04.Menus.Events.MainMenu;
using DelegatesSubMenuItem = Ex04.Menus.Events.SubMenuItem;
using DelegatesActionMenuItem = Ex04.Menus.Events.ActionMenuItem;

namespace Ex04.Menus.Test
{
    internal class EventsMenuBuilder
    {
        private readonly ShowCurrentDateAction r_ShowCurrentDateAction;
        private readonly ShowCurrentTimeAction r_ShowCurrentTimeAction;
        private readonly CountCapitalsAction r_CountCapitalsAction;
        private readonly ShowVersionAction r_ShowVersionAction;

        public EventsMenuBuilder()
        {
            r_ShowCurrentDateAction = new ShowCurrentDateAction();
            r_ShowCurrentTimeAction = new ShowCurrentTimeAction();
            r_CountCapitalsAction = new CountCapitalsAction();
            r_ShowVersionAction = new ShowVersionAction();
        }

        public DelegatesMainMenu BuildMenu()
        {
            DelegatesMainMenu mainMenu = new DelegatesMainMenu("Delegates Main Menu");
            DelegatesSubMenuItem dateTimeSubMenu = mainMenu.AddSubMenuItem("Show Current Date/Time");
            DelegatesSubMenuItem versionCapsSubMenu = mainMenu.AddSubMenuItem("Version and Capitals");
            DelegatesActionMenuItem showCurrentDate = dateTimeSubMenu.AddActionItem("Show Current Date");
            DelegatesActionMenuItem showCurrentTime = dateTimeSubMenu.AddActionItem("Show Current Time");
            DelegatesActionMenuItem countCapitals = versionCapsSubMenu.AddActionItem("Count Capitals");
            DelegatesActionMenuItem showVersion = versionCapsSubMenu.AddActionItem("Show Version");

            showCurrentDate.Selected += showCurrentDateAction_Selected;
            showCurrentTime.Selected += showCurrentTimeAction_Selected;
            countCapitals.Selected += countCapitalsAction_Selected;
            showVersion.Selected += showVersionAction_Selected;

            return mainMenu;
        }

        private void showCurrentDateAction_Selected()
        {
            r_ShowCurrentDateAction.Execute();
        }

        private void showCurrentTimeAction_Selected()
        {
            r_ShowCurrentTimeAction.Execute();
        }

        private void countCapitalsAction_Selected()
        {
            r_CountCapitalsAction.Execute();
        }

        private void showVersionAction_Selected()
        {
            r_ShowVersionAction.Execute();
        }
    }
}
