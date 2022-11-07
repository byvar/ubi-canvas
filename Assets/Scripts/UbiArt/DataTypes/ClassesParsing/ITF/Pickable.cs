using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;

namespace UbiArt.ITF {
	public partial class Pickable {
		public TemplatePickable templatePickable;

		public Pickable() {
			ANGLE = new Angle(0);
			SCALE = Vec2d.One;
		}
	}
}
