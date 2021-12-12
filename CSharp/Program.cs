using Primeiro;
using Interface;
using Enum;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

        Pessoas pessoa1 = (Pessoas)0;
        Pessoas pessoa2 = Pessoas.Zuw;
        Pessoas pessoa3 = (Pessoas)4;

        Animal animal = new Animal();
        animal.Nome = "Pingo";
        animal.NomeDono = "Bozó";
        animal.Especie = "cachorro";

        Pessoa person = new Pessoa();

        person.Nome = "Maikel";           
        person.Idade = 38;
        person.Estado = "SP";

        Pessoa person2 = new Pessoa();

        person2.Nome = "Julia";
        person2.Estado = "RJ";
        person2.Idade = 18;

        var classe = new Classe();
        var classe2 = new Segundo.Classe();

       
        }       
            
    }    
}
              







     
   