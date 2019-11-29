using System;
using System.Collections.Generic;
using System.Linq;

namespace PiFoot
{

    //Classe Time : define o time
    public class Time{
        private string nome;
        private string cor;
        private string gritoTorcida;

        //Construtores da classe
        public Time(){}

        public Time(string nome, string cor, string gritoTorcida){
            this.nome = nome;
            this.cor = cor;
            this.gritoTorcida = gritoTorcida;
        }


        //gets and sets
        public string getNome(){
            return this.nome;
        }

        public string getCor(){
            return this.cor;
        }

        public string getGritoTorcida(){
            return this.gritoTorcida;
        }

        public void setNome(string nome){
            this.nome = nome;
        }

        public void setCor(string cor){
            this.cor = cor;
        }

        public void setGritoTorcida(string gritoTorcida){
            this.gritoTorcida = gritoTorcida;
        }

    }

    //Classe Jogo: define a partida entre dois times em uma certa rodada
    public class Jogo{

        private Time time1;
        private Time time2;

        private int gols1;
        private int gols2;

        //Construtores
        public Jogo(){}
        
        public Jogo(Time time1, Time time2){
            this.time1 = time1;
            this.time2 = time2;
        }
        public Jogo(Time time1, Time time2, int gols1, int gols2){
            this.time1 = time1;
            this.time2 = time2;
            this.gols1 = gols1;
            this.gols2 = gols2;
        }

        //Gets and sets
        public Time getTime1(){
            return this.time1;
        }

        public Time getTime2(){
            return this.time2;
        }

        public int getGols1(){
            return this.gols1;
        }

        public int getGols2(){
            return this.gols2;
        }

        public void setTime1(Time time1){
            this.time1 = time1;
        }

        public void setTime2(Time time2){
            this.time2 = time2;
        }

        public void setGols1(int gols1){
            this.gols1 = gols1;
        }
        public void setGols2(int gols2){
            this.gols2 = gols2;
        }

    }

    //Classe Rodada: contém a lista de jogos de uma rodada
    public class Rodada{
        //Propriedades
        private string nome;
        private List<Jogo> listaJogos = new List<Jogo>();

        //Define número máximo de gols por partida (para sorteio aleatório uniforme)
        private const int maxGols = 5;
        
        //Inicializa gerador de números aleatórios para todas as instâncias da classe (static)
        private static Random geradorGols = new Random();

        //Construtores
        public Rodada(){}

        public Rodada(string nome){
            this.nome = nome;
        }

        public Rodada(string nome, List<Jogo> listaJogos){
            this.nome = nome;
            this.listaJogos = listaJogos;
        }

        //Métodos para adicionar ou retirar jogos da lista
        public void addJogo(Jogo jogo){
            this.listaJogos.Add(jogo);
        }

        public void removeJogo(Jogo jogo){
            this.listaJogos.Remove(jogo);
        }

        //Gets and sets
        public string getNome(){
            return this.nome;
        }

        public void setNome(string nome){
            this.nome = nome;
        }
        public List<Jogo> getListaJogos(){
            return this.listaJogos;
        }

        public void setListaJogos(List<Jogo> listaJogos){
            this.listaJogos = listaJogos;
        }

        //Cria método para realizar os jogos (i.e., sortear os gols de cada partida)
        public void realizaJogos(){
            foreach(Jogo jogo in listaJogos){

                //Sorteia os gols da partida
                int gols1 = geradorGols.Next(0,maxGols);
                int gols2 = geradorGols.Next(0,maxGols);

                //Preenche as respectivas propriedades do jogo
                jogo.setGols1(gols1);
                jogo.setGols2(gols2);
            }

        }

    }

    //Classe Resultado: contém o resultado de um jogo, de um certo time
    public class Resultado{

        private Rodada rodada;
        private Time time;
        private Time adversario;
        private int pontos;
        private int golsFeitos;
        private int golsTomados;

        //Construtores
        public Resultado(){}

        public Resultado(Rodada rodada, Time time, Time adversario){
            this.rodada = rodada;
            this.time = time;
            this.adversario = adversario;
        }

        public Resultado(Rodada rodada, Time time, Time adversario, int pontos, int golsFeitos, int golsTomados){
            this.rodada = rodada;
            this.time = time;
            this.adversario = adversario;
            this.pontos = pontos;
            this.golsFeitos = golsFeitos;
            this.golsTomados = golsTomados;
        }

        //Gets and sets
        public Rodada getRodada(){
            return this.rodada;
        }

        public Time getTime(){
            return this.time;
        }

