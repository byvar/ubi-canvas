using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_7_sub_38B040 : CSerializable {
		[Serialize("name"         )] public StringID name;
		[Serialize("activate"     )] public bool activate;
		[Serialize("buslist"      )] public Placeholder buslist;
		[Serialize("factor"       )] public float factor;
		[Serialize("aux"          )] public uint aux;
		[Serialize("reverbParams" )] public Placeholder reverbParams;
		[Serialize("blendDuration")] public float blendDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(activate));
			SerializeField(s, nameof(buslist));
			SerializeField(s, nameof(factor));
			SerializeField(s, nameof(aux));
			SerializeField(s, nameof(reverbParams));
			SerializeField(s, nameof(blendDuration));
		}
		public override uint? ClassCRC => 0xAC4D988E;
	}
}

