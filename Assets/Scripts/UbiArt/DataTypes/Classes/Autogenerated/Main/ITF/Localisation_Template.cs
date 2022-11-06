using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Localisation_Template : CSerializable {
		[Description("Moods")]
		public Placeholder moods;
		[Description("Actor paths")]
		public Placeholder actors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			moods = s.SerializeObject<Placeholder>(moods, name: "moods");
			actors = s.SerializeObject<Placeholder>(actors, name: "actors");
		}
		public override uint? ClassCRC => 0x4DBF16AB;
	}
}

