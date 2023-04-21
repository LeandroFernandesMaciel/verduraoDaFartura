
using static System.Net.Mime.MediaTypeNames;

/*CONTEXTUALIZAÇÃO: George Boole criou a lógica que usou seu nome, lógica booleana e
sendo discípulo do Aristóteles fez história dentro do mundo computacional. Veja que
interessante, um discípulo de um dos maiores filósofos da história contribuiu para nossa
situação de aprendizagem. A lógica de programação é a base de toda o desenvolvimento
de software. É com ela que podemos organizar o nosso pensamento e propor algoritmos
computacionais.


Nesse contexto encontramos a empresa familiar “João do Verdurão”.
Essa empresa possui uma pequena frota de caminhão e precisa de um sistema console
básico, mas que tenha as funcionalidades principais que possam atender o negócio.

DESAFIO:
João solicita um “Melanciometro” , software este, que irá ajuda-lo no controle de
dois tipos de Melancias (Comum e Baby).
RESULTADOS ESPERADOS:
• O software deve permitir a entrada da placa do caminhão

• O software deve considerar dois valores fixos: melancia comum R$ 5.50 e melancia
baby 8.54 o quilo

• O software deve possuir um looping (do while) que possa interagir com o usuário do
sistema, esse looping irá mostrar o menu e as entradas de dados, deixando-o
controlado por sentinela ( o usuário que vai determinar o fim)

• O software deve considerar o looping e calcular o valor total de melancia comum e o
valor total de melancia baby que foi carregada no caminhão em questão

• O software deve também considerar e mostrar o total geral das duas melancias

• Na entrada de dados o usuário vai entrar com um número inteiro. Você deverá
utilizar um switch para mostrar uma mensagem personalizada para cada dia da
semana. O dia 1 é segunda-feira o dia 5 é sexta-feira.
Os dias de promoção é na terça  e quarta, chamada de terça e quarta verde, então, 
você deve dar um desconto na terça de 15% e na quarta de 17%, as mensagens devem 
ser personalizadas (“terçaverde”, “quarta verde”). Os outros dias, respectivamente,
devem dar os seguintes descontos: Segunda - Feira(1 %) , Quinta - Feira(2 %) , Sexta
- Feira(3 %) e não possuem mensagem de promoções.
• Por último, ele solicitou também, um controle de usuário, considerando que a senha
é 123 e o usuário é “joão”. Sabendo desses valores estáticos, crie um sistema de
login que verifique se o usuário e a senha possuem os dados corretos para
autenticação.
• Muito importante, saber também, que ele pediu para bloquear e abandonar o looping
se o usuário errar três vezes. Então, aplique os conhecimentos de if, if else, while,
break, continue entre outros aplicando-os nesse desafio, considere que ele pode
acertar a senha e o usuário na 1ª , 2ª ou 3ª tentativa.*/







