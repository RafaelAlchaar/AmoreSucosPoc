namespace AmoreSucos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque frm = new FrmEstoque();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void BtnAddLaranja_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void BtnAddMorango_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void BtnAddAbacaxi_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void btnAddLimao_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void BtnAddAcerola_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void BtnAddManga_Click(object sender, EventArgs e)
        {
            FrmAdicionarEstoqueSuco frm = new FrmAdicionarEstoqueSuco();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frm = new FrmCadastroUsuario();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frm = new FrmCadastrarProduto();
            frm.Show();
        }
    }
}
