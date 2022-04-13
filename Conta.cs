public class Conta 
{
    public int Codigo { get; }
    public double Saldo { get; private set; }  

    public Conta(int codigo) 
    {
        Codigo = codigo; 
        Saldo = 0.0; 
    } 

    public void Sacar(double valor) 
    {
        VerificarValor(valor);
      
        Saldo = Saldo - valor; 
    }  
    public void Depositar(double valor) 
    {
        VerificarDeposito(valor);
        Saldo = Saldo + valor; 
    } 

    public void Transferir(double valor, Conta conta)      
    {
        VerificarValor(valor);

        conta.Saldo= conta.Saldo + valor;
        Saldo = Saldo - valor;

    } 
    private void VerificarValor(double valor)
    {
        if(valor <= 0.0 || valor > Saldo)
        {
            throw new ArgumentException ("Transferencia invalida");
        }
    } 

    private void VerificarDeposito(double valor)
    {
        if(valor <= 0.0)
        {
            throw new ArgumentException ("Impossibilitado de realizar o deposito");
        }
    }
    
}

    
