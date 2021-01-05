public class Actor: Hurtable {

  public virtual void Awake() {
    if (!this.aiControlled) {//Not An AI
      this.maxHealth = 20000f;//Max Helth every respawn
      this.health = 20000f;//Helth every respawn
    }
  }
  private void UpdateWeapon() {
    
    if (!this.aiControlled) {//If its not an AI
      this.activeWeapon.heat = 0f;//No weapon cooldown
      this.activeWeapon.ammo = 999;//Literraly infinity because its do everytime
      this.activeWeapon.projectileSpeed = this.activeWeapon.projectileSpeed * 2f;//speed also increase range
      this.activeWeapon.configuration.kickback = 0f;//Recoil
      this.activeWeapon.configuration.cooldown = 0f;//No Cooldown
    }
  }
}
