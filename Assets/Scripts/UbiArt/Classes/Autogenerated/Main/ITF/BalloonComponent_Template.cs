using UnityEngine;

namespace UbiArt.ITF {
	public partial class BalloonComponent_Template : ActorComponent_Template {
		[Serialize("aabbMin")] public Vector2 aabbMin;
		[Serialize("is3D"   )] public bool is3D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(aabbMin));
			SerializeField(s, nameof(is3D));
		}
		public override uint? ClassCRC => 0xC29A3B3F;
	}
}