        public Time getAdversario(){
            return this.adversario;
        }

        public int getPontos(){
            return this.pontos;
        }

        public int getGolsFeitos(){
            return this.golsFeitos;
        }

        public int getGolsTomados(){
            return this.golsTomados;
        }


        public void setRodada(Rodada rodada){
            this.rodada = rodada;
        }

        public void setTime(Time time){
            this.time = time;
        }

        public void setAdversario(Time adversario){
            this.adversario = adversario;
        }

        public void setPontos(int pontos){
            this.pontos = pontos;
        }

        public void setGolsFeitos(int golsFeitos){
            this.golsFeitos = golsFeitos;
        }

        public void setGolsTomados(int golsTomados){
            this.golsTomados = golsTomados;
        }
    }

    public class ResultadoCampeonato{
        private Time time;
        private int pontos;
        private int golsFeitos;
        private int golsTomados;
        private int saldo;
        private int vitorias;
        private int empates;
        private int derrotas;

        //Construtores
        public ResultadoCampeonato(){}

        public ResultadoCampeonato(Time time, int pontos, int golsFeitos, int golsTomados, int saldo, int vitorias, int empates, int derrotas){
            this.time = time;
            this.pontos = pontos;
            this.golsFeitos = golsFeitos;
            this.golsTomados = golsTomados;
            this.saldo = saldo;
            this.vitorias = vitorias;
            this.empates = empates;
            this.derrotas = derrotas;
        }

        //Gets and sets
        public Time getTime(){
            return this.time;
        }

        public void setTime(Time time){
            this.time = time;
        }

        public int getPontos(){
            return this.pontos;
        }

        public void setPontos(int pontos){
            this.pontos = pontos;
        }

        public int getGolsFeitos(){
            return this.golsFeitos;
        }

        public void setGolsFeitos(int golsFeitos){
            this.golsFeitos = golsFeitos;
        }

        public int getGolsTomados(){
            return this.golsTomados;
        }

        public void setGolsTomados(int golsTomados){
            this.golsTomados = golsTomados;
        }

        public int getSaldo(){
            return this.saldo;
        }

        public void setSaldo(int saldo){
            this.saldo = saldo;
        } 

        public int getVitorias(){
            return this.vitorias;
        }

        public void setVitorias(int vitorias){
            this.vitorias = vitorias;
        }

        public int getEmpates(){
            return this.empates;
        }

        public void setEmpates(int empates){
            this.empates = empates;
        }

        public int getDerrotas(){
            return this.derrotas;
        }

        public void setDerrotas(int derrotas){
            this.derrotas = derrotas;
        }

    }

    //Cria enumeração com os atributos de ResultadoCampeonato para posterior uso na classe de comparação (veja abaixo)
    enum AtributoResultado{
        nomeTime,
        pontos,
        saldo,
        vitorias,
        empates,
        derrotas
    }


    //Cria comparador de resultados do campeonato, para ordenar a lista conforme o atributo
    class ComporadorResultadoCampeonato : IComparer<ResultadoCampeonato> { 
        private AtributoResultado atributoResultado;
        public int Compare(ResultadoCampeonato x, ResultadoCampeonato y) 
        { 
            int returnCompare = 0;

            if (x == null || y == null) 
            { 
                returnCompare = 0; 
            } 
            else{
                switch(atributoResultado){
                    case AtributoResultado.nomeTime:
                        //Ordem alfabética dos nomes dos times (ascendente)
                        returnCompare = x.getTime().getNome().CompareTo(y.getTime().getNome());
                        break;

                    case AtributoResultado.pontos:
                        //Ordem decrescente de pontos 
                        if (x.getPontos() > y.getPontos()){
                            //x precede y
                            returnCompare = -1;
                        } else if(x.getPontos() < y.getPontos()){
                            //y precede x
                            returnCompare = 1;
                        } else {
                            // x mesma posição y
                            returnCompare = 0;
                        }
                        break;

                    case AtributoResultado.saldo:
                        //Ordem decrescente de saldo 
                        if (x.getSaldo() > y.getSaldo()){
                            //x precede y
                            returnCompare = -1;
                        } else if(x.getSaldo() < y.getSaldo()){
                            //y precede x
                            returnCompare = 1;
                        } else {
                            // x mesma posição y
                            returnCompare = 0;
                        }
                        break;

                    case AtributoResultado.vitorias:
                        //Ordem decrescente de vitorias 
                        if (x.getVitorias() > y.getVitorias()){
                            //x precede y
                            returnCompare = -1;
                        } else if(x.getVitorias() < y.getVitorias()){
                            //y precede x
                            returnCompare = 1;
                        } else {
                            // x mesma posição y
                            returnCompare = 0;
                        }
                        break;


                    case AtributoResultado.empates: 
                        //Ordem crescente de empates 
                        if (x.getEmpates() > y.getEmpates()){
                            //y precede x
                            returnCompare = 1;
                        } else if(x.getEmpates() < y.getEmpates()){
                            //x precede y
                            returnCompare = -1;
                        } else {
                            // x mesma posição y
                            returnCompare = 0;
                        }
                        break;

                    case AtributoResultado.derrotas:
                        //Ordem crescente de derrotas 
                        if (x.getDerrotas() > y.getDerrotas()){
                            //y precede x
                            returnCompare = 1;
                        } else if(x.getDerrotas() < y.getDerrotas()){
                            //x precede y
                            returnCompare = -1;
                        } else {
                            // x mesma posição y
                            returnCompare = 0;
                        }
                        break;
                } 
            }
            return returnCompare;
        }

