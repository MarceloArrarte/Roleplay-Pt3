using System.Collections.Generic;
using System.Linq;
using System;

namespace RoleplayGame {
    public class Encounter {
        public List<Hero> Heroes {get; private set;}
        public List<Enemy> Enemies {get; private set;}

        public Encounter(List<Hero> heroes, List<Enemy> enemies) {
            this.Heroes = heroes;
            this.Enemies = enemies;
        }

        public void DoEncounter() {
            if (this.Heroes.Count == 0) {
                Console.WriteLine("Debe haber al menos un héroe en el encuentro.");
                return;
            }
            if (this.Enemies.Count == 0) {
                Console.WriteLine("Debe haber al menos un enemigo en el encuentro.");
                return;
            }

            while (this.Heroes.Count > 0 && this.Enemies.Count > 0) {
                for (int i = 0; i < this.Enemies.Count; i++) {
                    Enemy attackingEnemy = this.Enemies[i];
                    int targetHeroIndex = i % Heroes.Count;
                    this.Heroes[targetHeroIndex].ReceiveAttack(attackingEnemy.AttackValue);
                }

                foreach (Hero hero in this.Heroes) {
                    foreach (Enemy enemy in this.Enemies) {
                        if (enemy.Health > 0) {
                            enemy.ReceiveAttack(hero.AttackValue);
                            if (enemy.Health == 0) {
                                hero.ObtainVictoryPoints(enemy);
                            }
                        }
                    }
                }
            }

            foreach (Hero hero in this.Heroes) {
                hero.AfterBattleRecovery();
            }
        }
    }
}