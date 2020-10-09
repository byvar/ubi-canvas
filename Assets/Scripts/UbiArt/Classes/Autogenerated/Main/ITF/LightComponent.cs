using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class LightComponent : ActorComponent {
		public int useOnActor;
		public int useOnFrize;
		public int useBV;
		public float alpha;
		public float red;
		public float green;
		public float blue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				useOnActor = s.Serialize<int>(useOnActor, name: "useOnActor");
				useOnFrize = s.Serialize<int>(useOnFrize, name: "useOnFrize");
				useBV = s.Serialize<int>(useBV, name: "useBV");
				alpha = s.Serialize<float>(alpha, name: "alpha");
				red = s.Serialize<float>(red, name: "red");
				green = s.Serialize<float>(green, name: "green");
				blue = s.Serialize<float>(blue, name: "blue");
			}
		}
		public override uint? ClassCRC => 0x89DA5668;
	}
}

