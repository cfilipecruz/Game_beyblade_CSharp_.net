using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace beyblade
{
    internal class Atractor
    {
        private float massa, G;
        private Vector2 pos;

        private float raio;
        private SolidBrush brushAtractor;
        private RectangleF rectAtractor;

        public Atractor(Vector2 location)
        {
            massa = 300;
            pos = location;
            G = 1f;

            raio = 40;
            brushAtractor = new SolidBrush(Color.Brown);
            rectAtractor = new RectangleF(-raio, -raio, raio * 2, raio * 2);
        }

        public Vector2 atract(Beyblade b)
        {
            Vector2 force = Vector2.Subtract(pos, b.Pos);
            float distance = force.Length();
            distance = (distance < 5 ? 5 : (distance > 25 ? 25 : distance));
            force = Vector2.Normalize(force);
            float strength = (G * massa * b.Massa / (distance * distance));
            force = Vector2.Multiply(strength, force);
            return force;
        }
        public void draw(Graphics g)
        {
            g.ResetTransform();
            g.TranslateTransform(pos.X, pos.Y);
            g.FillEllipse(brushAtractor, rectAtractor);

        }
    }
}
