﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computers.UI.Console.ComputerTypes
{
    public class PersonalComputer : Computer
    {
        public PersonalComputer(Cpu cpu, Rammstein ram, IEnumerable<HardDriver> hardDrives, HardDriver videoCard, LaptopBattery battery) 
            : base(cpu, ram, hardDrives, videoCard, battery)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.rand(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }
    }
}
