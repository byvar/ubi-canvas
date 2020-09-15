using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ZAction : CSerializable {
		public StringID name;
		public bool inverted;
		public float scale;
		public CList<ZInput> input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			inverted = s.Serialize<bool>(inverted, name: "inverted");
			scale = s.Serialize<float>(scale, name: "scale");
			input = s.SerializeObject<CList<ZInput>>(input, name: "input");
		}
	}
}

