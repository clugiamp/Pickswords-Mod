using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace PickswordsModByClugiamp.Projectiles
{
    //Function made by Lynx, all credits goes to him
    public class SpinningWeaponProjectileOri : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Size = new Vector2(80);
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.melee = true;
        }

        public override void AI()
        {
            // Set some variables
            float num = 50f;//manage rotation speed
            float num2 = 2f;//manage rotation speed
            float quarterPi = -(float)Math.PI / 4f;
            float scaleFactor = 20f;
            // Get the current player
            Player player = Main.player[projectile.owner];
            // Get the Relative Point to player
            Vector2 relativePoint = player.RotatedRelativePoint(player.MountedCenter);
            // Check if Player Dead
            if (player.dead)
            {
                projectile.Kill();
                return;
            }
            // Handle Lighting Effects
            Lighting.AddLight(player.Center, 0.75f, 0.2f, 0.3f);
            // Get the Sign of Velocity X
            int sign = Math.Sign(projectile.velocity.X);
            // Ensure that the Y velocity is zero;
            projectile.velocity = new Vector2(sign, 0f);
            // Set Rotation at start of AI
            if(projectile.ai[0] == 0f)
            {
                projectile.rotation = new Vector2(sign, 0 - player.gravDir).ToRotation() + quarterPi + (float)Math.PI;
                // Reverse Direction is less than 0
                if(projectile.velocity.X < 0f)
                {
                    projectile.rotation -= (float)Math.PI / 2f;
                }
            }
            // Increase AI
            projectile.ai[0] += 1f;
            // Rotate Projectile
            projectile.rotation += (float)Math.PI * 2f * num2 / num * (float)sign;
            // Check if a rotation is done
            bool isDone = projectile.ai[0] == (num / 2f);
            // Check if projectile is done with its rotations
            if(projectile.ai[0] >= num || (isDone && !player.controlUseItem))
            {
                // Destroy Projectile
                projectile.Kill();
                // Reset the reuse delay ready for the next cycle
                player.reuseDelay = 2;
            } else if(isDone) // Check if we are done
            {
                // Get position of cursor
                Vector2 mouseWorld = Main.MouseWorld;
                // Check direction  towards cursor
                int dir = (player.DirectionTo(mouseWorld).X > 0f) ? 1 : -1;
                // Flip everything if direction is not same as player direction
                if((float)dir != projectile.velocity.X)
                {
                    player.ChangeDir(dir);
                    projectile.velocity = new Vector2(dir, 0f);
                    projectile.netUpdate = true;
                    projectile.rotation -= (float)Math.PI;
                }
            }
            // Get a rotation value
            float rotationValue = projectile.rotation - (float)Math.PI / 4f * (float)sign;
            Vector2 positionVector = (rotationValue + (sign == -1 ? (float)Math.PI : 0f)).ToRotationVector2() * (projectile.ai[0] / num) * scaleFactor;
            Vector2 dustVector1 = projectile.Center + (rotationValue + ((sign == -1) ? ((float)Math.PI) : 0f)).ToRotationVector2() * 30f;
            Vector2 dustPosition = rotationValue.ToRotationVector2();
            Vector2 dustVector2 = dustPosition.RotatedBy((float)Math.PI / 2f * (float)projectile.spriteDirection);
            // Update Projectile
            projectile.position = relativePoint - projectile.Size / 2f;
            projectile.position += positionVector;
            projectile.spriteDirection = projectile.direction;
            projectile.timeLeft = 2;
            // Update Player
            player.ChangeDir(projectile.direction);
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = MathHelper.WrapAngle(projectile.rotation);
        }
    }
}