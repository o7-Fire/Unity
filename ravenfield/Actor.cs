public class Actor: Hurtable {

  public virtual void Awake() {
    //Code...
    if (!this.aiControlled) { //Not An AI
      this.maxHealth = 20000 f; //Max Helth every respawn
      this.health = 20000 f; //Helth every respawn
    }
  }
  public void SwitchWeapon(int slot) {
    //Code....
    if (this.aiControlled) {
      return;
    }
    float speedMultiplier = 2f; //change speed here
    //no need to edit this
    if (this.activeWeapon.configuration.projectilePrefab != null) this.activeWeapon.projectileSpeed = this.activeWeapon.configuration.projectilePrefab.GetComponent < Projectile > ().configuration.speed * this.speedMultiplier;
    else this.activeWeapon.projectileSpeed = 100 f * this.speedMultiplier;
  }
  public virtual void Update() {
    if (!this.aiControlled && this.IsSeated()) { //Make sure inside a vehicle and not an AI
      Vehicle vehicle = this.seat.vehicle;
      if (vehicle != null) {
        vehicle.maxHealth = 20000 f; //Max
        vehicle.health = 15000 f; //Current
        vehicle.canBeRepairedAfterDeath = true; // revive
        vehicle.Repair(10000 f); //auto repair
      }
    }
    //Code... 
  }
  private void UpdateWeapon() {

    if (!this.aiControlled) { //If its not an AI
      this.activeWeapon.heat = 0 f; //No weapon cooldown
      this.activeWeapon.ammo = 9999; //Literraly infinity because its do everytime
      this.activeWeapon.configuration.kickback = 0 f; //Recoil
      this.activeWeapon.configuration.cooldown = 0 f; //No Cooldown
      this.activeWeapon.configuration.applyHeat = false; //no cooldown
      this.activeWeapon.configuration.useChargeTime = false; //no charge time ?
    }
    //Code...
  }
}
