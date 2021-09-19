public class Vehicle: MonoBehaviour {
  // unlimited flare
  public bool CountermeasuresAreReady() {
    return (this.HasDriver() && !this.Driver().aiControlled) || this.countermeasuresCooldownAction.TrueDone();
  }

}
