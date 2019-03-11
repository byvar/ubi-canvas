using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AspiNetworkComponent_Template : CSerializable {
		[Serialize("enterDuration"        )] public float enterDuration;
		[Serialize("enterBezierMultiplier")] public float enterBezierMultiplier;
		[Serialize("speed"                )] public float speed;
		[Serialize("exitSpeed"            )] public float exitSpeed;
		[Serialize("exitDist"             )] public float exitDist;
		[Serialize("exitRestoreZDist"     )] public float exitRestoreZDist;
		[Serialize("fxData"               )] public Placeholder fxData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enterDuration));
			SerializeField(s, nameof(enterBezierMultiplier));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(exitSpeed));
			SerializeField(s, nameof(exitDist));
			SerializeField(s, nameof(exitRestoreZDist));
			SerializeField(s, nameof(fxData));
		}
		public override uint? ClassCRC => 0x1DF730D4;
	}
}

