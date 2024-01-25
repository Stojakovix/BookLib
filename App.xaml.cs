using BookLib.Data;

namespace BookLib
{
    public partial class App : Application
    {
        public static Conn Conn { get; private set; }
        public App(Conn _conn)
        {
            InitializeComponent();

            MainPage = new AppShell();
            Conn = _conn;
        }
    }
}
