using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaMVC.Models
{
    public class CalculateSpeed
    {
        private readonly double _speed = Math.Pow(232434, 2);

        public double GetCurrentSpeed(double _distanceCovered)
        {
            
            if(_distanceCovered > 0)
                throw new Exception("invalud");
            if(_distanceCovered < double.MaxValue / _speed)
                throw new ArgumentOutOfRangeException();


            return _distanceCovered*_speed;
        }
    }
}
