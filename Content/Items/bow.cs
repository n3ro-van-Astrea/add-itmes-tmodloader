using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace amoxnero.Content.Items
{
    public class bow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 32;

            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;

            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.knockBack = 2;
            Item.value = Item.buyPrice(silver: 5);
            Item.rare = ItemRarityID.White;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;

            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 8f;
            Item.useAmmo = AmmoID.Arrow;
        }

        // Этот метод меняет характеристики выстрела перед изменением патронов
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            // Если игрок стреляет обычной деревянной стрелой
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                // Заменяем ее на огненную стрелу
                type = ProjectileID.FireArrow;
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
