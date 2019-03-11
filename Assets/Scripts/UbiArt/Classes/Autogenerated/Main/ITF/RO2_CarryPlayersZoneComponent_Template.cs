using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CarryPlayersZoneComponent_Template : ActorComponent_Template {
		[Serialize("regionID"                         )] public StringID regionID;
		[Serialize("carryMinParticulePercent"         )] public float carryMinParticulePercent;
		[Serialize("leaveMinCollidingParticulePercent")] public float leaveMinCollidingParticulePercent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(regionID));
			SerializeField(s, nameof(carryMinParticulePercent));
			SerializeField(s, nameof(leaveMinCollidingParticulePercent));
		}
		public override uint? ClassCRC => 0x2527120E;
	}
}

