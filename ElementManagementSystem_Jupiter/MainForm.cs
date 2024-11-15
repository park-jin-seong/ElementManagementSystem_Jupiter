using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElementManagementSystem_Jupiter.PanelControls;

namespace ElementManagementSystem_Jupiter
{
    public partial class MainForm : Form
    {
        //private MainUserControl m_MainUserControl;
        //private IncomingUserControl m_IncomingUserControl;
        public MainForm()
        {
            InitializeComponent();

            MainDataGridView.Columns.Add("State", "상태");
            MainDataGridView.Columns.Add("NIN", "품번");
            MainDataGridView.Columns.Add("Name", "품명");
            MainDataGridView.Columns.Add("Count", "개수");
            MainDataGridView.Columns.Add("Date", "날짜");
            MainDataGridView.Columns.Add("Location", "위치");
            MainDataGridView.Columns.Add("User", "작성자");

            GetCSVFile();
        }

        private void GetCSVFile()
        {
            for (int i = 1; i <= 10; i++)
            {
                MainDataGridView.Rows.Add("입고", (i*1111).ToString() , "전투원용무전기", "1", DateTime.Now.ToString(), "통신소대", "박진성");
            }
        }

        private void Mainbutton_Click(object sender, EventArgs e)
        {
            MainDataGridView.Columns["State"].Visible = true;
        }

        private void IncomingButton_Click(object sender, EventArgs e)
        {
            MainDataGridView.Columns["State"].Visible = false;
        }

        private void OutgoingButton_Click(object sender, EventArgs e)
        {
            MainDataGridView.Columns["State"].Visible = false;
        }

        private void RentalButton_Click(object sender, EventArgs e)
        {
            MainDataGridView.Columns["State"].Visible = false;
        }

        private void RetrunButton_Click(object sender, EventArgs e)
        {
            MainDataGridView.Columns["State"].Visible = false;
        }

        private void CSVExportButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "csv (*.csv) | *.csv";
                dlg.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.Save_Csv(dlg.FileName, MainDataGridView,true); // dataGridView에 데이터를 세팅하는 메서드를 호출                                                              
                }
            }
        }

        private void Save_Csv(string fileName, DataGridView dgv, bool header)
        {
            string delimiter = ", ";  // 구분자   
            FileStream fs = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);    
            StreamWriter csvExport = new StreamWriter(fs, System.Text.Encoding.UTF8);    
            if (dgv.Rows.Count == 0) return;    // 헤더정보 출력   
                                               
            if (header)    
            {      
                for (int i = 0; i < dgv.Columns.Count; i++)      
                {        
                    csvExport.Write(dgv.Columns[i].HeaderText);  
                    if (i != dgv.Columns.Count - 1)   
                    {             
                        csvExport.Write(delimiter);        
                    }  
                }  
            }   
            csvExport.Write(csvExport.NewLine); // add new line    // 데이터 출력
                                               
            foreach (DataGridViewRow row in dgv.Rows)   
            {    
                if (!row.IsNewRow)     
                {         
                    for (int i = 0; i < dgv.Columns.Count; i++)   
                    {          
                        csvExport.Write(row.Cells[i].Value);  
                        if (i != dgv.Columns.Count - 1)    
                        {               
                            csvExport.Write(delimiter);  
                        }         
                    }           
                    csvExport.Write(csvExport.NewLine); // write new line       
                                                       
                }    
            }        
            csvExport.Flush(); // flush from the buffers.   
                              
            csvExport.Close();  
            fs.Close(); 
            MessageBox.Show("CSV파일 저장 완료！");
        }
    }
}
