using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace amoxnero.Content.Projectiles
{
    public class AllFlamesProjectile : ModProjectile
    {
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
{
    target.AddBuff(BuffID.OnFire, 60);
    target.AddBuff(BuffID.CursedInferno, 60);
    target.AddBuff(BuffID.Frostburn, 60);
    target.AddBuff(BuffID.ShadowFlame, 60);
}
        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 900;
            
        }
    }
}

