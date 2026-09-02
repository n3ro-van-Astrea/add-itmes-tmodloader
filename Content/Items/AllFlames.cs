using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using add_itmes.Projectiles;
namespace add_itmes.Items
{
    public class AllFlames : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.DamageType = DamageClass.Magic;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 3;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Pink;
            Item.UseSound = SoundID.Item20;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<AllFlamesProjectile>();
Item.shootSpeed = 10f;
        }
 public override void SetStaticDefaults()
{
    Item.ResearchUnlockCount = 1;
}   
public override void AddRecipes()
{
    Recipe recipe = CreateRecipe();

    recipe.AddIngredient(ItemID.StoneBlock, 10);
    recipe.AddIngredient(ItemID.Wood, 15);
    recipe.AddIngredient(ItemID.DirtBlock, 20);

    recipe.AddTile(TileID.WorkBenches);

    recipe.Register();
}
}
}
