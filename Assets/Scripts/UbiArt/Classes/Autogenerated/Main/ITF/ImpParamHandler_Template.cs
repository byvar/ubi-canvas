using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ImpParamHandler_Template : CSerializable {
		[Serialize("list")] public CList<ImpParamHandler_Template.ImpParamData> list;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(list));
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class ImpParamData : CSerializable {
			[Serialize("name" )] public StringID name;
			[Serialize("value")] public string value;
			[Serialize("type" )] public uint type;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
			}
		}
	}
}

