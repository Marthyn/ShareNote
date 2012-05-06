using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWorkCsharp2
{
    public class Notebook
    {
        String name, description;
        int notebookId, userId;

        public Notebook(int notebookId, int userId, String name, String description)
        {
            this.notebookId = notebookId;
            this.userId = userId;
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return name;
        }

        public int getId()
        {
            return notebookId;
        }

        public String getName()
        {
            return name;
        }

        public String getDescription()
        {
            return description;
        }

        public int getUserId()
        {
            return userId;
        }
    }
}
