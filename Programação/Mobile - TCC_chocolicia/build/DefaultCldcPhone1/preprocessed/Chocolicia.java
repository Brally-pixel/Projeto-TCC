import javax.microedition.lcdui.*;
import javax.microedition.midlet.MIDlet;


public class Chocolicia extends MIDlet {

   Display tela;
	//Alert entrada;
	Form formPrincipal, formProdutos, formParceiros, formInfo, formDescProd, formCartao;
	Command cmdSair, cmdExibir, cmdVoltar, cmdProdutos, cmdInfo, cmdParceiros, cmdCartao;
	ChoiceGroup grupo1;
	public Image img1, img2, img3;


	public Chocolicia () {
		// Display
		tela = Display.getDisplay(this);

		// Alerta de Entrada
		//entrada = new Alert("Entrada","",null,AlertType.INFO);
		//entrada.setTimeout(2000);

		// Formulários
		formPrincipal = new Form ("Chocolícia");
		formProdutos = new Form ("Chocolícia - Produtos");
		formInfo = new Form ("Chocolícia - Informações");
		formDescProd = new Form ("Chocolícia - Nossos Produtos");
		formCartao = new Form ("Chocolícia - Cartões");

		// Botões
		cmdSair = new Command("Sair", Command.EXIT, 0);
		cmdExibir = new Command("Exibir", Command.OK, 1);
		cmdVoltar = new Command("Voltar", Command.BACK, 1);
		cmdProdutos = new Command("Produtos", Command.ITEM, 2);
		cmdInfo = new Command("Informações", Command.ITEM, 2);
		cmdCartao = new Command("Cartões", Command.ITEM, 2);

		// Opções
		grupo1 = new ChoiceGroup("Opções", Choice.EXCLUSIVE);
		grupo1.append(" Chocolates", null);
		grupo1.append("Bombom com Licor", null);
		grupo1.append("Trufa", null);
		grupo1.append("Tortas com Chocolate",null);
		grupo1.append("Cupcakes",null);
		grupo1.append("Bebidas",null);
		grupo1.setSelectedIndex(0, true);

		// Adição dos botões
		formPrincipal.addCommand(cmdSair);
		formPrincipal.addCommand(cmdProdutos);
		formPrincipal.addCommand(cmdCartao);
		formPrincipal.addCommand(cmdInfo);
		formProdutos.addCommand(cmdVoltar);
		formProdutos.addCommand(cmdExibir);
		formInfo.addCommand(cmdVoltar);
		formDescProd.addCommand(cmdVoltar);
		formCartao.addCommand(cmdVoltar);

		formProdutos.append(grupo1);

		// Imagens
			try {
			img1 = Image.createImage("/Bombom com licor.png");
			
            }
                        catch (Exception e) {

			e.printStackTrace();
		}

                //Adição das Imagens
			formPrincipal.append(new ImageItem("", img1, Item.LAYOUT_CENTER, null));
			formProdutos.append(new ImageItem("", img2, Item.LAYOUT_CENTER, null));
		        formProdutos.append(new ImageItem("", img3, Item.LAYOUT_CENTER, null));


		// Adição das Imagens
		formCartao.append("Trabalhamos com os seguintes cartões:");
                
                 try {
			img2 = Image.createImage("/cartoes.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}

                
		formInfo.append(" ");


		// Ações dos botões
		formPrincipal.setCommandListener(new CommandListener() {
			public void commandAction(Command c, Displayable d) {
				if (cmdProdutos == c) {
					tela.setCurrent(formProdutos);
				}
				if (cmdCartao == c) {
					tela.setCurrent(formCartao);

				}
				if (cmdInfo == c) {
						tela.setCurrent(formInfo);
				}

				if (cmdSair == c) {
					destroyApp(true);
					notifyDestroyed();
				}
			}
		});
		formProdutos.setCommandListener(new CommandListener() {
			public void commandAction(Command c, Displayable d) {

				if(cmdExibir == c) {
					switch (grupo1.getSelectedIndex()) {

					case 0:
					formDescProd.deleteAll();
					formDescProd.append("Chocolate meio amargo" + "\n");
					formDescProd.append("Chocolate branco e preto" + "\n");
					formDescProd.append("Chocolate branco com pistache" + "\n");
					formDescProd.append("Chocolate ao leite" + "\n");

                  try {
			img2 = Image.createImage("/Chocolates.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}

                formDescProd.append(new ImageItem("", img2, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;

					case 1:
						formDescProd.deleteAll();
						formDescProd.append("Morango" + "\n");
						formDescProd.append("Maracujá" + "\n");
						formDescProd.append("Limão" + "\n");
						formDescProd.append("Uva" + "\n");
						tela.setCurrent(formDescProd);
						break;

					case 2:
						formDescProd.deleteAll();
						formDescProd.append("Trufa de Brigadeiro" + "\n");
						formDescProd.append("Trufa de Maracujá" + "\n");
						formDescProd.append("Trufa de Abacaxi" + "\n");
						formDescProd.append("Trufa de Tradicional" + "\n");
						tela.setCurrent(formDescProd);
						break;

					case 3:
						formDescProd.deleteAll();
						formDescProd.append("Torta de Chocolate" + "\n");
						formDescProd.append("Torta de Chocolate com Maracujá " + "\n");
						formDescProd.append("Torta de Chocolate com Morango " + "\n");
						formDescProd.append("Torta de Chocolate Branco " + "\n");
						tela.setCurrent(formDescProd);
						break;

					case 4:
						formDescProd.deleteAll();
						formDescProd.append(" Recheio de Morango" + "\n");
						formDescProd.append(" Abacaxi " + "\n");
						formDescProd.append(" Chocolate Tradicional " + "\n");
						formDescProd.append(" Maracujá " + "\n");
						tela.setCurrent(formDescProd);
						break;

					case 5:
						formDescProd.deleteAll();
						formDescProd.append("Nós trabalhamos com as seguintes bebidas:" + "\n" +
											"-----------------------------------------------------------------" + "\n" +
											"* Água" + "\n" +
											"     => 500 ml" + "\n" +
											"     => Copo (250ml)" + "\n" +
											"-----------------------------------------------------------------" + "\n" +
											"* Bebidas Quentes" + "\n" +
											"     => Café" + "\n" +
											"     => Chocolate Quente" + "\n" +
											"     => Cappuccino" + "\n" +
											"-----------------------------------------------------------------" + "\n"

											);
						tela.setCurrent(formDescProd);
						break;
					}
				}
				if (cmdVoltar== c) {
					tela.setCurrent(formPrincipal);
				}

			}
		});
		formInfo.setCommandListener(new CommandListener() {
			public void commandAction(Command c, Displayable d) {
				if (cmdVoltar== c) {
					tela.setCurrent(formPrincipal);
				}
			}
		});
		formDescProd.setCommandListener(new CommandListener() {
			public void commandAction(Command c, Displayable d) {
				if (cmdVoltar== c) {
					tela.setCurrent(formProdutos);
				}
			}
		});
		formCartao.setCommandListener(new CommandListener() {
			public void commandAction(Command c, Displayable d) {
				if (cmdVoltar== c) {
					tela.setCurrent(formPrincipal);
				}
			}
		});
		}
	protected void destroyApp(boolean arg0) {
	}
	protected void pauseApp() {
	}
	protected void startApp() {
		tela.setCurrent(formPrincipal);
                //tela.setCurrent(entrada,formPrincipal);
	}
        }
