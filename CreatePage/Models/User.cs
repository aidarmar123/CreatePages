using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace CreatePage.Models
{
    public class User
    {
        public User(int Id, string Name, string Email, string Password, bool isAdmin, BitmapImage image)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.IsAdmin = isAdmin;
            this.Sook = Email;
            this.Image = image;

        }
        [VerstkaIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
      
        private string Sook {get;set;}
        public ImageSource Image { get; set; }

    }
}
