public class Exercice3Controller : Exercice2Controller {
    public override void TakeDamage() {
        if (_animator!=null)_animator.SetTrigger("TakeDamage");
        base.TakeDamage();
    }
}