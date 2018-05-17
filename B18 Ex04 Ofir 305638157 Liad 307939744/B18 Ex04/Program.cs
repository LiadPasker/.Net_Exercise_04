namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfacesMenuTest intefacesMenuTest = new InterfacesMenuTest();
            DelegatesMenuTest delegatesMenuTest = new DelegatesMenuTest();

            intefacesMenuTest.Show();
            delegatesMenuTest.Show();
        }
    }
}
