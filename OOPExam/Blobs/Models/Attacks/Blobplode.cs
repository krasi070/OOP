namespace Blobs.Models.Attacks
{
    using Interfaces;

    public class Blobplode : Attack
    {
        public override void ExecuteAttackCommand(IBlob attacker, IBlob target)
        {
            attacker.Health = attacker.Health % 2 == 0 ? attacker.Health / 2 : attacker.Health / 2 + 1;

            target.Health -= attacker.Damage * 2;
        }
    }
}
