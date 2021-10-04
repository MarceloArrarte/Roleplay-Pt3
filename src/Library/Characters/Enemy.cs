namespace RoleplayGame {
    public class Enemy : Character {
        public int VictoryPointsValue;

        public Enemy(string nombre, int victoryPointsValue)
            : base(nombre) {
            this.VictoryPointsValue = victoryPointsValue;
        }
    }
}