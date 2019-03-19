using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_85_sub_564E10 : CSerializable {
		[Serialize("is2D"               )] public bool is2D;
		[Serialize("showingFadeDuration")] public float showingFadeDuration;
		[Serialize("hidingFadeDuration" )] public float hidingFadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(is2D), boolAsByte: true);
			SerializeField(s, nameof(showingFadeDuration));
			SerializeField(s, nameof(hidingFadeDuration));
		}
		public override uint? ClassCRC => 0x3ACB8EAC;
	}
}

