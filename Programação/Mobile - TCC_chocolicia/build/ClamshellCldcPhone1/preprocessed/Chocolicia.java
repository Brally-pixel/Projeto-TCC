import javax.microedition.lcdui.*;
import javax.microedition.midlet.MIDlet;


public class Chocolicia extends MIDlet {

   Display tela;
	//Alert entrada;
	Form formPrincipal, formProdutos, formParceiros, formInfo, formDescProd, formCartao;
	Command cmdSair, cmdExibir, cmdVoltar, cmdProdutos, cmdInfo, cmdParceiros, cmdCartao;
	ChoiceGroup grupo1;
	public Image img1, img2, img3, img4, img5, img6, img7, img8, img9;


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
		grupo1.append("Trufas", null);
		grupo1.append("Tortas com Chocolate",null);
		grupo1.append("Cupcakes",null);
		grupo1.append("Água",null);
                grupo1.append("Bebidas quentes",null);
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
			img1 = Image.createImage("/Fundo.png");
			
            }
                        catch (Exception e) {

			e.printStackTrace();
                        formProdutos.append(new ImageItem("", img1, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formProdutos);
		}

                //Adição das Imagens
			formPrincipal.append(new ImageItem("", img1, Item.LAYOUT_CENTER, null));
			formProdutos.append(new ImageItem("", img2, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img3, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img4, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img5, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img6, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img7, Item.LAYOUT_CENTER, null));
                        formProdutos.append(new ImageItem("", img8, Item.LAYOUT_CENTER, null));
		        formCartao.append(new ImageItem("", img9,Item.LAYOUT_CENTER, null));


		// Adição das Imagens
		formCartao.append("Trabalhamos com os seguintes cartões:");
                
                 try {
			img2 = Image.createImage("/cartoes.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
                        
                        
                        
		}
                 formCartao.append(new ImageItem("", img2, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formCartao);
						


                
		formInfo.append("Endereço: Av: João Rodrigues" + "\n");
		formInfo.append("Telefone: 4135-6287" + "\n");
		formInfo.append("Celular: 9.7867-4238" + "\n");							
                formInfo.append(" www.chocolicia.com.br" + "\n");                                                   
				
									
                
                
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
                                        formDescProd.append("Valor: 3,50 R$" + "\n");
					formDescProd.append("Chocolate meio amargo" + "\n");
					formDescProd.append("Chocolate branco e preto" + "\n");
					formDescProd.append("Chocolate ao leite" + "\n");

                  try {
			img3 = Image.createImage("/Chocolates.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}

                formDescProd.append(new ImageItem("", img3, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;

					case 1:
						formDescProd.deleteAll();
                                                formDescProd.append("Valor: 2,50 R$" + "\n");
						formDescProd.append("Morango" + "\n");
						formDescProd.append("Maracujá" + "\n");
						formDescProd.append("Limão" + "\n");
						formDescProd.append("Uva" + "\n");
						tela.setCurrent(formDescProd);
                                                
                                                try {
			img4 = Image.createImage("/Bombom com licor.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img4, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;
						

					case 2:
						formDescProd.deleteAll();
                                                formDescProd.append("Valor: 2,00 R$" + "\n");
						formDescProd.append("Trufa de Brigadeiro" + "\n");
						formDescProd.append("Trufa de Maracujá" + "\n");
						formDescProd.append("Trufa de Abacaxi" + "\n");
						formDescProd.append("Trufa de Tradicional" + "\n");
						tela.setCurrent(formDescProd);
						 try {
			img5 = Image.createImage("/Trufas.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img5, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;

					case 3:
						formDescProd.deleteAll();
                                                formDescProd.append("Valor: 10,00 R$" + "\n");
						formDescProd.append("Torta de Chocolate" + "\n");
						formDescProd.append("Torta de Chocolate com Maracujá " + "\n");
						formDescProd.append("Torta de Chocolate com Morango " + "\n");
						formDescProd.append("Torta de Chocolate Branco " + "\n");
						tela.setCurrent(formDescProd);
						 try {
			img6 = Image.createImage("/Tortas.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img6, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;


					case 4:
						formDescProd.deleteAll();
                                                formDescProd.append("Valor: 7,00 R$" + "\n");
						formDescProd.append(" Recheio de Morango" + "\n");
						formDescProd.append(" Abacaxi " + "\n");
						formDescProd.append(" Chocolate Tradicional " + "\n");
						formDescProd.append(" Maracujá " + "\n");
						tela.setCurrent(formDescProd);
						 try {
			img7 = Image.createImage("/Cupcakes.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img7, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;


					case 5:
						formDescProd.deleteAll();
						formDescProd.append("Nós trabalhamos com as seguintes bebidas:" + "\n" +
											"" + "\n" +
											"* Água" + "\n" +
											"     => 500 ml" + "\n" +
                                                                                        "     Valor: 2,00 R$" + "\n" +
											"     => Copo (250ml)" + "\n" +
                                                                                        "     Valor: 1,50 R$" + "\n" +
											"" + "\n" 
											
											);
                                                 try {
			img8 = Image.createImage("/garrafa.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img8, Item.LAYOUT_CENTER, null));

						tela.setCurrent(formDescProd);
						break;

                                            case 6:
						formDescProd.deleteAll();
						formDescProd.append("Nós trabalhamos com as seguintes bebidas:" + "\n" +
	
											"* Bebidas Quentes" + "\n" +
											"     => Café" + "\n" +
                                                                                        "     Valor: 3,00 R$" + "\n" +
											"     => Chocolate Quente" + "\n" +
                                                                                        "     Valor: 3,50" + "\n" +
											"     => Cappuccino" + "\n" +
                                                                                        "     Valor: 4,00 R$" + "\n" +
											"" + "\n"

											);
                                                 try {
			img9 = Image.createImage("/Cappuccino.png");
            }
                        catch (Exception e) {

			e.printStackTrace();
		}
                                              

                formDescProd.append(new ImageItem("", img9, Item.LAYOUT_CENTER, null));

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
