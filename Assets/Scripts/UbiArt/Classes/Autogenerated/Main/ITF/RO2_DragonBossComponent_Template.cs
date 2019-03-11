using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DragonBossComponent_Template : ActorComponent_Template {
		[Serialize("breathBone"    )] public StringID breathBone;
		[Serialize("breathLength"  )] public float breathLength;
		[Serialize("breathWidth"   )] public float breathWidth;
		[Serialize("flameFx"       )] public Path flameFx;
		[Serialize("hurtDelay"     )] public float hurtDelay;
		[Serialize("genericEventId")] public StringID genericEventId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(breathBone));
			SerializeField(s, nameof(breathLength));
			SerializeField(s, nameof(breathWidth));
			SerializeField(s, nameof(flameFx));
			SerializeField(s, nameof(hurtDelay));
			SerializeField(s, nameof(genericEventId));
		}
		public override uint? ClassCRC => 0xC42ECEF9;
	}
}

