public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }
    private double _bonificacao;
    public double Bonificacao 
    { 
        get
        {
            return _bonificacao;
        } 
        set
        {
            if(this.Cargo == "Vendedor")
            {
                _bonificacao += this.Salario*0.03;
            }
            if(this.Cargo == "Auxiliar")
            {
                _bonificacao += this.Salario*0.01;
            }
        } 
    }
}