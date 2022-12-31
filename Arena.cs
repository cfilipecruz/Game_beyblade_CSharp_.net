using System;
using System.Collections.Generic;
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
        private List<Particula> particulas;

        private Vector2 emissor1;
        private Vector2 emissor2;

        public Arena(Size s)
        {
            area = s;
            rnd = new Random();
            beyblade = new Beyblade();
            beybladeInimigo=new Beyblade();
            iniciaBeyblade();

            particulas = new List<Particula>();

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

        public Beyblade Inimigo
        {
            get { return beybladeInimigo; }
            set { beyblade = value; }
        }

        public void iniciaBeyblade()
        {
            Vector2 pos=beyblade.Pos, velo=beyblade.Velo;
            Vector2 posI = beybladeInimigo.Pos, veloI = beybladeInimigo.Velo;
            float raio = beyblade.Raio;
            pos.X = 0 + raio * 2;
            pos.Y =area.Height / 2;
            posI.X= area.Width-raio*2;
            posI.Y= area.Height / 2;
            velo.X = (float)rnd.NextDouble() * 10 - 5;
            velo.Y = (float)rnd.NextDouble() * 10 - 5;
            veloI.X = (float)rnd.NextDouble() * 10 - 5;
            veloI.Y= (float)rnd.NextDouble() * 10 - 5;
            beyblade.Pos = pos;
            beyblade.Velo = velo;
            beybladeInimigo.Pos = posI;
            beybladeInimigo.Velo= veloI;
        }

        public void limitaLateral(Beyblade b)
        {
            Vector2 pos = b.Pos, velo = b.Velo;
            float aVelo = b.aVelo;
            if (b.Pos.X - b.Raio < 0)
            {
                velo.X *= -1;
                pos.X = b.Raio;
                aVelo -= 1;
            }
            if (b.Pos.X + b.Raio > area.Width)
            {
                velo.X *= -1;
                pos.X = area.Width - b.Raio;
                aVelo -= 1;
            }
            if (b.Pos.Y - b.Raio < 0)
            {
                velo.Y *= -1;
                pos.Y = b.Raio;
                aVelo -= 1;
            }
            if (b.Pos.Y + b.Raio > area.Height)
            {
                velo.Y *= -1;
                pos.Y = area.Height - b.Raio;
                aVelo -= 1;
            }
            b.Pos = pos;
            b.Velo = velo;
        }
        public void colide(float x1, float y1, float r1, float x2, float y2, float r2)
        {
            Vector2  velo = beyblade.Velo, acel = beyblade.Acel, pos1 = beyblade.Pos, pos2 = beybladeInimigo.Pos;
            Vector2 veloI = beybladeInimigo.Velo, acelI = beybladeInimigo.Acel;

            float xDist=x1-x2;
            float yDist=y1-y2;
            float dist =(float)Math.Sqrt((xDist * xDist) +(yDist*yDist));


            if (r1+r2 >dist)
            {
                velo.X *= -1;
                velo.Y *= -1;
                veloI.X *= -1;
                veloI.Y *= -1;

                if (beyblade.Massa> beybladeInimigo.Massa && beyblade.aVelo > beybladeInimigo.aVelo)
                {
                        beybladeInimigo.aVelo -= 3;        
                }
                if(beyblade.Massa > beybladeInimigo.Massa && beybladeInimigo.aVelo > beyblade.aVelo)
                {
                        beybladeInimigo.aVelo -= 2 ;
                        beyblade.aVelo -= 1;
                }
                if(beybladeInimigo.Massa >= beyblade.Massa && beybladeInimigo.aVelo >= beyblade.aVelo){
                        beyblade.aVelo -= 3;
                }
                if(beybladeInimigo.Massa >= beyblade.Massa && beyblade.aVelo >= beybladeInimigo.aVelo)
                {
                        beybladeInimigo.aVelo -= 1;
                        beyblade.aVelo -= 2;           
                }

                if (beyblade.aVelo < 0)
                {
                    beyblade.aVelo = 0;
                }
                if(beybladeInimigo.aVelo < 0)
                {
                    beybladeInimigo.aVelo = 0;
                }


                    emissor1 = new Vector2(pos1.X, pos1.Y);
                    emissor2 = new Vector2(pos2.X, pos2.Y);
                    particulas.Add(new Particula(emissor1));
                    particulas.Add(new Particula(emissor2));
              

            }

            if (beyblade.aVelo == 0)
            {
                velo.X = 0;
                velo.Y = 0;
                acel.X = 0;
                acel.Y = 0;
            }
            if(beybladeInimigo.aVelo == 0)
            {
                veloI.X = 0;
                veloI.Y = 0;
                acelI.X = 0;
                acelI.Y = 0;
            }

            beybladeInimigo.Acel = acelI;
            beybladeInimigo.Velo= veloI;
            beyblade.Acel = acel;
            beyblade.Velo = velo;
        }
        
        public void move()
        {
           beyblade.aplicaForca(atractor.atract(beyblade));
           beybladeInimigo.aplicaForca(atractor.atract(beybladeInimigo));
   
            colide(beyblade.Pos.X, beyblade.Pos.Y, beyblade.Raio, beybladeInimigo.Pos.X, beybladeInimigo.Pos.Y, beybladeInimigo.Raio);

            limitaLateral(beyblade);
            limitaLateral(beybladeInimigo);


            for (int i = particulas.Count - 1; i >= 0; i--)
            {
                particulas[i].move();
                if (particulas[i].isDead())
                    particulas.RemoveAt(i);
            }

            beybladeInimigo.move();
            beyblade.move();

        }
        public void draw(Graphics g)
        {
            beyblade.brushBola.Color = Color.White;
            beyblade.draw(g);
            beybladeInimigo.draw(g);
            // atractor.draw(g);

            foreach (Particula b in particulas)
            {
                b.draw(g);
            }

        }


    }

}
