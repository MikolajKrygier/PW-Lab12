using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW_Lab_12
{
    public partial class Form2 : Form
    {
        public static Form2 form2Instance;
        public Form2()
        {
            InitializeComponent();
            form2Instance = this;
        }
    }
}
