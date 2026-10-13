namespace Ex04.Menus.Test
{
    internal class Program
    {
        static void Main()
        {
            InterfacesMenuBuilder interfacesMenuBuilder = new InterfacesMenuBuilder();
            EventsMenuBuilder eventsMenuBuilder = new EventsMenuBuilder();

            interfacesMenuBuilder.BuildMenu().Show();
            eventsMenuBuilder.BuildMenu().Show();
        }
    }
}