        //Construtores da classe
        public ComporadorResultadoCampeonato(){
            //Default ordem alfabético do nome do time
            this.atributoResultado = AtributoResultado.nomeTime;
        }

        public ComporadorResultadoCampeonato(AtributoResultado atributoResultado){
            this.atributoResultado = atributoResultado;
        }
    }


    class Program
    {

        /*
            Este jogo é formado pelos times A, B, C, D, onde somente o time A é inputado pelo usuário e os 
            outros estão pré cadastrados.

            O jogo consiste em 3 rodadas, de acordo com a seguinte tabela:
            -------------------------------------------
                    |    Rodada 1  Rodada 2  Rodada 3
            -------------------------------------------
            jogo 1  |    A x B     A x C     A x D
            jogo 2  |    C x D     B x D     B x C

            A cada rodada, ocorrem os jogos e calculam-se os resultados da rodada.

        */


        //Define variáveis (globais) do jogo
        static Time timeA = new Time();
        static Time timeB = new Time("Batutas", "azul", "Batuta, batuta, batuta, é uma turma muito astuta, mas não é filha da mãe...");
        static Time timeC = new Time("Canários", "amarelo", "Piu, piu, piu, veja só, preste atenção, este gol você não viu...");
        static Time timeD = new Time("Dromedários", "branco", "Oooôo oôooooôo, domedrário já fez mais um gol...");

        //Cria lista de times
        static List<Time> listaTimes = new List<Time>() {timeA, timeB, timeC, timeD};

        //Cria Jogos
        static Jogo jogoAB = new Jogo(timeA, timeB);
        static Jogo jogoAC = new Jogo(timeA, timeC);
        static Jogo jogoAD = new Jogo(timeA, timeD);
        static Jogo jogoBC = new Jogo(timeB, timeC);
        static Jogo jogoBD = new Jogo(timeB, timeD);
        static Jogo jogoCD = new Jogo(timeC, timeD);

        //Cria lista de rodadas
        static List<Rodada> listaRodadas = new List<Rodada>();

        //Cria lista de resultados dos jogos
        static List<Resultado> listaResultados = new List<Resultado>();

        //Cria lista de resultados do campeonato
        static List<ResultadoCampeonato> listaResultadosCampeonato = new List<ResultadoCampeonato>();


        //Cria método para impressão limitada de caracteres de uma string
        public static void writeLimit(string entradaString, int tamanhoColuna){
            int maxLength = (entradaString.Length < tamanhoColuna)? entradaString.Length : tamanhoColuna;
            for(int i = 0; i < maxLength; i++){
                Console.Write(entradaString[i]);
            }
            for(int i = 0; i < tamanhoColuna-maxLength; i++){
                Console.Write(" ");
            }
        }

