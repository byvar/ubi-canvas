using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ValueSorter : ActorComponent {
		[Serialize("float__0"                                        )] public float float__0;
		[Serialize("float__1"                                        )] public float float__1;
		[Serialize("CArray<W1W_ValueSorter.Range>__2"                )] public CArray<W1W_ValueSorter.Range> CArray_W1W_ValueSorter_Range__2;
		[Serialize("CArray<W1W_ValueSorter.EventsListWithLinkTag>__3")] public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__3;
		[Serialize("CArray<W1W_ValueSorter.EventsListWithLinkTag>__4")] public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(CArray_W1W_ValueSorter_Range__2));
			SerializeField(s, nameof(CArray_W1W_ValueSorter_EventsListWithLinkTag__3));
			SerializeField(s, nameof(CArray_W1W_ValueSorter_EventsListWithLinkTag__4));
		}
		[Games(GameFlags.VH)]
		public partial class EventsListWithLinkTag : CSerializable {
			[Serialize("CArray<Generic<Event>>__0")] public CArray<Generic<Event>> CArray_Generic_Event__0;
			[Serialize("StringID__1"              )] public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(CArray_Generic_Event__0));
				SerializeField(s, nameof(StringID__1));
			}
		}
		[Games(GameFlags.VH)]
		public partial class Range : CSerializable {
			[Serialize("float__0"                                        )] public float float__0;
			[Serialize("float__1"                                        )] public float float__1;
			[Serialize("CArray<W1W_ValueSorter.EventsListWithLinkTag>__2")] public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__2;
			[Serialize("CArray<W1W_ValueSorter.EventsListWithLinkTag>__3")] public CArray<W1W_ValueSorter.EventsListWithLinkTag> CArray_W1W_ValueSorter_EventsListWithLinkTag__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(CArray_W1W_ValueSorter_EventsListWithLinkTag__2));
				SerializeField(s, nameof(CArray_W1W_ValueSorter_EventsListWithLinkTag__3));
			}
		}
		public override uint? ClassCRC => 0xE96BBDDE;
	}
}

