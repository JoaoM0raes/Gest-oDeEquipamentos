using System;

namespace GestãoDeEquipamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }
        static void AdicionarEquipamentos(ref int i, ref string[] lista, ref int contador, ref string[] equipamentos, ref int z, ref int d)
        {
            int number = 0;
            int dia = 0;
            int mes = 0;
            int ano = 0;
            int preço = 0;
            string data = "";
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
                while (true)
                {
                    Console.WriteLine($"Escreva o preço do produto");
                    digitado = Console.ReadLine();
                    if (digitado.Length == 0)
                    {
                        Console.WriteLine($"Favor prencher o compo");
                        continue;
                    }
                    bool isNumber = int.TryParse(digitado, out preço);
                    if (isNumber == false)
                    {
                        Console.WriteLine($"favor colocar um número válido ");
                        continue;
                    }
                    if (preço == 0 || preço < 1)
                    {
                        Console.WriteLine($"O preço do produto deve ser maior que 0 ");
                        continue;
                    }
                    lista[i] = digitado;
                    i++;
                    break;
                }

                while (true)
                {
                    Console.WriteLine($"Escreva a série do produto com AAA-AAA");
                    digitado = Console.ReadLine();
                    if (digitado.Length < 7 || digitado.Length > 8)
                    {
                        Console.WriteLine($"Série do produto inválido");
                        continue;
                    }
                    if (digitado[3] != '-')
                    {
                        Console.WriteLine($"Série do produto inválido");
                        continue;
                    }
                    if (Array.Exists(lista, element => element == digitado))
                    {
                        Console.WriteLine($"Série do produto já existente");
                        continue;
                    }
                    lista[i] = digitado;
                    i++;
                    break;
                }
                while (true)
                {
                    Console.WriteLine($"Escolha o dia de fabricação");
                    digitado = Console.ReadLine();
                    bool isNumber = int.TryParse(digitado, out number);
                    if (isNumber == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    dia = Convert.ToInt32(digitado);
                    if (dia > 30)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um dia de fabricação válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um mes de fabricação");
                    digitado = Console.ReadLine();
                    bool lol = int.TryParse(digitado, out number);
                    if (lol == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    mes = Convert.ToInt32(digitado);
                    if (mes > 12)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um mes válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um ano de fabricação");
                    digitado = Console.ReadLine();
                    bool cs = int.TryParse(digitado, out number);
                    if (cs == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    ano = Convert.ToInt32(digitado); ;

                    DateTime Entrada = new DateTime(ano, mes, dia);
                    data = Entrada.ToShortDateString();
                    lista[i] = data;
                    i++;
                    break;
                }
                while (true)
                {
                    Console.WriteLine($"Escreva o fabricante do produto");
                    digitado = Console.ReadLine();
                    if (digitado.Length < 1)
                    {
                        Console.WriteLine($"O campo não pode ser vázio");
                        continue;
                    }
                    lista[i] = digitado;
                    i++;
                    break;
                }
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
        static void MostrarOEquipamento(ref string[] lista, ref int MostrarMenu, ref string[] equipamentos, ref int d)
        {

            string sair = "";
            string digitado = "";
            while (true)
            {
                if (d == 0)
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
                        Console.WriteLine("- " + equipamentos[i]);
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

                    if (item == equipamentos[cd])
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
            DateTime dataEntrada = new DateTime();
            string[] lista = new string[1000];
            string[] chamados = new string[1000];
            string[] solicitantes = new string[1000];
            string[] solicitantesTotal = new string[1000];
            int mostrarMenu = 0;
            int i = 0;
            int w = 0;
            int l = 0;
            while (true)
            {
                string digitado = "";
                Console.WriteLine("Menu principal para gestão de Equipamentos e Chamados");
                Console.WriteLine("");
                Console.WriteLine("Digite 'e' Para acessar equipamentos");
                Console.WriteLine("");
                Console.WriteLine("Digite 'c' para acessar chamados ");
                Console.WriteLine("");
                Console.WriteLine("Digite 'b' para acessar solicitantes ");

                digitado = Console.ReadLine();
                if (digitado == "e")
                {
                    Console.Clear();
                    MostrarEquipamentos(ref lista, ref mostrarMenu, digitado, ref i, ref chamados, ref contador, ref equipamentos, ref d, ref z);
                }
                else if (digitado == "c")
                {
                    Console.Clear();
                    MostrarChamados(ref lista, ref chamados, ref mostrarMenu, ref dataEntrada, ref contador, ref contagem, ref equipamentos, ref d, ref z,ref solicitantesTotal,ref solicitantes,ref w);
                }
                else if (digitado == "b")
                {
                    MostrarSolicitantes(ref solicitantes, ref solicitantesTotal, ref w, ref l,ref chamados);
                }

            }
        }
        static void EditarItem(ref string[] lista, ref int MostrarMenu, ref string[] equipamentos, ref int d)
        {
            string sair = "";
            string digitado;
            while (true)
            {
                if (d == 0)
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




                    if (equipamentos[cd] == item)
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
        static void RemoverItem(ref string[] lista, ref int MostrarMenu, ref string[] chamados, ref string[] equipamentos, ref int d, ref int z)
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
                    if (equipamentos[cd] == item)
                    {
                        int achar = Array.IndexOf(equipamentos, item);
                        int pos = Array.IndexOf(lista, item);
                        for (int i = achar; i < equipamentos.Length - 1; i++)
                        {
                            equipamentos[i] = equipamentos[i + 1];
                        }
                        Array.Resize(ref equipamentos, equipamentos.Length - 1);
                        d--;
                        z--;


                        for (int i = pos; i < lista.Length - 5; i++)
                        {
                            lista[i] = lista[i + 5];
                        }
                        Array.Resize(ref lista, lista.Length - 1);
                        Console.WriteLine($"Equipamento excluido");
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
        static void Chamados(ref string[] lista, ref int MostrarMenu, ref string[] chamados, ref DateTime dataEntrada, ref int contador, ref int contagem, ref string[] equipamentos, ref int d, ref int z, ref string[] chamadosTotal, ref int u, ref int k,ref string[]solicitantesTotal,ref string[] solicitantes,ref int w, ref string[] equipamentosTotal, ref int b, ref int c)
        {
            int dia = 0;
            int mes = 0;
            int ano = 0;

            int j = 0;
            string item = "";
            string data = "";
            string sair = "";
            int number;

            while (true)
            {
                if (d == 0)
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
                while (true)
                {
                    Console.WriteLine("Escolha uma descrição para o Chamado");
                    item = Console.ReadLine();
                    if (item.Length < 1)
                    {
                        Console.WriteLine("Erro campo vazio");
                    }
                    chamados[j] = item;
                    j++;
                    break;
                }
                while (true)
                {
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
                    int cd = Array.IndexOf(equipamentos, item);
                    if (cd == -1)
                    {
                        Console.WriteLine($"Equipamento não existe");
                        continue;
                    }else
                    {
                        int a = Array.IndexOf(lista, item);
                        chamados[j] = lista[a];
                        c++;
                        equipamentosTotal[b]= lista[a];
                        b++;
                        j++;
                    }
                    
                    break;
                }
                while (true)
                {
                    Console.WriteLine($"Escolha um dia para o Seu chamado");
                    item = Console.ReadLine();
                    bool lol = int.TryParse(item, out number);
                    if (lol == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    dia = Convert.ToInt32(item);
                    if (dia > 30)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um dia válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um mes para o Seu chamado");
                    item = Console.ReadLine();
                    bool vasco = int.TryParse(item, out number);
                    if (vasco == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    mes = Convert.ToInt32(item);
                    if (mes > 12)
                    {
                        Console.Clear();
                        Console.WriteLine($"Escolha um mes válido");
                        continue;
                    }

                    Console.WriteLine($"Escolha um ano para o Seu chamado");
                    item = Console.ReadLine();
                    bool inter = int.TryParse(item, out number);
                    if (inter == false)
                    {
                        Console.WriteLine($"Favor utilizar números");
                        continue;
                    }
                    ano = Convert.ToInt32(item);

                    dataEntrada = new DateTime(ano, mes, dia);
                    data = dataEntrada.ToShortDateString();
                    chamados[j] = data;
                    j++;
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Solicitantes já registrados para uso");
                    for (int i = 0; i < w; i++)
                    {
                        Console.WriteLine("- " + solicitantesTotal[i]);
                    }
                    Console.WriteLine("Escreva um solicitante para entrar no chamado");
                    item= Console.ReadLine();
                    int cd = Array.IndexOf(solicitantesTotal, item);
                    if (cd == -1)
                    {
                        Console.WriteLine($"Elemento não existe");
                        continue;
                    }else
                    {
                        int a = Array.IndexOf(solicitantes, item);
                        chamados[j] = solicitantesTotal[a];
                        j++;
                    }
                    break;
                }

                chamados[j] = "Aberto";
                j++;
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
                        Console.WriteLine("- " + chamadosTotal[i]);
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

                    cont++;
                    Console.WriteLine($"data de abertura: {chamados[cont]}");
                    cont++;
                    Console.WriteLine($"solicitante desse Chamado: {chamados[cont]}");
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
        static void EditarChamados(ref string[] chamados, ref DateTime dataEntrada, ref string[] lista, ref int contagem, ref string[] equipamentos, ref int d, ref int z, ref string[] chamadosTotal, ref int u, ref int k, ref string[] solicitantesTotal, ref string[] solicitantes, ref int w)
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
                if (chamadosTotal[cd] == item)
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
                        pos++;
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Solicitantes já registrados para uso");
                        for (int i = 0; i < w; i++)
                        {
                            Console.WriteLine("- " + solicitantesTotal[i]);
                        }
                        Console.WriteLine("Escreva um solicitante para entrar no chamado");
                        item = Console.ReadLine();
                        int lol = Array.IndexOf(solicitantesTotal, item);
                        if (lol == -1)
                        {
                            Console.WriteLine($"Elemento não existe");
                            continue;
                        }
                        else
                        {
                            int a = Array.IndexOf(solicitantes, item);
                            chamados[pos] = solicitantesTotal[a];
                            pos++;
                        }
                        break;
                    }
                    while (true)
                    {
                        Console.WriteLine("Digite 'a' para deixar o chamado aberto e 'f' para fechar o chamado");
                        item = Console.ReadLine();
                        if (item == "a")
                        {
                            chamados[pos] = "Aberto";
                        }else if (item == "f")
                        {
                            chamados[pos] = "Fechado";
                        }
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
                if (chamadosTotal[cd] == item)
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
                    for (int i = pos; i < chamados.Length - 6; i++)
                    {
                        chamados[i] = chamados[i + 6];
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
        static void MostrarEquipamentos(ref string[] lista, ref int mostrarMenu, string digitando, ref int i, ref string[] chamados, ref int contador, ref string[] equipamentos, ref int d, ref int z)
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
                if (digitado != "a" && digitado != "m" && digitado != "e" && digitado != "d" && digitado != "s")
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar uma letra válida");
                    continue;
                }

                if (digitado == "a")
                {
                    Console.Clear();
                    AdicionarEquipamentos(ref i, ref lista, ref contador, ref equipamentos, ref z, ref d);
                    mostrarMenu++;
                }

                else if (digitado == "m")
                {
                    Console.Clear();
                    MostrarOEquipamento(ref lista, ref mostrarMenu, ref equipamentos, ref d);
                }
                else if (digitado == "e")
                {
                    Console.Clear();
                    EditarItem(ref lista, ref mostrarMenu, ref equipamentos, ref d);
                }
                else if (digitado == "d")
                {
                    Console.Clear();
                    RemoverItem(ref lista, ref mostrarMenu, ref chamados, ref equipamentos, ref d, ref z);
                }
                else if (digitado == "s")
                {
                    Console.Clear();
                    break;
                }
            }

        }
        static void MostrarChamados(ref string[] lista, ref string[] chamados, ref int mostrarMenu, ref DateTime dataEntrada, ref int contador, ref int contagem, ref string[] equipamentos, ref int d, ref int z,ref string[] solicitantesTotal,ref string[] solicitantes,ref int w)
        {
            int u = 0;
            int k = 0;
            string[] chamadosTotal = new string[1000];
            string[] chamadosCont = new string[1000];
            string[] equipamentosTotal = new string[1000];
            int b = 0;
            int c = 0;
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
                Console.WriteLine("digite 'k' para mostrar os chamados Abertos e Fechados");
                Console.WriteLine();
                Console.WriteLine("digite 'l' para mostrar contagem de problema");
                Console.WriteLine();
                Console.WriteLine("digite 's' para Voltar pro menu");
                digitado = Console.ReadLine();
                if (digitado != "c" && digitado != "n" && digitado != "u" && digitado != "x" && digitado != "s" && digitado != "k" && digitado != "l")
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar uma letra válida");
                    continue;
                }
                if (digitado == "c")
                {
                    Console.Clear();
                    Chamados(ref lista, ref mostrarMenu, ref chamados, ref dataEntrada, ref contador, ref contagem, ref equipamentos, ref d, ref z, ref chamadosTotal, ref u, ref k,ref solicitantesTotal,ref solicitantes,ref w,ref equipamentosTotal,ref b,ref c);
                }
                else if (digitado == "n")
                {
                    Console.Clear();
                    VizualizarChamados(ref chamados, ref dataEntrada, ref contagem, ref chamadosTotal, ref u, ref k);
                }
                else if (digitado == "u")
                {
                    Console.Clear();
                    EditarChamados(ref chamados, ref dataEntrada, ref lista, ref contagem, ref equipamentos, ref d, ref z, ref chamadosTotal, ref u, ref k, ref solicitantesTotal, ref  solicitantes, ref w);
                }
                else if (digitado == "x")
                {
                    Console.Clear();
                    ExcluirChamados(ref chamados, ref contagem, ref chamadosTotal, ref u, ref k);
                }
                else if (digitado == "k")
                {
                    Console.Clear();
                    chamadosAbertosFechados(ref chamados);
                }
                else if (digitado == "l")
                {
                    Console.Clear();
                    mostrarEquipamentoProblema(ref equipamentosTotal, ref c);
                }
                else if (digitado == "s")
                {
                    Console.Clear();
                    break;
                }
            }

        }
        static void MostrarSolicitantes(ref string[] solicitantes, ref string[] solicitantesTotal, ref int l, ref int w,ref string[] chamados)
        {
            int id = 0;
            while (true)
            {
                string digitado = "";
                Console.WriteLine("Menu Solicitantes");
                Console.WriteLine("Digite 'a' para adicionar um solicitante");
                Console.WriteLine();
                Console.WriteLine("Digite 'm' para mostrar um solicitante ");
                Console.WriteLine();
                Console.WriteLine("Digite 'e' para editar um solicitante ");
                Console.WriteLine();
                Console.WriteLine("Digite 'x' para excluir um solicitante ");
                Console.WriteLine();
                Console.WriteLine("Digite 's' para sair para o menu principal ");
                Console.WriteLine();


                digitado = Console.ReadLine();
                if (digitado != "a" && digitado != "m" && digitado != "e" && digitado != "x" && digitado != "s")
                {
                    Console.Clear();
                    Console.WriteLine("Favor colocar uma letra válida");
                    continue;
                }
                else if (digitado == "a")
                {
                    Console.Clear();
                    adicionarSolicitante(ref solicitantes, ref solicitantesTotal, ref l, ref w, ref id);
                }
                else if (digitado == "m")
                {
                    Console.Clear();
                    mostrarSolicitante(ref solicitantes, ref solicitantesTotal, ref id, ref w);
                }
                else if (digitado == "e")
                {
                    Console.Clear();
                    editarSolicitante(ref solicitantes, ref solicitantesTotal, ref w);
                }
                else if (digitado=="x")
                {
                    Console.Clear();
                    excluirSolicitante(ref  solicitantes, ref  solicitantesTotal, ref w, ref l,ref chamados);
                }
                else if (digitado=="s")
                {
                    Console.Clear();
                    break;
                }
            }
        }
        static void adicionarSolicitante(ref string[] solicitantes, ref string[] solicitantesTotal, ref int l, ref int w, ref int id)
        {
            string sair = "";
            int i = 0;
            string digitado = "";
            while (true)
            {
                Console.WriteLine("Favor escreva o nome do solicitante Min 6 letras.");
                digitado = Console.ReadLine();
                if (digitado.Length < 6)
                {
                    Console.WriteLine("Favor escreva o nome com mais de cinco letras.");
                    continue;
                }
                w++;
                solicitantesTotal[l] = digitado;
                l++;
                solicitantes[i] = digitado;
                i++;
                while (true)
                {
                    Console.WriteLine("Favor escreva o email do solicitante");
                    digitado = Console.ReadLine();
                    if (digitado.Length < 1)
                    {
                        Console.WriteLine("campo vazio!!!!!!!!!");
                        continue;
                    }
                    solicitantes[i] = digitado;
                    i++;
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Favor escreva o número do solicitante");
                    digitado = Console.ReadLine();
                    if (digitado.Length < 9 || digitado.Length > 9)
                    {
                        Console.WriteLine("Favor escrever o número com 9 digitos");
                        continue;
                    }
                    solicitantes[i] = digitado;
                    i++;
                    break;
                }
                id++;
                string MostrarId = Convert.ToString(id);
                Console.Write(MostrarId);
                solicitantes[i] = MostrarId;
                i++;
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
        static void mostrarSolicitante(ref string[] solicitante, ref string[] solicitantesTotal, ref int id, ref int w)
        {
            string sair = "";
            string digitado = "";
            while (true)
            {
                Console.WriteLine("Nome de solicitantes já criados");
                for (int i = 0; i < w; i++)
                {
                    Console.WriteLine("- " + solicitantesTotal[i]);
                }
                Console.WriteLine("Escreva o nome do solicitante para mostra-lo");
                digitado = Console.ReadLine();
                int cd = Array.IndexOf(solicitantesTotal, digitado);
                if (cd == -1)
                {
                    Console.WriteLine($"Solicitante não existe");
                    continue;
                }
                if (digitado == solicitantesTotal[cd])
                {
                    int pos = Array.IndexOf(solicitante, digitado);
                    int cont = pos;
                    Console.WriteLine($"Nome do solicitante: {solicitante[cont]}");
                    cont++;
                    Console.WriteLine($"email do solicitante: {solicitante[cont]}");
                    cont++;
                    Console.WriteLine($"número do solicitante: {solicitante[cont]}");
                    cont++;
                    Console.WriteLine($"id do solicitante: {solicitante[cont]}");
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
        static void editarSolicitante(ref string[] solicitante, ref string[] solicitantesTotal, ref int w)
        {
            string sair = "";
            string item = "";
            while (true)
            {
                Console.WriteLine("Nome de solicitantes já criados");
                for (int i = 0; i < w; i++)
                {
                    Console.WriteLine("- " + solicitantesTotal[i]);
                }
                Console.WriteLine("Coloque o nome do solicitane para edita-lo");
                item=Console.ReadLine();

                
                int cd = Array.IndexOf(solicitantesTotal, item);
                if (cd == -1)
                {
                    Console.WriteLine("Nome de equipamento Incorreto");
                    continue;
                }
                if (solicitantesTotal[cd] == item)
                {
                    string editar;
                    int pos = Array.IndexOf(solicitante, item);
                    int achar = Array.IndexOf(solicitantesTotal, item);

                    Console.WriteLine("Edite o nome do solicitante");
                    editar = Console.ReadLine();
                    if (editar.Length < 6)
                    {
                        Console.WriteLine("O nome deve ter pelo menos 6 letras");
                        continue;
                    }
                    solicitante[pos] = editar;
                    solicitantesTotal[achar] = editar;
                    pos++;
                    Console.WriteLine("Edite o email do  solicitante ");
                    editar = Console.ReadLine();
                    solicitante[pos] = editar;
                    pos++;
                    Console.WriteLine("Edite o número do solicitante ");
                    editar = Console.ReadLine();
                    if(editar.Length<9 || editar.Length > 9)
                    {
                        Console.WriteLine("Favor colocar o número com 9 digitos");
                        continue;
                    }
                    solicitante[pos] = editar;
                    pos++;
                   
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
        static void excluirSolicitante(ref string[] solicitante, ref string[] solicitantesTotal, ref int w,ref int l,ref string[] chamados)
        {
            string sair = "";
            string item = "";
            while (true)
            {
                Console.WriteLine("Nome de solicitantes já criados");
                for (int i = 0; i < w; i++)
                {
                    Console.WriteLine("- " + solicitantesTotal[i]);
                }
                Console.WriteLine("Escreva o nome do solicitante para Excluir ");
                item = Console.ReadLine();
                
                int cd = Array.IndexOf(chamados, item);
                if (cd == -1)
                {
                    int lol = Array.IndexOf(solicitantesTotal, item);
                    if (lol == -1)
                    {
                        Console.Clear();
                        Console.WriteLine($"Solicitante não existe");
                        break;
                    }
                    if (item == solicitantesTotal[lol])
                    {
                        int achar = Array.IndexOf(solicitantesTotal, item);
                        int pos = Array.IndexOf(solicitante, item);
                        for (int i = achar; i < solicitantesTotal.Length - 1; i++)
                        {
                            solicitantesTotal[i] = solicitantesTotal[i + 1];
                        }
                        Array.Resize(ref solicitantesTotal, solicitantesTotal.Length - 1);
                        w--;
                        l--;


                        for (int i = pos; i < solicitante.Length - 4; i++)
                        {
                            solicitante[i] = solicitante[i + 4];
                        }
                        Array.Resize(ref solicitante, solicitante.Length - 1);
                        Console.WriteLine($"Equipamento excluido");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Solicitante já aberto em um chamado");
                    break;
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
        static void chamadosAbertosFechados(ref string []chamados)
        {
            Console.WriteLine("Chamados Abertos");
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == "Aberto")
                {
                    Console.WriteLine(chamados[i-5]);
                }
            }
            Console.WriteLine("Chamados Fechados");
            for (int i = 0; i < chamados.Length; i++)
            {
                if (chamados[i] == "Fechado")
                {
                    Console.WriteLine(chamados[i-5]);
                }
            }
        }
        static void mostrarEquipamentoProblema(ref string[] equipamentosTotal,ref int c)
        {

            string apareceu = "";
                for (int i = 0; i < c; i++)
                {
                    int contagem = 0;
                   
                    for (int l = 0; l < c; l++)
                    {
                        if (equipamentosTotal[i] == equipamentosTotal[l])
                        {
                            contagem++;
                            i = l;
                        }
                    

                    }
                if (contagem == 1)
                {
                    apareceu = "problema";
                }
                else
                {
                    apareceu = "problemas";
                }
                    Console.WriteLine($"O Equipamento {equipamentosTotal[i]} teve {contagem} {apareceu} ");
                }
            
        }
    }
}
