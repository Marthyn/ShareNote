using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWorkCsharp2
{
    class University
    {
        int universityId;
        String name, location;
        public University(int universityId, String name, String location)
        {
            this.universityId = universityId;
            this.name = name;
            this.location = location;
        }

        public int getUniversityId()
        {
            return universityId;
        }

        public String getName()
        {
            return name;
        }

        public String getLocation()
        {
            return location;
        }

        public override string ToString() { return name; }
    }
}
