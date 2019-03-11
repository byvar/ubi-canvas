using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventStats : Event {
		[Serialize("Data")] public CMap<string, string> Data;
		[Serialize("Name")] public string Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Data));
			SerializeField(s, nameof(Name));
		}
		public override uint? ClassCRC => 0x3B5D3CF1;
	}
}

