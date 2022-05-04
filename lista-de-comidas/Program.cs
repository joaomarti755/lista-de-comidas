public class Program
{
	public static void Main()
	{

		Console.WriteLine(" Tipo        | Nome                                       | Valor     ");
		Console.WriteLine(" Bolos       | Bolo Brigadeiro                            | R$ 29,50  ");

		Console.WriteLine(" Bolos       | Bolo Floresta Negra                        | R$ 2,00   ");

		Console.WriteLine(" Bolos       | Bolo Leite com Nutella                     | R$ 29,23  ");

		Console.WriteLine(" Bolos       | Bolo Mousse de Chocolate                   | R$ 7,10   ");

		Console.WriteLine(" Bolos       | Bolo Nega Maluca                           | R$ 19,33  ");

		Console.WriteLine(" Doces       | Bolo de Creme                              | R$ 17,71  ");

		Console.WriteLine(" Doces       | Bolo de Morango                            | R$ 4,82   ");

		Console.WriteLine(" Sanduíches  | Filé-Mignon com fritas e cheddar           | R$ 21,16  ");

		Console.WriteLine(" Sanduíches  | Hambúrguer com queijos,champignon e rúcula | R$ 12,70  ");

		Console.WriteLine(" Sanduíches  | Provolone com salame                       | R$ 19,70  ");

		Console.WriteLine(" Sanduíches  | Vegetariano de berinjela                   | R$ 28,22  ");

		Console.WriteLine(" Pizzas      | Calabresa                                  | R$ 8,98   ");

		Console.WriteLine(" Pizzas      | Napolitana                                 | R$ 0,42   ");

		Console.WriteLine(" Pizzas      | Peruana                                    | R$ 18,36  ");

		Console.WriteLine(" Pizzas      | Portuguesa                                 | R$ 27,50  ");

		Console.Write("Digite seu primeiro pedido: ");
		string pedido1 = Console.ReadLine();

		Console.Write("Digite seu segundo pedido: ");
		string pedido2 = Console.ReadLine();

		Console.Write("Digite seu terceiro pedido: ");
		string pedido3 = Console.ReadLine();

		if (pedido1.ToLower().Trim() == "bolo brigadeiro")
		{
			pedido1 = "Bolo Brigadeiro | 29.50";
		}
		else if (pedido1.ToLower().Trim() == "bolo floresta negra")
		{
			pedido1 = "Bolo Floresta Negra | 2.00";
		}
		else if (pedido1.ToLower().Trim() == "bolo leite com nutella")
		{
			pedido1 = "Bolo Leite com Nutella | 29.23";
		}
		else if (pedido1.ToLower().Trim() == "bolo mousse de chocolate")
		{
			pedido1 = "Bolo Mousse de Chocolate | 7.10";
		}
		else if (pedido1.ToLower().Trim() == "bolo nega maluca")
		{
			pedido1 = "Bolo Nega Maluca | 19.33";
		}
		else if (pedido1.ToLower().Trim() == "bolo de creme")
		{
			pedido1 = "Bolo de Creme | 17.71";
		}
		else if (pedido1.ToLower().Trim() == "bolo de morango")
		{
			pedido1 = "Bolo de Morango | 4.82";
		}
		else if (pedido1.ToLower().Trim() == "filé-mignon com fritas e cheddar")
		{
			pedido1 = "Filé-Mignon com fritas e cheddar | 21.16";
		}
		else if (pedido1.ToLower().Trim() == "hambúrguer com queijos,champignon e rúcula")
		{
			pedido1 = "Hambúrguer com queijos,champignon e rúcula | 12.70";
		}
		else if (pedido1.ToLower().Trim() == "provolone com salame")
		{
			pedido1 = "Provolone com salame | 19.70";
		}
		else if (pedido1.ToLower().Trim() == "vegetariano de berinjela")
		{
			pedido1 = "Vegetariano de berinjela | 28.22";
		}
		else if (pedido1.ToLower().Trim() == "calabresa")
		{
			pedido1 = "Calabresa | 8.98";
		}
		else if (pedido1.ToLower().Trim() == "napolitana")
		{
			pedido1 = "Napolitana | 0.42";
		}
		else if (pedido1.ToLower().Trim() == "peruana")
		{
			pedido1 = "Peruana | 18.36";
		}
		else if (pedido1.ToLower().Trim() == "portuguesa")
		{
			pedido1 = "Portuguesa | 27.50";
		}
		else
		{
			Console.WriteLine("Pedido 1 não encontrado ");
		}


		if (pedido2.ToLower().Trim() == "bolo brigadeiro")
		{
			pedido2 = "Bolo Brigadeiro | 29.50";
		}
		else if (pedido2.ToLower().Trim() == "bolo floresta negra")
		{
			pedido2 = "Bolo Floresta Negra | 2.00";
		}
		else if (pedido2.ToLower().Trim() == "bolo leite com nutella")
		{
			pedido2 = "Bolo Leite com Nutella | 29.23";
		}
		else if (pedido2.ToLower().Trim() == "bolo mousse de chocolate")
		{
			pedido2 = "Bolo Mousse de Chocolate | 7.10";
		}
		else if (pedido2.ToLower().Trim() == "bolo nega maluca")
		{
			pedido2 = "Bolo Nega Maluca | 19.33";
		}
		else if (pedido2.ToLower().Trim() == "bolo de creme")
		{
			pedido2 = "Bolo de Creme | 17.71";
		}
		else if (pedido2.ToLower().Trim() == "bolo de morango")
		{
			pedido2 = "Bolo de Morango | 4.82";
		}
		else if (pedido2.ToLower().Trim() == "filé-mignon com fritas e cheddar")
		{
			pedido2 = "Filé-Mignon com fritas e cheddar | 21.16";
		}
		else if (pedido2.ToLower().Trim() == "hambúrguer com queijos,champignon e rúcula")
		{
			pedido2 = "Hambúrguer com queijos,champignon e rúcula | 12.70";
		}
		else if (pedido2.ToLower().Trim() == "provolone com salame")
		{
			pedido2 = "Provolone com salame | 19.70";
		}
		else if (pedido2.ToLower().Trim() == "vegetariano de berinjela")
		{
			pedido2 = "Vegetariano de berinjela | 28.22";
		}
		else if (pedido2.ToLower().Trim() == "calabresa")
		{
			pedido2 = "Calabresa | 8.98";
		}
		else if (pedido2.ToLower().Trim() == "napolitana")
		{
			pedido2 = "Napolitana | 0.42";
		}
		else if (pedido2.ToLower().Trim() == "peruana")
		{
			pedido2 = "Peruana | 18.36";
		}
		else if (pedido2.ToLower().Trim() == "portuguesa")
		{
			pedido2 = "Portuguesa | 27.50";
		}
		else
		{
			Console.WriteLine("Pedido 2 não encontrado ");
		}


		if (pedido3.ToLower().Trim() == "bolo brigadeiro")
		{
			pedido3 = "Bolo Brigadeiro | 29.50";
		}
		else if (pedido3.ToLower().Trim() == "bolo floresta negra")
		{
			pedido3 = "Bolo Floresta Negra | 2.00";
		}
		else if (pedido3.ToLower().Trim() == "bolo leite com nutella")
		{
			pedido3 = "Bolo Leite com Nutella | 29.23";
		}
		else if (pedido3.ToLower().Trim() == "bolo mousse de chocolate")
		{
			pedido3 = "Bolo Mousse de Chocolate | 7.10";
		}
		else if (pedido3.ToLower().Trim() == "bolo nega maluca")
		{
			pedido3 = "Bolo Nega Maluca | 19.33";
		}
		else if (pedido3.ToLower().Trim() == "bolo de creme")
		{
			pedido3 = "Bolo de Creme | 17.71";
		}
		else if (pedido3.ToLower().Trim() == "bolo de morango")
		{
			pedido3 = "Bolo de Morango | 4.82";
		}
		else if (pedido3.ToLower().Trim() == "filé-mignon com fritas e cheddar")
		{
			pedido3 = "Filé-Mignon com fritas e cheddar | 21.16";
		}
		else if (pedido3.ToLower().Trim() == "hambúrguer com queijos,champignon e rúcula")
		{
			pedido3 = "Hambúrguer com queijos,champignon e rúcula | 12.70";
		}
		else if (pedido3.ToLower().Trim() == "provolone com salame")
		{
			pedido3 = "Provolone com salame | 19.70";
		}
		else if (pedido3.ToLower().Trim() == "vegetariano de berinjela")
		{
			pedido3 = "Vegetariano de berinjela | 28.22";
		}
		else if (pedido3.ToLower().Trim() == "calabresa")
		{
			pedido3 = "Calabresa | 8.98";
		}
		else if (pedido3.ToLower().Trim() == "napolitana")
		{
			pedido3 = "Napolitana | 0.42";
		}
		else if (pedido3.ToLower().Trim() == "peruana")
		{
			pedido3 = "Peruana | 18.36";
		}
		else if (pedido3.ToLower().Trim() == "portuguesa")
		{
			pedido3 = "Portuguesa | 27.50";
		}
		else
		{
			Console.WriteLine("Pedido 3 não encontrado ");
		}

		int indiceBarraVertical1 = pedido1.IndexOf("|");
		int indiceBarraVertical2 = pedido2.IndexOf("|");
		int indiceBarraVertical3 = pedido3.IndexOf("|");

		int indiceComecoPedido1 = indiceBarraVertical1 + 1;
		int indiceComecoPedido2 = indiceBarraVertical2 + 1;
		int indiceComecoPedido3 = indiceBarraVertical3 + 1;

		int tamanoPedido1 = pedido1.Length;
		int tamanhoValorPedido1 = tamanoPedido1 - indiceComecoPedido1;
		string valor1 = pedido1.Substring(indiceComecoPedido1, tamanhoValorPedido1);
		double valorPedido1 = Convert.ToDouble(valor1);
		valorPedido1 = valorPedido1 / 100;

		int tamanoPedido2 = pedido2.Length;
		int tamanhoValorPedido2 = tamanoPedido2 - indiceComecoPedido2;
		string valor2 = pedido2.Substring(indiceComecoPedido2, tamanhoValorPedido2);
		double valorPedido2 = Convert.ToDouble(valor2);
		valorPedido2 = valorPedido2 / 100;

		int tamanoPedido3 = pedido3.Length;
		int tamanhoValorPedido3 = tamanoPedido3 - indiceComecoPedido3;
		string valor3 = pedido3.Substring(indiceComecoPedido3, tamanhoValorPedido3);
		double valorPedido3 = Convert.ToDouble(valor3);
		valorPedido3 = valorPedido3 / 100;

		string nomePedido1 = pedido1.Substring(0, indiceBarraVertical1);
		string nomePedido2 = pedido2.Substring(0, indiceBarraVertical2);
		string nomePedido3 = pedido3.Substring(0, indiceBarraVertical3);

		double valorTotal = valorPedido1 + valorPedido2 + valorPedido3;

		Console.WriteLine("Pedido1: " + nomePedido1);
		Console.WriteLine("Pedido2: " + nomePedido2);
		Console.WriteLine("Pedido3: " + nomePedido3);

		Console.WriteLine("Valor pedido1: R$" + valorPedido1);
		Console.WriteLine("Valor pedido2: R$" + valorPedido2);
		Console.WriteLine("Valor pedido3: R$" + valorPedido3);

		Console.WriteLine("Valor total: R$" + valorTotal);
	}
}