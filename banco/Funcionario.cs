public abstract class Funcionario : PessoaFisica
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    protected double _bonificacao;

    public virtual double Bonificacao 
    {   
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += Salario * 0.01;
        }
    }

    public abstract int CalcularFerias(); 

    public double RemuneracaoTotal(double salario)
    {
        return salario * 13;
    }

    public double RemuneracaoTotal(double salario, double bonificacao)
    {
        return salario * 13 + bonificacao; 
    }
}