﻿using System;

namespace Console
{
    public class CalculatorEngine
    {
        /// <summary>
        /// Function to Addition two value.
        /// </summary>
        /// <param name="val1">1st value.</param>
        /// <param name="val2">2nd value.</param>
        /// <returns>the addition value.</returns>
        public virtual int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public virtual int Sub(int val1, int val2)
        {
            return val1 - val2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public virtual int Mul(int val1, int val2)
        {
            return val1 * val2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public virtual int Div(int val1, int val2)
        {
            int res;

            if (val2 != 0)
            {
                res = val1 / val2;
            }
            else
            {
                res = Int32.MinValue;
            }

            return res;
        }
    }
}
