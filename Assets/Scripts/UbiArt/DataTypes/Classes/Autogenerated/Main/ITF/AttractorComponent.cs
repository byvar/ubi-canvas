using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class AttractorComponent : ActorComponent {
		public Spline valueOverDistance;
		public Spline valueOverSpeed;
		public Spline valueOverAcceleration;
		public Spline valueOverTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			valueOverDistance = s.SerializeObject<Spline>(valueOverDistance, name: "valueOverDistance");
			valueOverSpeed = s.SerializeObject<Spline>(valueOverSpeed, name: "valueOverSpeed");
			valueOverAcceleration = s.SerializeObject<Spline>(valueOverAcceleration, name: "valueOverAcceleration");
			valueOverTime = s.SerializeObject<Spline>(valueOverTime, name: "valueOverTime");
		}
		public override uint? ClassCRC => 0xF8EF1527;
	}
}

