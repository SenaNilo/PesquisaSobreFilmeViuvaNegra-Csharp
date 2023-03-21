using System;

class Program {
  //Contagem de partiipantes, média da idade dos participantes e a porcentagem escolhidas em cada alternativa: Ótimo, Bom, Regular, Ruim ou Péssimo
  public static void Main (string[] args) {
    double media_id, id, cont = 0, soma_id = 0, cont_a = 0, cont_b = 0, cont_c = 0, cont_d = 0, cont_e = 0, pc_a, pc_b, pc_c, pc_d, pc_e;
    char op;
    do{
      if (cont == 0){
        Console.WriteLine("Para finalizar o programa, Digite 0 ou menos para a idade");
        Console.WriteLine("");
        Console.WriteLine("Qual a idade do espectador? ");
        id = double.Parse(Console.ReadLine());
      }
      else{
        Console.WriteLine("Qual a idade do outro espectador? ");
        id = double.Parse(Console.ReadLine());
      }
      if (id > 0){
        Console.WriteLine("A - Ótimo");
        Console.WriteLine("B - Bom");
        Console.WriteLine("C - Regular");
        Console.WriteLine("D - Ruim");
        Console.WriteLine("E - Péssimo");
        Console.Write("Qual sua opinião sobre o filme, Viúva Negra? ");
        op = char.Parse(Console.ReadLine().ToUpper());
        switch (op){ //contagem de cada alternativa
          case 'A':
            cont_a = cont_a + 1;
          break;
          case 'B':
            cont_b = cont_b + 1;
          break;
          case 'C':
            cont_c = cont_c + 1;
          break;
          case 'D':
            cont_d = cont_d + 1;
          break;
          case 'E':
            cont_e = cont_e + 1;
          break;
          default:
            do{
              Console.Write("Critério inválido, digite novamente: ");
              op = char.Parse(Console.ReadLine().ToUpper());
            }while(op != 'A' && op != 'B' && op != 'C' && op != 'D' && op != 'E');
          break;
        }
        cont = cont + 1;//quantidade de pessoas que responderam
        soma_id = soma_id + id;
        Console.WriteLine("");
      }// fim if
    } while (id > 0); //fim do-while

    //Media_id
    media_id = soma_id / cont;

    //Calculo Porcentagem
    pc_a = 100 * cont_a / cont;
    pc_b = 100 * cont_b / cont;
    pc_c = 100 * cont_c / cont;
    pc_d = 100 * cont_d / cont;
    pc_e = 100 * cont_e / cont;

    //Apresentação de tela
    Console.WriteLine("");
    Console.WriteLine("Total de participantes: {0}", cont);
    Console.WriteLine("Média da idade dos participantes: {0}", media_id);
    Console.WriteLine("Porcentagem da pesquisa: ");
    Console.WriteLine("");
    Console.WriteLine("A = {0:F2}%", pc_a);
    Console.WriteLine("B = {0:F2}%", pc_b);
    Console.WriteLine("C = {0:F2}%", pc_c);
    Console.WriteLine("D = {0:F2}%", pc_d);
    Console.WriteLine("E = {0:F2}%", pc_e);
    Console.ReadLine();   
  }
}