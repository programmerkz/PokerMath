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
        public byte DiceNumber { get; }
        public byte FaceNumber { get; }
        public List<SingleDice> Dices { get; }

        public Dice(byte faceNumber, byte diceNumber)
        {
            if (faceNumber < 1) throw new ArgumentException("Количество граней на костях не может быть меньше 1", "faceNumber");
            else if (diceNumber < 1) throw new ArgumentException("Количество костей не может быть меньше 1", "diceNumber");
            else
            {
                DiceNumber = diceNumber;
                FaceNumber = faceNumber;
                Dices = new List<SingleDice>();

                try
                {
                    for (byte i = 0; i < DiceNumber; i++)
                        Dices.Add(new SingleDice(FaceNumber));
                }
                catch (Exception ex)
                {
                    throw new Exception("Не возможно создать набор костей", ex);
                }
            }
        }

        public uint Roll()
        {
            uint diceSum = 0;

            for (byte i = 0; i < DiceNumber; i++)
                diceSum += Dices[i].Roll();

            return diceSum;
        }
    }
}
