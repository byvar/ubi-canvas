using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchSpawn : Event {
		public Enum_VH_0 Enum_VH_0__0;
		public ushort ushort__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public StringID StringID__5;
		public string string__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			ushort__1 = s.Serialize<ushort>(ushort__1, name: "ushort__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			StringID__5 = s.SerializeObject<StringID>(StringID__5, name: "StringID__5");
			string__6 = s.Serialize<string>(string__6, name: "string__6");
		}
		public enum Enum_VH_0 {
			[Serialize("Gameplay")] Gameplay = 0,
			[Serialize("Decor"   )] Decor = 1,
		}
		public override uint? ClassCRC => 0x27AF0B8A;
	}
}

