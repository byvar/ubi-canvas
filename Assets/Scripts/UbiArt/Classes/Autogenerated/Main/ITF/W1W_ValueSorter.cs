using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ValueSorter : ActorComponent {
		public float float__0;
		public float float__1;
		public CArray<W1W_ValueSorter.Range> CArray_W1W_ValueSorter_Range__2;
		public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__3;
		public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			CArray_W1W_ValueSorter_Range__2 = s.SerializeObject<CArray<W1W_ValueSorter.Range>>(CArray_W1W_ValueSorter_Range__2, name: "CArray_W1W_ValueSorter_Range__2");
			CArray_W1W_ValueSorter_EventsListWithLinkTag__3 = s.SerializeObject<CArray<W1W_ValueSorter.EventsListWithLinkTag>>(CArray_W1W_ValueSorter_EventsListWithLinkTag__3, name: "CArray_W1W_ValueSorter_EventsListWithLinkTag__3");
			CArray_W1W_ValueSorter_EventsListWithLinkTag__4 = s.SerializeObject<CArray<W1W_ValueSorter.EventsListWithLinkTag>>(CArray_W1W_ValueSorter_EventsListWithLinkTag__4, name: "CArray_W1W_ValueSorter_EventsListWithLinkTag__4");
		}
		[Games(GameFlags.VH)]
		public partial class EventsListWithLinkTag : CSerializable {
			public CArray<Generic<Event>> CArray_Generic_Event__0;
			public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				CArray_Generic_Event__0 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__0, name: "CArray_Generic_Event__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			}
		}
		[Games(GameFlags.VH)]
		public partial class Range : CSerializable {
			public float float__0;
			public float float__1;
			public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__2;
			public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				CArray_W1W_ValueSorter_EventsListWithLinkTag__2 = s.SerializeObject<CArray<W1W_ValueSorter.EventsListWithLinkTag>>(CArray_W1W_ValueSorter_EventsListWithLinkTag__2, name: "CArray_W1W_ValueSorter_EventsListWithLinkTag__2");
				CArray_W1W_ValueSorter_EventsListWithLinkTag__3 = s.SerializeObject<CArray<W1W_ValueSorter.EventsListWithLinkTag>>(CArray_W1W_ValueSorter_EventsListWithLinkTag__3, name: "CArray_W1W_ValueSorter_EventsListWithLinkTag__3");
			}
		}
		public override uint? ClassCRC => 0xE96BBDDE;
	}
}

