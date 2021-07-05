using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Demo
{
    public partial class DetailedInfo : Form
    {
        string detailed_content;
        public DetailedInfo(string _detailed_content)
        {
            InitializeComponent();
            detailedContent_richTextBox.Text = _detailed_content;
        }

        
    }
}


