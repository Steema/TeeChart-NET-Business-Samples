using System.Drawing;
using System.Reflection;

namespace StandardSeriesDemo.Properties
{
    internal class Resources
    {
        public static Image up { 
            get {
                return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("StandardSeriesDemo.Resources.up.png"));
            }  
        }
        public static Image down
        {
            get
            {
                return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("StandardSeriesDemo.Resources.down.png"));
            }
        }
        public static Image TeeChartWhite190x44
        {
            get
            {
                return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("StandardSeriesDemo.Resources.TeeChartWhite190x44.png"));
            }
        }
    }
}
