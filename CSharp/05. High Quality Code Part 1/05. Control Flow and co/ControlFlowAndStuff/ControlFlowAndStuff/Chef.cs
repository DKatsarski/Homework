namespace ControlFlowAndStuff
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();

            bowl.SizeInMl = 500;

            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();

            carrot.CountryOfOrigin = "Bulgarian";
            carrot.isPeeled = false;
            carrot.isCut = false;

            return carrot;
        }
        private Potato GetPotato()
        {
            Potato sweetPotato = new Potato();

            sweetPotato.Type = "Samokovski";
            sweetPotato.isPeeled = false;
            sweetPotato.isCut = false;

            return sweetPotato;
        }

        private void Cut(Vegetable vegetable)
        {
            if (!vegetable.isCut)
            {
                vegetable.isCut = true;
            }
        }
        
        private void Peel(Vegetable vegetable)
        {
            if (!vegetable.isPeeled)
            {
                vegetable.isPeeled = true;
            }
        }
    }
}
