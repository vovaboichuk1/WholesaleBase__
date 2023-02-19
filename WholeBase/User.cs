using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Windows.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace WholeBase
{
    class User
    {

        [Key] public int id { get; set; }

        [Key]
        private string name;
        private string password;

        public string Name {
            get { 
                return name; 

            }
            set { name=value ;}  
        }
        public string Password { 
            get { 
                return password; 
            }
            set { password=value ;}
        }

        public User() { }
        

        

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        
    }
}
