namespace InterfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFighter> listFighters = new List<IFighter>();
            
            Fighter fighter1 = new Fighter();
            Commander commander1 = new Commander();
            listFighters.Add(fighter1);
            foreach (var fighter in listFighters)
            {
                fighter.canAttack();
            }
        }
    }
}