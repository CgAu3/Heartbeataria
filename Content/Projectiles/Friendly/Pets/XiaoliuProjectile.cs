using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace XDContentMod.Content.Projectiles.Friendly.Pets 
{
    public class XiaoliuProjectile : ConsolariaPet
	{
        public override int maxFrames => 15;

        public override void SetStaticDefaults () 
		{
            ProjectileID.Sets.TrailCacheLength [Projectile.type] = 12;
            ProjectileID.Sets.TrailingMode [Projectile.type] = 0;

            base.SetStaticDefaults();
        }

        public override void SetDefaults () 
		{
            int width = 36; int height = 44;
            Projectile.Size = new Vector2(width, height);

            DrawOffsetX -= 6;

            base.SetDefaults();
        }

        public override void AI () 
		{
            Player player = Main.player [Projectile.owner];
            if (!player.dead && player.HasBuff(ModContent.BuffType<Content.Buffs.XiaoliuBuff>()))
                Projectile.timeLeft = 2;

            WalkerAI();
            PassiveAnimation(idleFrame: 0, jumpFrame: 3);
            int finalFrame = maxFrames - 5;
            WalkingAnimation(walkingAnimationSpeed: 3, walkingFirstFrame: 1, finalFrame);
            FlyingAnimation(flyingAnimationSpeed: 3, flyingFirstFrame: 11, flyingLastFrame: 14);

            if (isFlying) 
			{
                Projectile.rotation = Projectile.velocity.ToRotation() + (float) Math.PI / 2;
                int dust = Dust.NewDust(new Vector2(Projectile.Center.X, Projectile.Center.Y) + new Vector2(0, 16).RotatedBy(Projectile.rotation), 0, 0, DustID.Cloud, 0, 0, 50, default, 1.4f);
                Main.dust [dust].velocity = Vector2.Zero;
                Main.dust [dust].noGravity = true;
                Main.dust [dust].noLight = true;
            }
        }
    }
}