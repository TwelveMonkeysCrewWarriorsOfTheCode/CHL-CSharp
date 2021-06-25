using System;
using System.Collections.Generic;
using System.Text;

namespace UsingGenerics
{
    class Range<UnknowType> where UnknowType : IComparable<UnknowType>
    {
        private UnknowType m_LowerBound;
        private UnknowType m_UpperBound;

        public Range(UnknowType plowerBound, UnknowType pUpperBound)
        {
            m_LowerBound = plowerBound;
            m_UpperBound = pUpperBound;
        }

        public bool IsIncluded(UnknowType pTemperature)
        {
            return pTemperature.CompareTo(m_LowerBound) >= 0 && pTemperature.CompareTo(m_UpperBound) <= 0;
            //return pTemperature >= m_LowerBound && pTemperature <= m_UpperBound;
        }
    }
}
