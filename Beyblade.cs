using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace beyblade
{

    internal class Beyblade
    {
        Vector2 pos, velo, acel, gravidade;
        private float massa;
        private float atrito = 0.2f;

        public float angle, aVelo;

        private float raio;
        public SolidBrush brushBola;
        public Pen pen;
        private RectangleF rectBola;

        private Random rnd;

        public Beyblade()
        {
            rnd = new Random();
            angle= 0;
            aVelo = 40;

            massa = 1;
            raio = 40;
            brushBola = new SolidBrush(Color.Aquamarine);
            pen= new Pen(Color.Black,3);
            rectBola = new RectangleF(-raio, -raio, raio * 2, raio * 2);
            pos = new Vector2();
            velo = new Vector2(0);
            gravidade = new Vector2(0, 0.0f);
        }
        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }
        public Vector2 Velo
        {
            get { return velo; }
            set { velo = value; }
        }
        public Vector2 Acel
        {
            get { return acel; }
            set { acel = value; }
        }

        public float Massa
        {
            get { return massa; }
            set
            {
                massa = value;
                //raio = massa * 5;
                rectBola = new RectangleF(-raio, -raio, raio * 2, raio * 2);
            }
        }
        public float Raio
        {
            get { return raio; }
            set { raio = value; }
        }
        public void aplicaForca(Vector2 forca)
        {
            acel += Vector2.Divide(forca, massa);
        }

        public void aplicaAtrito(Vector2 forca)
        {
            acel += Vector2.Divide(forca, atrito);
        }

        public void move()
        {
            angle += aVelo;
            velo += acel;
            pos += velo;
            acel = gravidade;
        }

        public void draw(Graphics g)
        {
            g.ResetTransform();
            g.RotateTransform(angle);
            g.TranslateTransform(pos.X, pos.Y, System.Drawing.Drawing2D.MatrixOrder.Append);

            g.FillEllipse(brushBola, rectBola);
            g.DrawEllipse(pen, -raio, 0, raio*2,0);

        }

    }



}