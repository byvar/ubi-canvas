using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class SplineUsageModeExtAttribute : Attribute {
		private ITF.Spline.UsageMode mode;

		public SplineUsageModeExtAttribute(ITF.Spline.UsageMode mode) {
			this.mode = mode;
		}
		public ITF.Spline.UsageMode Mode => mode;
	}
}