using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace VerduraoDoJoao.Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool usuarioAutenticado = false;
            int contadorErrosLogin = 0;
            do
            {
                Console.WriteLine("Usuário:");
                string usuario = Console.ReadLine();


                Console.WriteLine("Senha:");
                string senha = Console.ReadLine();

                if (usuario == "joao" & senha == "123")
                {
                    usuarioAutenticado = true;
                }
                else
                {
                    contadorErrosLogin++;
                }

                if (contadorErrosLogin == 3)
                {
                    break;
                }

            }
            while (!usuarioAutenticado);

            if (usuarioAutenticado)
            {
                Console.WriteLine(" Bom dia ! Para iniciar a compra informe a placa do seu caminhão");
                int placa = int.Parse(Console.ReadLine());

                Console.WriteLine("Para aproveitar nossas promoções informe o dia da semana. \n 1 - domingo.\n 2 - segunda-feira.\n 3 - terça-feira.\n 4 - quarta.\n 5 - quinta.\n 6 - sexta.");
                int diaSemana = int.Parse(Console.ReadLine());


                int novoPedido;
                int contadorErro = 0;
                bool validaEntradadeMelancia;
                double valorTotalComum = 0;
                double valorTotalBaby = 0;
                double totalGeral = 0;
                double totalKgMelanciaComum = 0;
                double totalKgMelanciaBaby = 0;
                double kgMelanciaBaby = 0;
                double precokgMelaciaComumHabitual = 5.50;
                double precoMelanciaBabyHabitual = 8.54;
                double desconto = 0;
                string diaSemanaNotaFiscal = "";
                string descontoNotaFiscal = "";
                string promocaoDoDia = "";



                do
                {
                    do
                    {

                        Console.WriteLine("Bom dia ! Informe que tipo de melancia quer levar hoje.\n Digite 1 para Melancia COMUM e 2 para Melancia BABY");
                        int melancia = int.Parse(Console.ReadLine());
                        //Console.ReadKey();//serve para o programa não fechar 

                        if (melancia == 1)
                        {
                            //double precokgMelaciaComumHabitual = 5.50;
                            Console.WriteLine(" Você selecionou Melancia Comum que está saindo  por " + precokgMelaciaComumHabitual.ToString() + " o quilo. \n Quantos kg deseja ?");
                            double kgMelanciaComum = int.Parse(Console.ReadLine());
                            validaEntradadeMelancia = true;
                            totalKgMelanciaComum = totalKgMelanciaComum+kgMelanciaComum;
                            valorTotalComum = valorTotalComum + (precokgMelaciaComumHabitual * kgMelanciaComum);// a variável está recebendo ela mesma !!!

                        }
                        else if (melancia == 2)
                        {
                            //double precoMelanciaBabyHabitual = 8.54;
                            Console.WriteLine("Você selecionou Melancia Baby que está saindo por  " + precoMelanciaBabyHabitual.ToString() + " o quilo. \n Quantos kg deseja ?");
                            kgMelanciaBaby = int.Parse(Console.ReadLine());
                            validaEntradadeMelancia = true;
                            totalKgMelanciaBaby = totalKgMelanciaBaby + kgMelanciaBaby;
                            valorTotalBaby = valorTotalBaby + (precoMelanciaBabyHabitual * kgMelanciaBaby);


                        }
                        else
                        {

                            Console.WriteLine("Não existe essa opção! Vamos reiniciar o Sistema!" +
                                "\n. Lembre-se desta vez de utilizar apenas as opções válidas 1 ou 2 ");
                            contadorErro++;
                            validaEntradadeMelancia = false;
                        }

                        if (contadorErro == 3)
                        {
                            Console.WriteLine("Você errou 3 vezes! \n O sistema será encerrado !");
                            break;
                        }

                    } while (!validaEntradadeMelancia);


                    if (contadorErro == 3)
                    {
                        break;
                    }

                    totalGeral = (valorTotalComum + valorTotalBaby);

                    Console.WriteLine("Gostaria de fazer um novo pedido ? \n 1 para sim  \n 2 para não ");
                    novoPedido = int.Parse(Console.ReadLine());


                } while (novoPedido == 1);


                switch (diaSemana)
                {
                    case 1: diaSemanaNotaFiscal = "Segunda-feira"; promocaoDoDia = "incentivo de 1%                    "; descontoNotaFiscal = "01% de desconto"; desconto = 0.01; break;
                    case 2: diaSemanaNotaFiscal = "Terça-feira  "; promocaoDoDia = "EBA! Terça-Verde desontão de 15%   "; descontoNotaFiscal = "15% de desconto"; desconto = 0.15; break;
                    case 3: diaSemanaNotaFiscal = "Quarta-feira "; promocaoDoDia = "EBA! Quarta-Verde descontão de 17% "; descontoNotaFiscal = "17% de desconto"; desconto = 0.17; break;
                    case 4: diaSemanaNotaFiscal = "Quinta-feira "; promocaoDoDia = "incentivo de 2%                    "; descontoNotaFiscal = "02% de desconto"; desconto = 0.02; break;
                    case 5: diaSemanaNotaFiscal = "Sexta-feira  "; promocaoDoDia = "incentivo de 3%                    "; descontoNotaFiscal = "03% de desconto"; desconto = 0.03; break;

                }



                Console.WriteLine("Seu pedido ficou assim:\n");

                Console.WriteLine(totalKgMelanciaComum + " kg de melancia comum" + ". Valor  do Kg Melancia Comum " + precokgMelaciaComumHabitual + " Total ...." + valorTotalComum.ToString("F2") + " reais ");//ToString("F2") formato o num para duas casas apos a virgula;
                Console.WriteLine(totalKgMelanciaBaby + " kg de melancia baby" + ". Valor do Kg Melancia Baby " + precoMelanciaBabyHabitual + " Total ......" + valorTotalBaby.ToString("F2") + " reais ");
                Console.WriteLine(" Total Geral ............................................... " + totalGeral.ToString("F2") + "\n \n");
                totalGeral = totalGeral - (totalGeral * desconto);

                Console.WriteLine(diaSemanaNotaFiscal + " " + promocaoDoDia + " \n Descontos totais = " + descontoNotaFiscal);
                Console.WriteLine(" Total Final com DESCONTO ............." + totalGeral.ToString("F2"));

                Console.WriteLine(" \n Obrigado!");
                Console.WriteLine(" O Verdurão do João agradece a sua preferência");


            }
            else
            {
                Console.WriteLine("Usuário não autenticado! Você erro a senha 3 vezes !  O programa será fechado !");
            }
        }




    }
}