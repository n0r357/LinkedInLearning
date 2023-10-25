using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExampleApp {
	public class RayPoint : Object {

		public static RayPoint Parse(string value) {

            // solution code or similar will go here 
            // see instructor solution in next video
			string trimmed = value.Trim();
            var regex = Regex.Replace(trimmed.Replace(" ", ","), "[^0-9,-]", "");
            var coords = regex.Split(',');

			if(coords.Length == 2)
			{
				if (Int32.TryParse(coords[0], out int x) && Int32.TryParse(coords[1], out int y))
				{
                    return new RayPoint(true, x, y);
                } else
				{
                    throw new InvalidCastException($"Cannot parse the value ({value}) into a RayPoint");
                }
			} else
			{
                throw new InvalidCastException($"Invalid length of Raypoint: ({value})");
            }
		}
		#region ToString
		public override string ToString()
		{
			return ToString("C");
		}

		public string ToString(string format)
		{

			var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
			return ToString(format, currentCulture);

		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			// use this implementation to 
			// process other cultures (passed via the IFormatProvider)
			// move the code here from other ToString("H")
			string formattedString;
			switch (format)
			{
				case "C":
					formattedString = $"Parsed: {WasParsed}, X: {X}, Y:{Y}";
					break;
				case "H":
					formattedString = $"Parsed: {WasParsed}, X: {X} - Y:{Y}";
					break;
				case "F":
					formattedString = $"Parsed: {WasParsed}, X: {X} --++-- Y:{Y}";
					break;
				default:
					formattedString = $"Parsed: {WasParsed}, X: {X}, Y:{Y}";
					break;
			}
			return formattedString;
		}
		#endregion
		#region Constructors
		public RayPoint() {

		}
		public RayPoint(bool wasParsed, int x, int y) {
			_wasParsed = wasParsed;
			_x = x;
			_y = y;
		}
        #endregion
        #region Properties
        private bool _wasParsed;

        public bool WasParsed
        {
            get { return _wasParsed; }
            set { _wasParsed = value; }
        }

        private int _x;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}

		private int _y;

		public int Y
		{
			get { return _y; }
			set { _y = value; }
		}
		#endregion
	}
}