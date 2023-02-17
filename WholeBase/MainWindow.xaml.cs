using System;
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
            if (IsDarkTheme =theme.GetBaseTheme() ==BaseTheme.Dark)
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

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Hide();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();

        }
    }
}
