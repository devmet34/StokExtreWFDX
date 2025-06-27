using System;


namespace StokExtreWFDX
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            documentViewer1.DocumentSource = new ReportFactory().CreateReport();



            //report.ShowPreview();

        }


        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
