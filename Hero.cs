namespace BCEngine;
using Microsoft.Xna.Framework.Graphics;
using TexturePackerLoader;

public class Hero : Sprite{
    public int Energy;

    public Hero() : base()
    {
        Energy=100;
    }

    public override void TouchedBy(IActor pBy){
        if(pBy is Meteor){
            Energy-=10;
        }
    }

    

    public override void Draw(SpriteBatch pSpriteBatch, SpriteRender pSpriteRenderer)
    {
        base.Draw(pSpriteBatch,pSpriteRenderer);
    }
}