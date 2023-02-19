using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WholeBase
{
    /// <summary>
    /// Логика взаимодействия для SerchPlace.xaml
    /// </summary>
    public partial class SerchPlace : Page
    {
        public SerchPlace()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Очищуємо список товарів перед пошуком
            ProductsList.Items.Clear();

            // Отримуємо текст для пошуку
            string searchText = SearchBox.Text;

            // Перебираємо всі товари в базі даних та додаємо ті, що відповідають пошуковому запиту, в список
           // foreach (var product in database.Products)
            //{
              //  if (product.Name.Contains(searchText))
               // {
                  //  ProductsList.Items.Add(product);
               // }
          //  }
        }
    }
}
