public class Actor: Hurtable {

  public virtual void Awake() {
    //Code...
    if (!this.aiControlled) { //Not An AI
      this.maxHealth = 20000f; //Max Helth every respawn
      this.health = 20000f; //Helth every respawn
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
    else this.activeWeapon.projectileSpeed = 100f * this.speedMultiplier;
    if (IsSeated()) //if in a vehicle
      activeWeapon.configuration.projectilesPerShot = 4; //current weapon
  }
  public virtual void Update() {
    if (!this.aiControlled && this.IsSeated()) { //Make sure inside a vehicle and not an AI
      Vehicle vehicle = this.seat.vehicle;
      if (vehicle != null) {
        vehicle.maxHealth = 20000f; //Max
        vehicle.health = 15000f; //Current
        vehicle.canBeRepairedAfterDeath = true; // revive
        vehicle.Repair(10000f); //auto repair
      }
    }
    if ((this.parachuteDeployed && this.parachuteDeployAction.TrueDone() && this.fallenOver) || (!this.aiControlled && this.fallenOver)) {
      this.InstantGetUpAtPosition(this.ragdoll.Position());
    }
    //Code... 
  }
  private void UpdateWeapon() {

    if (!this.aiControlled || (this.IsSeated() && this.seat.HasActiveWeaponNonHorn())) { //If its not an AI
      this.activeWeapon.heat = 0f; //No weapon cooldown
      this.activeWeapon.ammo = 9999; //infinity because it refresh everytime
      //this.activeWeapon.configuration.kickback = 0f; //Recoil
      this.activeWeapon.configuration.cooldown = 0f; //No Cooldown
      this.activeWeapon.configuration.applyHeat = false; //no cooldown
      //this.activeWeapon.configuration.useChargeTime = false; //no charge time ?, what is this
    }
    //Code...
  }

}