        //Cria método para cálculo dos resultados das partidas em uma rodada
        public static void calculaResultadosRodada(Rodada rodada){

            //Extrai lista de jogos da rodada
            List<Jogo> listaJogos = rodada.getListaJogos();

            //Para cada jogo na lista de jogos da rodada, implementa cálculo dos resultados
            foreach(Jogo jogo in listaJogos){
                //Obtém (ponteiros para) times do jogo e gols feitos
                Time time1 = jogo.getTime1();
                Time time2 = jogo.getTime2();
                int gols1 = jogo.getGols1();
                int gols2 = jogo.getGols2();

                //Define variáveis auxiliares
                int pontos1;
                int pontos2;
                int golsFeitos1 = gols1;
                int golsFeitos2 = gols2;
                int golsTomados1 = gols2;
                int golsTomados2 = gols1;

                //Calcula resultados da peleja
                if (gols1 > gols2){
                    //Time 1 vencedor
                    pontos1 = 3;
                    pontos2 = 0;

                } else if(gols1 < gols2){
                    //Time 2 vencedor
                    pontos1 = 0;
                    pontos2 = 3;

                } else{
                    //Empate
                    pontos1 = 1;
                    pontos2 = 1;
                }

                //Cria instância de resultado para os times
                Resultado resultado1 = new Resultado(rodada, time1, time2, pontos1, golsFeitos1, golsTomados1);
                Resultado resultado2 = new Resultado(rodada, time2, time1, pontos2, golsFeitos2, golsTomados2);

                //Adiciona resultados na lista (global) de resultados
                listaResultados.Add(resultado1);
                listaResultados.Add(resultado2);
            }
        }

        //Cria método para impressão dos resultados da rodada
        public static void imprimeResultadosRodada(Rodada rodada){

            //Define variáveis auxiliares
            string nomeTime;
            string nomeAdversario;
            int pontos;
            int golsFeitos;
            int golsTomados;
  
            //Extrai lista de jogos da rodada
            List<Jogo> listaJogos = rodada.getListaJogos();

            //Imprime cabeçalho
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Resultados da rodada {0}", rodada.getNome());
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Time                Adversario          Pontos         Gols feitos    Gols tomados");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //Para cada time, imprime o resultado da rodada
            foreach(Time time in listaTimes){
                //Extrai nome do time
                nomeTime = time.getNome();

                //Encontra o resultado na lista de resultados correspondente ao time x jogo
                Resultado resultado = listaResultados.Find(x => (x.getTime().Equals(time)) && (x.getRodada().Equals(rodada)));

                //Extrai resultados
                nomeAdversario = resultado.getAdversario().getNome();
                pontos = resultado.getPontos();
                golsFeitos = resultado.getGolsFeitos();
                golsTomados = resultado.getGolsTomados();

                //Imprime dados
                writeLimit(nomeTime, 20);
                writeLimit(nomeAdversario, 20);
                Console.Write("{0,-15}", pontos);
                Console.Write("{0,-15}", golsFeitos);
                Console.Write("{0,-15}", golsTomados);
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }

        //Cria método para cálculo e impressão do resultado final do campeonato
        public static void imprimeResultadosCampeonato(){

            //Calcula os resultados para cada time
            foreach(Time time in listaTimes){

                //Extrai lista de resultados relativos ao time
                List<Resultado> listaResultadosTime = listaResultados.FindAll(x => x.getTime().Equals(time));

                //Contabiliza os resultados de todos os jogos do time
                int totalPontos = 0;
                int totalGolsFeitos = 0;
                int totalGolsTomados = 0;
                int saldoGols = 0;
                int vitorias = 0;
                int empates = 0;
                int derrotas = 0;
                foreach(Resultado resultado in listaResultadosTime){
                    int pontos = resultado.getPontos();
                    int golsFeitos = resultado.getGolsFeitos();
                    int golsTomados = resultado.getGolsTomados();
                    totalPontos += pontos;
                    totalGolsFeitos += golsFeitos;
                    totalGolsTomados += golsTomados;
                    switch(pontos){
                        case 3:
                            vitorias++;
                            break;
                        case 1:
                            empates++;            
                            break;
                        case 0:
                            derrotas++;
                            break;
                    }
                }

                //Calcula saldo de gols
                saldoGols = totalGolsFeitos - totalGolsTomados;

                //Cria instância de resultado do campeonato para o time
                ResultadoCampeonato resultadoCampeonato = new ResultadoCampeonato(time, totalPontos, totalGolsFeitos, totalGolsTomados, saldoGols, vitorias, empates, derrotas);

                //Adiciona o resultado do campeonato na lista correspondente
                listaResultadosCampeonato.Add(resultadoCampeonato);

            }


            //Obtém o time campeão, como o primeiro da lista ordenada por
            // 1. Maior número de pontos
            // 2. Maior saldo de gols
            // 3. Maior número de vitórias
            // 4. Menor número de empates
            // 5. Menor número de derrotas
            // 6. Ordem alfabética
            // Para obter esta lista, vamos ordenar sucessivamente a lista de resultados do campeonato, do último critério para o primeiro

            // 6. Ordem alfabética
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoNomeTime = new ComporadorResultadoCampeonato(AtributoResultado.nomeTime);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoNomeTime);

            // 5. Menor número de derrotas
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoDerrotas = new ComporadorResultadoCampeonato(AtributoResultado.derrotas);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoDerrotas);

