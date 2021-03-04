using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practise_WFA_LogInSystem.Entities.BaseEntity;

namespace Practise_WFA_LogInSystem.Entities.Concrete
{
    public class DetailInfo : BasicInfo 
    {
        private Guid _id = Guid.NewGuid();

        public Guid Id
        {
            get
            {
                return _id;
            }
        }
        

        public DateTime BirthDate
        {
            get;
            set;
        }

        private DateTime _createTime = DateTime.Now;
        public DateTime CreateDate
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 19)
                {
                    MessageBox.Show("Membership registration is not allowed for those under 18.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private string _email;

        public string Email
        {
            get;
            set;
        }

        private string _phone;

        public string Phone
        {
            get;
            set;
        }
    }
}
