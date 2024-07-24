public class Pessoa 
{ 
   string Nome;
   string Sobrenome;
   string CPF;
   string Telefone;
 
public void SetNome (string Nome)
{
   this.Nome = Nome;
}
public string GetNome ()
{ 
    return Nome;
}
public void SetSobrenome (string Sobrenome)
{ 
    this.Sobrenome = Sobrenome;  
}
public string GetSobrenome()
{ 
    return Sobrenome;
}
public void SetCPF (string CPF)
{ 
    this.CPF = CPF;
}
public string GetCPF()
{ 
    return CPF;
}
public void SetTelefone(string Telefone)
{ 
    this.Telefone = Telefone;
}
public string GetTelefone()
{ 
    return Telefone;
}
}