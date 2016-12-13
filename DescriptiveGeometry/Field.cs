using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DescriptiveGeometry
{
    class Field
    {
        private Dictionary<string, Point> points;
        private Tuple<KeyValuePair<string, Point>, KeyValuePair<string, Point>> lines;
        private Rectangle fieldSize;


        public Field(Rectangle size)
        {
            fieldSize = size;
        }

        #region Properties

        public Dictionary<string, Point> Points
        {
            get
            {
                return points;
            }
        }

        public Tuple<KeyValuePair<string, Point>, KeyValuePair<string, Point>> Lines
        {
            get
            {
                return lines;
            }
        }

        public Rectangle FieldSize
        {
            get
            {
                return fieldSize;
            }
        }

        #endregion

        #region Public methods



        #endregion
    }
}
