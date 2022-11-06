using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class PersistentDataComponent : ActorComponent {
		public CMap<StringID, int> i32Map;
		public CMap<StringID, float> f32Map;
		public CMap<StringID, string> string8Map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			i32Map = s.SerializeObject<CMap<StringID, int>>(i32Map, name: "i32Map");
			f32Map = s.SerializeObject<CMap<StringID, float>>(f32Map, name: "f32Map");
			string8Map = s.SerializeObject<CMap<StringID, string>>(string8Map, name: "string8Map");
		}
		public override uint? ClassCRC => 0xDF1A0961;
	}
}

