using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DescriptiveGeometry
{
    class Result
    {
        private Field field;
        private Point eye;

        public Result(Field field)
        {
            this.field = field;
        }

        #region Properties


        internal Field Field
        {
            get
            {
                return field;
            }
        }

        public Point Eye
        {
            get
            {
                return eye;
            }
            set
            {
                eye = value;
            }
        }

        #endregion
    }
}
