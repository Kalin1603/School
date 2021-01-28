namespace Farm
{
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meowwww";
        }
    }
}
