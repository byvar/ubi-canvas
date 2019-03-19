using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionStunned_Template : CSerializable {
		[Serialize("name"                )] public StringID name;
		[Serialize("anim"                )] public StringID anim;
		[Serialize("stunDuration"        )] public float stunDuration;
		[Serialize("minStunDuration"     )] public float minStunDuration;
		[Serialize("postStunDuration"    )] public float postStunDuration;
		[Serialize("minTimeBetween2Stuns")] public float minTimeBetween2Stuns;
		[Serialize("secondStunThreshold" )] public float secondStunThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(stunDuration));
			SerializeField(s, nameof(minStunDuration));
			SerializeField(s, nameof(postStunDuration));
			SerializeField(s, nameof(minTimeBetween2Stuns));
			SerializeField(s, nameof(secondStunThreshold));
		}
		public override uint? ClassCRC => 0xC367087F;
	}
}

