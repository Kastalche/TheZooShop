using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheZooShop.States
{
    public class ChooseAnimal : IState
    {
        private readonly ZooShopManager shop;
        public ChooseAnimal(ZooShopManager shop)
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