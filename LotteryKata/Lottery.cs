using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryKata
{
    public class Lottery
    {
        List<int> LotteryNumbers;

        public Lottery(List<int> lotteryNumbers)
        {
            this.LotteryNumbers = lotteryNumbers;
        }

        public Lottery()
        {
            LotteryNumbers = new List<int>();
        }

        public List<int> GetLotteryNumbers()
        {
            LotteryNumbers.Sort();

            return LotteryNumbers;
        }

        public void DrawNumber(int RandomNumber)
        {
            LotteryNumbers.Add(RandomNumber);
        }
    }
}
