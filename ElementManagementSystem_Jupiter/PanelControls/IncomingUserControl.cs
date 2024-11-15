using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementManagementSystem_Jupiter.PanelControls
{
    public partial class IncomingUserControl : UserControl
    {
        public IncomingUserControl()
        {
            InitializeComponent();
            MainDataGridView.Columns.Add("State", "상태");
            MainDataGridView.Columns.Add("NIN", "품번");
            MainDataGridView.Columns.Add("Name", "품명");
            MainDataGridView.Columns.Add("Count", "개수");
            MainDataGridView.Columns.Add("Date", "날짜");
            MainDataGridView.Columns.Add("Location", "위치");
            MainDataGridView.Columns.Add("User", "작성자");

            MainDataGridView.Columns["State"].Visible = false;
        }
    }
}
