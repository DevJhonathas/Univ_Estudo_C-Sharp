using System;

class Pessoa
{
    // Atributo nome
    private string nome;

    // Get e Set - get pega e set envia
    public string Nome //Se poe o mesmo nome do atributo mas com letra inicial maiuscula
    {
        get{
            return nome;
        }
        set{
            nome=value;
            }
    }

}