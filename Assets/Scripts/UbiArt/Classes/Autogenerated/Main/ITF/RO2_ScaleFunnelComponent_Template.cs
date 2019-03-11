using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScaleFunnelComponent_Template : ActorComponent_Template {
		[Serialize("scale"       )] public float scale;
		[Serialize("suckMinTime" )] public float suckMinTime;
		[Serialize("suckMaxTime" )] public float suckMaxTime;
		[Serialize("suckMaxSpeed")] public float suckMaxSpeed;
		[Serialize("exitDistance")] public float exitDistance;
		[Serialize("enterRegion" )] public StringID enterRegion;
		[Serialize("enterPoint"  )] public StringID enterPoint;
		[Serialize("exitPoint"   )] public StringID exitPoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(suckMinTime));
			SerializeField(s, nameof(suckMaxTime));
			SerializeField(s, nameof(suckMaxSpeed));
			SerializeField(s, nameof(exitDistance));
			SerializeField(s, nameof(enterRegion));
			SerializeField(s, nameof(enterPoint));
			SerializeField(s, nameof(exitPoint));
		}
		public override uint? ClassCRC => 0xC906E14F;
	}
}