            // 4. Menor número de empates
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoEmpates = new ComporadorResultadoCampeonato(AtributoResultado.empates);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoEmpates);

            // 3. Maior número de vitórias
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoVitorias = new ComporadorResultadoCampeonato(AtributoResultado.vitorias);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoVitorias);

            // 2. Maior saldo de gols
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoSaldo = new ComporadorResultadoCampeonato(AtributoResultado.saldo);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoSaldo);

            // 1. Maior número de pontos
            ComporadorResultadoCampeonato comparadorResultadoCampeonatoPontos = new ComporadorResultadoCampeonato(AtributoResultado.pontos);
            listaResultadosCampeonato.Sort(comparadorResultadoCampeonatoPontos);

            //Obtém o time campeão como o primeiro da lista ordenada
            Time timeCampeao = listaResultadosCampeonato[0].getTime();

            //Imprime tabela de resultados finais
            //Imprime cabeçalho
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Resultados finais do campeonato");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Pos  Time                Pontos         Gols feitos    Gols tomados   Saldo de gols  Vitorias       Empates        Derrotas");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < listaResultadosCampeonato.Count; i++){
                Console.Write("{0,-5}", i+1);
                writeLimit(listaResultadosCampeonato[i].getTime().getNome(), 20);
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getPontos());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getGolsFeitos());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getGolsTomados());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getSaldo());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getVitorias());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getEmpates());
                Console.Write("{0,-15}", listaResultadosCampeonato[i].getDerrotas());
                Console.WriteLine("");
            }
            Console.WriteLine("\n");

            //Imprime time campeão
            Console.WriteLine("O campeão é o time {0} : {1}!!!", timeCampeao.getNome(), timeCampeao.getGritoTorcida());
            Console.WriteLine("\n");

        }

        //Programa principal
        static void Main(string[] args)
        {

            //Cria rodadas
            Rodada rodada1 = new Rodada("1");
            rodada1.addJogo(jogoAB);
            rodada1.addJogo(jogoCD);

            Rodada rodada2 = new Rodada("2");
            rodada2.addJogo(jogoAC);
            rodada2.addJogo(jogoBD);

            Rodada rodada3 = new Rodada("3");
            rodada3.addJogo(jogoAD);
            rodada3.addJogo(jogoBC);

            //Adiciona rodadas na lista de rodadas
            listaRodadas.Add(rodada1);
            listaRodadas.Add(rodada2);
            listaRodadas.Add(rodada3);

            //Define variáveis auxiliares
            string nomeA;
            string corA;
            string gritoA;

            //Pede para o usuário os dados do timeA
            Console.WriteLine("===================================================================================================");
            Console.WriteLine("PiFoot - versão 0.0.2");
            Console.WriteLine("===================================================================================================");
            Console.WriteLine("Por favor, informe os seguintes dados do seu time (A):");
            Console.Write("Nome do time     > ");
            nomeA = Console.ReadLine();
            Console.Write("Cor do uniforme  > ");
            corA = Console.ReadLine();
            Console.Write("Grito da torcida > ");
            gritoA = Console.ReadLine();
            Console.WriteLine("\n");

            //Preenche dados do time A (do usuário)
            timeA.setNome(nomeA);
            timeA.setCor(corA);
            timeA.setGritoTorcida(gritoA);

            //Imprime lista de times
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Lista de times no campeonato");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Time                Cor da camisa");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            foreach(Time time in listaTimes){
                Console.Write("{0,-20}", time.getNome());
                Console.Write("{0,-15}", time.getCor());
                Console.WriteLine("");
            }
            Console.WriteLine("\n \n");

            //Para cada rodada na lista de rodadas
            // - Realiza jogos
            // - Imprime resultados
            foreach(Rodada rodada in listaRodadas){
                //Interrompe procedimento para pedir entrada pelo usuário
                Console.Write("Digite enter para a {0}a. rodada > ", rodada.getNome());
                Console.ReadLine();

                //Realiza jogos
                rodada.realizaJogos();

                //Calcula resultados da rodada
                calculaResultadosRodada(rodada);

                //Imprime resultados
                imprimeResultadosRodada(rodada);
            }

            //Imprime resultados do campeonato e identifica campeão
            Console.WriteLine("");
            Console.Write("Digite enter para os resultados do campeonato > ");
            Console.ReadLine();
            imprimeResultadosCampeonato();

        }
    }
}
