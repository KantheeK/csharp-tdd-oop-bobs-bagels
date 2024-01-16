﻿using exercise.main.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Inventory
    {
        public int skuu;
        public Dictionary<string,Product> inventory = new Dictionary<string,Product>();    
        private List<string> bagels = new List<string>() { 
           "Onion","Plain","Everything","Sesame"
        };
        private List<string> coffes = new List<string>() {
           "Black","White","Capuccino","Latte"
        };
        private List<string> fillings = new List<string>() {
           "Bacon","Egg","Cheese","Cream Cheese", "Smoked Salmon", "Ham"
        };

        public Inventory()
        {
            bagels.ForEach(bagelType => {
                Bagel bagel = new Bagel(bagelType);
                inventory.Add(bagel.SKU, new Product(bagel));
            } );

            coffes.ForEach(coffeType => {
                Coffe coffe = new Coffe(coffeType);
                inventory.Add(coffe.SKU, new Product(coffe));
            });

            fillings.ForEach(fillingType => {
                Filling filling = new Filling(fillingType);
                inventory.Add(filling.SKU, new Product(filling));
            });

        }

       
    }
}