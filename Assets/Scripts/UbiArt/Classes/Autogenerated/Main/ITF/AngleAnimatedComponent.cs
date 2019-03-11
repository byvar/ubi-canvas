using UnityEngine;

namespace UbiArt.ITF {
	public partial class AngleAnimatedComponent : ActorComponent {
		[Serialize("Addanim"    )] public bool Addanim;
		[Serialize("angleOffset")] public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Addanim));
			SerializeField(s, nameof(angleOffset));
		}
		public override uint? ClassCRC => 0xB026081F;
	}
}

