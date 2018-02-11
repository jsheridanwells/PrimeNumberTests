using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) return false;

            if (candidate == 2) return true;

            if (candidate % 2 == 0) return false;

            var boundary = Math.Floor(Math.Sqrt(candidate));

            for (var i = 3; i < boundary; i++)
            {
                if (candidate % i == 0) return false;
            }

            return true;

        }
    }
}