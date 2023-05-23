using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public List<Evaulation> GetEvaulations()
        {
            return EvaulationRepository.GetEvaluations(this);
        }

        public int CalculateTotalPoints()
        {
            int totalPoints = 0;
            foreach(var Evaulation in GetEvaulations())
            {
                totalPoints += Evaulation.Points;
            }
            return totalPoints;
        }
        private bool IsEvaulationComplete()
        {
            var Evaulations = GetEvaulations();
            var activites = ActivityRepository.GetActivities();

            return Evaulations.Count == activites.Count;
        }
        public bool HasSignature()
        {
            bool hasSignature = true;
            if (IsEvaulationComplete() == true)
            {
                foreach (var evaulation in GetEvaulations())
                {
                    if (evaulation.IsSufficientForSignature() == false)
                    {
                        hasSignature = false;
                        break;
                    }
                }
            }
            else {
                hasSignature = false;
            }
            return hasSignature;
        }
        public bool hasGrade()
        {
            bool hasGrade=true;
            if (IsEvaulationComplete() == true)
            {
                foreach (var evaulation in GetEvaulations())
                {
                    if (evaulation.IsSufficientForGrade() == false)
                    {
                        hasGrade = false;
                        break;
                    }
                }
            }
            else { 
                hasGrade=false;
            }

            return hasGrade;
        }
        public int CalculateGrade()
        {
            int grade = 0;
            if (hasGrade() == true)
            {
                int totalPoints = CalculateTotalPoints();
                if(totalPoints >= 91)
                {
                    grade = 5;
                }
                else if(totalPoints >= 76)
                {
                    grade = 4;
                }
                else if (totalPoints >= 61)
                {
                    grade = 3;
                }
                else if(totalPoints >= 50)
                {
                    grade = 2;
                }
                else
                {
                    grade = 1;
                }
            }

            return grade;
        }
    }
}
