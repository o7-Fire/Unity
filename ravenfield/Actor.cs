public class Actor : Hurtable
{

	public virtual void Awake()
	{
		if (!this.aiControlled)
		{
			this.maxHealth = 20000f;
			this.health = 20000f;
		}
	}
  private void UpdateWeapon()
  {
  	if (!this.aiControlled)
		{
			this.activeWeapon.heat = 0f;
			this.activeWeapon.ammo = 999;
			this.activeWeapon.projectileSpeed = this.activeWeapon.projectileSpeed * 100f;
			this.activeWeapon.configuration.kickback = 0f;
			this.activeWeapon.configuration.cooldown = 0f;
		}
   }
}
