namespace Aula11Polimorfismo
{
    public class Calculos
    {
        //Sobrecarga --> Quantidade e tipos nos argumentos
        //Precisa apenas de uma classe

        public string calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

            public string calcular(int vida){
            return "A vida do jogador está com "+vida;
        }

        public string calcular(int vida, int escudo){
            return "A vida do jogador com a capa-escudo é "+ (vida+escudo);
        }
        public string calcular(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }

            public string calcularIdade(int idade){
            return $"A idade do jogador: {idade} anos";
        }

            public string ApresentarPoder(string poder){
            return $"O Super Poder do personagem é {poder}";
        }


       






    }
}