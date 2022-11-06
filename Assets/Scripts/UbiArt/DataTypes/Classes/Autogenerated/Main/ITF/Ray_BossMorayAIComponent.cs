using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BossMorayAIComponent : Ray_SnakeAIComponent {
		public CListO<Ray_BossMorayAIComponent.Sequence> sequences;
		public ObjectPath finalCinematic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				sequences = s.SerializeObject<CListO<Ray_BossMorayAIComponent.Sequence>>(sequences, name: "sequences");
				finalCinematic = s.SerializeObject<ObjectPath>(finalCinematic, name: "finalCinematic");
			}
		}
		[Games(GameFlags.RFR)]
		public partial class Sequence : CSerializable {
			public StringID StringID__0;
			public StringID StringID__1;
			public ObjectPath ObjectPath__2;
			public ObjectPath ObjectPath__3;
			public CListO<ObjectPath> CList_ObjectPath__4;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				ObjectPath__2 = s.SerializeObject<ObjectPath>(ObjectPath__2, name: "ObjectPath__2");
				ObjectPath__3 = s.SerializeObject<ObjectPath>(ObjectPath__3, name: "ObjectPath__3");
				CList_ObjectPath__4 = s.SerializeObject<CListO<ObjectPath>>(CList_ObjectPath__4, name: "CList<ObjectPath>__4");
			}
		}
		public override uint? ClassCRC => 0x79F06CB0;
	}
}

