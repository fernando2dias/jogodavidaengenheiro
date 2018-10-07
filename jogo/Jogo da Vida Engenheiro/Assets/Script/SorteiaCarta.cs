using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SorteiaCarta : MonoBehaviour
{

    public int valorMin = 0;
    public int valorMax = 31;
    [Space(20)]
    public int cartaSorteada;
    [Space(20)]
    public List<int> cartasJaSorteadas = new List<int>();
    public List<string> cartas = new List<string>(new string[] {
        "Você passou em Física. Avance 10 casas",//0
        "Sua matemática básica estava em dia. Avance 5 casas",//1
        "Você se destacou na TECNOFACENS. Avance 5 casas",//2
        "Você foi fazer a maratona de programação e ganhou. Avance 3 casas",//3
        "Você foi selecionado para participar do Fórmula. Avance 4 casas",//4
        "Você encontou um vale salgado na sua carteira. Avance 5 casas",//5
        "Você entendeu a matéria de Banco de Dados. Parabéns. Avance 7 casas",//6
        "Seu grupo no trabalho te ajudou. Avance 4 casas",//7
        "Você visitou a biblioteca além de sua inauguração. Avance 5 casas",//8
        "Você não frequenta festas e estuda. Avance 8 casas",//9
        "Você frequenta festas e não passa vergonha. Avance 7 casas",//10
        "Você foi campeão com a equipe de volei. Avance 3 casas",//11
        "Você conseguiu assistir todas as palestras da Semana da Engenharia. Avance 4 casas",//12
        "Você teve uma ideia de um bilhão de dolares e está recebendo tutoria. Avance 3 casas",//13
        "Você não matou aula para ir ao bar. Avance 8 casas",//14
        "Sua grade foi reorganizada, você vai precisar fazer Física IV. Volte 5 casas",//15
        "Algoritmos e Programação foi um pesadelo para você. Volte 3 casas",//16
        "Você se esforçou muito mas não coneguiu entender Algebra Linear e Geometria Analítica. Volte 3 casas",//17
        "Você errou matemática básica e pegou DP em cálculo. Volte 5 casas",//18
        "Você achou que nunca choveria, então faltou em todas as aulas de Introdução à Engenharia. Volte 7 casas",//19
        "O Breda é o seu professor de Lógica Computacional. Volte 4 casas",//20
        "Você achou que era o Superman e puxou duas materias de Projeto à Engenharia. Volte 10 casas",//21
        "Química Geral foi mais difícil do que imaginou e você não estudou. Volte 3 casas",//22
        "Você recebeu um trabalho e deixou para última hora. Perca uma noite de estudo e volte 3 casas",//23
        "Estatística não entra na sua cabeça e a DP vem a galope. Volte 4 casas",//24
        "Você esqueceu de fazer as provas de EAD. Volte 5 casas",//25
        "Andrea é a sua professora de programação estruturada. Volte 5 casas",//26
        "Você tentou fazer os cálculos de Cálculo Numérico, mas não deu certo. Volte 2 casas.",//27
        "Você pegou Física II com o Diego. Volte 3 casas.",//28
        "Você pegou sua Eletiva I relacionada a alimentos. Volte 4 casas",//29
        "Você se tornou papai/mamãe retorne ao início"//30
    });
    public int avanceMais;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cartaSorteada = CartaRandomica();
            switch (cartaSorteada)
            {
                case 0:
                    avanceMais = 10;
                    Debug.Log(cartas[0]);
                    break;

                case 1:
                    avanceMais = 5;
                    Debug.Log(cartas[1]);
                    break;
                case 2:
                    avanceMais = 5;
                    Debug.Log(cartas[2]);
                    break;

                case 3:
                    avanceMais = 3;
                    Debug.Log(cartas[3]);
                    break;

                case 4:
                    avanceMais = 4;
                    Debug.Log(cartas[4]);
                    break;

                case 5:
                    avanceMais = 5;
                    Debug.Log(cartas[5]);
                    break;

                case 6:
                    avanceMais = 7;
                    Debug.Log(cartas[6]);
                    break;

                case 7:
                    avanceMais = 4;
                    Debug.Log(cartas[7]);
                    break;

                case 8:
                    avanceMais = 5;
                    Debug.Log(cartas[8]);
                    break;

                case 9:
                    avanceMais = 8;
                    Debug.Log(cartas[9]);
                    break;

                case 10:
                    avanceMais = 7;
                    Debug.Log(cartas[10]);
                    break;

                case 11:
                    avanceMais = 3;
                    Debug.Log(cartas[11]);
                    break;

                case 12:
                    avanceMais = 4;
                    Debug.Log(cartas[12]);
                    break;

                case 13:
                    avanceMais = 3;
                    Debug.Log(cartas[13]);
                    break;

                case 14:
                    avanceMais = 8;
                    Debug.Log(cartas[14]);
                    break;

                case 15:
                    avanceMais = -5;
                    Debug.Log(cartas[15]);
                    break;

                case 16:
                    avanceMais = -3;
                    Debug.Log(cartas[16]);
                    break;

                case 17:
                    avanceMais = -3;
                    Debug.Log(cartas[6]);
                    break;

                case 18:
                    avanceMais = -5;
                    Debug.Log(cartas[18]);
                    break;

                case 19:
                    avanceMais = -7;
                    Debug.Log(cartas[19]);
                    break;

                case 20:
                    avanceMais = -4;
                    Debug.Log(cartas[20]);
                    break;

                case 21:
                    avanceMais = -10;
                    Debug.Log(cartas[21]);
                    break;

                case 22:
                    avanceMais = -3;
                    Debug.Log(cartas[22]);
                    break;
                case 23:
                    avanceMais = -3;
                    Debug.Log(cartas[23]);
                    break;

                case 24:
                    avanceMais = -4;
                    Debug.Log(cartas[24]);
                    break;

                case 25:
                    avanceMais = -5;
                    Debug.Log(cartas[25]);
                    break;

                case 26:
                    avanceMais = -5;
                    Debug.Log(cartas[26]);
                    break;

                case 27:
                    avanceMais = -2;
                    Debug.Log(cartas[27]);
                    break;

                case 28:
                    avanceMais = -3;
                    Debug.Log(cartas[28]);
                    break;

                case 29:
                    avanceMais = -4;
                    Debug.Log(cartas[29]);
                    break;

                case 30:
                    avanceMais = 7; // tem que voltar para o inicio
                    Debug.Log(cartas[30]);
                    break;


                default:
                    Debug.Log("Outra carta foi sorteada");
                    break;


            }
        }
    }

    public int CartaRandomica()
    {
        if (Mathf.Abs(valorMax - valorMin) > cartasJaSorteadas.Count)
        {
            //bool condicao = true;
            while (true)
            {
                int numeroAleatorio = Random.Range(valorMin, valorMax);
                if (!cartasJaSorteadas.Contains(numeroAleatorio))
                {
                    cartasJaSorteadas.Add(numeroAleatorio);
                    return numeroAleatorio;
                }
            }

        }
        else
        {
            cartasJaSorteadas = new List<int>();
            return 0;
        }

    }
}
