using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossMorayAIComponent : Ray_SnakeAIComponent {
		[Serialize("sequences"     )] public CList<Ray_BossMorayAIComponent.Sequence> sequences;
		[Serialize("finalCinematic")] public ObjectPath finalCinematic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(sequences));
				SerializeField(s, nameof(finalCinematic));
			}
		}
		[Games(GameFlags.RFR)]
		public partial class Sequence : CSerializable {
			[Serialize("StringID__0"         )] public StringID StringID__0;
			[Serialize("StringID__1"         )] public StringID StringID__1;
			[Serialize("ObjectPath__2"       )] public ObjectPath ObjectPath__2;
			[Serialize("ObjectPath__3"       )] public ObjectPath ObjectPath__3;
			[Serialize("CList<ObjectPath>__4")] public CList<ObjectPath> CList_ObjectPath__4;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(ObjectPath__2));
				SerializeField(s, nameof(ObjectPath__3));
				SerializeField(s, nameof(CList_ObjectPath__4));
			}
		}
		public override uint? ClassCRC => 0x79F06CB0;
	}
}

