namespace ControlFlowAndStuff
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            // Second Task, first part - (Refactor if statements):
            if (potato == null)
            {
                throw new ArgumentNullException();
            }

            if (carrot == null)
            {
                throw new ArgumentNullException();
            }

            if (bowl == null)
            {
                throw new ArgumentNullException();
            }

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
            carrot.IsPeeled = false;
            carrot.IsCut = false;
            carrot.IsRotten = false;

            return carrot;
        }
        private Potato GetPotato()
        {
            Potato sweetPotato = new Potato();

            sweetPotato.Type = "Samokovski";
            sweetPotato.IsPeeled = false;
            sweetPotato.IsCut = false;
            sweetPotato.IsRotten = false;

            return sweetPotato;
        }

        private void Cut(Vegetable vegetable)
        {
            if (!vegetable.IsCut)
            {
                vegetable.IsCut = true;
            }
        }
        
        private void Peel(Vegetable vegetable)
        {
            if (!vegetable.IsPeeled)
            {
                vegetable.IsPeeled = true;
            }
        }
    }
}
