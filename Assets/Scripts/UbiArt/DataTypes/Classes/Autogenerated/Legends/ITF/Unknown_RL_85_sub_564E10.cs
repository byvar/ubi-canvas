using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_85_sub_564E10 : CSerializable {
		public bool is2D;
		public float showingFadeDuration;
		public float hidingFadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			is2D = s.Serialize<bool>(is2D, name: "is2D", options: CSerializerObject.Options.BoolAsByte);
			showingFadeDuration = s.Serialize<float>(showingFadeDuration, name: "showingFadeDuration");
			hidingFadeDuration = s.Serialize<float>(hidingFadeDuration, name: "hidingFadeDuration");
		}
		public override uint? ClassCRC => 0x3ACB8EAC;
	}
}

