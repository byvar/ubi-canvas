using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_177_sub_768C60 : CSerializable {
		[Serialize("costumePainting")] public Path costumePainting;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumePainting));
		}
		public override uint? ClassCRC => 0x0E10C15E;
	}
}

