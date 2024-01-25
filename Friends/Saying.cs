namespace Friends
{
    class Saying
    {
        public string Acronyme { get; set; }
        public string Sentence { get; set; }
        public bool IsPerfect { get; set; } = false;

        public Saying(string sentence)
        {
            Sentence = sentence;
            Acronyme = MakeAcronyme(sentence);
            IsPerfect = CheckIfPerfect();
        }

        string MakeAcronyme(string sentence)
        {
            string[] words = sentence.Split(' ');
            string acronyme = "";
            foreach (string word in words)
            {
                acronyme += char.ToUpper(word[0]);
            }
            return acronyme;
        }

        bool CheckIfPerfect()
        {
            int acronymeSum = CalculateAcronymeSum();
            int decagonalNumber = CalculateDecagonalNumber();

            int mergedSum = acronymeSum + decagonalNumber;
            if (mergedSum == SumOfDivisors(mergedSum))
            {
                return true;
            }
            return false;
        }

        public static int SumOfDivisors(int number)
        {
            int sum = 1;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    if (number / i != i)
                    {
                        sum += number / i;
                    }
                }
            }

            return sum;
        }

        public int CalculateAcronymeSum()
        {
            int total = 0;
            foreach(char c in Acronyme)
            {
                total += c;
            }

            return total;
        }

        public int CalculateDecagonalNumber()
        {
            // 5n^2 - 5n + 1
            // n = Acronyme + 3
            int n = Acronyme.Length + 3;
            int total = (5 * n * n) - (5 * n) + 1;
            return total;
        }


    }
}
