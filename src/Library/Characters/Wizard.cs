using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : MagicHero
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
            : base(name) {
            this.AddItem(new Staff());
        }
    }
}