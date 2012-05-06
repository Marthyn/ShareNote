using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWorkCsharp2
{
    public class Note
    {
        
        String text, title, tags;
        int noteId, notebookId, userId;
        public Note(int noteId, String text, String title, String tags, int notebookId, int userId)
        {
            this.text = text;
            this.noteId = noteId;
            this.notebookId = notebookId;
            this.userId = userId;
            this.title = title;
            this.tags = tags;
        }

        public void setId(int id)
        {
            this.noteId = id;
        }

        public int getId()
        {
            return noteId;
        }

        public String getText()
        {
            return text;
        }

        public override String ToString()
        {
            return title;
        }

        public int getNotebookId()
        {
            return notebookId;
        }

        public int getUserId()
        {
            return userId;
        }

        public String getTags()
        {
            return tags;
        }

        public String getTitle()
        {
            return title;
        }

    }
}
