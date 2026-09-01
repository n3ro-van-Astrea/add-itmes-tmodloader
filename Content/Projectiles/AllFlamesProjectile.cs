using Terraria;
using Terraria.ModLoader;

namespace add_itmes.Projectiles
{
    public class AllFlamesProjectile : ModProjectile
    {
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
{
    target.AddBuff(BuffID.OnFire, 100);
target.AddBuff(BuffID.CursedInferno, 100);
target.AddBuff(BuffID.Frostburn, 100);
target.AddBuff(BuffID.ShadowFlame, 100);
}
        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 300;
            
        }
    }
}

