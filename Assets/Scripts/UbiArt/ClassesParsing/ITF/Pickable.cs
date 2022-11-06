using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class Pickable {
		public TemplatePickable templatePickable;

		public Pickable() {
			ANGLE = new Angle(0);
			SCALE = Vec2d.One;
		}
	}
}
