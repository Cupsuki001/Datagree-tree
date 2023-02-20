namespace practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("INNS LABORAL"))
            {
                label4.Text = "Inss laboral ";
            }
            else if (treeView1.SelectedNode.Text.Equals("INNS PATRONAL"))
            {
                label4.Text = "Inss patronal ";
            }
            else if (treeView1.SelectedNode.Text.Equals("IR"))
            {
                label4.Text = "IR ";
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXBnombre.Text = "";
            MASKEDingresomensual.Text = "";
            MASKEDinssnumero.Text = "";
            label4.Text = "NINGUNO";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            double men = Convert.ToDouble(MASKEDingresomensual.Text);

            dataGridView1.Rows[n].Cells[0].Value = TXBnombre.Text;
            dataGridView1.Rows[n].Cells[1].Value = MASKEDinssnumero.Text;
            dataGridView1.Rows[n].Cells[2].Value = MASKEDingresomensual.Text;
            dataGridView1.Rows[n].Cells[3].Value = treeView1.SelectedNode.Text;

            if (treeView1.SelectedNode.Text.Equals("INNS LABORAL")) 
            {
                double tot , desc;

                desc = men * 0.07;
                tot = men - desc;

                dataGridView1.Rows[n].Cells[4].Value = tot;
            }
        }
    }
    
}