using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace beyblade
{
    internal class Particula
    {
        protected Vector2 pos, velo, acel, gravidade;
        protected float lifeSpan;
      

        protected float raio;
        protected SolidBrush brushBola;
        protected RectangleF rectBola;

        protected Random rnd;

        public Particula(Vector2 p)
        {

                rnd = new Random();
                pos = p;
                velo = new Vector2(
                    (float)(rnd.NextDouble() * 12 - 6),
                    (float)(rnd.NextDouble() * -6)
                    );

                gravidade = new Vector2(0, 0.2f);

                lifeSpan = 200;

                raio =6 ;
            for(int i = 0; i < 10000; i++) { 
                brushBola = new SolidBrush(Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)));
                rectBola = new RectangleF(-raio, -raio, raio * 2, raio * 2);
            }
        }

        public void aplicaForca(Vector2 forca)
        {
            acel += Vector2.Divide(forca, lifeSpan);
        }
        public Boolean isDead()
        {
            return lifeSpan <= 0;
        }

        //virtual permite com que a subclasse de override a este metodo
        public virtual void move()
        {
            velo += acel;
            pos += velo;
            acel = gravidade;
            lifeSpan -= 5;
        }

        public virtual void draw(Graphics g)
        {
                brushBola.Color = Color.FromArgb((int)lifeSpan, brushBola.Color);
                g.ResetTransform();
                g.TranslateTransform(pos.X, pos.Y);
                g.FillEllipse(brushBola, rectBola);

        }
    }

}
