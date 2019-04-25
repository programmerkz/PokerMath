using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fwaPokerMath
{
    class SingleDice
    {
        public byte FaceNumber { get; }

        public SingleDice()
        {
            FaceNumber = 6;
        }

        public SingleDice(byte faceNumber)
        {
            if (faceNumber < 1) throw new ArgumentException("Количество граней на костях не может быть меньше 1", "faceNumber");
            else
                FaceNumber = faceNumber;
        }

        public byte Roll()
        {
            Random rnd = new Random();
            return (byte)rnd.Next(1, FaceNumber + 1);
        }
    }

    class Dice
    {
    }
}
