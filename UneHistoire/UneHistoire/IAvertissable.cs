using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    public interface IAvertissable
    {
        int WorkCompleted();
        void WorkProgressing();
        void WorkStarted();
    }
}