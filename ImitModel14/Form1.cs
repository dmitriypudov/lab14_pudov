using System.Windows.Forms;

namespace SimulationModel14
{
    public partial class MainForm : Form
    {
        private  Model _model;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            StartModel();
        }

        private void StartModel()
        {
            var attendantQuantity = (int)OperatorsNumber.Value;
            var flowLambda = (double)FlowLambda.Value;
            var attendantLambda = (double)OperatorLambda.Value;
            var totalTime = (double)TotalTime.Value;

            _model = new Model(totalTime, attendantQuantity, attendantLambda, flowLambda);
            _model.SimulateModel();
            TotalClients.Text = _model.Stream.TotalClients.ToString();
        }
    }
}
