using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.States
{
    public class BuyAnimal : IState
    {
        private readonly ZooShopManager shop;

        public BuyAnimal(ZooShopManager shop)
        {
            this.shop = shop;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Destroy()
        {
            throw new NotImplementedException();
        }

    }
}