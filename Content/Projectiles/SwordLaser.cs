using terraria;
using Terraria.ID;
using terraria.ModLoader;
using Terraria.Audio;
using Terraria.DataStructures;
namespace add_itmes.Projectiles
{
    public class SwordLaser : ModProjectile
    {
        public override void SetDefaults()
        {
        Projectile.damage = 12;
        Projectile.width = 30;
        Projectile.height = 150;
        Projectile.knockBack = 0f;
        Projectile.friendly = true;
        Projectile.timeLeft = 60;
        Projectile.hostile = false;
        Projectile.DamageType = DamageClass.Melee;
        Projectile.penetrate = 1;
        Projectile.tileCollide = true;
        Projectile.aiStyle = 0;
    }
    public override void AI()
    {
        Projectile.rotation = Projectile.velocity.ToRotation();
        Projectile.scale = 1f;
        Projectile.rotation += MathHelper.PiOver2;
    }
    public override bool PreDraw(ref Color LightColor)
    {
        LightColor = Color.White;
        Texture2D texture = Terraria.GameContent.textureAssets.Projectile[Type].Value;
        return true;
    }
        public override void OnSpawn(IEntitySource source)
        {
            SoundEngine.PlaySound(SoundID.Item12);
        }
    }
}






