using CreatePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.RightsManagement;
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

namespace CreatePage.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageGeneration.xaml
    /// </summary>
    public partial class PageGeneration : Page
    {
        
        public PageGeneration(Object user)
        {
            InitializeComponent();
            CreateElement(user);

        }

        private void CreateElement(object data)
        {

            var props = data.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreReturn);
            foreach (var value in props)
            {
                if (value.GetCustomAttribute<VerstkaIgnoreAttribute>() == null)
                {
                    var content = value.GetValue(data);
                    if (content == null)
                        continue;
                    if (Generator.elements.ContainsKey(content.GetType()))
                    {
                        var element = Generator.elements[value.PropertyType];
                        var vv = Activator.CreateInstance(element.GetType()) as UIElement;
                        Content.Children.Add(vv);
                    }
                    else
                    {
                        Content.Children.Add(new TextBox() { Text = content.ToString() });
                    }



                }

            }
        }


    }
}
