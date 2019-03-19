using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTActionDash_Template : BTAction_Template {
		[Serialize("animAnticip"         )] public StringID animAnticip;
		[Serialize("animDash"            )] public StringID animDash;
		[Serialize("animEndDash"         )] public StringID animEndDash;
		[Serialize("animDashSuccess"     )] public StringID animDashSuccess;
		[Serialize("animHitWall"         )] public StringID animHitWall;
		[Serialize("animPullSword"       )] public StringID animPullSword;
		[Serialize("animPullSwordToStand")] public StringID animPullSwordToStand;
		[Serialize("animHoleStop"        )] public StringID animHoleStop;
		[Serialize("distMaxCharge"       )] public float distMaxCharge;
		[Serialize("timeTired"           )] public float timeTired;
		[Serialize("timeAnticip"         )] public float timeAnticip;
		[Serialize("timePullSword"       )] public float timePullSword;
		[Serialize("dashEfficiency"      )] public Spline dashEfficiency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animAnticip));
			SerializeField(s, nameof(animDash));
			SerializeField(s, nameof(animEndDash));
			SerializeField(s, nameof(animDashSuccess));
			SerializeField(s, nameof(animHitWall));
			SerializeField(s, nameof(animPullSword));
			SerializeField(s, nameof(animPullSwordToStand));
			SerializeField(s, nameof(animHoleStop));
			SerializeField(s, nameof(distMaxCharge));
			SerializeField(s, nameof(timeTired));
			SerializeField(s, nameof(timeAnticip));
			SerializeField(s, nameof(timePullSword));
			SerializeField(s, nameof(dashEfficiency));
		}
		public override uint? ClassCRC => 0xCE1C0FF4;
	}
}

