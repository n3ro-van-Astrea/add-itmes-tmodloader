using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace amoxnero.Content.Items
{
    public class daun : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 6;
            Item.value = Item.buyPrice(silver: 1);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;

            Item.scale = 2.0f;
        }

        // Эффект частиц во время замаха
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            // Каждые 2 из 3 кадров создаем огонь по траектории взмаха
            if (Main.rand.NextBool(2, 3))
                {
                    // Выбираем тип: с вероятностью 50% это огненный (Torch), иначе ледяной (IceTorch)
                    int dustType = Main.rand.NextBool() ? DustID.Torch : DustID.IceTorch;

                    // Передаем параметры: Vector2, Width, Height, Type, SpeedX, SpeedY, Alpha, Color, Scale
                    Dust.NewDust(
                        new Vector2(hitbox.X, hitbox.Y),
                        hitbox.Width,
                        hitbox.Height,
                        dustType,
                        0f, 0f,           // Скорость X и Y
                        100,              // Прозрачность Alpha
                        default,          // Цвет оттенка (default)
                        2.0f              // Scale: размер в 2 раза больше
                    );
                }
        }

        // Эффект при попадании по мобу
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            // Вешаем горение на 3 секунды (180 кадров)
            target.AddBuff(BuffID.Frostburn, 180);

            // Создаем всплеск из 12 разлетающихся искр при ударе
            for (int i = 0; i < 12; i++)
            {
                int dustIndex = Dust.NewDust(target.position, target.width, target.height, DustID.Torch, 0f, 0f, 100, default, 1.8f);
                Main.dust[dustIndex].velocity *= 1.4f; // Увеличиваем скорость разлета
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
