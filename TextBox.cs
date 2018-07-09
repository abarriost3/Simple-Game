using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class TextBox
    {
        public List<String> lines { get; set; }

        /// <summary>
        /// How many lines can be displayed in a textbox
        /// </summary>
        public int boxLineLimit { get; set; }

        private int page;

        public TextBox(int limit)
        {
            lines = new List<string>();

            if (limit > 0) boxLineLimit = limit;
            else boxLineLimit = 1;

            page = 1;
        }

        /// <summary>
        /// Calculates how many pages (segmentation part) a Checkbox has; based on how much lines the output is able to display of that checkbox
        /// </summary>
        /// <param name="maxLinesTextBox"></param>
        /// <returns></returns>
        public int calculateMaxPages()
        {
            if (lines.Count > 0)
                return (((lines.Count - 1) / boxLineLimit) + 1);
            else
                return 1;
        }

        private int calculateFirstIndexFromPage(int page)
        {
            return ( (page-1) * boxLineLimit );
        }

        /// <summary>
        /// Gets a single line of the list of lines
        /// </summary>
        /// <param name="indexLine"></param>
        /// <returns></returns>
        public String getLine(int indexLine)
        {
            try
            {
                if (indexLine < lines.Count)
                    return lines[indexLine];
                else
                    return "";
            }
            catch(Exception e)
            {               
                e = new Exception("ERROR[TextBox.getLine] - Wrong page index!");
                return "";
                throw e;    
            }
        }

        /// <summary>
        /// Will return a list of the lines that belong to a certain page, based on the index of the page, and the size of one page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="maxLinesTextBox"></param>
        /// <returns></returns>
        public List<String> getPageLines(int page)
        {
            List<String> pageLines = new List<string>();

            try
            {
                if ( (page > 0) && (page <= calculateMaxPages() ) ){
                    int index = calculateFirstIndexFromPage(page);

                    while( index < (calculateFirstIndexFromPage(page) + boxLineLimit))
                    {
                        pageLines.Add(getLine(index));
                        index++;
                    }
                }
            }
            catch (Exception e)
            {
                e = new Exception("ERROR[TextBox.getPageLines] - Wrong list index!");
                throw e;
            }


            return pageLines;
        }


        public void addLine(String line)
        {
            lines.Add(line);

            page = this.calculateMaxPages();
        }

        public int getPage()
        {
            return page;
        }

        public void setPage(int newPage)
        {
            if ((newPage > 0) && (newPage <= calculateMaxPages() ) )
                page = newPage;
        }
    }
}
