using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
<<<<<<< HEAD
using add_itmes.Projectiles;
namespace add_itmes.Items
=======
using Terraria.DataStructures;
using amoxnero.Content.Projectiles;
namespace amoxnero.Content.Items
>>>>>>> d79e41375fb27edabb75bfaf990ace33b4833846
{
    public class AllFlames : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.DamageType = DamageClass.Magic;
            Item.width = 26;
            Item.height = 26;
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
            Item.scale = 0.8f;
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
<<<<<<< HEAD
}
}
=======
}}
>>>>>>> d79e41375fb27edabb75bfaf990ace33b4833846
