using UnityEngine;

namespace UbiArt.ITF {
	public partial class DynModifier_GravityController : AbstractDynModifier {
		[Serialize("curvMultiplier")] public Curve2D curvMultiplier;
		[Serialize("timeTotal"     )] public float timeTotal;
		[Serialize("amplitude"     )] public float amplitude;
		[Serialize("persistent"    )] public bool persistent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(curvMultiplier));
			SerializeField(s, nameof(timeTotal));
			SerializeField(s, nameof(amplitude));
			SerializeField(s, nameof(persistent));
		}
		public override uint? ClassCRC => 0x423BF519;
	}
}

