

public class PessoasFisicas:Pessoas
{
    private string _cpf;
    public string _rg;
    public string _dtNascimento;
    public string _sexo;

    public void SetVerifCpf(string cpf)
    {
        cpf = cpf.Replace("-", "").Replace(".", "");

        if (cpf.Length == 11)
        {
            _cpf = cpf;
        }
        else
        {
            throw new Exception("CPF incorreto");
        }
    }
}