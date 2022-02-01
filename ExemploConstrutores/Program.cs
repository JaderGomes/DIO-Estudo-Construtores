using System;
using ExemploConstrutores.Models;
     
namespace ExemploConstrutores
{
        class Program
        {
               public delegate void Operacao(int x, int y);

               static void Main(string[] args)
                {       
                    Matematica m = new Matematica (10, 20);
                    m.Somar();


                //       Operacao = Calculadora.Somar;
                //       Operacao op = new Operacao(Calculadora.Somar);
                //       op += Calculadora.Subtrair;
                
                //       op.Invoke (10, 10);

                      //op(10, 10);
                      

                 // const double pi = 3.14;
                 // System.Console.WriteLine(pi);


                 // Data data = new Data();
                 // data.SetMes(20);
                
                 // data.Mes = 12;
                 // System.Console.WriteLine(data.Mes);
                
                 // data.ApresentarMes();


                 //     Log log = Log.GetInstance();

                 //     log.PropriedadeLog = "Teste Instancia";

                 //     Log log2 = Log.GetInstance();
                 //     System.Console.WriteLine(log2.PropriedadeLog); 

                 //    Pessoa p1 = new Pessoa("Jader", "Gomes");
                 //    p1.Apresentar();


                 //       Aluno p1 = new Aluno("Jader" , "Gomes" ,  "Teste");
                 //       p1.Apresentar(); 
                }
        }
}