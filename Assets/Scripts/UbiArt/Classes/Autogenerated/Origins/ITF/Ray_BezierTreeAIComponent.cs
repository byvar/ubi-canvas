using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BezierTreeAIComponent : GraphicComponent {
		[Serialize("startActivated")] public bool startActivated;
		[Serialize("branchSpeed"   )] public float branchSpeed;
		[Serialize("polylineMode"  )] public PolylineMode polylineMode;
		[Serialize("flipTexture"   )] public bool flipTexture;
		[Serialize("branches"      )] public Placeholder branches;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startActivated));
				SerializeField(s, nameof(branchSpeed));
				SerializeField(s, nameof(polylineMode));
				SerializeField(s, nameof(flipTexture));
				SerializeField(s, nameof(branches));
			}
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None"       )] None = 0,
			[Serialize("PolylineMode_Left"       )] Left = 1,
			[Serialize("PolylineMode_Right"      )] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x3AFFD116;
	}
}

