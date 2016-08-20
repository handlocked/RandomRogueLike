using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace RogueLikeGame
{
    class GameObject
    {
        public int X
        {
            get; set;
        }

        public int Y
        {
            get; set;
        }

        public virtual void Update(GameTime gameTime)
        {

        }
    }
}
