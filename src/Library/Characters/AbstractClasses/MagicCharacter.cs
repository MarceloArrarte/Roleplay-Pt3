using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter : Character
    {
        private List<IMagicalItem> _magicalItems;

        protected MagicCharacter(string name)
            : base(name) {
            this._magicalItems = new List<IMagicalItem>();
        }

        public override int AttackValue {
            get {
                int value = base.AttackValue;
                foreach (IMagicalItem item in this._magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue {
            get {
                int value = base.DefenseValue;
                foreach (IMagicalItem item in this._magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void AddItem(IMagicalItem item)
        {
            this._magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this._magicalItems.Remove(item);
        }
    }
}
