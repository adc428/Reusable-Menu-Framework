namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        private readonly string r_Title;

        protected MenuItem(string i_Title)
        {
            if (string.IsNullOrWhiteSpace(i_Title))
            {
                throw new System.ArgumentException("Menu item title cannot be empty.", "i_Title");
            }
            r_Title = i_Title;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public abstract void Execute();
    }
}
