namespace Factory
{
    public class FactoryMethod
    {
        public ICharacter ChooseCaracter(string character)
        {
            switch (character)
            {
                case "Liu Kang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
