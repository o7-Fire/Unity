public class VehicleSpawner : MonoBehaviour{
    public bool HasAvailableVehicle(){
        return true;
    }
    private void StartSpawnCountdown(){
        base.CancelInvoke();
        base.Invoke("SpawnVehicleWhenClear", this.spawnTime / 4f);
    }
}