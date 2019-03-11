using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIMedalBehavior : CSerializable {
		[Serialize("The medal actor is present twice.\n")] public Placeholder TODO;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Debug.LogError("TODO: Ray_AIMedalBehavior");
			throw new System.Exception("TODO");
		}
		public override uint? ClassCRC => 0x402E8012;
	}
}

