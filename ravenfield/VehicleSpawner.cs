public class VehicleSpawner: MonoBehaviour {
  private void Awake() {
    //game code
    if (this.respawnType != VehicleSpawner.RespawnType.Never) {
      this.respawnType = VehicleSpawner.RespawnType.AfterMoved;
    }
  }
  private void StartSpawnCountdown() {
    base.CancelInvoke();
    base.Invoke("SpawnVehicleWhenClear", this.spawnTime / 4f);
  }
}
