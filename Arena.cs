using System;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography;

namespace beyblade
{

    internal class Arena
    {
        private Size area;
        private Random rnd;
        Beyblade beyblade;
        Beyblade beybladeInimigo;
        Atractor atractor;

        public Arena(Size s)
        {
            area = s;
            rnd = new Random();
            beyblade = new Beyblade();
            beybladeInimigo=new Beyblade();
            iniciaBeyblade(beyblade);
            iniciaBeyblade(beybladeInimigo);

            
            atractor = new Atractor(new Vector2(area.Width / 2, area.Height / 2));
        }
        public Size Area
        {
            get { return area; }
            set { area = value; }
        }
        public Beyblade Jogador
        {
            get { return beyblade; }
            set { beyblade = value; }
        }

        public void iniciaBeyblade(Beyblade b)
        {
            Vector2 pos, velo;
            float raio = b.Raio;
            //float massa = ((float)(rnd.NextDouble() * 3 + 1));
            //b.Massa = massa;
            pos.X = rnd.Next((int)raio, area.Width - (int)raio);
            pos.Y = rnd.Next((int)raio, area.Height - (int)raio);
            velo.X =(float)rnd.NextDouble() * 6 - 3;
            velo.Y =(float)rnd.NextDouble() * 6 + 3;
            b.Pos = pos;
            b.Velo = velo;
        }

        public void limitaLateral(Beyblade b)
        {
            Vector2 pos = b.Pos, velo = b.Velo;
            if (b.Pos.X - b.Raio < 0)
            {
                velo.X *= -1;
                pos.X = b.Raio;
               // beyblade.Raio = -1;
            }
            if (b.Pos.X + b.Raio > area.Width)
            {
                velo.X *= -1;
                pos.X = area.Width - b.Raio;
               // beyblade.Raio = -1;
            }
            if (b.Pos.Y - b.Raio < 0)
            {
                velo.Y *= -1;
                pos.Y = b.Raio;
               // beyblade.Raio = -1;
            }
            if (b.Pos.Y + b.Raio > area.Height)
            {
                velo.Y *= -1;
                pos.Y = area.Height - b.Raio;
               // beyblade.Raio = -1;
            }
            b.Pos = pos;
            b.Velo = velo;
        }
        public void colide(float x1, float y1, float r1, float x2, float y2, float r2)
        {
            Vector2  velo = beyblade.Velo;
            Vector2 veloInimigo = beybladeInimigo.Velo;


            if (x1 + r1 > x2 - r2 &
               x1 - r1 < x2 + r2 &
               y1 + r1 > y2 - r2 &
               y1 - r1 < y2 + r2)
            {

                if (velo.X != 0 || velo.X != 0)
                {
                    velo.X *= -1;
                    velo.Y *= -1;
                    veloInimigo.X *= -1;
                    veloInimigo.Y *= -1;
                    if (beyblade.aVelo != 0)
                    {
                        beyblade.aVelo -= 10;
                    }
                }



            }
            beyblade.Velo= velo;
            beybladeInimigo.Velo = veloInimigo;

        }

        public void move()
        {
            beyblade.aplicaForca(atractor.atract(beyblade));
            beybladeInimigo.aplicaForca(atractor.atract(beybladeInimigo));
   
            colide(beyblade.Pos.X, beyblade.Pos.Y, beyblade.Raio, beybladeInimigo.Pos.X, beybladeInimigo.Pos.Y, beybladeInimigo.Raio);

            limitaLateral(beyblade);
            limitaLateral(beybladeInimigo);
            beybladeInimigo.move();
            beyblade.move();

        }
        public void draw(Graphics g)
        {
            beyblade.brushBola.Color = Color.White;
            beyblade.draw(g);
             beybladeInimigo.draw(g);
            // atractor.draw(g);

        }


    }

}
