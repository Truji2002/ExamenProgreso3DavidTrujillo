using ExamenProgreso3.Data;

namespace ExamenProgreso3;

public partial class App : Application
{
    public static ApiDatabaseDT APIRepoDT { get; private set; }

    public App(ApiDatabaseDT repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        APIRepoDT = repo;
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
