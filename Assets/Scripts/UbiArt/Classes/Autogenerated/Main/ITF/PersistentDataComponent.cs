using UnityEngine;

namespace UbiArt.ITF {
	public partial class PersistentDataComponent : ActorComponent {
		[Serialize("i32Map"    )] public CMap<StringID, int> i32Map;
		[Serialize("f32Map"    )] public CMap<StringID, float> f32Map;
		[Serialize("string8Map")] public CMap<StringID, string> string8Map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(i32Map));
			SerializeField(s, nameof(f32Map));
			SerializeField(s, nameof(string8Map));
		}
		public override uint? ClassCRC => 0xDF1A0961;
	}
}

