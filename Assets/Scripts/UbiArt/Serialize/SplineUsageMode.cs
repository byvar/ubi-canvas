using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field)]
	public class SplineUsageModeAttribute : Attribute {
		private ITF.Spline.UsageMode mode;

		public SplineUsageModeAttribute(ITF.Spline.UsageMode mode) {
			this.mode = mode;
		}
		public ITF.Spline.UsageMode Mode => mode;
	}
}