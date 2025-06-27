namespace StokExtreWFDX
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            documentViewer1.DocumentSource = new ReportFactory().CreateReport();


        }


    }
}
