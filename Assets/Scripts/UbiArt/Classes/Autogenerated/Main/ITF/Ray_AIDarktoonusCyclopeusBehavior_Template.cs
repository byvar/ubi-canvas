using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIDarktoonusCyclopeusBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"               )] public Placeholder idle;
		[Serialize("prepareFocus"       )] public Placeholder prepareFocus;
		[Serialize("focus"              )] public Placeholder focus;
		[Serialize("attack"             )] public Placeholder attack;
		[Serialize("waitHit"            )] public Placeholder waitHit;
		[Serialize("distanceDetect"     )] public float distanceDetect;
		[Serialize("angleMaxDetect"     )] public Angle angleMaxDetect;
		[Serialize("countDownAttack"    )] public float countDownAttack;
		[Serialize("speed"              )] public float speed;
		[Serialize("speedBack"          )] public float speedBack;
		[Serialize("timeWaiting"        )] public float timeWaiting;
		[Serialize("timeFocus"          )] public float timeFocus;
		[Serialize("mustBeStickToAttack")] public int mustBeStickToAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(prepareFocus));
			SerializeField(s, nameof(focus));
			SerializeField(s, nameof(attack));
			SerializeField(s, nameof(waitHit));
			SerializeField(s, nameof(distanceDetect));
			SerializeField(s, nameof(angleMaxDetect));
			SerializeField(s, nameof(countDownAttack));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(speedBack));
			SerializeField(s, nameof(timeWaiting));
			SerializeField(s, nameof(timeFocus));
			SerializeField(s, nameof(mustBeStickToAttack));
		}
		public override uint? ClassCRC => 0x24D2B959;
	}
}

