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
        //choosvash animal, ako i dostatychno pari kupuvash trygvash
        //eeventurallu buy and choose animal can be merged 
        //you can tip the seler if u have enough money kupuvash i sledva nextCustomer() otnovo na welcome
    }
}