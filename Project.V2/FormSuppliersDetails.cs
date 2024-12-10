using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V2
{
    public partial class FormSuppliersDetails : Form
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal Capital { get; set; }

        public FormSuppliersDetails()
        {
            InitializeComponent();
        }
    }
}
