namespace GStock {

    class Produit
    {
        
        //nom du produit
        public string nom {

              get; 
                set;
        }

        // quantite de stock du produit
        public int stock;

          public int getStock() {
                
                    return stock;

        }

      

        //etat du stock des produits (Disponible, en  réapprovisionnement, en rupture)
        public string etat {

                get; 
                set;
        }

        public void setEtat (string etat){

            this.etat = etat;
        }

        public int idProduit {

                get; 
                set;
        }

        // Fonction permettant l'affichage du stock
        override
        public string ToString() => " |     " + idProduit + "     |   " + nom + "     |          " + stock + "            |    " + etat;

        // Fonction permettant de décrémenter les stocks
        public void decrementerStock(){
            /*
            if (valeur > stock)
            {
                Console.WriteLine();
                Console.WriteLine("Stock insuffisant pour decrementer le stcok");
                Console.WriteLine();


            }  else */

            this.stock = stock - 1;

            //Mettre à jour l'état du stock
           /* if (this.stock > 5)
            {
                Console.WriteLine("Disponible");

            }  else if (this.stock  == 1 && this.stock < 5) {

                Console.WriteLine("Réapprovisionnement");

            } else if(this.stock == 0) {

            Console.WriteLine("En rupture");
            
            }*/
            
        }

        // Mettre l etat a jour l etat du stock

        public Produit (int idProduit, string nom, int stock, string etat){

            this.idProduit = idProduit;
            this.nom = nom;
            this.stock = stock;
            this.etat = etat;

        }

    }
}