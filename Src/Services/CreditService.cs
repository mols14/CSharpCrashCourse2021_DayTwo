using System;
using CrashCourse2021ExercisesDayTwo.Models;

namespace CrashCourse2021ExercisesDayTwo.Services
{
    //This is the only Class where you should change code!! :)
    public class CreditService
    {
        private Credit credit;

        public CreditService()
        {
            credit = new Credit { Value = 0, MaxAllowed = 10000d};
        }

        internal double CurrentCreditValue()
        {
            return credit.Value;
        }

        internal void AddCredit(double valueToAdd)
        {
            if (valueToAdd !< 0)
            {
                credit.Value = CurrentCreditValue() + valueToAdd;
            }
        }

        internal void RemoveCredit(double valueToRemove)
        {
            throw new NotImplementedException();
        }

        internal double CurrentMaxAllowedValue()
        {
            throw new NotImplementedException();
        }

        internal void SetMaxAllowedValue(double maxValue)
        {
            throw new NotImplementedException();
        }
    }
}
