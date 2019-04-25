using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fwaPokerMath
{
    class SingleDice
    {
        private byte _faceValue;

        public byte FaceNumber { get; }
        public byte FaceValue { get { return _faceValue; }}

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
            _faceValue = (byte)rnd.Next(1, FaceNumber + 1);
            return FaceValue;
        }

        public byte Roll(Random rnd)
        {
            if (rnd == null) throw new ArgumentNullException("Не возможно сделать бросок кости, т.к. передан null генератор случайных числел");
            else
            {
                _faceValue = (byte)rnd.Next(1, FaceNumber + 1);
                return FaceValue;
            }
        }
    }

    class Dice
    {
        public byte DiceNumber { get; }
        public byte FaceNumber { get; }
        public List<SingleDice> Dices { get; }

        public Dice(byte faceNumber, byte diceNumber)
        {
            //if (faceNumber < 0) throw new ArgumentException("Количество граней на костях не может быть меньше 1", "faceNumber");
            if (diceNumber < 1) throw new ArgumentException("Количество костей не может быть меньше 1", "diceNumber");
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
                    throw new Exception($"Не возможно создать набор костей \r\n{ex.Message}", ex);
                }
            }
        }

        public bool isAllFacesAreSame()
        {
            if (Dices == null) throw new NullReferenceException("Набор костей не инициализирован");
            else if (Dices.Count == 1) return false; // логичнее именно так, т.е. когда набор костей - это одна игральная кость, то это по-любому НЕ ДУБЛЬ
            else
            {
                for (byte i = 1; i < DiceNumber; i++)
                    if (Dices[0].FaceValue != Dices[i].FaceValue)
                        return false; // как только мы нашли кости с разными значениями граней, то это уже НЕ ДУБЛЬ

                return true; // если выподнение кода пришло в эту точку, то значит различий выявлено не было, а значит это ДУБЛЬ
            }
        }

        public uint Roll(Random rnd)
        {
            if (rnd == null) throw new ArgumentNullException("Не возможно сделать бросок кости, т.к. не передан генератор случайных числел");
            else
            {
                uint diceSum = 0;

                for (byte i = 0; i < DiceNumber; i++)
                    diceSum += Dices[i].Roll(rnd);

                return diceSum;
            }
        }

        public uint RollDoble(Random rnd)
        {
            if (rnd == null) throw new ArgumentNullException("Не возможно сделать бросок кости, т.к. не передан генератор случайных числел");
            else
            {
                uint diceSum = 0;

                for (byte i = 0; i < DiceNumber; i++)
                    diceSum += Dices[i].Roll(rnd);

                if (isAllFacesAreSame())
                    return diceSum * DiceNumber;    // если все грани одинаковые, то значение равно сумме выпавших косте, умноженному на количество кубиков
                else
                    return diceSum;
            }
        }

        public string PrintValue()
        {
            if (Dices == null) throw new NullReferenceException("Набор костей не инициализирован");
            else
            {
                string res = "";

                for (byte i = 0; i < DiceNumber; i++)
                    res += $"";

                return res;
            }
        }
    }
}
