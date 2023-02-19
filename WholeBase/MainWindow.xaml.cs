using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;


namespace WholeBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IsDarkTheme { get; set; }
        public static System.Windows.Media.Color ControlLightColor { get; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void ThemToogle_Click(object sender, RoutedEventArgs e)
        {


            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
                LabelName.Foreground = Brushes.Black;
                LabelName1.Foreground = Brushes.Black;
                LabelName2.Foreground = Brushes.Black;
                LabelName3.Foreground = Brushes.Black;
                LabelName4.Foreground = Brushes.Black;

            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
                LabelName.Foreground = Brushes.White;
                LabelName1.Foreground = Brushes.White;
                LabelName2.Foreground = Brushes.White;
                LabelName3.Foreground = Brushes.White;
                LabelName4.Foreground = Brushes.White;


            }
            paletteHelper.SetTheme(theme);
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

       

            private void Auth_Click(object sender, RoutedEventArgs e)
            {


                string name = TxtUsername.Text;
                string password = txtPassword.Password;

                if (name.Length < 4)
                {
                    TxtUsername.ToolTip = "Мінімум 4 символи";
                    TxtUsername.Background = Brushes.IndianRed;
                }
                else if (password.Length < 6)
                {
                    txtPassword.ToolTip = "Мінімум 6 символів";
                    txtPassword.Background = Brushes.IndianRed;
                }
                else
                {
                    TxtUsername.ToolTip = "";
                    TxtUsername.Background = Brushes.Transparent;

                    txtPassword.ToolTip = "";
                    txtPassword.Background = Brushes.Transparent;



                User? AuthUser = null;
                using (AppContext db = new AppContext())
                {
                    AuthUser = db.Users.Where(b => b.Name == name && b.Password == password).FirstOrDefault();
                }
                if (AuthUser != null)
                    {

                        Main main = new Main();
                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Введено не коректно дані");
                    }
                }
            }
        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Hide();

        }

    }
   
}
