using terraria;
using terraria.ID;
using terraria.ModLoader;
namespace add_itmes.Items
{
    public class sword : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 12
            Item.useTime = 60
            Item.knockBack = 0f;
            Item.shoot = ModContent.ProjectileType<SwordLaser>();
            Item.ShootSpeed = 10f;
            Item.width = 40;
            Item.height = 40;
            Item.useAnimation = 60;
            Item.noMelee = true;
            Item.DamageType = DamageClass.Melee;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = 10000;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Diamond, 3);
            recipe.AddIngredient(ItemID.ManaCrystal, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}

        



