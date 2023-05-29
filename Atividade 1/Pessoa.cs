public class Pessoa
{
    private string nome;
    private string cpf;
    private string idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, string idade, string sexo, double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
    }   

    public (double, string, string) CalcularIMC()
    {
        double imc = peso / (altura * altura);

        if(imc < 18.5)
        {
            return (imc, "MAGREZA", "Grau 0");
        }

        if (imc >= 18.5 && imc <= 24.9)
        {
            return (imc, "NORMAL", "Grau 0");
        }

        else if (imc >= 25.0 && imc <= 29.9)
        {
            return (imc, "SOBREPESO", "Grau I");
        }

        else if (imc >= 30.0 && imc <= 39.9)
        {
            return (imc, "OBESIDADE", "Grau II");
        }

        else
        {
            return (imc, "OBESIDADE GRAVE", "Grau III");
        }

        
    }

    public string GetNome()
    {
        return this.nome;

    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetCpf()
    {
        return this.cpf;
    }

    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }

    public string GetIdade()
    {
        return this.idade;
    }

    public void SetIdade(string idade)
    {
        this.idade = idade;
    }

    public string GetSexo()
    {
        return this.sexo;
    }

    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }

    public double GetPeso()
    {
        return this.peso;
    }

    public void SetPeso(double peso)
    {
        this.peso = peso;
    }

    public double GetAltura()
    {
        return this.altura;
    }

    public void SetAltura(double altura)
    {
        this.altura = altura;
    }

}
