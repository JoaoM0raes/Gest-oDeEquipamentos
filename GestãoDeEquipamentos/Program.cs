using System;
namespace GestãoDeEquipamentos
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            MostrarMenu();
        }
        static void AdicionarEquipamentos(ref int i, ref string[] lista,ref int contador,ref string[] equipamentos,ref int z,ref int d)
        {
            string digitado = "";
            string a = "";
            string sair = "";
            while (true)
            {
                
                    Console.WriteLine($"Escreva o nome do produto");
                    a = Console.ReadLine();
                    if (Array.Exists(lista, element => element == a))
                    {
                        Console.Clear();
                        Console.WriteLine($"Nome do equipamento já usado");
                        continue;
                    }
                    if (a.Length < 6)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escreva o nome do produto com mais de cinco letras");
                        continue;
                    }
                    lista[i] = a;
                    d++;
                   equipamentos[z] = a;
                   
                    z++;
                    i++;

                    Console.WriteLine($"Escreva o preço do produto");
                    digitado = Console.ReadLine();
                    lista[i] = digitado;
                    i++;
                    Console.WriteLine($"Escreva a série do produto");
                    digitado = Console.ReadLine();
                    lista[i] = digitado;
                    i++;
                    Console.WriteLine($"Escreva a data de fabricação do produto");
                    digitado = Console.ReadLine();
                    lista[i] = digitado;
                    i++;
                    Console.WriteLine($"Escreva o fabricante do produto");
                    digitado = Console.ReadLine();
                    lista[i] = digitado;
                    i++;
                    
                  
                    contador++;
                
                Console.Clear();
                Console.WriteLine("Equipamento adicionado com sucesso");
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("digite C para continuar e digite S para sair ");
                    sair = Console.ReadLine();
                    if (sair != "c" && sair != "s")
                    {

                        Console.WriteLine("Favor colocar uma letra válida");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (sair == "c")
                {
                    Console.Clear();
                    continue;
                }
                else if (sair == "s")
                {
                    Console.Clear();
                    break;
                }
                

            }
           
        }
        static void MostrarOEquipamento(ref string[] lista, ref int MostrarMenu, ref string[] equipamentos,ref int d)
        {
            
            string sair = "";
            string digitado = "";
            while (true)
            {
                if (MostrarMenu == 0)
                {
                    Console.WriteLine("Nenhum item adicionado ainda... digite s para sair ");
                    digitado = Console.ReadLine();
                    if (digitado == "c")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (digitado == "s")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Equipamentos já registrados para uso");
                    for (int i = 0; i < d; i++)
                    {
                        Console.WriteLine("- "+equipamentos[i]);
                    }          
                    string item = "";
                    
                    Console.WriteLine("Escreva o Nome do Equipamento para mais detalhes");
                    item = Console.ReadLine();
                    if (item.Length < 6)
                    {
                        Console.WriteLine($"Escreva o nome do produto com mais de cinco letras");
                        continue;
                    }
                 int cd = Array.IndexOf(equipamentos, item);
                    if (cd == -1)
                    {
                        Console.WriteLine($"Elemento não existe");
                        continue;
                    }
                  
                       if ( item ==equipamentos[cd])
                        {
                            int pos = Array.IndexOf(lista, item);
                            int cont = pos;
                            Console.WriteLine($"Nome do produto: {lista[cont]}");
                            cont += 2;

                            Console.WriteLine($"Série do produto: {lista[cont]}");

                            cont += 2;
                            Console.WriteLine($"fabricante do produto: {lista[cont]}");
                            
                        }
                    else
                    {
                        Console.WriteLine("Erro");
                        continue;
                    }
                      
                                       
                    while (true)
                    {
                        Console.WriteLine("digite C para continuar e digite S para sair ");
                        sair = Console.ReadLine();
                        if (sair != "c" && sair != "s")
                        {

                            Console.WriteLine("Favor colocar uma letra válida");
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (sair == "c")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (sair == "s")
                    {
                        Console.Clear();
                        break;
                    }
                  
                }

            }

        }
        static void MostrarMenu()
        {
            int d = 0;
            string[] equipamentos = new string[1000];
            int z = 0;
            int contagem = 0;
            int contador = 0;
            DateTime dataEntrada= new DateTime();
            string[] lista = new string[1000];
            string[] chamados = new string[1000];
            int mostrarMenu = 0;
            int i = 0;
            while (true)
            {
                string digitado = "";
                Console.WriteLine("Menu principal para gestão de Equipamentos e Chamados");
                Console.WriteLine("");
                Console.WriteLine("Digite 'e' Para acessar equipamentos");
                Console.WriteLine("");
                Console.WriteLine("Digite 'c' para acessar chamados ");

                digitado = Console.ReadLine();
                if (digitado == "e")
                {
                    Console.Clear();
                    MostrarEquipamentos(ref  lista, ref  mostrarMenu,  digitado, ref  i,ref chamados,ref contador,ref equipamentos,ref d,ref z);   
                }
                else if (digitado == "c")
                {
                    Console.Clear();
                    MostrarChamados(ref lista, ref chamados, ref mostrarMenu, ref dataEntrada, ref contador, ref contagem, ref equipamentos, ref d, ref z);
                }
           
            }
        }      
        static void EditarItem(ref string[] lista, ref int MostrarMenu, ref string[] equipamentos,  ref int d)
        {
            string sair = "";
            string digitado;
            while (true)
            {
                if (MostrarMenu == 0)
                {
                    Console.WriteLine("Nenhum item adicionado ainda... digite s para sair ");
                    digitado = Console.ReadLine();
                    if (digitado == "c")
                    {
                        continue;
                    }
                    else if (digitado == "s")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Equipamentos já registrados para uso");
                    for (int i = 0; i < d; i++)
                    {
                        Console.WriteLine("- " + equipamentos[i]);
                    }
                    Console.WriteLine("Escreva O nome do equipamento para edição");
                    string item = Console.ReadLine();
                    if (item.Length < 6)
                    {
                        Console.WriteLine($"Escreva o nome do produto com mais de cinco letras");
                        continue;
                    }

                    int cd = Array.IndexOf(equipamentos, item);
                    if (cd == -1)
                    {
                        Console.WriteLine("Nome de equipamento Incorreto");
                        continue;
                    }

                 


                    if (equipamentos[cd]==item)
                    {
                        string editar;
                        int pos = Array.IndexOf(lista, item);
                        int achar = Array.IndexOf(equipamentos, item);

                        Console.WriteLine("Edite o nome do equipamento ");
                        editar = Console.ReadLine();
                        if (editar.Length < 6)
                        {
                            Console.WriteLine("O nome deve ter pelo menos 6 letras");
                            continue;
                        }
                        lista[pos] = editar;
                        equipamentos[achar] = editar;
                        pos++;
                        Console.WriteLine("Edite o preço do produto");
                        editar = Console.ReadLine();
                        lista[pos] = editar;
                        pos++;
                        Console.WriteLine("Edite a serie do produto ");
                        editar = Console.ReadLine();
                        lista[pos] = editar;
                        pos++;
                        Console.WriteLine("Edite a data de fabricação do produto ");
                        editar = Console.ReadLine();
                        lista[pos] = editar;
                        pos++;
                        Console.WriteLine("Edite a fabricante do produto ");
                        editar = Console.ReadLine();
                        lista[pos] = editar;
                        pos++;

                    }
                    else
                    {
                        Console.WriteLine("favor escolher um equipamento Existente");
                        continue;
                    }
                    while (true)
                    {
                        Console.WriteLine("digite C para continuar e digite S para sair ");
                        sair = Console.ReadLine();
                        if (sair != "c" && sair != "s")
                        {

                            Console.WriteLine("Favor colocar uma letra válida");
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (sair == "c")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (sair == "s")
                    {
                        Console.Clear();
                        break;
                    }
                   
                }

            }
        }
        static void RemoverItem(ref string[] lista, ref int MostrarMenu,ref string[] chamados, ref string[] equipamentos, ref int d,ref int z)
        {
            while (true)
            {
                string sair = "";
                string digitado;
                if (MostrarMenu == 0)
                {
                    Console.WriteLine("Nenhum item adicionado ainda... digite s para sair ");
                    digitado = Console.ReadLine();
                    if (digitado == "c")
                    {
                        continue;
                    }
                    else if (digitado == "s")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Equipamentos já registrados para uso");
                    for (int i = 0; i < d; i++)
                    {
                        Console.WriteLine("- " + equipamentos[i]);
                    }
                    Console.WriteLine("Digite o item para remoção");
                    string item = Console.ReadLine();
                    int cd = Array.IndexOf(equipamentos, item);
                    if (cd == -1)
                    {
                        Console.WriteLine("Erro coloque um equipamento valido");
                        continue;
                    }
                    if (item.Length < 6)
                    {
                        Console.WriteLine($"Escreva o nome do produto com mais de cinco letras");
                        continue;
                    }
                     if (Array.Exists(chamados, element => element == item))
                    {
                        Console.Clear();
                        Console.WriteLine("Não é possível Remover um item dentro de um chamado");
                        break;
                    }
                    if (equipamentos[cd]==item)
                    {
                        int achar = Array.IndexOf(equipamentos, item);
                        int pos = Array.IndexOf(lista, item);
                        for (int i =achar; i < equipamentos.Length-1; i++)
                        {
                            equipamentos[i] = equipamentos[i + 1];
                        }
                        Array.Resize(ref equipamentos, equipamentos.Length-1);
                        d--;
                        z--;
                        
                        
                        for (int i = pos; i < lista.Length - 5; i++)
                        {
                            lista[i] = lista[i + 5];
                        }
                        Array.Resize(ref lista, lista.Length - 1);
                    }
                    else
                    {
                        Console.WriteLine($"Escreva o nome de um produto Existente");
                    }
                }
                while (true)
                {
                    Console.WriteLine("digite C para continuar e digite S para sair ");
                    sair = Console.ReadLine();
                    if (sair != "c" && sair != "s")
                    {

                        Console.WriteLine("Favor colocar uma letra válida");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (sair == "c")
                {
                    Console.Clear();
                    continue;
                }
                else if (sair == "s")
                {
                    Console.Clear();
                    break;
                }
                
            }
        }
        static void Chamados(ref string[] lista, ref int MostrarMenu, ref string[] chamados,ref DateTime dataEntrada,ref int contador,ref int contagem,ref string[] equipamentos,ref int d,ref int z, ref string[] chamadosTotal, ref int u, ref int k )
        {
            int dia = 0;
            int mes = 0;
            int ano = 0;

            int j = 0;
            string item = "";
            string data = "";
            string sair = "";
            
            while (true)
            {
                if (contador == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Favor ter pelo menos um equipamento registrado para poder acessar o chamados!!");
                    break;
                }
                Console.WriteLine("Escolha um titulo para o chamado (Min. 6 letras)");
                item = Console.ReadLine();
                if (item.Length < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar um titulo com 6 letras ou mais");
                    continue;
                }
                u++;
                chamadosTotal[k] = item;
                k++;
                chamados[j] = item;
                j++;
                Console.WriteLine("Escolha uma descrição para o Chamado");
                item = Console.ReadLine();
                chamados[j] = item;
                j++;            
                Console.WriteLine("Equipamentos já registrados para uso");
                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine("- " + equipamentos[i]);
                }
                Console.WriteLine("Escolha um equipamento para o chamado");
                item = Console.ReadLine();
                if (item.Length < 6)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha um equipamento para válido");
                    continue;
                }
                if (Array.Exists(lista, element => element == item))
                {
                    int a = Array.IndexOf(lista, item);
                    chamados[j] = lista[a];
                    j++;
                }
                else
                {
                    Console.WriteLine("Favor colocar um nome de um item já existente");
                }

              
                while (true)
                {
                    Console.WriteLine($"Escolha um dia para o Seu chamado");
                    item = Console.ReadLine();
                    dia = Convert.ToInt32(item);
                    if (dia > 30)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um dia válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um mes para o Seu chamado");
                    item = Console.ReadLine();
                    mes = Convert.ToInt32(item);
                    if (mes > 12)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um mes válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um ano para o Seu chamado");
                    item = Console.ReadLine();
                    ano = Convert.ToInt32(item); ;

                    dataEntrada = new DateTime(ano, mes, dia);
                    data = dataEntrada.ToShortDateString();
                    chamados[j] = data;
                    j++;
                    break;
                }
              

                Console.WriteLine($"Chamado criado Com Sucesso!!!!");
                contagem++;

                while (true)
                {
                    Console.WriteLine("digite C para continuar e digite S para sair ");
                    sair = Console.ReadLine();
                    if (sair != "c" && sair != "s")
                    {

                        Console.WriteLine("Favor colocar uma letra válida");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (sair == "c")
                {
                    Console.Clear();
                    continue;
                }
                else if (sair == "s")
                {
                    Console.Clear();
                    break;
                }

              

            }
        }
        static void VizualizarChamados(ref string[] chamados, ref DateTime dataEntrada, ref int contagem, ref string[] chamadosTotal, ref int u, ref int k)
        {
            {
                while (true)
                {
                    if (contagem == 0)
                    {
                        Console.WriteLine("Favor criar algum Chamado para poder acessar essa opção");
                        break;
                    }
                    string sair = "";          
                    string item = "";
                    Console.WriteLine("Chamados já criados");
                    for (int i = 0; i < k; i++)
                    {
                        Console.WriteLine("- "+chamadosTotal[i]);
                    }
                    Console.WriteLine("Escreva o Nome do Chamado para mais detalhes");
                    item = Console.ReadLine();
                    if (item.Length < 6)
                    {
                        Console.WriteLine("Nome do chamado iválido");
                    }
                    int cd = Array.IndexOf(chamadosTotal, item);
                    if (cd == -1)
                    {
                        Console.WriteLine("Erro coloque um chamado válido");
                        continue;
                    }
                   

                        int pos = Array.IndexOf(chamados, item);
                        int cont = pos;
                        Console.WriteLine($"Nome do chamado: {chamados[cont]}");
                        cont += 2;

                        Console.WriteLine($"Equipamento do chamado: {chamados[cont]}");

                        cont += 1;
                        Console.WriteLine($"data de abertura: {chamados[cont]}");

                        TimeSpan difference = DateTime.Now - dataEntrada;
                        Console.WriteLine("O chamado está aberto há : " + difference.Days + " dias");
                    
                    
                    
                   
                 
                 
                    while (true)
                    {
                        Console.WriteLine("digite C para continuar e digite S para sair ");
                        sair = Console.ReadLine();
                        if (sair != "c" && sair != "s")
                        {

                            Console.WriteLine("Favor colocar uma letra válida");
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (sair == "c")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (sair == "s")
                    {
                        Console.Clear();
                        break;
                    }
                }
                
            }


        }
        static void EditarChamados(ref string[] chamados, ref DateTime dataEntrada, ref string[] lista, ref int contagem, ref string[] equipamentos, ref int d, ref int z, ref string[] chamadosTotal, ref int u, ref int k)
        {
            while (true)
            {
                if (contagem == 0)
                {
                    Console.WriteLine("Favor criar algum Chamado para poder acessar essa opção");
                    break;
                }
                
                string item = "";
                string editar = "";
                int ano, mes, dia;
                string data;
                string sair = "";
                Console.WriteLine("Chamados já criados");
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("- " + chamadosTotal[i]);
                }
                Console.WriteLine("Escreva o Nome do Chamado para edita-lo");
                item = Console.ReadLine();
                if (item.Length < 6)
                {
                    Console.WriteLine("Nome do chamado inválido");
                    continue;
                }
                int cd = Array.IndexOf(chamadosTotal, item);
                if (cd == -1)
                {
                    Console.WriteLine("Erro coloque um chamado válido");
                    continue;
                }
                if (chamadosTotal[cd]==item)
                {         
                    int pos = Array.IndexOf(chamados, item);
                    Console.WriteLine("Edite o nome do Chamado ");
                    editar = Console.ReadLine();
                    if (editar.Length < 6)
                    {
                        Console.WriteLine("Nome do chamado inválido");
                        continue;
                    }
                    int achar = Array.IndexOf(chamadosTotal, item);
                    chamadosTotal[achar] = editar;
                    chamados[pos] = editar;
                    pos++;

                    Console.WriteLine("Edite a descrição do Chamado ");
                    editar = Console.ReadLine();
                    chamados[pos] = editar;
                    pos++;
                     Console.WriteLine("Equipamentos ja criados)");
                    for (int i = 0; i < d; i++)
                    {
                        Console.WriteLine("- " + equipamentos[i]);
                    }
                    Console.WriteLine("Edite o Equipamento do Chamado obs:(O EQUIPAMENTO EDITADO DEVE EXISTIR DENTRO DO INVENTÁRIO)");
                    editar = Console.ReadLine();
                    if (Array.Exists(lista, element => element == editar))
                    {
                        int mostrar = Array.IndexOf(lista, editar);
                        
                        chamados[pos] = lista[mostrar];
                        
                        pos++;
                    }
                    else
                    {
                        pos = 0;
                        Console.WriteLine("Favor escolher um Equipamento com nome válido ou existente");
                        continue;
                    }

                    while (true)
                    {
                        Console.WriteLine($"Escolha um dia para o Seu chamado");
                        item = Console.ReadLine();
                        dia = Convert.ToInt32(item);
                        if (dia > 30)
                        {
                            Console.WriteLine($"Escolha um dia válido");
                            continue;
                        }
                        Console.WriteLine($"Escolha um mes para o Seu chamado");
                        item = Console.ReadLine();
                        mes = Convert.ToInt32(item);
                        if (mes > 12)
                        {
                            Console.WriteLine($"Escolha um mes válido");
                            continue;
                        }

                        Console.WriteLine($"Escolha um ano para o Seu chamado");
                        item = Console.ReadLine();
                        ano = Convert.ToInt32(item); ;

                        dataEntrada = new DateTime(ano, mes, dia);
                        data = dataEntrada.ToShortDateString();
                        chamados[pos] = data;
                        break;
                    }
                  
                }
             

                while (true)
                {
                    Console.WriteLine("digite C para continuar e digite S para sair ");
                    sair = Console.ReadLine();
                    if (sair != "c" && sair != "s")
                    {

                        Console.WriteLine("Favor colocar uma letra válida");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (sair == "c")
                {
                    Console.Clear();
                    continue;
                }
                else if (sair == "s")
                {
                    Console.Clear();
                    break;
                }
            }
           

        }
        static void ExcluirChamados(ref string[] chamados, ref int contagem, ref string[] chamadosTotal, ref int u, ref int k)
        {
            string sair = "";
            while (true)
            {
                if (contagem == 0)
                {
                    Console.WriteLine("Favor criar algum Chamado para poder acessar essa opção");
                    break;
                }
                Console.WriteLine("Chamados já criados");
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("- " + chamadosTotal[i]);
                }
                Console.WriteLine("Digite o item para remoção");
                string item = Console.ReadLine();
                if (item.Length < 6)
                {
                    Console.WriteLine("Nome do chamado iválido");
                    continue;
                }
                int cd = Array.IndexOf(chamadosTotal, item);
                if (cd == -1)
                {
                    Console.WriteLine("Erro coloque um chamado válido");
                    break;
                }
                if (chamadosTotal[cd]==item)
                {
                    int pao = Array.IndexOf(chamadosTotal, item);
                    
                    for (int i = pao; i < chamadosTotal.Length - 1; i++)
                    {
                        chamadosTotal[i] = chamadosTotal[i + 1];
                    }
                    Array.Resize(ref chamadosTotal, chamadosTotal.Length - 1);                  
                    k--;
                    u--;
                    int pos = Array.IndexOf(chamados, item);
                    for (int i = pos; i < chamados.Length - 4; i++)
                    {
                        chamados[i] = chamados[i + 4];
                    }
                    Array.Resize(ref chamados, chamados.Length - 1);
                }          
                while (true)
                {
                    Console.WriteLine("digite C para continuar e digite S para sair ");
                    sair = Console.ReadLine();
                    if (sair != "c" && sair != "s")
                    {

                        Console.WriteLine("Favor colocar uma letra válida");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (sair == "c")
                {
                    Console.Clear();
                    continue;
                }
                else if (sair == "s")
                {
                    Console.Clear();
                    break;
                }
            }
           
            
        }
        static void MostrarEquipamentos(ref string[] lista,ref int mostrarMenu,string digitando,ref int i,ref string[] chamados,ref int contador,ref string[] equipamentos, ref int d,ref int z)
        {
            
           

            while (true)
            {                        
                string digitado = "";
                Console.WriteLine("Gerenciamento De EQUIPAMENTOS!!");
                Console.WriteLine();
                Console.WriteLine("digite 'a' para Adicionar Equipamentos");
                Console.WriteLine();
                Console.WriteLine("digite 'm' para Mostrar Equipamentos");
                Console.WriteLine();
                Console.WriteLine("digite 'e' para Editar os Equipamentos");
                Console.WriteLine();
                Console.WriteLine("digite 'd' para remover os Equipamentos");
                Console.WriteLine();
                Console.WriteLine("digite 's' para voltar ao menu principal");
                Console.WriteLine();
             
                
                digitado = Console.ReadLine();
                if (digitado != "a" && digitado != "m" && digitado != "e" && digitado != "d" && digitado!="s")
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar uma letra válida");
                    continue;
                }

                if (digitado == "a")
                {
                    Console.Clear();
                    AdicionarEquipamentos(ref i, ref lista, ref contador,ref equipamentos,ref z,ref d);
                    mostrarMenu++;
                }

                else if (digitado == "m")
                {
                    Console.Clear();
                    MostrarOEquipamento(ref lista, ref mostrarMenu, ref equipamentos,ref d);
                }
                else if (digitado == "e")
                {
                    Console.Clear();
                    EditarItem(ref lista, ref mostrarMenu, ref equipamentos,ref d);
                }
                else if (digitado == "d")
                {
                    Console.Clear();
                    RemoverItem(ref lista, ref mostrarMenu, ref chamados, ref equipamentos, ref d,ref z);
                }
                else if (digitado == "s")
                {
                    Console.Clear();
                    break;
                }
            }
              
        }
        static void MostrarChamados(ref string[] lista, ref string [] chamados,ref int mostrarMenu,ref DateTime dataEntrada,ref int contador,ref int contagem, ref string[] equipamentos, ref int d, ref int z)
        {
            int u = 0;
            int k = 0;
            string[] chamadosTotal = new string[1000];
            string[] chamadosCont = new string[1000];
            while (true)
            {
                string digitado = "";
                Console.WriteLine("Gerenciamento De CHAMADOS!!");
                Console.WriteLine("digite 'c' para adicionar chamados");
                Console.WriteLine();
                Console.WriteLine("digite 'n' para mostrar o chamado escolhido");
                Console.WriteLine();
                Console.WriteLine("digite 'u' para Editar os chamados");
                Console.WriteLine();
                Console.WriteLine("digite 'x' para Excluir os chamados");
                Console.WriteLine();
                Console.WriteLine("digite 's' para Voltar pro menu");
                digitado = Console.ReadLine();
                if (digitado != "c" && digitado != "n" && digitado != "u" && digitado != "x" && digitado != "s")
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar uma letra válida");
                    continue;
                }
                if (digitado == "c")
                {

                    Chamados(ref lista, ref mostrarMenu, ref chamados, ref dataEntrada, ref contador, ref contagem, ref equipamentos, ref d, ref z, ref chamadosTotal, ref u, ref k);
                }
                else if (digitado == "n")
                {

                    VizualizarChamados(ref chamados, ref dataEntrada, ref contagem, ref chamadosTotal, ref u, ref  k);
                }
                else if (digitado == "u")
                {

                    EditarChamados(ref chamados, ref dataEntrada, ref lista, ref contagem, ref equipamentos, ref d, ref z, ref  chamadosTotal, ref  u, ref  k);
                }
                else if (digitado == "x")
                {

                    ExcluirChamados(ref chamados, ref contagem, ref  chamadosTotal, ref  u, ref  k);
                }
                else if (digitado == "s")
                {
                    Console.Clear();
                    break;
                }
            }
         
        }
    }
}
