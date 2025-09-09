using System;

public class Item
{
    public string nome;
    public int id;

    public class Pedido
    {
        private Item item;

        public Pedido()
        {
            item = new Item();
            item.nome = "Banana";
            item.id = 321123;
        }
    }



}
