using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GStock {


    class Program  {

        
        static void Main(string[] args){   
 

                List<Produit> prod = new List<Produit>();

                Produit p1 = new Produit(1, "Tongs", 50,  "RAS");
                Produit p2 = new Produit(2, "Ballon",40, "RAS");
                Produit p3 = new Produit(3, "Maillot", 20, "RAS");
                Produit p4 = new Produit(4, "Seau", 9, "RAS" );
                Produit p5 = new Produit(5, "Pelle", 40, "RAS");
                Produit p6 = new Produit(6, "Sac", 20,"RAS");

                    // Add produits to the list.
                prod.Add(p1);  
                prod.Add(p2);
                prod.Add(p3);
                prod.Add(p4);
                prod.Add(p5);
                prod.Add(p6);

                Console.WriteLine();
                Console.WriteLine("..................................................................");
                Console.WriteLine("                AFFICHAGE DE L ETAT DU STOCK                      ");
                Console.WriteLine("..................................................................");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("..................................................................");
                Console.WriteLine("|      #       |  Produit      |      Stocks          |  Etat      |");
                Console.WriteLine("..................................................................");



            //Affichage des produits
            foreach(Produit p in prod)
            {
                
                Console.WriteLine(p);
                Console.WriteLine("..................................................................");


            }
       
         // Choix du produit a décrémenter.
        System.Console.WriteLine("Décrémenter le numero du produit a décrémenter de 1 et 6.");
        string number = Console.ReadKey().KeyChar.ToString();

        Console.WriteLine();

      
            if(Regex.IsMatch(number, @"^[0-9]+$"))
      {  
    
        int numero = Convert.ToInt32(number);
        

                        //Les opertations de decrementation des produits
                        switch (numero) 
                        {
                            case 1:
                            Console.WriteLine("Produit avec indice 1"); 

                                        p1.decrementerStock();
                                        /*prod.Where(Produit => Produit.nom == "Tongs").ToList()
                                        .ForEach(Produit => Produit.stock = p1.getStock());

                                         prod.Add(new Produit(p1.idProduit, p1.nom, p1.stock, p1.etat));
                            
                                         Console.WriteLine(String.Join(", ", prod));*/
                                        Console.WriteLine();
                                        Console.WriteLine(p1);
                                        Console.WriteLine();


                                        //Mettre à jour l'etat du stock
                                          if(p1.getStock() > 5){

                                                    p1.setEtat("Disponible");

                                                } else if ( p1.getStock() > 0 && p1.getStock() < 5)
                                                {
                                                    p1.setEtat("En réapprovisionnement");

                                                } else if(p1.getStock() == 0)
                                                {
                                                    p1.setEtat("En rupture");
                                                }
                                                                                                                                        

                            break;
                            case 2:
                            Console.WriteLine("Produit avec indice 2");             
                                        
                                        p2.decrementerStock();
                                        Console.WriteLine(p2);

                                        //Mettre à jour l'etat du stock
                                         if(p2.getStock() > 5){

                                                    p2.setEtat("Disponible");

                                                } else if ( p2.getStock() > 0 && p2.getStock() < 5)
                                                {
                                                    p2.setEtat("En réapprovisionnement");

                                                } else if(p2.getStock() == 0)
                                                {
                                                    p2.setEtat("En rupture");
                                                }
                              

                            break;
                            case 3:
                            Console.WriteLine("Produit avec indice 3");
              
                                        
                                        p3.decrementerStock();
                                        Console.WriteLine(p3);

                                        //Mettre à jour l'etat du stock
                                        if(p3.getStock() > 5){

                                                    p3.setEtat("Disponible");

                                                } else if ( p3.getStock() > 0 && p3.getStock() < 5)
                                                {
                                                    p3.setEtat("En réapprovisionnement");

                                                } else if(p3.getStock() == 0)
                                                {
                                                    p3.setEtat("En rupture");
                                                }
                                                                         
                            
                            break;
                            case 4:
                            Console.WriteLine("Produit avec indice 4");           
                                        
                                        p4.decrementerStock();
                                        Console.WriteLine(p4);

                                        //Mettre à jour l'etat du stock
                                         if(p4.getStock() > 5){

                                                    p4.setEtat("Disponible");

                                                } else if ( p4.getStock() > 0 && p4.getStock() < 5)
                                                {
                                                    p4.setEtat("En réapprovisionnement");

                                                } else if(p4.getStock() == 0)
                                                {
                                                    p4.setEtat("En rupture");
                                                }

                            break;
                            case 5:
                            Console.WriteLine("Produit avec indice 5");            
                                        
                                        p5.decrementerStock();
                                        Console.WriteLine(p5);

                                        //Mettre à jour l'etat du stock
                                        if(p5.getStock() > 5){

                                                    p5.setEtat("Disponible");

                                                } else if ( p5.getStock() > 0 && p5.getStock() < 5)
                                                {
                                                    p5.setEtat("En réapprovisionnement");

                                                } else if(p5.getStock() == 0)
                                                {
                                                    p5.setEtat("En rupture");
                                                }
                                  

                            break;
                            case 6:
                            Console.WriteLine("Produit avec indice 6");
                            
                                        p6.decrementerStock();
                                        Console.WriteLine(p6);

                                        //Mettre à jour l'etat du stock
                                        if(p6.getStock() > 5){

                                                    p6.setEtat("Disponible");

                                                } else if ( p6.getStock() > 0 && p6.getStock() < 5)
                                                {
                                                    p6.setEtat("En réapprovisionnement");

                                                } else if(p6.getStock() == 0)
                                                {
                                                    p6.setEtat("En rupture");
                                                }
                                   
                            break;

                        } 

          
                      }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un nombre.");
                            }
                
            }

           
        }

    }
