public class Estoque
{
    string NomedoProduto;
    int ID_Produto;
    string PreçodeCusto;

public void SetNomedoProduto (string NomedoProduto)
 { 
    this.NomedoProduto = NomedoProduto;
 }
 public string GetNomedoProduto ()
 {
    return NomedoProduto;
 }
 public void SetID (string ID)
 {
    this.ID =ID_Produto;
 }
 public string GetID ()
 { 
    return ID_Produto;
 }
 public void SetPreçodecusto (string Preçodecusto)
{
    this.Preçodecusto = Preçodecusto;
}
public string GetPreçodecusto ()
{
    return Preçodecusto;
}
}