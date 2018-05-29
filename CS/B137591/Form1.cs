using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B137591 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData() {
            for (int i = 0; i < 10; i++)
                dataTable1.Rows.Add(null, null, null, null);
        }
    }
}