﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public class Hero
    {
        public Point Location { get; set; }
        public Bitmap HeroShipImg { get; set; }
        public bool ShowHeroShip { get; set; }
        public int Speed { get; set; }
        public List<HeroBullet> bullets { get; set; }

        public Hero(Point Location)
        {
            this.Location = Location;
            this.HeroShipImg = VP_Project.Properties.Resources.HeroShip1_1;
            this.ShowHeroShip = false;
            this.Speed = 10;
            this.bullets = new List<HeroBullet>();
        }

        public void AddHeroBullet(HeroBullet bullet)
        {
            this.bullets.Add(bullet);
        }

        public void Move(Keys keys,int width)
        {
            if(keys == Keys.Left)
            {
                Point newLocation = new Point(this.Location.X - Speed, this.Location.Y);
                if(newLocation.X <= 0 || newLocation.X >= width)
                {
                    newLocation = new Point(this.Location.X, this.Location.Y);
                }
                this.Location = newLocation;
            }

            if (keys == Keys.Right)
            {
                Point newLocation = new Point(this.Location.X + Speed, this.Location.Y);

                if (newLocation.X >= width - HeroShipImg.Size.Width)
                {
                    newLocation = new Point(this.Location.X, this.Location.Y);
                }

                this.Location = newLocation;
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(this.HeroShipImg, this.Location);
            foreach(HeroBullet bullet in bullets)
            {
                bullet.Draw(g);
            }
        }
    }
}