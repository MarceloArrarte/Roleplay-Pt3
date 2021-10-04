namespace RoleplayGame
{
    public abstract class Hero : Character {
        public int _totalVictoryPoints;
        public int VictoryPoints {
            get { return this._totalVictoryPoints;}
            set {
                this._currentBattleVictoryPoints += value - this._totalVictoryPoints;
                this._totalVictoryPoints = value;
            }
        }

        private int _currentBattleVictoryPoints;

        public Hero(string nombre)
            : base(nombre) {
            this._totalVictoryPoints = 0;
            this._currentBattleVictoryPoints = 0;
        }

        public void ObtainVictoryPoints(Enemy defeatedEnemy) {
            this.VictoryPoints += defeatedEnemy.VictoryPointsValue;
        }

        public void AfterBattleRecovery() {
            if (this._currentBattleVictoryPoints >= 5) {
                this.Cure();
            }
            this._currentBattleVictoryPoints = 0;
        }
    }
}