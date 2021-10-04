using System.Collections.Generic;

namespace RoleplayGame {
    public abstract class Character {
        private const int K_MaxHealth = 100;

        public string Name {get; set;}

        private int _health;
        public int Health {
            get {
                return this._health;
            }
            protected set {
                this._health = value >= 0 ? value : 0;
            }
        }

        private List<IItem> _items;

        protected Character(string name) {
            this.Name = name;
            this.Health = Character.K_MaxHealth;
            this._items = new List<IItem>();
        }

        public virtual int AttackValue {
            get {
                int value = 0;
                foreach (IItem item in this._items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public virtual int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this._items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this._items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this._items.Remove(item);
        }
    }
}