using static System.Console;
using static System.Convert;

public class Veiculos
{
    public string _idVeiculos;
    private string _niv;
    public string _nplaca;
    public string _nmotor;
    public string _renavam;
    public string _anomodelo;
    public string _situacao;
    public string _cor;
    public Pessoas _pessoas;
    public Modelos _modelos;
    public Cidades _cidades;

    public void SetNivVerific(string niv)
    {
        if (niv.Length == 17)
        {
            _niv = niv;
        }
        else
        {
            throw new Exception("NIV inválido");
        }
    }

    public string GetNivVerific()
    { 
        return _niv;
    }
}