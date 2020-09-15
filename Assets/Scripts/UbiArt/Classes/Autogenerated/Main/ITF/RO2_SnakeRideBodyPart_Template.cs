using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeRideBodyPart_Template : RO2_SnakeBodyPartAmv_Template {
		public StringID animTickle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animTickle = s.SerializeObject<StringID>(animTickle, name: "animTickle");
		}
		public override uint? ClassCRC => 0xA02799E6;
	}
}

