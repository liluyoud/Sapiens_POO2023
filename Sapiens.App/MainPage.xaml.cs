using Sapiens.Shared.Entities;

namespace Sapiens.App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private Aluno aluno = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            aluno.Nome = "Liluyoud Cury de Lacerda";
            count++;

            if (count == 1)
                CounterBtn.Text = $"{aluno.Nome} clicado primeira {count} vez";
            else
                CounterBtn.Text = $"{aluno.Nome} clicado {count} vezes";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}