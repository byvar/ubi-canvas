using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_409_sub_B5D520 : CSerializable {
		[Serialize("toctocRumbleName")] public StringID toctocRumbleName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(toctocRumbleName));
		}
		public override uint? ClassCRC => 0xBD94FF75;
	}
}

