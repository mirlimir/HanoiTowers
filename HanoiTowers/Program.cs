using System;

namespace HanoiTowers
{
    class Program
    {
        private static int GetCountDisks()
        {
            const int MIN_COUNT_DISKS = 3;
            int countDisks = MIN_COUNT_DISKS;
            string enterCountDisks;
            Console.Write("Enter the number of disks (min 3): ");
            enterCountDisks = Console.ReadLine();
            if (!(Int32.TryParse(enterCountDisks, out countDisks) && countDisks >= MIN_COUNT_DISKS))
            {
                return GetCountDisks();
            }
            return countDisks;
        }
        public static int countTransferDisk = 0;
        private static void GetSolutionHanoiTowers(int disks, char towerA, char towerB, char towerC)
        {
            const int STEP_DISK = 1;
            if (disks == STEP_DISK)
            {
                Console.WriteLine($"{towerA} --> {towerC}"); 
                countTransferDisk++;
            }
            else
            {
                GetSolutionHanoiTowers((disks - STEP_DISK), towerA, towerC, towerB);
                Console.WriteLine($"{towerA} --> {towerC}"); 
                countTransferDisk++;
                GetSolutionHanoiTowers((disks - STEP_DISK), towerB, towerA, towerC);
            }
        }
        static void Main(string[] args)
        {
            char towerA = 'A';
            char towerB = 'B';
            char towerC = 'C';
            Console.WriteLine("\t\t\t\tHanoi Tower");
            GetSolutionHanoiTowers(GetCountDisks(), towerA, towerB, towerC);
            Console.WriteLine($"Number of disc transfers: {countTransferDisk}.");

        }      
    }
}
