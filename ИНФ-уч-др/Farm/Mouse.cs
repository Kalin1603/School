namespace Farm
{
    using System;

    public class Mouse : Mammal
    {
        public override string Eat(Food food)
        {
            throw new NotImplementedException();
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }
    }
}
