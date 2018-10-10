using static SimonBase.SimonForm;

namespace AED_SimonTest
{
    internal class Item
    {
        public Item next;
        public Botao botao;

        public Item(Botao botao)
        {
            this.botao = botao;
        }
    }
}