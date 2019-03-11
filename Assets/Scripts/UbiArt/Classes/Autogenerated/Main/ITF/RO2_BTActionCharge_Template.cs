using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionCharge_Template : BTAction_Template {
		[Serialize("animAnticip"  )] public StringID animAnticip;
		[Serialize("animRun"      )] public StringID animRun;
		[Serialize("animEndRun"   )] public StringID animEndRun;
		[Serialize("animHitWall"  )] public StringID animHitWall;
		[Serialize("animHoleStop" )] public StringID animHoleStop;
		[Serialize("distMaxCharge")] public float distMaxCharge;
		[Serialize("timePatinage" )] public float timePatinage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animAnticip));
			SerializeField(s, nameof(animRun));
			SerializeField(s, nameof(animEndRun));
			SerializeField(s, nameof(animHitWall));
			SerializeField(s, nameof(animHoleStop));
			SerializeField(s, nameof(distMaxCharge));
			SerializeField(s, nameof(timePatinage));
		}
		public override uint? ClassCRC => 0x31AC41DC;
	}
}

