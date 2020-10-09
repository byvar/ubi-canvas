using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class DynModifier_GravityController : AbstractDynModifier {
		public Curve2D curvMultiplier;
		public float timeTotal;
		public float amplitude;
		public bool persistent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			curvMultiplier = s.SerializeObject<Curve2D>(curvMultiplier, name: "curvMultiplier");
			timeTotal = s.Serialize<float>(timeTotal, name: "timeTotal");
			amplitude = s.Serialize<float>(amplitude, name: "amplitude");
			persistent = s.Serialize<bool>(persistent, name: "persistent");
		}
		public override uint? ClassCRC => 0x423BF519;
	}
}

