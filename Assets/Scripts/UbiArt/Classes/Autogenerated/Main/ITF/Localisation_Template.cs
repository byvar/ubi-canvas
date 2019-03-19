using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Localisation_Template : CSerializable {
		[Description("Moods")]
		[Serialize("moods" )] public Placeholder moods;
		[Description("Actor paths")]
		[Serialize("actors")] public Placeholder actors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(moods));
			SerializeField(s, nameof(actors));
		}
		public override uint? ClassCRC => 0xDF7C3ACF;
	}
}

