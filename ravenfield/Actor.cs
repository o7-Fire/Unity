public class Actor: Hurtable {

  public virtual void Awake() {
    //Code...
    if (!this.aiControlled) { //Not An AI
      this.maxHealth = 20000 f; //Max Helth every respawn
      this.health = 20000 f; //Helth every respawn
    }
  }
  public virtual void Update() {
    if (!this.aiControlled && this.IsSeated()) {//Make sure inside a vehicle and not an AI
      Vehicle vehicle = this.seat.vehicle;
      if (vehicle != null) {
        vehicle.maxHealth = 1200 f;
        vehicle.health = 1000 f;//unlimited helth
      }
    }
    //Code... 
  }
  private void UpdateWeapon() {

    if (!this.aiControlled) { //If its not an AI
      this.activeWeapon.heat = 0 f; //No weapon cooldown
      this.activeWeapon.ammo = 999; //Literraly infinity because its do everytime
      this.activeWeapon.projectileSpeed = this.activeWeapon.projectileSpeed * 2 f; //speed also increase range
      this.activeWeapon.configuration.kickback = 0 f; //Recoil
      this.activeWeapon.configuration.cooldown = 0 f; //No Cooldown
    }
    //Code...
  }
}
