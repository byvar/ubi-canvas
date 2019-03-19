using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class AttractorComponent : ActorComponent {
		[Serialize("valueOverDistance"    )] public Spline valueOverDistance;
		[Serialize("valueOverSpeed"       )] public Spline valueOverSpeed;
		[Serialize("valueOverAcceleration")] public Spline valueOverAcceleration;
		[Serialize("valueOverTime"        )] public Spline valueOverTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(valueOverDistance));
			SerializeField(s, nameof(valueOverSpeed));
			SerializeField(s, nameof(valueOverAcceleration));
			SerializeField(s, nameof(valueOverTime));
		}
		public override uint? ClassCRC => 0xF8EF1527;
	}
}

