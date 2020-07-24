using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : iJogador 
    {
        public readonly string _Nome;

        public Jogador3(string nome = "Romário"){
            _Nome = nome;
        }

        public string Chuta(){
            return $"{_Nome} está chutando \n";
        }
        
        public string Corre(){
            return $"{_Nome} está correndo \n";  
        }

        public string Passe(){
            return $"{_Nome} está passando \n";
        }
    }
}