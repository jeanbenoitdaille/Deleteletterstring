    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public string RemoveAtPosition(string v, int index){
                index = index < 0 ? 0 : index;
                index = index > (v.Length -1 ) ? v.Length -1 : index;
                
                return v.Remove(index, 1);
            }
        }
    }