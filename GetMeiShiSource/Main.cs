namespace GetMeiShiSource
{
    public partial class Main : Form
    {
        public bool AllConfig = true;

        public Main()
        {
            InitializeComponent();
            DownloadConfig_Click(null,null);    // 不显示详细配置
        }

        /// <summary>
        /// 展开详细配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadConfig_Click(object sender, EventArgs e) => this.Height = (AllConfig = !AllConfig) ? 378 : 178;
    }
}